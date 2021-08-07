Imports System.Data.Odbc

Public Class frmMenu
    Private Sub frmMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            cnn = New OdbcConnection("DSN=BDCons")
            cnn.Open()
        Catch ex As Exception
            MsgBox("Falla en la conexion")
        End Try
    End Sub

    Private Sub btnVentaA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVentaA.Click
        Me.Hide()
        frmVenta.Show()
    End Sub
End Class