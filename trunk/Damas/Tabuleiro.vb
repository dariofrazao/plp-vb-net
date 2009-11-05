Public Class Tabuleiro

    Public Structure Coordenada
        Dim linha As Short
        Dim coluna As Short
    End Structure

    Public casas(,) As Casa
    Public brancas As List(Of Coordenada) = New List(Of Coordenada)
    Public pretas As List(Of Coordenada) = New List(Of Coordenada)
    Private Const DIMENSAO As Short = 8


    Public Sub New()
        Me.casas = New Casa(Tabuleiro.DIMENSAO, Tabuleiro.DIMENSAO) {}
        Me.inicializar()
        Me.preencher()
    End Sub

    Private Sub inicializar()
        For linha = 0 To DIMENSAO - 1
            For coluna = 0 To DIMENSAO - 1
                casas(linha, coluna) = New Casa()
            Next coluna
        Next linha
    End Sub

    Private Sub preencher()
        preencher(Peca.Cor.BRANCA)
        preencher(Peca.Cor.PRETA)

    End Sub

    Private Sub preencher(ByVal cor As Short)
        Dim inicio, fim As Short
        inicio = 0
        fim = 2
        If cor = Peca.Cor.BRANCA Then
            inicio = 5
            fim = 7
        End If
        Dim coord As Coordenada
        For i = inicio To fim
            Dim j As Short
            coord.linha = i
            If i Mod 2 = 0 Then
                For j = 1 To DIMENSAO - 1
                    coord.coluna = j
                    If cor = Peca.Cor.BRANCA Then
                        brancas.Add(coord)
                    Else
                        pretas.Add(coord)
                    End If
                    casas(i, j).addPeca(New Peca(cor))
                    IUser.preencherCasa(coord, (casas(i, j).peca))
                    j += 1
                Next j

            Else
                For j = 0 To DIMENSAO - 1
                    coord.coluna = j
                    If cor = Peca.Cor.BRANCA Then
                        brancas.Add(coord)
                    Else
                        pretas.Add(coord)
                    End If
                    casas(i, j).addPeca(New Peca(cor))
                    IUser.preencherCasa(coord, (casas(i, j).peca))
                    j += 1
                Next j
            End If

        Next i
    End Sub

    Public Sub verificaPecas(ByVal cor As Peca.Cor)
        If cor = Peca.Cor.BRANCA Then
            verificaBrancas()
        Else
            verificaPretas()
        End If
    End Sub

    Private Sub verificaBrancas()

    End Sub

    Private Sub verificaPretas()

    End Sub

    Public Function getDireita(ByVal coord As Coordenada, ByVal cor As Peca.Cor) As Coordenada
        If cor = Peca.Cor.BRANCA Then
            coord.linha += 1
            coord.coluna -= 1
            Return coord
        Else
            coord.linha -= 1
            coord.coluna += 1
            Return coord
        End If
    End Function

    Public Function getEsquerda(ByVal coord As Coordenada, ByVal cor As Peca.Cor) As Coordenada
        If cor = Peca.Cor.BRANCA Then
            coord.linha += 1
            coord.coluna += 1
            Return coord
        Else
            coord.linha -= 1
            coord.coluna -= 1
            Return coord
        End If
    End Function

    Private Sub criaRainha()

    End Sub

    Public Sub eliminaPeca(ByVal eliminada As Coordenada, ByVal peca As Coordenada)
        Dim eliminador = casas(peca.linha, peca.coluna).peca
        If eliminador.getCor = DAMAS.Peca.Cor.BRANCA Then
            pretas.Remove(eliminada)
        Else
            brancas.Remove(eliminada)
        End If
        Dim destino As Coordenada = New Coordenada
        If isDiagonalPrincipal(eliminada, peca) Then
            If peca.linha > eliminada.linha Then
                destino = getEsquerda(eliminada, eliminador.getCor)
                casas(destino.linha, destino.coluna) = casas(peca.linha, peca.coluna)
                casas(peca.linha, peca.coluna).removePeca()
            Else

            End If
        End If

        casas(eliminada.linha, eliminada.coluna).removePeca()
        IUser.Tab(eliminada.coluna, eliminada.linha).Value = My.Resources.CasaPreta

    End Sub

    Public Sub moverPeca(ByVal origem As Coordenada, ByVal destino As Coordenada)

    End Sub


    Private Function diagonalLivre(ByVal origem As Coordenada, ByVal destino As Coordenada) As Boolean
        Dim diagonal As Coordenada = New Coordenada
        diagonal.linha = destino.linha - origem.linha
        diagonal.coluna = destino.coluna - origem.coluna
        Dim inicio As Short = 0
        If diagonal.linha = diagonal.coluna Then
            If diagonal.linha > 0 Then

            End If

        End If
        For i = 1 To Math.Abs(destino.linha - origem.linha)

        Next i
    End Function

    Public Function mesmaDiagonal(ByVal origem As Coordenada, ByVal destino As Coordenada) As Boolean
        Return Math.Abs(destino.linha - origem.linha) = Math.Abs(destino.coluna - origem.coluna)
    End Function

    Public Function isVisinha(ByVal origem As Coordenada, ByVal destino As Coordenada) As Boolean
        If mesmaDiagonal(origem, destino) Then
            Return Math.Abs(destino.linha - origem.linha) = 1
        End If

    End Function

    Public Function isDiagonalPrincipal(ByVal origem As Coordenada, ByVal destino As Coordenada) As Boolean
        Return destino.linha - origem.linha = destino.coluna - origem.coluna
    End Function

    Public Function isBorda(ByVal casa As Coordenada) As Boolean
        Return casa.linha = 0 Or casa.linha = 7 Or casa.coluna = 0 Or casa.coluna = 7
    End Function

    Public ReadOnly Property getDimensao()
        Get
            Return DIMENSAO
        End Get
    End Property

End Class
