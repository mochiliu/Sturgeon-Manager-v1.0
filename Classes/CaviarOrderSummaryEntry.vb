'This class stores an entry in the caviar order summary
'A dictionary of the class produces the actual order
Public Class CaviarOrderSummaryEntry
    Public ProductCode As String
    Public UnitWeight As Double
    Public Count As Integer
    Public TotalKgs As Double
    Public PricePerKg As Decimal
    Public PricePerItem As Decimal
    Public TotalPrice As Decimal

    Public Sub New(ByVal PCode As String, ByVal UWeight As Double, ByVal KgPrice As Decimal, Optional ByVal Cnt As Integer = 1)
        ProductCode = PCode
        UnitWeight = UWeight
        Count = Cnt
        PricePerKg = KgPrice
        Recalculate()
    End Sub

    Public Sub Add(Optional ByVal Cnt As Integer = 1)
        Count += Cnt
        Recalculate()
    End Sub

    Public Sub Recalculate()
        If UnitWeight > 0 Then
            TotalKgs = Count * UnitWeight / 1000
            PricePerItem = PricePerKg * UnitWeight / 1000
            TotalPrice = PricePerKg * TotalKgs
        End If
    End Sub
End Class
