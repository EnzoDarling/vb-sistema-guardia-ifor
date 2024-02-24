'IMPORTANDO LIBRERIAS
Imports System.Data.OleDb
Imports System.IO
Public Class NuevoUsuario
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Enzo\Github\vb-sistema-guardia-ifor\bdguardiaifor.mdb")
    Dim i, rolval As Integer
    Private Sub NuevoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            ToolStripLabel1.Text = "Conectado"
            ToolStripLabel1.ForeColor = Color.Green
        Catch ex As Exception
            ToolStripLabel1.Text = "Desconectado"
            ToolStripLabel1.ForeColor = Color.Red
        End Try
        conn.Close()
        Limpiar()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Guardar()
    End Sub
    Sub Limpiar()
        txtApellido.Clear()
        txtNombre.Clear()
        txtUsuario.Clear()
        txtClave.Clear()
    End Sub
    Sub Guardar()
        If rdAdmin.Checked = True Then
            rolval = 1
        ElseIf rdSupervisor.Checked - True Then
            rolval = 2
        ElseIf rdCargador.Checked = True Then
            rolval = 3
        End If
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("INSERT INTO usuarios(`apellido`,`nombre`,`usuario`,`clave`,`rol_id`) values (@Apellido,@Nombre,@Usuario,@Clave,@Rol)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text)
            cmd.Parameters.AddWithValue("@Clave", txtClave.Text)
            cmd.Parameters.AddWithValue("@Rol", rolval)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Se guardo el usuario con exito!")
            Else
                MessageBox.Show("Hubo un error al guardar")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class