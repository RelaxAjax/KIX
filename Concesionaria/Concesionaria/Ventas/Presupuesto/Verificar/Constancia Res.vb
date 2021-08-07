Public Class frmConsRes
    'Se llega aca una vez que el cliente ya haya firmado su presupuesto y haya tomado su decicion sobre que metodo de pago.
    'Basicamente se fija si los datos de presupuesto y dni son validos para reservarle el auto que quiera comprar y hacerle una constancia de reserva.
    'Si quiere pagar en credito entonces primero le pedimos la seña y le damos la constancia de reserva y despues pasamos al formulario de pedido de credito prendario en el cual le pedimos sus datos crediticios al cliente para
    'hacer el pedido a credito, el cual cuando termine de averiguar nos va a decir si es apto o no, se le entrega el contrato de credito en otro formulario,
    'el cual va a ser accedido a travez del formulario de ventas.
    'Si quiere pagar en efectivo entonces se le pide la seña solamente y se le da la constancia de reserva.



    Private Sub btnVerDNI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVer.Click
        If Len(txtDNI.Text) = 8 And Len(txtPres.Text) <> 0 Then
            sql = "Select count(*) " & _
                  "From Clientes " & _
                  "Where DNI='" & txtDNI.Text & "';"
            consulta(1)

            If rs1.Read = True Then
                If rs1(0) = 1 Then
                    sql = "Select count(*) " & _
                          "From Presupuestos " & _
                          "Where IdCliente=(Select IdCliente " & _
                                           "From Clientes " & _
                                           "Where DNI='" & txtDNI.Text & "') " & _
                          "And NPres=" & txtPres.Text & ";"
                    consulta(1)

                    If rs1.Read = True Then
                        If rs1(0) <> 0 Then

                            sql = "Select Fven>=curdate() " & _
                                  "From Presupuestos " & _
                                  "Where NPres=" & txtPres.Text & ";"
                            consulta(1)

                            If rs1.Read Then
                                If rs1(0) = 1 Then
                                    sql = "Select count(*) " & _
                                          "From AutosU_Presupuestos " & _
                                          "Where Presupuesto=" & txtPres.Text & ";"
                                    consulta(1)

                                    sql = "Select count(*) " & _
                                          "From Autos_Presupuestos " & _
                                          "Where Presupuesto=" & txtPres.Text & ";"
                                    consulta(2)

                                    If rs1.Read = True Or rs2.Read = True Then
                                        If rs2(0) <> 0 Or rs1(0) <> 0 Then 'El hecho de que haya una tupla en AutoU_Presupuestos que tenga el presupuesto que el cliente puso significa que el auto que cliente quiere esta en "stock" *
                                            gbxMet.Enabled = True
                                            txtDNI.Enabled = False
                                            txtPres.Enabled = False
                                            btnVer.Enabled = False
                                        Else
                                            MsgBox("El presupuesto no es valido")
                                        End If
                                    End If
                                Else
                                    MsgBox("El presupuesto esta vencido")
                                End If
                            End If

                        Else
                            MsgBox("El presupuesto no pertenece a ese cliente")
                        End If
                    End If
                Else
                    MsgBox("Cliente no valido")
                End If
            End If
        Else
            MsgBox("Ingrese un DNI (8 caracteres) y numero de presupuesto validos")
        End If


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

    Private Sub txtPres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPres.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnVol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVol.Click
        Me.Close()
        frmPres.Show()
    End Sub

    Private Sub rdnEfe_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdnEfe.CheckedChanged
        If rdnEfe.Checked = True Then
            btnSen.Enabled = True
            btnSig.Enabled = False
        End If
    End Sub

    Private Sub rdnCre_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdnCre.CheckedChanged
        If rdnCre.Checked = True Then
            btnSen.Enabled = False
            btnSig.Enabled = True
        End If
    End Sub

    Private Sub btnSen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSen.Click
        Me.Hide()
        frmChe.Show()
        btnSig.Enabled = True
    End Sub

    Private Sub btnSig_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSig.Click
        If rdnCre.Checked = True Then
            frmSolC.Show()
            Me.Hide()
        Else
            frmDocConsRes.Show()
            Me.Hide()
        End If
    End Sub
End Class

'* Esto es porque cuando el auto deje de estar en stock se lo va a eliminar de la BD, haciendo que todos los datos relacionados con el queden borrados