<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioDivisas
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
        Dim lb_cambio As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambioDivisas))
        Me.btn_convert = New System.Windows.Forms.Button()
        Me.lb_uni = New System.Windows.Forms.Label()
        Me.txt_moneda = New System.Windows.Forms.TextBox()
        Me.txt_pesoMXN = New System.Windows.Forms.TextBox()
        Me.cmb_tipodecambio = New System.Windows.Forms.ComboBox()
        Me.lb_mxn = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        lb_cambio = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_convert
        '
        Me.btn_convert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_convert.Location = New System.Drawing.Point(104, 112)
        Me.btn_convert.Name = "btn_convert"
        Me.btn_convert.Size = New System.Drawing.Size(75, 23)
        Me.btn_convert.TabIndex = 5
        Me.btn_convert.Text = "Convertir"
        Me.btn_convert.UseVisualStyleBackColor = True
        '
        'lb_uni
        '
        Me.lb_uni.BackColor = System.Drawing.SystemColors.Control
        Me.lb_uni.Font = New System.Drawing.Font("Consolas", 25.0!)
        Me.lb_uni.ForeColor = System.Drawing.Color.Black
        Me.lb_uni.Location = New System.Drawing.Point(75, 51)
        Me.lb_uni.Name = "lb_uni"
        Me.lb_uni.Size = New System.Drawing.Size(27, 34)
        Me.lb_uni.TabIndex = 5
        Me.lb_uni.Text = "↓ "
        '
        'txt_moneda
        '
        Me.txt_moneda.Location = New System.Drawing.Point(43, 31)
        Me.txt_moneda.Name = "txt_moneda"
        Me.txt_moneda.Size = New System.Drawing.Size(100, 20)
        Me.txt_moneda.TabIndex = 3
        '
        'txt_pesoMXN
        '
        Me.txt_pesoMXN.Location = New System.Drawing.Point(43, 88)
        Me.txt_pesoMXN.Name = "txt_pesoMXN"
        Me.txt_pesoMXN.ReadOnly = True
        Me.txt_pesoMXN.Size = New System.Drawing.Size(100, 20)
        Me.txt_pesoMXN.TabIndex = 0
        '
        'lb_cambio
        '
        lb_cambio.AutoSize = True
        lb_cambio.BackColor = System.Drawing.Color.Transparent
        lb_cambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lb_cambio.ForeColor = System.Drawing.Color.Black
        lb_cambio.Location = New System.Drawing.Point(146, 12)
        lb_cambio.Name = "lb_cambio"
        lb_cambio.Size = New System.Drawing.Size(94, 13)
        lb_cambio.TabIndex = 2
        lb_cambio.Text = "Tipo de cambio"
        '
        'cmb_tipodecambio
        '
        Me.cmb_tipodecambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipodecambio.FormattingEnabled = True
        Me.cmb_tipodecambio.Items.AddRange(New Object() {"Euro (EUR)", "Dolar (USD)", "Yen (YEN)", "Dirham (AED)", "Yuan (CNY)", "Rublo (RUB)"})
        Me.cmb_tipodecambio.Location = New System.Drawing.Point(149, 30)
        Me.cmb_tipodecambio.Name = "cmb_tipodecambio"
        Me.cmb_tipodecambio.Size = New System.Drawing.Size(85, 21)
        Me.cmb_tipodecambio.TabIndex = 4
        '
        'lb_mxn
        '
        Me.lb_mxn.AutoSize = True
        Me.lb_mxn.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mxn.Location = New System.Drawing.Point(149, 90)
        Me.lb_mxn.Name = "lb_mxn"
        Me.lb_mxn.Size = New System.Drawing.Size(140, 15)
        Me.lb_mxn.TabIndex = 6
        Me.lb_mxn.Text = "Peso Mexicano (MXN)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lb_uni)
        Me.GroupBox1.Controls.Add(Me.lb_mxn)
        Me.GroupBox1.Controls.Add(Me.btn_convert)
        Me.GroupBox1.Controls.Add(Me.cmb_tipodecambio)
        Me.GroupBox1.Controls.Add(Me.txt_moneda)
        Me.GroupBox1.Controls.Add(lb_cambio)
        Me.GroupBox1.Controls.Add(Me.txt_pesoMXN)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 212)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(317, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AboutToolStripMenuItem.Text = "Acerca de"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ProgramaDespliegue.My.Resources.Resources.images
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(44, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'CambioDivisas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 244)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "CambioDivisas"
        Me.Text = "Cambio de divisas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_convert As System.Windows.Forms.Button
    Friend WithEvents lb_uni As System.Windows.Forms.Label
    Friend WithEvents txt_moneda As System.Windows.Forms.TextBox
    Friend WithEvents txt_pesoMXN As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipodecambio As System.Windows.Forms.ComboBox
    Friend WithEvents lb_mxn As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
