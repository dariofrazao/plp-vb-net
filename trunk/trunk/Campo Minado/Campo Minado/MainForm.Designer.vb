<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.JogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NovoJogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PanelPontuacoes = New System.Windows.Forms.TableLayoutPanel
        Me.PontuacaoHumano = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.C = New Campo_Minado.Campo
        Me.MenuStrip1.SuspendLayout()
        Me.PanelPontuacoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogoToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JogoToolStripMenuItem
        '
        Me.JogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoJogoToolStripMenuItem, Me.ToolStripSeparator1, Me.SairToolStripMenuItem})
        Me.JogoToolStripMenuItem.Name = "JogoToolStripMenuItem"
        Me.JogoToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.JogoToolStripMenuItem.Text = "&Jogo"
        '
        'NovoJogoToolStripMenuItem
        '
        Me.NovoJogoToolStripMenuItem.Name = "NovoJogoToolStripMenuItem"
        Me.NovoJogoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.NovoJogoToolStripMenuItem.Text = "&Novo Jogo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(128, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SairToolStripMenuItem.Text = "&Sair"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "&Ajuda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SobreToolStripMenuItem.Text = "&Sobre..."
        '
        'PanelPontuacoes
        '
        Me.PanelPontuacoes.AutoSize = True
        Me.PanelPontuacoes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelPontuacoes.ColumnCount = 2
        Me.PanelPontuacoes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706!))
        Me.PanelPontuacoes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.PanelPontuacoes.Controls.Add(Me.PontuacaoHumano, 0, 0)
        Me.PanelPontuacoes.Controls.Add(Me.Label2, 1, 0)
        Me.PanelPontuacoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPontuacoes.Location = New System.Drawing.Point(0, 247)
        Me.PanelPontuacoes.Name = "PanelPontuacoes"
        Me.PanelPontuacoes.RowCount = 1
        Me.PanelPontuacoes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PanelPontuacoes.Size = New System.Drawing.Size(284, 17)
        Me.PanelPontuacoes.TabIndex = 2
        '
        'PontuacaoHumano
        '
        Me.PontuacaoHumano.AutoSize = True
        Me.PontuacaoHumano.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PontuacaoHumano.Dock = System.Windows.Forms.DockStyle.Left
        Me.PontuacaoHumano.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PontuacaoHumano.Location = New System.Drawing.Point(3, 0)
        Me.PontuacaoHumano.Name = "PontuacaoHumano"
        Me.PontuacaoHumano.Size = New System.Drawing.Size(17, 17)
        Me.PontuacaoHumano.TabIndex = 1
        Me.PontuacaoHumano.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "0"
        '
        'C
        '
        Me.C.Altura = 0
        Me.C.Bombas = 0
        Me.C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C.Largura = 0
        Me.C.Location = New System.Drawing.Point(0, 24)
        Me.C.Margin = New System.Windows.Forms.Padding(0)
        Me.C.MinimumSize = New System.Drawing.Size(70, 70)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(284, 240)
        Me.C.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.PanelPontuacoes)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Campo Minado"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelPontuacoes.ResumeLayout(False)
        Me.PanelPontuacoes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents JogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoJogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C As Campo_Minado.Campo
    Friend WithEvents PanelPontuacoes As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PontuacaoHumano As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
