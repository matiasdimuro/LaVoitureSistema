Public Class frmElabPropuesta

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmVentas.Show()
    End Sub

    Private Sub txtCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCliente.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDni.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtColor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        Dim clienid As Integer
        Dim vehid As Integer
        Dim existePatente As Integer

        sql = "SELECT COUNT(*) FROM vehiculos WHERE patente = '" & txtPatente.Text & "'"
        query(sql, 1)
        rs.Read()
        existePatente = rs(0)

        If existePatente = 0 Then

            MsgBox("No existe un auto con esa patente, ingrese de nuevo.", MsgBoxStyle.Critical, vbOKOnly)

        Else

            'EXISTE EL CLIENTE?
            sql = "SELECT COUNT(idCliente) FROM clientes WHERE dni = '" & txtDni.Text & "'"
            query(sql, 1)
            rs.Read()

            If rs(0) = 0 Then 'NO -> DEBO REGISTRARLO

                sql = "INSERT INTO clientes VALUES ('', '" & txtCliente.Text & "', '" & txtTelefono.Text & "', '" & txtMail.Text & "', '" & txtDom.Text & "', '" & txtDni.Text & "')"
                query(sql, 1)

            Else 'SI -> ACTUALIZO SUS DATOS POR SI HA CAMBIADO ALGUNO

                sql = "UPDATE clientes SET nomyape = '" & txtCliente.Text & "', tel = '" & txtTelefono.Text & "', mail = '" & txtMail.Text & "', dom = '" & txtDom.Text & "' WHERE dni = '" & txtDni.Text & "'"
                query(sql, 1)

            End If

            'REGISTRO LA PROPUESTA

            sql = "SELECT idvehiculo FROM vehiculos WHERE patente = '" & txtPatente.Text & "'"
            query(sql, 1)
            rs.Read()
            vehid = rs(0)

            sql = "SELECT idcliente FROM clientes WHERE dni = '" & txtDni.Text & "'"
            query(sql, 1)
            rs.Read()
            clienid = rs(0)

            sql = "INSERT INTO propuestas VALUES ('', '" & txtMedioPago.Text & "', '" & vehid & "', '" & clienid & "', '" & txtMonto.Text & "')"
            query(sql, 1)

            sql = "SELECT MAX(codPropuesta) FROM propuestas"
            query(sql, 1)
            rs.Read()
            numPropuesta = rs(0)

            MsgBox("Propuesta Nro. '" & numPropuesta & "' Registrada Con Exito", MsgBoxStyle.Information)

            Me.Close()
            formImprimirPropuesta.Show()

        End If


    End Sub
End Class