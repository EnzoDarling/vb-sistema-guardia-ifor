Imports System.Data.OleDb
Imports System.IO
Public Class Personal
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Enzo\Github\vb-sistema-guardia-ifor\bdguardiaifor.mdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    '-------------------- MOSTAR DATOS ---------------------
    Sub MostrarDatos()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("SELECT * FROM personal", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("IdPersonal"), dr.Item("jerarquia"), dr.Item("apellido"), dr.Item("nombre"), dr.Item("destino"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, MsgBoxStyle.Critical)
        End Try
        conn.Close()
    End Sub
    '-------------------- LIMPIAR DATOS ---------------------
    Sub Limpiar()
        cmbJerarquia.SelectedIndex = -1
        txtApellido.Clear()
        txtNombre.Clear()
        cmbDestino.SelectedIndex = -1
    End Sub
    '-------------------- GUARDAR PERSONAL ---------------------
    Sub GuardarPersonal()
        Dim JerarquiaSeleccionada As String = cmbJerarquia.SelectedItem
        Dim DestinoSeleccionado As String = cmbDestino.SelectedItem
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("INSERT INTO personal(`jerarquia`,`apellido`,`nombre`,`destino`) values (@Jerarquia,@Apellido,@Nombre,@Destino)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Jerarquia", JerarquiaSeleccionada)
            cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@Destino", DestinoSeleccionado)
            cmd.ExecuteNonQuery()
            MsgBox("Se guardo el personal con exito!", vbInformation, MsgBoxStyle.Information)
            'i = cmd.ExecuteNonQuery
            'If i > 0 Then
            'MsgBox("Se guardo el personal con exito!", vbInformation, MsgBoxStyle.Information)
            'End If
            'MsgBox("Hubo un error al guardar", vbCritical, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, MsgBoxStyle.Critical)
        End Try
        conn.Close()
    End Sub
    '-------------------- ELIMINAR PERSONAL ---------------------
    Sub EliminarPersonal()
        Dim cmd As New OleDb.OleDbCommand("DELETE FROM personal WHERE IdPersonal=@Id", conn)
        Try
            If Trim(txtIdPersonal.Text).Length > 0 Then
                If MsgBox("Se va a eliminar el personal del sistema ¿Está seguro de eliminar el usuario?", vbQuestion + vbYesNo) = vbYes Then
                    conn.Open()
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Id", txtIdPersonal.Text)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Se elimino el personal con exito!", vbInformation, MsgBoxStyle.Information)
                    Else
                        MsgBox("Hubo un error al eliminar", vbCritical, MsgBoxStyle.Critical)
                    End If
                End If
            Else
                MsgBox("No se selecciono ningun Personal a eliminar, seleccione un Personal de la lista", vbInformation, MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, MsgBoxStyle.Critical)
        End Try
        conn.Close()
        MostrarDatos()
    End Sub
    '-------------------- MODIFICAR PERSONAL ---------------------
    Sub ModificarPersonal()
        Dim JerarquiaSeleccionada As String = cmbJerarquia.SelectedItem
        Dim DestinoSeleccionado As String = cmbDestino.SelectedItem
        Dim IdVal As Integer
        If Trim(txtIdPersonal.Text).Length > 0 Then
            If MsgBox("Se va a modificar un usuario del sistema ¿Está seguro de eliminar el usuario?", vbQuestion + vbYesNo) = vbYes Then
                conn.Open()
                Dim command As String
                command = "UPDATE personal SET `jerarquia`=@Jerarquia,`apellido`=@Apellido,`nombre`=@Nombre,`destino`=@Destino WHERE `IdPersonal`=@Id"
                Dim cmd As OleDbCommand = New OleDbCommand(command, conn)
                IdVal = CInt(txtIdPersonal.Text)
                Try
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Id", IdVal)
                    cmd.Parameters.AddWithValue("@Jerarquia", JerarquiaSeleccionada)
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    cmd.Parameters.AddWithValue("@Destino", DestinoSeleccionado)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MsgBox("Se modifico el personal con exito!", vbInformation, MsgBoxStyle.Information)
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
                'conn.Close()
            End If
        End If
        MostrarDatos()
        Limpiar()
    End Sub

    Private Sub Personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarDatos()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        GuardarPersonal()
        MostrarDatos()
    End Sub
    '-------------------- CARGAR DATOS DESDE TABLA BD ---------------------
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        btnGuardar.Enabled = False
        btnNuevo.Enabled = False
        Try
            Dim filaSelecIndice As DataGridViewRow
            filaSelecIndice = DataGridView1.Rows(e.RowIndex)
            txtIdPersonal.Text = filaSelecIndice.Cells(0).Value
            cmbJerarquia.SelectedItem = filaSelecIndice.Cells(1).Value
            txtApellido.Text = filaSelecIndice.Cells(2).Value
            txtNombre.Text = filaSelecIndice.Cells(3).Value
            cmbDestino.SelectedItem = filaSelecIndice.Cells(4).Value
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        EliminarPersonal()
        MostrarDatos()
        Limpiar()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        ModificarPersonal()
        MostrarDatos()
        Limpiar()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MostrarDatos()
    End Sub
End Class