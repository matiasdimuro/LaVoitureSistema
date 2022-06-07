Public Class frmRegistCompra

    Private Sub frmRegistCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT CURDATE()"
        query(sql, 1)
        rs.Read()
        txtfechafacturacompra.Text = rs(0)
        txtfecharemito.Text = rs(0)

    End Sub

    Private Sub btnsalirregistropago_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalirregistropago.Click
        Me.Close()
        frmCompras.Show()
    End Sub

    Private Sub btnComprobar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprobar.Click

        sql = "SELECT COUNT(*) FROM ordenescompra WHERE codOC = '" & txtOrdenCompra.Text & "'"
        query(sql, 1)
        rs.Read()

        If rs(0) = 0 Then
            MsgBox("No existe tal orden. Pruebe de nuevo.", vbExclamation, vbOKOnly)
            txtOrdenCompra.Text = ""
            btnRegistrar.Enabled = False

        Else
            sql = "SELECT nomProv, producto, cantidad FROM ordenescompra oc INNER JOIN proveedores p ON p.idProveedor = oc.idProveedor WHERE codOC = '" & txtOrdenCompra.Text & "'"
            query(sql, 1)
            rs.Read()

            txtproveedorfacturacompra.Text = rs(0)
            txtProdRem.Text = rs(1)
            txtProducto.Text = rs(1)
            txtCantidad.Text = rs(2)

            btnRegistrar.Enabled = True

        End If

    End Sub

    Private Sub btnRegistrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        Dim medioDePago() As String
        Dim idMedioPago As Integer
        Dim remitoFirmado As Integer
        Dim productoCampos() As String
        Dim flag As Integer = 0
        Dim patentevehiculoaccesorio As String
        Dim idvehiculoaccesorio As Integer

        medioDePago = (txtMedioPago.Text.ToString.Replace(" ", "")).Split("-")

        sql = "SELECT idMedioPago FROM MediosPago WHERE tipo = '" & medioDePago(0) & "' AND medio = '" & medioDePago(1) & "' AND cuotas = '" & medioDePago(2) & "' "
        query(sql, 1)
        rs.Read()

        idMedioPago = rs(0)

        'REGISTRO LA FACTURA
        sql = "INSERT INTO facturascompra VALUES ('', curdate(), 'A', '" & txtmontofacturacompra.Text & "', '" & txtCantidad.Text & "  " & txtProducto.Text & "', '" & txtproveedorfacturacompra.Text & "', '" & idMedioPago & "', '" & txtOrdenCompra.Text & "')"
        query(sql, 1)

        'ACEPTO ORDEN
        sql = "UPDATE ordenescompra SET estado = 1 WHERE codOC = '" & txtOrdenCompra.Text & "'"
        query(sql, 1)

        ' FIRMARON EL REMITO
        If rbnremitofirmado.Checked = True Then
            remitoFirmado = 1

        ElseIf rbnremitonofirmado.Checked = True Then
            remitoFirmado = 0

        End If

        'REGISTRO EL REMITO
        sql = "INSERT INTO remitoscompra VALUES ('', curdate(), '" & rtxtDescrRem.Text & "', '" & remitoFirmado & "', (SELECT MAX(idFacturaCompra) FROM facturasCompra))"
        query(sql, 1)

        'ACTUALIZO STOCK

        'ES UN VEHICULO ...
        If rbnVeh.Checked = True Then

            productoCampos = (txtProducto.Text.ToString.Split("-"))

            For i = 1 To Val(txtCantidad.Text) Step 1
                sql = "INSERT INTO vehiculos VALUES ('', '" & productoCampos(0) & "', '" & productoCampos(1) & "', '" & productoCampos(2) & "', '" & productoCampos(3) & "', 1)"
                query(sql, 1)
            Next

            Me.Close()
            frmCompras.Show()

            'ES UN ACCESORIO
        ElseIf rbnAcc.Checked = True Then

            For x = 1 To Val(txtCantidad.Text) Step 1

                flag = 0

                While flag = 0

                    patentevehiculoaccesorio = InputBox("Ingrese la patente del auto a asignar el accesorio " & x, "Actualizar stock", "")

                    If patentevehiculoaccesorio = "" Then
                        MsgBox("Ingresar una patente.", MsgBoxStyle.Critical, vbOKOnly)

                    ElseIf patentevehiculoaccesorio.Length < 15 Then

                        sql = "SELECT COUNT(idvehiculo) FROM vehiculos WHERE disponible = 1 AND patente = '" & patentevehiculoaccesorio & "'"
                        query(sql, 1)
                        rs.Read()

                        If rs(0) = 0 Then
                            MsgBox("No existe tal vehiculo. Pruebe de nuevo.", MsgBoxStyle.Critical, vbOKOnly)

                        Else
                            flag = 1

                            sql = "SELECT idvehiculo FROM vehiculos WHERE patente = '" & patentevehiculoaccesorio & "'"
                            query(sql, 1)
                            rs.Read()

                            idvehiculoaccesorio = rs(0)

                            sql = "INSERT INTO accesorios VALUES ('', '" & txtProducto.Text & "', '" & Val(txtmontofacturacompra.Text) / Val(txtCantidad.Text) & "', '" & idvehiculoaccesorio & "')"
                            query(sql, 1)

                        End If

                    ElseIf patentevehiculoaccesorio.Length > 15 Then
                        MsgBox("Ingreso de caracteres excedido. Pruebe de nuevo.", MsgBoxStyle.Critical, vbOKCancel)

                    End If

                End While

            Next


        End If

        Me.Close()
        frmCompras.Show()

    End Sub

    Private Sub txtOrdenCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrdenCompra.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmontofacturacompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmontofacturacompra.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class