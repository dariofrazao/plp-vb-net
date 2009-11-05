Public Class Peca

    Public Enum Cor As Short
        BRANCA
        PRETA
    End Enum

    Private corPeca As Cor
    Private rainha As Boolean
    Private imagem As Image

    Public Sub New(ByVal cor As Cor)
        corPeca = cor
        setImagem(cor)
    End Sub

    Public ReadOnly Property getCor() As Cor
        Get
            Return corPeca
        End Get
    End Property

    Public Sub coroar()
        rainha = True
        If corPeca = Cor.BRANCA Then
            imagem = My.Resources.RainhaBranca
        Else
            imagem = My.Resources.RainhaPreta
        End If

    End Sub

    Private Sub setImagem(ByVal cor As Cor)
        If corPeca = Peca.Cor.BRANCA Then
            imagem = My.Resources.PecaBranca
        Else
            imagem = My.Resources.PecaPreta
        End If
    End Sub

    Public ReadOnly Property getImagem()
        Get
            Return imagem
        End Get
    End Property

    Public Function isRainha() As Boolean
        Return rainha
    End Function

End Class
