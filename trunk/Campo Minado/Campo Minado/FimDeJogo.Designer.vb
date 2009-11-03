<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FimDeJogo
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.BotaoSim = New System.Windows.Forms.Button
        Me.BotaoNao = New System.Windows.Forms.Button
        Me.LabelStatus = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BotaoSim, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BotaoNao, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 113)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(251, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BotaoSim
        '
        Me.BotaoSim.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BotaoSim.Location = New System.Drawing.Point(29, 3)
        Me.BotaoSim.Name = "BotaoSim"
        Me.BotaoSim.Size = New System.Drawing.Size(67, 23)
        Me.BotaoSim.TabIndex = 0
        Me.BotaoSim.Text = "Sim"
        '
        'BotaoNao
        '
        Me.BotaoNao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BotaoNao.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BotaoNao.Location = New System.Drawing.Point(154, 3)
        Me.BotaoNao.Name = "BotaoNao"
        Me.BotaoNao.Size = New System.Drawing.Size(67, 23)
        Me.BotaoNao.TabIndex = 1
        Me.BotaoNao.Text = "Não"
        '
        'LabelStatus
        '
        Me.LabelStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(0, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(251, 31)
        Me.LabelStatus.TabIndex = 1
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Deseja jogar novamente?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FimDeJogo
        '
        Me.AcceptButton = Me.BotaoSim
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BotaoNao
        Me.ClientSize = New System.Drawing.Size(251, 142)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FimDeJogo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FimDeJogo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BotaoSim As System.Windows.Forms.Button
    Friend WithEvents BotaoNao As System.Windows.Forms.Button
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
