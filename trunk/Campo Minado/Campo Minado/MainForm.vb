Public Class MainForm

    Private Atual As Jogador
    Private JogadorHumano As Humano
    Private Computador As PC
    Private HumanoJoga As Boolean

    Private Sub NovoJogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoJogoToolStripMenuItem.Click
        Dim NovoJogo = New NovoJogoDialog()
        NovoJogo.ShowDialog()
        If (NovoJogo.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            Me.HumanoJoga = True
            Dim JogadorHumano = New Humano
            Dim Computador = New PC
            With NovoJogo
                Me.MaximumSize = New System.Drawing.Size(.Largura * Casa.Largura + Casa.Largura - 2, _
                                                  .Altura * Casa.Altura + 2 * Casa.Altura - 2 + Me.MenuStrip1.Height + Me.PanelPontuacoes.Height)
                Me.MinimumSize = Me.MaximumSize
                C.Altura = .Altura
                C.Largura = .Largura
                C.Bombas = .Minas
                C.IniciaCampo()
                While True
                    Me.Joga()
                End While
            End With
        End If
    End Sub

    Private Sub Joga()
        If (HumanoJoga) Then
            Me.C.Enabled = True
            Me.Atual = Me.JogadorHumano
        Else
            Me.C.Enabled = False
            Me.Atual = Me.Computador
            Dim CasaPC = Me.C.MelhorOpcao()
            CasaPC.Clicked()
            If (Not CasaPC.Valor = Casa.Bomba) Then
                Me.HumanoJoga = True
            End If
        End If
    End Sub

    Public Property HumanoJogando() As Boolean
        Get
            Return Me.HumanoJoga
        End Get
        Set(ByVal value As Boolean)
            Me.HumanoJoga = value
        End Set
    End Property

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        Dim About As New Sobre
        Sobre.ShowDialog()
    End Sub

    Public Sub Pontua()
        Me.Atual.Pontua()

    End Sub

    Public Property JogadorAtual() As Jogador
        Get
            Return Me.Atual
        End Get
        Set(ByVal value As Jogador)
            Me.Atual = value
        End Set
    End Property

End Class
