Imports System.Data.OleDb
Imports System.IO
Public Class Usuarios
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Enzo\Github\vb-sistema-guardia-ifor\bdguardiaifor.mdb")
    Dim dr As OleDbDataReader
    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            ToolStripLabel1.Text = "Conectado"
            ToolStripLabel1.ForeColor = Color.Green
        Catch ex As Exception
            ToolStripLabel1.Text = "Desconectado"
            ToolStripLabel1.ForeColor = Color.Red
        End Try
        conn.Close()
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("SELECT * FROM usuarios", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("apellido"), dr.Item("nombre"), dr.Item("usuario"), dr.Item("clave"), dr.Item("rol_id"))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class