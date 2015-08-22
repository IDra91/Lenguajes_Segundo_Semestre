Imports System
Imports System.IO

Public Class Form1

    Private Sub GuardarArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarArchivoToolStripMenuItem.Click
        Guardar.Filter = "Archivos.LFP|*.lfp"
        Guardar.OverwritePrompt = True
        Guardar.Title = "Guardar Archivo"
        If (Guardar.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Dim SF As StreamWriter
            Dim FS As FileStream
            FS = New FileStream(Guardar.FileName, FileMode.Create)
            SF = New StreamWriter(FS)
            SF.WriteLine(TextoAnalizar.Text)
            SF.Close()
            FS.Close()

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AbrirArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirArchivoToolStripMenuItem.Click
        Abrir.Filter = "Archivos.LFP|*.lfp"
        Abrir.ShowDialog()
        Dim file As StreamReader
        file = New StreamReader(Abrir.FileName)
        TextoAnalizar.Text = file.ReadToEnd
        file.Close()
        TextoAnalizar.Select(1, 0)
    End Sub

    Private Sub BotonAnalizar_Click(sender As Object, e As EventArgs) Handles BotonAnalizar.Click
        Dim cadena As String
        Dim s As New Scanner
        s.Scanner()
        cadena = TextoAnalizar.Text
        s.AnalizadorGeneral(cadena)

    End Sub
End Class
