Public Class frmDeudas

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub btnRevisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevisar.Click

        Dim hayDeudas As Integer = 0
        Dim nomClien As String

        rtxtDeudas.Clear()

        If String.IsNullOrWhiteSpace(txtDniClien.Text) = True Then

            sql = "SELECT c.nomyape, c.tel, fv.idFacturaVenta, mp.cuotas, fv.monto, SUM(rv.monto) FROM clientes c INNER JOIN propuestas p ON p.idcliente = c.idcliente INNER JOIN facturasventa fv ON fv.codpropuesta = p.codpropuesta INNER JOIN recibosventa rv ON rv.idfacturaventa = fv.idfacturaventa INNER JOIN mediospago mp ON mp.idmediopago = fv.idmediopago GROUP BY fv.idfacturaventa"
            query(sql, 1)

            While rs.Read = True
                sql = "SELECT COUNT(idreciboVenta) - (SELECT cuotas FROM mediospago mp INNER JOIN facturasventa fv ON fv.idmediopago = mp.idmediopago WHERE fv.idfacturaventa = '" & rs(2) & "') FROM recibosventa rv INNER JOIN facturasventa fv ON fv.idfacturaventa = rv.idfacturaventa WHERE fv.idfacturaventa = '" & rs(2) & "' GROUP BY fv.idFacturaVenta"
                query(sql, 2)
                rsDeuda.Read()

                If rsDeuda(0) < 0 Then
                    rtxtDeudas.Text += rs(0) & " (tel " & rs(1) & ") debe " & rsDeuda(0) * (-1) & " pagos de la factura N° " & rs(2) & " ( " & rs(4) - rs(5) & " pesos)" & vbCrLf
                End If

            End While

        Else

            sql = "SELECT COUNT(idcliente) FROM clientes WHERE dni = '" & txtDniClien.Text & "'"
            query(sql, 1)
            rs.Read()

            If rs(0) = 0 Then
                rtxtDeudas.Text = "No existe tal cliente. Pruebe con otro DNI."

            Else

                sql = "SELECT c.nomyape, c.tel, fv.idFacturaVenta, mp.cuotas, fv.monto, SUM(rv.monto) FROM clientes c INNER JOIN propuestas p ON p.idcliente = c.idcliente INNER JOIN facturasventa fv ON fv.codpropuesta = p.codpropuesta INNER JOIN recibosventa rv ON rv.idfacturaventa = fv.idfacturaventa INNER JOIN mediospago mp ON mp.idmediopago = fv.idmediopago WHERE c.dni = '" & txtDniClien.Text & "' GROUP BY fv.idfacturaventa"
                query(sql, 1)

                While rs.Read = True
                    sql = "SELECT COUNT(idreciboVenta) - (SELECT cuotas FROM mediospago mp INNER JOIN facturasventa fv ON fv.idmediopago = mp.idmediopago WHERE fv.idfacturaventa = '" & rs(2) & "') FROM recibosventa rv INNER JOIN facturasventa fv ON fv.idfacturaventa = rv.idfacturaventa WHERE fv.idfacturaventa = '" & rs(2) & "' GROUP BY fv.idFacturaVenta"
                    query(sql, 2)
                    rsDeuda.Read()

                    If rsDeuda(0) < 0 Then
                        rtxtDeudas.Text += rs(0) & " (tel " & rs(1) & ") debe " & rsDeuda(0) * (-1) & " pagos de la factura N° " & rs(2) & " ( " & rs(4) - rs(5) & " pesos)" & vbCrLf
                        hayDeudas = 1

                    End If

                    nomClien = rs(0)

                End While

                If hayDeudas = 0 Then
                    rtxtDeudas.Text = "El cliente '" & nomClien & "' no adeuda pagos."
                End If

            End If

        End If

    End Sub

End Class