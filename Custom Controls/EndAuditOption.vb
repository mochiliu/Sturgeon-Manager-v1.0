Public Class EndAuditOption

    Private Sub EndAuditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndAuditButton.Click
        CaviarInventoryAudit.myEndAuditOption = CaviarInventoryAudit.EndAuditOptions.EndAudit
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        CaviarInventoryAudit.myEndAuditOption = CaviarInventoryAudit.EndAuditOptions.CancelEndAudit
        Me.Close()
    End Sub

    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        CaviarInventoryAudit.myEndAuditOption = CaviarInventoryAudit.EndAuditOptions.QuitAudit
        Me.Close()
    End Sub
End Class