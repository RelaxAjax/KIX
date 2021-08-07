Public Class frmDocConsRes
    Dim aux As String
    Dim aux2 As String
    Dim sena As String

    Private Sub frmDocConsRes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sql = "Select Nombre, Apellido " & _
              "From Clientes " & _
              "Where DNI='" & frmConsRes.txtDNI.Text & "';"
        consulta(1)

        If rs1.Read Then
            lblCl.Text = rs1(0) & ", " & rs1(1)
        End If

        sql = "Select count(*) " & _
              "From Autos_Presupuestos " & _
              "Where Presupuesto=" & frmConsRes.txtPres.Text & ""
        consulta(1)

        sql = "Select count(*) " & _
              "From AutosU_Presupuestos " & _
              "Where Presupuesto=" & frmConsRes.txtPres.Text & ""
        consulta(2)

        If rs1.Read = True Or rs2.Read = True Then
            If rs1(0) = 1 Then
                sql = "Select Marca, Modelo, IdAuto " & _
                      "From Autos_Presupuestos AP, Autos A " & _
                      "Where AP.Presupuesto=" & frmConsRes.txtPres.Text & " " & _
                      "And A.IdAuto=AP.Auto;"
                consulta(1)

                If rs1.Read = True Then
                    lblAu.Text = rs1(0) & ", " & rs1(1)
                    aux2 = rs1(2)
                End If

                lblCond.Text = "0Km"
            ElseIf rs2(0) = 1 Then
                sql = "Select Marca, Modelo, IdAutoU " & _
                      "From AutosU_Presupuestos AP, Almacen A " & _
                      "Where AP.Presupuesto=" & frmConsRes.txtPres.Text & " " & _
                      "And A.IdAutoU=AP.AutoU"
                consulta(1)

                If rs1.Read = True Then
                    aux2 = rs1(2)
                    lblAu.Text = rs1(0) & ", " & rs1(1)
                End If

                lblCond.Text = "Usado"
            End If
        End If

        lblPre.Text = frmConsRes.txtPres.Text

        lblSen.Text = frmConsRes.lblAux.Text

        sql = "Select max(IdRes)+1 " & _
              "From Constancias_Res;"
        consulta(1)

        If rs1.Read = True Then
            aux = rs1(0)
            lblNum.Text = "N°: " & rs1(0)
        End If

        If frmConsRes.rdnCre.Checked = True Then
            lblMetP.Text = "Credito"
        Else
            lblMetP.Text = "Efectivo"
        End If
    End Sub

    Private Sub btnImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImp.Click

        If frmConsRes.rdnCre.Checked = True Then
            sena = "null"
        Else
            sena = lblSen.Text
        End If

        sql = "Insert into Constancias_Res values('', " & lblPre.Text & ", '" & lblMetP.Text & "'," & sena & ");"
        consulta(1)

        sql = "Select count(*) " & _
              "From Autos_Presupuestos " & _
              "Where Presupuesto=" & lblPre.Text & ";"
        consulta(1)

        sql = "Select count(*) " & _
              "From AutosU_Presupuestos " & _
              "Where Presupuesto=" & lblPre.Text & ";"
        consulta(2)

        If rs1.Read = True Or rs2.Read = True Then
            If rs1(0) = 1 Then
                sql = "Insert into ConsRes_0km values(" & aux & ", " & aux2 & ");"
                consulta(1)
            Else
                sql = "Insert into ConsRes_U values(" & aux & ", " & aux2 & ");"
                consulta(1)
            End If
        End If

        Me.Close()
        frmConsRes.Close()
        frmMenu.Show()
    End Sub
End Class