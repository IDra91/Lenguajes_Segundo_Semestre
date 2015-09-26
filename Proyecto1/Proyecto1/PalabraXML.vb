Public Class PalabraXML
    Enum categoria
        Sustantivo
        Articulo
        Adjetivo
        Verbo
    End Enum
    Public catPa As categoria
    Public palabra As String

    Public Sub New(ByVal categoria As categoria, ByVal palabra As String)
        Me.catPa = categoria
        Me.palabra = palabra
    End Sub

    Public Function getPalabra() As String
        Return palabra
    End Function

    Public Function getCategoria() As String
        Select Case catPa
            Case categoria.Adjetivo
                Return "Adjetivo"
            Case categoria.Articulo
                Return "Artículo"
            Case categoria.Sustantivo
                Return "Sustantivo"
            Case categoria.Verbo
                Return "Verbo"
            Case Else
                Return "Palabra"
        End Select
    End Function
End Class
