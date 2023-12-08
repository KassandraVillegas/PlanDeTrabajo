<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class in_datos
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
        fecha = New DateTimePicker()
        Label6 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' fecha
        ' 
        fecha.Location = New Point(83, 53)
        fecha.Name = "fecha"
        fecha.Size = New Size(266, 27)
        fecha.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(27, 58)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 20
        Label6.Text = "Fecha:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(548, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(230, 20)
        Label2.TabIndex = 13
        Label2.Text = "BÚSQUEDA INDIVIDUALIZADA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(305, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(476, 20)
        Label1.TabIndex = 12
        Label1.Text = "DEPARTAMENTO ESPECIALIZADO DE BÚSQUEDA DE LARGA DATA"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(657, 309)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 35)
        Button1.TabIndex = 24
        Button1.Text = "Siguiente"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(23, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 20)
        Label3.TabIndex = 25
        Label3.Text = "Fecha Comisión:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(145, 163)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(273, 27)
        DateTimePicker1.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(27, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(181, 20)
        Label5.TabIndex = 29
        Label5.Text = "Folio único de búsqueda:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(208, 108)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(333, 27)
        TextBox1.TabIndex = 30
        ' 
        ' in_datos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LemonChiffon
        ClientSize = New Size(793, 361)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(fecha)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "in_datos"
        Text = "in_datos"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
