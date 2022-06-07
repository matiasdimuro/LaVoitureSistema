Public Class frmStock

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub btnRevisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevisar.Click

        rtxtStock.Clear()

        If String.IsNullOrWhiteSpace(txtModeloAuto.Text) = True Then

            sql = "SELECT idvehiculo, modelo, color, patente, costo FROM vehiculos WHERE disponible = TRUE ORDER BY modelo"
            query(sql, 1)

            While rs.Read = True
                rtxtStock.Text += rs(1) & " " & rs(2) & " " & rs(3) & " " & rs(4) & vbCr
            End While

        Else

            sql = "SELECT COUNT(*) FROM vehiculos WHERE modelo = '" & txtModeloAuto.Text & "'"
            query(sql, 1)
            rs.Read()

            If rs(0) > 0 Then

                sql = "SELECT idvehiculo, modelo, color, patente, costo FROM vehiculos WHERE disponible = TRUE AND modelo = '" & txtModeloAuto.Text & "'"
                query(sql, 1)

                While rs.Read = True
                    rtxtStock.Text += rs(1) & " " & rs(2) & " " & rs(3) & " " & rs(4) & vbCr
                End While

            Else

                rtxtStock.Text = "No hay vehículos con el modelo solicitado."

            End If

        End If

    End Sub
End Class