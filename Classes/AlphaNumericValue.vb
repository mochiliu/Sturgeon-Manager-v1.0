'This class associates a number with the corresponding alphabet letter. Used to prepresent caviar boxes
Public Class AlphaNumericValue
    Public Value As Integer

    Public Sub New(ByVal myvalue As Integer)
        Value = myvalue
    End Sub

    Public Overrides Function ToString() As String
        Select Case Value
            Case 0 To 51
                ToString = Convert.ToChar(Convert.ToInt32("A"c) + Value).ToString()
            Case Else
                ToString = String.Empty
        End Select
    End Function

    Public Shared Function StringToValue(ByVal obj As Object) As Integer
        If obj.ToString <> "" Then
            Return Asc(obj.ToString(0)) - 65 'return the first letter's value
        Else
            Return 0
        End If
    End Function
End Class
