Public Class IUser

    Public tabuleiro As Tabuleiro
    Private Damas As Jogo


    Private Sub Tab_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tab.CellClick
        Dim coord = New Tabuleiro.Coordenada
        coord.coluna = e.ColumnIndex
        coord.linha = e.RowIndex


    End Sub

    Private Sub Tab_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tab.CellContentClick

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tab.Rows.Add(7)
        Tab.Rows(7).Height = 50
        colorir()
        tabuleiro = New Tabuleiro()
        Damas = New Jogo()
        Damas.iniciarPartida()

    End Sub

    Private Sub colorir()
        For i As Short = 0 To Tab.ColumnCount - 1
            For Each item As DataGridViewImageCell In Tab.Rows(i).Cells
                With CType(item, DataGridViewImageCell)
                    If (item.ColumnIndex + item.RowIndex) Mod 2 = 0 Then
                        .Value = My.Resources.CasaBranca
                    Else
                        .Value = My.Resources.CasaPreta
                    End If
                End With
            Next
        Next
    End Sub

    Public Sub preencherCasa(ByVal coord As Tabuleiro.Coordenada, ByRef peca As Peca)
        With CType(Tab(coord.coluna, coord.linha), DataGridViewImageCell)
            .Value = peca.getImagem
        End With
    End Sub

End Class
