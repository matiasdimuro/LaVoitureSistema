<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnRegistCompra = New System.Windows.Forms.Button()
        Me.btnGenerarOrden = New System.Windows.Forms.Button()
        Me.pnlLogoCompras = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pnlLogoCompras.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPago
        '
        Me.btnPago.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPago.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnPago.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnPago.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPago.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPago.ForeColor = System.Drawing.Color.Black
        Me.btnPago.Location = New System.Drawing.Point(448, 278)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(267, 53)
        Me.btnPago.TabIndex = 14
        Me.btnPago.Text = "Subir Pago"
        Me.btnPago.UseVisualStyleBackColor = False
        '
        'btnRegistCompra
        '
        Me.btnRegistCompra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRegistCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistCompra.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnRegistCompra.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRegistCompra.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRegistCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistCompra.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistCompra.ForeColor = System.Drawing.Color.Black
        Me.btnRegistCompra.Location = New System.Drawing.Point(448, 170)
        Me.btnRegistCompra.Name = "btnRegistCompra"
        Me.btnRegistCompra.Size = New System.Drawing.Size(267, 53)
        Me.btnRegistCompra.TabIndex = 13
        Me.btnRegistCompra.Text = "Registrar Compra"
        Me.btnRegistCompra.UseVisualStyleBackColor = False
        '
        'btnGenerarOrden
        '
        Me.btnGenerarOrden.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGenerarOrden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarOrden.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnGenerarOrden.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnGenerarOrden.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnGenerarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarOrden.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarOrden.ForeColor = System.Drawing.Color.Black
        Me.btnGenerarOrden.Location = New System.Drawing.Point(448, 64)
        Me.btnGenerarOrden.Name = "btnGenerarOrden"
        Me.btnGenerarOrden.Size = New System.Drawing.Size(267, 53)
        Me.btnGenerarOrden.TabIndex = 12
        Me.btnGenerarOrden.Text = "Generar Orden"
        Me.btnGenerarOrden.UseVisualStyleBackColor = False
        '
        'pnlLogoCompras
        '
        Me.pnlLogoCompras.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogoCompras.BackgroundImage = CType(resources.GetObject("pnlLogoCompras.BackgroundImage"), System.Drawing.Image)
        Me.pnlLogoCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLogoCompras.Controls.Add(Me.btnVolver)
        Me.pnlLogoCompras.Location = New System.Drawing.Point(1, 1)
        Me.pnlLogoCompras.Name = "pnlLogoCompras"
        Me.pnlLogoCompras.Size = New System.Drawing.Size(430, 414)
        Me.pnlLogoCompras.TabIndex = 11
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
        Me.btnVolver.Location = New System.Drawing.Point(13, 358)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(94, 31)
        Me.btnVolver.TabIndex = 11
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(736, 413)
        Me.Controls.Add(Me.btnPago)
        Me.Controls.Add(Me.btnRegistCompra)
        Me.Controls.Add(Me.btnGenerarOrden)
        Me.Controls.Add(Me.pnlLogoCompras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCompras"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Compras"
        Me.pnlLogoCompras.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPago As System.Windows.Forms.Button
    Friend WithEvents btnRegistCompra As System.Windows.Forms.Button
    Friend WithEvents btnGenerarOrden As System.Windows.Forms.Button
    Friend WithEvents pnlLogoCompras As System.Windows.Forms.Panel
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
