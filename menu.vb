Public Class menu
    Private Sub MenuTop_ItemClicked_1(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuTop.ItemClicked
        ''MessageBox.Show(e.ClickedItem.Text)
        If e.ClickedItem.Text = "Nuevo" Then
            Dim v2 = New Ventana2()
            v2.MdiParent = Me
            v2.Show()
        ElseIf e.ClickedItem.Text = "Abrir" Then
            Dim f2 = New Form2()
            f2.MdiParent = Me
            f2.Show()
        ElseIf e.ClickedItem.Text = "Salir" Then
            Me.Close()
        End If

    End Sub


End Class