Public Class ManipuladorPreto
    Implements Manipulador
    Private minhasPecas As List(Of Tabuleiro.Coordenada) = IUser.tabuleiro.pretas
    Private meuTabuleiro As Tabuleiro
    Private pecaSelecionada As Tabuleiro.Coordenada
    Public Sub New(ByRef tab As Tabuleiro)
        meuTabuleiro = tab
    End Sub

    Public Sub selecionaPeca(ByVal coord As Tabuleiro.Coordenada)

    End Sub

    Public Sub jogar(ByVal coord As Tabuleiro.Coordenada) Implements Manipulador.jogar

    End Sub

    Public Sub repousar() Implements Manipulador.repousar

    End Sub

    Public Function selecionou() As Boolean Implements Manipulador.selecionou

    End Function
End Class
