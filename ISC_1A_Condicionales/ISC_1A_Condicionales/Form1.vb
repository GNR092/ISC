Public Class Form1
    ''' <summary>
    ''' Taller de programación
    ''' ISC 1-A
    ''' Integrantes
    ''' Can Dzul Gener de Jesús 
    ''' Can Dzul Lesli Guadalupe 
    ''' Ku Canche Armando Eliomar 
    ''' Ku Pool Karla Pamela
    ''' </summary>
    Private Sub btn_comprobar_Click(sender As Object, e As EventArgs) Handles btn_comprobar.Click
        Dim Edad As Integer
        Edad = 0
        If String.IsNullOrEmpty(txt_edad.Text) Then
            MessageBox.Show("Ingrese su edad porfavor", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If Val(txt_edad.Text) <= 0 Then
            MessageBox.Show("Favor de ingresar una catidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Edad = Val(txt_edad.Text)
        If Edad >= 15 And Edad <= 17 Then
            MessageBox.Show("Usted es candidato a la vacuna Pfizer", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Edad >= 18 And Edad <= 29 Then
            MessageBox.Show("Usted es candidato a la vacuna Sinovac", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Edad >= 30 Then
            MessageBox.Show("Usted es candidato a la vacuna Astrazeneca", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Edad < 15 Then
            MessageBox.Show("Usted no es candidato a la vacuna", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class
