'This class stores objects with the original column name and the column name displayed to the user
Public Class ComboBoxObjectForFilter
    Public OriginalColumnName As String
    Public DisplayedColumnName As String

    Public Sub New(ByVal OriginalName As String, ByVal DisplayName As String)
        OriginalColumnName = OriginalName
        If DisplayName = "" Then
            DisplayedColumnName = OriginalColumnName
        Else
            DisplayedColumnName = DisplayName.ToString
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return DisplayedColumnName
    End Function
End Class
