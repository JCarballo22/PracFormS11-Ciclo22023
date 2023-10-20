Public Class progres

    Dim cont = 0
    Private Sub picbImagen_Click(sender As Object, e As EventArgs) Handles picbImagen.Click
        Cargar()

    End Sub

    Private Sub progres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbBarra.Minimum = 0
        pbBarra.Maximum = 100
        picbImagen.ImageLocation = "C:/Users/Carba/Desktop/Imagenes/LOGO.png"
    End Sub

    Private Sub picbImagen_MouseMove(sender As Object, e As MouseEventArgs) Handles picbImagen.MouseMove
        Cargar()
    End Sub

    Sub Cargar()
        If (cont < 100) Then
            cont = cont + 1
            pbBarra.Value = cont
        End If
    End Sub

End Class