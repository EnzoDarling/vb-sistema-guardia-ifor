﻿Imports System.Data.OleDb
Imports System.IO
Public Class Usuarios
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Enzo\Github\vb-sistema-guardia-ifor\bdguardiaifor.mdb")
    Dim dr As OleDbDataReader
    Dim i, rolval, roltabla, IdVal As Integer
    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            ToolStripLabel2.Text = "Conectado"
            ToolStripLabel2.ForeColor = Color.Green
        Catch ex As Exception
            ToolStripLabel2.Text = "Desconectado"
            ToolStripLabel2.ForeColor = Color.Red
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
                DataGridView1.Rows.Add(dr.Item("IdUsuario"), dr.Item("apellido"), dr.Item("nombre"), dr.Item("usuario"), dr.Item("clave"), dr.Item("rol_id"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, MsgBoxStyle.Critical)
        End Try
        conn.Close()
        Limpiar()
    End Sub
    Sub Limpiar()
        txtApellido.Clear()
        txtNombre.Clear()
        txtUsuario.Clear()
        txtClave.Clear()
        rdAdmin.Checked = False
        rdCargador.Checked = False
        rdSupervisor.Checked = False
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
                MsgBox("Se guardo el usuario con exito!", vbInformation, MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error al guardar", vbCritical, MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, MsgBoxStyle.Critical)
        End Try
        conn.Close()
    End Sub
    Sub Modificar()
        If MsgBox("Se va a eliminar un usuario del sistema ¿Está seguro de eliminar el usuario?", vbQuestion + vbYesNo) = vbYes Then
            If rdAdmin.Checked = True Then
                rolval = 1
            ElseIf rdSupervisor.Checked - True Then
                rolval = 2
            ElseIf rdCargador.Checked = True Then
                rolval = 3
            End If
            IdVal = CInt(txtId.Text)
            conn.Open()
            Dim command As String
            command = "UPDATE usuarios SET `apellido`=@Apellido,`nombre`=@Nombre,`usuario`=@Usuario,`clave`=@Clave,`rol_id`=@Rol WHERE `IdUsuario`=@Id"
            Dim cmd As OleDbCommand = New OleDbCommand(command, conn)
            Try
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Id", IdVal)
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text)
                cmd.Parameters.AddWithValue("@Clave", txtClave.Text)
                cmd.Parameters.AddWithValue("@Rol", rolval)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        mostrarDatos()
        Limpiar()
    End Sub
    
    Sub Eliminar()
        Try
            If MsgBox("Se va a eliminar un usuario del sistema ¿Está seguro de eliminar el usuario?", vbQuestion + vbYesNo) = vbYes Then
                conn.Open()
                Dim cmd As New OleDb.OleDbCommand("DELETE FROM usuarios WHERE IdUsuario=@Id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Id", txtId.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Se elimino el usuario con exito!", vbInformation, MsgBoxStyle.Information)
                Else
                    MsgBox("Hubo un error al eliminar", vbCritical, MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, MsgBoxStyle.Critical)
        End Try
        conn.Close()
        mostrarDatos()
        Limpiar()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Guardar()
        mostrarDatos()
        Limpiar()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Limpiar()
        roltabla = 0
        txtId.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtApellido.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtNombre.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtUsuario.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtClave.Text = DataGridView1.CurrentRow.Cells(4).Value
        roltabla = DataGridView1.CurrentRow.Cells(5).Value
        If roltabla = 1 Then
            rdAdmin.Checked = True
        ElseIf roltabla = 2 Then
            rdSupervisor.Checked = True
        ElseIf roltabla = 3 Then
            rdCargador.Checked = True
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Eliminar()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Modificar()
    End Sub
End Class