Imports System.Windows.Forms

Public Class Casa : Inherits Button
    Private ValorCampo As Integer
    Public Const Bomba = -1
    Public Const Invalido = -2
    Public Const Altura = 20
    Public Const Largura = 20
    Private Colors() As System.Drawing.Color
    Private Id As Integer

    Public Sub New()
        MyBase.New()
        Me.Valor = Invalido
        Me.Id = Invalido
        Configure()
    End Sub

    Public Sub New(ByVal Id As Integer)
        MyBase.New()
        Me.Valor = Invalido
        Me.Id = Id
        Configure()
    End Sub

    Public Sub New(ByVal Valor As Integer, ByVal Id As Integer)
        MyBase.New()
        Me.ValorCampo = Valor
        Me.Id = Id
        Configure()
    End Sub

    Private Sub Configure()
        Me.Margin = New Windows.Forms.Padding(0)
        Me.Size = New System.Drawing.Size(Largura, Altura)
        Me.FlatStyle = Windows.Forms.FlatStyle.Popup
        Me.BackColor = Color.Blue
        Me.TextAlign = ContentAlignment.MiddleCenter
        ReDim Colors(9)
        Colors(0) = Color.Gray
        Colors(1) = Color.LightBlue
        Colors(2) = Color.Green
        Colors(3) = Color.Red
        Colors(4) = Color.Blue
        Colors(5) = Color.Brown
        Colors(6) = Color.LightCyan
        Colors(7) = Color.Green
        Colors(8) = Color.Black
    End Sub

    Public Property Valor() As Integer
        Get
            Return ValorCampo
        End Get
        Set(ByVal value As Integer)
            Me.ValorCampo = value
        End Set
    End Property

    Private Sub Casa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If (Me.Valor = Bomba) Then
            CasaBomba()
        Else
            Clicked()
            CType(Me.Parent.Parent, MainForm).HumanoJogando = _
            Not CType(Me.Parent.Parent, MainForm).HumanoJogando
        End If
    End Sub

    Private Sub CasaBomba()
        Me.Enabled = False
        Me.BackColor = Color.Red
        CType(Me.Parent.Parent, MainForm).Pontua()
    End Sub

    Public Sub Clicked()
        Me.Enabled = False
        CType(Me.Parent, Campo).AbreCasa(Me)
        Me.BackColor = Color.Gray
        Me.Text = Me.Valor.ToString
        If (Me.Valor <> Invalido) Then
            Me.ForeColor = Me.Colors(Me.Valor)
        End If
        Me.Refresh()
    End Sub

    Public Overloads Function Equals(ByVal C As Casa) As Boolean
        Return Me.Id.Equals(C.Id)
    End Function

End Class
