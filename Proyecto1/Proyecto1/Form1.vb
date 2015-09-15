Public Class Form1

    Private Sub BotonAnalizar_Click(sender As Object, e As EventArgs) Handles BotonAnalizar.Click
        Dim cadena As String
        Dim s As New Scanner
        cadena = TAnalizar1.Text
        s.AnalizadorXMLGeneral(cadena)

    End Sub
End Class
