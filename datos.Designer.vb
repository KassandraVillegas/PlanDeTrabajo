<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class datos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        Label7 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label8 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(358, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(476, 20)
        Label1.TabIndex = 0
        Label1.Text = "DEPARTAMENTO ESPECIALIZADO DE BÚSQUEDA DE LARGA DATA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(174, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 20)
        Label3.TabIndex = 2
        Label3.Text = "Lugar de Búsqueda:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(334, 179)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(289, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(86, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(239, 20)
        Label4.TabIndex = 4
        Label4.Text = "Folio Expediente de Búsqueda (s):"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(334, 217)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(287, 27)
        TextBox2.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(122, 292)
        Label5.Name = "Label5"
        Label5.Size = New Size(201, 20)
        Label5.TabIndex = 6
        Label5.Text = "Carpeta (s) de Investigación:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(334, 291)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(289, 27)
        TextBox3.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(22, 80)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 8
        Label6.Text = "Fecha:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(78, 75)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(266, 27)
        DateTimePicker1.TabIndex = 9
        DateTimePicker1.Value = New Date(2023, 12, 7, 0, 0, 0, 0)
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(690, 384)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 36)
        Button1.TabIndex = 12
        Button1.Text = "Siguiente"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(27, 330)
        Label7.Name = "Label7"
        Label7.Size = New Size(300, 20)
        Label7.TabIndex = 13
        Label7.Text = "Nombre (s) de la persona desaparecida (s):"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(334, 327)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(289, 27)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(334, 253)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(289, 27)
        TextBox5.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(41, 254)
        Label8.Name = "Label8"
        Label8.Size = New Size(283, 20)
        Label8.TabIndex = 15
        Label8.Text = "Folio Único de Expediente Búsqueda (s):"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(187, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 20)
        Label2.TabIndex = 17
        Label2.Text = "Tipo de Búsqueda:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(334, 139)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 18
        ' 
        ' datos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LemonChiffon
        ClientSize = New Size(851, 435)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(TextBox5)
        Controls.Add(Label8)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "datos"
        Text = "datos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class

