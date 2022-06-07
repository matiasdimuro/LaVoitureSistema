<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequePago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequePago))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNumCheque = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumRec = New System.Windows.Forms.TextBox()
        Me.txtNumCheque = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCantPlata = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblCheque = New System.Windows.Forms.Label()
        Me.txtFirma = New System.Windows.Forms.TextBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblNumPropuesta = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.printCheque = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.lblNumCheque)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNumRec)
        Me.Panel1.Controls.Add(Me.txtNumCheque)
        Me.Panel1.Controls.Add(Me.txtAño)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtCantPlata)
        Me.Panel1.Controls.Add(Me.txtMes)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtNom)
        Me.Panel1.Controls.Add(Me.lblCheque)
        Me.Panel1.Controls.Add(Me.txtFirma)
        Me.Panel1.Controls.Add(Me.txtDia)
        Me.Panel1.Controls.Add(Me.txtMonto)
        Me.Panel1.Controls.Add(Me.lblNumPropuesta)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(27, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 336)
        Me.Panel1.TabIndex = 0
        '
        'lblNumCheque
        '
        Me.lblNumCheque.AutoSize = True
        Me.lblNumCheque.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCheque.ForeColor = System.Drawing.Color.Black
        Me.lblNumCheque.Location = New System.Drawing.Point(17, 229)
        Me.lblNumCheque.Name = "lblNumCheque"
        Me.lblNumCheque.Size = New System.Drawing.Size(138, 26)
        Me.lblNumCheque.TabIndex = 286
        Me.lblNumCheque.Text = "Num. cheque:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(344, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 26)
        Me.Label3.TabIndex = 285
        Me.Label3.Text = "Num. recibo:"
        '
        'txtNumRec
        '
        Me.txtNumRec.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtNumRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRec.Location = New System.Drawing.Point(480, 233)
        Me.txtNumRec.MaxLength = 200
        Me.txtNumRec.Name = "txtNumRec"
        Me.txtNumRec.ReadOnly = True
        Me.txtNumRec.Size = New System.Drawing.Size(180, 24)
        Me.txtNumRec.TabIndex = 284
        Me.txtNumRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumCheque
        '
        Me.txtNumCheque.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtNumCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCheque.Location = New System.Drawing.Point(170, 231)
        Me.txtNumCheque.MaxLength = 200
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.ReadOnly = True
        Me.txtNumCheque.Size = New System.Drawing.Size(160, 24)
        Me.txtNumCheque.TabIndex = 283
        Me.txtNumCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño
        '
        Me.txtAño.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(587, 60)
        Me.txtAño.MaxLength = 200
        Me.txtAño.Name = "txtAño"
        Me.txtAño.ReadOnly = True
        Me.txtAño.Size = New System.Drawing.Size(73, 24)
        Me.txtAño.TabIndex = 282
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 120)
        Me.Panel2.TabIndex = 271
        '
        'txtCantPlata
        '
        Me.txtCantPlata.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtCantPlata.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantPlata.Location = New System.Drawing.Point(480, 140)
        Me.txtCantPlata.MaxLength = 200
        Me.txtCantPlata.Name = "txtCantPlata"
        Me.txtCantPlata.ReadOnly = True
        Me.txtCantPlata.Size = New System.Drawing.Size(180, 24)
        Me.txtCantPlata.TabIndex = 275
        Me.txtCantPlata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMes
        '
        Me.txtMes.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMes.Location = New System.Drawing.Point(480, 60)
        Me.txtMes.MaxLength = 200
        Me.txtMes.Name = "txtMes"
        Me.txtMes.ReadOnly = True
        Me.txtMes.Size = New System.Drawing.Size(73, 24)
        Me.txtMes.TabIndex = 281
        Me.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(332, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 26)
        Me.Label1.TabIndex = 274
        Me.Label1.Text = "la cantidad de"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 26)
        Me.Label2.TabIndex = 276
        Me.Label2.Text = "firma del encargado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(559, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 26)
        Me.Label6.TabIndex = 280
        Me.Label6.Text = "/"
        '
        'txtNom
        '
        Me.txtNom.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(114, 140)
        Me.txtNom.MaxLength = 200
        Me.txtNom.Name = "txtNom"
        Me.txtNom.ReadOnly = True
        Me.txtNom.Size = New System.Drawing.Size(216, 24)
        Me.txtNom.TabIndex = 273
        Me.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCheque
        '
        Me.lblCheque.AutoSize = True
        Me.lblCheque.Font = New System.Drawing.Font("Trebuchet MS", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheque.ForeColor = System.Drawing.Color.Black
        Me.lblCheque.Location = New System.Drawing.Point(158, 26)
        Me.lblCheque.Name = "lblCheque"
        Me.lblCheque.Size = New System.Drawing.Size(209, 67)
        Me.lblCheque.TabIndex = 268
        Me.lblCheque.Text = "Cheque"
        '
        'txtFirma
        '
        Me.txtFirma.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirma.Location = New System.Drawing.Point(214, 187)
        Me.txtFirma.MaxLength = 200
        Me.txtFirma.Name = "txtFirma"
        Me.txtFirma.Size = New System.Drawing.Size(446, 24)
        Me.txtFirma.TabIndex = 277
        Me.txtFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDia
        '
        Me.txtDia.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDia.Location = New System.Drawing.Point(373, 60)
        Me.txtDia.MaxLength = 200
        Me.txtDia.Name = "txtDia"
        Me.txtDia.ReadOnly = True
        Me.txtDia.Size = New System.Drawing.Size(73, 24)
        Me.txtDia.TabIndex = 279
        Me.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(523, 285)
        Me.txtMonto.MaxLength = 200
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(137, 24)
        Me.txtMonto.TabIndex = 272
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumPropuesta
        '
        Me.lblNumPropuesta.AutoSize = True
        Me.lblNumPropuesta.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPropuesta.ForeColor = System.Drawing.Color.Black
        Me.lblNumPropuesta.Location = New System.Drawing.Point(495, 283)
        Me.lblNumPropuesta.Name = "lblNumPropuesta"
        Me.lblNumPropuesta.Size = New System.Drawing.Size(22, 26)
        Me.lblNumPropuesta.TabIndex = 269
        Me.lblNumPropuesta.Text = "$"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Location = New System.Drawing.Point(13, 138)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(101, 26)
        Me.lblFecha.TabIndex = 270
        Me.lblFecha.Text = "Paguese a"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(452, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 26)
        Me.Label7.TabIndex = 278
        Me.Label7.Text = "/"
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
        Me.btnVolver.Location = New System.Drawing.Point(27, 368)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(128, 31)
        Me.btnVolver.TabIndex = 219
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
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
        Me.btnImprimir.Location = New System.Drawing.Point(581, 368)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 31)
        Me.btnImprimir.TabIndex = 218
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'frmChequePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(736, 413)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChequePago"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Compras: Cheque Pago"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtCantPlata As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblCheque As System.Windows.Forms.Label
    Friend WithEvents txtFirma As System.Windows.Forms.TextBox
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblNumPropuesta As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents printCheque As System.Drawing.Printing.PrintDocument
    Friend WithEvents lblNumCheque As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumRec As System.Windows.Forms.TextBox
    Friend WithEvents txtNumCheque As System.Windows.Forms.TextBox
End Class
