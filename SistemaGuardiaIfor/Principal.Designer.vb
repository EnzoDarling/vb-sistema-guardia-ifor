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
        Me.Label2 = New System.Windows.Forms.Label
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdpersonalDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdfuncionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdturnosDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaguardiaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotificadoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip
        Me.ApellidoToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.ApellidoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.BdguardiaiforPersonal = New SistemaGuardiaIfor.bdguardiaiforPersonal
        Me.PersonalTableAdapter = New SistemaGuardiaIfor.bdguardiaiforPersonalTableAdapters.personalTableAdapter
        Me.GuardiasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuardiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdguardiaiforPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuardiasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuardiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaGuardiaToolStripMenuItem, Me.PersonalEstToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.ConvertirToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1521, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevaGuardiaToolStripMenuItem
        '
        Me.NuevaGuardiaToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevaGuardiaToolStripMenuItem.Name = "NuevaGuardiaToolStripMenuItem"
        Me.NuevaGuardiaToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.NuevaGuardiaToolStripMenuItem.Text = "&Nueva Guardia"
        '
        'PersonalEstToolStripMenuItem
        '
        Me.PersonalEstToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalEstToolStripMenuItem.Name = "PersonalEstToolStripMenuItem"
        Me.PersonalEstToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.PersonalEstToolStripMenuItem.Text = "Gestionar &Personal"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.UsuariosToolStripMenuItem.Text = "Gestionar &Usuarios"
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
        Me.ImprimirToolStripMenuItem.Text = "&Imprimir"
        '
        'ConvertirToolStripMenuItem
        '
        Me.ConvertirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem, Me.PDFToolStripMenuItem})
        Me.ConvertirToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConvertirToolStripMenuItem.Name = "ConvertirToolStripMenuItem"
        Me.ConvertirToolStripMenuItem.Size = New System.Drawing.Size(98, 26)
        Me.ConvertirToolStripMenuItem.Text = "&Convertir"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
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
        Me.AyudaToolStripMenuItem.Text = "&Ayuda"
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
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar"
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = "asd"
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(124, 20)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 35)
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
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(657, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lista de Guardia"
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        '
        'IdpersonalDataGridViewTextBoxColumn2
        '
        Me.IdpersonalDataGridViewTextBoxColumn2.Name = "IdpersonalDataGridViewTextBoxColumn2"
        '
        'IdfuncionDataGridViewTextBoxColumn2
        '
        Me.IdfuncionDataGridViewTextBoxColumn2.Name = "IdfuncionDataGridViewTextBoxColumn2"
        '
        'IdturnosDataGridViewTextBoxColumn2
        '
        Me.IdturnosDataGridViewTextBoxColumn2.Name = "IdturnosDataGridViewTextBoxColumn2"
        '
        'FechaguardiaDataGridViewTextBoxColumn2
        '
        Me.FechaguardiaDataGridViewTextBoxColumn2.Name = "FechaguardiaDataGridViewTextBoxColumn2"
        '
        'NotificadoDataGridViewTextBoxColumn2
        '
        Me.NotificadoDataGridViewTextBoxColumn2.Name = "NotificadoDataGridViewTextBoxColumn2"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApellidoToolStripLabel, Me.ApellidoToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 31)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1480, 31)
        Me.FillByToolStrip.TabIndex = 7
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'ApellidoToolStripLabel
        '
        Me.ApellidoToolStripLabel.Name = "ApellidoToolStripLabel"
        Me.ApellidoToolStripLabel.Size = New System.Drawing.Size(67, 28)
        Me.ApellidoToolStripLabel.Text = "apellido:"
        '
        'ApellidoToolStripTextBox
        '
        Me.ApellidoToolStripTextBox.Name = "ApellidoToolStripTextBox"
        Me.ApellidoToolStripTextBox.Size = New System.Drawing.Size(132, 31)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 28)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(16, 155)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1472, 607)
        Me.Panel1.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 155)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1436, 444)
        Me.DataGridView1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(588, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(311, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sistema de Guardia IFOR"
        '
        'BdguardiaiforPersonal
        '
        Me.BdguardiaiforPersonal.DataSetName = "bdguardiaiforPersonal"
        Me.BdguardiaiforPersonal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonalTableAdapter
        '
        Me.PersonalTableAdapter.ClearBeforeFill = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1521, 769)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Principal"
        Me.Text = "Sistema de Guardia IFOR"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdguardiaiforPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuardiasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuardiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdpersonalDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdfuncionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdturnosDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaguardiaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotificadoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuardiasBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BdguardiaiforPersonal As SistemaGuardiaIfor.bdguardiaiforPersonal
    Friend WithEvents PersonalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonalTableAdapter As SistemaGuardiaIfor.bdguardiaiforPersonalTableAdapters.personalTableAdapter
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ApellidoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ApellidoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GuardiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdpersonalDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdfuncionDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdturnosDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaguardiaDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotificadoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
