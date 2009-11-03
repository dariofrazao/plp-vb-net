Public Class Jogador

    Protected Pontuacao As Integer

    Public Sub New()
        Me.Pontuacao = 0
    End Sub

    Public Sub Pontua()
        Me.Pontuacao += 1
    End Sub

    Public Property Pontos() As Integer
        Get
            Return Me.Pontuacao
        End Get
        Set(ByVal value As Integer)
            Me.Pontuacao = value
        End Set
    End Property

End Class
