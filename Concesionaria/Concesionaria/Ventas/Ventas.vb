Imports System.Data.Odbc

Public Class frmVenta

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnPresupuesto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPresupuesto.Click
        Me.Close()
        frmPres.Show()
    End Sub

    Private Sub btnCons_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCons.Click
        Me.Close()
        frmConsCP.Show()
    End Sub

    Private Sub btnCreditos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreditos.Click
        Me.Close()
        frmCre.Show()
    End Sub
End Class
