Public Class frmPres
    Private Sub btnEmi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmi.Click
        Me.Close()
        frmEmi.Show()
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Me.Close()
        frmConsRes.Show()
    End Sub

    Private Sub btnVol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVol.Click
        frmVenta.Show()
        Me.Close()
    End Sub
End Class