<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsRes
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
        Me.btnVol = New System.Windows.Forms.Button()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtPres = New System.Windows.Forms.TextBox()
        Me.lblPre = New System.Windows.Forms.Label()
        Me.gbxMet = New System.Windows.Forms.GroupBox()
        Me.rdnEfe = New System.Windows.Forms.RadioButton()
        Me.rdnCre = New System.Windows.Forms.RadioButton()
        Me.btnSen = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.lblAux = New System.Windows.Forms.Label()
        Me.gbxMet.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVol
        '
        Me.btnVol.Location = New System.Drawing.Point(102, 186)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(75, 23)
        Me.btnVol.TabIndex = 0
        Me.btnVol.Text = "Volver"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(12, 39)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 1
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(12, 16)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(64, 13)
        Me.lblDNI.TabIndex = 2
        Me.lblDNI.Text = "DNI Cliente:"
        '
        'txtPres
        '
        Me.txtPres.Location = New System.Drawing.Point(139, 39)
        Me.txtPres.Name = "txtPres"
        Me.txtPres.Size = New System.Drawing.Size(100, 20)
        Me.txtPres.TabIndex = 3
        '
        'lblPre
        '
        Me.lblPre.AutoSize = True
        Me.lblPre.Location = New System.Drawing.Point(135, 17)
        Me.lblPre.Name = "lblPre"
        Me.lblPre.Size = New System.Drawing.Size(84, 13)
        Me.lblPre.TabIndex = 4
        Me.lblPre.Text = "Nº Presupuesto:"
        '
        'gbxMet
        '
        Me.gbxMet.Controls.Add(Me.rdnEfe)
        Me.gbxMet.Controls.Add(Me.rdnCre)
        Me.gbxMet.Enabled = False
        Me.gbxMet.Location = New System.Drawing.Point(3, 105)
        Me.gbxMet.Name = "gbxMet"
        Me.gbxMet.Size = New System.Drawing.Size(75, 72)
        Me.gbxMet.TabIndex = 5
        Me.gbxMet.TabStop = False
        Me.gbxMet.Text = "Metodo"
        '
        'rdnEfe
        '
        Me.rdnEfe.AutoSize = True
        Me.rdnEfe.Location = New System.Drawing.Point(7, 44)
        Me.rdnEfe.Name = "rdnEfe"
        Me.rdnEfe.Size = New System.Drawing.Size(64, 17)
        Me.rdnEfe.TabIndex = 1
        Me.rdnEfe.TabStop = True
        Me.rdnEfe.Text = "Efectivo"
        Me.rdnEfe.UseVisualStyleBackColor = True
        '
        'rdnCre
        '
        Me.rdnCre.AutoSize = True
        Me.rdnCre.Location = New System.Drawing.Point(7, 20)
        Me.rdnCre.Name = "rdnCre"
        Me.rdnCre.Size = New System.Drawing.Size(58, 17)
        Me.rdnCre.TabIndex = 0
        Me.rdnCre.TabStop = True
        Me.rdnCre.Text = "Credito"
        Me.rdnCre.UseVisualStyleBackColor = True
        '
        'btnSen
        '
        Me.btnSen.Enabled = False
        Me.btnSen.Location = New System.Drawing.Point(127, 113)
        Me.btnSen.Name = "btnSen"
        Me.btnSen.Size = New System.Drawing.Size(81, 41)
        Me.btnSen.TabIndex = 6
        Me.btnSen.Text = "Seña"
        Me.btnSen.UseVisualStyleBackColor = True
        '
        'btnSig
        '
        Me.btnSig.Enabled = False
        Me.btnSig.Location = New System.Drawing.Point(197, 186)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(75, 23)
        Me.btnSig.TabIndex = 7
        Me.btnSig.Text = "Siguiente"
        Me.btnSig.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(82, 74)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(75, 23)
        Me.btnVer.TabIndex = 8
        Me.btnVer.Text = "Verificar"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'lblAux
        '
        Me.lblAux.AutoSize = True
        Me.lblAux.Location = New System.Drawing.Point(233, 83)
        Me.lblAux.Name = "lblAux"
        Me.lblAux.Size = New System.Drawing.Size(13, 13)
        Me.lblAux.TabIndex = 9
        Me.lblAux.Text = "0"
        Me.lblAux.Visible = False
        '
        'frmConsRes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 221)
        Me.Controls.Add(Me.lblAux)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnSen)
        Me.Controls.Add(Me.gbxMet)
        Me.Controls.Add(Me.lblPre)
        Me.Controls.Add(Me.txtPres)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.btnVol)
        Me.Name = "frmConsRes"
        Me.Text = "Verificar presupuesto"
        Me.gbxMet.ResumeLayout(False)
        Me.gbxMet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVol As System.Windows.Forms.Button
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtPres As System.Windows.Forms.TextBox
    Friend WithEvents lblPre As System.Windows.Forms.Label
    Friend WithEvents gbxMet As System.Windows.Forms.GroupBox
    Friend WithEvents rdnEfe As System.Windows.Forms.RadioButton
    Friend WithEvents rdnCre As System.Windows.Forms.RadioButton
    Friend WithEvents btnSen As System.Windows.Forms.Button
    Friend WithEvents btnSig As System.Windows.Forms.Button
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents lblAux As System.Windows.Forms.Label
End Class
