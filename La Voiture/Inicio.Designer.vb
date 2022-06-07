<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.pnlLogoHome = New System.Windows.Forms.Panel()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnDeudas = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVentas.Location = New System.Drawing.Point(446, 35)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(267, 53)
        Me.btnVentas.TabIndex = 2
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'pnlLogoHome
        '
        Me.pnlLogoHome.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogoHome.BackgroundImage = CType(resources.GetObject("pnlLogoHome.BackgroundImage"), System.Drawing.Image)
        Me.pnlLogoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLogoHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogoHome.Name = "pnlLogoHome"
        Me.pnlLogoHome.Size = New System.Drawing.Size(430, 414)
        Me.pnlLogoHome.TabIndex = 1
        '
        'btnCompras
        '
        Me.btnCompras.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompras.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCompras.Location = New System.Drawing.Point(446, 126)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(267, 53)
        Me.btnCompras.TabIndex = 3
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.UseVisualStyleBackColor = False
        '
        'btnDeudas
        '
        Me.btnDeudas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDeudas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeudas.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnDeudas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnDeudas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnDeudas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeudas.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeudas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDeudas.Location = New System.Drawing.Point(446, 219)
        Me.btnDeudas.Name = "btnDeudas"
        Me.btnDeudas.Size = New System.Drawing.Size(267, 53)
        Me.btnDeudas.TabIndex = 6
        Me.btnDeudas.Text = "Deudas"
        Me.btnDeudas.UseVisualStyleBackColor = False
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.Font = New System.Drawing.Font("Trebuchet MS", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.Color.Black
        Me.btnStock.Location = New System.Drawing.Point(446, 316)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(267, 53)
        Me.btnStock.TabIndex = 7
        Me.btnStock.Text = "Stock"
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(736, 413)
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.btnDeudas)
        Me.Controls.Add(Me.btnCompras)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.pnlLogoHome)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHome"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "La Voiture Sistema"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVentas As System.Windows.Forms.Button
    Friend WithEvents pnlLogoHome As System.Windows.Forms.Panel
    Friend WithEvents btnCompras As System.Windows.Forms.Button
    Friend WithEvents btnDeudas As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button

End Class
