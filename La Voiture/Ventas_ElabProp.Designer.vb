<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElabPropuesta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmElabPropuesta))
        Me.pnlFlagPropuesta = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtMedioPago = New System.Windows.Forms.TextBox()
        Me.txtDom = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblMedioPago = New System.Windows.Forms.Label()
        Me.lblDom = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblPatente = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'pnlFlagPropuesta
        '
        Me.pnlFlagPropuesta.BackgroundImage = CType(resources.GetObject("pnlFlagPropuesta.BackgroundImage"), System.Drawing.Image)
        Me.pnlFlagPropuesta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlFlagPropuesta.Location = New System.Drawing.Point(12, -4)
        Me.pnlFlagPropuesta.Name = "pnlFlagPropuesta"
        Me.pnlFlagPropuesta.Size = New System.Drawing.Size(94, 346)
        Me.pnlFlagPropuesta.TabIndex = 14
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
        Me.btnVolver.Location = New System.Drawing.Point(13, 359)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(94, 31)
        Me.btnVolver.TabIndex = 13
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
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
        Me.btnRegistrar.Location = New System.Drawing.Point(595, 359)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(128, 31)
        Me.btnRegistrar.TabIndex = 30
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(131, 45)
        Me.txtCliente.MaxLength = 200
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(177, 26)
        Me.txtCliente.TabIndex = 17
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(328, 45)
        Me.txtDni.MaxLength = 11
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(171, 26)
        Me.txtDni.TabIndex = 18
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(516, 45)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(189, 26)
        Me.txtTelefono.TabIndex = 19
        '
        'txtMedioPago
        '
        Me.txtMedioPago.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedioPago.Location = New System.Drawing.Point(516, 135)
        Me.txtMedioPago.MaxLength = 50
        Me.txtMedioPago.Name = "txtMedioPago"
        Me.txtMedioPago.Size = New System.Drawing.Size(189, 26)
        Me.txtMedioPago.TabIndex = 22
        '
        'txtDom
        '
        Me.txtDom.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDom.Location = New System.Drawing.Point(328, 135)
        Me.txtDom.MaxLength = 50
        Me.txtDom.Name = "txtDom"
        Me.txtDom.Size = New System.Drawing.Size(171, 26)
        Me.txtDom.TabIndex = 21
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(131, 135)
        Me.txtMail.MaxLength = 50
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(177, 26)
        Me.txtMail.TabIndex = 20
        '
        'txtPatente
        '
        Me.txtPatente.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatente.Location = New System.Drawing.Point(328, 226)
        Me.txtPatente.MaxLength = 15
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(189, 26)
        Me.txtPatente.TabIndex = 25
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Transparent
        Me.lblCliente.Location = New System.Drawing.Point(127, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(61, 22)
        Me.lblCliente.TabIndex = 27
        Me.lblCliente.Text = "Cliente"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.ForeColor = System.Drawing.Color.Transparent
        Me.lblDni.Location = New System.Drawing.Point(324, 20)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(34, 22)
        Me.lblDni.TabIndex = 28
        Me.lblDni.Text = "DNI"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Location = New System.Drawing.Point(512, 20)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 22)
        Me.lblTelefono.TabIndex = 29
        Me.lblTelefono.Text = "Telefono"
        '
        'lblMedioPago
        '
        Me.lblMedioPago.AutoSize = True
        Me.lblMedioPago.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedioPago.ForeColor = System.Drawing.Color.Transparent
        Me.lblMedioPago.Location = New System.Drawing.Point(512, 110)
        Me.lblMedioPago.Name = "lblMedioPago"
        Me.lblMedioPago.Size = New System.Drawing.Size(91, 22)
        Me.lblMedioPago.TabIndex = 32
        Me.lblMedioPago.Text = "Medio Pago"
        '
        'lblDom
        '
        Me.lblDom.AutoSize = True
        Me.lblDom.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDom.ForeColor = System.Drawing.Color.Transparent
        Me.lblDom.Location = New System.Drawing.Point(324, 110)
        Me.lblDom.Name = "lblDom"
        Me.lblDom.Size = New System.Drawing.Size(78, 22)
        Me.lblDom.TabIndex = 31
        Me.lblDom.Text = "Domicilio"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.Transparent
        Me.lblMail.Location = New System.Drawing.Point(127, 110)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(38, 22)
        Me.lblMail.TabIndex = 30
        Me.lblMail.Text = "Mail"
        '
        'lblPatente
        '
        Me.lblPatente.AutoSize = True
        Me.lblPatente.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatente.ForeColor = System.Drawing.Color.Transparent
        Me.lblPatente.Location = New System.Drawing.Point(324, 201)
        Me.lblPatente.Name = "lblPatente"
        Me.lblPatente.Size = New System.Drawing.Size(64, 22)
        Me.lblPatente.TabIndex = 35
        Me.lblPatente.Text = "Patente"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.Transparent
        Me.lblMonto.Location = New System.Drawing.Point(127, 201)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(53, 22)
        Me.lblMonto.TabIndex = 36
        Me.lblMonto.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(513, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "(forma - medio - cuotas)"
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(131, 226)
        Me.txtMonto.MaxLength = 20
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(177, 26)
        Me.txtMonto.TabIndex = 26
        '
        'frmElabPropuesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(736, 413)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblPatente)
        Me.Controls.Add(Me.lblMedioPago)
        Me.Controls.Add(Me.lblDom)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDni)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.txtPatente)
        Me.Controls.Add(Me.txtMedioPago)
        Me.Controls.Add(Me.txtDom)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.pnlFlagPropuesta)
        Me.Controls.Add(Me.btnVolver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmElabPropuesta"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ventas: Elaborar Propuesta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlFlagPropuesta As System.Windows.Forms.Panel
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtMedioPago As System.Windows.Forms.TextBox
    Friend WithEvents txtDom As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtPatente As System.Windows.Forms.TextBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblMedioPago As System.Windows.Forms.Label
    Friend WithEvents lblDom As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblPatente As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
End Class
