'This is a combobox that automatically adjusts the dropdown width depending on the items it contains


Namespace Controls

    Public Class AutoDropDownWidthComboBox
        Inherits ComboBox


        Protected Overrides Sub OnDropDown(ByVal e As System.EventArgs)
            Dim width As Integer = Me.DropDownWidth
            Dim g As Graphics = Me.CreateGraphics()
            Dim font As Font = Me.Font
            Dim vertScrollBarWidth As Integer = If((Me.Items.Count > Me.MaxDropDownItems), SystemInformation.VerticalScrollBarWidth, 0)
            Dim newWidth As Integer
            For Each item As Object In Me.Items
                ' instead of treating an item as a string, treat it as an object and use GetItemText to fetch the item's textvalue
                Dim s As String = Me.GetItemText(item)
                newWidth = CInt(g.MeasureString(s, font).Width) + vertScrollBarWidth
                If width < newWidth Then
                    width = newWidth
                End If
            Next
            Me.DropDownWidth = width
            MyBase.OnDropDown(e)
        End Sub

        Private Sub MyBaseKeyDown(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            Select Case e.KeyCode
                Case Keys.Enter
                    SendKeys.Send("{TAB}") 'move to the next control
            End Select
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
            MyBase.OnMouseEnter(e)
            Me.Focus()
            Me.DroppedDown = True
        End Sub

    End Class
End Namespace