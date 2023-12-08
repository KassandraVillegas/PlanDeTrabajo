<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datos_r
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
        TextBox1 = New TextBox()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        Button1 = New Button()
        fecha = New DateTimePicker()
        Label6 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DateTimePicker2 = New DateTimePicker()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(203, 120)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(333, 27)
        TextBox1.TabIndex = 39
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(22, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(181, 20)
        Label5.TabIndex = 38
        Label5.Text = "Folio único de búsqueda:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(114, 178)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(273, 27)
        DateTimePicker1.TabIndex = 37
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 20)
        Label3.TabIndex = 36
        Label3.Text = "Fecha Inicio:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(665, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 35)
        Button1.TabIndex = 35
        Button1.Text = "Siguiente"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' fecha
        ' 
        fecha.Location = New Point(78, 65)
        fecha.Name = "fecha"
        fecha.Size = New Size(266, 27)
        fecha.TabIndex = 34
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(22, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 33
        Label6.Text = "Fecha:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(543, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(230, 20)
        Label2.TabIndex = 32
        Label2.Text = "BÚSQUEDA INDIVIDUALIZADA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(300, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(476, 20)
        Label1.TabIndex = 31
        Label1.Text = "DEPARTAMENTO ESPECIALIZADO DE BÚSQUEDA DE LARGA DATA"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.AccessibleRole = AccessibleRole.MenuBar
        DateTimePicker2.Location = New Point(517, 180)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(273, 27)
        DateTimePicker2.TabIndex = 41
        ' 
        ' Label4
        ' 
        Label4.AccessibleRole = AccessibleRole.MenuBar
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(404, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 40
        Label4.Text = "Fecha Termino:"
        ' 
        ' datos_r
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LemonChiffon
        ClientSize = New Size(811, 351)
        Controls.Add(DateTimePicker2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(fecha)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "datos_r"
        Text = "datos_r"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
