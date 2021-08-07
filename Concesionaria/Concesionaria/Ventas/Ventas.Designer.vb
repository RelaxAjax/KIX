<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Me.btnPresupuesto = New System.Windows.Forms.Button()
        Me.btnCons = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCreditos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPresupuesto
        '
        Me.btnPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresupuesto.Location = New System.Drawing.Point(12, 53)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(126, 52)
        Me.btnPresupuesto.TabIndex = 0
        Me.btnPresupuesto.Text = "Presupuestos"
        Me.btnPresupuesto.UseVisualStyleBackColor = True
        '
        'btnCons
        '
        Me.btnCons.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCons.Location = New System.Drawing.Point(178, 53)
        Me.btnCons.Name = "btnCons"
        Me.btnCons.Size = New System.Drawing.Size(126, 52)
        Me.btnCons.TabIndex = 1
        Me.btnCons.Text = "Constancias de compraventa"
        Me.btnCons.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(25, 141)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(87, 28)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnCreditos
        '
        Me.btnCreditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditos.Location = New System.Drawing.Point(178, 128)
        Me.btnCreditos.Name = "btnCreditos"
        Me.btnCreditos.Size = New System.Drawing.Size(126, 52)
        Me.btnCreditos.TabIndex = 3
        Me.btnCreditos.Text = "Credito Pendiario"
        Me.btnCreditos.UseVisualStyleBackColor = True
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 198)
        Me.Controls.Add(Me.btnCreditos)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnCons)
        Me.Controls.Add(Me.btnPresupuesto)
        Me.Name = "frmVenta"
        Me.Text = "Venta"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPresupuesto As System.Windows.Forms.Button
    Friend WithEvents btnCons As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnCreditos As System.Windows.Forms.Button

End Class
