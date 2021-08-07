<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocConsRes
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
        Me.lblTit = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblCl = New System.Windows.Forms.Label()
        Me.lblAuto = New System.Windows.Forms.Label()
        Me.lblAu = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblCondicion = New System.Windows.Forms.Label()
        Me.lblCond = New System.Windows.Forms.Label()
        Me.lblPresupuesto = New System.Windows.Forms.Label()
        Me.lblPre = New System.Windows.Forms.Label()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.lblSena = New System.Windows.Forms.Label()
        Me.lblSen = New System.Windows.Forms.Label()
        Me.lblMetodoPago = New System.Windows.Forms.Label()
        Me.lblMetP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTit
        '
        Me.lblTit.AutoSize = True
        Me.lblTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit.Location = New System.Drawing.Point(13, 13)
        Me.lblTit.Name = "lblTit"
        Me.lblTit.Size = New System.Drawing.Size(249, 25)
        Me.lblTit.TabIndex = 0
        Me.lblTit.Text = "Constancia de reserva"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(16, 72)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(57, 18)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente:"
        '
        'lblCl
        '
        Me.lblCl.AutoSize = True
        Me.lblCl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblCl.Location = New System.Drawing.Point(16, 98)
        Me.lblCl.Name = "lblCl"
        Me.lblCl.Size = New System.Drawing.Size(68, 18)
        Me.lblCl.TabIndex = 2
        Me.lblCl.Text = "..............."
        '
        'lblAuto
        '
        Me.lblAuto.AutoSize = True
        Me.lblAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblAuto.Location = New System.Drawing.Point(134, 72)
        Me.lblAuto.Name = "lblAuto"
        Me.lblAuto.Size = New System.Drawing.Size(42, 18)
        Me.lblAuto.TabIndex = 3
        Me.lblAuto.Text = "Auto:"
        '
        'lblAu
        '
        Me.lblAu.AutoSize = True
        Me.lblAu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblAu.Location = New System.Drawing.Point(134, 98)
        Me.lblAu.Name = "lblAu"
        Me.lblAu.Size = New System.Drawing.Size(64, 18)
        Me.lblAu.TabIndex = 4
        Me.lblAu.Text = ".............."
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(278, 14)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(55, 24)
        Me.lblNum.TabIndex = 5
        Me.lblNum.Text = "N°:...."
        '
        'lblCondicion
        '
        Me.lblCondicion.AutoSize = True
        Me.lblCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblCondicion.Location = New System.Drawing.Point(19, 132)
        Me.lblCondicion.Name = "lblCondicion"
        Me.lblCondicion.Size = New System.Drawing.Size(79, 18)
        Me.lblCondicion.TabIndex = 6
        Me.lblCondicion.Text = "Condicion:"
        '
        'lblCond
        '
        Me.lblCond.AutoSize = True
        Me.lblCond.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblCond.Location = New System.Drawing.Point(19, 165)
        Me.lblCond.Name = "lblCond"
        Me.lblCond.Size = New System.Drawing.Size(64, 18)
        Me.lblCond.TabIndex = 7
        Me.lblCond.Text = ".............."
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblPresupuesto.Location = New System.Drawing.Point(134, 132)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(115, 18)
        Me.lblPresupuesto.TabIndex = 8
        Me.lblPresupuesto.Text = "N° presupuesto:"
        '
        'lblPre
        '
        Me.lblPre.AutoSize = True
        Me.lblPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblPre.Location = New System.Drawing.Point(134, 165)
        Me.lblPre.Name = "lblPre"
        Me.lblPre.Size = New System.Drawing.Size(60, 18)
        Me.lblPre.TabIndex = 9
        Me.lblPre.Text = "............."
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(304, 209)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 23)
        Me.btnImp.TabIndex = 10
        Me.btnImp.Text = "Imprimir"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'lblSena
        '
        Me.lblSena.AutoSize = True
        Me.lblSena.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblSena.Location = New System.Drawing.Point(279, 72)
        Me.lblSena.Name = "lblSena"
        Me.lblSena.Size = New System.Drawing.Size(46, 18)
        Me.lblSena.TabIndex = 11
        Me.lblSena.Text = "Seña:"
        '
        'lblSen
        '
        Me.lblSen.AutoSize = True
        Me.lblSen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblSen.Location = New System.Drawing.Point(279, 98)
        Me.lblSen.Name = "lblSen"
        Me.lblSen.Size = New System.Drawing.Size(36, 18)
        Me.lblSen.TabIndex = 12
        Me.lblSen.Text = "......."
        '
        'lblMetodoPago
        '
        Me.lblMetodoPago.AutoSize = True
        Me.lblMetodoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetodoPago.Location = New System.Drawing.Point(279, 132)
        Me.lblMetodoPago.Name = "lblMetodoPago"
        Me.lblMetodoPago.Size = New System.Drawing.Size(100, 18)
        Me.lblMetodoPago.TabIndex = 13
        Me.lblMetodoPago.Text = "Metodo pago:"
        '
        'lblMetP
        '
        Me.lblMetP.AutoSize = True
        Me.lblMetP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetP.Location = New System.Drawing.Point(279, 165)
        Me.lblMetP.Name = "lblMetP"
        Me.lblMetP.Size = New System.Drawing.Size(60, 18)
        Me.lblMetP.TabIndex = 14
        Me.lblMetP.Text = "............."
        '
        'frmDocConsRes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 244)
        Me.Controls.Add(Me.lblMetP)
        Me.Controls.Add(Me.lblMetodoPago)
        Me.Controls.Add(Me.lblSen)
        Me.Controls.Add(Me.lblSena)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.lblPre)
        Me.Controls.Add(Me.lblPresupuesto)
        Me.Controls.Add(Me.lblCond)
        Me.Controls.Add(Me.lblCondicion)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblAu)
        Me.Controls.Add(Me.lblAuto)
        Me.Controls.Add(Me.lblCl)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblTit)
        Me.Name = "frmDocConsRes"
        Me.Text = "Constancia de reserva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTit As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblCl As System.Windows.Forms.Label
    Friend WithEvents lblAuto As System.Windows.Forms.Label
    Friend WithEvents lblAu As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents lblCondicion As System.Windows.Forms.Label
    Friend WithEvents lblCond As System.Windows.Forms.Label
    Friend WithEvents lblPresupuesto As System.Windows.Forms.Label
    Friend WithEvents lblPre As System.Windows.Forms.Label
    Friend WithEvents btnImp As System.Windows.Forms.Button
    Friend WithEvents lblSena As System.Windows.Forms.Label
    Friend WithEvents lblSen As System.Windows.Forms.Label
    Friend WithEvents lblMetodoPago As System.Windows.Forms.Label
    Friend WithEvents lblMetP As System.Windows.Forms.Label
End Class
