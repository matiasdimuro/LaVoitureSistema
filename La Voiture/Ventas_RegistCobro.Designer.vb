<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDeuda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantPlata = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtRec = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblNumPropuesta = New System.Windows.Forms.Label()
        Me.lblModeloAuto = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.printReciboVta = New System.Drawing.Printing.PrintDocument()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.txtDeuda)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtAño)
        Me.Panel1.Controls.Add(Me.txtMes)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtDia)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtFactura)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCantPlata)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNom)
        Me.Panel1.Controls.Add(Me.txtRec)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.lblNumPropuesta)
        Me.Panel1.Controls.Add(Me.lblModeloAuto)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 350)
        Me.Panel1.TabIndex = 21
        '
        'txtDeuda
        '
        Me.txtDeuda.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeuda.Location = New System.Drawing.Point(200, 294)
        Me.txtDeuda.MaxLength = 200
        Me.txtDeuda.Name = "txtDeuda"
        Me.txtDeuda.ReadOnly = True
        Me.txtDeuda.Size = New System.Drawing.Size(142, 24)
        Me.txtDeuda.TabIndex = 247
        Me.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(29, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 26)
        Me.Label5.TabIndex = 246
        Me.Label5.Text = "Saldo pendiente:"
        '
        'txtAño
        '
        Me.txtAño.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(576, 294)
        Me.txtAño.MaxLength = 200
        Me.txtAño.Name = "txtAño"
        Me.txtAño.ReadOnly = True
        Me.txtAño.Size = New System.Drawing.Size(73, 24)
        Me.txtAño.TabIndex = 245
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMes
        '
        Me.txtMes.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMes.Location = New System.Drawing.Point(469, 294)
        Me.txtMes.MaxLength = 200
        Me.txtMes.Name = "txtMes"
        Me.txtMes.ReadOnly = True
        Me.txtMes.Size = New System.Drawing.Size(73, 24)
        Me.txtMes.TabIndex = 244
        Me.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(548, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 26)
        Me.Label4.TabIndex = 243
        Me.Label4.Text = "/"
        '
        'txtDia
        '
        Me.txtDia.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDia.Location = New System.Drawing.Point(362, 294)
        Me.txtDia.MaxLength = 200
        Me.txtDia.Name = "txtDia"
        Me.txtDia.ReadOnly = True
        Me.txtDia.Size = New System.Drawing.Size(73, 24)
        Me.txtDia.TabIndex = 242
        Me.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(441, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 26)
        Me.Label3.TabIndex = 241
        Me.Label3.Text = "/"
        '
        'txtFactura
        '
        Me.txtFactura.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(362, 230)
        Me.txtFactura.MaxLength = 200
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(295, 24)
        Me.txtFactura.TabIndex = 240
        Me.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(329, 26)
        Me.Label2.TabIndex = 239
        Me.Label2.Text = "por concepto de la factura numero" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtCantPlata
        '
        Me.txtCantPlata.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtCantPlata.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantPlata.Location = New System.Drawing.Point(177, 184)
        Me.txtCantPlata.MaxLength = 200
        Me.txtCantPlata.Name = "txtCantPlata"
        Me.txtCantPlata.ReadOnly = True
        Me.txtCantPlata.Size = New System.Drawing.Size(480, 24)
        Me.txtCantPlata.TabIndex = 238
        Me.txtCantPlata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 26)
        Me.Label1.TabIndex = 237
        Me.Label1.Text = "la cantidad de"
        '
        'txtNom
        '
        Me.txtNom.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(130, 142)
        Me.txtNom.MaxLength = 200
        Me.txtNom.Name = "txtNom"
        Me.txtNom.ReadOnly = True
        Me.txtNom.Size = New System.Drawing.Size(527, 24)
        Me.txtNom.TabIndex = 236
        Me.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRec
        '
        Me.txtRec.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec.Location = New System.Drawing.Point(520, 50)
        Me.txtRec.MaxLength = 200
        Me.txtRec.Name = "txtRec"
        Me.txtRec.ReadOnly = True
        Me.txtRec.Size = New System.Drawing.Size(137, 24)
        Me.txtRec.TabIndex = 235
        Me.txtRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Location = New System.Drawing.Point(29, 140)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(95, 26)
        Me.lblFecha.TabIndex = 214
        Me.lblFecha.Text = "Recibi de"
        '
        'lblNumPropuesta
        '
        Me.lblNumPropuesta.AutoSize = True
        Me.lblNumPropuesta.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPropuesta.ForeColor = System.Drawing.Color.Black
        Me.lblNumPropuesta.Location = New System.Drawing.Point(492, 48)
        Me.lblNumPropuesta.Name = "lblNumPropuesta"
        Me.lblNumPropuesta.Size = New System.Drawing.Size(22, 26)
        Me.lblNumPropuesta.TabIndex = 20
        Me.lblNumPropuesta.Text = "$"
        '
        'lblModeloAuto
        '
        Me.lblModeloAuto.AutoSize = True
        Me.lblModeloAuto.Font = New System.Drawing.Font("Trebuchet MS", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloAuto.ForeColor = System.Drawing.Color.Black
        Me.lblModeloAuto.Location = New System.Drawing.Point(22, 25)
        Me.lblModeloAuto.Name = "lblModeloAuto"
        Me.lblModeloAuto.Size = New System.Drawing.Size(203, 67)
        Me.lblModeloAuto.TabIndex = 19
        Me.lblModeloAuto.Text = "RECIBO"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Location = New System.Drawing.Point(595, 370)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 31)
        Me.btnImprimir.TabIndex = 22
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(292, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(156, 120)
        Me.Panel2.TabIndex = 216
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.Black
        Me.btnVolver.Location = New System.Drawing.Point(13, 370)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(128, 31)
        Me.btnVolver.TabIndex = 217
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(736, 413)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRecibo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ventas: Registrar Cobro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtRec As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblNumPropuesta As System.Windows.Forms.Label
    Friend WithEvents lblModeloAuto As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCantPlata As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents printReciboVta As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtDeuda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
