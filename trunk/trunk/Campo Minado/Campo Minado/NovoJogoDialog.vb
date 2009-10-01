Imports System.Windows.Forms

Public Class NovoJogoDialog

    Private AlturaD As Integer
    Private LarguraD As Integer
    Private MinasD As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            AlturaD = MaskedTextBoxAltura.Text
            LarguraD = MaskedTextBoxLargura.Text
            MinasD = MaskedTextBoxMinas.Text
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch Except As InvalidCastException
        End Try
    End Sub

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
