Public Class Casa

    Private ocupada As Boolean
    Public peca As Peca

    Public Sub New()
        ocupada = False
        peca = Nothing
    End Sub

    Public Sub addPeca(ByRef peca As Peca)
        Me.peca = peca
        ocupada = True
    End Sub

    Public Sub removePeca()
        peca = Nothing
        ocupada = False
    End Sub

    Public ReadOnly Property ocupado() As Boolean
        Get
            Return ocupada
        End Get
    End Property

End Class