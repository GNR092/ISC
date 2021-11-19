''' <summary>
''' Tarea de Taller de programacion ISC 1-A
''' Gener de Jesús Can Dzul
''' 09-Noviembre-2021
''' </summary>
''' <remarks></remarks>
Public Class Form1
    Private Sub btn_Calcular_Click(sender As Object, e As EventArgs) Handles btn_Calcular.Click
        Dim result, num1, num2 As Double 'Definiendo variables

        Try 'Try Catch por si a alguien se le ocurre meter letras

            If String.IsNullOrEmpty(txt_campo1.Text) Then 'Comprobando campos vacios en el texbox
                MessageBox.Show("Verifique que los campos no esten vacios")
                Return
            End If

            num1 = Double.Parse(txt_campo1.Text) 'Haciendo un parse Double(Convirtiedo a Double) el campo

            If String.IsNullOrEmpty(txt_campo2.Text) Then 'Comprobando campos vacios en el texbox
                MessageBox.Show("Verifique que los campos no esten vacios")
                Return
            End If

            num2 = Double.Parse(txt_campo2.Text) 'Haciendo un parse Double(Convirtiedo a Double) el campo

            Select Case cmb_operation.Text 'Usando Casos de Swicth para selecionar la operacion a hacer
                Case "+" 'Caso Suma
                    result = num1 + num2
                    txt_result.Text = result
                Case "-" 'Caso Resta
                    result = num1 - num2
                    txt_result.Text = result
                Case "x" 'Caso Multiplicacion
                    result = num1 * num2
                    txt_result.Text = result
                Case "÷" 'Caso Divicion
                    result = num1 / num2
                    txt_result.Text = result
                Case "" 'Caso Campo vacio
                    MessageBox.Show("Selecione una operacion")
                Case Else

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
