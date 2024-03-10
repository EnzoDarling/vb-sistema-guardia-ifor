Imports System.Data.OleDb
Imports System.IO
Public Class Usuarios
    '-------------- DEFINICION DE VARIABLES --------------------
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Enzo\Github\vb-sistema-guardia-ifor\bdguardiaifor.mdb")
    Dim dr As OleDbDataReader
    Dim i, rolval, roltabla, IdVal As Integer
    '------------ COMPRUEBA CONEXION Y MUESTRA DATOS DESACTIVANDO CONTROLES ---------
    Private Sub Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DeshabilitarControles()
        DeshabilitarBotones()
        btnGuardar.Enabled = False
    End Sub
    '--------- DESHABILITAR CONTROLES -------------
    Sub DeshabilitarControles()
        txtApellido.Enabled = False
        txtNombre.Enabled = False
        txtUsuario.Enabled = False
        txtClave.Enabled = False
        rdAdmin.Enabled = False
        rdCargador.Enabled = False
        rdSupervisor.Enabled = False
    End Sub
    '--------- HABILITAR CONTROLES --------------
    Sub HabilitarControles()
        txtApellido.Enabled = True
        txtNombre.Enabled = True
        txtUsuario.Enabled = True
        txtClave.Enabled = True
        rdAdmin.Enabled = True
        rdCargador.Enabled = True
        rdSupervisor.Enabled = True
        btnGuardar.Enabled = True
        Limpiar()
    End Sub
    '--------- HABILITAR BOTONES ---------
    Sub HabilitarBotones()
        btnEliminar.Enabled = True
        btnModificar.Enabled = True
    End Sub
    '--------- DESHABILITAR BOTONES ---------
    Sub DeshabilitarBotones()
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
    End Sub

    Sub DeshabilitarBotonesNG()
        btnGuardar.Enabled = False
        btnNuevo.Enabled = False
    End Sub

    '--------- FUNCION MOSTRAR DATOS ---------
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
    '--------- FUNCION LIMPIAR ---------
    Sub Limpiar()
        txtApellido.Clear()
        txtNombre.Clear()
        txtUsuario.Clear()
        txtClave.Clear()
        rdAdmin.Checked = False
        rdCargador.Checked = False
        rdSupervisor.Checked = False
    End Sub
    '--------- FUNCION GUARDAR ---------
    Sub Guardar()
        If rdAdmin.Checked = True Then
            rolval = 1
        ElseIf rdSupervisor.Checked = True Then
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
    '--------- FUNCION MODIFICAR ---------
    Sub Modificar()
        If MsgBox("Se va a modificar un usuario del sistema ¿Está seguro de eliminar el usuario?", vbQuestion + vbYesNo) = vbYes Then
            If rdAdmin.Checked = True Then
                rolval = 1
            ElseIf rdSupervisor.Checked = True Then
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
    '--------- FUNCION ELIMINAR ---------
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
    '--------- BOTON GUARDAR ---------
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Guardar()
        mostrarDatos()
        Limpiar()
        DeshabilitarBotones()
        DeshabilitarControles()
        btnGuardar.Enabled = False
    End Sub
    '--------- FUNCION CLICK TABLA DATOS ---------
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim filaSelecIndice As DataGridViewRow
        filaSelecIndice = DataGridView1.Rows(e.RowIndex)
        HabilitarControles()
        roltabla = 0
        txtId.Text = filaSelecIndice.Cells(0).Value
        txtApellido.Text = filaSelecIndice.Cells(1).Value
        txtNombre.Text = filaSelecIndice.Cells(2).Value
        txtUsuario.Text = filaSelecIndice.Cells(3).Value
        txtClave.Text = filaSelecIndice.Cells(4).Value
        roltabla = filaSelecIndice.Cells(5).Value
        If roltabla = 1 Then
            rdAdmin.Checked = True
        ElseIf roltabla = 2 Then
            rdSupervisor.Checked = True
        ElseIf roltabla = 3 Then
            rdCargador.Checked = True
        End If
        btnGuardar.Enabled = False
        HabilitarBotones()
    End Sub
    '--------- BOTON ELIMINAR ---------
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Eliminar()
        DeshabilitarControles()
        DeshabilitarBotones()
    End Sub
    '--------- BOTON MODIFICAR ---------
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Modificar()
        DeshabilitarBotones()
        DeshabilitarControles()
    End Sub
    '---------BOTON NUEVO ---------
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        HabilitarControles()
        DeshabilitarBotones()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.UsuariosTableAdapter.FillBy(Me.BdguardiaiforDataSet.usuarios, txtBuscar.Text)
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.UsuariosTableAdapter.FillBy(Me.BdguardiaiforDataSet.usuarios, ApellidoToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class