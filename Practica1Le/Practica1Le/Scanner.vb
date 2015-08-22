Imports Practica1Le.Token

Public Class Scanner
    Dim cadena As String
    Dim abierto As Integer
    Dim counter As Integer
    Dim aceptacion As Boolean
    Dim aux As String
    Dim h As Integer
    Dim i As Integer
    Dim u As Integer
    Dim s As Integer
    Dim t As Integer
    Dim c As Integer
    Dim lista_Token As List(Of Token)








    Public Sub Scanner()
        cadena = ""
        abierto = 0
        aceptacion = False
        lista_Token = New List(Of Token)
        aux = ""

        h = 0
        i = 0
        u = 0
        s = 0
        t = 0
        c = 0
    End Sub

    'Hay que terminar el analizador general
    Public Sub AnalizadorGeneral(ByVal cadena As String)
        Dim caracter As Char
        Dim estadoActual As Integer

        While (aceptacion = False)
            caracter = cadena.Chars(counter)
            Select Case estadoActual
                Case 0
                    If (inicio(cadena)) Then
                        estadoActual = 1
                    Else
                        estadoActual = 0
                    End If
                Case 1
                    If (EtiquetaAbierto(cadena)) Then
                        estadoActual = 2
                    ElseIf (ChrW(13).Equals(caracter)) Then
                        estadoActual = 1
                    ElseIf (EtiquetaCerrado(cadena)) Then
                        estadoActual = 9
                    Else
                        estadoActual = 1
                    End If
                Case 2
                    If (h = 1) Then

                        If (EtiquetaAbierto(cadena)) Then
                            estadoActual = 3
                        ElseIf (ChrW(13).Equals(caracter)) Then
                            estadoActual = 2
                        Else
                            estadoActual = 2
                        End If
                    ElseIf (s = 1) Then
                        If (EtiquetaAbierto(cadena)) Then
                            estadoActual = 6
                        ElseIf (ChrW(13).Equals(caracter)) Then
                            estadoActual = 2
                        Else
                            estadoActual = 2
                        End If

                    End If

                Case 3
                    If (identificador(cadena) Or usuarios(cadena) Or tipo(cadena)) Then
                        estadoActual = 4
                    Else
                        estadoActual = 3
                    End If
                Case 4
                    If (EtiquetaCerrado(cadena)) Then
                        estadoActual = 5
                    Else
                        estadoActual = 4
                    End If
                Case 5
                    If (EtiquetaAbierto(cadena)) Then
                        estadoActual = 2
                    ElseIf (EtiquetaCerrado(cadena)) Then
                        estadoActual = 1
                    Else
                        estadoActual = 5
                    End If
                Case 6
                    If (identificador(cadena) Or conectados(cadena)) Then
                        estadoActual = 7
                    Else
                        estadoActual = 6
                    End If
                Case 7
                    If (EtiquetaCerrado(cadena)) Then
                        estadoActual = 8
                    Else
                        estadoActual = 7
                    End If
                Case 8
                    If (EtiquetaAbierto(cadena)) Then
                        estadoActual = 2
                    ElseIf (EtiquetaCerrado(cadena)) Then
                        estadoActual = 1
                    Else
                        estadoActual = 8
                    End If
                Case 9
                    aceptacion = True
                    counter += 1
                    t = 1
                    MsgBox("Hola bebé")
                Case Else
                    aceptacion = False

            End Select
        End While

    End Sub

    Public Function conectados(ByVal analizar As String) As Boolean
        Dim aux As String = ""
        Dim caracter As Char
        Dim estadoActual As Integer
        If (c = 1) Then
            For counter As Integer = counter To analizar.Length Step 1
                caracter = analizar.Chars(counter)
                Select Case estadoActual
                    Case 0
                        If Char.IsNumber(caracter) Then
                            estadoActual = 1
                            aux += caracter
                        Else
                            estadoActual = 0
                        End If
                    Case 1
                        If caracter = "," Then
                            estadoActual = 1
                            aux += caracter
                        ElseIf Char.IsNumber(caracter) Then
                            estadoActual = 1
                            aux += caracter
                        ElseIf caracter = "<" Then
                            estadoActual = 2
                        Else
                            estadoActual = 1
                        End If
                    Case 2
                        lista_Token.Add(New Token(Token.Tipo.ID, aux))
                        aux = ""
                        Return True
                    Case Else
                        Return False
                End Select
            Next
        End If
        Return False
    End Function
    Public Function usuarios(ByVal analizar As String) As Boolean
        Dim aux As String = ""
        Dim caracter As Char
        Dim estadoActual As Integer
        If (u = 1) Then
            For counter As Integer = counter To analizar.Length Step 1
                caracter = analizar.Chars(counter)
                Select Case estadoActual
                    Case 0
                        If ChrW(34).Equals(caracter) Then
                            estadoActual = 1

                        Else
                            estadoActual = 0
                        End If
                    Case 1
                        If Char.IsLetter(caracter) Then
                            estadoActual = 2
                            aux = aux + caracter
                        Else
                            estadoActual = 1
                        End If
                    Case 2
                        If Char.IsLetter(caracter) Then
                            estadoActual = 2
                            aux += caracter
                        ElseIf caracter = " " Then
                            estadoActual = 2
                            aux += caracter
                        ElseIf ChrW(34).Equals(caracter) Then
                            estadoActual = 3
                        Else
                            estadoActual = 2
                        End If
                    Case 3
                        lista_Token.Add(New Token(Token.Tipo.ID, aux))
                        aux = ""
                        counter -= 1
                        Return True
                    Case Else
                        Return False
                End Select

            Next


        End If

        Return False
    End Function
    Public Function tipo(ByVal analizar As String) As Boolean
        Dim aux As String = ""
        Dim caracter As Char
        Dim estadoActual As Integer
        If (t = 1) Then
            For counter As Integer = counter To analizar.Length Step 1
                caracter = analizar.Chars(counter)
                Select Case estadoActual
                    Case 0
                        If Char.IsNumber(caracter) Then
                            estadoActual = 1
                            aux += caracter
                        Else
                            estadoActual = 0
                        End If
                    Case 1
                        If Char.IsNumber(caracter) Then
                            estadoActual = 1
                            aux += caracter
                        ElseIf caracter = "<" Then
                            estadoActual = 2
                        Else
                            estadoActual = 1
                        End If
                    Case 2
                        lista_Token.Add(New Token(Token.Tipo.ID, aux))
                        aux = ""
                        counter -= 1
                        Return True

                    Case Else
                        Return False
                End Select
            Next
        End If
        Return False
    End Function
    Public Function identificador(ByVal analizar As String) As Boolean
        Dim aux As String = ""
        Dim caracter As Char
        Dim estadoActual As Integer
        If (i = 1) Then
            For counter As Integer = counter To analizar.Length Step 1
                caracter = analizar.Chars(counter)
                Select Case estadoActual
                    Case 0
                        If Char.IsNumber(caracter) Then
                            estadoActual = 1
                            aux += caracter
                        Else
                            estadoActual = 0
                        End If
                    Case 1
                        If Char.IsNumber(caracter) Then
                            estadoActual = 1
                            aux += caracter
                        ElseIf (caracter = "<") Then
                            estadoActual = 2
                        Else
                            estadoActual = 1
                        End If
                    Case 2
                        lista_Token.Add(New Token(Token.Tipo.ID, aux))
                        aux = ""
                        Return True
                        counter -= 1
                    Case Else
                        Return False
                End Select
            Next

        End If
        Return False
    End Function

    Public Function EtiquetaCerrado(ByVal analizar As String) As Boolean
        Dim aux As String = ""
        Dim caracter As Char
        Dim estadoActual As Integer

        For counter As Integer = counter To analizar.Length Step 1
            caracter = analizar.Chars(counter)
            Select Case estadoActual
                Case 0
                    If (caracter = "<") Then
                        estadoActual = 1
                        aux += caracter
                        Console.WriteLine("Esto se añadirá a la cadena ---> " + caracter)
                    Else
                        estadoActual = 0
                    End If
                Case 1
                    If (caracter = "/") Then
                        estadoActual = 2
                        aux += caracter
                        Console.WriteLine("Esto se añadirá a la cadena ---> " + caracter)
                    Else
                        estadoActual = 1
                    End If
                Case 2
                    If Char.IsLetter(caracter) Then
                        estadoActual = 3
                        aux += caracter
                        Console.WriteLine("Esto se añadirá a la cadena ---> " + caracter)
                    Else
                        estadoActual = 2

                    End If
                Case 3
                    If Char.IsLetter(caracter) Then
                        estadoActual = 3
                        aux += caracter
                        Console.WriteLine("Esto se añadirá a la cadena ---> " + caracter)
                    ElseIf (caracter = ">") Then
                        estadoActual = 4
                        aux += caracter
                        Console.WriteLine("Esto se añadirá a la cadenA ---> " + caracter)
                    Else
                        estadoActual = 3

                    End If
                Case 4
                    If ((aux = "</host>") Or (aux = "</HOST>") Or (aux = "</Host>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Cerrado, aux))
                        aux = ""
                        h = 0
                        Return True
                        counter -= 1

                    ElseIf ((aux = "</ID>") Or (aux = "</id>") Or (aux = "</Id>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Cerrado, aux))
                        aux = ""
                        i = 0
                        Return True
                        counter -= 1

                    ElseIf ((aux = "</Usuario>") Or (aux = "</USUARIO>") Or (aux = "</usuario>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Cerrado, aux))
                        aux = ""
                        u = 0
                        Return True
                        counter -= 1

                    ElseIf ((aux = "</Tipo>") Or (aux = "</TIPO>") Or (aux = "</tipo>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Cerrado, aux))
                        aux = ""
                        t = 0
                        Return True
                        counter -= 1

                    ElseIf ((aux = "</Conectados>") Or (aux = "</CONECTADOS>") Or (aux = "</conectados>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Cerrado, aux))
                        aux = ""
                        c = 0
                        Return True
                        counter -= 1

                    ElseIf ((aux = "</SWITCH>") Or (aux = "</switch>") Or (aux = "</Switch>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Cerrado, aux))
                        aux = ""
                        s = 0
                        Return True
                        counter -= 1
                    ElseIf ((aux = "</TOPOLOGIA>") Or (aux = "</topologia>") Or (aux = "</Topologia>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Cerrado, aux))
                        aux = ""
                        s = 0
                        Return True
                        counter -= 1

                    Else
                        'Añadir a lista de Errores léxicos
                        aux = ""
                        Return True
                        counter -= 1
                    End If
                Case Else
                    Return False
            End Select
        Next
        Return False
    End Function


    Public Function EtiquetaAbierto(ByVal analizar As String) As Boolean
        Dim aux As String = ""
        Dim caracter As Char
        Dim estadoActual As Integer

        For counter As Integer = counter To analizar.Length Step 1
            caracter = analizar.Chars(counter)
            Select Case estadoActual
                Case 0
                    If (caracter = "<") Then
                        estadoActual = 1
                        Console.WriteLine("Se va añadiendo esto a la cadena --->" + caracter)
                        aux += caracter
                    Else
                        estadoActual = 0
                    End If
                Case 1
                    If Char.IsLetter(caracter) Then
                        estadoActual = 2
                        aux += caracter
                        Console.WriteLine("Así va la cadena ---> " + aux)
                    Else
                        estadoActual = 1

                    End If
                Case 2
                    If Char.IsLetter(caracter) Then
                        estadoActual = 2
                        aux += caracter
                        Console.WriteLine("Así va la cadena ---> " + aux)
                    ElseIf (caracter = ">") Then
                        estadoActual = 3

                        aux += caracter
                        Console.WriteLine("Así va la cadena ---> " + aux)
                    Else
                        estadoActual = 2
                    End If
                Case 3
                    If ((aux = "<host>") Or (aux = "<HOST>") Or (aux = "<Host>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Abierto, aux))
                        aux = ""
                        h = 1
                        Return True
                        counter -= 1

                    ElseIf ((aux = "<ID>") Or (aux = "<id>") Or (aux = "<Id>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Abierto, aux))
                        aux = ""
                        i = 1
                        Return True
                        counter -= 1

                    ElseIf ((aux = "<Usuario>") Or (aux = "<USUARIO>") Or (aux = "<usuario>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Abierto, aux))
                        aux = ""
                        u = 1
                        Return True
                        counter -= 1

                    ElseIf ((aux = "<Tipo>") Or (aux = "<TIPO>") Or (aux = "<tipo>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Abierto, aux))
                        aux = ""
                        t = 1
                        Return True
                        counter -= 1

                    ElseIf ((aux = "<Conectados>") Or (aux = "<CONECTADOS>") Or (aux = "<conectados>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Abierto, aux))
                        aux = ""
                        c = 1
                        Return True
                        counter -= 1

                    ElseIf ((aux = "<SWITCH>") Or (aux = "<switch>") Or (aux = "<Switch>")) Then
                        lista_Token.Add(New Token(Token.Tipo.Etiqueta_Abierto, aux))
                        aux = ""
                        s = 1
                        Return True
                        counter -= 1

                    Else
                        'Añadir a lista de Errores léxicos
                        aux = ""
                        Return True
                        counter -= 1
                    End If
                Case Else
                    Return False
            End Select
        Next
        Return False

    End Function

    Public Function inicio(ByVal analizar As String) As Boolean
        Dim aux As String = ""
        Dim caracter As Char
        Dim estadoActual As Integer

        Dim salida As Boolean = False


        'Nombre: Manuel Gonzalo Rivera
        For counter As Integer = counter To analizar.Length Step 1
            caracter = analizar.Chars(counter)
            Select Case estadoActual
                Case 0
                    If (caracter = "<") Then
                        estadoActual = 1

                        aux += caracter
                    Else
                        estadoActual = 0
                    End If
                Case 1
                    If Char.IsLetter(caracter) Then
                        estadoActual = 2
                        aux += caracter
                        Console.WriteLine("Así va la cadena ---> " + aux)
                    Else
                        estadoActual = 1

                        'Agregar a lista error

                    End If
                Case 2
                    If Char.IsLetter(caracter) Then
                        estadoActual = 2
                        aux += caracter
                        Console.WriteLine("Así va la cadena ---> " + aux)
                    ElseIf caracter = ">" Then
                        aux += caracter
                        estadoActual = 3

                        Console.WriteLine("Así va la cadena ---> " + aux)


                    End If
                Case 3
                    If ((aux = "<topologia>") Or (aux = "<TOPOLOGIA>") Or (aux = "<Topologia>")) Then
                        addToken(Token.Tipo.Etiqueta_Abierto, aux)
                        Console.WriteLine("Así va la cadena ---> " + aux)
                        salida = True
                        Return salida


                    End If
                Case Else
                    Return salida
            End Select

        Next

        Return salida


    End Function

    Private Sub addToken(ByVal tipo As Tipo, ByVal aux As String)

        lista_Token.Add(New Token(tipo, aux))
    End Sub



End Class

