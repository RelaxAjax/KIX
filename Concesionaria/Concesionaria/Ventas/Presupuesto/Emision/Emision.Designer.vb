<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmi
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
        Me.gbxTipo = New System.Windows.Forms.GroupBox()
        Me.rdn0km = New System.Windows.Forms.RadioButton()
        Me.rdnUsado = New System.Windows.Forms.RadioButton()
        Me.lblAuto = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnGen = New System.Windows.Forms.Button()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.lstAuto = New System.Windows.Forms.ListView()
        Me.lstMarcas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstModelo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstKm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstInt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblColor = New System.Windows.Forms.Label()
        Me.cbxColor = New System.Windows.Forms.ComboBox()
        Me.gbxTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxTipo
        '
        Me.gbxTipo.Controls.Add(Me.rdn0km)
        Me.gbxTipo.Controls.Add(Me.rdnUsado)
        Me.gbxTipo.Enabled = False
        Me.gbxTipo.Location = New System.Drawing.Point(12, 77)
        Me.gbxTipo.Name = "gbxTipo"
        Me.gbxTipo.Size = New System.Drawing.Size(72, 76)
        Me.gbxTipo.TabIndex = 0
        Me.gbxTipo.TabStop = False
        Me.gbxTipo.Text = "Tipo"
        '
        'rdn0km
        '
        Me.rdn0km.AutoSize = True
        Me.rdn0km.Location = New System.Drawing.Point(6, 19)
        Me.rdn0km.Name = "rdn0km"
        Me.rdn0km.Size = New System.Drawing.Size(45, 17)
        Me.rdn0km.TabIndex = 1
        Me.rdn0km.TabStop = True
        Me.rdn0km.Text = "0km"
        Me.rdn0km.UseVisualStyleBackColor = True
        '
        'rdnUsado
        '
        Me.rdnUsado.AutoSize = True
        Me.rdnUsado.Location = New System.Drawing.Point(6, 42)
        Me.rdnUsado.Name = "rdnUsado"
        Me.rdnUsado.Size = New System.Drawing.Size(56, 17)
        Me.rdnUsado.TabIndex = 0
        Me.rdnUsado.TabStop = True
        Me.rdnUsado.Text = "Usado"
        Me.rdnUsado.UseVisualStyleBackColor = True
        '
        'lblAuto
        '
        Me.lblAuto.AutoSize = True
        Me.lblAuto.Enabled = False
        Me.lblAuto.Location = New System.Drawing.Point(104, 74)
        Me.lblAuto.Name = "lblAuto"
        Me.lblAuto.Size = New System.Drawing.Size(29, 13)
        Me.lblAuto.TabIndex = 2
        Me.lblAuto.Text = "Auto"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 250)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnGen
        '
        Me.btnGen.Enabled = False
        Me.btnGen.Location = New System.Drawing.Point(12, 171)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(75, 42)
        Me.btnGen.TabIndex = 8
        Me.btnGen.Text = "Generar presupuesto"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(18, 32)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 9
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(18, 13)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(64, 13)
        Me.lblDni.TabIndex = 10
        Me.lblDni.Text = "DNI Cliente:"
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(124, 29)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(75, 23)
        Me.btnVer.TabIndex = 11
        Me.btnVer.Text = "Verificar"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'lstAuto
        '
        Me.lstAuto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstMarcas, Me.lstModelo, Me.lstPrecio, Me.lstKm, Me.lstCol, Me.lstInt})
        Me.lstAuto.Enabled = False
        Me.lstAuto.FullRowSelect = True
        Me.lstAuto.HideSelection = False
        Me.lstAuto.Location = New System.Drawing.Point(107, 96)
        Me.lstAuto.MultiSelect = False
        Me.lstAuto.Name = "lstAuto"
        Me.lstAuto.Size = New System.Drawing.Size(284, 177)
        Me.lstAuto.TabIndex = 12
        Me.lstAuto.UseCompatibleStateImageBehavior = False
        Me.lstAuto.View = System.Windows.Forms.View.Details
        '
        'lstMarcas
        '
        Me.lstMarcas.Text = "Marcas"
        Me.lstMarcas.Width = 78
        '
        'lstModelo
        '
        Me.lstModelo.Text = "Modelos"
        Me.lstModelo.Width = 106
        '
        'lstPrecio
        '
        Me.lstPrecio.Text = "Precio"
        Me.lstPrecio.Width = 66
        '
        'lstKm
        '
        Me.lstKm.Text = "Km uso"
        '
        'lstCol
        '
        Me.lstCol.Text = "Color"
        '
        'lstInt
        '
        Me.lstInt.Text = "Interes %"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Enabled = False
        Me.lblColor.Location = New System.Drawing.Point(221, 13)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(31, 13)
        Me.lblColor.TabIndex = 13
        Me.lblColor.Text = "Color"
        '
        'cbxColor
        '
        Me.cbxColor.DisplayMember = "Negro"
        Me.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxColor.Enabled = False
        Me.cbxColor.FormattingEnabled = True
        Me.cbxColor.Items.AddRange(New Object() {"Negro", "Blanco", "Verde", "Rojo oscuro", "Verde oscuro", "Gris", "Rosa", "Azul oscuro", "Azul", "Amarillo"})
        Me.cbxColor.Location = New System.Drawing.Point(224, 30)
        Me.cbxColor.Name = "cbxColor"
        Me.cbxColor.Size = New System.Drawing.Size(121, 21)
        Me.cbxColor.TabIndex = 14
        '
        'frmEmi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 297)
        Me.Controls.Add(Me.cbxColor)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lstAuto)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.lblDni)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.btnGen)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblAuto)
        Me.Controls.Add(Me.gbxTipo)
        Me.Name = "frmEmi"
        Me.Text = "Presupuestos"
        Me.gbxTipo.ResumeLayout(False)
        Me.gbxTipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rdn0km As System.Windows.Forms.RadioButton
    Friend WithEvents rdnUsado As System.Windows.Forms.RadioButton
    Friend WithEvents lblAuto As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnGen As System.Windows.Forms.Button
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents lstAuto As System.Windows.Forms.ListView
    Friend WithEvents lstMarcas As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstModelo As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstPrecio As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstKm As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstCol As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents cbxColor As System.Windows.Forms.ComboBox
    Friend WithEvents lstInt As System.Windows.Forms.ColumnHeader
End Class
