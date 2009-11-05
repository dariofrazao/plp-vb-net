Public Class Jogador
    Protected cor As Peca.Cor
    Protected numPecas As Short = 12
    Public manipulador As Manipulador

    Public Sub New(ByVal cor As Peca.Cor, ByRef manipulador As Manipulador)
        Me.cor = cor
        Me.manipulador = manipulador
    End Sub

    Public ReadOnly Property getNumeroPecas()
        Get
            Return numPecas 
        End Get
    End Property

    Public Sub decrementePeca()
        numPecas -= numPecas
    End Sub

    Public Sub jogar(ByVal coord As Tabuleiro.Coordenada)
        With CType(manipulador, ManipuladorBranco)
            If Not .selecionou() Then
                .selecionaPeca(coord)
            Else
                .jogar(coord)
            End If
        End With
    End Sub

End Class
