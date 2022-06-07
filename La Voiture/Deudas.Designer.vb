<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeudas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeudas))
        Me.rtxtDeudas = New System.Windows.Forms.RichTextBox()
        Me.txtAclaracion = New System.Windows.Forms.TextBox()
        Me.lblDniClien = New System.Windows.Forms.Label()
        Me.pnlFlagDeudas = New System.Windows.Forms.Panel()
        Me.txtDniClien = New System.Windows.Forms.TextBox()
        Me.btnRevisar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtxtDeudas
        '
        Me.rtxtDeudas.Cursor = System.Windows.Forms.Cursors.Default
        Me.rtxtDeudas.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtDeudas.Location = New System.Drawing.Point(146, 137)
        Me.rtxtDeudas.Name = "rtxtDeudas"
        Me.rtxtDeudas.ReadOnly = True
        Me.rtxtDeudas.Size = New System.Drawing.Size(568, 248)
        Me.rtxtDeudas.TabIndex = 16
        Me.rtxtDeudas.Text = ""
        Me.rtxtDeudas.WordWrap = False
        '
        'txtAclaracion
        '
        Me.txtAclaracion.AccessibleDescription = ""
        Me.txtAclaracion.BackColor = System.Drawing.Color.Black
        Me.txtAclaracion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAclaracion.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtAclaracion.Enabled = False
        Me.txtAclaracion.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAclaracion.ForeColor = System.Drawing.Color.White
        Me.txtAclaracion.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtAclaracion.Location = New System.Drawing.Point(283, 84)
        Me.txtAclaracion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAclaracion.MaxLength = 70
        Me.txtAclaracion.Multiline = True
        Me.txtAclaracion.Name = "txtAclaracion"
        Me.txtAclaracion.ReadOnly = True
        Me.txtAclaracion.Size = New System.Drawing.Size(175, 31)
        Me.txtAclaracion.TabIndex = 21
        Me.txtAclaracion.Text = "( para ver todas las deudas dejarlo en blanco)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtAclaracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDniClien
        '
        Me.lblDniClien.AutoSize = True
        Me.lblDniClien.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDniClien.ForeColor = System.Drawing.Color.Transparent
        Me.lblDniClien.Location = New System.Drawing.Point(142, 21)
        Me.lblDniClien.Name = "lblDniClien"
        Me.lblDniClien.Size = New System.Drawing.Size(115, 22)
        Me.lblDniClien.TabIndex = 20
        Me.lblDniClien.Text = "DNI del cliente"
        '
        'pnlFlagDeudas
        '
        Me.pnlFlagDeudas.BackgroundImage = CType(resources.GetObject("pnlFlagDeudas.BackgroundImage"), System.Drawing.Image)
        Me.pnlFlagDeudas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlFlagDeudas.Location = New System.Drawing.Point(12, -5)
        Me.pnlFlagDeudas.Name = "pnlFlagDeudas"
        Me.pnlFlagDeudas.Size = New System.Drawing.Size(94, 346)
        Me.pnlFlagDeudas.TabIndex = 19
        '
        'txtDniClien
        '
        Me.txtDniClien.AccessibleDescription = ""
        Me.txtDniClien.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDniClien.Location = New System.Drawing.Point(146, 48)
        Me.txtDniClien.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDniClien.MaxLength = 70
        Me.txtDniClien.Name = "txtDniClien"
        Me.txtDniClien.Size = New System.Drawing.Size(312, 26)
        Me.txtDniClien.TabIndex = 1
        '
        'btnRevisar
        '
        Me.btnRevisar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRevisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRevisar.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnRevisar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRevisar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRevisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRevisar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevisar.ForeColor = System.Drawing.Color.Black
        Me.btnRevisar.Location = New System.Drawing.Point(146, 84)
        Me.btnRevisar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRevisar.Name = "btnRevisar"
        Me.btnRevisar.Size = New System.Drawing.Size(137, 31)
        Me.btnRevisar.TabIndex = 2
        Me.btnRevisar.Text = "Revisar Deudas"
        Me.btnRevisar.UseVisualStyleBackColor = False
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
        Me.btnVolver.Location = New System.Drawing.Point(13, 363)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(94, 31)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmDeudas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(736, 413)
        Me.Controls.Add(Me.rtxtDeudas)
        Me.Controls.Add(Me.txtAclaracion)
        Me.Controls.Add(Me.lblDniClien)
        Me.Controls.Add(Me.pnlFlagDeudas)
        Me.Controls.Add(Me.txtDniClien)
        Me.Controls.Add(Me.btnRevisar)
        Me.Controls.Add(Me.btnVolver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDeudas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Deudas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtxtDeudas As System.Windows.Forms.RichTextBox
    Friend WithEvents txtAclaracion As System.Windows.Forms.TextBox
    Friend WithEvents lblDniClien As System.Windows.Forms.Label
    Friend WithEvents pnlFlagDeudas As System.Windows.Forms.Panel
    Friend WithEvents txtDniClien As System.Windows.Forms.TextBox
    Friend WithEvents btnRevisar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
