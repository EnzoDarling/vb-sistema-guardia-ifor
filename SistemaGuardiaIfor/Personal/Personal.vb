Imports System.Data.OleDb
Imports System.IO
Public Class Personal
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Enzo\Github\vb-sistema-guardia-ifor\bdguardiaifor.mdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
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

    Sub GuardarPersonal()
        Dim JerarquiaSeleccionada As String = cmbJerarquia.SelectedItem
        Dim DestinoSeleccionado As String = cmbDestino.SelectedItem
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("INSERT INTO personal(`jerarquia`,`apellido`,`nombre`,`destino`) values (@Jerarquia,@Apellido,@Nombre,@Destino)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Jerarquia", cmbJerarquia.SelectedIndex())
            cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@Destino", cmbDestino.SelectedIndex())
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Se guardo el personal con exito!", vbInformation, MsgBoxStyle.Information)
            End If
            MsgBox("Hubo un error al guardar", vbCritical, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, MsgBoxStyle.Critical)
        End Try
        conn.Close()
    End Sub
    Private Sub Personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarDatos()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        GuardarPersonal()
        MostrarDatos()
    End Sub
End Class