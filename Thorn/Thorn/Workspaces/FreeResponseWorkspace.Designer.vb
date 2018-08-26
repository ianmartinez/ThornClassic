<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FreeResponseWorkspace
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.clCorrectAnswers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHint = New System.Windows.Forms.TextBox()
        Me.lblHint = New System.Windows.Forms.Label()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(61, 3)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(323, 20)
        Me.txtQuestion.TabIndex = 1
        '
        'dgvMain
        '
        Me.dgvMain.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clCorrectAnswers})
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 81)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.Size = New System.Drawing.Size(387, 228)
        Me.dgvMain.TabIndex = 2
        '
        'clCorrectAnswers
        '
        Me.clCorrectAnswers.HeaderText = "Correct Answers"
        Me.clCorrectAnswers.Name = "clCorrectAnswers"
        Me.clCorrectAnswers.Width = 150
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(3, 6)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(52, 13)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Question:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDisplay)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtHint)
        Me.Panel1.Controls.Add(Me.lblHint)
        Me.Panel1.Controls.Add(Me.txtQuestion)
        Me.Panel1.Controls.Add(Me.lblQuestion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 81)
        Me.Panel1.TabIndex = 3
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(61, 53)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(323, 23)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "..."
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Display:"
        '
        'txtHint
        '
        Me.txtHint.Location = New System.Drawing.Point(61, 29)
        Me.txtHint.Name = "txtHint"
        Me.txtHint.Size = New System.Drawing.Size(323, 20)
        Me.txtHint.TabIndex = 5
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Location = New System.Drawing.Point(3, 32)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(29, 13)
        Me.lblHint.TabIndex = 4
        Me.lblHint.Text = "Hint:"
        '
        'FreeResponseWorkspace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FreeResponseWorkspace"
        Me.Size = New System.Drawing.Size(387, 309)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents clCorrectAnswers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtHint As System.Windows.Forms.TextBox
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
