Public Class frmChequePago

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmCompras.Show()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        btnImprimir.Visible = False
        btnVolver.Visible = False
        printCheque.Print()
        btnImprimir.Visible = True
        btnVolver.Visible = True

        Me.Close()
        frmCompras.Show()

    End Sub

    Private Sub frmChequePago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "SELECT EXTRACT(DAY FROM curdate()), EXTRACT(MONTH FROM curdate()), EXTRACT(YEAR FROM curdate())"
        query(sql, 1)
        rs.Read()
        txtDia.Text = rs(0)
        txtMes.Text = rs(1)
        txtAño.Text = rs(2)

        txtMonto.Text = pagoFacturaCompra
        txtCantPlata.Text = pagoFacturaCompra

        sql = "SELECT MAX(idrecibocompra), MAX(codChequeC) FROM reciboscompra, chequescompra"
        query(sql, 1)
        rs.Read()
        txtNumCheque.Text = rs(1).ToString
        txtNumRec.Text = rs(0).ToString

        sql = "SELECT nomProv FROM proveedores p INNER JOIN ordenescompra oc ON oc.idproveedor = p.idproveedor INNER JOIN facturascompra fc ON fc.codOc = oc.codOc WHERE fc.idfacturacompra = '" & numeroFacturaCompra & "'"
        query(sql, 1)
        rs.Read()

        txtNom.Text = rs(0).ToString

    End Sub

End Class