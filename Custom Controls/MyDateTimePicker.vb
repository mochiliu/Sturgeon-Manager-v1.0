
'This Control is extends the DateTimePicker to allow changes in the background color in XP themed computers
Imports System
Imports System.Windows.Forms
Namespace Controls
    Public Class MyDateTimePicker
        Inherits DateTimePicker
        Private _BackColor As Color = SystemColors.Window

        Public Sub New()
            MyBase.New()
            'Me.Format = DateTimePickerFormat.Short
            Me.Width = 88
            Me.FontHeight = 25
            Me.BackColor = Color.White
        End Sub

        Public Overrides Property BackColor() As Color
            Get
                Return _BackColor
            End Get
            Set(ByVal Value As Color)
                _BackColor = Value
                Invalidate()
            End Set
        End Property

        Protected Overrides Sub WndProc(ByRef m As Message)
            If m.Msg = CInt(&H14) Then ' WM_ERASEBKGND 
                Dim g As Graphics = Graphics.FromHdc(m.WParam)
                g.FillRectangle(New SolidBrush(_BackColor), ClientRectangle)
                g.Dispose()
                Return
            End If
            MyBase.WndProc(m)
        End Sub

        Private Sub MyBaseKeyDown(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            Select Case e.KeyCode
                Case Keys.Enter
                    SendKeys.Send("{TAB}") 'move to the next control
            End Select
        End Sub
    End Class
End Namespace
