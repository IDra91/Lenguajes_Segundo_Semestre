Public Class Errores
    Enum Tipo
        Etiqueta_NoValida
        ID_NoValido
        No_Reconocido

    End Enum

    Private tipoError As Tipo
    Private valor As String

    Public Sub New(ByVal tipo As Tipo, ByVal auxiliar As String)
        Me.tipoError = tipo
        Me.valor = auxiliar

    End Sub


    Public Function getError() As String
        Select Case tipoError
            Case Tipo.Etiqueta_NoValida
                Return "Etiqueta No Valida"
            Case Tipo.ID_NoValido
                Return "ID No valido"
            Case Else
                Return "Desconocido"
        End Select
    End Function
End Class
