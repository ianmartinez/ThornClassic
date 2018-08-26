<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReadVocabulary
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Picture = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Translation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Word = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Picture.DefaultCellStyle = DataGridViewCellStyle2
        Me.Picture.HeaderText = "Picture"
        Me.Picture.Name = "Picture"
        Me.Picture.ReadOnly = True
        Me.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Translation
        '
        Me.Translation.HeaderText = "Translation"
        Me.Translation.Name = "Translation"
        Me.Translation.ReadOnly = True
        '
        'Word
        '
        Me.Word.HeaderText = "Word"
        Me.Word.Name = "Word"
        Me.Word.ReadOnly = True
        '
        'dgvMain
        '
        Me.dgvMain.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Word, Me.Translation, Me.Picture})
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.Size = New System.Drawing.Size(435, 315)
        Me.dgvMain.TabIndex = 26
        '
        'dlgReadVocabulary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.dgvMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "dlgReadVocabulary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vocabulary"
        Me.TopMost = True
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Picture As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Translation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Word As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView

End Class
