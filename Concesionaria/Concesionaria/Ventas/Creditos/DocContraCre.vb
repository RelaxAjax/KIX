Public Class frmDocCCre
    Dim NPres As Integer
    Dim interes As Integer

    Private Sub frmDocCCre_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        sql = "Select Presupuesto " & _
              "From Solicitud_Cre " & _
              "Where idSolC=" & frmCre.lblAux.Text
        consulta(1)

        If rs1.Read = True Then
            NPres = rs1(0)
        End If

        sql = "Select curdate(), DATE_ADD(curdate(), INTERVAL 28 month)"
        consulta(1)

        If rs1.Read = True Then
            lblFE.Text = "Fecha de emision: " & rs1(0)
            lblFV.Text = "Fecha de vencimiento: " & rs1(1)
        End If

        sql = "Select count(*) " & _
              "From Autos_Presupuestos " & _
              "Where Presupuesto=" & NPres
        consulta(2)

        sql = "Select count(*) " & _
              "From AutosU_Presupuestos " & _
              "Where Presupuesto=" & NPres
        consulta(3)

        If rs2.Read = True Or rs3.Read = True Then
            If rs2(0) = 1 Then
                sql = "Select Marca, Modelo, Nombre, Apellido " & _
                      "From Clientes C, Autos A " & _
                      "Where A.IdAuto=(Select Auto " & _
                                      "From Autos_Presupuestos " & _
                                      "Where Presupuesto=" & NPres & ") " & _
                      "And C.IdCliente=(Select IdCliente " & _
                                       "From Presupuestos " & _
                                       "Where NPres=" & NPres & ")"
                consulta(3)

                If rs3.Read = True Then
                    lblCue1.Text = "Se le entrega este contrato de credito prendario" + vbLf + "a " & rs3(2) & " " & rs3(3) & " para la compra de un automovil" + vbLf + "marca " & rs3(0) & ", modelo " & rs3(1) & ", estando el mismo" + vbLf + "en condicion de 0km."
                End If

                sql = "Select Interes " & _
                      "From Autos_Presupuestos " & _
                      "Where Presupuesto=" & NPres
                consulta(3)

                If rs3.Read = True Then
                    interes = Val(rs3(0))
                    lblCue2.Text = "Solo se podra pagar a travez de cuotas, siendo las mismas" + vbLf + "25 de $" & rs3(0) / 25 & " cada una, el cliente solo podra pagar en" + vbLf + "efectivo a travez de cheques. Si el cliente no llegara a" + vbLf + "pagar 3 cuotas seguidas se le extraera el automovil de su" + vbLf + "propiedad y no se lo devolveremos hasta que pague todas" + vbLf + "las cuotas que deba, con sus debidas prendas."
                End If

            Else
                sql = "Select Marca, Modelo, Nombre, Apellido " & _
                      "From Clientes C, Almacen A " & _
                      "Where A.IdAutoU=(Select AutoU " & _
                                       "From AutosU_Presupuestos " & _
                                       "Where Presupuesto=" & NPres & ") " & _
                      "And C.IdCliente=(Select IdCliente " & _
                                       "From Presupuestos " & _
                                       "Where NPres=" & NPres & ")"
                consulta(3)

                If rs3.Read = True Then
                    interes = Val(rs3(0))
                    lblCue1.Text = "Se le entrega este contrato de credito prendario" + vbLf + "a " & rs3(2) & " " & rs3(3) & " para la compra de un automovil" + vbLf + "marca " & rs3(0) & ", modelo " & rs3(1) & ", estando el mismo" + vbLf + "en condicion de usado."
                End If

                sql = "Select Interes " & _
                      "From AutosU_Presupuestos " & _
                      "Where Presupuesto=" & NPres
                consulta(3)

                If rs3.Read = True Then
                    interes = Val(rs3(0))
                    lblCue2.Text = "Solo se podra pagar a travez de cuotas, siendo las mismas" + vbLf + "35 de $" & rs3(0) / 35 & " cada una, el cliente solo podra pagar en" + vbLf + "efectivo a travez de cheques. Si el cliente no llegara a" + vbLf + "pagar 3 cuotas seguidas se le extraera el automovil de su" + vbLf + "propiedad y no se lo devolveremos hasta que pague todas" + vbLf + "las cuotas que deba, con sus debidas prendas."
                End If
            End If
        End If

        sql = "Select max(IdCont)+1 From Contratos_Cre"
        consulta(2)

        If rs2.Read = True Then
            lblN.Text = "N°: " & rs2(0)
        End If

    End Sub

    Private Sub btnImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImp.Click
        sql = "Select IdCliente " & _
              "From Presupuestos " & _
              "Where NPres=" & NPres
        consulta(2)

        If rs2.Read = True Then
            sql = "Insert into Contratos_Cre values('', " & rs2(0) & ", " & interes & ", curdate(), date_add(curdate(), INTERVAL 38 month))"
            consulta(1)
        End If

        frmVenta.Show()
        Me.Close()
    End Sub
End Class