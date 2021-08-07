Public Class frmCobroCuo

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
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
    End Sub

    Private Sub txtCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVer.Click
        If Len(txtDNI.Text) = 8 And txtCont.Text <> "" And txtCP.Text <> "" Then
            sql = "Select count(*) " & _
                  "From Clientes " & _
                  "Where DNI=" & txtDNI.Text
            consulta(1)

            If rs1.Read = True Then
                If rs1(0) = 1 Then
                    sql = "Select count(*) " & _
                          "From Constancias_cp " & _
                          "Where Presupuesto = (Select NPres " & _
                                               "From Presupuestos " & _
                                               "Where IdCliente=(Select IdCliente " & _
                                                                "From Clientes " & _
                                                                "Where DNI=" & txtDNI.Text & ")) " & _
                          "And IdCons=" & txtCP.Text
                    consulta(1)

                    If rs1.Read = True Then
                        If rs1(0) = 1 Then
                            sql = "Select count(*) " & _
                                  "From Contratos_cre " & _
                                  "Where IdCont=" & txtCont.Text & " " & _
                                  "And Cliente = (Select IdCliente " & _
                                                 "From Clientes " & _
                                                 "Where DNI=" & txtDNI.Text & ") " & _
                                  "And CP=" & txtCP.Text
                            consulta(1)

                            If rs1.Read = True Then
                                If rs1(0) = 1 Then
                                    'Seleccionas que cuota/s queres pagar y te sale una ventana aparte que te muestra el total de lo que tenes que pagar, dejandote ahi decidir si pagar o volver
                                    lstCuo.Enabled = True
                                Else
                                    MsgBox("El contrato de credito es invalido o no pertenece al conjunto de cliente y constancia de compraventa que ingreso")
                                End If
                            End If
                        Else
                            MsgBox("La constancia de compraventa es invalida o no pertenece a ese cliente")
                        End If
                    End If
                Else
                    MsgBox("Cliente invalido")
                End If
            End If

        Else
            MsgBox("Llene las cajas de texto")
        End If
    End Sub

    


    Private Sub lstCuo_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCuo.EnabledChanged

    End Sub
End Class