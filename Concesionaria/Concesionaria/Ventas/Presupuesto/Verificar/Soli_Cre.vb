Public Class frmSolC

    Private Sub txtSal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSal.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCUIL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCUIL.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnSIg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSIg.Click

        If txtSal.Text <> "" And txtTra.Text <> "" And Len(txtCUIL.Text) = 11 Then

            sql = "Insert into Solicitud_Cre values ('', " & frmConsRes.txtPres.Text & ", '" & txtCUIL.Text & "', '" & txtTra.Text & "', " & txtSal.Text & ", 'En tramite', null)"
            consulta(1)

            frmDocConsRes.Show()
            Me.Close()
        Else
            MsgBox("Llene todas las cajas de texto")
        End If

    End Sub
End Class