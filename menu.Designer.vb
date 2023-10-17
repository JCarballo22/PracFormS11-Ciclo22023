<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuTop = New System.Windows.Forms.MenuStrip()
        Me.Nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Abrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuTop
        '
        Me.MenuTop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.Abrir, Me.Salir})
        Me.MenuTop.Location = New System.Drawing.Point(0, 0)
        Me.MenuTop.Name = "MenuTop"
        Me.MenuTop.Size = New System.Drawing.Size(915, 24)
        Me.MenuTop.TabIndex = 1
        Me.MenuTop.Text = "Menu"
        '
        'Nuevo
        '
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(54, 20)
        Me.Nuevo.Text = "Nuevo"
        '
        'Abrir
        '
        Me.Abrir.Name = "Abrir"
        Me.Abrir.Size = New System.Drawing.Size(45, 20)
        Me.Abrir.Text = "Abrir"
        '
        'Salir
        '
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(41, 20)
        Me.Salir.Text = "Salir"
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 625)
        Me.Controls.Add(Me.MenuTop)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuTop
        Me.Name = "menu"
        Me.Text = "menu"
        Me.MenuTop.ResumeLayout(False)
        Me.MenuTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuTop As MenuStrip
    Friend WithEvents Nuevo As ToolStripMenuItem
    Friend WithEvents Abrir As ToolStripMenuItem
    Friend WithEvents Salir As ToolStripMenuItem
End Class
