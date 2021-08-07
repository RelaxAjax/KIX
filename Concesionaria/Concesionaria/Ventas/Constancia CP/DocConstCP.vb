Public Class frmDocC
    Dim fecha As String
    Dim Metodo As String
    Dim monto As Integer
    Dim npres As Integer

    Private Sub frmDocC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fecha = Format(Now, "dd/MM/yyyy")

        lblCuerpo.Text = "En el día " & fecha & " la empresa KIX domiciliada en calle " + vbLf + "Tres arroyos 4587 se dispone de venderle un automóvil a:"

        sql = "Select Nombre, Apellido " & _
              "From Clientes " & _
              "Where DNI='" & frmConsCP.txtDNI.Text & "';"
        consulta(1)

        If rs1.Read = True Then
            lblNom.Text = "Nombre: " & rs1(0) & ""
            lblApe.Text = "Apellido: " & rs1(1) & ""
        End If
        lblDNI.Text = "DNI: " & frmConsCP.txtDNI.Text & ""

        sql = "Select count(*) " & _
              "From Autos_presupuestos " & _
              "Where Presupuesto=" & frmConsCP.txtPres.Text & ";"
        consulta(1)

        If rs1.Read = True Then
            If rs1(0) = 1 Then
                lblCond.Text = "Condicion del vehiculo: 0km"

                sql = "Select Marca, Modelo, Color " & _
                      "From Autos A, Autos_presupuestos AP " & _
                      "Where AP.Presupuesto=" & frmConsCP.txtPres.Text & " " & _
                      "And A.IdAuto=AP.Auto;"
                consulta(1)

                If rs1.Read = True Then
                    lblMar.Text = "Marca: " & rs1(0) & ""
                    lblMod.Text = "Modelo: " & rs1(1) & ""
                    lblCol.Text = "Color: " & rs1(2) & ""
                End If

                lblNB.Visible = False

                If frmConsCP.txtCont.Visible = True Then
                    Metodo = "Credito"

                    sql = "Select AP.Interes " & _
                          "From Autos_Presupuestos AP, Autos A " & _
                          "Where Presupuesto=" & frmConsCP.txtPres.Text & " " & _
                          "And IdAuto=AP.Auto;"
                    consulta(1)

                    If rs1.Read = True Then
                        monto = rs1(0)

                        lblCond1.Text = "1) La empresa KIX vende al comprador el vehículo especificado " + vbLf + "por la cantidad de $" & rs1(0) & ", IVA e intereses incluidos"

                        lblCond2.Text = "2)El comprador se compromete a pagar en el método de pago " + vbLf + "de crédito por el monto especificado anteriormente."
                    End If

                Else
                    Metodo = "Efectivo"

                    sql = "Select Monto " & _
                          "From Autos_Presupuestos AP, Autos A " & _
                          "Where Presupuesto=" & frmConsCP.txtPres.Text & " " & _
                          "And IdAuto=AP.Auto;"
                    consulta(1)

                    If rs1.Read = True Then
                        monto = rs1(0)
                        lblCond1.Text = "1) La empresa KIX vende al comprador el vehículo especificado " + vbLf + "por la cantidad de $" & rs1(0) & ", IVA e intereses incluidos"

                        lblCond2.Text = "2)El comprador se compromete a pagar en el método de pago " + vbLf + "de crédito por el monto especificado anteriormente."
                    End If
                End If


            Else
                lblCond.Text = "Condicion del vehiculo: Usado"

                sql = "Select Marca, Modelo, NBast, Color " & _
                      "From Almacen A, AutosU_presupuestos AP " & _
                      "Where AP.Presupuesto=" & frmConsCP.txtPres.Text & " " & _
                      "And A.IdAutoU=AP.AutoU"
                consulta(1)

                If rs1.Read = True Then
                    lblMar.Text = "Marca: " & rs1(0) & ""
                    lblMod.Text = "Modelo: " & rs1(1) & ""
                    lblNB.Text = "Nº de bastidor: " & rs1(2) & ""
                    lblCol.Text = "Color: " & rs1(3) & ""
                End If

                If frmConsCP.txtCont.Visible = True Then
                    Metodo = "Credito"

                    sql = "Select Interes " & _
                          "From AutosU_Presupuestos AP, Almacen A " & _
                          "Where Presupuesto=" & frmConsCP.txtPres.Text & " " & _
                          "And IdAutoU=AutoU"
                    consulta(1)

                    If rs1.Read = True Then
                        monto = rs1(0)
                        lblCond1.Text = "1) La empresa KIX vende al comprador el vehículo especificado " + vbLf + "por la cantidad de $" & rs1(0) & ", IVA e intereses incluidos"

                        lblCond2.Text = "2)El comprador se compromete a pagar en el método de pago " + vbLf + "de crédito por el monto especificado anteriormente."
                    End If
                Else
                    Metodo = "Efectivo"

                    sql = "Select Monto " & _
                          "From AutosU_Presupuestos AP, Almacen A " & _
                          "Where Presupuesto=" & frmConsCP.txtPres.Text & " " & _
                          "And IdAutoU=AutoU"
                    consulta(1)

                    If rs1.Read = True Then
                        monto = rs1(0)
                        lblCond1.Text = "1) La empresa KIX vende al comprador el vehículo especificado " + vbLf + "por la cantidad de $" & rs1(0) & ", IVA e intereses incluidos"

                        lblCond2.Text = "2)El comprador se compromete a pagar en el método de pago " + vbLf + "de crédito por el monto especificado anteriormente."
                    End If
                End If
            End If
        End If

        fecha = Format(DateAdd("m", 4, Now), "dd/MM/yyyy")

        lblCond3.Text = "3)La empresa KIX se compromete a entregar el auto " + vbLf + "al día " & fecha & " a mas tardar junto a las llaves del mismo, " + vbLf + "la cedula verde, la garantía y el seguro." + vbLf + "En caso de haberse elegido pagarse en crédito prendario y " + vbLf + "el comprador deba 3 o mas cuotas del credito, el auto " + vbLf + "será sacado de su propiedad e ira a ser propiedad del banco."

        sql = "Select max(IdCons)+1 " & _
              "From Constancias_cp;"
        consulta(1)

        If rs1.Read = True Then
            lblNCons.Text = "Nº: " & rs1(0)
        End If

        npres = frmConsCP.txtPres.Text
    End Sub

    Private Sub btnImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImp.Click
        sql = "Insert into Constancias_cp values ('', " & npres & ", curdate(), " & monto & ", '" & Metodo & "');"
        consulta(1)

        If frmConsCP.txtCont.Text <> "" Then
            sql = "Select Cast(monto/35 AS int) " & _
                  "From Contratos_cre " & _
                  "Where IdCont=" & frmConsCP.txtCont.Text
            consulta(1)

            If rs1.Read = True Then
                For i As Integer = 2 To 36 Step 1
                    sql = "Select date_format(date_add(curdate(), INTERVAL " & i & " month), '%Y/%m/15')"
                    consulta(3)

                    If rs3.Read = True Then
                        sql = "Insert into Cuotas values('', " & frmConsCP.txtCont.Text & ", '" & rs3(0) & "', " & rs1(0) & ", null)"
                        consulta(2)
                    End If

                Next
            End If

            frmConsCP.Close()
        End If

        frmVenta.Show()
        Me.Close()
    End Sub
End Class