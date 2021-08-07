Public Class frmConsCP
    'Primero se verifica el DNI despues el presupuesto, una vez se revise le presupuesto el programa se fija automaticamente 
    'si hay stock del auto que el cliente pidio en el caso de que haya comprado un usado. Despues en el caso de 0km le dice a compras 
    'que compre el auto en el cuando se genera la constancia (hacer insert en la tabla pedidos) o se le pide a almacen que traiga el auto en caso de usado
    '(Feca de entrega del auto es a mas tardar 3 meses despues de la emision de la constancia)

    'Soy conciente del error de diseño en este formulario, que se podrian haber hecho mas simple con un solo boton de verificar, pero
    'la mayor parte del diseño esta hecho de antes y cambiarlo ahora me consumiria mucho tiempo, del cual no dispongo.


    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPres.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCont_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCont.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If txtCR.Text <> "" And txtCont.Text <> "" Then
            btnGen.Enabled = True
        End If
    End Sub

    Private Sub btnVDNI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVDNI.Click
        Dim x As Integer

        If Len(txtDNI.Text) < 8 Then
            MsgBox("Ingrese un DNI valido (8 caracteres total)")
        Else
            sql = "Select count(*) " & _
                  "From Clientes " & _
                  "Where DNI='" & txtDNI.Text & "';"
            consulta(1)

            If rs1.Read = True Then
                If rs1(0) = 1 Then
                    txtDNI.Enabled = False
                    lblDni.Enabled = False
                    btnVDNI.Enabled = False
                    lblPres.Enabled = True
                    txtPres.Enabled = True
                    btnVPres.Enabled = True
                Else
                    x = MsgBox("Cliente no econtrado, desea ingresarlo en el sistema?", MsgBoxStyle.YesNo, "Registrar")

                    If x = 6 Then
                        Me.Hide()
                        frmReg.Show()
                    Else
                        Me.Close()
                        frmMenu.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnVPres_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVPres.Click
        If txtPres.Text <> "" Then
            sql = "Select count(*) " & _
                  "From Autos_presupuestos " & _
                  "Where Presupuesto=" & txtPres.Text
            consulta(1)

            sql = "Select count(*) " & _
                  "From AutosU_presupuestos " & _
                  "Where Presupuesto=" & txtPres.Text
            consulta(2)

            If rs1.Read = True And rs2.Read = True Then
                If rs1(0) = 1 Or rs2(0) = 1 Then
                    txtPres.Enabled = False
                    btnVPres.Enabled = False
                    lblCR.Enabled = True
                    txtCR.Enabled = True
                    btnVCR.Enabled = True
                Else
                    MsgBox("Presupuesto no encontrado")
                End If
            End If
        Else
            MsgBox("Ingrese un numero de presupuesto")
        End If
    End Sub

    Private Sub btnVol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVol.Click
        Me.Close()
        frmVenta.Show()
    End Sub

    Private Sub btnChe_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmChe.Show()
    End Sub

    Private Sub btnGen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGen.Click

        If txtCont.Visible = True Then
            sql = "Select count(*) " & _
                  "From Contratos_cre " & _
                  "Where IdCont=" & txtCont.Text & " " & _
                  "And Cliente=(Select IdCliente " & _
                               "From Clientes " & _
                               "Where DNI=" & txtDNI.Text & ")"
            consulta(1)

            If rs1.Read = True Then
                If rs1(0) = 1 Then
                    frmDocC.Show()
                    Me.Hide()
                Else
                    MsgBox("El contrato de credito no es valido o no pertenece a ese cliente")
                End If
            End If
        Else
            frmDocC.Show()
            Me.Close()
        End If

    End Sub

    Private Sub txtCR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCR.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If txtCR.Text <> "" And txtCont.Text <> "" Then
            btnGen.Enabled = True
        End If
    End Sub

    Private Sub btnVCR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVCR.Click
        If txtCR.Text <> "" Then
            sql = "Select count(*) " & _
                  "From constancias_res " & _
                  "Where IdRes=" & txtCR.Text & " " & _
                  "And Presupuesto=" & txtPres.Text
            consulta(1)

            If rs1.Read = True Then
                If rs1(0) = 1 Then
                    txtCR.Enabled = False
                    btnVCR.Enabled = False

                    sql = "Select Metodo " & _
                          "From Constancias_res " & _
                          "Where IdRes=" & txtCR.Text
                    consulta(1)

                    If rs1.Read = True Then
                        If rs1(0) = "Efectivo" Then
                            btnGen.Enabled = True
                        Else
                            txtCont.Visible = True
                            lblCont.Visible = True
                        End If
                    End If

                Else
                    MsgBox("La constancia de reserva no es valida o no pertenece a ese presupuesto")
                End If
            End If
        Else
            MsgBox("Ingrese una id de constancia de reserva")
        End If
        
    End Sub
End Class