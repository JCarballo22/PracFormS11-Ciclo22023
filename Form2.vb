Public Class Form2
    Private Sub cbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductos.SelectedIndexChanged
        picbProducto.ImageLocation = "C:/Users/Carba/Desktop/Imagenes/" & cbProductos.Text & ".png"

    End Sub

    Private Sub lbMetPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbMetPago.SelectedIndexChanged
        picbMetPago.ImageLocation = "C:/Users/Carba/Desktop/Imagenes/" & lbMetPago.Text & ".png"
    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Dim total = 0
        Dim metPago = ""
        Dim conProd = 0
        Dim conMetPago = 0

        If cbProductos.Text = "camisa" Then
            total = total + 20
            conProd = conProd + 1
        End If
        If cbProductos.Text = "zapatos" Then
            total = total + 30
            conProd = conProd + 1
        End If
        If lbMetPago.Text = "tarjeta" Then
            metPago = "Pago con Tarjeta "
            conMetPago = conMetPago + 1
        End If
        If lbMetPago.Text = "efectivo" Then
            metPago = "Pago con Tarjeta "
            conMetPago = conMetPago + 1
        End If
        If conProd > 0 And conMetPago > 0 Then
            lstResultado.Text = MetPago & total
        Else
            lstResultado.Text = "Debes seleccionar un articulo y un metodo de pago"
        End If

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub
End Class