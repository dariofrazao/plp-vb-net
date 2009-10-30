Public Class MainForm

    Private Humano As Jogador
    Private Computador As Jogador
    Private HumanoJogando As Boolean
    Private BombasEncontradas As Integer

    'Metodo que manipula o evento Click de NovoJogoStripMenuItem
    Private Sub NovoJogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoJogoToolStripMenuItem.Click
        Inicio()
    End Sub

    'Inicia o campo de acordo com as especificacoes do usuario
    Private Sub Inicio()
        Dim NovoJogo = New NovoJogoDialog()
        NovoJogo.ShowDialog()
        If (NovoJogo.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            With NovoJogo
                'Calculo realizado para comportar todos as casas na janela principal
                Me.MaximumSize = New System.Drawing.Size(.Largura * Casa.Largura + Casa.Largura - 4, _
                                                  .Altura * Casa.Altura + 2 * Casa.Altura - 4 + Me.MenuStrip1.Height + Me.PanelPontuacoes.Height)
                Me.MinimumSize = Me.MaximumSize
                C.Altura = .Altura
                C.Largura = .Largura
                C.Bombas = .Minas
                C.IniciaCampo()
                C.Enabled = True
            End With
        End If
        Me.BombasEncontradas = 0
        Me.Humano = New Jogador
        Me.Computador = New Jogador
        Me.LabelPontuacaoPC.Text = Computador.Pontos.ToString
        Me.LabelPontuacaoHumano.Text = Humano.Pontos.ToString
        Me.LabelRestantes.Text = C.Bombas
        Me.HumanoJogando = True
    End Sub

    'Eh chamado quando algum jogador decide jogar. Manipula se o mesmo eh um usuario
    'humano ou o computador
    Public Sub Joga(ByVal CasaJogada As Casa)
        If (Me.HumanoJogando) Then
            If (CasaJogada.Valor = Casa.Bomba) Then
                Humano.Pontua()
                CasaJogada.BackColor = Color.Blue
                Me.LabelRestantes.Text = (C.Bombas - Me.BombasEncontradas).ToString
                Me.LabelPontuacaoHumano.Text = Humano.Pontos.ToString
                Me.BombasEncontradas += 1
                If (Humano.Pontos > C.Bombas / 2) Then
                    Me.C.Enabled = False
                    Dim Fim As New FimDeJogo("Voce Venceu!")
                    Fim.ShowDialog()
                    If Fim.DialogResult = Windows.Forms.DialogResult.OK Then
                        Inicio()
                    End If
                End If
            Else
                Me.HumanoJogando = False
                'A maquina joga ateh errar
                While (Not HumanoJogando)
                    Dim CasaPC = C.MelhorOpcao()
                    CasaPC.Clicked()
                    If (CasaPC.Valor = Casa.Bomba) Then
                        Computador.Pontua()
                        LabelPontuacaoPC.Text = Computador.Pontos.ToString
                        Me.BombasEncontradas += 1
                        If (Computador.Pontos > C.Bombas / 2) Then
                            Me.C.Enabled = False
                            Dim Fim As New FimDeJogo("Voce Perdeu!")
                            Fim.ShowDialog()
                            If Fim.DialogResult = Windows.Forms.DialogResult.OK Then
                                Inicio()
                            End If
                            Exit While
                        End If
                    Else
                        HumanoJogando = True
                    End If
                End While
            End If
        End If
    End Sub

    'Manipula o evento Click de SairToolStripMenuItem
    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Manipula o evento Click de SobreToolStripMenuItem
    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        Dim About As New Sobre
        Sobre.ShowDialog()
    End Sub

End Class
