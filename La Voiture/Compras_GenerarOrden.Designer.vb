<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenCompra))
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.lblproducto = New System.Windows.Forms.Label()
        Me.lblproveedor = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.printOrden = New System.Drawing.Printing.PrintDocument()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.pnlFlagPropuesta = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'txtProveedor
        '
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(163, 46)
        Me.txtProveedor.MaxLength = 50
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(345, 24)
        Me.txtProveedor.TabIndex = 2
        '
        'lblproducto
        '
        Me.lblproducto.AutoSize = True
        Me.lblproducto.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproducto.ForeColor = System.Drawing.Color.White
        Me.lblproducto.Location = New System.Drawing.Point(159, 156)
        Me.lblproducto.Name = "lblproducto"
        Me.lblproducto.Size = New System.Drawing.Size(73, 20)
        Me.lblproducto.TabIndex = 8
        Me.lblproducto.Text = "Producto:"
        '
        'lblproveedor
        '
        Me.lblproveedor.AutoSize = True
        Me.lblproveedor.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblproveedor.Location = New System.Drawing.Point(159, 23)
        Me.lblproveedor.Name = "lblproveedor"
        Me.lblproveedor.Size = New System.Drawing.Size(81, 20)
        Me.lblproveedor.TabIndex = 7
        Me.lblproveedor.Text = "Proveedor:"
        '
        'txtProducto
        '
        Me.txtProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(163, 179)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(536, 24)
        Me.txtProducto.TabIndex = 5
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(163, 113)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(345, 24)
        Me.txtDireccion.TabIndex = 3
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.White
        Me.lblDireccion.Location = New System.Drawing.Point(159, 90)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(76, 20)
        Me.lblDireccion.TabIndex = 15
        Me.lblDireccion.Text = "Direccion:"
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(448, 251)
        Me.txtMail.MaxLength = 50
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(251, 24)
        Me.txtMail.TabIndex = 7
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.White
        Me.lblMail.Location = New System.Drawing.Point(444, 228)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(41, 20)
        Me.lblMail.TabIndex = 19
        Me.lblMail.Text = "Mail:"
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(163, 251)
        Me.txtTel.MaxLength = 50
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(247, 24)
        Me.txtTel.TabIndex = 6
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.Color.White
        Me.lblTel.Location = New System.Drawing.Point(159, 223)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(71, 20)
        Me.lblTel.TabIndex = 17
        Me.lblTel.Text = "Telefono:"
        '
        'txtCant
        '
        Me.txtCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant.Location = New System.Drawing.Point(529, 113)
        Me.txtCant.MaxLength = 50
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(170, 24)
        Me.txtCant.TabIndex = 4
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.ForeColor = System.Drawing.Color.White
        Me.lblCant.Location = New System.Drawing.Point(527, 90)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(74, 20)
        Me.lblCant.TabIndex = 21
        Me.lblCant.Text = "Cantidad:"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(529, 46)
        Me.txtFecha.MaxLength = 50
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(170, 24)
        Me.txtFecha.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFecha.Location = New System.Drawing.Point(525, 23)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(54, 20)
        Me.lblFecha.TabIndex = 23
        Me.lblFecha.Text = "Fecha:"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnaceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnaceptar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnaceptar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Black
        Me.btnaceptar.Location = New System.Drawing.Point(571, 368)
        Me.btnaceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(128, 31)
        Me.btnaceptar.TabIndex = 9
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.Black
        Me.btnsalir.Location = New System.Drawing.Point(13, 368)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(128, 31)
        Me.btnsalir.TabIndex = 8
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'pnlFlagPropuesta
        '
        Me.pnlFlagPropuesta.BackgroundImage = CType(resources.GetObject("pnlFlagPropuesta.BackgroundImage"), System.Drawing.Image)
        Me.pnlFlagPropuesta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlFlagPropuesta.Location = New System.Drawing.Point(27, -5)
        Me.pnlFlagPropuesta.Name = "pnlFlagPropuesta"
        Me.pnlFlagPropuesta.Size = New System.Drawing.Size(94, 336)
        Me.pnlFlagPropuesta.TabIndex = 27
        '
        'frmOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(736, 413)
        Me.Controls.Add(Me.pnlFlagPropuesta)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtCant)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.lblproducto)
        Me.Controls.Add(Me.lblproveedor)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmOrdenCompra"
        Me.ShowIcon = False
        Me.Text = "Compras: Generar Orden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblproducto As System.Windows.Forms.Label
    Friend WithEvents lblproveedor As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents printOrden As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents pnlFlagPropuesta As System.Windows.Forms.Panel
End Class
