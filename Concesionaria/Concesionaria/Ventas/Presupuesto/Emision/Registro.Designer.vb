<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReg
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
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblApe = New System.Windows.Forms.Label()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.lblDom = New System.Windows.Forms.Label()
        Me.txtDom = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(13, 13)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 0
        Me.lblDNI.Text = "DNI"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(13, 30)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 1
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(135, 9)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(44, 13)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nombre"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(138, 30)
        Me.txtNom.MaxLength = 20
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 3
        '
        'lblApe
        '
        Me.lblApe.AutoSize = True
        Me.lblApe.Location = New System.Drawing.Point(259, 9)
        Me.lblApe.Name = "lblApe"
        Me.lblApe.Size = New System.Drawing.Size(44, 13)
        Me.lblApe.TabIndex = 4
        Me.lblApe.Text = "Apellido"
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(262, 30)
        Me.txtApe.MaxLength = 20
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(100, 20)
        Me.txtApe.TabIndex = 5
        '
        'lblDom
        '
        Me.lblDom.AutoSize = True
        Me.lblDom.Location = New System.Drawing.Point(13, 59)
        Me.lblDom.Name = "lblDom"
        Me.lblDom.Size = New System.Drawing.Size(49, 13)
        Me.lblDom.TabIndex = 6
        Me.lblDom.Text = "Domicilio"
        '
        'txtDom
        '
        Me.txtDom.Location = New System.Drawing.Point(16, 75)
        Me.txtDom.MaxLength = 50
        Me.txtDom.Name = "txtDom"
        Me.txtDom.Size = New System.Drawing.Size(100, 20)
        Me.txtDom.TabIndex = 7
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(138, 75)
        Me.txtTel.MaxLength = 8
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(100, 20)
        Me.txtTel.TabIndex = 8
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Location = New System.Drawing.Point(135, 59)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(49, 13)
        Me.lblTel.TabIndex = 9
        Me.lblTel.Text = "Telefono"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(259, 59)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(32, 13)
        Me.lblMail.TabIndex = 10
        Me.lblMail.Text = "Email"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(262, 75)
        Me.txtMail.MaxLength = 50
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(100, 20)
        Me.txtMail.TabIndex = 11
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(275, 112)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(87, 23)
        Me.btnVerificar.TabIndex = 12
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(16, 112)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(87, 23)
        Me.btnVolver.TabIndex = 13
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 147)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtDom)
        Me.Controls.Add(Me.lblDom)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.lblApe)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lblDNI)
        Me.Name = "frmReg"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblApe As System.Windows.Forms.Label
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents lblDom As System.Windows.Forms.Label
    Friend WithEvents txtDom As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
