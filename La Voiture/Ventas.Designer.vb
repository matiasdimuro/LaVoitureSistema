<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.pnlLogoVentas = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnPropuesta = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnCobro = New System.Windows.Forms.Button()
        Me.pnlLogoVentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLogoVentas
        '
        Me.pnlLogoVentas.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogoVentas.BackgroundImage = CType(resources.GetObject("pnlLogoVentas.BackgroundImage"), System.Drawing.Image)
        Me.pnlLogoVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLogoVentas.Controls.Add(Me.btnVolver)
        Me.pnlLogoVentas.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogoVentas.Name = "pnlLogoVentas"
        Me.pnlLogoVentas.Size = New System.Drawing.Size(430, 414)
        Me.pnlLogoVentas.TabIndex = 5
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
        'btnPropuesta
        '
        Me.btnPropuesta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPropuesta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPropuesta.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnPropuesta.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnPropuesta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnPropuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPropuesta.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPropuesta.ForeColor = System.Drawing.Color.Black
        Me.btnPropuesta.Location = New System.Drawing.Point(447, 63)
        Me.btnPropuesta.Name = "btnPropuesta"
        Me.btnPropuesta.Size = New System.Drawing.Size(267, 53)
        Me.btnPropuesta.TabIndex = 8
        Me.btnPropuesta.Text = "Elaborar propuesta"
        Me.btnPropuesta.UseVisualStyleBackColor = False
        '
        'btnVenta
        '
        Me.btnVenta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVenta.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.ForeColor = System.Drawing.Color.Black
        Me.btnVenta.Location = New System.Drawing.Point(447, 169)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(267, 53)
        Me.btnVenta.TabIndex = 9
        Me.btnVenta.Text = "Registrar venta"
        Me.btnVenta.UseVisualStyleBackColor = False
        '
        'btnCobro
        '
        Me.btnCobro.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCobro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCobro.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnCobro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnCobro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCobro.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobro.ForeColor = System.Drawing.Color.Black
        Me.btnCobro.Location = New System.Drawing.Point(447, 277)
        Me.btnCobro.Name = "btnCobro"
        Me.btnCobro.Size = New System.Drawing.Size(267, 53)
        Me.btnCobro.TabIndex = 10
        Me.btnCobro.Text = "Subir cobro"
        Me.btnCobro.UseVisualStyleBackColor = False
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(736, 413)
        Me.Controls.Add(Me.btnCobro)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.btnPropuesta)
        Me.Controls.Add(Me.pnlLogoVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVentas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ventas"
        Me.pnlLogoVentas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLogoVentas As System.Windows.Forms.Panel
    Friend WithEvents btnPropuesta As System.Windows.Forms.Button
    Friend WithEvents btnVenta As System.Windows.Forms.Button
    Friend WithEvents btnCobro As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
