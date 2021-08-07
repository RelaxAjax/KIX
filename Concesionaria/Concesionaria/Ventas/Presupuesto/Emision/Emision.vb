Public Class frmEmi
    'Primero se verifica el dni del cliente, si no esta en la base de datos entonces se le pide que registre al cliente (form registro)
    Private Sub btnVolver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmVenta.Show()
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



    Private Sub btnVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Dim x As Integer

        If Len(txtDNI.Text) <> 8 Then
            MsgBox("DNI invalido (8 caracteres en total)")
        Else
            sql = "Select count(*) " & _
                  "From Clientes " & _
                  "Where DNI='" & txtDNI.Text & "';"
            consulta(1)

            If rs1.Read = True Then
                If rs1(0) <> 0 Then
                    MsgBox("Cliente valido")
                    gbxTipo.Enabled = True
                    txtDNI.Enabled = False
                    btnVer.Enabled = False
                    lblDni.Enabled = False
                Else
                    x = MsgBox("Cliente no encontrado, desea ingresarlo?", MsgBoxStyle.YesNo, "Registrar")

                    If x = 6 Then
                        Me.Hide()
                        frmReg.Show()
                    Else
                        txtDNI.Text = ""
                    End If
                End If
            End If

        End If
    End Sub


    Private Sub rdn0km_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdn0km.CheckedChanged
        Dim i As Integer
        btnGen.Enabled = False
        lblAuto.Enabled = True
        lstAuto.Enabled = True
        lblColor.Enabled = True
        cbxColor.Enabled = True

        If rdn0km.Checked = True Then
            sql = "Select marca, modelo, P.precio " & _
                  "From Autos A, Precios P " & _
                  "Where P.NPre=A.Precio " & _
                  "Order by marca;"
            consulta(1)

            While rs1.Read = True
                lstAuto.Items.Add(rs1(0))
                lstAuto.Items(i).SubItems.Add(rs1(1))
                lstAuto.Items(i).SubItems.Add(rs1(2))
                lstAuto.Items(i).SubItems.Add("--")
                lstAuto.Items(i).SubItems.Add("--")
                lstAuto.Items(i).SubItems.Add(rs1(2) * 1.4)

                i = i + 1
            End While
        Else
            lstAuto.Items.Clear()
        End If
    End Sub

    Private Sub rdnUsado_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdnUsado.CheckedChanged
        Dim i As Integer
        lblAuto.Enabled = True
        lstAuto.Enabled = True
        lblColor.Enabled = False
        cbxColor.Enabled = False

        If rdnUsado.Checked = True Then
            sql = "Select marca, modelo, P.precio, KmU, color " & _
                  "From Almacen A, Precios P " & _
                  "Where P.NPre=A.Precio " & _
                  "And IdAutoU not in (Select AutoU from ConsRes_U) " & _
                  "Order by marca;"
            consulta(1)

            While rs1.Read = True
                lstAuto.Items.Add(rs1(0))
                lstAuto.Items(i).SubItems.Add(rs1(1))
                lstAuto.Items(i).SubItems.Add(rs1(2))
                lstAuto.Items(i).SubItems.Add(rs1(3))
                lstAuto.Items(i).SubItems.Add(rs1(4))
                lstAuto.Items(i).SubItems.Add(rs1(2) * 1.4)

                i = i + 1
            End While
        Else
            lstAuto.Items.Clear()
        End If
    End Sub

    Private Sub lstAuto_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lstAuto.ItemSelectionChanged
        If cbxColor.Text <> "" Or rdnUsado.Checked = True Then
            btnGen.Enabled = True
        End If
    End Sub

    Private Sub btnGen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGen.Click
        Me.Hide()
        frmDocP.Show()
    End Sub
End Class

'ListView1.Items(x).SubItems(y).Text tomando en cuenta como si fuera puntos en una matriz
'lstAuto.Items(lstAuto.FocusedItem.Index).SubItems(0).Text