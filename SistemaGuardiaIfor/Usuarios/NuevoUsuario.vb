'IMPORTANDO LIBRERIAS
Imports System.Data.OleDb


Public Class NuevoUsuario
    'DECLARACION DE VARIABLES DE CONEXION
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Private Sub NuevoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Enzo\Sistema Guardia IFOR\bdguardiaifor.mdb"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rol As Integer
        Dim apellido, nombre, usuario, clave As String
        apellido = Val(TextBox1.Text)
        nombre = Val(TextBox2.Text)
        usuario = Val(TextBox3.Text)
        clave = Val(TextBox4.Text)

        If IsNumeric(apellido) = True Or IsNumeric(nombre) = True Or IsNumeric(usuario) = True Or IsNumeric(clave) = True Then
            apellido.ToString()
            nombre.ToString()
            usuario.ToString()
            clave.ToString()
        Else
            apellido = 0
            nombre = 0
            usuario = 0
            clave = 0
        End If

        If RadioButton1.Checked = True Then
            rol = 1
        ElseIf RadioButton2.Checked = True Then
            rol = 2
        ElseIf RadioButton3.Checked = True Then
            rol = 3
        End If
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into usuarios(apellido,nombre,usuario,clave,rol_id)values('" + apellido + "', '" + nombre + "', '" + usuario + "', '" + clave + "','" + rol + "')"
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Se ha guardado el usuario con exito!", "Sistema de Guardia IFOR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class