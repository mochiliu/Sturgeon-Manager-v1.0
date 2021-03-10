'This class sets the application's cursor to "wait". Used for time consuming operations
Imports System.Windows.Forms

Public Class WaitCursor
    Implements IDisposable
    Public Sub New()
        Enabled = True
    End Sub
    Public Sub Dispose() Implements IDisposable.Dispose
        Enabled = False
    End Sub
    Public Shared Property Enabled() As Boolean
        Get
            Return Application.UseWaitCursor
        End Get
        Set(ByVal value As Boolean)
            If value = Application.UseWaitCursor Then
                Return
            End If
            Application.UseWaitCursor = value
            Dim f As Form = Form.ActiveForm
            If Not IsNothing(f) AndAlso Not (f.Handle = vbNull) Then
                ' Send WM_SETCURSOR
                SendMessage(f.Handle, &H20, f.Handle, CType(1, IntPtr))
            End If
        End Set
    End Property
    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr
    End Function
End Class
