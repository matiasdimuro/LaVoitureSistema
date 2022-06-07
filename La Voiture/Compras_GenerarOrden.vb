Public Class frmOrdenCompra

    Private Sub txtProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProveedor.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCant.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT CURDATE()"
        query(sql, 1)
        rs.Read()
        txtFecha.Text = rs(0)

    End Sub

    Private Sub btnsalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
        frmCompras.Show()
    End Sub

    Private Sub btnaceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        sql = "SELECT COUNT(*) FROM proveedores WHERE nomProv = '" & txtProveedor.Text & "'"
        query(sql, 1)
        rs.Read()

        If rs(0) = 0 Then   'PROOVEDOR NUEVO -> LO REGISTRO
            sql = "INSERT INTO proveedores VALUES ('', '" & txtProveedor.Text & "', '" & txtDireccion.Text & "', '" & txtTel.Text & "', '" & txtMail.Text & "', null)"
            query(sql, 1)

        Else                'PROVEEDOR EXISTENTE -> ACTUALIZO DATOS
            sql = "UPDATE proveedores SET direc = '" & txtDireccion.Text & "', tel = '" & txtTel.Text & "', mail = '" & txtMail.Text & "' WHERE nomProv = '" & txtProveedor.Text & "'"

        End If

        sql = "INSERT INTO ordenescompra VALUES ('', curdate(), null, '" & txtProducto.Text & "', '" & txtCant.Text & "', false, (SELECT idproveedor FROM proveedores WHERE nomProv = '" & txtProveedor.Text & "' ))"
        query(sql, 1)

        btnaceptar.Visible = False
        btnsalir.Visible = False
        printOrden.Print()
        btnaceptar.Visible = True
        btnsalir.Visible = True

        Me.Close()
        frmCompras.Show()

    End Sub

    Private Sub txtTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class