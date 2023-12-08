

Public Class in_datos
    ' Cadena de conexión a la base de datos
    'Dim connectionString As String = "Server=localhost;Database=android_db;user=root;pwd=123456;"

    ' Crear objeto de conexión
    'Dim myCon As New MySqlConnection(connectionString)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        lugar.Show()

        'Dim query = "insert into busqueda " &
        '   "(nombre,folio,folder,titulo)" &
        '  "('" & nombre.Text & "','" & folio.Text & "','" & carpeta.Text & "','" & titulo.Text & "')"
        'Dim comando = New MySqlCommand(query, myCon)
        'Try
        'Dim reader = comando.ExecuteReader()
        'reader.Close()
        'Catch ex As Exception

        'Console.WriteLine($"Error de conexión: {ex.Message}")
        'End Try
    End Sub

    Private Sub in_datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        'myCon.Open()
        ' Ahora puedes ejecutar consultas u otras operaciones en la base de datos
        'Catch ex As Exception
        'MessageBox.Show($"Error de conexión: {ex.Message}")
        'End Try
    End Sub
End Class