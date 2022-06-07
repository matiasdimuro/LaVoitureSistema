Public Class frmVentas

    Dim flag As Integer = 0

    Dim nroFacturaVta As Integer
    Dim montoReciboVta As Decimal

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub btnPropuesta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPropuesta.Click
        Me.Close()
        frmElabPropuesta.Show()
    End Sub

    Private Sub btnVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVenta.Click

        flag = 0

        While flag = 0

            numPropuesta = Val(InputBox("Ingrese el numero de la propuesta.", "Registrar Compra", "1"))
            numPropuesta.ToString()

            If numPropuesta = vbEmpty Then
                Exit While

            ElseIf numPropuesta.ToString.Length < 11 Then

                sql = "SELECT COUNT(codPropuesta) FROM propuestas WHERE codPropuesta = '" & Val(numPropuesta) & "'"
                query(sql, 1)
                rs.Read()

                If rs(0) = 0 Then
                    MsgBox("No existe tal propuesta. Pruebe de nuevo.", MsgBoxStyle.Critical, vbOKOnly)

                Else
                    flag = 1
                    Me.Close()
                    formRegistVenta.Show()

                End If

            ElseIf numPropuesta.ToString.Length > 11 Then
                MsgBox("Ingreso de caracteres excedido. Pruebe de nuevo.", MsgBoxStyle.Critical, vbOKCancel)

            End If

        End While

    End Sub

    Private Sub btnCobro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobro.Click

        flag = 0

        While flag = 0

            nroFacturaVta = Val(InputBox("Ingrese el numero de la factura.", "Registrar Cobro", "1"))
            nroFacturaVta.ToString()

            If nroFacturaVta = vbEmpty Then
                Exit While

            ElseIf nroFacturaVta.ToString.Length < 11 Then

                sql = "SELECT COUNT(idFacturaVenta) FROM FacturasVenta WHERE idFacturaVenta = '" & Val(nroFacturaVta) & "'"
                query(sql, 1)
                rs.Read()

                If rs(0) = 0 Then
                    MsgBox("No existe tal factura. Pruebe de nuevo.", MsgBoxStyle.Critical, vbOKOnly)

                Else
                    flag = 1

                End If

            ElseIf numPropuesta.ToString.Length > 11 Then
                MsgBox("Ingreso de caracteres exedido. Pruebe de nuevo.", MsgBoxStyle.Critical, vbOKCancel)

            End If

        End While

        While flag = 1

            montoReciboVta = Val(InputBox("Ingrese el monto Recibido.", "Registrar Cobro", "250000"))
            montoReciboVta.ToString()

            If montoReciboVta = vbEmpty Then
                'MsgBox("Ingrese un monto valido.", MsgBoxStyle.Critical, vbOKOnly)
                flag = 0
                Exit While

            ElseIf montoReciboVta.ToString.Length < 11 Then

                reciboVtaMonto = montoReciboVta
                facturaVtaNum = nroFacturaVta

                flag = 2

                Me.Close()
                frmRecibo.Show()

            ElseIf numPropuesta.ToString.Length > 11 Then
                MsgBox("Ingreso de caracteres excedido. Pruebe de nuevo.", MsgBoxStyle.Critical, vbOKCancel)

            End If

        End While

    End Sub

End Class