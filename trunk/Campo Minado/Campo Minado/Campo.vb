Imports System.Windows.Forms

Public Class Campo : Inherits FlowLayoutPanel

    Private NumBombas As Integer
    Private Alt As Integer
    Private Larg As Integer
    Private Matriz(,) As Casa

    'Cria as casas, adiciona as mesmas no Panel e cria as bombas aleatoreamente
    Public Sub IniciaCampo()
        Me.Controls.Clear()
        'Cria as casas e adiciona no Panel
        Dim BombasColocadas = 0
        For i = 0 To Alt - 1
            For j = 0 To Larg - 1
                Me.Matriz(i, j) = New Casa()
                Me.Controls.Add(Me.Matriz(i, j))
            Next
        Next
        'Sorteia uma coordenada e checa se ja existe bomba na mesma.
        'Caso nao exista, adiciona uma
        While (BombasColocadas < NumBombas)
            Dim r As New Random()
            Dim i = r.Next(0, Alt - 1)
            Dim j = r.Next(0, Larg - 1)
            If (Matriz(i, j).Valor <> Casa.Bomba) Then
                Matriz(i, j).Valor = Casa.Bomba
                BombasColocadas += 1
            End If
        End While
    End Sub

    'Procura por uma casa dentro e retorna suas coordenadas
    Private Function Busca(ByVal C As Casa) As Integer()
        Dim Indice = Me.Controls.IndexOf(C)
        Dim i = 0
        Dim j = Indice
        While j > Largura - 1
            j -= Largura
            i += 1
        End While
        Dim Retorno(2) As Integer
        Retorno(0) = i
        Retorno(1) = j
        Return Retorno
    End Function

    'Revela uma casa
    Public Sub AbreCasa(ByRef C As Casa)
        Dim Indice = Busca(C)
        Abre(Indice(0), Indice(1))
    End Sub

    'Metodo responsavel por revelar as casas adjacentes caso o valor de uma casa seja 0
    Private Sub Abre(ByVal i As Integer, ByVal j As Integer)
        Dim Count = Quantidade(i, j, Function(C As Casa) C.Valor = Casa.Bomba, Function(C As Casa) True)
        Me.Matriz(i, j).Valor = Count
        If (Count = 0) Then
            If (i > 0) Then
                If (Me.Matriz(i - 1, j).Enabled) Then
                    Me.Matriz(i - 1, j).Clicked()
                End If
            End If
            If (i + 1 < Altura) Then
                If (Me.Matriz(i + 1, j).Enabled) Then
                    Me.Matriz(i + 1, j).Clicked()
                End If
            End If
            If (j > 0) Then
                If (Me.Matriz(i, j - 1).Enabled) Then
                    Me.Matriz(i, j - 1).Clicked()
                End If
            End If
            If (j + 1 < Largura) Then
                If (Me.Matriz(i, j + 1).Enabled) Then
                    Me.Matriz(i, j + 1).Clicked()
                End If
            End If
            If (i > 0 And j > 0) Then
                If (Me.Matriz(i - 1, j - 1).Enabled) Then
                    Me.Matriz(i - 1, j - 1).Clicked()
                End If
            End If
            If (i + 1 < Altura And j + 1 < Largura) Then
                If (Me.Matriz(i + 1, j + 1).Enabled) Then
                    Me.Matriz(i + 1, j + 1).Clicked()
                End If
            End If
            If (i > 0 And j + 1 < Largura) Then
                If (Me.Matriz(i - 1, j + 1).Enabled) Then
                    Me.Matriz(i - 1, j + 1).Clicked()
                End If
            End If
            If (i + 1 < Altura And j > 0) Then
                If (Me.Matriz(i + 1, j - 1).Enabled) Then
                    Me.Matriz(i + 1, j - 1).Clicked()
                End If
            End If
        End If
    End Sub

    'Retorna a quantidade de minas em volta de uma casa de acordo com duas condicoes
    Private Function Quantidade(ByVal i As Integer, ByVal j As Integer, _
                                ByVal Condicao1 As Func(Of Casa, Boolean), _
                                ByVal Condicao2 As Func(Of Casa, Boolean)) As Integer
        Dim Count = 0
        If (i > 0) Then
            If (Condicao1(Me.Matriz(i - 1, j)) And Condicao2(Me.Matriz(i - 1, j))) Then
                Count += 1
            End If
        End If
        If (i + 1 < Altura) Then
            If (Condicao1(Me.Matriz(i + 1, j)) And Condicao2(Me.Matriz(i + 1, j))) Then
                Count += 1
            End If
        End If
        If (j > 0) Then
            If (Condicao1(Me.Matriz(i, j - 1)) And Condicao2(Me.Matriz(i, j - 1))) Then
                Count += 1
            End If
        End If
        If (j + 1 < Largura) Then
            If (Condicao1(Me.Matriz(i, j + 1)) And Condicao2(Me.Matriz(i, j + 1))) Then
                Count += 1
            End If
        End If
        If (i > 0 And j > 0) Then
            If (Condicao1(Me.Matriz(i - 1, j - 1)) And Condicao2(Me.Matriz(i - 1, j - 1))) Then
                Count += 1
            End If
        End If
        If (i + 1 < Altura And j + 1 < Largura) Then
            If (Condicao1(Me.Matriz(i + 1, j + 1)) And Condicao2(Me.Matriz(i + 1, j + 1))) Then
                Count += 1
            End If
        End If
        If (i > 0 And j + 1 < Largura) Then
            If (Condicao1(Me.Matriz(i - 1, j + 1)) And Condicao2(Me.Matriz(i - 1, j + 1))) Then
                Count += 1
            End If
        End If
        If (i + 1 < Altura And j > 0) Then
            If (Condicao1(Me.Matriz(i + 1, j - 1)) And Condicao2(Me.Matriz(i + 1, j - 1))) Then
                Count += 1
            End If
        End If
        Return Count
    End Function

    'Retorna o primeiro adjacente valido de acordo com duas condicoes
    Private Function Adjacente(ByVal i As Integer, ByVal j As Integer, _
                                ByVal Condicao1 As Func(Of Casa, Boolean), _
                                ByVal Condicao2 As Func(Of Casa, Boolean)) As Casa
        If (i > 0) Then
            If (Condicao1(Me.Matriz(i - 1, j)) And Condicao2(Me.Matriz(i - 1, j))) Then
                Return Me.Matriz(i - 1, j)
            End If
        End If
        If (i + 1 < Altura) Then
            If (Condicao1(Me.Matriz(i + 1, j)) And Condicao2(Me.Matriz(i + 1, j))) Then
                Return Me.Matriz(i + 1, j)
            End If
        End If
        If (j > 0) Then
            If (Condicao1(Me.Matriz(i, j - 1)) And Condicao2(Me.Matriz(i, j - 1))) Then
                Return Me.Matriz(i, j - 1)
            End If
        End If
        If (j + 1 < Largura) Then
            If (Condicao1(Me.Matriz(i, j + 1)) And Condicao2(Me.Matriz(i, j + 1))) Then
                Return Me.Matriz(i, j + 1)
            End If
        End If
        If (i > 0 And j > 0) Then
            If (Condicao1(Me.Matriz(i - 1, j - 1)) And Condicao2(Me.Matriz(i - 1, j - 1))) Then
                Return Me.Matriz(i - 1, j - 1)
            End If
        End If
        If (i + 1 < Altura And j + 1 < Largura) Then
            If (Condicao1(Me.Matriz(i + 1, j + 1)) And Condicao2(Me.Matriz(i + 1, j + 1))) Then
                Return Me.Matriz(i + 1, j + 1)
            End If
        End If
        If (i > 0 And j + 1 < Largura) Then
            If (Condicao1(Me.Matriz(i - 1, j + 1)) And Condicao2(Me.Matriz(i - 1, j + 1))) Then
                Return Me.Matriz(i - 1, j + 1)
            End If
        End If
        If (i + 1 < Altura And j > 0) Then
            If (Condicao1(Me.Matriz(i + 1, j - 1)) And Condicao2(Me.Matriz(i + 1, j - 1))) Then
                Return Me.Matriz(i + 1, j - 1)
            End If
        End If
        Return Nothing
    End Function

    'Busca a melhor opcao de jogada a partir das casas ja descobertas
    Public Function MelhorOpcao() As Casa
        Dim MelhorValor = 0
        Dim Melhor As New Casa
        Dim x = -1
        Dim y = -1
        For i = 0 To Altura - 1
            For j = 0 To Largura - 1
                If (Me.Matriz(i, j).Enabled) Then
                    Continue For
                End If
                If (Me.Matriz(i, j).Valor = Casa.Bomba) Then
                    Continue For
                End If
                Dim Abertas = Quantidade(i, j, Function(C As Casa) Not C.Enabled, Function(C As Casa) True)
                Dim Fechadas = Quantidade(i, j, Function(C As Casa) C.Enabled, Function(C As Casa) True)
                Dim BombasAbertas = Quantidade(i, j, Function(C As Casa) C.Valor = Casa.Bomba, _
                                               Function(C As Casa) Not C.Enabled)
                If (Fechadas - (Me.Matriz(i, j).Valor - BombasAbertas) >= MelhorValor) Then
                    MelhorValor = Fechadas - (Me.Matriz(i, j).Valor - BombasAbertas)
                    Melhor = Matriz(i, j)
                End If
            Next
        Next
        For i = 0 To 1000000
            'Delay
        Next
        'Se nao encontrou uma boa opcao, escolhe uma aleatoria
        If (x = -1 And y = -1) Then
            Dim r As New Random()
            Do
                x = r.Next(0, Altura - 1)
                y = r.Next(0, Largura - 1)
            Loop While (Me.Matriz(x, y).Enabled = False)
            Return Me.Matriz(x, y)
        End If
        'Escolhe a primeira adjacente valida
        Melhor = Adjacente(x, y, Function(C As Casa) C.Enabled, Function(C As Casa) True)
        Return Melhor
    End Function

    Public Property Bombas() As Integer
        Get
            Return NumBombas
        End Get
        Set(ByVal value As Integer)
            Me.NumBombas = value
        End Set
    End Property

    Public Property Altura() As Integer
        Get
            Return Alt
        End Get
        Set(ByVal value As Integer)
            Me.Alt = value
            ReDim Matriz(value, Largura)
        End Set
    End Property

    Public Property Largura() As Integer
        Get
            Return Larg
        End Get
        Set(ByVal value As Integer)
            Me.Larg = value
            ReDim Matriz(Altura, value)
        End Set
    End Property

End Class
