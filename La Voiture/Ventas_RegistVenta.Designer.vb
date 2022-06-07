<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRegistVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formRegistVenta))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rtxtDesc = New System.Windows.Forms.RichTextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtMedioPago = New System.Windows.Forms.TextBox()
        Me.lblMedioPago = New System.Windows.Forms.Label()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.txtDire = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblDire = New System.Windows.Forms.Label()
        Me.lblTipoFact = New System.Windows.Forms.Label()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtNumFact = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblFact = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.printFacturaVenta = New System.Drawing.Printing.PrintDocument()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.rtxtDesc)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.txtMedioPago)
        Me.Panel1.Controls.Add(Me.lblMedioPago)
        Me.Panel1.Controls.Add(Me.lblDescr)
        Me.Panel1.Controls.Add(Me.txtDire)
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Controls.Add(Me.lblDire)
        Me.Panel1.Controls.Add(Me.lblTipoFact)
        Me.Panel1.Controls.Add(Me.pnlLogo)
        Me.Panel1.Controls.Add(Me.txtFecha)
        Me.Panel1.Controls.Add(Me.txtNumFact)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblCliente)
        Me.Panel1.Controls.Add(Me.lblFact)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 476)
        Me.Panel1.TabIndex = 21
        '
        'rtxtDesc
        '
        Me.rtxtDesc.BackColor = System.Drawing.SystemColors.MenuBar
        Me.rtxtDesc.Location = New System.Drawing.Point(25, 266)
        Me.rtxtDesc.Name = "rtxtDesc"
        Me.rtxtDesc.ReadOnly = True
        Me.rtxtDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtxtDesc.Size = New System.Drawing.Size(381, 144)
        Me.rtxtDesc.TabIndex = 247
        Me.rtxtDesc.Text = ""
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(240, 436)
        Me.txtTotal.MaxLength = 200
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(168, 24)
        Me.txtTotal.TabIndex = 246
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(169, 434)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(65, 26)
        Me.lblTotal.TabIndex = 245
        Me.lblTotal.Text = "Total:"
        '
        'txtMedioPago
        '
        Me.txtMedioPago.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtMedioPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedioPago.Location = New System.Drawing.Point(159, 204)
        Me.txtMedioPago.MaxLength = 200
        Me.txtMedioPago.Name = "txtMedioPago"
        Me.txtMedioPago.ReadOnly = True
        Me.txtMedioPago.Size = New System.Drawing.Size(247, 24)
        Me.txtMedioPago.TabIndex = 244
        Me.txtMedioPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMedioPago
        '
        Me.lblMedioPago.AutoSize = True
        Me.lblMedioPago.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedioPago.ForeColor = System.Drawing.Color.Black
        Me.lblMedioPago.Location = New System.Drawing.Point(3, 202)
        Me.lblMedioPago.Name = "lblMedioPago"
        Me.lblMedioPago.Size = New System.Drawing.Size(150, 26)
        Me.lblMedioPago.TabIndex = 243
        Me.lblMedioPago.Text = "Medio de pago:"
        '
        'lblDescr
        '
        Me.lblDescr.AutoSize = True
        Me.lblDescr.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescr.ForeColor = System.Drawing.Color.Black
        Me.lblDescr.Location = New System.Drawing.Point(3, 237)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(123, 26)
        Me.lblDescr.TabIndex = 241
        Me.lblDescr.Text = "Descripcion:"
        '
        'txtDire
        '
        Me.txtDire.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtDire.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDire.Location = New System.Drawing.Point(113, 174)
        Me.txtDire.MaxLength = 200
        Me.txtDire.Name = "txtDire"
        Me.txtDire.ReadOnly = True
        Me.txtDire.Size = New System.Drawing.Size(293, 24)
        Me.txtDire.TabIndex = 240
        Me.txtDire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(113, 144)
        Me.txtCliente.MaxLength = 200
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(293, 24)
        Me.txtCliente.TabIndex = 239
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDire
        '
        Me.lblDire.AutoSize = True
        Me.lblDire.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDire.ForeColor = System.Drawing.Color.Black
        Me.lblDire.Location = New System.Drawing.Point(3, 172)
        Me.lblDire.Name = "lblDire"
        Me.lblDire.Size = New System.Drawing.Size(104, 26)
        Me.lblDire.TabIndex = 238
        Me.lblDire.Text = "Direccion:"
        '
        'lblTipoFact
        '
        Me.lblTipoFact.AutoSize = True
        Me.lblTipoFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTipoFact.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoFact.ForeColor = System.Drawing.Color.Black
        Me.lblTipoFact.Location = New System.Drawing.Point(174, 8)
        Me.lblTipoFact.Name = "lblTipoFact"
        Me.lblTipoFact.Size = New System.Drawing.Size(25, 28)
        Me.lblTipoFact.TabIndex = 237
        Me.lblTipoFact.Text = "B"
        '
        'pnlLogo
        '
        Me.pnlLogo.BackgroundImage = CType(resources.GetObject("pnlLogo.BackgroundImage"), System.Drawing.Image)
        Me.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(156, 131)
        Me.pnlLogo.TabIndex = 216
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(291, 96)
        Me.txtFecha.MaxLength = 200
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(115, 24)
        Me.txtFecha.TabIndex = 236
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumFact
        '
        Me.txtNumFact.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtNumFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumFact.Location = New System.Drawing.Point(217, 46)
        Me.txtNumFact.MaxLength = 200
        Me.txtNumFact.Name = "txtNumFact"
        Me.txtNumFact.ReadOnly = True
        Me.txtNumFact.Size = New System.Drawing.Size(189, 24)
        Me.txtNumFact.TabIndex = 235
        Me.txtNumFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Location = New System.Drawing.Point(212, 94)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(73, 26)
        Me.lblFecha.TabIndex = 214
        Me.lblFecha.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-5, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1032, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "_________________________________________________________________________________" & _
            "____"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Black
        Me.lblCliente.Location = New System.Drawing.Point(3, 144)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(84, 26)
        Me.lblCliente.TabIndex = 20
        Me.lblCliente.Text = "Cliente:"
        '
        'lblFact
        '
        Me.lblFact.AutoSize = True
        Me.lblFact.Font = New System.Drawing.Font("Trebuchet MS", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFact.ForeColor = System.Drawing.Color.Black
        Me.lblFact.Location = New System.Drawing.Point(256, 8)
        Me.lblFact.Name = "lblFact"
        Me.lblFact.Size = New System.Drawing.Size(107, 35)
        Me.lblFact.TabIndex = 19
        Me.lblFact.Text = "Factura"
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
        Me.btnImprimir.Location = New System.Drawing.Point(315, 496)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 31)
        Me.btnImprimir.TabIndex = 22
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
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
        Me.btnVolver.Location = New System.Drawing.Point(13, 496)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(128, 31)
        Me.btnVolver.TabIndex = 23
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'formRegistVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(461, 540)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formRegistVenta"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Registrar Venta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtNumFact As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblFact As System.Windows.Forms.Label
    Friend WithEvents lblTipoFact As System.Windows.Forms.Label
    Friend WithEvents pnlLogo As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDire As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblDire As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtMedioPago As System.Windows.Forms.TextBox
    Friend WithEvents lblMedioPago As System.Windows.Forms.Label
    Friend WithEvents lblDescr As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents printFacturaVenta As System.Drawing.Printing.PrintDocument
    Friend WithEvents rtxtDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
