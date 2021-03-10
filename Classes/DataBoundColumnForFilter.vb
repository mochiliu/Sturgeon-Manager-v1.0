'This class is written to support databinding for filtering: displaying the information in comboboxes for fields like Grade, Inventory Status, etc
Public Class DataBoundColumnForFilter
    Public ColumnName As String
    Public DataSource As DataTable
    Public ValueMemberColumn As String
    Public DisplayMemberColumn As String
    'Public Visible As Boolean 'Display Column. A column can be selected to not be filtered by setting this to false

    Public Sub New(ByVal C_Name As String, ByRef D_Source As DataTable, ByVal V_Member As String, ByVal D_Member As String)
        ColumnName = C_Name
        DataSource = D_Source
        ValueMemberColumn = V_Member
        DisplayMemberColumn = D_Member
        'Visible = Vis
    End Sub
End Class
