<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocCCre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocCCre))
        Me.lblTit = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblFE = New System.Windows.Forms.Label()
        Me.lblFV = New System.Windows.Forms.Label()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.lblSTIT2 = New System.Windows.Forms.Label()
        Me.lblCue2 = New System.Windows.Forms.Label()
        Me.lblSTIT1 = New System.Windows.Forms.Label()
        Me.lblCue1 = New System.Windows.Forms.Label()
        Me.lblFirmaC = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFirmaV = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTit
        '
        Me.lblTit.AutoSize = True
        Me.lblTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit.Location = New System.Drawing.Point(13, 13)
        Me.lblTit.Name = "lblTit"
        Me.lblTit.Size = New System.Drawing.Size(327, 25)
        Me.lblTit.TabIndex = 0
        Me.lblTit.Text = "Contrato de credito prendiario"
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.Location = New System.Drawing.Point(349, 13)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(80, 25)
        Me.lblN.TabIndex = 1
        Me.lblN.Text = "N°: ......."
        '
        'lblFE
        '
        Me.lblFE.AutoSize = True
        Me.lblFE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblFE.Location = New System.Drawing.Point(21, 57)
        Me.lblFE.Name = "lblFE"
        Me.lblFE.Size = New System.Drawing.Size(205, 18)
        Me.lblFE.TabIndex = 2
        Me.lblFE.Text = "Fecha de emision: ..../..../........"
        '
        'lblFV
        '
        Me.lblFV.AutoSize = True
        Me.lblFV.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFV.Location = New System.Drawing.Point(21, 87)
        Me.lblFV.Name = "lblFV"
        Me.lblFV.Size = New System.Drawing.Size(232, 18)
        Me.lblFV.TabIndex = 3
        Me.lblFV.Text = "Fecha de vencimiento: ..../..../........"
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblMoneda.Location = New System.Drawing.Point(21, 117)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(187, 18)
        Me.lblMoneda.TabIndex = 4
        Me.lblMoneda.Text = "Moneda: Pesos Argentinos"
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblAd.Location = New System.Drawing.Point(21, 162)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(412, 36)
        Me.lblAd.TabIndex = 5
        Me.lblAd.Text = "Este contrato solo se le puede ser dado a usted desde " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "una consesionaria KIX, en" & _
            " cualquiera de nuestras sucursales."
        '
        'lblSTIT2
        '
        Me.lblSTIT2.AutoSize = True
        Me.lblSTIT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSTIT2.Location = New System.Drawing.Point(14, 333)
        Me.lblSTIT2.Name = "lblSTIT2"
        Me.lblSTIT2.Size = New System.Drawing.Size(131, 20)
        Me.lblSTIT2.TabIndex = 6
        Me.lblSTIT2.Text = "Medio de pago"
        '
        'lblCue2
        '
        Me.lblCue2.AutoSize = True
        Me.lblCue2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblCue2.Location = New System.Drawing.Point(24, 367)
        Me.lblCue2.Name = "lblCue2"
        Me.lblCue2.Size = New System.Drawing.Size(403, 108)
        Me.lblCue2.TabIndex = 7
        Me.lblCue2.Text = resources.GetString("lblCue2.Text")
        '
        'lblSTIT1
        '
        Me.lblSTIT1.AutoSize = True
        Me.lblSTIT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.lblSTIT1.Location = New System.Drawing.Point(14, 217)
        Me.lblSTIT1.Name = "lblSTIT1"
        Me.lblSTIT1.Size = New System.Drawing.Size(159, 20)
        Me.lblSTIT1.TabIndex = 8
        Me.lblSTIT1.Text = "Motivo del credito"
        '
        'lblCue1
        '
        Me.lblCue1.AutoSize = True
        Me.lblCue1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblCue1.Location = New System.Drawing.Point(24, 248)
        Me.lblCue1.Name = "lblCue1"
        Me.lblCue1.Size = New System.Drawing.Size(398, 72)
        Me.lblCue1.TabIndex = 9
        Me.lblCue1.Text = resources.GetString("lblCue1.Text")
        '
        'lblFirmaC
        '
        Me.lblFirmaC.AutoSize = True
        Me.lblFirmaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirmaC.Location = New System.Drawing.Point(30, 553)
        Me.lblFirmaC.Name = "lblFirmaC"
        Me.lblFirmaC.Size = New System.Drawing.Size(115, 18)
        Me.lblFirmaC.TabIndex = 10
        Me.lblFirmaC.Text = "Firma del cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 536)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "..................................................."
        '
        'lblFirmaV
        '
        Me.lblFirmaV.AutoSize = True
        Me.lblFirmaV.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblFirmaV.Location = New System.Drawing.Point(258, 553)
        Me.lblFirmaV.Name = "lblFirmaV"
        Me.lblFirmaV.Size = New System.Drawing.Size(134, 18)
        Me.lblFirmaV.TabIndex = 12
        Me.lblFirmaV.Text = "Firma del vendedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(243, 536)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "..................................................."
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(354, 606)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 23)
        Me.btnImp.TabIndex = 14
        Me.btnImp.Text = "Imprimir"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'frmDocCCre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 641)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblFirmaV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFirmaC)
        Me.Controls.Add(Me.lblCue1)
        Me.Controls.Add(Me.lblSTIT1)
        Me.Controls.Add(Me.lblCue2)
        Me.Controls.Add(Me.lblSTIT2)
        Me.Controls.Add(Me.lblAd)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.lblFV)
        Me.Controls.Add(Me.lblFE)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.lblTit)
        Me.Name = "frmDocCCre"
        Me.Text = "DocContraCre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTit As System.Windows.Forms.Label
    Friend WithEvents lblN As System.Windows.Forms.Label
    Friend WithEvents lblFE As System.Windows.Forms.Label
    Friend WithEvents lblFV As System.Windows.Forms.Label
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents lblAd As System.Windows.Forms.Label
    Friend WithEvents lblSTIT2 As System.Windows.Forms.Label
    Friend WithEvents lblCue2 As System.Windows.Forms.Label
    Friend WithEvents lblSTIT1 As System.Windows.Forms.Label
    Friend WithEvents lblCue1 As System.Windows.Forms.Label
    Friend WithEvents lblFirmaC As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFirmaV As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnImp As System.Windows.Forms.Button
End Class
