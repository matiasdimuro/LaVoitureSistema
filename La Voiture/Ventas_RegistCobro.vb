Public Class frmRecibo

    Private Sub frmRecibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtRec.Text = reciboVtaMonto
        txtFactura.Text = facturaVtaNum
        txtCantPlata.Text = txtRec.Text

        sql = "SELECT nomyape, fv.monto FROM clientes c INNER JOIN propuestas p ON p.idCliente = c.idCliente INNER JOIN facturasVenta fv ON fv.codPropuesta = p.codPropuesta WHERE idFacturaVenta = '" & facturaVtaNum & "'"
        query(sql, 1)
        rs.Read()
        txtNom.Text = rs(0)
        txtDeuda.Text = "$ " & (rs(1) - reciboVtaMonto).ToString

        sql = "SELECT EXTRACT(DAY FROM curdate()), EXTRACT(MONTH FROM curdate()), EXTRACT(YEAR FROM curdate())"
        query(sql, 1)
        rs.Read()
        txtDia.Text = rs(0)
        txtMes.Text = rs(1)
        txtAño.Text = rs(2)

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        sql = "INSERT INTO recibosventa VALUES ('', curdate(), '" & facturaVtaNum & "', '" & reciboVtaMonto & "')"
        query(sql, 1)

        sql = "SELECT medio FROM mediospago mp INNER JOIN facturasventa fv ON fv.idMedioPago = mp.idMedioPago WHERE fv.idfacturaventa = '" & facturaVtaNum & "' "
        query(sql, 1)
        rs.Read()

        If rs(0) = "Cheque" Or rs(0) = "cheque" Or rs(0) = "CHEQUE" Then

            sql = "INSERT INTO chequesventa VALUES ('', curdate(), DATE_ADD(curdate(),INTERVAL 30 DAY), '" & reciboVtaMonto & "', (SELECT MAX(idReciboVenta) FROM recibosVenta))"
            query(sql, 1)

        End If

        btnImprimir.Visible = False
        btnVolver.Visible = False
        printReciboVta.Print()
        btnImprimir.Visible = True
        btnVolver.Visible = True

        Me.Close()
        frmVentas.Show()

    End Sub

    Private Sub btnVolver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmVentas.Show()
    End Sub
End Class