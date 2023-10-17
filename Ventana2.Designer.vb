<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana2
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
        Me.ckbNike = New System.Windows.Forms.CheckBox()
        Me.ckbJordan = New System.Windows.Forms.CheckBox()
        Me.rbTCredito = New System.Windows.Forms.RadioButton()
        Me.rbEfectivo = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbResultado = New System.Windows.Forms.Label()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ckbNike
        '
        Me.ckbNike.AutoSize = True
        Me.ckbNike.Location = New System.Drawing.Point(59, 96)
        Me.ckbNike.Name = "ckbNike"
        Me.ckbNike.Size = New System.Drawing.Size(69, 17)
        Me.ckbNike.TabIndex = 0
        Me.ckbNike.Text = "Nike $50"
        Me.ckbNike.UseVisualStyleBackColor = True
        '
        'ckbJordan
        '
        Me.ckbJordan.AutoSize = True
        Me.ckbJordan.Location = New System.Drawing.Point(59, 133)
        Me.ckbJordan.Name = "ckbJordan"
        Me.ckbJordan.Size = New System.Drawing.Size(85, 17)
        Me.ckbJordan.TabIndex = 1
        Me.ckbJordan.Text = "Jordan $100"
        Me.ckbJordan.UseVisualStyleBackColor = True
        '
        'rbTCredito
        '
        Me.rbTCredito.AutoSize = True
        Me.rbTCredito.Location = New System.Drawing.Point(283, 96)
        Me.rbTCredito.Name = "rbTCredito"
        Me.rbTCredito.Size = New System.Drawing.Size(109, 17)
        Me.rbTCredito.TabIndex = 2
        Me.rbTCredito.TabStop = True
        Me.rbTCredito.Text = "Tarjeta de Credito"
        Me.rbTCredito.UseVisualStyleBackColor = True
        '
        'rbEfectivo
        '
        Me.rbEfectivo.AutoSize = True
        Me.rbEfectivo.Location = New System.Drawing.Point(283, 133)
        Me.rbEfectivo.Name = "rbEfectivo"
        Me.rbEfectivo.Size = New System.Drawing.Size(80, 17)
        Me.rbEfectivo.TabIndex = 3
        Me.rbEfectivo.TabStop = True
        Me.rbEfectivo.Text = "En Efectivo"
        Me.rbEfectivo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Selecciones un tipo de Zapatos"
        '
        'lbResultado
        '
        Me.lbResultado.AutoSize = True
        Me.lbResultado.Location = New System.Drawing.Point(56, 236)
        Me.lbResultado.Name = "lbResultado"
        Me.lbResultado.Size = New System.Drawing.Size(55, 13)
        Me.lbResultado.TabIndex = 5
        Me.lbResultado.Text = "Resultado"
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(81, 191)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(75, 23)
        Me.btnPagar.TabIndex = 6
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(255, 191)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 7
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Ventana2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 347)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.lbResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbEfectivo)
        Me.Controls.Add(Me.rbTCredito)
        Me.Controls.Add(Me.ckbJordan)
        Me.Controls.Add(Me.ckbNike)
        Me.Name = "Ventana2"
        Me.Text = "Ventana2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ckbNike As CheckBox
    Friend WithEvents ckbJordan As CheckBox
    Friend WithEvents rbTCredito As RadioButton
    Friend WithEvents rbEfectivo As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lbResultado As Label
    Friend WithEvents btnPagar As Button
    Friend WithEvents btnRegresar As Button
End Class
