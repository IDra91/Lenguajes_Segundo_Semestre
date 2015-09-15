Public Class Scanner
    Dim cadena As String = ""
    Dim aceptacion1 As Boolean = False
    Dim t As Integer = 0
    Dim n As Integer = 0
    Dim p As Integer = 0
    Dim c As Integer = 0
    Dim Te As Integer = 0
    Dim No As Integer = 0
    Dim Pa As Integer = 0
    Dim aceptacion2 As Boolean = False
    Dim ca As Integer = 0
    Dim counter1 As Integer = 0
    'Agregar dos listas de objetos para las palabras a comparar

    Public Sub Scanner()

    End Sub


    Public Sub AnalizadorXMLGeneral(ByVal cadena As String)
        Dim caracter As Char
        Dim estadoActual As Integer
        Dim auxiliar As String = ""
        Dim estadoActual2 As Integer
        For counter1 As Integer = counter1 To cadena.Length Step 1
            caracter = cadena.Chars(counter1)
            Select Case estadoActual
                Case 0

                    If (caracter = "<") Then
                        estadoActual = 1
                        auxiliar += caracter
                        Console.WriteLine("Así va la cadena --->" + auxiliar)
                    ElseIf (caracter = "'") Then
                        estadoActual = 2
                    Else
                        estadoActual = 0
                    End If
                Case 1
                    Select Case estadoActual2
                        Case 0
                            If (Char.IsLetter(caracter)) Then
                                estadoActual2 = 1
                                auxiliar += caracter
                                Console.WriteLine("Así va la cadena --->" + auxiliar)
                            ElseIf (caracter = "/") Then
                                estadoActual2 = 1
                                auxiliar += caracter
                            End If
                        Case 1
                            If (Char.IsLetter(caracter)) Then
                                estadoActual2 = 1
                                auxiliar += caracter
                                Console.WriteLine("Así va la cadena --->" + auxiliar)
                            ElseIf (caracter = ">") Then
                                auxiliar += caracter
                                Console.WriteLine("Esto se guardará en la lista de tokens --->" + auxiliar)
                                If ((auxiliar = "<Texto>") Or (auxiliar = "<TEXTO>") Or (auxiliar = "<texto>")) Then
                                    'Agregar a una lista de objeto tokens 
                                    auxiliar = ""
                                    t = 1
                                    estadoActual = 0
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "<Categoria>") Or (auxiliar = "<CATEGORIA>") Or (auxiliar = "<categoria>")) Then
                                    'Agregar a una lista de objeto tokens 
                                    auxiliar = ""
                                    c = 1
                                    estadoActual = 0
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "<Nombre>") Or (auxiliar = "<NOMBRE>") Or (auxiliar = "<nombre>")) Then
                                    'Agregar a una lista de objeto tokens 
                                    auxiliar = ""
                                    n = 1
                                    estadoActual = 0
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "<Palabra>") Or (auxiliar = "<PALABRA>") Or (auxiliar = "<palabra>")) Then
                                    'Agregar a una lista de objeto tokens
                                    auxiliar = ""
                                    p = 1
                                    estadoActual = 0
                                    estadoActual = 0
                                ElseIf ((auxiliar = "</Texto>") Or (auxiliar = "</TEXTO>") Or (auxiliar = "</texto>")) Then
                                    'Agregar a una lista de objeto tokens
                                    auxiliar = ""
                                    t = 0
                                    estadoActual = 3
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "</Nombre>") Or (auxiliar = "</NOMBRE>") Or (auxiliar = "</nombre>")) Then
                                    'Agregar a una lista de objeto tokens
                                    auxiliar = ""
                                    n = 0
                                    estadoActual = 0
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "</Palabra>") Or (auxiliar = "</PALABRA>") Or (auxiliar = "</palabra>")) Then
                                    'Agregar a una lista de objeto tokens
                                    auxiliar = ""
                                    p = 0
                                    estadoActual = 0
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "</Categoria>") Or (auxiliar = "</CATEGORIA>") Or (auxiliar = "</categoria>")) Then
                                    'Agregar a una lista de objeto tokens
                                    auxiliar = ""
                                    c = 0
                                    estadoActual = 0
                                    estadoActual2 = 0
                                Else
                                    'Agregar a una lista de objeto errores
                                    auxiliar = ""
                                    Console.WriteLine("Etiqueta no reconocida")
                                    estadoActual = 0
                                    estadoActual2 = 0
                                End If
                                
                            Else
                                estadoActual2 = 1
                            End If
                    End Select
                Case 2
                    Select Case estadoActual2
                        Case 0
                            If (Char.IsLetter(caracter)) Then
                                estadoActual2 = 1
                                auxiliar += caracter
                                Console.WriteLine("Así va la cadena --->" + auxiliar)
                            Else
                                estadoActual2 = 0
                            End If
                        Case 1
                            If (Char.IsLetter(caracter)) Then
                                estadoActual2 = 1
                                auxiliar += caracter
                                Console.WriteLine("Así va la cadena --->" + auxiliar)
                            ElseIf (caracter = "'") Then
                                Console.WriteLine("Esto debería de ser reconocido dentro de comillas--->" + auxiliar)
                                'Agregar a una lista de objetos de tokens 
                                'Agregar a una lista de palabras recibidas 
                                auxiliar = ""
                                estadoActual = 0
                                estadoActual2 = 0
                            Else
                                estadoActual2 = 1
                            End If
                    End Select
                Case 3


            End Select
        Next

    End Sub

    
End Class
