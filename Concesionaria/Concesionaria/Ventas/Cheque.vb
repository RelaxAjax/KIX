Public Class frmChe
    Dim band1 As Boolean = False
    Dim band2 As Boolean = False
    Dim band3 As Boolean = False
    Dim band4 As Boolean = False
    Dim fecha As String

    Private Sub txtNC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNC.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNR.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMon.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnEmi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmi.Click
        If Len(txtNC.Text) = 9 Then
            band1 = True
        Else
            MsgBox("Ingrese una Nª de cuenta valido (9 caracteres total)")
            band1 = False
        End If

        If Len(txtNom.Text) >= 3 Then
            band2 = True
        Else
            MsgBox("Ingrese un nombre valido")
            band2 = False
        End If

        If Len(txtNR.Text) = 9 Then
            band3 = True
        Else
            MsgBox("Ingrese una Nª de ruta valido (9 caracteres total)")
            band3 = False
        End If

        If Len(txtMon.Text) >= 4 Then
            band4 = True
        Else
            MsgBox("Ingrese un monto valido (mayor a 1000)")
            band4 = False
        End If

        fecha = Str(Format(dtpFecha.Value, "yyyyMMdd"))

        If band1 And band2 And band3 And band4 Then
            sql = "Insert into Cheques values ('', '" & txtNom.Text & "', " & txtNR.Text & ", " & txtNC.Text & ", " & txtMon.Text & ", '" & fecha & "', 'Entrada', 'Compra auto');"
            consulta(1)

            If frmConsRes.txtPres.Text <> "" Then
                frmConsRes.gbxMet.Enabled = False
                frmConsRes.btnSig.Enabled = True
                frmConsRes.btnVol.Enabled = False
                frmConsRes.btnSen.Enabled = False
                frmConsRes.lblAux.Text = txtMon.Text
                Me.Close()
                frmConsRes.Show()
            End If
        End If
    End Sub

    Private Sub btnVol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVol.Click
        If frmConsCP.txtPres.Text <> "" Then
            Me.Close()
            frmConsCP.Show()
        ElseIf frmConsRes.txtPres.Text <> "" Then
            Me.Close()
            frmConsRes.Show()
        End If
    End Sub
End Class