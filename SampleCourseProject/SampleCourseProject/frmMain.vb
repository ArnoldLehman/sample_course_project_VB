Public Class frmMain

    Private Sub cmdBookkeeping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBookkeeping.Click
        frmBookkeeping.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmRegistrationPersonal.Show()
        Me.Close()
    End Sub
End Class