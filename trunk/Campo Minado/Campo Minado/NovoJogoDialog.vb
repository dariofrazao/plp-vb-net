Imports System.Windows.Forms

Public Class NovoJogoDialog

    Private AlturaD As Integer
    Private LarguraD As Integer
    Private MinasD As Integer
    Private Const Fator = 3

    Public Const Min = 10
    Public Const Max = 30

    'Manipua o evento Click de OK_Button
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            AlturaD = MaskedTextBoxAltura.Text
            LarguraD = MaskedTextBoxLargura.Text
            'Checa se as dimensoes estao dentro do limite
            If (AlturaD >= Min And AlturaD <= Max And LarguraD >= Min And LarguraD <= Max) Then
                MinasD = AlturaD * Largura / Fator
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
            'Nada acontece caso o usuario deixe alguma caixa de texto vazia
        Catch Except As InvalidCastException
        End Try
    End Sub

    'Manipula o evento Cancel de Cancel_Button
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public ReadOnly Property Altura() As Integer
        Get
            Return AlturaD
        End Get
    End Property

    Public ReadOnly Property Largura() As Integer
        Get
            Return LarguraD
        End Get
    End Property

    Public ReadOnly Property Minas() As Integer
        Get
            Return MinasD
        End Get
    End Property

End Class
