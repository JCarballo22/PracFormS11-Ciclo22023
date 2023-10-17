Public Class Form2
    Private Sub cbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductos.SelectedIndexChanged
        picbProducto.ImageLocation = "C:/Users/Carba/Desktop/UNAB Chalatenango/Ciclo 2 - 2023/Programación II/Semana 11/Imagenes" & cbProductos.Text & ".png"

    End Sub

    Private Sub lbMetPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbMetPago.SelectedIndexChanged
        picbProducto.ImageLocation = "C:/Users/Carba/Desktop/UNAB Chalatenango/Ciclo 2 - 2023/Programación II/Semana 11/Imagenes" & lbMetPago.Text & ".png"
    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Dim total = 0
        Dim MetPago = 0
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
            MetPago = "Pago con Tarjeta "
            conMetPago = conMetPago + 1
        End If
        If lbMetPago.Text = "efectivo" Then
            MetPago = "Pago con Tarjeta "
            conMetPago = conMetPago + 1
        End If
        If conProd > 0 And conMetPago > 0 Then
            lstResultado.Text = MetPago & total
        Else
            lstResultado.Text = "Debes seleccionar un articulo y un metodo de pago"
        End If

    End Sub
End Class