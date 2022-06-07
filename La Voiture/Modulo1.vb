Imports System.Data.Odbc

Module Modulo1

    'Ventas
    Public numPropuesta As Integer
    Public reciboVtaMonto As Decimal
    Public facturaVtaNum As Decimal

    'Compras
    Public numeroFacturaCompra As Integer
    Public pagoFacturaCompra As Decimal

    'Base de Datos
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public rsDeuda As OdbcDataReader

    Public sql As String

    Public Function connectdb()
        Try
            cnn = New OdbcConnection("DSN=lavoiture")
            cnn.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
            frmHome.btnVentas.Enabled = False
            frmHome.btnCompras.Enabled = False
            frmHome.btnDeudas.Enabled = False
            frmHome.btnStock.Enabled = False

        End Try

        Return 0

    End Function

    Public Sub query(ByVal sql As String, ByVal flag As Integer) ' 1 -> General 2 -> Deudas

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text

        Select Case flag
            Case 1
                rs = cmd.ExecuteReader
            Case 2
                rsDeuda = cmd.ExecuteReader

        End Select

        cmd.Dispose()

    End Sub

End Module
