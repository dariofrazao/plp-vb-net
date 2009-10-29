Imports System.Windows.Forms

Public Class Campo : Inherits FlowLayoutPanel

    Private NumBombas As Integer
    Private Alt As Integer
    Private Larg As Integer
    Private Matriz(,) As Casa

    Public Sub IniciaCampo()
        Me.Controls.Clear()
        Dim BombasColocadas = 0
        For i = 0 To Alt - 1
            For j = 0 To Larg - 1
                Me.Matriz(i, j) = New Casa(i * Larg + j)
                Me.Controls.Add(Me.Matriz(i, j))
            Next
        Next
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

    Private Sub Abre(ByVal i As Integer, ByVal j As Integer)
        Dim Count = 0
        If (i > 0) Then
            If (Me.Matriz(i - 1, j).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (i + 1 < Altura) Then
            If (Me.Matriz(i + 1, j).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (j > 0) Then
            If (Me.Matriz(i, j - 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (j + 1 < Largura) Then
            If (Me.Matriz(i, j + 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (i > 0 And j > 0) Then
            If (Me.Matriz(i - 1, j - 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (i + 1 < Altura And j + 1 < Largura) Then
            If (Me.Matriz(i + 1, j + 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (i > 0 And j + 1 < Largura) Then
            If (Me.Matriz(i - 1, j + 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (i + 1 < Altura And j > 0) Then
            If (Me.Matriz(i + 1, j - 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        Me.Matriz(i, j).Valor = Count
        If (Me.Matriz(i, j).Enabled) Then
            Me.Matriz(i, j).Clicked()
        End If
        'If (Count = 0) Then
        '    If (i > 0) Then
        '        Abre(i - 1, j)
        '    End If
        '    If (i + 1 < Altura) Then
        '        Abre(i + 1, j)
        '    End If
        '    If (j > 0) Then
        '        Abre(i, j - 1)
        '    End If
        '    If (j + 1 < Largura) Then
        '        Abre(i, j + 1)
        '    End If
        '    If (i > 0 And j > 0) Then
        '        Abre(i - 1, j - 1)
        '    End If
        '    If (i + 1 < Altura And j + 1 < Largura) Then
        '        Abre(i + 1, j + 1)
        '    End If
        '    If (i > 0 And j + 1 < Largura) Then
        '        Abre(i - 1, j + 1)
        '    End If
        '    If (i + 1 < Altura And j > 0) Then
        '        Abre(i + 1, j - 1)
        '    End If
        'End If
    End Sub

    Private Function Quantidade(ByVal i As Integer, ByVal j As Integer) As Integer
        Dim Count = 0
        If (i > 0) Then
            If (Me.Matriz(i - 1, j).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (i + 1 < Altura) Then
            If (Me.Matriz(i + 1, j).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (j > 0) Then
            If (Me.Matriz(i, j - 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (j + 1 < Largura) Then
            If (Me.Matriz(i, j + 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (i > 0 And j > 0) Then
            If (Me.Matriz(i - 1, j - 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (i + 1 < Altura And j + 1 < Largura) Then
            If (Me.Matriz(i + 1, j + 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (i > 0 And j + 1 < Largura) Then
            If (Me.Matriz(i - 1, j + 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        If (i + 1 < Altura And j > 0) Then
            If (Me.Matriz(i + 1, j - 1).Valor = Casa.Bomba) Then
                Count += 1
            End If
        End If
        Return Count
    End Function

    Public Function MelhorOpcao() As Casa
        Dim MelhorCasa = Me.Matriz(0, 0)
        Dim MelhorValor = 8
        For i = 0 To Altura - 1
            For j = 0 To Largura - 1
                Dim Quantidade = Me.Quantidade(i, j)
                If (Quantidade - Me.Matriz(i, j).Valor < MelhorValor _
                    And Quantidade <> Me.Matriz(i, j).Valor) Then
                    MelhorCasa = Me.Matriz(i, j)
                    MelhorValor = Quantidade - Me.Matriz(i, j).Valor
                End If
            Next
        Next
        Return MelhorCasa
    End Function

    Public Sub AbreCasa(ByRef C As Casa)
        For i = 0 To Alt - 1
            For j = 0 To Larg - 1
                If (Me.Matriz(i, j).Equals(C)) Then
                    Abre(i, j)
                    Exit Sub
                End If
            Next
        Next
    End Sub

End Class
