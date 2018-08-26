<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MediaViewer
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
        Me.pnlMain = New Thorn.DoubleBufferedSplit()
        Me.pMain = New Thorn.Player()
        Me.lblText = New Thorn.GrowLabel()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.Panel1.SuspendLayout()
        Me.pnlMain.Panel2.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.pnlMain.Panel2.Controls.Add(Me.pMain)
        Me.pnlMain.Size = New System.Drawing.Size(246, 246)
        Me.pnlMain.SplitterDistance = 58
        Me.pnlMain.TabIndex = 1
        '
        'pMain
        '
        Me.pMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMain.Location = New System.Drawing.Point(0, 0)
        Me.pMain.Media = Nothing
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(246, 184)
        Me.pMain.TabIndex = 0
        '
        'lblText
        '
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(246, 13)
        Me.lblText.TabIndex = 2
        Me.lblText.Text = "text"
        '
        'MediaViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnlMain)
        Me.DoubleBuffered = True
        Me.Name = "MediaViewer"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(256, 256)
        Me.pnlMain.Panel1.ResumeLayout(False)
        Me.pnlMain.Panel2.ResumeLayout(False)
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMain As Thorn.DoubleBufferedSplit
    Friend WithEvents pMain As Thorn.Player
    Friend WithEvents lblText As Thorn.GrowLabel

End Class
