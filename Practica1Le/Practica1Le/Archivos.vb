Imports System
Imports System.IO
Imports System.IO.StreamWriter

Public Class Archivos

    Public Sub Archivos(ByVal sender As System.Object, ByVal e As System.EventArgs)
        


    End Sub

    Public Sub GenerarHTML(ByVal lista As List(Of Token))
        Dim datos As String = _
        My.Computer.FileSystem.SpecialDirectories.MyDocuments
        My.Computer.FileSystem.CreateDirectory(datos & "\pagina")
        Dim ruta As String = datos & "readme.html"
        Dim fi As FileInfo = New FileInfo(ruta)
        Dim sw As StreamWriter
        If (File.Exists(ruta) = False) Then
            sw = File.CreateText(ruta)
            sw.WriteLine("<html>")
            sw.WriteLine("<head><title>Tabla de elementos</title></head>")
            sw.WriteLine("<body>")
            sw.WriteLine("<left><h1>Universidad de San Carlos de Guatemala</h1></left>")
            sw.WriteLine("<left><h1>Facultad de Ingeniería</h1></left>")
            sw.WriteLine("<left><h1>By Manuel Rivera, Carné: 201212747")
            sw.WriteLine("<left><h1>Lenguajes Formales y de Programación</h1></left>")
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine("<left><h1> Tabla de Tokens </h1></left>")
            sw.WriteLine("<table border = 1 width = 300>")
            sw.WriteLine("<tr><td width = 100> No. Token </td> <td width = 100> Token </td> <td width = 100> Lexema </td></tr>")
            For i As Integer = 0 To lista.Count Step 1

            Next
            sw.WriteLine("</table>")
            sw.WriteLine("")
            sw.WriteLine("")
            sw.WriteLine("<left><h1>Tabla de Errores</h1></left>")
            sw.WriteLine("<table border = 1 width = 300")
            sw.WriteLine("<tr><td width = 100> No. Token </td> <td width = 100> Error </td> <td width = 100> Tipo de error </td></tr>")

            sw.WriteLine("</table>")
            sw.WriteLine("</body>")
            sw.WriteLine("</html>")
        End If

    End Sub

End Class
