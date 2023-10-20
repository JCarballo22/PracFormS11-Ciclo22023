<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class progres
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picbImagen = New System.Windows.Forms.PictureBox()
        Me.pbBarra = New System.Windows.Forms.ProgressBar()
        CType(Me.picbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picbImagen
        '
        Me.picbImagen.Location = New System.Drawing.Point(316, 107)
        Me.picbImagen.Name = "picbImagen"
        Me.picbImagen.Size = New System.Drawing.Size(169, 175)
        Me.picbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbImagen.TabIndex = 0
        Me.picbImagen.TabStop = False
        '
        'pbBarra
        '
        Me.pbBarra.Location = New System.Drawing.Point(229, 346)
        Me.pbBarra.Name = "pbBarra"
        Me.pbBarra.Size = New System.Drawing.Size(341, 23)
        Me.pbBarra.TabIndex = 1
        '
        'progres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbBarra)
        Me.Controls.Add(Me.picbImagen)
        Me.Name = "progres"
        Me.Text = "progres"
        CType(Me.picbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picbImagen As PictureBox
    Friend WithEvents pbBarra As ProgressBar
End Class
