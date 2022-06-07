Public Class frmCompras

    Private Sub btnGenerarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarOrden.Click
        Me.Close()
        frmOrdenCompra.Show()
    End Sub

    Private Sub btnRegistCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistCompra.Click
        Me.Close()
        frmRegistCompra.Show()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub btnPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPago.Click

        Dim flag As Integer
        Dim numFact As Integer
        Dim montoPagado As Decimal
        flag = 0

        'PREGUNTO FACTURA
        While flag = 0

            numFact = Val(InputBox("Ingrese el numero de la factura.", "Registrar Pago", "1"))

            If numFact = "0" Then
                Exit While

            ElseIf numFact.ToString.Length < 11 Then

                sql = "SELECT COUNT(idfacturacompra) FROM facturascompra WHERE idfacturacompra = '" & Val(numFact) & "'"
                query(sql, 1)
                rs.Read()

                If rs(0) = 0 Then
                    MsgBox("No existe tal factura. Pruebe de nuevo.", MsgBoxStyle.Critical, vbOKOnly)

                Else
                    flag = 1

                End If

            ElseIf numFact.ToString.Length > 11 Then
                MsgBox("Ingreso de caracteres excedido. Pruebe de nuevo.", MsgBoxStyle.Critical, vbOKCancel)

            End If

        End While

        'PREGUNTO EL MONTO
        While flag = 1

            montoPagado = Val(InputBox("Ingrese el monto pagado.", "Registrar Pago", "250000"))

            If (String.IsNullOrWhiteSpace(montoPagado.ToString) = True) Or (montoPagado = 0) Then
                'MsgBox("Ingrese un monto valido.", MsgBoxStyle.Critical, vbOKOnly)
                flag = 0
                Exit While

            ElseIf montoPagado.ToString.Length < 11 Then

                numeroFacturaCompra = Val(numFact)
                pagoFacturaCompra = montoPagado

                'REGISTRO PAGO (RECIBO COMPRA)
                sql = "INSERT INTO reciboscompra VALUES ('', curdate(), '" & pagoFacturaCompra & "', '" & numeroFacturaCompra & "')"
                query(sql, 1)

                sql = "SELECT medio FROM MediosPago mp INNER JOIN facturascompra fc ON fc.idmediopago = mp.idmediopago WHERE fc.idfacturacompra = '" & numeroFacturaCompra & "' "
                query(sql, 1)
                rs.Read()

                If rs(0) = "Cheque" Then

                    sql = "INSERT INTO chequescompra VALUES ('', CURDATE(), DATE_ADD(CURDATE(), INTERVAL 30 DAY), '" & pagoFacturaCompra & "', (SELECT MAX(idReciboCompra) FROM reciboscompra))"
                    query(sql, 1)
                    Me.Close()
                    frmChequePago.Show()

                End If

                flag = 2

            ElseIf montoPagado.ToString.Length > 11 Then
                MsgBox("Ingreso de caracteres excedido. Pruebe de nuevo.", MsgBoxStyle.Critical, vbOKCancel)

            End If

        End While

        


    End Sub

End Class