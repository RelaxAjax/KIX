<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuotas
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
        Me.btnCMor = New System.Windows.Forms.Button()
        Me.btnCCuo = New System.Windows.Forms.Button()
        Me.btnVol = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCMor
        '
        Me.btnCMor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCMor.Location = New System.Drawing.Point(165, 39)
        Me.btnCMor.Name = "btnCMor"
        Me.btnCMor.Size = New System.Drawing.Size(107, 49)
        Me.btnCMor.TabIndex = 0
        Me.btnCMor.Text = "Control de morosos"
        Me.btnCMor.UseVisualStyleBackColor = True
        '
        'btnCCuo
        '
        Me.btnCCuo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCCuo.Location = New System.Drawing.Point(12, 39)
        Me.btnCCuo.Name = "btnCCuo"
        Me.btnCCuo.Size = New System.Drawing.Size(107, 49)
        Me.btnCCuo.TabIndex = 1
        Me.btnCCuo.Text = "Cobro de cuotas"
        Me.btnCCuo.UseVisualStyleBackColor = True
        '
        'btnVol
        '
        Me.btnVol.Location = New System.Drawing.Point(197, 127)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(75, 23)
        Me.btnVol.TabIndex = 2
        Me.btnVol.Text = "Volver"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'Cuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.btnVol)
        Me.Controls.Add(Me.btnCCuo)
        Me.Controls.Add(Me.btnCMor)
        Me.Name = "Cuotas"
        Me.Text = "Cuotas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCMor As System.Windows.Forms.Button
    Friend WithEvents btnCCuo As System.Windows.Forms.Button
    Friend WithEvents btnVol As System.Windows.Forms.Button
End Class
