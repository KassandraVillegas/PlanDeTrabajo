Public Class anexo2
    Private Sub anexo2_Load_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        File.Clear()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim FileDialog As New OpenFileDialog
        Dim FileReader As System.IO.StreamReader
        FileDialog.Filter = "Documento de texto|*.txt|Visual Basic Script|*vbs|Todos los documentos|*.*"
        FileDialog.CheckFileExists = True
        FileDialog.Title = "Abrir"
        FileDialog.ShowDialog(Me)
        Try
            FileDialog.OpenFile()
            FileReader = System.IO.File.OpenText(FileDialog.FileName)
            File.Text = FileReader.ReadToEnd()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim SaveDialog As New SaveFileDialog
        Dim SaveWriter As System.IO.StreamWriter
        SaveDialog.Filter = "Documento de texto|*.txt|Visual Basic Script|*vbs|Todos los documentos|*.*"
        SaveDialog.Title = "Guardar como"
        SaveDialog.ShowDialog(Me)
        Try
            SaveWriter = System.IO.File.AppendText(SaveDialog.FileName)
            SaveWriter.Write(File.Text)
            SaveWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        File.Undo()
    End Sub

    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
        File.Undo()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        File.Copy()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        File.Cut()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        File.Paste()
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        File.SelectAll()
    End Sub

    Private Sub DeseleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeseleccionarTodoToolStripMenuItem.Click
        File.DeselectAll()
    End Sub

    Private Sub TamañoDeFuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TamañoDeFuenteToolStripMenuItem.Click
        Try
            Dim FontDialog As FontDialog = New FontDialog
            FontDialog.Font = File.Font
            If FontDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                File.Font = FontDialog.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        colectivos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        datos_r.Show()
    End Sub
End Class