<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistCompra))
        Me.gbxremito = New System.Windows.Forms.GroupBox()
        Me.rbnremitonofirmado = New System.Windows.Forms.RadioButton()
        Me.rbnremitofirmado = New System.Windows.Forms.RadioButton()
        Me.lblDescrRem = New System.Windows.Forms.Label()
        Me.rtxtDescrRem = New System.Windows.Forms.RichTextBox()
        Me.txtProdRem = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtfecharemito = New System.Windows.Forms.TextBox()
        Me.lblfecharemito = New System.Windows.Forms.Label()
        Me.gbxfactura = New System.Windows.Forms.GroupBox()
        Me.rbnAcc = New System.Windows.Forms.RadioButton()
        Me.rbnVeh = New System.Windows.Forms.RadioButton()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtMedioPago = New System.Windows.Forms.TextBox()
        Me.lblMedioPago = New System.Windows.Forms.Label()
        Me.txtproveedorfacturacompra = New System.Windows.Forms.TextBox()
        Me.txtmontofacturacompra = New System.Windows.Forms.TextBox()
        Me.lblproveedorfacturacompra = New System.Windows.Forms.Label()
        Me.lblmontofacturacompra = New System.Windows.Forms.Label()
        Me.lblproductofacturacompra = New System.Windows.Forms.Label()
        Me.txttipofacturacompra = New System.Windows.Forms.TextBox()
        Me.tipofacturacompra = New System.Windows.Forms.Label()
        Me.txtfechafacturacompra = New System.Windows.Forms.TextBox()
        Me.fechafacturacompra = New System.Windows.Forms.Label()
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox()
        Me.lblNumOrden = New System.Windows.Forms.Label()
        Me.btnsalirregistropago = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnComprobar = New System.Windows.Forms.Button()
        Me.gbxremito.SuspendLayout()
        Me.gbxfactura.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxremito
        '
        Me.gbxremito.Controls.Add(Me.rbnremitonofirmado)
        Me.gbxremito.Controls.Add(Me.rbnremitofirmado)
        Me.gbxremito.Controls.Add(Me.lblDescrRem)
        Me.gbxremito.Controls.Add(Me.rtxtDescrRem)
        Me.gbxremito.Controls.Add(Me.txtProdRem)
        Me.gbxremito.Controls.Add(Me.lblDesc)
        Me.gbxremito.Controls.Add(Me.txtfecharemito)
        Me.gbxremito.Controls.Add(Me.lblfecharemito)
        Me.gbxremito.ForeColor = System.Drawing.Color.White
        Me.gbxremito.Location = New System.Drawing.Point(445, 12)
        Me.gbxremito.Name = "gbxremito"
        Me.gbxremito.Size = New System.Drawing.Size(279, 336)
        Me.gbxremito.TabIndex = 29
        Me.gbxremito.TabStop = False
        Me.gbxremito.Text = "Remito"
        '
        'rbnremitonofirmado
        '
        Me.rbnremitonofirmado.AutoSize = True
        Me.rbnremitonofirmado.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnremitonofirmado.ForeColor = System.Drawing.Color.White
        Me.rbnremitonofirmado.Location = New System.Drawing.Point(182, 56)
        Me.rbnremitonofirmado.Name = "rbnremitonofirmado"
        Me.rbnremitonofirmado.Size = New System.Drawing.Size(94, 24)
        Me.rbnremitonofirmado.TabIndex = 15
        Me.rbnremitonofirmado.TabStop = True
        Me.rbnremitonofirmado.Text = "Sin firmar"
        Me.rbnremitonofirmado.UseVisualStyleBackColor = True
        '
        'rbnremitofirmado
        '
        Me.rbnremitofirmado.AutoSize = True
        Me.rbnremitofirmado.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnremitofirmado.ForeColor = System.Drawing.Color.White
        Me.rbnremitofirmado.Location = New System.Drawing.Point(182, 33)
        Me.rbnremitofirmado.Name = "rbnremitofirmado"
        Me.rbnremitofirmado.Size = New System.Drawing.Size(82, 24)
        Me.rbnremitofirmado.TabIndex = 14
        Me.rbnremitofirmado.TabStop = True
        Me.rbnremitofirmado.Text = "Firmado"
        Me.rbnremitofirmado.UseVisualStyleBackColor = True
        '
        'lblDescrRem
        '
        Me.lblDescrRem.AutoSize = True
        Me.lblDescrRem.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrRem.ForeColor = System.Drawing.Color.White
        Me.lblDescrRem.Location = New System.Drawing.Point(6, 133)
        Me.lblDescrRem.Name = "lblDescrRem"
        Me.lblDescrRem.Size = New System.Drawing.Size(90, 20)
        Me.lblDescrRem.TabIndex = 25
        Me.lblDescrRem.Text = "Descripcion:"
        '
        'rtxtDescrRem
        '
        Me.rtxtDescrRem.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtDescrRem.Location = New System.Drawing.Point(9, 159)
        Me.rtxtDescrRem.Name = "rtxtDescrRem"
        Me.rtxtDescrRem.Size = New System.Drawing.Size(253, 163)
        Me.rtxtDescrRem.TabIndex = 16
        Me.rtxtDescrRem.Text = ""
        '
        'txtProdRem
        '
        Me.txtProdRem.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdRem.Location = New System.Drawing.Point(9, 105)
        Me.txtProdRem.Name = "txtProdRem"
        Me.txtProdRem.ReadOnly = True
        Me.txtProdRem.Size = New System.Drawing.Size(253, 25)
        Me.txtProdRem.TabIndex = 13
        Me.txtProdRem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.White
        Me.lblDesc.Location = New System.Drawing.Point(6, 78)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(79, 20)
        Me.lblDesc.TabIndex = 22
        Me.lblDesc.Text = "Productos:"
        '
        'txtfecharemito
        '
        Me.txtfecharemito.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecharemito.Location = New System.Drawing.Point(6, 43)
        Me.txtfecharemito.Name = "txtfecharemito"
        Me.txtfecharemito.ReadOnly = True
        Me.txtfecharemito.Size = New System.Drawing.Size(161, 25)
        Me.txtfecharemito.TabIndex = 12
        Me.txtfecharemito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblfecharemito
        '
        Me.lblfecharemito.AutoSize = True
        Me.lblfecharemito.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecharemito.ForeColor = System.Drawing.Color.White
        Me.lblfecharemito.Location = New System.Drawing.Point(5, 20)
        Me.lblfecharemito.Name = "lblfecharemito"
        Me.lblfecharemito.Size = New System.Drawing.Size(54, 20)
        Me.lblfecharemito.TabIndex = 20
        Me.lblfecharemito.Text = "Fecha:"
        '
        'gbxfactura
        '
        Me.gbxfactura.Controls.Add(Me.rbnAcc)
        Me.gbxfactura.Controls.Add(Me.rbnVeh)
        Me.gbxfactura.Controls.Add(Me.txtCantidad)
        Me.gbxfactura.Controls.Add(Me.lblCantidad)
        Me.gbxfactura.Controls.Add(Me.txtProducto)
        Me.gbxfactura.Controls.Add(Me.txtMedioPago)
        Me.gbxfactura.Controls.Add(Me.lblMedioPago)
        Me.gbxfactura.Controls.Add(Me.txtproveedorfacturacompra)
        Me.gbxfactura.Controls.Add(Me.txtmontofacturacompra)
        Me.gbxfactura.Controls.Add(Me.lblproveedorfacturacompra)
        Me.gbxfactura.Controls.Add(Me.lblmontofacturacompra)
        Me.gbxfactura.Controls.Add(Me.lblproductofacturacompra)
        Me.gbxfactura.Controls.Add(Me.txttipofacturacompra)
        Me.gbxfactura.Controls.Add(Me.tipofacturacompra)
        Me.gbxfactura.Controls.Add(Me.txtfechafacturacompra)
        Me.gbxfactura.Controls.Add(Me.fechafacturacompra)
        Me.gbxfactura.ForeColor = System.Drawing.Color.White
        Me.gbxfactura.Location = New System.Drawing.Point(16, 108)
        Me.gbxfactura.Name = "gbxfactura"
        Me.gbxfactura.Size = New System.Drawing.Size(414, 240)
        Me.gbxfactura.TabIndex = 28
        Me.gbxfactura.TabStop = False
        Me.gbxfactura.Text = "Factura"
        '
        'rbnAcc
        '
        Me.rbnAcc.AutoSize = True
        Me.rbnAcc.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnAcc.ForeColor = System.Drawing.Color.White
        Me.rbnAcc.Location = New System.Drawing.Point(217, 202)
        Me.rbnAcc.Name = "rbnAcc"
        Me.rbnAcc.Size = New System.Drawing.Size(129, 24)
        Me.rbnAcc.TabIndex = 11
        Me.rbnAcc.TabStop = True
        Me.rbnAcc.Text = "Es un accesorio"
        Me.rbnAcc.UseVisualStyleBackColor = True
        '
        'rbnVeh
        '
        Me.rbnVeh.AutoSize = True
        Me.rbnVeh.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnVeh.ForeColor = System.Drawing.Color.White
        Me.rbnVeh.Location = New System.Drawing.Point(80, 202)
        Me.rbnVeh.Name = "rbnVeh"
        Me.rbnVeh.Size = New System.Drawing.Size(121, 24)
        Me.rbnVeh.TabIndex = 25
        Me.rbnVeh.TabStop = True
        Me.rbnVeh.Tag = "10"
        Me.rbnVeh.Text = "Es un Vehiculo"
        Me.rbnVeh.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(197, 96)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(70, 25)
        Me.txtCantidad.TabIndex = 7
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.White
        Me.lblCantidad.Location = New System.Drawing.Point(193, 72)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(74, 20)
        Me.lblCantidad.TabIndex = 23
        Me.lblCantidad.Text = "Cantidad:"
        '
        'txtProducto
        '
        Me.txtProducto.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(8, 156)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(398, 25)
        Me.txtProducto.TabIndex = 9
        Me.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMedioPago
        '
        Me.txtMedioPago.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedioPago.Location = New System.Drawing.Point(8, 96)
        Me.txtMedioPago.Name = "txtMedioPago"
        Me.txtMedioPago.Size = New System.Drawing.Size(183, 25)
        Me.txtMedioPago.TabIndex = 6
        Me.txtMedioPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMedioPago
        '
        Me.lblMedioPago.AutoSize = True
        Me.lblMedioPago.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedioPago.ForeColor = System.Drawing.Color.White
        Me.lblMedioPago.Location = New System.Drawing.Point(6, 73)
        Me.lblMedioPago.Name = "lblMedioPago"
        Me.lblMedioPago.Size = New System.Drawing.Size(111, 20)
        Me.lblMedioPago.TabIndex = 20
        Me.lblMedioPago.Text = "Medio de Pago:"
        '
        'txtproveedorfacturacompra
        '
        Me.txtproveedorfacturacompra.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproveedorfacturacompra.Location = New System.Drawing.Point(6, 38)
        Me.txtproveedorfacturacompra.Name = "txtproveedorfacturacompra"
        Me.txtproveedorfacturacompra.ReadOnly = True
        Me.txtproveedorfacturacompra.Size = New System.Drawing.Size(235, 25)
        Me.txtproveedorfacturacompra.TabIndex = 3
        Me.txtproveedorfacturacompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmontofacturacompra
        '
        Me.txtmontofacturacompra.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmontofacturacompra.Location = New System.Drawing.Point(273, 96)
        Me.txtmontofacturacompra.Name = "txtmontofacturacompra"
        Me.txtmontofacturacompra.Size = New System.Drawing.Size(135, 25)
        Me.txtmontofacturacompra.TabIndex = 8
        Me.txtmontofacturacompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblproveedorfacturacompra
        '
        Me.lblproveedorfacturacompra.AutoSize = True
        Me.lblproveedorfacturacompra.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproveedorfacturacompra.ForeColor = System.Drawing.Color.White
        Me.lblproveedorfacturacompra.Location = New System.Drawing.Point(6, 15)
        Me.lblproveedorfacturacompra.Name = "lblproveedorfacturacompra"
        Me.lblproveedorfacturacompra.Size = New System.Drawing.Size(81, 20)
        Me.lblproveedorfacturacompra.TabIndex = 16
        Me.lblproveedorfacturacompra.Text = "Proveedor:"
        '
        'lblmontofacturacompra
        '
        Me.lblmontofacturacompra.AutoSize = True
        Me.lblmontofacturacompra.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmontofacturacompra.ForeColor = System.Drawing.Color.White
        Me.lblmontofacturacompra.Location = New System.Drawing.Point(269, 72)
        Me.lblmontofacturacompra.Name = "lblmontofacturacompra"
        Me.lblmontofacturacompra.Size = New System.Drawing.Size(93, 20)
        Me.lblmontofacturacompra.TabIndex = 18
        Me.lblmontofacturacompra.Text = "Monto Total:"
        '
        'lblproductofacturacompra
        '
        Me.lblproductofacturacompra.AutoSize = True
        Me.lblproductofacturacompra.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproductofacturacompra.ForeColor = System.Drawing.Color.White
        Me.lblproductofacturacompra.Location = New System.Drawing.Point(4, 133)
        Me.lblproductofacturacompra.Name = "lblproductofacturacompra"
        Me.lblproductofacturacompra.Size = New System.Drawing.Size(73, 20)
        Me.lblproductofacturacompra.TabIndex = 16
        Me.lblproductofacturacompra.Text = "Producto:"
        '
        'txttipofacturacompra
        '
        Me.txttipofacturacompra.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipofacturacompra.Location = New System.Drawing.Point(352, 38)
        Me.txttipofacturacompra.Name = "txttipofacturacompra"
        Me.txttipofacturacompra.ReadOnly = True
        Me.txttipofacturacompra.Size = New System.Drawing.Size(56, 25)
        Me.txttipofacturacompra.TabIndex = 5
        Me.txttipofacturacompra.Text = "A"
        Me.txttipofacturacompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tipofacturacompra
        '
        Me.tipofacturacompra.AutoSize = True
        Me.tipofacturacompra.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipofacturacompra.ForeColor = System.Drawing.Color.White
        Me.tipofacturacompra.Location = New System.Drawing.Point(348, 16)
        Me.tipofacturacompra.Name = "tipofacturacompra"
        Me.tipofacturacompra.Size = New System.Drawing.Size(43, 20)
        Me.tipofacturacompra.TabIndex = 2
        Me.tipofacturacompra.Text = "Tipo:"
        '
        'txtfechafacturacompra
        '
        Me.txtfechafacturacompra.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfechafacturacompra.Location = New System.Drawing.Point(247, 38)
        Me.txtfechafacturacompra.Name = "txtfechafacturacompra"
        Me.txtfechafacturacompra.ReadOnly = True
        Me.txtfechafacturacompra.Size = New System.Drawing.Size(99, 25)
        Me.txtfechafacturacompra.TabIndex = 4
        Me.txtfechafacturacompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fechafacturacompra
        '
        Me.fechafacturacompra.AutoSize = True
        Me.fechafacturacompra.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechafacturacompra.ForeColor = System.Drawing.Color.White
        Me.fechafacturacompra.Location = New System.Drawing.Point(246, 15)
        Me.fechafacturacompra.Name = "fechafacturacompra"
        Me.fechafacturacompra.Size = New System.Drawing.Size(54, 20)
        Me.fechafacturacompra.TabIndex = 0
        Me.fechafacturacompra.Text = "Fecha:"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCompra.Location = New System.Drawing.Point(17, 65)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(168, 25)
        Me.txtOrdenCompra.TabIndex = 1
        '
        'lblNumOrden
        '
        Me.lblNumOrden.AutoSize = True
        Me.lblNumOrden.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOrden.ForeColor = System.Drawing.Color.White
        Me.lblNumOrden.Location = New System.Drawing.Point(13, 32)
        Me.lblNumOrden.Name = "lblNumOrden"
        Me.lblNumOrden.Size = New System.Drawing.Size(134, 20)
        Me.lblNumOrden.TabIndex = 22
        Me.lblNumOrden.Text = "Numero de Orden:"
        '
        'btnsalirregistropago
        '
        Me.btnsalirregistropago.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnsalirregistropago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsalirregistropago.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnsalirregistropago.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnsalirregistropago.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnsalirregistropago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalirregistropago.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalirregistropago.ForeColor = System.Drawing.Color.Black
        Me.btnsalirregistropago.Location = New System.Drawing.Point(13, 368)
        Me.btnsalirregistropago.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsalirregistropago.Name = "btnsalirregistropago"
        Me.btnsalirregistropago.Size = New System.Drawing.Size(89, 31)
        Me.btnsalirregistropago.TabIndex = 18
        Me.btnsalirregistropago.Text = "Salir"
        Me.btnsalirregistropago.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrar.Location = New System.Drawing.Point(612, 368)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(112, 31)
        Me.btnRegistrar.TabIndex = 17
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnComprobar
        '
        Me.btnComprobar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnComprobar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnComprobar.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnComprobar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnComprobar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprobar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprobar.ForeColor = System.Drawing.Color.Black
        Me.btnComprobar.Location = New System.Drawing.Point(445, 368)
        Me.btnComprobar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnComprobar.Name = "btnComprobar"
        Me.btnComprobar.Size = New System.Drawing.Size(114, 31)
        Me.btnComprobar.TabIndex = 2
        Me.btnComprobar.Text = "Comprobar "
        Me.btnComprobar.UseVisualStyleBackColor = False
        '
        'frmRegistCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(736, 413)
        Me.Controls.Add(Me.btnComprobar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnsalirregistropago)
        Me.Controls.Add(Me.txtOrdenCompra)
        Me.Controls.Add(Me.lblNumOrden)
        Me.Controls.Add(Me.gbxremito)
        Me.Controls.Add(Me.gbxfactura)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegistCompra"
        Me.ShowIcon = False
        Me.Text = "Registrar Compra"
        Me.gbxremito.ResumeLayout(False)
        Me.gbxremito.PerformLayout()
        Me.gbxfactura.ResumeLayout(False)
        Me.gbxfactura.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxremito As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtfecharemito As System.Windows.Forms.TextBox
    Friend WithEvents lblfecharemito As System.Windows.Forms.Label
    Friend WithEvents gbxfactura As System.Windows.Forms.GroupBox
    Friend WithEvents txtMedioPago As System.Windows.Forms.TextBox
    Friend WithEvents lblMedioPago As System.Windows.Forms.Label
    Friend WithEvents txtproveedorfacturacompra As System.Windows.Forms.TextBox
    Friend WithEvents txtmontofacturacompra As System.Windows.Forms.TextBox
    Friend WithEvents lblproveedorfacturacompra As System.Windows.Forms.Label
    Friend WithEvents lblmontofacturacompra As System.Windows.Forms.Label
    Friend WithEvents lblproductofacturacompra As System.Windows.Forms.Label
    Friend WithEvents txttipofacturacompra As System.Windows.Forms.TextBox
    Friend WithEvents tipofacturacompra As System.Windows.Forms.Label
    Friend WithEvents txtfechafacturacompra As System.Windows.Forms.TextBox
    Friend WithEvents fechafacturacompra As System.Windows.Forms.Label
    Friend WithEvents txtOrdenCompra As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOrden As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtProdRem As System.Windows.Forms.TextBox
    Friend WithEvents lblDescrRem As System.Windows.Forms.Label
    Friend WithEvents rtxtDescrRem As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents btnsalirregistropago As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnComprobar As System.Windows.Forms.Button
    Friend WithEvents rbnremitonofirmado As System.Windows.Forms.RadioButton
    Friend WithEvents rbnremitofirmado As System.Windows.Forms.RadioButton
    Friend WithEvents rbnAcc As System.Windows.Forms.RadioButton
    Friend WithEvents rbnVeh As System.Windows.Forms.RadioButton
End Class
