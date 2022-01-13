''' <summary>
''' Taller de programación
''' ISC 1-A
''' Integrantes
''' Can Dzul Gener de Jesús 
''' Can Dzul Lesli Guadalupe 
''' Ku Canche Armando Eliomar 
''' Ku Pool Karla Pamela
''' </summary>
Public Class Arreglos
#Region "Generador de Contraseña Arreglos unidimensionales"
    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        'se declaran la variables
        Dim minusculas(), mayusculas(), numeros(), nuevoarreglo(), password As String
        'se le asignan valores
        minusculas = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", " v", "w", "x", "y", "z"}
        mayusculas = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        numeros = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}

        'se comprueba que este seleccionado la longitud en el combobox
        If String.IsNullOrEmpty(cmb_length.Text) Then
            MessageBox.Show("Seleccione la longitud", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'Se validan los checks y se crea un nuevo arreglo retornando la nueva contraseña
        If chk_mayus.Checked And Not (chk_numbers.Checked) Then
            password = ""
            nuevoarreglo = CopiarArrelos(minusculas, mayusculas)
            For index = 0 To CInt(cmb_length.Text) - 1
                password += nuevoarreglo(Int(Rnd() * nuevoarreglo.Length)).Trim()
            Next
            txt_pass.Text = password
        ElseIf chk_numbers.Checked And Not (chk_mayus.Checked) Then
            password = ""
            nuevoarreglo = CopiarArrelos(minusculas, numeros)
            For index = 0 To CInt(cmb_length.Text) - 1
                password += nuevoarreglo(Int(Rnd() * nuevoarreglo.Length)).Trim()
            Next
            txt_pass.Text = password

        ElseIf chk_mayus.Checked And chk_numbers.Checked Then
            password = ""
            nuevoarreglo = CopiarArrelos(minusculas, mayusculas)
            nuevoarreglo = CopiarArrelos(nuevoarreglo, numeros)
            For index = 0 To CInt(cmb_length.Text) - 1
                password += nuevoarreglo(Int(Rnd() * nuevoarreglo.Length)).Trim()
            Next
            txt_pass.Text = password
        Else
            password = ""
            For index = 0 To CInt(cmb_length.Text) - 1
                password += minusculas(Int(Rnd() * minusculas.Length)).Trim()
            Next
            txt_pass.Text = password
        End If
    End Sub
    ''' <summary>
    ''' Se unifican en un solo arreglo
    ''' </summary>
    ''' <param name="arreglo1">primer arreglo tipo string</param>
    ''' <param name="arreglo2">segundo arreglo tipo string</param>
    ''' <returns>Regresa el arreglo unificado</returns>
    Private Function CopiarArrelos(arreglo1() As String, arreglo2() As String)

        Dim aux(arreglo1.Length + arreglo2.Length - 1) As String

        For i = 0 To arreglo1.Length - 1
            aux(i) = arreglo1(i)
        Next

        For j = 0 To arreglo2.Length - 1
            aux(j + arreglo1.Length) = arreglo2(j)
        Next

        Return aux
    End Function

    Private Sub Arreglos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_vender.Enabled = False
        txt_costo.Enabled = False
        txt_existencia.Enabled = False
    End Sub
#End Region
#Region "Bidireccional"
    'Variables
    Private AJugos(,) As String
    Private CJugos As Integer
    Private index As Integer
    Private flag As Integer

    Private Sub btn_cargarData_Click(sender As Object, e As EventArgs) Handles btn_cargarData.Click
        'Comprobando que tenga los campos validos
        If String.IsNullOrEmpty(txt_cantidadjugos.Text) Then
            MessageBox.Show("Ingrese una cantidad", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If Val(txt_cantidadjugos.Text) <= 0 Then
            MessageBox.Show("Favor de ingresar una catidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        'Entrada de Datos
        CJugos = Val(txt_cantidadjugos.Text)
        'Inicializar ahora el arreglo
        ReDim Preserve AJugos(CJugos, 3)
        'Ingresar datos a nuestro arreglo
        For i As Integer = 0 To CJugos - 1 Step 1
            AJugos(i, 0) = InputBox("Ingrese el nombre del jugo " & (i + 1), "Jugos")
            cmb_jugos.Items.Add(AJugos(i, 0))
            AJugos(i, 1) = InputBox("Ingrese el precio del jugo de " + AJugos(i, 0), "Jugos")
            AJugos(i, 2) = InputBox("Ingrese el stock del jugo de " + AJugos(i, 0), "Jugos")
        Next
        T_Ticks.Enabled = True

    End Sub
    ''' <summary>
    ''' Comprobando el cambio de la ComboBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmb_jugos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_jugos.SelectedValueChanged
        'Declaración de variables
        Dim plato As String
        'Entrada de datos
        plato = cmb_jugos.Text
        'Buscamos  si el jugo ingresado existe
        For i As Integer = 0 To CJugos Step 1
            If (AJugos(i, 0) = plato) Then
                txt_costo.Text = AJugos(i, 1)
                txt_existencia.Text = AJugos(i, 2)
                index = i
                btn_vender.Enabled = True
                flag = 1
            End If
        Next
    End Sub

    Private Sub btn_vender_Click(sender As Object, e As EventArgs) Handles btn_vender.Click
        'Declaración de variables
        Dim cant As Integer, stock As Integer
        'Entrada de Datos
        If String.IsNullOrEmpty(txt_cantidad.Text) Then
            MessageBox.Show("Ingrese una cantidad", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If Val(txt_cantidad.Text) <= 0 Then
            MessageBox.Show("Favor de ingresar una catidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        cant = Val(txt_cantidad.Text)
        stock = Val(txt_existencia.Text)
        If (cant <= stock) Then
            'Disminuir el stock de ese plato
            AJugos(index, 2) = stock - cant
        Else
            MessageBox.Show("NO hay suficiente Stock" + Environment.NewLine + "Disponibles: " + stock, "Jugos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    ''' <summary>
    ''' Actualizando los TextBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub T_Ticks_Tick(sender As Object, e As EventArgs) Handles T_Ticks.Tick
        Dim plato As String
        'Entrada de datos
        plato = cmb_jugos.Text
        If String.IsNullOrEmpty(plato) Then
            Return
        End If
        'Buscamos  si el jugo ingresado existe
        For i As Integer = 0 To CJugos Step 1
            If (AJugos(i, 0) = plato) Then
                txt_costo.Text = AJugos(i, 1)
                txt_existencia.Text = AJugos(i, 2)
                index = i
                btn_vender.Enabled = True
                flag = 1
            End If
        Next
    End Sub
#End Region
End Class