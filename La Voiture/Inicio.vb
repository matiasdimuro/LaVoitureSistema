Public Class frmHome

    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connectdb()
    End Sub

    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click
        Me.Hide()
        frmStock.Show()
    End Sub

    Private Sub btnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVentas.Click
        Me.Hide()
        frmVentas.Show()
    End Sub

    Private Sub btnDeudas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeudas.Click
        Me.Hide()
        frmDeudas.Show()
    End Sub

    Private Sub btnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompras.Click
        Me.Hide()
        frmCompras.Show()
    End Sub
End Class
