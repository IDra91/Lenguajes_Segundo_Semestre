Imports System
Imports System.IO

Public Class Form1

    Private Sub BotonAnalizar_Click(sender As Object, e As EventArgs) Handles BotonAnalizar.Click
        Dim cadena As String
        Dim s As New Scanner
        cadena = TAnalizar1.Text
        s.AnalizadorXMLGeneral(cadena)

    End Sub

    Private Sub CargarArchivoXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarArchivoXMLToolStripMenuItem.Click
        Abrir1.Filter = "Archivos.XML|*.xml"
        Abrir1.ShowDialog()
        Dim file As StreamReader
        file = New StreamReader(Abrir1.FileName)
        TAnalizar1.Text = file.ReadToEnd
        file.Close()
        TAnalizar1.Select(1, 0)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As ComponentModel.CancelEventArgs) Handles Abrir1.FileOk

    End Sub

    Private Sub CargarArchivoJSONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarArchivoJSONToolStripMenuItem.Click
        Abrir2.Filter = "Archivos.JSON|*.json"
        Abrir2.ShowDialog()
        Dim file As StreamReader
        file = New StreamReader(Abrir2.FileName)
        TAnalizar2.Text = file.ReadToEnd
        file.Close()
        TAnalizar2.Select(1, 0)
    End Sub

    Private Sub GuardarArchvioXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarArchvioXMLToolStripMenuItem.Click
        Guardar1.Filter = "Archivos.XML|*.xml"
        Guardar1.OverwritePrompt = True
        Guardar1.Title = "Guardar Archivo"
        If (Guardar1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Dim SF As StreamWriter
            Dim FS As FileStream
            FS = New FileStream(Guardar1.FileName, FileMode.Create)
            SF = New StreamWriter(FS)
            SF.WriteLine(TAnalizar1.Text)
            SF.Close()
            FS.Close()

        End If
    End Sub

    Private Sub GuardarArchivoJSONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarArchivoJSONToolStripMenuItem.Click
        Guardar2.Filter = "Archivos.JSON|*.json"
        Guardar2.OverwritePrompt = True
        Guardar2.Title = "Guardar Archivo"
        If (Guardar2.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Dim SF As StreamWriter
            Dim FS As FileStream
            FS = New FileStream(Guardar2.FileName, FileMode.Create)
            SF = New StreamWriter(FS)
            SF.WriteLine(TAnalizar2.Text)
            SF.Close()
            FS.Close()

        End If
    End Sub

    Private Sub GenerarGrafoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarGrafoToolStripMenuItem.Click

    End Sub
End Class
