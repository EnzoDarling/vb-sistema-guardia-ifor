<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.NuevaGuardiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonalEstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerListaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConvertirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InstructivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdpersonalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdfuncionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdturnosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaguardiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotificadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdpersonalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdfuncionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdturnosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaguardiaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotificadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Jerarquia = New System.Windows.Forms.ColumnHeader
        Me.Apellido = New System.Windows.Forms.ColumnHeader
        Me.Nombre = New System.Windows.Forms.ColumnHeader
        Me.Turno = New System.Windows.Forms.ColumnHeader
        Me.Fecha = New System.Windows.Forms.ColumnHeader
        Me.Funcion = New System.Windows.Forms.ColumnHeader
        Me.GuardiasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GuardiasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaGuardiaToolStripMenuItem, Me.PersonalEstToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.ConvertirToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevaGuardiaToolStripMenuItem
        '
        Me.NuevaGuardiaToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevaGuardiaToolStripMenuItem.Name = "NuevaGuardiaToolStripMenuItem"
        Me.NuevaGuardiaToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.NuevaGuardiaToolStripMenuItem.Text = "Nueva Guardia"
        '
        'PersonalEstToolStripMenuItem
        '
        Me.PersonalEstToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerListaToolStripMenuItem, Me.VerListaToolStripMenuItem1})
        Me.PersonalEstToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalEstToolStripMenuItem.Name = "PersonalEstToolStripMenuItem"
        Me.PersonalEstToolStripMenuItem.Size = New System.Drawing.Size(97, 26)
        Me.PersonalEstToolStripMenuItem.Text = "Personal"
        '
        'VerListaToolStripMenuItem
        '
        Me.VerListaToolStripMenuItem.Name = "VerListaToolStripMenuItem"
        Me.VerListaToolStripMenuItem.Size = New System.Drawing.Size(228, 26)
        Me.VerListaToolStripMenuItem.Text = "Agregar Personal"
        '
        'VerListaToolStripMenuItem1
        '
        Me.VerListaToolStripMenuItem1.Name = "VerListaToolStripMenuItem1"
        Me.VerListaToolStripMenuItem1.Size = New System.Drawing.Size(228, 26)
        Me.VerListaToolStripMenuItem1.Text = "Ver Lista"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(96, 26)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ListaToolStripMenuItem
        '
        Me.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        Me.ListaToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.ListaToolStripMenuItem.Text = "Gestionar"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(91, 26)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ConvertirToolStripMenuItem
        '
        Me.ConvertirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem, Me.PDFToolStripMenuItem})
        Me.ConvertirToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConvertirToolStripMenuItem.Name = "ConvertirToolStripMenuItem"
        Me.ConvertirToolStripMenuItem.Size = New System.Drawing.Size(98, 26)
        Me.ConvertirToolStripMenuItem.Text = "Convertir"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(127, 26)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'PDFToolStripMenuItem
        '
        Me.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem"
        Me.PDFToolStripMenuItem.Size = New System.Drawing.Size(127, 26)
        Me.PDFToolStripMenuItem.Text = "PDF"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructivoToolStripMenuItem, Me.InformacionToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(75, 26)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'InstructivoToolStripMenuItem
        '
        Me.InstructivoToolStripMenuItem.Name = "InstructivoToolStripMenuItem"
        Me.InstructivoToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.InstructivoToolStripMenuItem.Text = "Instructivo"
        '
        'InformacionToolStripMenuItem
        '
        Me.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem"
        Me.InformacionToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.InformacionToolStripMenuItem.Text = "Informacion"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar"
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = "asd"
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(118, 88)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 36)
        Me.TextBox1.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'IdpersonalDataGridViewTextBoxColumn
        '
        Me.IdpersonalDataGridViewTextBoxColumn.Name = "IdpersonalDataGridViewTextBoxColumn"
        '
        'IdfuncionDataGridViewTextBoxColumn
        '
        Me.IdfuncionDataGridViewTextBoxColumn.Name = "IdfuncionDataGridViewTextBoxColumn"
        '
        'IdturnosDataGridViewTextBoxColumn
        '
        Me.IdturnosDataGridViewTextBoxColumn.Name = "IdturnosDataGridViewTextBoxColumn"
        '
        'FechaguardiaDataGridViewTextBoxColumn
        '
        Me.FechaguardiaDataGridViewTextBoxColumn.Name = "FechaguardiaDataGridViewTextBoxColumn"
        '
        'NotificadoDataGridViewTextBoxColumn
        '
        Me.NotificadoDataGridViewTextBoxColumn.Name = "NotificadoDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        '
        'IdpersonalDataGridViewTextBoxColumn1
        '
        Me.IdpersonalDataGridViewTextBoxColumn1.Name = "IdpersonalDataGridViewTextBoxColumn1"
        '
        'IdfuncionDataGridViewTextBoxColumn1
        '
        Me.IdfuncionDataGridViewTextBoxColumn1.Name = "IdfuncionDataGridViewTextBoxColumn1"
        '
        'IdturnosDataGridViewTextBoxColumn1
        '
        Me.IdturnosDataGridViewTextBoxColumn1.Name = "IdturnosDataGridViewTextBoxColumn1"
        '
        'FechaguardiaDataGridViewTextBoxColumn1
        '
        Me.FechaguardiaDataGridViewTextBoxColumn1.Name = "FechaguardiaDataGridViewTextBoxColumn1"
        '
        'NotificadoDataGridViewTextBoxColumn1
        '
        Me.NotificadoDataGridViewTextBoxColumn1.Name = "NotificadoDataGridViewTextBoxColumn1"
        '
        'ListView1
        '
        Me.ListView1.AccessibleName = ""
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Jerarquia, Me.Apellido, Me.Nombre, Me.Turno, Me.Fecha, Me.Funcion})
        Me.ListView1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ListView1.Location = New System.Drawing.Point(16, 162)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1039, 402)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Jerarquia
        '
        Me.Jerarquia.DisplayIndex = 1
        '
        'Apellido
        '
        Me.Apellido.DisplayIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(460, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lista de Guardia"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 582)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Principal"
        Me.Text = "Sistema de Guardia IFOR"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GuardiasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NuevaGuardiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalEstToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdpersonalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdfuncionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdturnosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaguardiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotificadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerListaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdpersonalDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdfuncionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdturnosDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaguardiaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotificadoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuardiasBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Jerarquia As System.Windows.Forms.ColumnHeader
    Friend WithEvents Apellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Turno As System.Windows.Forms.ColumnHeader
    Friend WithEvents ExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Fecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents Funcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
