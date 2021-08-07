<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCre
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
        Me.lstSols = New System.Windows.Forms.ListView()
        Me.NSol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DNI = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Est = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbxMos = New System.Windows.Forms.GroupBox()
        Me.rdnTod = New System.Windows.Forms.RadioButton()
        Me.rdnDes = New System.Windows.Forms.RadioButton()
        Me.rdnApro = New System.Windows.Forms.RadioButton()
        Me.btnVol = New System.Windows.Forms.Button()
        Me.btnEP = New System.Windows.Forms.Button()
        Me.lblAux = New System.Windows.Forms.Label()
        Me.gbxMos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSols
        '
        Me.lstSols.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NSol, Me.Nom, Me.DNI, Me.Est})
        Me.lstSols.FullRowSelect = True
        Me.lstSols.HideSelection = False
        Me.lstSols.Location = New System.Drawing.Point(139, 18)
        Me.lstSols.MultiSelect = False
        Me.lstSols.Name = "lstSols"
        Me.lstSols.Size = New System.Drawing.Size(328, 227)
        Me.lstSols.TabIndex = 0
        Me.lstSols.UseCompatibleStateImageBehavior = False
        Me.lstSols.View = System.Windows.Forms.View.Details
        '
        'NSol
        '
        Me.NSol.Text = "Soli N°"
        '
        'Nom
        '
        Me.Nom.Text = "Nombre"
        Me.Nom.Width = 92
        '
        'DNI
        '
        Me.DNI.Text = "DNI"
        Me.DNI.Width = 92
        '
        'Est
        '
        Me.Est.Text = "Estado"
        Me.Est.Width = 80
        '
        'gbxMos
        '
        Me.gbxMos.Controls.Add(Me.rdnTod)
        Me.gbxMos.Controls.Add(Me.rdnDes)
        Me.gbxMos.Controls.Add(Me.rdnApro)
        Me.gbxMos.Location = New System.Drawing.Point(12, 12)
        Me.gbxMos.Name = "gbxMos"
        Me.gbxMos.Size = New System.Drawing.Size(106, 96)
        Me.gbxMos.TabIndex = 1
        Me.gbxMos.TabStop = False
        Me.gbxMos.Text = "Mostrar:"
        '
        'rdnTod
        '
        Me.rdnTod.AutoSize = True
        Me.rdnTod.Checked = True
        Me.rdnTod.Location = New System.Drawing.Point(7, 66)
        Me.rdnTod.Name = "rdnTod"
        Me.rdnTod.Size = New System.Drawing.Size(55, 17)
        Me.rdnTod.TabIndex = 2
        Me.rdnTod.TabStop = True
        Me.rdnTod.Text = "Todos"
        Me.rdnTod.UseVisualStyleBackColor = True
        '
        'rdnDes
        '
        Me.rdnDes.AutoSize = True
        Me.rdnDes.Location = New System.Drawing.Point(7, 42)
        Me.rdnDes.Name = "rdnDes"
        Me.rdnDes.Size = New System.Drawing.Size(94, 17)
        Me.rdnDes.TabIndex = 1
        Me.rdnDes.Text = "Desaprobados"
        Me.rdnDes.UseVisualStyleBackColor = True
        '
        'rdnApro
        '
        Me.rdnApro.AutoSize = True
        Me.rdnApro.Location = New System.Drawing.Point(7, 19)
        Me.rdnApro.Name = "rdnApro"
        Me.rdnApro.Size = New System.Drawing.Size(76, 17)
        Me.rdnApro.TabIndex = 0
        Me.rdnApro.Text = "Aprobados"
        Me.rdnApro.UseVisualStyleBackColor = True
        '
        'btnVol
        '
        Me.btnVol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnVol.Location = New System.Drawing.Point(19, 219)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(94, 43)
        Me.btnVol.TabIndex = 2
        Me.btnVol.Text = "Volver"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'btnEP
        '
        Me.btnEP.Enabled = False
        Me.btnEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEP.Location = New System.Drawing.Point(19, 136)
        Me.btnEP.Name = "btnEP"
        Me.btnEP.Size = New System.Drawing.Size(94, 73)
        Me.btnEP.TabIndex = 3
        Me.btnEP.Text = "Emitir contrato de credito y solicitud de poliza"
        Me.btnEP.UseVisualStyleBackColor = True
        '
        'lblAux
        '
        Me.lblAux.AutoSize = True
        Me.lblAux.Location = New System.Drawing.Point(119, 196)
        Me.lblAux.Name = "lblAux"
        Me.lblAux.Size = New System.Drawing.Size(0, 13)
        Me.lblAux.TabIndex = 4
        Me.lblAux.Visible = False
        '
        'frmCre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 283)
        Me.Controls.Add(Me.lblAux)
        Me.Controls.Add(Me.btnEP)
        Me.Controls.Add(Me.btnVol)
        Me.Controls.Add(Me.gbxMos)
        Me.Controls.Add(Me.lstSols)
        Me.Name = "frmCre"
        Me.Text = "Credito"
        Me.gbxMos.ResumeLayout(False)
        Me.gbxMos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstSols As System.Windows.Forms.ListView
    Friend WithEvents Nom As System.Windows.Forms.ColumnHeader
    Friend WithEvents DNI As System.Windows.Forms.ColumnHeader
    Friend WithEvents Est As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbxMos As System.Windows.Forms.GroupBox
    Friend WithEvents rdnDes As System.Windows.Forms.RadioButton
    Friend WithEvents rdnApro As System.Windows.Forms.RadioButton
    Friend WithEvents btnVol As System.Windows.Forms.Button
    Friend WithEvents btnEP As System.Windows.Forms.Button
    Friend WithEvents NSol As System.Windows.Forms.ColumnHeader
    Friend WithEvents rdnTod As System.Windows.Forms.RadioButton
    Friend WithEvents lblAux As System.Windows.Forms.Label
End Class
