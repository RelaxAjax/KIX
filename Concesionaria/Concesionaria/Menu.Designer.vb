<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnAcc = New System.Windows.Forms.Button()
        Me.btnCuo = New System.Windows.Forms.Button()
        Me.btnRep = New System.Windows.Forms.Button()
        Me.btnRec = New System.Windows.Forms.Button()
        Me.btnCom = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.Label()
        Me.btnVentaA = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAcc
        '
        Me.btnAcc.Enabled = False
        Me.btnAcc.Location = New System.Drawing.Point(136, 149)
        Me.btnAcc.Name = "btnAcc"
        Me.btnAcc.Size = New System.Drawing.Size(89, 39)
        Me.btnAcc.TabIndex = 1
        Me.btnAcc.Text = "Accesorios"
        Me.btnAcc.UseVisualStyleBackColor = True
        '
        'btnCuo
        '
        Me.btnCuo.Enabled = False
        Me.btnCuo.Location = New System.Drawing.Point(260, 89)
        Me.btnCuo.Name = "btnCuo"
        Me.btnCuo.Size = New System.Drawing.Size(89, 39)
        Me.btnCuo.TabIndex = 2
        Me.btnCuo.Text = "Cuotas"
        Me.btnCuo.UseVisualStyleBackColor = True
        '
        'btnRep
        '
        Me.btnRep.Enabled = False
        Me.btnRep.Location = New System.Drawing.Point(136, 89)
        Me.btnRep.Name = "btnRep"
        Me.btnRep.Size = New System.Drawing.Size(89, 39)
        Me.btnRep.TabIndex = 3
        Me.btnRep.Text = "Reparacion"
        Me.btnRep.UseVisualStyleBackColor = True
        '
        'btnRec
        '
        Me.btnRec.Enabled = False
        Me.btnRec.Location = New System.Drawing.Point(260, 149)
        Me.btnRec.Name = "btnRec"
        Me.btnRec.Size = New System.Drawing.Size(89, 39)
        Me.btnRec.TabIndex = 4
        Me.btnRec.Text = "Reciclado"
        Me.btnRec.UseVisualStyleBackColor = True
        '
        'btnCom
        '
        Me.btnCom.Enabled = False
        Me.btnCom.Location = New System.Drawing.Point(12, 89)
        Me.btnCom.Name = "btnCom"
        Me.btnCom.Size = New System.Drawing.Size(89, 39)
        Me.btnCom.TabIndex = 5
        Me.btnCom.Text = "Compra de autos usados"
        Me.btnCom.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(12, 149)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 39)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Recepcion de mercaderia"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Logo
        '
        Me.Logo.AutoSize = True
        Me.Logo.Location = New System.Drawing.Point(47, 36)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(31, 13)
        Me.Logo.TabIndex = 7
        Me.Logo.Text = "Logo"
        '
        'btnVentaA
        '
        Me.btnVentaA.Location = New System.Drawing.Point(260, 23)
        Me.btnVentaA.Name = "btnVentaA"
        Me.btnVentaA.Size = New System.Drawing.Size(89, 39)
        Me.btnVentaA.TabIndex = 0
        Me.btnVentaA.Text = "Venta de autos"
        Me.btnVentaA.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 200)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnCom)
        Me.Controls.Add(Me.btnRec)
        Me.Controls.Add(Me.btnRep)
        Me.Controls.Add(Me.btnCuo)
        Me.Controls.Add(Me.btnAcc)
        Me.Controls.Add(Me.btnVentaA)
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAcc As System.Windows.Forms.Button
    Friend WithEvents btnCuo As System.Windows.Forms.Button
    Friend WithEvents btnRep As System.Windows.Forms.Button
    Friend WithEvents btnRec As System.Windows.Forms.Button
    Friend WithEvents btnCom As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Logo As System.Windows.Forms.Label
    Friend WithEvents btnVentaA As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
