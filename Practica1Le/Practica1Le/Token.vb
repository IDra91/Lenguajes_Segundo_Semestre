Public Class Token
    Enum Tipo
        Etiqueta_Abierto
        Etiqueta_Cerrado
        Numero
        Comillas
        ID
        Coma
    End Enum
    Public tipoToken As Tipo = 0
    Public valor As String

    'Asignación de valores a la lista de Tokens
    Public Sub New(ByVal tipo As Tipo, ByVal Auxiliar As String)
        Me.tipoToken = tipo
        Me.valor = Auxiliar


    End Sub

    'Devuelve el valor que está en una posición en específico
    Public Function getValor() As String
        Return valor

    End Function

    'Retorna el tipo del Token que va obteniendo
    Public Function getString() As String
        Select Case tipoToken
            Case Tipo.Coma
                Return "Coma"
            Case Tipo.Comillas
                Return "Comillas"
            Case Tipo.Etiqueta_Abierto

                Return "Etiqueta_Abierto"
            Case Tipo.Etiqueta_Cerrado

                Return "Etiqueta_Cerrado"
            Case Tipo.ID

                Return "ID"

            Case Tipo.Numero
                Return "Número"
            Case Else
                Return "Desconocido"
        End Select
    End Function

End Class
