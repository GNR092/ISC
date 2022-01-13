<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arreglos
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
        Me.components = New System.ComponentModel.Container()
        Me.TapC_primario = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_length = New System.Windows.Forms.Label()
        Me.cmb_length = New System.Windows.Forms.ComboBox()
        Me.chk_numbers = New System.Windows.Forms.CheckBox()
        Me.chk_mayus = New System.Windows.Forms.CheckBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_vender = New System.Windows.Forms.Button()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.lc_cantidad = New System.Windows.Forms.Label()
        Me.gb_venta = New System.Windows.Forms.GroupBox()
        Me.txt_existencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_costo = New System.Windows.Forms.TextBox()
        Me.lb_precio = New System.Windows.Forms.Label()
        Me.lb_jugo = New System.Windows.Forms.Label()
        Me.gb_datos = New System.Windows.Forms.GroupBox()
        Me.btn_cargarData = New System.Windows.Forms.Button()
        Me.txt_cantidadjugos = New System.Windows.Forms.TextBox()
        Me.lb_ctjugos = New System.Windows.Forms.Label()
        Me.cmb_jugos = New System.Windows.Forms.ComboBox()
        Me.T_Ticks = New System.Windows.Forms.Timer(Me.components)
        Me.TapC_primario.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gb_venta.SuspendLayout()
        Me.gb_datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TapC_primario
        '
        Me.TapC_primario.Controls.Add(Me.TabPage1)
        Me.TapC_primario.Controls.Add(Me.TabPage2)
        Me.TapC_primario.Location = New System.Drawing.Point(0, 0)
        Me.TapC_primario.Name = "TapC_primario"
        Me.TapC_primario.SelectedIndex = 0
        Me.TapC_primario.Size = New System.Drawing.Size(344, 315)
        Me.TapC_primario.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(336, 289)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Unidimensional"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_length)
        Me.GroupBox1.Controls.Add(Me.cmb_length)
        Me.GroupBox1.Controls.Add(Me.chk_numbers)
        Me.GroupBox1.Controls.Add(Me.chk_mayus)
        Me.GroupBox1.Controls.Add(Me.txt_pass)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_generar)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 276)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generador de Contraseñas"
        '
        'lb_length
        '
        Me.lb_length.AutoSize = True
        Me.lb_length.Location = New System.Drawing.Point(67, 45)
        Me.lb_length.Name = "lb_length"
        Me.lb_length.Size = New System.Drawing.Size(48, 13)
        Me.lb_length.TabIndex = 8
        Me.lb_length.Text = "Longitud"
        '
        'cmb_length
        '
        Me.cmb_length.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_length.FormattingEnabled = True
        Me.cmb_length.Items.AddRange(New Object() {"8", "12", "14"})
        Me.cmb_length.Location = New System.Drawing.Point(121, 42)
        Me.cmb_length.Name = "cmb_length"
        Me.cmb_length.Size = New System.Drawing.Size(39, 21)
        Me.cmb_length.TabIndex = 7
        '
        'chk_numbers
        '
        Me.chk_numbers.AutoSize = True
        Me.chk_numbers.Location = New System.Drawing.Point(121, 97)
        Me.chk_numbers.Name = "chk_numbers"
        Me.chk_numbers.Size = New System.Drawing.Size(68, 17)
        Me.chk_numbers.TabIndex = 6
        Me.chk_numbers.Text = "Numeros"
        Me.chk_numbers.UseVisualStyleBackColor = True
        '
        'chk_mayus
        '
        Me.chk_mayus.AutoSize = True
        Me.chk_mayus.Location = New System.Drawing.Point(121, 74)
        Me.chk_mayus.Name = "chk_mayus"
        Me.chk_mayus.Size = New System.Drawing.Size(82, 17)
        Me.chk_mayus.TabIndex = 4
        Me.chk_mayus.Text = "Mayusculas"
        Me.chk_mayus.UseVisualStyleBackColor = True
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(121, 19)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.ReadOnly = True
        Me.txt_pass.Size = New System.Drawing.Size(130, 20)
        Me.txt_pass.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contraseña generada"
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(121, 130)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 0
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.gb_venta)
        Me.TabPage2.Controls.Add(Me.gb_datos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(336, 289)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bidimensional"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_vender)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad)
        Me.GroupBox2.Controls.Add(Me.lc_cantidad)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 85)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta"
        '
        'btn_vender
        '
        Me.btn_vender.AutoSize = True
        Me.btn_vender.Location = New System.Drawing.Point(203, 34)
        Me.btn_vender.Name = "btn_vender"
        Me.btn_vender.Size = New System.Drawing.Size(51, 23)
        Me.btn_vender.TabIndex = 2
        Me.btn_vender.Text = "Vender"
        Me.btn_vender.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(97, 37)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 1
        '
        'lc_cantidad
        '
        Me.lc_cantidad.AutoSize = True
        Me.lc_cantidad.Location = New System.Drawing.Point(42, 40)
        Me.lc_cantidad.Name = "lc_cantidad"
        Me.lc_cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lc_cantidad.TabIndex = 0
        Me.lc_cantidad.Text = "Cantidad"
        '
        'gb_venta
        '
        Me.gb_venta.Controls.Add(Me.cmb_jugos)
        Me.gb_venta.Controls.Add(Me.txt_existencia)
        Me.gb_venta.Controls.Add(Me.Label2)
        Me.gb_venta.Controls.Add(Me.txt_costo)
        Me.gb_venta.Controls.Add(Me.lb_precio)
        Me.gb_venta.Controls.Add(Me.lb_jugo)
        Me.gb_venta.Location = New System.Drawing.Point(8, 82)
        Me.gb_venta.Name = "gb_venta"
        Me.gb_venta.Size = New System.Drawing.Size(311, 106)
        Me.gb_venta.TabIndex = 3
        Me.gb_venta.TabStop = False
        Me.gb_venta.Text = "Busqueda"
        '
        'txt_existencia
        '
        Me.txt_existencia.Location = New System.Drawing.Point(211, 53)
        Me.txt_existencia.Name = "txt_existencia"
        Me.txt_existencia.ReadOnly = True
        Me.txt_existencia.Size = New System.Drawing.Size(39, 20)
        Me.txt_existencia.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Existencia"
        '
        'txt_costo
        '
        Me.txt_costo.Location = New System.Drawing.Point(104, 53)
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.ReadOnly = True
        Me.txt_costo.Size = New System.Drawing.Size(41, 20)
        Me.txt_costo.TabIndex = 4
        '
        'lb_precio
        '
        Me.lb_precio.AutoSize = True
        Me.lb_precio.Location = New System.Drawing.Point(61, 56)
        Me.lb_precio.Name = "lb_precio"
        Me.lb_precio.Size = New System.Drawing.Size(34, 13)
        Me.lb_precio.TabIndex = 3
        Me.lb_precio.Text = "Costo"
        '
        'lb_jugo
        '
        Me.lb_jugo.AutoSize = True
        Me.lb_jugo.Location = New System.Drawing.Point(88, 26)
        Me.lb_jugo.Name = "lb_jugo"
        Me.lb_jugo.Size = New System.Drawing.Size(35, 13)
        Me.lb_jugo.TabIndex = 0
        Me.lb_jugo.Text = "Jugos"
        '
        'gb_datos
        '
        Me.gb_datos.Controls.Add(Me.btn_cargarData)
        Me.gb_datos.Controls.Add(Me.txt_cantidadjugos)
        Me.gb_datos.Controls.Add(Me.lb_ctjugos)
        Me.gb_datos.Location = New System.Drawing.Point(13, 6)
        Me.gb_datos.Name = "gb_datos"
        Me.gb_datos.Size = New System.Drawing.Size(311, 70)
        Me.gb_datos.TabIndex = 0
        Me.gb_datos.TabStop = False
        Me.gb_datos.Text = "Datos"
        '
        'btn_cargarData
        '
        Me.btn_cargarData.Location = New System.Drawing.Point(210, 24)
        Me.btn_cargarData.Name = "btn_cargarData"
        Me.btn_cargarData.Size = New System.Drawing.Size(88, 23)
        Me.btn_cargarData.TabIndex = 2
        Me.btn_cargarData.Text = "Ingresar datos"
        Me.btn_cargarData.UseVisualStyleBackColor = True
        '
        'txt_cantidadjugos
        '
        Me.txt_cantidadjugos.Location = New System.Drawing.Point(104, 26)
        Me.txt_cantidadjugos.Name = "txt_cantidadjugos"
        Me.txt_cantidadjugos.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidadjugos.TabIndex = 1
        '
        'lb_ctjugos
        '
        Me.lb_ctjugos.AutoSize = True
        Me.lb_ctjugos.Location = New System.Drawing.Point(6, 26)
        Me.lb_ctjugos.Name = "lb_ctjugos"
        Me.lb_ctjugos.Size = New System.Drawing.Size(92, 13)
        Me.lb_ctjugos.TabIndex = 0
        Me.lb_ctjugos.Text = "Cantidad de jugos"
        '
        'cmb_jugos
        '
        Me.cmb_jugos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_jugos.FormattingEnabled = True
        Me.cmb_jugos.Location = New System.Drawing.Point(124, 23)
        Me.cmb_jugos.Name = "cmb_jugos"
        Me.cmb_jugos.Size = New System.Drawing.Size(107, 21)
        Me.cmb_jugos.TabIndex = 7
        '
        'T_Ticks
        '
        Me.T_Ticks.Interval = 500
        '
        'Arreglos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 313)
        Me.Controls.Add(Me.TapC_primario)
        Me.Name = "Arreglos"
        Me.Text = "ISC Arreglos(Arrays)"
        Me.TapC_primario.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gb_venta.ResumeLayout(False)
        Me.gb_venta.PerformLayout()
        Me.gb_datos.ResumeLayout(False)
        Me.gb_datos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TapC_primario As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_numbers As CheckBox
    Friend WithEvents chk_mayus As CheckBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_generar As Button
    Friend WithEvents lb_length As Label
    Friend WithEvents cmb_length As ComboBox
    Friend WithEvents gb_venta As GroupBox
    Friend WithEvents lb_jugo As Label
    Friend WithEvents gb_datos As GroupBox
    Friend WithEvents btn_cargarData As Button
    Friend WithEvents txt_cantidadjugos As TextBox
    Friend WithEvents lb_ctjugos As Label
    Friend WithEvents txt_costo As TextBox
    Friend WithEvents lb_precio As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_vender As Button
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents lc_cantidad As Label
    Friend WithEvents txt_existencia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_jugos As ComboBox
    Friend WithEvents T_Ticks As Timer
End Class
