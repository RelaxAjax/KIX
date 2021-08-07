<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocC))
        Me.lblTit = New System.Windows.Forms.Label()
        Me.lblCuerpo = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblApe = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblTit2 = New System.Windows.Forms.Label()
        Me.lblMod = New System.Windows.Forms.Label()
        Me.lblMar = New System.Windows.Forms.Label()
        Me.lblNB = New System.Windows.Forms.Label()
        Me.lblTit3 = New System.Windows.Forms.Label()
        Me.lblCond1 = New System.Windows.Forms.Label()
        Me.lblCond2 = New System.Windows.Forms.Label()
        Me.lblCond3 = New System.Windows.Forms.Label()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.lblCond = New System.Windows.Forms.Label()
        Me.lblNCons = New System.Windows.Forms.Label()
        Me.lblCol = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTit
        '
        Me.lblTit.AutoSize = True
        Me.lblTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit.Location = New System.Drawing.Point(131, 9)
        Me.lblTit.Name = "lblTit"
        Me.lblTit.Size = New System.Drawing.Size(439, 25)
        Me.lblTit.TabIndex = 0
        Me.lblTit.Text = "Constancia de compraventa del vehiculo"
        '
        'lblCuerpo
        '
        Me.lblCuerpo.AutoSize = True
        Me.lblCuerpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuerpo.Location = New System.Drawing.Point(17, 101)
        Me.lblCuerpo.Name = "lblCuerpo"
        Me.lblCuerpo.Size = New System.Drawing.Size(388, 36)
        Me.lblCuerpo.TabIndex = 1
        Me.lblCuerpo.Text = "En el día …./…./…… la empresa KIX domiciliada en calle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tres arroyos 4587 se dis" & _
            "pone de venderle un automóvil a:"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(20, 152)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(126, 18)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nombre: ……………….."
        '
        'lblApe
        '
        Me.lblApe.AutoSize = True
        Me.lblApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApe.Location = New System.Drawing.Point(20, 181)
        Me.lblApe.Name = "lblApe"
        Me.lblApe.Size = New System.Drawing.Size(123, 18)
        Me.lblApe.TabIndex = 3
        Me.lblApe.Text = "Apellido: ……………….."
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(20, 209)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(117, 18)
        Me.lblDNI.TabIndex = 4
        Me.lblDNI.Text = "DNI: ………………………."
        '
        'lblTit2
        '
        Me.lblTit2.AutoSize = True
        Me.lblTit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit2.Location = New System.Drawing.Point(15, 254)
        Me.lblTit2.Name = "lblTit2"
        Me.lblTit2.Size = New System.Drawing.Size(214, 25)
        Me.lblTit2.TabIndex = 5
        Me.lblTit2.Text = "Datos del vehículo:"
        '
        'lblMod
        '
        Me.lblMod.AutoSize = True
        Me.lblMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMod.Location = New System.Drawing.Point(20, 304)
        Me.lblMod.Name = "lblMod"
        Me.lblMod.Size = New System.Drawing.Size(162, 18)
        Me.lblMod.TabIndex = 6
        Me.lblMod.Text = "Modelo: ………………………………"
        '
        'lblMar
        '
        Me.lblMar.AutoSize = True
        Me.lblMar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMar.Location = New System.Drawing.Point(20, 331)
        Me.lblMar.Name = "lblMar"
        Me.lblMar.Size = New System.Drawing.Size(154, 18)
        Me.lblMar.TabIndex = 7
        Me.lblMar.Text = "Marca: ………………………………"
        '
        'lblNB
        '
        Me.lblNB.AutoSize = True
        Me.lblNB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNB.Location = New System.Drawing.Point(20, 359)
        Me.lblNB.Name = "lblNB"
        Me.lblNB.Size = New System.Drawing.Size(189, 18)
        Me.lblNB.TabIndex = 8
        Me.lblNB.Text = "Nº de bastidor: ……………………….."
        '
        'lblTit3
        '
        Me.lblTit3.AutoSize = True
        Me.lblTit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit3.Location = New System.Drawing.Point(20, 407)
        Me.lblTit3.Name = "lblTit3"
        Me.lblTit3.Size = New System.Drawing.Size(149, 25)
        Me.lblTit3.TabIndex = 9
        Me.lblTit3.Text = "Condiciones:"
        '
        'lblCond1
        '
        Me.lblCond1.AutoSize = True
        Me.lblCond1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCond1.Location = New System.Drawing.Point(23, 450)
        Me.lblCond1.Name = "lblCond1"
        Me.lblCond1.Size = New System.Drawing.Size(425, 36)
        Me.lblCond1.TabIndex = 10
        Me.lblCond1.Text = "1)La empresa KIX vende al comprador el vehículo especificado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por la cantidad de" & _
            " $.................., IVA e intereses incluidos"
        '
        'lblCond2
        '
        Me.lblCond2.AutoSize = True
        Me.lblCond2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCond2.Location = New System.Drawing.Point(26, 509)
        Me.lblCond2.Name = "lblCond2"
        Me.lblCond2.Size = New System.Drawing.Size(424, 36)
        Me.lblCond2.TabIndex = 11
        Me.lblCond2.Text = "2)El comprador se compromete a pagar en el método de pago " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de crédito/efectivo p" & _
            "or el monto especificado anteriormente."
        '
        'lblCond3
        '
        Me.lblCond3.AutoSize = True
        Me.lblCond3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCond3.Location = New System.Drawing.Point(29, 563)
        Me.lblCond3.Name = "lblCond3"
        Me.lblCond3.Size = New System.Drawing.Size(409, 108)
        Me.lblCond3.TabIndex = 12
        Me.lblCond3.Text = resources.GetString("lblCond3.Text")
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(495, 648)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 23)
        Me.btnImp.TabIndex = 13
        Me.btnImp.Text = "Imprimir"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'lblCond
        '
        Me.lblCond.AutoSize = True
        Me.lblCond.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCond.Location = New System.Drawing.Point(225, 304)
        Me.lblCond.Name = "lblCond"
        Me.lblCond.Size = New System.Drawing.Size(240, 18)
        Me.lblCond.TabIndex = 14
        Me.lblCond.Text = "Condicion del vehiculo: ..................."
        '
        'lblNCons
        '
        Me.lblNCons.AutoSize = True
        Me.lblNCons.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNCons.Location = New System.Drawing.Point(491, 44)
        Me.lblNCons.Name = "lblNCons"
        Me.lblNCons.Size = New System.Drawing.Size(71, 24)
        Me.lblNCons.TabIndex = 15
        Me.lblNCons.Text = "Nº: ......"
        '
        'lblCol
        '
        Me.lblCol.AutoSize = True
        Me.lblCol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol.Location = New System.Drawing.Point(225, 331)
        Me.lblCol.Name = "lblCol"
        Me.lblCol.Size = New System.Drawing.Size(121, 18)
        Me.lblCol.TabIndex = 16
        Me.lblCol.Text = "Color: ................."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "LOGO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmDocC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 688)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCol)
        Me.Controls.Add(Me.lblNCons)
        Me.Controls.Add(Me.lblCond)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.lblCond3)
        Me.Controls.Add(Me.lblCond2)
        Me.Controls.Add(Me.lblCond1)
        Me.Controls.Add(Me.lblTit3)
        Me.Controls.Add(Me.lblNB)
        Me.Controls.Add(Me.lblMar)
        Me.Controls.Add(Me.lblMod)
        Me.Controls.Add(Me.lblTit2)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblApe)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblCuerpo)
        Me.Controls.Add(Me.lblTit)
        Me.Name = "frmDocC"
        Me.Text = "DocConst"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTit As System.Windows.Forms.Label
    Friend WithEvents lblCuerpo As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblApe As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblTit2 As System.Windows.Forms.Label
    Friend WithEvents lblMod As System.Windows.Forms.Label
    Friend WithEvents lblMar As System.Windows.Forms.Label
    Friend WithEvents lblNB As System.Windows.Forms.Label
    Friend WithEvents lblTit3 As System.Windows.Forms.Label
    Friend WithEvents lblCond1 As System.Windows.Forms.Label
    Friend WithEvents lblCond2 As System.Windows.Forms.Label
    Friend WithEvents lblCond3 As System.Windows.Forms.Label
    Friend WithEvents btnImp As System.Windows.Forms.Button
    Friend WithEvents lblCond As System.Windows.Forms.Label
    Friend WithEvents lblNCons As System.Windows.Forms.Label
    Friend WithEvents lblCol As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
