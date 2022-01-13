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
        Me.txt_edad = New System.Windows.Forms.TextBox()
        Me.btn_comprobar = New System.Windows.Forms.Button()
        Me.lb_edad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_edad
        '
        Me.txt_edad.Location = New System.Drawing.Point(98, 60)
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.Size = New System.Drawing.Size(101, 20)
        Me.txt_edad.TabIndex = 0
        '
        'btn_comprobar
        '
        Me.btn_comprobar.Location = New System.Drawing.Point(204, 58)
        Me.btn_comprobar.Name = "btn_comprobar"
        Me.btn_comprobar.Size = New System.Drawing.Size(75, 23)
        Me.btn_comprobar.TabIndex = 1
        Me.btn_comprobar.Text = "Comprobar"
        Me.btn_comprobar.UseVisualStyleBackColor = True
        '
        'lb_edad
        '
        Me.lb_edad.AutoSize = True
        Me.lb_edad.Location = New System.Drawing.Point(8, 65)
        Me.lb_edad.Name = "lb_edad"
        Me.lb_edad.Size = New System.Drawing.Size(86, 13)
        Me.lb_edad.TabIndex = 2
        Me.lb_edad.Text = "Ingrese su edad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Con este programa se verificara a que vacuna es candidato"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_comprobar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_edad)
        Me.GroupBox1.Controls.Add(Me.lb_edad)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 164)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 189)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Vacunacion COVID19"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_edad As System.Windows.Forms.TextBox
    Friend WithEvents btn_comprobar As System.Windows.Forms.Button
    Friend WithEvents lb_edad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
