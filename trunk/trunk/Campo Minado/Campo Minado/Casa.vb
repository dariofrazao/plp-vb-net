Imports System.Windows.Forms

Public Class Casa : Inherits Button
    Private ValorCampo As Integer
    Public Const Bomba = -1
    Public Const Invalido = -2
    Public Const Altura = 20
    Public Const Largura = 20

    Public Sub New()
        MyBase.New()
        Me.Valor = Invalido
        Configure()
    End Sub

    Public Sub New(ByVal Valor As Integer)
        MyBase.New()
        Me.ValorCampo = Valor
        Configure()
    End Sub

    'Configura o padrao de uma casa
    Private Sub Configure()
        Me.Margin = New Windows.Forms.Padding(0)
        Me.Size = New System.Drawing.Size(Largura, Altura)
        Me.FlatStyle = Windows.Forms.FlatStyle.Popup
        Me.BackColor = Color.Green
        Me.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    'Metodo que manipula o evento Click
    Private Sub Casa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Clicked()
    End Sub

    'Manipula a casa quando a mesma eh clicaca (pelo usuario ou computador)
    Public Sub Clicked()
        Me.Enabled = False
        If (Me.Valor = Casa.Bomba) Then
            Me.BackColor = Color.Red
        Else
            CType(Me.Parent, Campo).AbreCasa(Me)
            Me.BackColor = Color.Gray
            Me.Text = Me.Valor.ToString
        End If
        Me.Refresh()
        CType(Me.Parent.Parent, MainForm).Joga(Me)
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
