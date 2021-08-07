<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsCP
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.btnVDNI = New System.Windows.Forms.Button()
        Me.lblPres = New System.Windows.Forms.Label()
        Me.txtPres = New System.Windows.Forms.TextBox()
        Me.btnVPres = New System.Windows.Forms.Button()
        Me.lblCont = New System.Windows.Forms.Label()
        Me.txtCont = New System.Windows.Forms.TextBox()
        Me.btnGen = New System.Windows.Forms.Button()
        Me.btnVol = New System.Windows.Forms.Button()
        Me.lblCR = New System.Windows.Forms.Label()
        Me.txtCR = New System.Windows.Forms.TextBox()
        Me.btnVCR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(13, 13)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(64, 13)
        Me.lblDni.TabIndex = 0
        Me.lblDni.Text = "DNI Cliente:"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(13, 30)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 1
        '
        'btnVDNI
        '
        Me.btnVDNI.Location = New System.Drawing.Point(139, 27)
        Me.btnVDNI.Name = "btnVDNI"
        Me.btnVDNI.Size = New System.Drawing.Size(75, 23)
        Me.btnVDNI.TabIndex = 2
        Me.btnVDNI.Text = "Verificar"
        Me.btnVDNI.UseVisualStyleBackColor = True
        '
        'lblPres
        '
        Me.lblPres.AutoSize = True
        Me.lblPres.Enabled = False
        Me.lblPres.Location = New System.Drawing.Point(238, 13)
        Me.lblPres.Name = "lblPres"
        Me.lblPres.Size = New System.Drawing.Size(84, 13)
        Me.lblPres.TabIndex = 4
        Me.lblPres.Text = "Nº Presupuesto:"
        '
        'txtPres
        '
        Me.txtPres.Enabled = False
        Me.txtPres.Location = New System.Drawing.Point(238, 30)
        Me.txtPres.Name = "txtPres"
        Me.txtPres.Size = New System.Drawing.Size(100, 20)
        Me.txtPres.TabIndex = 5
        '
        'btnVPres
        '
        Me.btnVPres.Enabled = False
        Me.btnVPres.Location = New System.Drawing.Point(364, 27)
        Me.btnVPres.Name = "btnVPres"
        Me.btnVPres.Size = New System.Drawing.Size(75, 23)
        Me.btnVPres.TabIndex = 6
        Me.btnVPres.Text = "Verificar"
        Me.btnVPres.UseVisualStyleBackColor = True
        '
        'lblCont
        '
        Me.lblCont.AutoSize = True
        Me.lblCont.Location = New System.Drawing.Point(233, 89)
        Me.lblCont.Name = "lblCont"
        Me.lblCont.Size = New System.Drawing.Size(115, 13)
        Me.lblCont.TabIndex = 7
        Me.lblCont.Text = "Nº Contrato de credito:"
        Me.lblCont.Visible = False
        '
        'txtCont
        '
        Me.txtCont.Location = New System.Drawing.Point(238, 112)
        Me.txtCont.Name = "txtCont"
        Me.txtCont.Size = New System.Drawing.Size(100, 20)
        Me.txtCont.TabIndex = 8
        Me.txtCont.Visible = False
        '
        'btnGen
        '
        Me.btnGen.Enabled = False
        Me.btnGen.Location = New System.Drawing.Point(363, 75)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(76, 41)
        Me.btnGen.TabIndex = 10
        Me.btnGen.Text = "Generar"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'btnVol
        '
        Me.btnVol.Location = New System.Drawing.Point(363, 122)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(75, 23)
        Me.btnVol.TabIndex = 11
        Me.btnVol.Text = "Volver"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'lblCR
        '
        Me.lblCR.AutoSize = True
        Me.lblCR.Enabled = False
        Me.lblCR.Location = New System.Drawing.Point(6, 89)
        Me.lblCR.Name = "lblCR"
        Me.lblCR.Size = New System.Drawing.Size(131, 13)
        Me.lblCR.TabIndex = 13
        Me.lblCR.Text = "N° Constancia de reserva:"
        '
        'txtCR
        '
        Me.txtCR.Enabled = False
        Me.txtCR.Location = New System.Drawing.Point(13, 112)
        Me.txtCR.Name = "txtCR"
        Me.txtCR.Size = New System.Drawing.Size(115, 20)
        Me.txtCR.TabIndex = 14
        '
        'btnVCR
        '
        Me.btnVCR.Enabled = False
        Me.btnVCR.Location = New System.Drawing.Point(139, 108)
        Me.btnVCR.Name = "btnVCR"
        Me.btnVCR.Size = New System.Drawing.Size(75, 23)
        Me.btnVCR.TabIndex = 15
        Me.btnVCR.Text = "Verificar"
        Me.btnVCR.UseVisualStyleBackColor = True
        '
        'frmConsCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 164)
        Me.Controls.Add(Me.btnVCR)
        Me.Controls.Add(Me.txtCR)
        Me.Controls.Add(Me.lblCR)
        Me.Controls.Add(Me.btnVol)
        Me.Controls.Add(Me.btnGen)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.lblCont)
        Me.Controls.Add(Me.btnVPres)
        Me.Controls.Add(Me.txtPres)
        Me.Controls.Add(Me.lblPres)
        Me.Controls.Add(Me.btnVDNI)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lblDni)
        Me.Name = "frmConsCP"
        Me.Text = "Constancias Compraventa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents btnVDNI As System.Windows.Forms.Button
    Friend WithEvents lblPres As System.Windows.Forms.Label
    Friend WithEvents txtPres As System.Windows.Forms.TextBox
    Friend WithEvents btnVPres As System.Windows.Forms.Button
    Friend WithEvents lblCont As System.Windows.Forms.Label
    Friend WithEvents txtCont As System.Windows.Forms.TextBox
    Friend WithEvents btnGen As System.Windows.Forms.Button
    Friend WithEvents btnVol As System.Windows.Forms.Button
    Friend WithEvents lblCR As System.Windows.Forms.Label
    Friend WithEvents txtCR As System.Windows.Forms.TextBox
    Friend WithEvents btnVCR As System.Windows.Forms.Button
End Class
