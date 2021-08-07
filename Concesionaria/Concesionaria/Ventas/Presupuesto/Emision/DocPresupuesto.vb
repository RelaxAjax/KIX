'La idea seria cambiar todos estos labels y meter una imagen del presupuesto en la ventana con los campos vacios,
'en el lugar donde estaria la info meter labels con los datos (cambiar el background color a blanco). A la hora de
'imprimir lo que hariamos es hacer que se cree una ventana sin bordes con la misma imagen, los mismos labels encima
'con la misma informacion y hacer que imprima esa ventana en vez de la original. Una vez impreso esto se sigue el curso normal.

Public Class frmDocP
    Private Sub frmDocP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblDNI.Text = frmEmi.txtDNI.Text

        sql = "Select Nombre, Apellido " & _
              "From Clientes " & _
              "WHere DNI='" & lblDNI.Text & "';"
        consulta(1)

        If rs1.Read = True Then
            lblNyA.Text = rs1(0) & " " & rs1(1)
        End If

        sql = "Select max(NPres)+1 " & _
              "From Presupuestos;"
        consulta(1)

        If rs1.Read = True Then
            lblNPres.Text = "N°: " & rs1(0)
        End If

        lblInt.Text = frmEmi.lstAuto.Items(frmEmi.lstAuto.FocusedItem.Index).SubItems(5).Text

        If frmEmi.rdn0km.Checked = True Then
            lblCond.Text = "0km"
            lblKmAux.Visible = False
            lblKm.Visible = False
            lblColor.Text = frmEmi.cbxColor.Text
        Else
            lblCond.Text = "Usado"
            lblKm.Text = frmEmi.lstAuto.Items(frmEmi.lstAuto.FocusedItem.Index).SubItems(3).Text
            lblColor.Text = frmEmi.lstAuto.Items(frmEmi.lstAuto.FocusedItem.Index).SubItems(4).Text
        End If

        lblPre.Text = frmEmi.lstAuto.Items(frmEmi.lstAuto.FocusedItem.Index).SubItems(2).Text

        lblAuto.Text = frmEmi.lstAuto.Items(frmEmi.lstAuto.FocusedItem.Index).SubItems(0).Text & ", " & frmEmi.lstAuto.Items(frmEmi.lstAuto.FocusedItem.Index).SubItems(1).Text

    End Sub

    Private Sub btnImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImp.Click
        sql = "Select IdCliente From Clientes Where DNI='" & lblDNI.Text & "';"
        consulta(1)

        If rs1.Read = True Then
            sql = "Insert into Presupuestos values ('', " & rs1(0) & ", 'Venta', curdate(), date_add(curdate(), interval 2 month), " & lblPre.Text & ");"
            consulta(1)

            If lblCond.Text = "0km" Then
                sql = "Select max(NPres) From Presupuestos"
                consulta(1)

                sql = "Select IdAuto " & _
                      "From Autos " & _
                      "Where Marca='" & frmEmi.lstAuto.Items(frmEmi.lstAuto.FocusedItem.Index).SubItems(0).Text & "' " & _
                      "And Modelo='" & frmEmi.lstAuto.Items(frmEmi.lstAuto.FocusedItem.Index).SubItems(1).Text & "';"
                consulta(2)

                If rs1.Read = True And rs2.Read = True Then
                    sql = "Insert into Autos_Presupuestos values (" & rs1(0) & ", " & rs2(0) & ", '" & lblColor.Text & "', " & lblInt.Text & ");"
                    consulta(1)
                End If

            Else
                sql = "Select max(NPres) From Presupuestos"
                consulta(1)

                sql = "Select IdAutoU " & _
                      "From Almacen " & _
                      "Where Marca='" & frmEmi.lstAuto.Items(frmEmi.lstAuto.FocusedItem.Index).SubItems(0).Text & "' " & _
                      "And Modelo='" & frmEmi.lstAuto.Items(frmEmi.lstAuto.FocusedItem.Index).SubItems(1).Text & "' " & _
                      "And KmU=" & lblKm.Text & ";"
                consulta(2)

                If rs1.Read = True And rs2.Read = True Then
                    sql = "Insert into AutosU_Presupuestos values (" & rs1(0) & ", " & rs2(0) & ", " & lblInt.Text & ");"
                    consulta(1)
                End If
            End If
        End If
        'Aca deberia "Imprimir" el presupuesto
        Me.Close()
        frmEmi.Close()
        frmVenta.Close()
        frmMenu.Show()
    End Sub
End Class