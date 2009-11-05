Public Class ManipuladorBranco
    Implements Manipulador
    Private minhasPecas As List(Of Tabuleiro.Coordenada) = IUser.tabuleiro.brancas
    Private meuTabuleiro As Tabuleiro
    Private pecaSelecionada As Tabuleiro.Coordenada = New Tabuleiro.Coordenada
    Private selecionada As Boolean

    Public Sub New(ByRef tab As Tabuleiro)
        meuTabuleiro = tab
        selecionada = False
    End Sub

    Public Sub selecionaPeca(ByVal coord As Tabuleiro.Coordenada)
        If (Not selecionada) And (minhasPecas.Contains(coord)) Then
            pecaSelecionada = coord
            selecionada = True
        End If
    End Sub

    Public Sub jogar(ByVal coord As Tabuleiro.Coordenada) Implements Manipulador.jogar
        With CType(meuTabuleiro, Tabuleiro)
            If .mesmaDiagonal(pecaSelecionada, coord) Then
                Dim peca = .casas(pecaSelecionada.linha, pecaSelecionada.coluna).peca
                If Not peca.isRainha And coord.linha < pecaSelecionada.linha Then
                    If .isVisinha(pecaSelecionada, coord) Then
                        Dim destino = .casas(coord.linha, coord.coluna)
                        If destino.ocupado Then
                            If Not .isBorda(coord) Then
                                Dim novoDestino As Tabuleiro.Coordenada
                                If .isDiagonalPrincipal(pecaSelecionada, coord) Then
                                    novoDestino = .getEsquerda(coord, DAMAS.Peca.Cor.BRANCA)
                                    If Not .casas(novoDestino.linha, novoDestino.coluna).ocupado Then
                                        tomarPeca(coord)
                                    End If
                                Else
                                    novoDestino = .getDireita(coord, DAMAS.Peca.Cor.BRANCA)
                                    If Not .casas(novoDestino.linha, novoDestino.coluna).ocupado Then
                                        tomarPeca(coord)
                                    End If
                                End If

                            End If
                        Else

                        End If
                    End If
                End If
            End If

        End With
        

    End Sub

    Public Sub repousar() Implements Manipulador.repousar
        pecaSelecionada = Nothing
        selecionada = False
    End Sub


    Public Function selecionou() As Boolean Implements Manipulador.selecionou
        Return selecionada
    End Function


    Public Sub tomarPeca(ByVal coord As Tabuleiro.Coordenada)
        meuTabuleiro.eliminaPeca(coord, pecaSelecionada)
    End Sub
End Class
