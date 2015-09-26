Public Class Scanner
    Dim cadena As String = ""
    Dim aceptacion1 As Boolean = False
    Dim aceptacion2 As Boolean = False
    Dim ca As Integer = 0
    Dim counter1 As Integer = 0
    Dim counter2 As Integer = 0
    Dim lista_token As List(Of Token)
    Dim lista_palabrax As List(Of PalabraXML)
    Dim lista_palabraj As List(Of PalabraJSON)

    'Agregar dos listas de objetos para las palabras a comparar

    Public Sub Scanner()

    End Sub


    Public Sub AnalizadorXMLGeneral(ByVal cadena As String)
        Dim caracter As Char
        Dim estadoActual As Integer
        Dim auxiliar As String = ""
        Dim estadoActual2 As Integer
        Dim aceptacion As Boolean = False
        Dim t As Integer = 0
        Dim n As Integer = 0
        Dim p As Integer = 0
        Dim c As Integer = 0
        lista_token = New List(Of Token)
        lista_palabrax = New List(Of PalabraXML)
        For counter1 As Integer = 0 To cadena.Length Step 1
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
                                    lista_token.Add(New Token(Token.Tipo.Etiqueta_Abierto, auxiliar))

                                    auxiliar = ""
                                    t = 1
                                    estadoActual = 0
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "<Categoria>") Or (auxiliar = "<CATEGORIA>") Or (auxiliar = "<categoria>")) Then
                                    'Agregar a una lista de objeto tokens 
                                    lista_token.Add(New Token(Token.Tipo.Etiqueta_Abierto, auxiliar))
                                    auxiliar = ""
                                    c = 1
                                    estadoActual = 0
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "<Nombre>") Or (auxiliar = "<NOMBRE>") Or (auxiliar = "<nombre>")) Then
                                    'Agregar a una lista de objeto tokens 
                                    lista_token.Add(New Token(Token.Tipo.Etiqueta_Abierto, auxiliar))
                                    auxiliar = ""
                                    n = 1
                                    estadoActual = 0
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "<Palabra>") Or (auxiliar = "<PALABRA>") Or (auxiliar = "<palabra>")) Then
                                    'Agregar a una lista de objeto tokens
                                    lista_token.Add(New Token(Token.Tipo.Etiqueta_Abierto, auxiliar))
                                    auxiliar = ""
                                    p = 1
                                    estadoActual = 0
                                    estadoActual = 0
                                ElseIf ((auxiliar = "</Texto>") Or (auxiliar = "</TEXTO>") Or (auxiliar = "</texto>")) Then
                                    'Agregar a una lista de objeto tokens
                                    lista_token.Add(New Token(Token.Tipo.Etiqueta_Cerrado, auxiliar))
                                    auxiliar = ""
                                    t = 0
                                    estadoActual = 3
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "</Nombre>") Or (auxiliar = "</NOMBRE>") Or (auxiliar = "</nombre>")) Then
                                    'Agregar a una lista de objeto tokens
                                    lista_token.Add(New Token(Token.Tipo.Etiqueta_Cerrado, auxiliar))
                                    auxiliar = ""
                                    n = 0
                                    estadoActual = 0
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "</Palabra>") Or (auxiliar = "</PALABRA>") Or (auxiliar = "</palabra>")) Then
                                    'Agregar a una lista de objeto tokens
                                    lista_token.Add(New Token(Token.Tipo.Etiqueta_Cerrado, auxiliar))
                                    auxiliar = ""
                                    p = 0
                                    estadoActual = 0
                                    estadoActual2 = 0
                                ElseIf ((auxiliar = "</Categoria>") Or (auxiliar = "</CATEGORIA>") Or (auxiliar = "</categoria>")) Then
                                    'Agregar a una lista de objeto tokens
                                    lista_token.Add(New Token(Token.Tipo.Etiqueta_Cerrado, auxiliar))
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
                                lista_token.Add(New Token(Token.Tipo.ID, auxiliar))

                                'Agregar a una lista de palabras recibidas
                                auxiliar = ""
                                estadoActual = 0
                                estadoActual2 = 0
                            Else
                                estadoActual2 = 1
                            End If
                    End Select
                Case 3
                    MsgBox("Análisis terminado :D")
                    Console.WriteLine("Análisis terminado :D")
                    aceptacion = True

            End Select
        Next

    End Sub

    Public Sub AnalizadorJSON(ByVal cadena As String)
        Dim caracter As Char
        Dim estadoActual As Integer
        Dim auxiliar As String = ""
        Dim estadoActual2 As Integer
        Dim Te As Integer = 0
        Dim No As Integer = 0
        Dim Pa As Integer = 0
        lista_token = New List(Of Token)
        lista_palabraj = New List(Of PalabraJSON)
        For counter2 As Integer = 0 To cadena.Length Step 1
            caracter = cadena.Chars(counter2)
            Select Case estadoActual
                Case 0
                    If (caracter = ChrW(34)) Then
                        If ((Te = 0) Or (ca = 0) Or (No = 0) Or (Pa = 0)) Then
                            estadoActual = 1
                        ElseIf ((ca = 1) Or (No = 1) Or (Pa = 1)) Then
                            estadoActual = 4
                        Else
                            estadoActual = 0
                        End If

                    ElseIf (caracter = ":") Then
                        estadoActual = 3
                    ElseIf ((caracter = "[") And (ca = 1)) Then
                        estadoActual = 4
                    ElseIf (caracter = ",") Then
                        estadoActual = 666
                    Else
                        estadoActual = 0
                    End If
                Case 1
                    If (Char.IsLetter(caracter)) Then
                        estadoActual = 2
                        auxiliar += caracter
                        Console.WriteLine("Así va la cadena ---> " + auxiliar)
                    Else
                        estadoActual = 0
                    End If
                Case 2
                    If (Char.IsLetter(caracter)) Then
                        estadoActual = 2
                        auxiliar += caracter
                        Console.WriteLine("Así va la cadena ---> " + auxiliar)
                    ElseIf (caracter = ChrW(34)) Then
                        estadoActual = 3
                        If ((auxiliar = "Texto") Or (auxiliar = "TEXTO") Or (auxiliar = "texto")) Then
                            'Agregar a lista de objeto de tokens
                            lista_token.Add(New Token(Token.Tipo.Palabra_Reservada, auxiliar))
                            Te = 1
                            Console.WriteLine("El valor del flag en este momento es --->" + Te)
                            estadoActual = 0
                            auxiliar = ""
                        ElseIf ((auxiliar = "Categoria") Or (auxiliar = "CATEGORIA") Or (auxiliar = "categoria")) Then
                            'Agregar a lista dde objeto de tokens
                            lista_token.Add(New Token(Token.Tipo.Palabra_Reservada, auxiliar))
                            ca = 1
                            Console.WriteLine("El valor del flag en este momento es --->" + ca)
                            estadoActual = 0
                            auxiliar = ""
                        ElseIf ((auxiliar = "Nombre") Or (auxiliar = "NOMBRE") Or (auxiliar = "Nombre")) Then
                            'Agregar a lista de objeto de tokens
                            lista_token.Add(New Token(Token.Tipo.Palabra_Reservada, auxiliar))
                            No = 1
                            Console.WriteLine("El valor del flag en este momento es --->" + No)
                            estadoActual = 0
                            auxiliar = ""
                        ElseIf ((auxiliar = "Palabra") Or (auxiliar = "PALABRA") Or (auxiliar = "Palabra")) Then
                            'Agregar a lista de objeto de tokens
                            lista_token.Add(New Token(Token.Tipo.Palabra_Reservada, auxiliar))
                            Pa = 1
                            Console.WriteLine("El valor del flag en este momento es --->" + Pa)
                            estadoActual = 0
                            auxiliar = ""
                        Else
                            'Agregar a lista de objeto de errores
                            Console.WriteLine("Sección no reconocida")
                            estadoActual = 0
                            auxiliar = ""
                        End If

                    Else
                        estadoActual = 2
                    End If
                Case 3
                    If (caracter = "{") Then
                        estadoActual = 0

                    Else
                        estadoActual = 3
                    End If
                Case 4
                    Select Case estadoActual2
                        Case 0
                            If (Char.IsLetter(caracter)) Then
                                auxiliar += caracter
                                Console.WriteLine("Así va la cadena --->" + auxiliar)
                            Else
                                estadoActual2 = 0
                            End If
                        Case 1
                            If (Char.IsLetter(caracter)) Then
                                auxiliar += caracter
                                Console.WriteLine("Así va la cadena --> " + auxiliar)
                            ElseIf (caracter = ChrW(34)) Then
                                'Agregar a la lista de objeto tokens (ID)
                                lista_token.Add(New Token(Token.Tipo.ID, auxiliar))
                                'Agregar a la lista de objeto palabras
                                If (No = 1) Then
                                    If ((auxiliar = "Articulo") Or (auxiliar = "ARTICULO") Or (auxiliar = "articulo")) Then
                                        lista_palabraj.Add(New PalabraJSON(PalabraJSON.Categoria.Articulo, ""))
                                        auxiliar = ""
                                        estadoActual = 0
                                        estadoActual2 = 0
                                    ElseIf ((auxiliar = "Sustantivo") Or (auxiliar = "SUSTANTIVO") Or (auxiliar = "sustantivo")) Then
                                        lista_palabraj.Add(New PalabraJSON(PalabraJSON.Categoria.Sustantivo, ""))
                                        auxiliar = ""
                                        estadoActual = 0
                                        estadoActual2 = 0
                                    ElseIf ((auxiliar = "Verbo") Or (auxiliar = "VERBO") Or (auxiliar = "verbo")) Then
                                        lista_palabraj.Add(New PalabraJSON(PalabraJSON.Categoria.Verbo, ""))
                                        auxiliar = ""
                                        estadoActual = 0
                                        estadoActual2 = 0
                                    ElseIf ((auxiliar = "Adjetivo") Or (auxiliar = "ADJETIVO") Or (auxiliar = "adjetivo")) Then
                                        lista_palabraj.Add(New PalabraJSON(PalabraJSON.Categoria.Adjetivo, ""))
                                        auxiliar = ""
                                        estadoActual = 0
                                        estadoActual2 = 0
                                    Else
                                        Console.WriteLine("Palabra no reconocida")
                                        auxiliar = ""
                                        estadoActual = 0
                                        estadoActual2 = 0
                                    End If
                                ElseIf (Pa = 1) Then

                                Else

                                End If
                                
                            Else
                                estadoActual2 = 0

                            End If
                    End Select
            End Select
        Next
    End Sub

    
End Class
