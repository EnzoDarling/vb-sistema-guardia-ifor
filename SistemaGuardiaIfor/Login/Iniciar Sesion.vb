Imports System.Data.OleDb
Imports System.IO
Public Class LoginForm1
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Enzo\Github\vb-sistema-guardia-ifor\bdguardiaifor.mdb")

    Sub Limpiar()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = Nothing Or PasswordTextBox.Text = Nothing Then
            MsgBox("Ingrese su usuario y contraseña para ingresar", MsgBoxStyle.Exclamation)
        Else
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand("SELECT count(*) FROM usuarios WHERE usuario=@Usuario and clave=@Pass", conn)
            cmd.Parameters.AddWithValue("@Usuario", OleDbType.VarChar).Value = UsernameTextBox.Text
            cmd.Parameters.AddWithValue("@Pass", OleDbType.VarChar).Value = PasswordTextBox.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                Me.Hide()
                Principal.Show()
            Else
                MsgBox("Ingreso un Usuario o una Clave incorrecto", MsgBoxStyle.Critical)
            End If

        End If
    End Sub
End Class
