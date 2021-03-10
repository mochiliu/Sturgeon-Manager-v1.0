'This Custom TextBox control processes certain user keys as tab actions

Public Class TabTextBox
    Inherits System.Windows.Forms.TextBox

    Private Sub MyBaseKeyDown(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send("{TAB}") 'move to the next control
            Case Keys.Down
                SendKeys.Send("{TAB}") 'move to the next control
            Case Keys.Up
                SendKeys.Send("+{TAB}") 'move to the previous control
        End Select
    End Sub

End Class