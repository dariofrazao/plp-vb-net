﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovoJogoDialog
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
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.LabelAltura = New System.Windows.Forms.Label
        Me.LabelLargura = New System.Windows.Forms.Label
        Me.MaskedTextBoxAltura = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBoxLargura = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(38, 98)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'LabelAltura
        '
        Me.LabelAltura.AutoSize = True
        Me.LabelAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAltura.Location = New System.Drawing.Point(39, 29)
        Me.LabelAltura.Name = "LabelAltura"
        Me.LabelAltura.Size = New System.Drawing.Size(51, 17)
        Me.LabelAltura.TabIndex = 1
        Me.LabelAltura.Text = "Altura"
        '
        'LabelLargura
        '
        Me.LabelLargura.AutoSize = True
        Me.LabelLargura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLargura.Location = New System.Drawing.Point(39, 59)
        Me.LabelLargura.Name = "LabelLargura"
        Me.LabelLargura.Size = New System.Drawing.Size(65, 17)
        Me.LabelLargura.TabIndex = 2
        Me.LabelLargura.Text = "Largura"
        '
        'MaskedTextBoxAltura
        '
        Me.MaskedTextBoxAltura.AllowPromptAsInput = False
        Me.MaskedTextBoxAltura.AsciiOnly = True
        Me.MaskedTextBoxAltura.BeepOnError = True
        Me.MaskedTextBoxAltura.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MaskedTextBoxAltura.Location = New System.Drawing.Point(139, 28)
        Me.MaskedTextBoxAltura.Mask = "00000"
        Me.MaskedTextBoxAltura.Name = "MaskedTextBoxAltura"
        Me.MaskedTextBoxAltura.RejectInputOnFirstFailure = True
        Me.MaskedTextBoxAltura.Size = New System.Drawing.Size(39, 20)
        Me.MaskedTextBoxAltura.SkipLiterals = False
        Me.MaskedTextBoxAltura.TabIndex = 5
        Me.MaskedTextBoxAltura.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'MaskedTextBoxLargura
        '
        Me.MaskedTextBoxLargura.AllowPromptAsInput = False
        Me.MaskedTextBoxLargura.AsciiOnly = True
        Me.MaskedTextBoxLargura.BeepOnError = True
        Me.MaskedTextBoxLargura.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MaskedTextBoxLargura.Location = New System.Drawing.Point(139, 56)
        Me.MaskedTextBoxLargura.Mask = "00000"
        Me.MaskedTextBoxLargura.Name = "MaskedTextBoxLargura"
        Me.MaskedTextBoxLargura.RejectInputOnFirstFailure = True
        Me.MaskedTextBoxLargura.Size = New System.Drawing.Size(39, 20)
        Me.MaskedTextBoxLargura.SkipLiterals = False
        Me.MaskedTextBoxLargura.TabIndex = 6
        Me.MaskedTextBoxLargura.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MaskedTextBoxLargura.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "(7-30)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "(7-30)"
        '
        'NovoJogoDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(216, 139)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaskedTextBoxLargura)
        Me.Controls.Add(Me.MaskedTextBoxAltura)
        Me.Controls.Add(Me.LabelLargura)
        Me.Controls.Add(Me.LabelAltura)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NovoJogoDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NovoJogo"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents LabelAltura As System.Windows.Forms.Label
    Friend WithEvents LabelLargura As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxAltura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxLargura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
