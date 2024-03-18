
Imports System.Data.OleDb

Public Class Principal
    'Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Enzo\Github\vb-sistema-guardia-ifor\bdguardiaifor.mdb")
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    conn.Open()
        '    Dim cmd As New OleDbCommand("SELECT personal.jerarquia,personal.apellido,personal.nombre,funcion.nombre_funcion,personal.destino,turnos.nombre_turno,turnos.hora_inicio,turnos.hora_fin,guardias.fecha_guardia,guardias.notificado from guardias inner join personal and guardias.Id_personal=personal.IdPersonal inner join turnos and guardias.Id_turnos=turnos.Idturnos inner join funcion and guardias.Id_funcion=funcion.IdFuncion", conn)
        '    Dim da As New OleDbDataAdapter
        '    da.SelectCommand = cmd
        '    Dim table1 As New DataTable
        '    table1.Clear()
        '    da.Fill(table1)
        '    DataGridView1.DataSource = table1
        '    conn.Close()
        '    DataGridView1.Columns(0).HeaderText = "Jerarquia"
        '    DataGridView1.Columns(0).HeaderText = "Apellido"
        '    DataGridView1.Columns(0).HeaderText = "Nombre"
        '    DataGridView1.Columns(0).HeaderText = "Funcion"
        '    DataGridView1.Columns(0).HeaderText = "Destino"
        '    DataGridView1.Columns(0).HeaderText = "Turno"
        '    DataGridView1.Columns(0).HeaderText = "Inicia"
        '    DataGridView1.Columns(0).HeaderText = "Finaliza"
        '    DataGridView1.Columns(0).HeaderText = "Fecha"
        '    DataGridView1.Columns(0).HeaderText = "Notificado"
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        
    End Sub
    Private Sub VerListaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Personal.Show()
    End Sub

    Private Sub ListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaToolStripMenuItem.Click
        Usuarios.Show()
    End Sub
    Private Sub NuevaGuardiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaGuardiaToolStripMenuItem.Click
        NuevaGuardia.Show()
    End Sub

    Private Sub PersonalEstToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalEstToolStripMenuItem.Click
        Personal.Show()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
    
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStripMenuItem.Click
        
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
