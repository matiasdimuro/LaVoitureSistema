Public Class formImprimirPropuesta

    Dim total As Decimal = 0

    Private Sub formImprimirPropuesta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT curdate(), nomyape, dni, patente, modelo, color, costo, descmediopago FROM propuestas p INNER JOIN clientes c ON c.idcliente = p.idcliente INNER JOIN vehiculos v ON v.idvehiculo = p.idvehiculo WHERE codpropuesta = '" & numPropuesta & "'"
        query(sql, 1)
        rs.Read()

        txtNumProp.Text = numPropuesta.ToString
        txtFecha.Text = rs(0)
        txtCliente.Text = rs(1)
        txtDni.Text = rs(2)
        txtPatente.Text = rs(3)
        txtModelo.Text = rs(4)
        txtColor.Text = rs(5)
        txtPrecio.Text = rs(6)
        txtMedioPago.Text = rs(7)

        sql = "SELECT count(codAcces) FROM accesorios WHERE idvehiculo = (SELECT idvehiculo FROM vehiculos WHERE patente = '" & txtPatente.Text & "')"
        query(sql, 1)
        rs.Read()

        If rs(0) > 0 Then

            txtAccesorios.Text = "SI"
            sql = "SELECT nomaccesorio, costoextra FROM accesorios WHERE idvehiculo = (SELECT idvehiculo FROM vehiculos WHERE patente = '" & txtPatente.Text & "')"
            query(sql, 1)

            total = Val(txtPrecio.Text)

            While rs.Read = True
                rtxtAccesorios.Text += rs(0) & " " & rs(1) & " - "
                total = total + rs(1)
            End While

            txtMontoFinal.Text = total

        Else
            txtAccesorios.Text = "NO"
            txtMontoFinal.Text = txtPrecio.Text

        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        btnImprimir.Visible = False
        btnVolver.Visible = False
        printPropuesta.Print()
        btnImprimir.Visible = True
        btnVolver.Visible = True

        Me.Close()
        frmVentas.Show()

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmVentas.Show()
    End Sub
End Class