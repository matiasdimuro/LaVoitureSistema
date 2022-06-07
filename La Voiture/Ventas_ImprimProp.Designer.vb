<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formImprimirPropuesta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formImprimirPropuesta))
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblModeloAuto = New System.Windows.Forms.Label()
        Me.lblNumPropuesta = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtNumProp = New System.Windows.Forms.TextBox()
        Me.txtMontoFinal = New System.Windows.Forms.TextBox()
        Me.lblTexto9 = New System.Windows.Forms.Label()
        Me.rtxtAccesorios = New System.Windows.Forms.RichTextBox()
        Me.txtAccesorios = New System.Windows.Forms.TextBox()
        Me.lblTexto8 = New System.Windows.Forms.Label()
        Me.txtMedioPago = New System.Windows.Forms.TextBox()
        Me.lblTexto7 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblTexto6 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblTexto5 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblTexto4 = New System.Windows.Forms.Label()
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.lblTexto3 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.lblTexto2 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblTexto1 = New System.Windows.Forms.Label()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.printPropuesta = New System.Drawing.Printing.PrintDocument()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnImprimir.Location = New System.Drawing.Point(594, 370)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 31)
        Me.btnImprimir.TabIndex = 18
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'lblModeloAuto
        '
        Me.lblModeloAuto.AutoSize = True
        Me.lblModeloAuto.Font = New System.Drawing.Font("Trebuchet MS", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloAuto.ForeColor = System.Drawing.Color.Black
        Me.lblModeloAuto.Location = New System.Drawing.Point(3, 0)
        Me.lblModeloAuto.Name = "lblModeloAuto"
        Me.lblModeloAuto.Size = New System.Drawing.Size(270, 35)
        Me.lblModeloAuto.TabIndex = 19
        Me.lblModeloAuto.Text = "Propuesta Venta 0km"
        '
        'lblNumPropuesta
        '
        Me.lblNumPropuesta.AutoSize = True
        Me.lblNumPropuesta.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPropuesta.ForeColor = System.Drawing.Color.Black
        Me.lblNumPropuesta.Location = New System.Drawing.Point(5, 45)
        Me.lblNumPropuesta.Name = "lblNumPropuesta"
        Me.lblNumPropuesta.Size = New System.Drawing.Size(214, 26)
        Me.lblNumPropuesta.TabIndex = 20
        Me.lblNumPropuesta.Text = "Numero de propuesta:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.txtFecha)
        Me.Panel1.Controls.Add(Me.txtNumProp)
        Me.Panel1.Controls.Add(Me.txtMontoFinal)
        Me.Panel1.Controls.Add(Me.lblTexto9)
        Me.Panel1.Controls.Add(Me.rtxtAccesorios)
        Me.Panel1.Controls.Add(Me.txtAccesorios)
        Me.Panel1.Controls.Add(Me.lblTexto8)
        Me.Panel1.Controls.Add(Me.txtMedioPago)
        Me.Panel1.Controls.Add(Me.lblTexto7)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.lblTexto6)
        Me.Panel1.Controls.Add(Me.txtColor)
        Me.Panel1.Controls.Add(Me.lblTexto5)
        Me.Panel1.Controls.Add(Me.txtModelo)
        Me.Panel1.Controls.Add(Me.lblTexto4)
        Me.Panel1.Controls.Add(Me.txtPatente)
        Me.Panel1.Controls.Add(Me.lblTexto3)
        Me.Panel1.Controls.Add(Me.txtDni)
        Me.Panel1.Controls.Add(Me.lblTexto2)
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Controls.Add(Me.lblTexto1)
        Me.Panel1.Controls.Add(Me.pnlLogo)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblNumPropuesta)
        Me.Panel1.Controls.Add(Me.lblModeloAuto)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 350)
        Me.Panel1.TabIndex = 20
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(225, 77)
        Me.txtFecha.MaxLength = 200
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(325, 24)
        Me.txtFecha.TabIndex = 236
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumProp
        '
        Me.txtNumProp.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtNumProp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumProp.Location = New System.Drawing.Point(225, 47)
        Me.txtNumProp.MaxLength = 200
        Me.txtNumProp.Name = "txtNumProp"
        Me.txtNumProp.ReadOnly = True
        Me.txtNumProp.Size = New System.Drawing.Size(325, 24)
        Me.txtNumProp.TabIndex = 235
        Me.txtNumProp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMontoFinal
        '
        Me.txtMontoFinal.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtMontoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoFinal.Location = New System.Drawing.Point(584, 234)
        Me.txtMontoFinal.MaxLength = 200
        Me.txtMontoFinal.Name = "txtMontoFinal"
        Me.txtMontoFinal.ReadOnly = True
        Me.txtMontoFinal.Size = New System.Drawing.Size(106, 24)
        Me.txtMontoFinal.TabIndex = 234
        Me.txtMontoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTexto9
        '
        Me.lblTexto9.AutoSize = True
        Me.lblTexto9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto9.ForeColor = System.Drawing.Color.Black
        Me.lblTexto9.Location = New System.Drawing.Point(502, 237)
        Me.lblTexto9.Name = "lblTexto9"
        Me.lblTexto9.Size = New System.Drawing.Size(85, 18)
        Me.lblTexto9.TabIndex = 233
        Me.lblTexto9.Text = "monto final:"
        '
        'rtxtAccesorios
        '
        Me.rtxtAccesorios.Enabled = False
        Me.rtxtAccesorios.Location = New System.Drawing.Point(10, 267)
        Me.rtxtAccesorios.Name = "rtxtAccesorios"
        Me.rtxtAccesorios.ReadOnly = True
        Me.rtxtAccesorios.Size = New System.Drawing.Size(680, 63)
        Me.rtxtAccesorios.TabIndex = 232
        Me.rtxtAccesorios.Text = ""
        '
        'txtAccesorios
        '
        Me.txtAccesorios.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtAccesorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccesorios.Location = New System.Drawing.Point(449, 234)
        Me.txtAccesorios.MaxLength = 200
        Me.txtAccesorios.Name = "txtAccesorios"
        Me.txtAccesorios.ReadOnly = True
        Me.txtAccesorios.Size = New System.Drawing.Size(47, 24)
        Me.txtAccesorios.TabIndex = 231
        Me.txtAccesorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTexto8
        '
        Me.lblTexto8.AutoSize = True
        Me.lblTexto8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto8.ForeColor = System.Drawing.Color.Black
        Me.lblTexto8.Location = New System.Drawing.Point(304, 237)
        Me.lblTexto8.Name = "lblTexto8"
        Me.lblTexto8.Size = New System.Drawing.Size(143, 18)
        Me.lblTexto8.TabIndex = 230
        Me.lblTexto8.Text = ". Incluye accesorios:"
        '
        'txtMedioPago
        '
        Me.txtMedioPago.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtMedioPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedioPago.Location = New System.Drawing.Point(137, 234)
        Me.txtMedioPago.MaxLength = 200
        Me.txtMedioPago.Name = "txtMedioPago"
        Me.txtMedioPago.ReadOnly = True
        Me.txtMedioPago.Size = New System.Drawing.Size(164, 24)
        Me.txtMedioPago.TabIndex = 229
        Me.txtMedioPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTexto7
        '
        Me.lblTexto7.AutoSize = True
        Me.lblTexto7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto7.ForeColor = System.Drawing.Color.Black
        Me.lblTexto7.Location = New System.Drawing.Point(7, 237)
        Me.lblTexto7.Name = "lblTexto7"
        Me.lblTexto7.Size = New System.Drawing.Size(131, 18)
        Me.lblTexto7.TabIndex = 228
        Me.lblTexto7.Text = "al (medio de pago)"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(523, 194)
        Me.txtPrecio.MaxLength = 200
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(167, 24)
        Me.txtPrecio.TabIndex = 227
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTexto6
        '
        Me.lblTexto6.AutoSize = True
        Me.lblTexto6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto6.ForeColor = System.Drawing.Color.Black
        Me.lblTexto6.Location = New System.Drawing.Point(416, 197)
        Me.lblTexto6.Name = "lblTexto6"
        Me.lblTexto6.Size = New System.Drawing.Size(101, 18)
        Me.lblTexto6.TabIndex = 226
        Me.lblTexto6.Text = "a un precio de"
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(307, 194)
        Me.txtColor.MaxLength = 200
        Me.txtColor.Name = "txtColor"
        Me.txtColor.ReadOnly = True
        Me.txtColor.Size = New System.Drawing.Size(103, 24)
        Me.txtColor.TabIndex = 225
        Me.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTexto5
        '
        Me.lblTexto5.AutoSize = True
        Me.lblTexto5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto5.ForeColor = System.Drawing.Color.Black
        Me.lblTexto5.Location = New System.Drawing.Point(239, 197)
        Me.lblTexto5.Name = "lblTexto5"
        Me.lblTexto5.Size = New System.Drawing.Size(62, 18)
        Me.lblTexto5.TabIndex = 224
        Me.lblTexto5.Text = "de color"
        '
        'txtModelo
        '
        Me.txtModelo.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(69, 194)
        Me.txtModelo.MaxLength = 200
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(164, 24)
        Me.txtModelo.TabIndex = 223
        Me.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTexto4
        '
        Me.lblTexto4.AutoSize = True
        Me.lblTexto4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto4.ForeColor = System.Drawing.Color.Black
        Me.lblTexto4.Location = New System.Drawing.Point(7, 197)
        Me.lblTexto4.Name = "lblTexto4"
        Me.lblTexto4.Size = New System.Drawing.Size(58, 18)
        Me.lblTexto4.TabIndex = 222
        Me.lblTexto4.Text = "modelo"
        '
        'txtPatente
        '
        Me.txtPatente.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtPatente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatente.Location = New System.Drawing.Point(481, 157)
        Me.txtPatente.MaxLength = 200
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.ReadOnly = True
        Me.txtPatente.Size = New System.Drawing.Size(209, 24)
        Me.txtPatente.TabIndex = 221
        Me.txtPatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTexto3
        '
        Me.lblTexto3.AutoSize = True
        Me.lblTexto3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto3.ForeColor = System.Drawing.Color.Black
        Me.lblTexto3.Location = New System.Drawing.Point(239, 160)
        Me.lblTexto3.Name = "lblTexto3"
        Me.lblTexto3.Size = New System.Drawing.Size(236, 18)
        Me.lblTexto3.TabIndex = 220
        Me.lblTexto3.Text = "la compra del vehiculo con patente"
        '
        'txtDni
        '
        Me.txtDni.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(69, 157)
        Me.txtDni.MaxLength = 200
        Me.txtDni.Name = "txtDni"
        Me.txtDni.ReadOnly = True
        Me.txtDni.Size = New System.Drawing.Size(164, 24)
        Me.txtDni.TabIndex = 219
        Me.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTexto2
        '
        Me.lblTexto2.AutoSize = True
        Me.lblTexto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto2.ForeColor = System.Drawing.Color.Black
        Me.lblTexto2.Location = New System.Drawing.Point(7, 160)
        Me.lblTexto2.Name = "lblTexto2"
        Me.lblTexto2.Size = New System.Drawing.Size(56, 18)
        Me.lblTexto2.TabIndex = 218
        Me.lblTexto2.Text = "con dni"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(178, 123)
        Me.txtCliente.MaxLength = 200
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(512, 24)
        Me.txtCliente.TabIndex = 217
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTexto1
        '
        Me.lblTexto1.AutoSize = True
        Me.lblTexto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto1.ForeColor = System.Drawing.Color.Black
        Me.lblTexto1.Location = New System.Drawing.Point(5, 126)
        Me.lblTexto1.Name = "lblTexto1"
        Me.lblTexto1.Size = New System.Drawing.Size(167, 18)
        Me.lblTexto1.TabIndex = 216
        Me.lblTexto1.Text = "Se acordó con el cliente"
        '
        'pnlLogo
        '
        Me.pnlLogo.BackgroundImage = CType(resources.GetObject("pnlLogo.BackgroundImage"), System.Drawing.Image)
        Me.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLogo.Location = New System.Drawing.Point(556, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(156, 120)
        Me.pnlLogo.TabIndex = 215
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Location = New System.Drawing.Point(5, 75)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(177, 26)
        Me.lblFecha.TabIndex = 214
        Me.lblFecha.Text = "Fecha de emision:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-5, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1032, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "_________________________________________________________________________________" & _
            "____"
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
        Me.btnVolver.TabIndex = 21
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'formImprimirPropuesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(736, 413)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnImprimir)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "formImprimirPropuesta"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ventas: Imprimir Propuesta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblModeloAuto As System.Windows.Forms.Label
    Friend WithEvents lblNumPropuesta As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTexto1 As System.Windows.Forms.Label
    Friend WithEvents pnlLogo As System.Windows.Forms.Panel
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtMontoFinal As System.Windows.Forms.TextBox
    Friend WithEvents lblTexto9 As System.Windows.Forms.Label
    Friend WithEvents rtxtAccesorios As System.Windows.Forms.RichTextBox
    Friend WithEvents txtAccesorios As System.Windows.Forms.TextBox
    Friend WithEvents lblTexto8 As System.Windows.Forms.Label
    Friend WithEvents txtMedioPago As System.Windows.Forms.TextBox
    Friend WithEvents lblTexto7 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblTexto6 As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents lblTexto5 As System.Windows.Forms.Label
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents lblTexto4 As System.Windows.Forms.Label
    Friend WithEvents txtPatente As System.Windows.Forms.TextBox
    Friend WithEvents lblTexto3 As System.Windows.Forms.Label
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents lblTexto2 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtNumProp As System.Windows.Forms.TextBox
    Friend WithEvents printPropuesta As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
