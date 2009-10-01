Public Class Campo : Inherits FlowLayoutPanel

    Private NumMinas As Integer
    Private Altura As Integer
    Private Largura As Integer
    Private Matriz(,) As Casa


    Public Sub New(ByVal Altura As Integer, ByVal Largura As Integer, ByVal NumMinas As Integer)
        MyBase.New()
        ReDim Matriz(Altura, Largura)
        Me.Altura = Altura
        Me.Largura = Largura
        Me.NumMinas = NumMinas
        Me.Height = Altura * Casa.Altura
        Me.Width = Largura * Casa.Largura
    End Sub

    Public Sub IniciaCampo()
        Dim BombasColocadas = 0
        For i = 0 To Altura
            For j = 0 To Largura
                Me.Matriz(i, j) = New Casa()
            Next
        Next
        While (BombasColocadas < NumMinas)
            Dim r As New Random()
            Dim i = r.Next(0, Altura - 1)
            Dim j = r.Next(0, Largura - 1)
            If (Matriz(i, j).Valor <> Casa.Bomba) Then
                Matriz(i, j).Valor = Casa.Bomba
                BombasColocadas += 1
            End If
        End While
    End Sub

End Class
