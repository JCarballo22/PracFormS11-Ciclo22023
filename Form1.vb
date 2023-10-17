Public Class Form1
    Private Sub bntAceptar_Click(sender As Object, e As EventArgs) Handles bntAceptar.Click

        If txtUsuario.Text = "Manuel" And txtPass.Text = "12345" Then
            'MessageBox.Show("El Usuario es valido 'Bienvenido' ")
            'Dim v2 = New Ventana2()
            'v2.Show()
            Dim f2 = New Form2()
            f2.Show()
            Me.Hide()
        Else
            MessageBox.Show("El Usuario es Incorrecto")
            txtUsuario.Text = ""
            txtPass.Text = ""
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
