Public Class Graphviz
    Public Sub New(ruta As String)
        Dim grapho As New Process

        grapho.StartInfo.FileName = "C:\Program Files (x86)\Graphviz 2.28\bin\dot.exe"
        grapho.StartInfo.Arguments = "-Tpng -o""C:\Users\Manuel\Documents\imagen1.png"" " + """" + ruta + """"
        grapho.Start()

    End Sub
End Class
