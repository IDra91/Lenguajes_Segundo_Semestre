<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextoAnalizar = New System.Windows.Forms.RichTextBox()
        Me.BotonAnalizar = New System.Windows.Forms.Button()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        Me.GenerarPagina = New System.Windows.Forms.Button()
        Me.GenerarGrafo = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(462, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirArchivoToolStripMenuItem, Me.GuardarArchivoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'AbrirArchivoToolStripMenuItem
        '
        Me.AbrirArchivoToolStripMenuItem.Name = "AbrirArchivoToolStripMenuItem"
        Me.AbrirArchivoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AbrirArchivoToolStripMenuItem.Text = "Abrir archivo"
        '
        'GuardarArchivoToolStripMenuItem
        '
        Me.GuardarArchivoToolStripMenuItem.Name = "GuardarArchivoToolStripMenuItem"
        Me.GuardarArchivoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.GuardarArchivoToolStripMenuItem.Text = "Guardar Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'TextoAnalizar
        '
        Me.TextoAnalizar.Location = New System.Drawing.Point(46, 36)
        Me.TextoAnalizar.Name = "TextoAnalizar"
        Me.TextoAnalizar.Size = New System.Drawing.Size(335, 128)
        Me.TextoAnalizar.TabIndex = 1
        Me.TextoAnalizar.Text = ""
        '
        'BotonAnalizar
        '
        Me.BotonAnalizar.Location = New System.Drawing.Point(147, 170)
        Me.BotonAnalizar.Name = "BotonAnalizar"
        Me.BotonAnalizar.Size = New System.Drawing.Size(75, 23)
        Me.BotonAnalizar.TabIndex = 2
        Me.BotonAnalizar.Text = "¡Analizar!"
        Me.BotonAnalizar.UseVisualStyleBackColor = True
        '
        'Abrir
        '
        Me.Abrir.FileName = "Abrir"
        '
        'GenerarPagina
        '
        Me.GenerarPagina.Location = New System.Drawing.Point(245, 170)
        Me.GenerarPagina.Name = "GenerarPagina"
        Me.GenerarPagina.Size = New System.Drawing.Size(116, 23)
        Me.GenerarPagina.TabIndex = 3
        Me.GenerarPagina.Text = "Generar HTML"
        Me.GenerarPagina.UseVisualStyleBackColor = True
        '
        'GenerarGrafo
        '
        Me.GenerarGrafo.Location = New System.Drawing.Point(46, 170)
        Me.GenerarGrafo.Name = "GenerarGrafo"
        Me.GenerarGrafo.Size = New System.Drawing.Size(95, 23)
        Me.GenerarGrafo.TabIndex = 4
        Me.GenerarGrafo.Text = "Generar Grafo"
        Me.GenerarGrafo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 237)
        Me.Controls.Add(Me.GenerarGrafo)
        Me.Controls.Add(Me.GenerarPagina)
        Me.Controls.Add(Me.BotonAnalizar)
        Me.Controls.Add(Me.TextoAnalizar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Generador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextoAnalizar As System.Windows.Forms.RichTextBox
    Friend WithEvents BotonAnalizar As System.Windows.Forms.Button
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GenerarPagina As System.Windows.Forms.Button
    Friend WithEvents GenerarGrafo As System.Windows.Forms.Button

End Class
