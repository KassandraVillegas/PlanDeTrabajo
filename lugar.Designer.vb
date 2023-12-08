<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lugar
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
        Label2 = New Label()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        TextBox5 = New TextBox()
        Label8 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 25)
        Label2.TabIndex = 1
        Label2.Text = "Datos del Lugar"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox8)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Location = New Point(402, 53)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(347, 254)
        Panel1.TabIndex = 29
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(148, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(134, 27)
        TextBox1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(88, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 7
        Label1.Text = "Banda:"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(148, 164)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(134, 27)
        TextBox8.TabIndex = 6
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(148, 119)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(134, 27)
        TextBox7.TabIndex = 5
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(148, 43)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(134, 27)
        TextBox6.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(3, 171)
        Label12.Name = "Label12"
        Label12.Size = New Size(141, 20)
        Label12.TabIndex = 3
        Label12.Text = "Coordenada Norte:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(17, 122)
        Label11.Name = "Label11"
        Label11.Size = New Size(128, 20)
        Label11.TabIndex = 2
        Label11.Text = "Coordenada Este:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(94, 46)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 20)
        Label10.TabIndex = 1
        Label10.Text = "Zona:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(104, 7)
        Label9.Name = "Label9"
        Label9.Size = New Size(154, 23)
        Label9.TabIndex = 0
        Label9.Text = "Coordena en UTM"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(108, 63)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(259, 27)
        TextBox5.TabIndex = 28
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(35, 66)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 20)
        Label8.TabIndex = 27
        Label8.Text = "Extensión:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(35, 333)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 30
        Button1.Text = "Anterior"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(631, 333)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 31
        Button2.Text = "Siguiente"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lugar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LemonChiffon
        ClientSize = New Size(764, 386)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(TextBox5)
        Controls.Add(Label8)
        Controls.Add(Label2)
        Name = "lugar"
        Text = "lugar"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
