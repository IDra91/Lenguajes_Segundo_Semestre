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
        Me.TAnalizar1 = New System.Windows.Forms.RichTextBox()
        Me.TAnalizar2 = New System.Windows.Forms.RichTextBox()
        Me.BotonAnalizar = New System.Windows.Forms.Button()
        Me.BotonJSON = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarArchivoXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarArchivoJSONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarArchvioXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarArchivoJSONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPáginaHTMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarGrafoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Abrir1 = New System.Windows.Forms.OpenFileDialog()
        Me.Abrir2 = New System.Windows.Forms.OpenFileDialog()
        Me.Guardar1 = New System.Windows.Forms.SaveFileDialog()
        Me.Guardar2 = New System.Windows.Forms.SaveFileDialog()
        Me.GenerarGrafo2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TAnalizar1
        '
        Me.TAnalizar1.Location = New System.Drawing.Point(21, 39)
        Me.TAnalizar1.Name = "TAnalizar1"
        Me.TAnalizar1.Size = New System.Drawing.Size(220, 151)
        Me.TAnalizar1.TabIndex = 0
        Me.TAnalizar1.Text = ""
        '
        'TAnalizar2
        '
        Me.TAnalizar2.Location = New System.Drawing.Point(285, 39)
        Me.TAnalizar2.Name = "TAnalizar2"
        Me.TAnalizar2.Size = New System.Drawing.Size(220, 151)
        Me.TAnalizar2.TabIndex = 1
        Me.TAnalizar2.Text = ""
        '
        'BotonAnalizar
        '
        Me.BotonAnalizar.Location = New System.Drawing.Point(128, 208)
        Me.BotonAnalizar.Name = "BotonAnalizar"
        Me.BotonAnalizar.Size = New System.Drawing.Size(113, 23)
        Me.BotonAnalizar.TabIndex = 2
        Me.BotonAnalizar.Text = "¡Analizar XML!"
        Me.BotonAnalizar.UseVisualStyleBackColor = True
        '
        'BotonJSON
        '
        Me.BotonJSON.Location = New System.Drawing.Point(269, 208)
        Me.BotonJSON.Name = "BotonJSON"
        Me.BotonJSON.Size = New System.Drawing.Size(122, 23)
        Me.BotonJSON.TabIndex = 3
        Me.BotonJSON.Text = "¡Analizar JSON!"
        Me.BotonJSON.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem, Me.GenerarToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(553, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarArchivoXMLToolStripMenuItem, Me.CargarArchivoJSONToolStripMenuItem, Me.GuardarArchvioXMLToolStripMenuItem, Me.GuardarArchivoJSONToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'CargarArchivoXMLToolStripMenuItem
        '
        Me.CargarArchivoXMLToolStripMenuItem.Name = "CargarArchivoXMLToolStripMenuItem"
        Me.CargarArchivoXMLToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.CargarArchivoXMLToolStripMenuItem.Text = "Cargar Archivo XML"
        '
        'CargarArchivoJSONToolStripMenuItem
        '
        Me.CargarArchivoJSONToolStripMenuItem.Name = "CargarArchivoJSONToolStripMenuItem"
        Me.CargarArchivoJSONToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.CargarArchivoJSONToolStripMenuItem.Text = "Cargar Archivo JSON"
        '
        'GuardarArchvioXMLToolStripMenuItem
        '
        Me.GuardarArchvioXMLToolStripMenuItem.Name = "GuardarArchvioXMLToolStripMenuItem"
        Me.GuardarArchvioXMLToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GuardarArchvioXMLToolStripMenuItem.Text = "Guardar Archivo XML"
        '
        'GuardarArchivoJSONToolStripMenuItem
        '
        Me.GuardarArchivoJSONToolStripMenuItem.Name = "GuardarArchivoJSONToolStripMenuItem"
        Me.GuardarArchivoJSONToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GuardarArchivoJSONToolStripMenuItem.Text = "Guardar Archivo JSON"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "XML"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "JSON"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarPáginaHTMLToolStripMenuItem, Me.GenerarGrafoToolStripMenuItem, Me.GenerarGrafo2ToolStripMenuItem})
        Me.GenerarToolStripMenuItem.Name = "GenerarToolStripMenuItem"
        Me.GenerarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.GenerarToolStripMenuItem.Text = "Generar"
        '
        'GenerarPáginaHTMLToolStripMenuItem
        '
        Me.GenerarPáginaHTMLToolStripMenuItem.Name = "GenerarPáginaHTMLToolStripMenuItem"
        Me.GenerarPáginaHTMLToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.GenerarPáginaHTMLToolStripMenuItem.Text = "Generar página HTML"
        '
        'GenerarGrafoToolStripMenuItem
        '
        Me.GenerarGrafoToolStripMenuItem.Name = "GenerarGrafoToolStripMenuItem"
        Me.GenerarGrafoToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.GenerarGrafoToolStripMenuItem.Text = "Generar Grafo1"
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
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'Abrir1
        '
        Me.Abrir1.FileName = "Abrir1"
        Me.Abrir1.Title = "Abrir1"
        '
        'Abrir2
        '
        Me.Abrir2.FileName = "OpenFileDialog1"
        '
        'GenerarGrafo2ToolStripMenuItem
        '
        Me.GenerarGrafo2ToolStripMenuItem.Name = "GenerarGrafo2ToolStripMenuItem"
        Me.GenerarGrafo2ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.GenerarGrafo2ToolStripMenuItem.Text = "Generar Grafo 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 258)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BotonJSON)
        Me.Controls.Add(Me.BotonAnalizar)
        Me.Controls.Add(Me.TAnalizar2)
        Me.Controls.Add(Me.TAnalizar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Analizador de Palabras"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TAnalizar1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TAnalizar2 As System.Windows.Forms.RichTextBox
    Friend WithEvents BotonAnalizar As System.Windows.Forms.Button
    Friend WithEvents BotonJSON As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarArchivoXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarArchivoJSONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarArchvioXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarArchivoJSONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPáginaHTMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarGrafoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Abrir1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Abrir2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Guardar1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Guardar2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GenerarGrafo2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
