<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnRevisar = New System.Windows.Forms.Button()
        Me.txtModeloAuto = New System.Windows.Forms.TextBox()
        Me.pnlFlagStock = New System.Windows.Forms.Panel()
        Me.lblModeloAuto = New System.Windows.Forms.Label()
        Me.txtAclaracion = New System.Windows.Forms.TextBox()
        Me.rtxtStock = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
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
        Me.btnVolver.TabIndex = 14
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
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
        Me.btnRevisar.Location = New System.Drawing.Point(145, 88)
        Me.btnRevisar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRevisar.Name = "btnRevisar"
        Me.btnRevisar.Size = New System.Drawing.Size(137, 31)
        Me.btnRevisar.TabIndex = 9
        Me.btnRevisar.Text = "Revisar Stock"
        Me.btnRevisar.UseVisualStyleBackColor = False
        '
        'txtModeloAuto
        '
        Me.txtModeloAuto.AccessibleDescription = ""
        Me.txtModeloAuto.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloAuto.Location = New System.Drawing.Point(145, 52)
        Me.txtModeloAuto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtModeloAuto.MaxLength = 70
        Me.txtModeloAuto.Name = "txtModeloAuto"
        Me.txtModeloAuto.Size = New System.Drawing.Size(289, 26)
        Me.txtModeloAuto.TabIndex = 1
        '
        'pnlFlagStock
        '
        Me.pnlFlagStock.BackgroundImage = CType(resources.GetObject("pnlFlagStock.BackgroundImage"), System.Drawing.Image)
        Me.pnlFlagStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlFlagStock.Location = New System.Drawing.Point(12, -4)
        Me.pnlFlagStock.Name = "pnlFlagStock"
        Me.pnlFlagStock.Size = New System.Drawing.Size(94, 346)
        Me.pnlFlagStock.TabIndex = 12
        '
        'lblModeloAuto
        '
        Me.lblModeloAuto.AutoSize = True
        Me.lblModeloAuto.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloAuto.ForeColor = System.Drawing.Color.Transparent
        Me.lblModeloAuto.Location = New System.Drawing.Point(141, 25)
        Me.lblModeloAuto.Name = "lblModeloAuto"
        Me.lblModeloAuto.Size = New System.Drawing.Size(124, 22)
        Me.lblModeloAuto.TabIndex = 13
        Me.lblModeloAuto.Text = "Modelo del Auto"
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
        Me.txtAclaracion.Location = New System.Drawing.Point(290, 88)
        Me.txtAclaracion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAclaracion.MaxLength = 70
        Me.txtAclaracion.Multiline = True
        Me.txtAclaracion.Name = "txtAclaracion"
        Me.txtAclaracion.ReadOnly = True
        Me.txtAclaracion.Size = New System.Drawing.Size(144, 37)
        Me.txtAclaracion.TabIndex = 14
        Me.txtAclaracion.Text = "( para ver stock total dejarlo en blanco)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtAclaracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rtxtStock
        '
        Me.rtxtStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.rtxtStock.Location = New System.Drawing.Point(464, 25)
        Me.rtxtStock.Name = "rtxtStock"
        Me.rtxtStock.ReadOnly = True
        Me.rtxtStock.Size = New System.Drawing.Size(250, 364)
        Me.rtxtStock.TabIndex = 15
        Me.rtxtStock.Text = ""
        Me.rtxtStock.WordWrap = False
        '
        'frmStock
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(736, 413)
        Me.Controls.Add(Me.rtxtStock)
        Me.Controls.Add(Me.txtAclaracion)
        Me.Controls.Add(Me.lblModeloAuto)
        Me.Controls.Add(Me.pnlFlagStock)
        Me.Controls.Add(Me.txtModeloAuto)
        Me.Controls.Add(Me.btnRevisar)
        Me.Controls.Add(Me.btnVolver)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmStock"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnRevisar As System.Windows.Forms.Button
    Friend WithEvents txtModeloAuto As System.Windows.Forms.TextBox
    Friend WithEvents pnlFlagStock As System.Windows.Forms.Panel
    Friend WithEvents lblModeloAuto As System.Windows.Forms.Label
    Friend WithEvents txtAclaracion As System.Windows.Forms.TextBox
    Friend WithEvents rtxtStock As System.Windows.Forms.RichTextBox
End Class
