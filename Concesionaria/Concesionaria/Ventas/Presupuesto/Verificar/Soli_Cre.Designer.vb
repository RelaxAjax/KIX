<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolC
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
        Me.txtTra = New System.Windows.Forms.TextBox()
        Me.txtSal = New System.Windows.Forms.TextBox()
        Me.btnSIg = New System.Windows.Forms.Button()
        Me.lblTra = New System.Windows.Forms.Label()
        Me.lblSal = New System.Windows.Forms.Label()
        Me.txtCUIL = New System.Windows.Forms.TextBox()
        Me.lblCUIL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTra
        '
        Me.txtTra.Location = New System.Drawing.Point(12, 44)
        Me.txtTra.MaxLength = 50
        Me.txtTra.Name = "txtTra"
        Me.txtTra.Size = New System.Drawing.Size(100, 20)
        Me.txtTra.TabIndex = 0
        '
        'txtSal
        '
        Me.txtSal.Location = New System.Drawing.Point(148, 44)
        Me.txtSal.MaxLength = 7
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Size = New System.Drawing.Size(100, 20)
        Me.txtSal.TabIndex = 1
        '
        'btnSIg
        '
        Me.btnSIg.Location = New System.Drawing.Point(161, 93)
        Me.btnSIg.Name = "btnSIg"
        Me.btnSIg.Size = New System.Drawing.Size(75, 23)
        Me.btnSIg.TabIndex = 2
        Me.btnSIg.Text = "Siguiente"
        Me.btnSIg.UseVisualStyleBackColor = True
        '
        'lblTra
        '
        Me.lblTra.AutoSize = True
        Me.lblTra.Location = New System.Drawing.Point(20, 18)
        Me.lblTra.Name = "lblTra"
        Me.lblTra.Size = New System.Drawing.Size(84, 13)
        Me.lblTra.TabIndex = 3
        Me.lblTra.Text = "Lugar de trabajo"
        '
        'lblSal
        '
        Me.lblSal.AutoSize = True
        Me.lblSal.Location = New System.Drawing.Point(178, 18)
        Me.lblSal.Name = "lblSal"
        Me.lblSal.Size = New System.Drawing.Size(39, 13)
        Me.lblSal.TabIndex = 4
        Me.lblSal.Text = "Salario"
        '
        'txtCUIL
        '
        Me.txtCUIL.Location = New System.Drawing.Point(284, 44)
        Me.txtCUIL.MaxLength = 11
        Me.txtCUIL.Name = "txtCUIL"
        Me.txtCUIL.Size = New System.Drawing.Size(100, 20)
        Me.txtCUIL.TabIndex = 5
        '
        'lblCUIL
        '
        Me.lblCUIL.AutoSize = True
        Me.lblCUIL.Location = New System.Drawing.Point(323, 18)
        Me.lblCUIL.Name = "lblCUIL"
        Me.lblCUIL.Size = New System.Drawing.Size(31, 13)
        Me.lblCUIL.TabIndex = 6
        Me.lblCUIL.Text = "CUIL"
        '
        'frmSolC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 128)
        Me.Controls.Add(Me.lblCUIL)
        Me.Controls.Add(Me.txtCUIL)
        Me.Controls.Add(Me.lblSal)
        Me.Controls.Add(Me.lblTra)
        Me.Controls.Add(Me.btnSIg)
        Me.Controls.Add(Me.txtSal)
        Me.Controls.Add(Me.txtTra)
        Me.Name = "frmSolC"
        Me.Text = "Datos crediticios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTra As System.Windows.Forms.TextBox
    Friend WithEvents txtSal As System.Windows.Forms.TextBox
    Friend WithEvents btnSIg As System.Windows.Forms.Button
    Friend WithEvents lblTra As System.Windows.Forms.Label
    Friend WithEvents lblSal As System.Windows.Forms.Label
    Friend WithEvents txtCUIL As System.Windows.Forms.TextBox
    Friend WithEvents lblCUIL As System.Windows.Forms.Label
End Class
