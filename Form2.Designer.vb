<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cbProductos = New System.Windows.Forms.ComboBox()
        Me.lbMetPago = New System.Windows.Forms.ListBox()
        Me.picbProducto = New System.Windows.Forms.PictureBox()
        Me.picbMetPago = New System.Windows.Forms.PictureBox()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.lstResultado = New System.Windows.Forms.Label()
        CType(Me.picbProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbMetPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProductos
        '
        Me.cbProductos.FormattingEnabled = True
        Me.cbProductos.Items.AddRange(New Object() {"camisa", "zapatos"})
        Me.cbProductos.Location = New System.Drawing.Point(112, 77)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(142, 21)
        Me.cbProductos.TabIndex = 0
        '
        'lbMetPago
        '
        Me.lbMetPago.FormattingEnabled = True
        Me.lbMetPago.Items.AddRange(New Object() {"tarjeta", "efectivo"})
        Me.lbMetPago.Location = New System.Drawing.Point(325, 77)
        Me.lbMetPago.Name = "lbMetPago"
        Me.lbMetPago.Size = New System.Drawing.Size(120, 56)
        Me.lbMetPago.TabIndex = 1
        '
        'picbProducto
        '
        Me.picbProducto.Location = New System.Drawing.Point(112, 156)
        Me.picbProducto.Name = "picbProducto"
        Me.picbProducto.Size = New System.Drawing.Size(121, 116)
        Me.picbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbProducto.TabIndex = 2
        Me.picbProducto.TabStop = False
        '
        'picbMetPago
        '
        Me.picbMetPago.Location = New System.Drawing.Point(325, 156)
        Me.picbMetPago.Name = "picbMetPago"
        Me.picbMetPago.Size = New System.Drawing.Size(120, 116)
        Me.picbMetPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbMetPago.TabIndex = 3
        Me.picbMetPago.TabStop = False
        '
        'btnPago
        '
        Me.btnPago.Location = New System.Drawing.Point(112, 304)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(75, 23)
        Me.btnPago.TabIndex = 4
        Me.btnPago.Text = "Pago"
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(325, 304)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 5
        Me.btnRegresar.Text = "Cerrar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'lstResultado
        '
        Me.lstResultado.AutoSize = True
        Me.lstResultado.Location = New System.Drawing.Point(112, 362)
        Me.lstResultado.Name = "lstResultado"
        Me.lstResultado.Size = New System.Drawing.Size(57, 13)
        Me.lstResultado.TabIndex = 6
        Me.lstResultado.Text = "lResultado"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 408)
        Me.Controls.Add(Me.lstResultado)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnPago)
        Me.Controls.Add(Me.picbMetPago)
        Me.Controls.Add(Me.picbProducto)
        Me.Controls.Add(Me.lbMetPago)
        Me.Controls.Add(Me.cbProductos)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.picbProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbMetPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbProductos As ComboBox
    Friend WithEvents lbMetPago As ListBox
    Friend WithEvents picbProducto As PictureBox
    Friend WithEvents picbMetPago As PictureBox
    Friend WithEvents btnPago As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents lstResultado As Label
End Class
