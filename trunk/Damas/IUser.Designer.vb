<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUser
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
        Me.Tab = New System.Windows.Forms.DataGridView
        Me.A = New System.Windows.Forms.DataGridViewImageColumn
        Me.B = New System.Windows.Forms.DataGridViewImageColumn
        Me.C = New System.Windows.Forms.DataGridViewImageColumn
        Me.D = New System.Windows.Forms.DataGridViewImageColumn
        Me.E = New System.Windows.Forms.DataGridViewImageColumn
        Me.F = New System.Windows.Forms.DataGridViewImageColumn
        Me.G = New System.Windows.Forms.DataGridViewImageColumn
        Me.H = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.Tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab
        '
        Me.Tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tab.ColumnHeadersVisible = False
        Me.Tab.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.A, Me.B, Me.C, Me.D, Me.E, Me.F, Me.G, Me.H})
        Me.Tab.Location = New System.Drawing.Point(83, 12)
        Me.Tab.MaximumSize = New System.Drawing.Size(450, 450)
        Me.Tab.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Tab.Name = "Tab"
        Me.Tab.RowHeadersVisible = False
        Me.Tab.RowHeadersWidth = 50
        Me.Tab.RowTemplate.Height = 50
        Me.Tab.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tab.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Tab.Size = New System.Drawing.Size(403, 403)
        Me.Tab.TabIndex = 0
        '
        'A
        '
        Me.A.Frozen = True
        Me.A.HeaderText = "A"
        Me.A.MinimumWidth = 50
        Me.A.Name = "A"
        Me.A.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.A.Width = 50
        '
        'B
        '
        Me.B.Frozen = True
        Me.B.HeaderText = "B"
        Me.B.MinimumWidth = 50
        Me.B.Name = "B"
        Me.B.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.B.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.B.Width = 50
        '
        'C
        '
        Me.C.Frozen = True
        Me.C.HeaderText = "C"
        Me.C.MinimumWidth = 50
        Me.C.Name = "C"
        Me.C.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.C.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.C.Width = 50
        '
        'D
        '
        Me.D.Frozen = True
        Me.D.HeaderText = "D"
        Me.D.MinimumWidth = 50
        Me.D.Name = "D"
        Me.D.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.D.Width = 50
        '
        'E
        '
        Me.E.Frozen = True
        Me.E.HeaderText = "E"
        Me.E.MinimumWidth = 50
        Me.E.Name = "E"
        Me.E.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.E.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.E.Width = 50
        '
        'F
        '
        Me.F.Frozen = True
        Me.F.HeaderText = "F"
        Me.F.MinimumWidth = 50
        Me.F.Name = "F"
        Me.F.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.F.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.F.Width = 50
        '
        'G
        '
        Me.G.Frozen = True
        Me.G.HeaderText = "G"
        Me.G.MinimumWidth = 50
        Me.G.Name = "G"
        Me.G.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.G.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.G.Width = 50
        '
        'H
        '
        Me.H.Frozen = True
        Me.H.HeaderText = "H"
        Me.H.MinimumWidth = 50
        Me.H.Name = "H"
        Me.H.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.H.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.H.Width = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 501)
        Me.Controls.Add(Me.Tab)
        Me.Name = "Form1"
        Me.Text = "DAMAS"
        CType(Me.Tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab As System.Windows.Forms.DataGridView
    Friend WithEvents A As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents B As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents C As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents D As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents E As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents F As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents G As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents H As System.Windows.Forms.DataGridViewImageColumn

End Class
