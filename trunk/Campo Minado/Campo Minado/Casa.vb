Public Class Casa : Inherits Button
    Private ValorCampo As Integer
    Public Const Bomba = -1
    Public Const Invalido = -2
    Public Const Altura = 10
    Public Const Largura = 10

    Public Sub New()
        MyBase.New()
        Me.Valor = Invalido
        SetSize()
    End Sub

    Public Sub New(ByVal Valor As Integer)
        MyBase.New()
        Me.ValorCampo = Valor
        SetSize()
    End Sub

    Private Sub SetSize()
        Me.Height = Altura
        Me.Width = Largura
    End Sub

    Public Property Valor() As Integer
        Get
            Return ValorCampo
        End Get
        Set(ByVal value As Integer)
            Me.ValorCampo = value
        End Set
    End Property

End Class
