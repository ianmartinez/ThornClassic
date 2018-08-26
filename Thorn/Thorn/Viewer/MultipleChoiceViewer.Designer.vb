<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultipleChoiceViewer
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
        Me.DisplayViewer1 = New Thorn.DisplayViewer()
        Me.pnlMain = New Thorn.DoubleBufferedSplit()
        Me.lblText = New Thorn.GrowLabel()
        Me.pnlAnswers = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.Panel1.SuspendLayout()
        Me.pnlMain.Panel2.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayViewer1
        '
        Me.DisplayViewer1.AssociatedDisplay = Nothing
        Me.DisplayViewer1.BackColor = System.Drawing.Color.Transparent
        Me.DisplayViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplayViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DisplayViewer1.Name = "DisplayViewer1"
        Me.DisplayViewer1.Padding = New System.Windows.Forms.Padding(5)
        Me.DisplayViewer1.Size = New System.Drawing.Size(246, 174)
        Me.DisplayViewer1.TabIndex = 1
        '
        'pnlMain
        '
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.IsSplitterFixed = True
        Me.pnlMain.Location = New System.Drawing.Point(5, 5)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.NoDraw = False
        Me.pnlMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'pnlMain.Panel1
        '
        Me.pnlMain.Panel1.AutoScroll = True
        Me.pnlMain.Panel1.Controls.Add(Me.lblText)
        '
        'pnlMain.Panel2
        '
        Me.pnlMain.Panel2.Controls.Add(Me.DisplayViewer1)
        Me.pnlMain.Panel2.Controls.Add(Me.pnlAnswers)
        Me.pnlMain.Size = New System.Drawing.Size(246, 246)
        Me.pnlMain.SplitterDistance = 58
        Me.pnlMain.TabIndex = 2
        '
        'lblText
        '
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(246, 13)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "text"
        '
        'pnlAnswers
        '
        Me.pnlAnswers.AutoSize = True
        Me.pnlAnswers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAnswers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlAnswers.Location = New System.Drawing.Point(0, 174)
        Me.pnlAnswers.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlAnswers.Name = "pnlAnswers"
        Me.pnlAnswers.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlAnswers.Size = New System.Drawing.Size(246, 10)
        Me.pnlAnswers.TabIndex = 2
        '
        'MultipleChoiceViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnlMain)
        Me.DoubleBuffered = True
        Me.Name = "MultipleChoiceViewer"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(256, 256)
        Me.pnlMain.Panel1.ResumeLayout(False)
        Me.pnlMain.Panel2.ResumeLayout(False)
        Me.pnlMain.Panel2.PerformLayout()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DisplayViewer1 As Thorn.DisplayViewer
    Friend WithEvents pnlMain As Thorn.DoubleBufferedSplit
    Friend WithEvents lblText As Thorn.GrowLabel
    Friend WithEvents pnlAnswers As System.Windows.Forms.FlowLayoutPanel

End Class
