<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MediaWorkspace
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
        Me.txtCaption = New System.Windows.Forms.TextBox()
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.pMain = New Thorn.Player()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cbCaption = New System.Windows.Forms.CheckBox()
        Me.dlgOpenMedia = New System.Windows.Forms.OpenFileDialog()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCaption
        '
        Me.txtCaption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCaption.Enabled = False
        Me.txtCaption.Location = New System.Drawing.Point(62, 0)
        Me.txtCaption.Multiline = True
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.Size = New System.Drawing.Size(325, 35)
        Me.txtCaption.TabIndex = 1
        '
        'scMain
        '
        Me.scMain.BackColor = System.Drawing.Color.Transparent
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.Location = New System.Drawing.Point(0, 0)
        Me.scMain.Name = "scMain"
        Me.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.Controls.Add(Me.btnImport)
        Me.scMain.Panel1.Controls.Add(Me.pMain)
        Me.scMain.Panel1.Controls.Add(Me.Panel1)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.txtCaption)
        Me.scMain.Panel2.Controls.Add(Me.cbCaption)
        Me.scMain.Size = New System.Drawing.Size(387, 309)
        Me.scMain.SplitterDistance = 270
        Me.scMain.TabIndex = 7
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.BackColor = System.Drawing.Color.Transparent
        Me.btnImport.Location = New System.Drawing.Point(309, 34)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 5
        Me.btnImport.Text = "Import..."
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'pMain
        '
        Me.pMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMain.Location = New System.Drawing.Point(0, 28)
        Me.pMain.Media = Nothing
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(387, 242)
        Me.pMain.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSet)
        Me.Panel1.Controls.Add(Me.txtTitle)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 28)
        Me.Panel1.TabIndex = 7
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.Transparent
        Me.btnSet.Location = New System.Drawing.Point(309, 1)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(75, 23)
        Me.btnSet.TabIndex = 6
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(39, 3)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(264, 20)
        Me.txtTitle.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(3, 6)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title:"
        '
        'cbCaption
        '
        Me.cbCaption.AutoSize = True
        Me.cbCaption.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbCaption.Location = New System.Drawing.Point(0, 0)
        Me.cbCaption.Name = "cbCaption"
        Me.cbCaption.Size = New System.Drawing.Size(62, 35)
        Me.cbCaption.TabIndex = 0
        Me.cbCaption.Text = "Caption"
        Me.cbCaption.UseVisualStyleBackColor = True
        '
        'dlgOpenMedia
        '
        Me.dlgOpenMedia.Filter = "Audio files|*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mid;*.midi;*.rmi;*.aif;*.aifc;*.aiff;" & _
    "*.au;*.snd;*.wav;*.cda;*.m4a|Video Files|*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*." & _
    "mov|All Files|*.*"
        '
        'MediaWorkspace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.scMain)
        Me.DoubleBuffered = True
        Me.Name = "MediaWorkspace"
        Me.Size = New System.Drawing.Size(387, 309)
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel2.ResumeLayout(False)
        Me.scMain.Panel2.PerformLayout()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCaption As System.Windows.Forms.TextBox
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents pMain As Player
    Friend WithEvents dlgOpenMedia As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cbCaption As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button

End Class
