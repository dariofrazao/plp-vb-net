Public Class MainForm

    Private Sub NovoJogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoJogoToolStripMenuItem.Click
        Dim NovoJogo = New NovoJogoDialog()
        NovoJogo.ShowDialog()
        If (NovoJogo.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            Dim Campo As New Campo(NovoJogo.Altura, NovoJogo.Largura, NovoJogo.Minas)
            Campo.IniciaCampo()
            Campo.Show()
        End If
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
