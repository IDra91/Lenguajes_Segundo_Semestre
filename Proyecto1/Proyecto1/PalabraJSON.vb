Public Class PalabraJSON
    Enum Categoria
        Sustantivo
        Articulo
        Adjetivo
        Verbo
    End Enum
    Public catPa As Categoria
    Public palabra As String
    Public Sub New(ByVal categoria As Categoria, ByVal palabra As String)
        Me.catPa = categoria
        Me.palabra = palabra


    End Sub

    Public Function getPalabra() As String
        Return palabra

    End Function

    Public Function getString() As String
        Select Case catPa
            Case Categoria.Adjetivo
                Return "Adjetivo"
            Case Categoria.Articulo
                Return "Artículo"
            Case Categoria.Sustantivo
                Return "Sustantivo"
            Case Categoria.Verbo
                Return "Verbo"
            Case Else
                Return "Palabra"
        End Select
    End Function
End Class
