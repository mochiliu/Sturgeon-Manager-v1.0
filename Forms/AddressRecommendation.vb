Public Class AddressRecommendation
    Public BillingOrShipping As String = "Billing" 'default replaces billing address
    Public ParentWindow As Form

    Private Sub AddressRecommendation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub GetGoogleAddress()
        Try
            Dim GMapXML As XDocument
            GMapXML = XDocument.Load(GenerateGoogleMapsURL(Addr1TextBox.Text, Addr2TextBox.Text, Addr3TextBox.Text, CityTextBox.Text, StateOrProvinceTextBox.Text, PostalCodeTextBox.Text, Country_RegionTextBox.Text))
            GoogleURLTextbox.Text = GenerateGoogleMapsURL(Addr1TextBox.Text, Addr2TextBox.Text, Addr3TextBox.Text, CityTextBox.Text, StateOrProvinceTextBox.Text, PostalCodeTextBox.Text, Country_RegionTextBox.Text)
            ClearGoogleAddress()

            If GMapXML.Root.Element("status") = "OK" Then
                Dim mapresult = GMapXML.Root.Element("result")
                Dim formated_address = mapresult.Element("formatted_address").Value
                Dim streetnumber As String = ""
                Dim route As String = ""
                Dim city As String = ""
                Dim state As String = ""
                Dim country As String = ""
                Dim postalcode As String = ""
                Dim subpremise As String = ""
                Dim establishment As String = ""
                For Each address_component In mapresult.Elements("address_component")
                    For Each address_type In address_component.Elements("type")
                        Select Case address_type.Value
                            Case "street_number"
                                streetnumber = address_component.Element("long_name").Value
                            Case "route"
                                route = address_component.Element("long_name").Value
                            Case "locality"
                                city = address_component.Element("long_name").Value
                            Case "administrative_area_level_1"
                                state = address_component.Element("short_name").Value
                            Case "country"
                                country = address_component.Element("long_name").Value
                            Case "postal_code"
                                postalcode = address_component.Element("long_name").Value
                            Case "subpremise"
                                subpremise = address_component.Element("long_name").Value
                            Case "establishment"
                                establishment = address_component.Element("long_name").Value
                            Case Else
                                Continue For
                        End Select
                        Exit For
                    Next
                Next

                GFormattedAddress.Text = formated_address
                If Addr1TextBox.Text.StartsWith(streetnumber) Then
                    'addr1 is not used as attn
                    GAddr1.Text = ""
                Else
                    GAddr1.Text = Addr1TextBox.Text
                End If
                GAddr2.Text = streetnumber & " " & route
                If establishment <> "" Then
                    GAddr3.Text = establishment
                End If
                If subpremise <> "" Then
                    If GAddr3.Text <> "" Then
                        GAddr3.Text = GAddr3.Text & " "
                    End If
                    GAddr3.Text = GAddr3.Text & "Unit " & subpremise
                End If
                GCity.Text = city
                GStateOrProvince.Text = state
                GZip.Text = postalcode
                GCountry.Text = country

                'Dim streetnums = From addresscomponent In mapresult Select mapresult.Element("address_component") Where 
            Else
                GFormattedAddress.Text = GMapXML.Root.Element("status")
            End If
            'Dim USPSXML As XDocument
            'USPSXML = XDocument.Load(GenerateUSPSURL(Addr2TextBox.Text, Addr3TextBox.Text, CityTextBox.Text, StateOrProvinceTextBox.Text, PostalCodeTextBox.Text, Country_RegionTextBox.Text))
            'GoogleURLTextbox.Text = GenerateUSPSURL(Addr2TextBox.Text, Addr3TextBox.Text, CityTextBox.Text, StateOrProvinceTextBox.Text, PostalCodeTextBox.Text, Country_RegionTextBox.Text)
            'MsgBox(USPSXML)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ClearGoogleAddress()
        GAddr1.Text = ""
        GAddr2.Text = ""
        GAddr3.Text = ""
        GCity.Text = ""
        GStateOrProvince.Text = ""
        GZip.Text = ""
        GCountry.Text = ""
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub ReplaceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceButton.Click
        Select Case BillingOrShipping
            Case "Billing"
                DirectCast(ParentWindow, Customer).Addr1TextBox.Text = GAddr1.Text
                DirectCast(ParentWindow, Customer).Addr2TextBox.Text = GAddr2.Text
                DirectCast(ParentWindow, Customer).Addr3TextBox.Text = GAddr3.Text
                DirectCast(ParentWindow, Customer).CityTextBox.Text = GCity.Text
                DirectCast(ParentWindow, Customer).StateOrProvinceTextBox.Text = GStateOrProvince.Text
                DirectCast(ParentWindow, Customer).PostalCodeTextBox.Text = GZip.Text
                DirectCast(ParentWindow, Customer).Country_RegionTextBox.Text = GCountry.Text
            Case "Shipping"
                DirectCast(ParentWindow, Customer).Addr1TextBox1.Text = GAddr1.Text
                DirectCast(ParentWindow, Customer).Addr2TextBox1.Text = GAddr2.Text
                DirectCast(ParentWindow, Customer).Addr3TextBox1.Text = GAddr3.Text
                DirectCast(ParentWindow, Customer).CityTextBox1.Text = GCity.Text
                DirectCast(ParentWindow, Customer).StateOrProvinceTextBox1.Text = GStateOrProvince.Text
                DirectCast(ParentWindow, Customer).PostalCodeTextBox1.Text = GZip.Text
                DirectCast(ParentWindow, Customer).Country_RegionTextBox1.Text = GCountry.Text

        End Select
        Me.Close()
    End Sub
End Class