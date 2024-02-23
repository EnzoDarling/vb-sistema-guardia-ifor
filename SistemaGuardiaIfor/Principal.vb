Public Class Principal

    Private Sub VerListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerListaToolStripMenuItem.Click
        NuevoPersonal.Show()
    End Sub

    Private Sub VerListaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerListaToolStripMenuItem1.Click
        Personal.Show()
    End Sub

    Private Sub ListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaToolStripMenuItem.Click
        Usuarios.Show()
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        NuevoUsuario.Show()
    End Sub

    Private Sub NuevaGuardiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaGuardiaToolStripMenuItem.Click
        NuevaGuardia.Show()
    End Sub
End Class
