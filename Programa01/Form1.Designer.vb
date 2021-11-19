<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txt_campo1 = New System.Windows.Forms.TextBox()
        Me.txt_campo2 = New System.Windows.Forms.TextBox()
        Me.lb_campo1 = New System.Windows.Forms.Label()
        Me.btn_Calcular = New System.Windows.Forms.Button()
        Me.cmb_operation = New System.Windows.Forms.ComboBox()
        Me.lb_campo2 = New System.Windows.Forms.Label()
        Me.lb_operacion = New System.Windows.Forms.Label()
        Me.lb_igual = New System.Windows.Forms.Label()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.lb_resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_campo1
        '
        Me.txt_campo1.Location = New System.Drawing.Point(10, 39)
        Me.txt_campo1.Name = "txt_campo1"
        Me.txt_campo1.Size = New System.Drawing.Size(70, 20)
        Me.txt_campo1.TabIndex = 0
        '
        'txt_campo2
        '
        Me.txt_campo2.Location = New System.Drawing.Point(135, 38)
        Me.txt_campo2.Name = "txt_campo2"
        Me.txt_campo2.Size = New System.Drawing.Size(70, 20)
        Me.txt_campo2.TabIndex = 1
        '
        'lb_campo1
        '
        Me.lb_campo1.AutoSize = True
        Me.lb_campo1.Location = New System.Drawing.Point(16, 22)
        Me.lb_campo1.Name = "lb_campo1"
        Me.lb_campo1.Size = New System.Drawing.Size(49, 13)
        Me.lb_campo1.TabIndex = 2
        Me.lb_campo1.Text = "Campo 1"
        '
        'btn_Calcular
        '
        Me.btn_Calcular.Location = New System.Drawing.Point(107, 86)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_Calcular.TabIndex = 3
        Me.btn_Calcular.Text = "Calcular"
        Me.btn_Calcular.UseVisualStyleBackColor = True
        '
        'cmb_operation
        '
        Me.cmb_operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_operation.FormattingEnabled = True
        Me.cmb_operation.Items.AddRange(New Object() {"+", "-", "x", "÷"})
        Me.cmb_operation.Location = New System.Drawing.Point(89, 38)
        Me.cmb_operation.Name = "cmb_operation"
        Me.cmb_operation.Size = New System.Drawing.Size(35, 21)
        Me.cmb_operation.TabIndex = 4
        '
        'lb_campo2
        '
        Me.lb_campo2.AutoSize = True
        Me.lb_campo2.Location = New System.Drawing.Point(144, 22)
        Me.lb_campo2.Name = "lb_campo2"
        Me.lb_campo2.Size = New System.Drawing.Size(49, 13)
        Me.lb_campo2.TabIndex = 5
        Me.lb_campo2.Text = "Campo 2"
        '
        'lb_operacion
        '
        Me.lb_operacion.AutoSize = True
        Me.lb_operacion.Location = New System.Drawing.Point(77, 22)
        Me.lb_operacion.Name = "lb_operacion"
        Me.lb_operacion.Size = New System.Drawing.Size(56, 13)
        Me.lb_operacion.TabIndex = 6
        Me.lb_operacion.Text = "Operacion"
        '
        'lb_igual
        '
        Me.lb_igual.AutoSize = True
        Me.lb_igual.Location = New System.Drawing.Point(206, 42)
        Me.lb_igual.Name = "lb_igual"
        Me.lb_igual.Size = New System.Drawing.Size(13, 13)
        Me.lb_igual.TabIndex = 7
        Me.lb_igual.Text = "="
        '
        'txt_result
        '
        Me.txt_result.Location = New System.Drawing.Point(221, 37)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.ReadOnly = True
        Me.txt_result.Size = New System.Drawing.Size(70, 20)
        Me.txt_result.TabIndex = 8
        '
        'lb_resultado
        '
        Me.lb_resultado.AutoSize = True
        Me.lb_resultado.Location = New System.Drawing.Point(229, 21)
        Me.lb_resultado.Name = "lb_resultado"
        Me.lb_resultado.Size = New System.Drawing.Size(55, 13)
        Me.lb_resultado.TabIndex = 9
        Me.lb_resultado.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 173)
        Me.Controls.Add(Me.lb_resultado)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.lb_igual)
        Me.Controls.Add(Me.lb_operacion)
        Me.Controls.Add(Me.lb_campo2)
        Me.Controls.Add(Me.cmb_operation)
        Me.Controls.Add(Me.btn_Calcular)
        Me.Controls.Add(Me.lb_campo1)
        Me.Controls.Add(Me.txt_campo2)
        Me.Controls.Add(Me.txt_campo1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programa01 Operaciones basicas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_campo1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_campo2 As System.Windows.Forms.TextBox
    Friend WithEvents lb_campo1 As System.Windows.Forms.Label
    Friend WithEvents btn_Calcular As System.Windows.Forms.Button
    Friend WithEvents cmb_operation As System.Windows.Forms.ComboBox
    Friend WithEvents lb_campo2 As System.Windows.Forms.Label
    Friend WithEvents lb_operacion As System.Windows.Forms.Label
    Friend WithEvents lb_igual As System.Windows.Forms.Label
    Friend WithEvents txt_result As System.Windows.Forms.TextBox
    Friend WithEvents lb_resultado As System.Windows.Forms.Label

End Class
