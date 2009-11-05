Public Class Jogo
    Private jogador1, jogador2 As Jogador
    Public jogadorDaVez, adiversario As Jogador

    Public Sub New()
        jogador1 = New Maquina(Peca.Cor.PRETA, New ManipuladorPreto(IUser.tabuleiro))
        jogador2 = New Jogador(Peca.Cor.BRANCA, New ManipuladorBranco(IUser.tabuleiro))
    End Sub

    Public Sub iniciarPartida()
        jogadorDaVez = jogador2
        adiversario = jogador1
        While adiversario.getNumeroPecas = 0

        End While

    End Sub
End Class
