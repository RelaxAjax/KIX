Public Class frmCre

    Private Sub ref(ByVal cond As String)
        'Esta funcion se usa para refrescar el contenido de la list view con la condicion que el usuario quiera,
        'siendo estas condiciones: "Todo" (para mostrar todos las solicitudes de credito)
        '                          "Aprobado" (para mostrar solo las solicitudes de creditos aprobadas)
        '                          "Desaprobado" (para mostrar solo las solicitudes de creditos desaprobadas)
        Dim i As Integer

        If cond = "Todo" Then

            sql = "Select Nombre, Apellido, DNI, Estado, idSolC " & _
                  "From Solicitud_Cre, Clientes " & _
                  "Where idCliente=(Select IdCliente " & _
                                   "From Presupuestos " & _
                                   "Where NPres=Presupuesto)"
            consulta(1)

            lstSols.Items.Clear()

            While rs1.Read = True
                lstSols.Items.Add(rs1(4))
                lstSols.Items(i).SubItems.Add(rs1(0) & " " & rs1(1))
                lstSols.Items(i).SubItems.Add(rs1(2))
                lstSols.Items(i).SubItems.Add(rs1(3))

                i = i + 1
            End While

            i = 0

        Else

            sql = "Select Nombre, Apellido, DNI, Estado, idSolC " & _
                  "From Solicitud_Cre, Clientes " & _
                  "Where idCliente=(Select IdCliente " & _
                                   "From Presupuestos " & _
                                   "Where NPres=Presupuesto) " & _
                  "And Estado='" & cond & "'"
            consulta(1)

            lstSols.Items.Clear()

            While rs1.Read = True
                lstSols.Items.Add(rs1(4))
                lstSols.Items(i).SubItems.Add(rs1(0) & " " & rs1(1))
                lstSols.Items(i).SubItems.Add(rs1(2))
                lstSols.Items(i).SubItems.Add(rs1(3))

                i = i + 1
            End While

            i = 0

        End If
    End Sub

    Private Sub rdnDes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdnDes.CheckedChanged
        If rdnDes.Checked = True Then
            ref("Desaprobado")
        End If
    End Sub

    Private Sub rdnApro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdnApro.CheckedChanged
        If rdnApro.Checked = True Then
            ref("Aprobado")
        End If
    End Sub

    Private Sub rdnTod_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdnTod.CheckedChanged
        If rdnTod.Checked = True Then
            ref("Todo")
        End If
    End Sub

    Private Sub btnEP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEP.Click
        If lstSols.Items(lstSols.FocusedItem.Index).SubItems(3).Text = "Aprobado" Then
            sql = "Select Presupuesto " & _
                  "From Solicitud_Cre " & _
                  "Where IdSolC=" & lstSols.Items(lstSols.FocusedItem.Index).SubItems(0).Text
            consulta(1)

            If rs1.Read = True Then
                sql = "Insert into Solicitudes_pol values ('', " & rs1(0) & ", 'En tramite')"
                consulta(1)
            End If

            lblAux.Text = lstSols.Items(lstSols.FocusedItem.Index).SubItems(0).Text

            Me.Hide()
            frmDocCCre.Show()

            sql = "Delete " & _
                  "From Solicitud_Cre " & _
                  "Where IdSolC=" & lstSols.Items(lstSols.FocusedItem.Index).SubItems(0).Text
            consulta(1)

            If rdnApro.Checked = True Then
                ref("Aprobado")
            ElseIf rdnDes.Checked = True Then
                ref("Desaprobado")
            Else
                ref("Todo")
            End If

        Else
            MsgBox("Seleccione una solicitud que este aprobada")
        End If
    End Sub

    Private Sub btnVol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVol.Click
        Me.Close()
        frmVenta.Show()
    End Sub

   
    Private Sub lstSols_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSols.Click
        btnEP.Enabled = True
    End Sub
End Class