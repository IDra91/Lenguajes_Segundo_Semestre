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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.BotonAnalizar = New System.Windows.Forms.Button()
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
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(285, 39)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(220, 151)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'BotonAnalizar
        '
        Me.BotonAnalizar.Location = New System.Drawing.Point(185, 218)
        Me.BotonAnalizar.Name = "BotonAnalizar"
        Me.BotonAnalizar.Size = New System.Drawing.Size(75, 23)
        Me.BotonAnalizar.TabIndex = 2
        Me.BotonAnalizar.Text = "¡Analizar!"
        Me.BotonAnalizar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 258)
        Me.Controls.Add(Me.BotonAnalizar)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TAnalizar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TAnalizar1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents BotonAnalizar As System.Windows.Forms.Button

End Class
