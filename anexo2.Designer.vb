<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class anexo2
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
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        NuevoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        AbrirToolStripMenuItem = New ToolStripMenuItem()
        GuardarComoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        DeshacerToolStripMenuItem = New ToolStripMenuItem()
        RehacerToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        CortarToolStripMenuItem = New ToolStripMenuItem()
        PegarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        SeleccionarTodoToolStripMenuItem = New ToolStripMenuItem()
        DeseleccionarTodoToolStripMenuItem = New ToolStripMenuItem()
        FuenteToolStripMenuItem = New ToolStripMenuItem()
        TamañoDeFuenteToolStripMenuItem = New ToolStripMenuItem()
        File = New RichTextBox()
        Button1 = New Button()
        Button2 = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdiciónToolStripMenuItem, FuenteToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(844, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.BackColor = Color.Gold
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NuevoToolStripMenuItem, ToolStripSeparator1, AbrirToolStripMenuItem, GuardarComoToolStripMenuItem, ToolStripSeparator2, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(76, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' NuevoToolStripMenuItem
        ' 
        NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        NuevoToolStripMenuItem.Size = New Size(190, 26)
        NuevoToolStripMenuItem.Text = "Nuevo"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(187, 6)
        ' 
        ' AbrirToolStripMenuItem
        ' 
        AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        AbrirToolStripMenuItem.Size = New Size(190, 26)
        AbrirToolStripMenuItem.Text = "Abrir"
        ' 
        ' GuardarComoToolStripMenuItem
        ' 
        GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        GuardarComoToolStripMenuItem.Size = New Size(190, 26)
        GuardarComoToolStripMenuItem.Text = "Guardar como"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(187, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(190, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.BackColor = Color.Gold
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DeshacerToolStripMenuItem, RehacerToolStripMenuItem, ToolStripSeparator3, CopiarToolStripMenuItem, CortarToolStripMenuItem, PegarToolStripMenuItem, ToolStripSeparator4, SeleccionarTodoToolStripMenuItem, DeseleccionarTodoToolStripMenuItem})
        EdiciónToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(73, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' DeshacerToolStripMenuItem
        ' 
        DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        DeshacerToolStripMenuItem.Size = New Size(223, 26)
        DeshacerToolStripMenuItem.Text = "Deshacer"
        ' 
        ' RehacerToolStripMenuItem
        ' 
        RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        RehacerToolStripMenuItem.Size = New Size(223, 26)
        RehacerToolStripMenuItem.Text = "Rehacer"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(220, 6)
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(223, 26)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' CortarToolStripMenuItem
        ' 
        CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        CortarToolStripMenuItem.Size = New Size(223, 26)
        CortarToolStripMenuItem.Text = "Cortar"
        ' 
        ' PegarToolStripMenuItem
        ' 
        PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        PegarToolStripMenuItem.Size = New Size(223, 26)
        PegarToolStripMenuItem.Text = "Pegar"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(220, 6)
        ' 
        ' SeleccionarTodoToolStripMenuItem
        ' 
        SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        SeleccionarTodoToolStripMenuItem.Size = New Size(223, 26)
        SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        ' 
        ' DeseleccionarTodoToolStripMenuItem
        ' 
        DeseleccionarTodoToolStripMenuItem.Name = "DeseleccionarTodoToolStripMenuItem"
        DeseleccionarTodoToolStripMenuItem.Size = New Size(223, 26)
        DeseleccionarTodoToolStripMenuItem.Text = "Deseleccionar todo"
        ' 
        ' FuenteToolStripMenuItem
        ' 
        FuenteToolStripMenuItem.BackColor = Color.Gold
        FuenteToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TamañoDeFuenteToolStripMenuItem})
        FuenteToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        FuenteToolStripMenuItem.Size = New Size(70, 24)
        FuenteToolStripMenuItem.Text = "Fuente"
        ' 
        ' TamañoDeFuenteToolStripMenuItem
        ' 
        TamañoDeFuenteToolStripMenuItem.Name = "TamañoDeFuenteToolStripMenuItem"
        TamañoDeFuenteToolStripMenuItem.Size = New Size(215, 26)
        TamañoDeFuenteToolStripMenuItem.Text = "Tamaño de fuente"
        ' 
        ' File
        ' 
        File.Dock = DockStyle.Fill
        File.Location = New Point(0, 28)
        File.Name = "File"
        File.Size = New Size(844, 458)
        File.TabIndex = 1
        File.Text = ""
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(26, 445)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Anterior"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(729, 445)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 3
        Button2.Text = "Siguiente"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' anexo2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(844, 486)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(File)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "anexo2"
        Text = "anexo2"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeseleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TamañoDeFuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents File As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
