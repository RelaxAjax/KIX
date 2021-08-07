Public Class frmReg
    Dim band1 As Boolean = False
    Dim band2 As Boolean = False
    Dim band3 As Boolean = False
    Dim band4 As Boolean = False
    Dim band5 As Boolean = False
    Dim band6 As Boolean = False

    Private Sub frmReg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtDNI.Text = frmEmi.txtDNI.Text
    End Sub

    Private Sub btnVerificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVerificar.Click
        If Len(txtDNI.Text) = 8 Then
            band1 = True
        ElseIf Len(txtDNI.Text) < 8 Then
            MsgBox("Ingrese una DNI valido (8 caracteres total)")
            band1 = False
        End If

        If Len(txtNom.Text) >= 3 Then
            band2 = True
        ElseIf Len(txtNom.Text) < 3 Then
            MsgBox("Ingrese un nombre valido")
            band2 = False
        End If

        If Len(txtApe.Text) >= 3 Then
            band3 = True
        ElseIf Len(txtApe.Text) < 3 Then
            MsgBox("Ingrese un apellido valido")
            band3 = False
        End If

        If Len(txtDom.Text) >= 6 Then
            band4 = True
        ElseIf Len(txtDom.Text) < 6 Then
            MsgBox("Ingrese una direccion valida")
            band4 = False
        End If

        If Len(txtTel.Text) = 8 Then
            band5 = True
        ElseIf Len(txtTel.Text) < 8 Then
            MsgBox("Ingrese una telefono valido (8 caracteres total)")
            band5 = False
        End If

        If Len(txtMail.Text) >= 13 Then
            band6 = True
        ElseIf Len(txtMail.Text) < 13 Then
            MsgBox("Ingrese un Email valido")
            band6 = False
        End If

        If band1 And band2 And band3 And band4 And band5 And band6 Then
            sql = "Insert into Clientes values('', '" & txtNom.Text & "', '" & txtApe.Text & "', '" & txtDNI.Text & "', '" & txtDom.Text & "', '" & txtMail.Text & "', " & txtTel.Text & ");"
            consulta(1)

            If frmEmi.txtDNI.Text <> "" Then
                frmEmi.txtDNI.Text = txtDNI.Text
                frmEmi.txtDNI.Enabled = False
                frmEmi.lblDni.Enabled = False
                frmEmi.btnVer.Enabled = False
                frmEmi.gbxTipo.Enabled = True

                Me.Close()
                frmEmi.Show()
            ElseIf frmConsCP.txtDNI.Text <> "" Then
                Me.Close()
                frmVenta.Show()
            End If

        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        If frmEmi.txtDNI.Text <> "" Then
            frmEmi.Show()
        ElseIf frmConsCP.txtDNI.Text <> "" Then
            frmConsCP.Show()
        End If

        Me.Close()
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
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

    Private Sub txtApe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class