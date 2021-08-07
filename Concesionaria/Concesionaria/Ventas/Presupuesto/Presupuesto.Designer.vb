<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPres
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
        Me.btnEmi = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnVol = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEmi
        '
        Me.btnEmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmi.Location = New System.Drawing.Point(12, 52)
        Me.btnEmi.Name = "btnEmi"
        Me.btnEmi.Size = New System.Drawing.Size(102, 52)
        Me.btnEmi.TabIndex = 0
        Me.btnEmi.Text = "Emitir"
        Me.btnEmi.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnVer.Location = New System.Drawing.Point(170, 52)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(102, 52)
        Me.btnVer.TabIndex = 1
        Me.btnVer.Text = "Verificar"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnVol
        '
        Me.btnVol.Location = New System.Drawing.Point(197, 166)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(75, 23)
        Me.btnVol.TabIndex = 2
        Me.btnVol.Text = "Volver"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'frmPres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 201)
        Me.Controls.Add(Me.btnVol)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnEmi)
        Me.Name = "frmPres"
        Me.Text = "Presupuesto"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEmi As System.Windows.Forms.Button
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents btnVol As System.Windows.Forms.Button
End Class
