<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgKeyboard
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
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.Key = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyTooltip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.kuiMain = New Thorn.KeyboardUI()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMain
        '
        Me.dgvMain.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Key, Me.KeyTooltip})
        Me.dgvMain.Location = New System.Drawing.Point(12, 41)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.Size = New System.Drawing.Size(325, 231)
        Me.dgvMain.TabIndex = 3
        '
        'Key
        '
        Me.Key.HeaderText = "Key"
        Me.Key.Name = "Key"
        '
        'KeyTooltip
        '
        Me.KeyTooltip.HeaderText = "Key Tooltip"
        Me.KeyTooltip.Name = "KeyTooltip"
        '
        'txtMain
        '
        Me.txtMain.Location = New System.Drawing.Point(345, 14)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Size = New System.Drawing.Size(172, 20)
        Me.txtMain.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(361, 280)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(442, 280)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(12, 12)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 19
        Me.btnImport.Text = "Import..."
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(93, 12)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 20
        Me.btnExport.Text = "Export..."
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(255, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Keyboard File (*.kyd)|*.kyd|All files (*.*)|*.*"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Keyboard File (*.kyd)|*.kyd|All files (*.*)|*.*"
        '
        'kuiMain
        '
        Me.kuiMain.AutoScroll = True
        Me.kuiMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kuiMain.Location = New System.Drawing.Point(345, 41)
        Me.kuiMain.Margin = New System.Windows.Forms.Padding(5)
        Me.kuiMain.Name = "kuiMain"
        Me.kuiMain.Padding = New System.Windows.Forms.Padding(5)
        Me.kuiMain.Size = New System.Drawing.Size(172, 231)
        Me.kuiMain.TabIndex = 18
        Me.kuiMain.TextControl = Me.txtMain
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(174, 12)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dlgKeyboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 315)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.kuiMain)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.dgvMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgKeyboard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Keyboard"
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents txtMain As System.Windows.Forms.TextBox
    Friend WithEvents Key As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeyTooltip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents KeyboardUI1 As KeyboardUI
    Friend WithEvents kuiMain As KeyboardUI
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnUpdate As System.Windows.Forms.Button

End Class
