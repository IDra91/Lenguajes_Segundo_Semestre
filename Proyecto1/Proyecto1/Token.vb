Public Class Token
    Enum Tipo
        Etiqueta_Abierto
        Etiqueta_Cerrado
        ID
        Palabra_Reservada
        Dos_Puntos

    End Enum
    Public TipoToken As Tipo = 0
    Public valor As String

    Public Sub New(ByVal tipo As Tipo, ByVal auxiliar As String)
        Me.TipoToken = tipo
        Me.valor = auxiliar

    End Sub

    Public Function getValor() As String
        Return valor
    End Function

    Public Function getString() As String
        Select Case TipoToken
            Case Tipo.Dos_Puntos
                Return "Dos Puntos"
            Case Tipo.Etiqueta_Abierto
                Return "Etiqueta Abierto"
            Case Tipo.Etiqueta_Cerrado
                Return "Etiqueta Cerrado"
            Case Tipo.ID
                Return "ID"
            Case Tipo.Palabra_Reservada
                Return "Palabra Reservada"
            Case Else
                Return "Desconocido"
        End Select
    End Function
End Class
