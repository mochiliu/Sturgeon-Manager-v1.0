Imports System.Text.RegularExpressions

'This Class allows the user to edit and view customers, navigating using a bindingnavigator
Public Class Customer
    Public myFilter As Filter
    Public isReadOnly As Boolean = False
    Public ShowDialogOption As ShowDialogOptions = ShowDialogOptions.NoAction
    Public DefaultRecordID As Integer = -1
    Public isAddingNew As Boolean = False 'if new customer is pressed
    Public SavedAtLeastOnce As Boolean = False 'if customer has been saved at least once
    Public myAdressrecommendation As AddressRecommendation = New AddressRecommendation

    Public Enum ShowDialogOptions As Integer
        NoAction = 0
        AddNewCustomer = 1
        AddNewBillingAddress = 2
        AddNewShippingAddress = 3
    End Enum

#Region "Form events"
    Private Sub Customer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myFilter.Close()
    End Sub

    Private Sub Customer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isReadOnly Then
            Exit Sub
        End If
        Select Case MsgBox("Save the data entered?", MsgBoxStyle.YesNoCancel)
            Case vbYes 'Save
                CustomersBindingNavigatorSaveItem_Click(Nothing, Nothing)
            Case vbCancel
                e.Cancel = True
            Case Else 'do not save but prompt user that database was saved already
                If SavedAtLeastOnce And isAddingNew AndAlso MsgBox("The Customer part of the record has already been saved. You must or Choose NO, and Use the Red X’s to delete any ADDRESS, or CUSTOMER data OR Choose YES To exit and leave the saved CUSTOMER data in place.", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    e.Cancel = True
                End If
                Exit Sub
        End Select
        If isAddingNew Then 'the form is activated given the user wants to add a new customer, so go to pricing
            Dim newPricingForm As New Pricing With {.DefaultRecordID = DefaultRecordID}
            newPricingForm.ShowDialog()
            newPricingForm.Dispose()
        End If
    End Sub
    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Shipping_Addresses' table. You can move, or remove it, as needed.
        Me.Shipping_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Shipping_Addresses)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Billing_Addresses' table. You can move, or remove it, as needed.
        Me.Billing_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Billing_Addresses)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)

        myFilter = New Filter(Me, CustomersBindingSource)
        Me.Cursor = Cursors.Default
        myAdressrecommendation.ParentWindow = Me


        Select Case ShowDialogOption
            Case ShowDialogOptions.NoAction
                Exit Sub
            Case ShowDialogOptions.AddNewCustomer
                CustomersBindingSource.AddNew()
                isAddingNew = True
            Case ShowDialogOptions.AddNewBillingAddress
                Dim index = 0
                For Each CustomerRow As DataRowView In CustomersBindingSource.List
                    If CustomerRow("PKCustomerID") = DefaultRecordID Then
                        CustomersBindingSource.Position = index
                        Billing_AddressesBindingSource.AddNew()
                        Exit Select
                    End If
                    index += 1
                Next
                MsgBox("Cannot Find Customer!")
            Case ShowDialogOptions.AddNewShippingAddress
                Dim index = 0
                For Each CustomerRow As DataRowView In CustomersBindingSource.List
                    If CustomerRow("PKCustomerID") = DefaultRecordID Then
                        CustomersBindingSource.Position = index
                        Shipping_AddressesBindingSource.AddNew()
                        Exit Select
                    End If
                    index += 1
                Next
                MsgBox("Cannot Find Customer!")
        End Select
        SavedAtLeastOnce = False
    End Sub
#End Region

#Region "Saving"
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        If Save() Then 'save when a new record is added
            CustomersBindingSource.AddNew()
        End If
    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Save()
    End Sub
    Private Sub BindingNavigatorMoveNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveNextItem.Click
        If Save() Then
            CustomersBindingSource.MoveNext()
        End If
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveLastItem.Click
        If Save() Then
            CustomersBindingSource.MoveLast()
        End If
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        If Save() Then
            CustomersBindingSource.MovePrevious()
        End If
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        If Save() Then
            CustomersBindingSource.MoveFirst()
        End If
    End Sub

    Private Function Save(Optional ByVal addingAddresses As Boolean = False) As Boolean
        Using (New WaitCursor)
            Try
                Billing_AddressesBindingSource.AddNew() 'the last item is not saved for some reason, so add a placeholder
                Billing_AddressesBindingSource.RemoveCurrent() 'delete the newly added item
                Shipping_AddressesBindingSource.AddNew() 'the last item is not saved for some reason, so add a placeholder
                Shipping_AddressesBindingSource.RemoveCurrent() 'delete the newly added item
                Me.Validate()
                Me.CustomersBindingSource.EndEdit()
                Me.Billing_AddressesBindingSource.EndEdit()
                Me.Shipping_AddressesBindingSource.EndEdit()

                Dim currentCustomerName As String
                currentCustomerName = Company_NameTextBox.Text
                If Company_NameTextBox.Text = "" Then
                    MsgBox("Company Name is required!")
                    Return False
                End If

                'prompt user if the record does not contain a shipping or a billing address
                If Not addingAddresses Then
                    If Billing_AddressesBindingSource.Count = 0 Or Shipping_AddressesBindingSource.Count = 0 Then
                        Select Case MsgBox("This customer lacks billing or shipping addresses. Countinue?", MsgBoxStyle.YesNo)
                            Case MsgBoxResult.No
                                Return False
                        End Select
                    End If
                End If

                Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet) 'save records

                'refill tables
                Me.Shipping_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Shipping_Addresses)
                Me.Billing_AddressesTableAdapter.Fill(Me.SturgeonDBDataSet.Billing_Addresses)
                Me.CustomersTableAdapter.Fill(Me.SturgeonDBDataSet.Customers)

                'find the same company name in the list and move the position there
                Dim index = 0
                For Each CustomerRow As DataRowView In CustomersBindingSource.List
                    If CustomerRow("Company Name") = currentCustomerName Then
                        DefaultRecordID = CustomerRow("PKCustomerID") 'save where the list is when the user last saved
                        CustomersBindingSource.Position = index
                    End If
                    index += 1
                Next
                SavedAtLeastOnce = True
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
                'CustomersBindingSource.CancelEdit()
            End Try
        End Using
    End Function
#End Region

    'copies the current billing address as a new shipping address
    Private Sub BillingToShippingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingToShippingButton.Click
        Shipping_AddressesBindingSource.AddNew()
        Addr1TextBox1.Text = Addr1TextBox.Text
        Addr2TextBox1.Text = Addr2TextBox.Text
        Addr3TextBox1.Text = Addr3TextBox.Text
        CityTextBox1.Text = CityTextBox.Text
        StateOrProvinceTextBox1.Text = StateOrProvinceTextBox.Text
        PostalCodeTextBox1.Text = PostalCodeTextBox.Text
        Country_RegionTextBox1.Text = Country_RegionTextBox.Text
        PhoneNumberTextBox1.Text = PhoneNumberTextBox.Text
        ExtensionTextBox1.Text = ExtensionTextBox.Text
    End Sub

    Private Sub FilterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterButton.Click
        Save()
        myFilter.Show()
    End Sub

    Public Sub LoadReadOnly()
        isReadOnly = True
        With Me
            .CustomersBindingNavigatorSaveItem.Enabled = False
            .CustomersBindingNavigatorSaveItem.Visible = False
            .BindingNavigatorAddNewItem.Visible = False
            .BindingNavigatorDeleteItem.Visible = False
            .BindingNavigatorAddNewItem1.Visible = False
            .BindingNavigatorDeleteItem1.Visible = False
            .BindingNavigatorAddNewItem2.Visible = False
            .BindingNavigatorDeleteItem2.Visible = False

            .Company_NameTextBox.ReadOnly = True
            .Contact_NameTextBox.ReadOnly = True

            .Addr1TextBox.ReadOnly = True
            .Addr2TextBox.ReadOnly = True
            .Addr3TextBox.ReadOnly = True
            .CityTextBox.ReadOnly = True
            .StateOrProvinceTextBox.ReadOnly = True
            .PostalCodeTextBox.ReadOnly = True
            .Country_RegionTextBox.ReadOnly = True
            .Addr1TextBox1.ReadOnly = True
            .Addr2TextBox1.ReadOnly = True
            .Addr3TextBox1.ReadOnly = True
            .CityTextBox1.ReadOnly = True
            .StateOrProvinceTextBox1.ReadOnly = True
            .PostalCodeTextBox1.ReadOnly = True
            .Country_RegionTextBox1.ReadOnly = True

            .BillingToShippingButton.Enabled = False

            .PhoneNumberTextBox.ReadOnly = True
            .PhoneNumberTextBox1.ReadOnly = True
            .ExtensionTextBox.ReadOnly = True
            .ExtensionTextBox1.ReadOnly = True
            .Fax_NumberTextBox.ReadOnly = True
            .EmailTextBox.ReadOnly = True
            .NotesTextBox.ReadOnly = True

            .Text = "View Customers"
        End With
    End Sub


    Private Sub Billing_AddressesBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles Billing_AddressesBindingSource.ListChanged
        If Billing_AddressesBindingSource.Count = 0 Then 'empty list
            Addr1TextBox.Enabled = False
            Addr2TextBox.Enabled = False
            Addr3TextBox.Enabled = False
            CityTextBox.Enabled = False
            StateOrProvinceTextBox.Enabled = False
            PostalCodeTextBox.Enabled = False
            Country_RegionTextBox.Enabled = False
            BillingToShippingButton.Enabled = False
            BillingAddressCustomerNameTextBox.Text = ""
            PhoneNumberTextBox.Enabled = False
            ExtensionTextBox.Enabled = False
        Else
            Addr1TextBox.Enabled = True
            Addr2TextBox.Enabled = True
            Addr3TextBox.Enabled = True
            CityTextBox.Enabled = True
            StateOrProvinceTextBox.Enabled = True
            PostalCodeTextBox.Enabled = True
            Country_RegionTextBox.Enabled = True
            BillingToShippingButton.Enabled = True
            BillingAddressCustomerNameTextBox.Text = Company_NameTextBox.Text
            PhoneNumberTextBox.Enabled = True
            ExtensionTextBox.Enabled = True
        End If
    End Sub

    Private Sub Shipping_AddressesBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles Shipping_AddressesBindingSource.ListChanged
        If Shipping_AddressesBindingSource.Count = 0 Then 'empty list
            Addr1TextBox1.Enabled = False
            Addr2TextBox1.Enabled = False
            Addr3TextBox1.Enabled = False
            CityTextBox1.Enabled = False
            StateOrProvinceTextBox1.Enabled = False
            PostalCodeTextBox1.Enabled = False
            Country_RegionTextBox1.Enabled = False
            ShippingAddressCustomerNameTextBox.Text = ""
            PhoneNumberTextBox1.Enabled = False
            ExtensionTextBox1.Enabled = False
        Else
            Addr1TextBox1.Enabled = True
            Addr2TextBox1.Enabled = True
            Addr3TextBox1.Enabled = True
            CityTextBox1.Enabled = True
            StateOrProvinceTextBox1.Enabled = True
            PostalCodeTextBox1.Enabled = True
            Country_RegionTextBox1.Enabled = True
            ShippingAddressCustomerNameTextBox.Text = Company_NameTextBox.Text
            PhoneNumberTextBox1.Enabled = True
            ExtensionTextBox1.Enabled = True
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem1.Click
        If Save(True) Then
            Billing_AddressesBindingSource.AddNew()
            Addr1TextBox.Focus()
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem2.Click
        If Save(True) Then
            Shipping_AddressesBindingSource.AddNew()
            Addr1TextBox1.Focus()
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Select Case MsgBox("Delete " & Company_NameTextBox.Text & "?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                CustomersBindingSource.RemoveCurrent()
                Save(True)
        End Select
    End Sub

    Private Sub BindingNavigatorDeleteItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem1.Click
        Select Case MsgBox("Delete " & Addr1TextBox.Text & "?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Billing_AddressesBindingSource.RemoveCurrent()
                Save(True)
        End Select
    End Sub

    Private Sub BindingNavigatorDeleteItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem2.Click
        Select Case MsgBox("Delete " & Addr1TextBox1.Text & "?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Shipping_AddressesBindingSource.RemoveCurrent()
                Save(True)
        End Select
    End Sub

#Region "Text Validataions"
    Private Sub EmailTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles EmailTextBox.Validating
        If ValidateTextFormatFailed(sender, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$", " Email Address") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Fax_NumberTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Fax_NumberTextBox.Validating
        Try
            Fax_NumberTextBox.Text = PhoneFormat(Fax_NumberTextBox.Text)
            If ValidateTextFormatFailed(sender, "^([\(]{1}[0-9]{3}[\)]{1}[ ]{1}[0-9]{3}[\-]{1}[0-9]{4})$", " 10 digit number") Then
                e.Cancel = True
            End If
        Catch ex As Exception
            MsgBox("Unrecognized Phone Format")
            e.Cancel = True
        End Try
    End Sub

    Private Sub CityTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CityTextBox.Validating
        If ValidateTextFormatFailed(sender, "^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$", " alpha characters only") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub CityTextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CityTextBox1.Validating
        If ValidateTextFormatFailed(sender, "^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$", " alpha characters only") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub StateOrProvinceTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles StateOrProvinceTextBox.Validating
        If Country_RegionTextBox.Text = "United States" AndAlso ValidateTextFormatFailed(sender, "^(?-i:A[LKSZRAEP]|C[AOT]|D[EC]|F[LM]|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEHINOPST]|N[CDEHJMVY]|O[HKR]|P[ARW]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])$", " 2 Letter Abbreviations of U.S. States") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub StateOrProvinceTextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles StateOrProvinceTextBox1.Validating
        If Country_RegionTextBox1.Text = "United States" AndAlso ValidateTextFormatFailed(sender, "^(?-i:A[LKSZRAEP]|C[AOT]|D[EC]|F[LM]|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEHINOPST]|N[CDEHJMVY]|O[HKR]|P[ARW]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])$", " 2 Letter Abbreviations of U.S. States") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub PostalCodeTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PostalCodeTextBox.Validating
        If Country_RegionTextBox.Text = "United States" AndAlso ValidateTextFormatFailed(sender, "^\d{5}(?:[-]\d{4})?$", " ##### or #####-####") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub PostalCodeTextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PostalCodeTextBox1.Validating
        If Country_RegionTextBox1.Text = "United States" AndAlso ValidateTextFormatFailed(sender, "^\d{5}(?:[-]\d{4})?$", " ##### or #####-####") Then
            e.Cancel = True
        End If
    End Sub
    Private Sub PhoneNumberTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PhoneNumberTextBox.Validating
        Try
            If Country_RegionTextBox.Text = "United States" Then
                PhoneNumberTextBox.Text = PhoneFormat(PhoneNumberTextBox.Text)
                If ValidateTextFormatFailed(sender, "^([\(]{1}[0-9]{3}[\)]{1}[ ]{1}[0-9]{3}[\-]{1}[0-9]{4})$", " 10 digit number") Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Unrecognized Phone Format")
            e.Cancel = True
        End Try
    End Sub

    Private Sub PhoneNumberTextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PhoneNumberTextBox1.Validating
        Try
            If Country_RegionTextBox1.Text = "United States" Then
                PhoneNumberTextBox1.Text = PhoneFormat(PhoneNumberTextBox1.Text)
                If ValidateTextFormatFailed(sender, "^([\(]{1}[0-9]{3}[\)]{1}[ ]{1}[0-9]{3}[\-]{1}[0-9]{4})$", " 10 digit number") Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Unrecognized Phone Format")
            e.Cancel = True
        End Try
    End Sub
#End Region

    'Display a duplicated Customer Name in the shipping and billing groups
    Private Sub Company_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Company_NameTextBox.TextChanged
        If Billing_AddressesBindingSource.Count > 0 Then 'there are billing address records
            BillingAddressCustomerNameTextBox.Text = Company_NameTextBox.Text
        Else
            BillingAddressCustomerNameTextBox.Text = ""
        End If
        If Shipping_AddressesBindingSource.Count > 0 Then 'there are shipping address records
            ShippingAddressCustomerNameTextBox.Text = Company_NameTextBox.Text
        Else
            ShippingAddressCustomerNameTextBox.Text = ""
        End If
    End Sub

    Private Sub BillingAddressGoogeMapsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingAddressGoogeMapsButton.Click
        myAdressrecommendation.Addr1TextBox.Text = Addr1TextBox.Text
        myAdressrecommendation.Addr2TextBox.Text = Addr2TextBox.Text
        myAdressrecommendation.Addr3TextBox.Text = Addr3TextBox.Text
        myAdressrecommendation.CityTextBox.Text = CityTextBox.Text
        myAdressrecommendation.StateOrProvinceTextBox.Text = StateOrProvinceTextBox.Text
        myAdressrecommendation.PostalCodeTextBox.Text = PostalCodeTextBox.Text
        myAdressrecommendation.Country_RegionTextBox.Text = Country_RegionTextBox.Text
        myAdressrecommendation.BillingOrShipping = "Billing"
        myAdressrecommendation.ClearGoogleAddress()
        myAdressrecommendation.GetGoogleAddress()
        myAdressrecommendation.ShowDialog()
    End Sub

    Private Sub ShippingAddressGoogeMapsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShippingAddressGoogeMapsButton.Click
        myAdressrecommendation.Addr1TextBox.Text = Addr1TextBox1.Text
        myAdressrecommendation.Addr2TextBox.Text = Addr2TextBox1.Text
        myAdressrecommendation.Addr3TextBox.Text = Addr3TextBox1.Text
        myAdressrecommendation.CityTextBox.Text = CityTextBox1.Text
        myAdressrecommendation.StateOrProvinceTextBox.Text = StateOrProvinceTextBox1.Text
        myAdressrecommendation.PostalCodeTextBox.Text = PostalCodeTextBox1.Text
        myAdressrecommendation.Country_RegionTextBox.Text = Country_RegionTextBox1.Text
        myAdressrecommendation.BillingOrShipping = "Shipping"
        myAdressrecommendation.ClearGoogleAddress()
        myAdressrecommendation.GetGoogleAddress()
        myAdressrecommendation.ShowDialog()
    End Sub
End Class