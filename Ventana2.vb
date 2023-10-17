Public Class Ventana2
    Private Sub Ventana2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbResultado.Text = ""
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim total = 0
        Dim metPago = ""
        Dim conCkb = 0
        Dim conRb = 0

        If ckbNike.Checked = True Then
            total = total + 50
            conCkb += 1

        End If
        If ckbJordan.Checked = True Then
            total = total + 100
            conCkb += 1
        End If

        If rbTCredito.Checked = True Then
            metPago = "Pago con Tarjeta de Credito $"
            conRb += 1
        End If
        If rbEfectivo.Checked = True Then
            metPago = "Pago en Efectivo $"
            conRb += 1

        End If

        If conCkb > 0 And conRb > 0 Then
            lbResultado.Text = metPago & total
        Else
            lbResultado.Text = "Usuario debes seleccionar un articulo y metodo de pago"
        End If



    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim f = New Form1()
        f.show()
        Me.Hide()
    End Sub
End Class