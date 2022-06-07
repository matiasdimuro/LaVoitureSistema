Public Class formRegistVenta

    Dim idMedioPago As Integer
    Dim medioDePago() As String
    Dim total As Decimal = 0
    Dim vehiculoVendido As Integer

    Private Sub formRegistVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT MAX(idFacturaVenta) + 1, curdate() FROM FacturasVenta"
        query(sql, 1)
        rs.Read()

        txtNumFact.Text = rs(0)
        txtFecha.Text = rs(1)

        sql = "SELECT nomyape, dom, descmediopago FROM propuestas p INNER JOIN clientes c ON c.idCliente = p.idCliente WHERE codPropuesta = '" & numPropuesta & "'"
        query(sql, 1)
        rs.Read()

        txtCliente.Text = rs(0)
        txtDire.Text = rs(1)
        txtMedioPago.Text = rs(2)

        sql = "SELECT modelo, color, patente, costo, v.idvehiculo FROM vehiculos v INNER JOIN propuestas p ON p.idVehiculo = v.idVehiculo WHERE codPropuesta = '" & numPropuesta & "'"
        query(sql, 1)
        rs.Read()

        rtxtDesc.Text = rs(0) & " - " & rs(1) & " - " & rs(2) & " - " & rs(3) & " - " & "pesos" & vbCr
        total += rs(3)

        sql = "SELECT nomaccesorio, costoextra FROM accesorios WHERE idvehiculo = '" & rs(4) & "'"
        query(sql, 1)

        While rs.Read = True

            rtxtDesc.Text += rs(0) & " " & rs(1) & "pesos / "
            total += rs(1)

        End While

        txtTotal.Text = total.ToString

        medioDePago = (txtMedioPago.Text.ToString.Replace(" ", "")).Split("-")

        sql = "SELECT idMedioPago FROM MediosPago WHERE tipo = '" & medioDePago(0) & "' AND medio = '" & medioDePago(1) & "' AND cuotas = '" & medioDePago(2) & "' "
        query(sql, 1)
        rs.Read()

        idMedioPago = rs(0)

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        sql = "INSERT INTO facturasVenta VALUES ('" & txtNumFact.Text & "', '" & txtFecha.Text & "', 'B', '" & txtTotal.Text & "', '" & rtxtDesc.Text & "', '" & idMedioPago & "', '" & numPropuesta & "')"
        query(sql, 1)

        sql = "SELECT v.idvehiculo FROM vehiculos v INNER JOIN propuestas p ON p.idvehiculo = v.idvehiculo INNER JOIN facturasventa fv ON fv.codpropuesta = p.codpropuesta WHERE idfacturaventa = '" & txtNumFact.Text & "'"
        query(sql, 1)
        rs.Read()
        vehiculoVendido = rs(0)

        sql = "UPDATE vehiculos SET disponible = 0 WHERE idvehiculo = '" & vehiculoVendido & "'"
        query(sql, 1)

        btnImprimir.Visible = False
        btnVolver.Visible = False
        printFacturaVenta.Print()
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