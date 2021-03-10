
'This form allows the user to modify and view products using a bindingnavigator
Public Class Product
    Public myFilter As Filter
    Public isReadOnly As Boolean = False

#Region "Form Events"
    Private Sub Product_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myFilter.Close()
    End Sub

    Private Sub Product_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If isReadOnly Then
            Exit Sub
        End If
        Select Case MsgBox("Save the data entered?", MsgBoxStyle.YesNoCancel)
            Case vbYes 'Save
                If Not Save() Then
                    e.Cancel = True
                End If
            Case vbCancel
                e.Cancel = True
            Case Else
                'do nothing
        End Select
    End Sub
    Private Sub Products_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.ProductCategorySelection' table. You can move, or remove it, as needed.
        Me.ProductCategorySelectionTableAdapter.Fill(Me.SturgeonDBDataSet.ProductCategorySelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.GradeSelection' table. You can move, or remove it, as needed.
        Me.GradeSelectionTableAdapter.Fill(Me.SturgeonDBDataSet.GradeSelection)
        'TODO: This line of code loads data into the 'SturgeonDBDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)

        myFilter = New Filter(Me, ProductsBindingSource)
    End Sub
#End Region

#Region "Button Events"
    Private Sub ProductsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Save()
    End Sub

    Private Sub FilterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterButton.Click
        Save()
        myFilter.Show()
    End Sub
#End Region

    Public Function Save() As Boolean
        Using (New WaitCursor) 'Load Hourglass
            Dim currentIndex As Integer
            currentIndex = ProductsBindingSource.Position
            Try
                Me.Validate()
                Me.ProductsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SturgeonDBDataSet)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            Me.ProductsTableAdapter.Fill(Me.SturgeonDBDataSet.Products)
            ProductsBindingSource.Position = currentIndex
            Return True
        End Using
    End Function

    Public Sub LoadReadOnly()
        isReadOnly = True
        With Me
            .ProductsBindingNavigatorSaveItem.Enabled = False
            .ProductsBindingNavigatorSaveItem.Visible = False
            .BindingNavigatorAddNewItem.Visible = False
            .BindingNavigatorDeleteItem.Visible = False

            .Product_NameTextBox.ReadOnly = True
            .ProductCategoryComboBox.Enabled = False
            .GradeComboBox.Enabled = False
            .UnitWeightgmsTextBox.ReadOnly = True
            .PriceTextBox.ReadOnly = True
            .DescriptionTextBox.ReadOnly = True

            .Text = "View Products"
        End With
    End Sub

    Private Sub ProductReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductReportButton.Click
        Using New WaitCursor
            ReportViewer.DisplayReport(ReportType.ProductListingReport, myFilter.CrystalReportSelectionFormula)
            ReportViewer.Show()
        End Using
    End Sub
End Class