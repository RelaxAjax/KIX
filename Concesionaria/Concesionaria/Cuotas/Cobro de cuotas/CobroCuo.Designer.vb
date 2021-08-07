<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCobroCuo
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
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblCont = New System.Windows.Forms.Label()
        Me.txtCont = New System.Windows.Forms.TextBox()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstCuo = New System.Windows.Forms.ListView()
        Me.Num = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fec = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Est = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnVol
        '
        Me.btnVol.Location = New System.Drawing.Point(197, 461)
        Me.btnVol.Name = "btnVol"
        Me.btnVol.Size = New System.Drawing.Size(75, 23)
        Me.btnVol.TabIndex = 0
        Me.btnVol.Text = "Volver"
        Me.btnVol.UseVisualStyleBackColor = True
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(31, 26)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(61, 13)
        Me.lblDNI.TabIndex = 1
        Me.lblDNI.Text = "DNI Cliente"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(12, 50)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 2
        '
        'lblCont
        '
        Me.lblCont.AutoSize = True
        Me.lblCont.Location = New System.Drawing.Point(166, 26)
        Me.lblCont.Name = "lblCont"
        Me.lblCont.Size = New System.Drawing.Size(97, 13)
        Me.lblCont.TabIndex = 3
        Me.lblCont.Text = "Contrato de credito"
        '
        'txtCont
        '
        Me.txtCont.Location = New System.Drawing.Point(163, 50)
        Me.txtCont.Name = "txtCont"
        Me.txtCont.Size = New System.Drawing.Size(100, 20)
        Me.txtCont.TabIndex = 4
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(173, 95)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(75, 23)
        Me.btnVer.TabIndex = 5
        Me.btnVer.Text = "Verificar"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(9, 82)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(140, 13)
        Me.lblCP.TabIndex = 6
        Me.lblCP.Text = "Constancia de compraventa"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(12, 104)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(100, 20)
        Me.txtCP.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "-------------------------------------------------------"
        '
        'lstCuo
        '
        Me.lstCuo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Num, Me.Fec, Me.Est})
        Me.lstCuo.Enabled = False
        Me.lstCuo.Location = New System.Drawing.Point(12, 159)
        Me.lstCuo.Name = "lstCuo"
        Me.lstCuo.Size = New System.Drawing.Size(260, 296)
        Me.lstCuo.TabIndex = 9
        Me.lstCuo.UseCompatibleStateImageBehavior = False
        Me.lstCuo.View = System.Windows.Forms.View.Details
        '
        'Num
        '
        Me.Num.Text = "Numero"
        Me.Num.Width = 74
        '
        'Fec
        '
        Me.Fec.Text = "Fecha"
        Me.Fec.Width = 89
        '
        'Est
        '
        Me.Est.Text = "Estado"
        Me.Est.Width = 91
        '
        'frmCobroCuo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 496)
        Me.Controls.Add(Me.lstCuo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.lblCont)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.btnVol)
        Me.Name = "frmCobroCuo"
        Me.Text = "Cobro de cuotas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVol As System.Windows.Forms.Button
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblCont As System.Windows.Forms.Label
    Friend WithEvents txtCont As System.Windows.Forms.TextBox
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstCuo As System.Windows.Forms.ListView
    Friend WithEvents Num As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fec As System.Windows.Forms.ColumnHeader
    Friend WithEvents Est As System.Windows.Forms.ColumnHeader
End Class
