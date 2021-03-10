Public Class ComboBoxObjectForBrowseData
    'This class stores objects with the chart name and the corresponding chart XElement

    Public ChartName As String
    Public ChartXElement As XElement

    Public Sub New(ByVal Name As String, ByVal ChartXMLElement As XElement)
        ChartName = Name
        ChartXElement = ChartXMLElement
    End Sub

    Public Overrides Function ToString() As String
        Return ChartName
    End Function

End Class
