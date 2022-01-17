Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net
''' <summary>
''' Cambio de divisas usando APIRest de Banxico
''' Equipo Conformado por 
''' Gener de Jesús Can Dzul
''' Karla Pamela Ku Pool
''' ISC 1-A
''' </summary>
Public Class CambioDivisas

    'Diccionario
    Protected Indentificador As New Dictionary(Of String, String)



    Private Sub btn_convert_Click(sender As Object, e As EventArgs) Handles btn_convert.Click
        'Se valida que en el combobox este seleccionado un tipo de moneda de lo contrario se manda un MessageBox
        If String.IsNullOrEmpty(cmb_tipodecambio.Text) Then
            MessageBox.Show("Seleccione una moneda a convertir", "Selecione moneda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'se hace un split al texto del combobox y se ontiene el texto en minusculas
        Dim moneda As String = LCase(Split(cmb_tipodecambio.Text, " ")(0))
        'Se le pasa a la Clase Divisa el tipo de moneda y el diccionario
        Dim div As New Divisa(moneda, Indentificador)
        'Obtengo y evaluo el textbox
        Dim txbmoneda As Double = Val(txt_moneda.Text)
        'se hace la conversion
        Dim convert As Double = (div.Precio * txbmoneda)
        'y se retorna al textbox en un formato simple
        txt_pesoMXN.Text = String.Format("{0,12: $0.00}", convert)


    End Sub

    Private Sub CambioDivisas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Agregamos al diccionaro las ids de las monedas al cargar el formulario
        Indentificador.Add("euro", "SF57923")
        Indentificador.Add("dolar", "SF43718")
        Indentificador.Add("yen", "SF46406")
        Indentificador.Add("dirham", "SF57797")
        Indentificador.Add("yuan", "SF57775")
        Indentificador.Add("rublo", "SF57807")
        txt_moneda.Select()
    End Sub
    ''' <summary>
    ''' Esta funcion evita que se ingresen letras
    ''' </summary>
    ''' <param name="e">numeros en formato de cadena</param>
    ''' <returns>True si contiene letras y false si solo numeros</returns>
    Private Function Numerico(e As String)
        Const _N As String = "1234567890."
        If Not (_N.Contains(e)) Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Esta funcion evita que el usuario ingrese letras y solo permite que los numeros sean validos en el textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txt_moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_moneda.KeyPress, cmb_tipodecambio.KeyPress
        'Detecta si el usuario presiona la tecla Intro y hace un tab al siguiente control
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        'la funcion Numerico evita que se ingresen letras y retorna false en caso de que no contenga
        'y permite que se ingrese los valores
        e.Handled = Numerico(e.KeyChar)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Creado por los integrantes:" + Environment.NewLine +
                        "Can Dzul Gener de Jesús" + Environment.NewLine +
                        "Ku Pool Karla Pamela" + Environment.NewLine +
                        "usando la API de https://www.banxico.org.mx/SieAPIRest/service/v1/",
                        "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class

Public Class Divisa
    Public Id As String
    Public Precio As Double
    ''' <summary>
    ''' Clase auxiliar en el codigo encargada de usar el APIRest de Banxico
    ''' </summary>
    ''' <param name="m">Tipo de moneda</param>
    ''' <param name="dic">Diccionario</param>
    Public Sub New(m As String, dic As Dictionary(Of String, String))
        'Se obtiene el id del diccionario
        Id = dic(m)
        'se le agrega al id a la url de la api
        Dim Url As String = "https://www.banxico.org.mx/SieAPIRest/service/v1/series/" + Id + "/datos/oportuno?token=dad39cd11c4aec3ba84c222fdb767e2d6df55b341d5c41a50c4c331431e6007f"
        'se hace la consulta y retorna el valor
        Precio = Val(GetJson(Url))

    End Sub
    ''' <summary>
    ''' Se encarga de hacer la consulta a la api donde retorna en formato JSON
    ''' </summary>
    ''' <param name="url">Direccion de la API</param>
    ''' <returns>En formato String el valor de la moneda</returns>
    Public Function GetJson(url As String)
        Try
            'se encarga de usar el protocolo TSL version 1 y 2
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            'se hacer la peticion
            Dim request As HttpWebRequest = WebRequest.Create(url)
            'request.ServicePoint.Expect100Continue = False 'Auxiliar en caso de error POST
            'se obtiene la respuesta de parte de banxico
            Using response As HttpWebResponse = request.GetResponse()
                'se compara en caso de no dar una respuesta satisfactoria
                If response.StatusCode <> HttpStatusCode.OK Then
                    MessageBox.Show("Server Error( " + response.StatusCode + ": " + response.StatusDescription + ").")
                    Return -1
                Else
                    'como se obtiene datos en Stream se pasan a un StreamReader para facilitar su lectura
                    Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
                    'Se lee hasta el final y se le hace un parse para delimitar el rango de busqueda en el JSON
                    Dim parsejson = JToken.Parse(reader.ReadToEnd())("bmx")("series")
                    'Obteniendo el valor indicado
                    For Each item As JToken In parsejson
                        For Each i2 As JToken In item("datos")
                            item = i2("dato")
                            response.Close()
                            Return item
                        Next
                    Next
                End If
            End Using
        Catch ex As Exception
            Return -1
        End Try
        Return -1
    End Function

End Class