<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewer))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tcSlides = New Thorn.DoubleBufferedTabs()
        Me.kuiMain = New Thorn.KeyboardUI()
        Me.btnVocabulary = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel1 = New Tundra.DoubleBufferedPanel()
        Me.StylizedPanel2 = New Tundra.StylizedPanel()
        Me.rtbDescription = New Tundra.TransparentRichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GoToToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BackToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ForwardToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DonateToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BugReportToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AboutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenSidebarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AnswerQuestionToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.StylizedPanel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tcSlides)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.kuiMain)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnVocabulary)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DoubleBufferedPanel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StylizedPanel2)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.SplitContainer1.Size = New System.Drawing.Size(684, 437)
        Me.SplitContainer1.SplitterDistance = 516
        Me.SplitContainer1.TabIndex = 7
        '
        'tcSlides
        '
        Me.tcSlides.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcSlides.Location = New System.Drawing.Point(0, 0)
        Me.tcSlides.Name = "tcSlides"
        Me.tcSlides.SelectedIndex = 0
        Me.tcSlides.Size = New System.Drawing.Size(516, 437)
        Me.tcSlides.TabIndex = 3
        '
        'kuiMain
        '
        Me.kuiMain.AutoScroll = True
        Me.kuiMain.BackColor = System.Drawing.Color.Transparent
        Me.kuiMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kuiMain.Location = New System.Drawing.Point(6, 217)
        Me.kuiMain.Margin = New System.Windows.Forms.Padding(5)
        Me.kuiMain.Name = "kuiMain"
        Me.kuiMain.Padding = New System.Windows.Forms.Padding(5)
        Me.kuiMain.Size = New System.Drawing.Size(155, 217)
        Me.kuiMain.TabIndex = 0
        Me.kuiMain.TextControl = Nothing
        '
        'btnVocabulary
        '
        Me.btnVocabulary.BackColor = System.Drawing.Color.Transparent
        Me.btnVocabulary.BackgroundImage = CType(resources.GetObject("btnVocabulary.BackgroundImage"), System.Drawing.Image)
        Me.btnVocabulary.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVocabulary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVocabulary.FlatAppearance.BorderSize = 0
        Me.btnVocabulary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnVocabulary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnVocabulary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVocabulary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVocabulary.Location = New System.Drawing.Point(6, 194)
        Me.btnVocabulary.Name = "btnVocabulary"
        Me.btnVocabulary.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnVocabulary.Size = New System.Drawing.Size(155, 23)
        Me.btnVocabulary.Style = resources.GetString("btnVocabulary.Style")
        Me.btnVocabulary.TabIndex = 38
        Me.btnVocabulary.Text = "Vocabulary"
        Me.btnVocabulary.UseCompatibleTextRendering = True
        Me.btnVocabulary.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel1
        '
        Me.DoubleBufferedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DoubleBufferedPanel1.Location = New System.Drawing.Point(6, 184)
        Me.DoubleBufferedPanel1.Name = "DoubleBufferedPanel1"
        Me.DoubleBufferedPanel1.Size = New System.Drawing.Size(155, 10)
        Me.DoubleBufferedPanel1.TabIndex = 0
        '
        'StylizedPanel2
        '
        Me.StylizedPanel2.Controls.Add(Me.rtbDescription)
        Me.StylizedPanel2.Controls.Add(Me.Label3)
        Me.StylizedPanel2.Controls.Add(Me.lblStatus)
        Me.StylizedPanel2.Controls.Add(Me.lblType)
        Me.StylizedPanel2.Controls.Add(Me.lblFamily)
        Me.StylizedPanel2.Controls.Add(Me.lblName)
        Me.StylizedPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.StylizedPanel2.Location = New System.Drawing.Point(6, 3)
        Me.StylizedPanel2.Name = "StylizedPanel2"
        Me.StylizedPanel2.Padding = New System.Windows.Forms.Padding(3)
        Me.StylizedPanel2.Size = New System.Drawing.Size(155, 181)
        Me.StylizedPanel2.Style = "Colors=#536ca4|#1a2640|#263552|#3a4d6b" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|0.3|0.8|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=3" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=#1f2b41" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=#4e79ae" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.StylizedPanel2.TabIndex = 0
        '
        'rtbDescription
        '
        Me.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDescription.ForeColor = System.Drawing.Color.White
        Me.rtbDescription.Location = New System.Drawing.Point(3, 91)
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.ReadOnly = True
        Me.rtbDescription.Size = New System.Drawing.Size(149, 87)
        Me.rtbDescription.TabIndex = 36
        Me.rtbDescription.Text = "Description"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 10)
        Me.Label3.TabIndex = 37
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(3, 68)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(149, 13)
        Me.lblStatus.TabIndex = 34
        Me.lblStatus.Text = "Status: Not Endangered"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblStatus.UseCompatibleTextRendering = True
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblType.ForeColor = System.Drawing.Color.White
        Me.lblType.Location = New System.Drawing.Point(3, 55)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(149, 13)
        Me.lblType.TabIndex = 33
        Me.lblType.Text = "Type: Natural"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblType.UseCompatibleTextRendering = True
        '
        'lblFamily
        '
        Me.lblFamily.BackColor = System.Drawing.Color.Transparent
        Me.lblFamily.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFamily.ForeColor = System.Drawing.Color.White
        Me.lblFamily.Location = New System.Drawing.Point(3, 42)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(149, 13)
        Me.lblFamily.TabIndex = 32
        Me.lblFamily.Text = "Family: Isolate"
        Me.lblFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFamily.UseCompatibleTextRendering = True
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(3, 3)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(149, 39)
        Me.lblName.TabIndex = 30
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblName.UseCompatibleTextRendering = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToToolStripButton, Me.BackToolStripButton, Me.ForwardToolStripButton, Me.ToolStripSeparator4, Me.DonateToolStripButton, Me.BugReportToolStripButton, Me.AboutToolStripButton, Me.OpenSidebarToolStripButton, Me.ToolStripSeparator1, Me.AnswerQuestionToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(684, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'GoToToolStripButton
        '
        Me.GoToToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GoToToolStripButton.Image = CType(resources.GetObject("GoToToolStripButton.Image"), System.Drawing.Image)
        Me.GoToToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoToToolStripButton.Name = "GoToToolStripButton"
        Me.GoToToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GoToToolStripButton.Text = "Go To..."
        '
        'BackToolStripButton
        '
        Me.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackToolStripButton.Image = CType(resources.GetObject("BackToolStripButton.Image"), System.Drawing.Image)
        Me.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackToolStripButton.Name = "BackToolStripButton"
        Me.BackToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BackToolStripButton.Text = "Back"
        '
        'ForwardToolStripButton
        '
        Me.ForwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ForwardToolStripButton.Image = CType(resources.GetObject("ForwardToolStripButton.Image"), System.Drawing.Image)
        Me.ForwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ForwardToolStripButton.Name = "ForwardToolStripButton"
        Me.ForwardToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ForwardToolStripButton.Text = "Forward"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'DonateToolStripButton
        '
        Me.DonateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DonateToolStripButton.Image = CType(resources.GetObject("DonateToolStripButton.Image"), System.Drawing.Image)
        Me.DonateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DonateToolStripButton.Name = "DonateToolStripButton"
        Me.DonateToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DonateToolStripButton.Text = "Donate"
        '
        'BugReportToolStripButton
        '
        Me.BugReportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BugReportToolStripButton.Image = CType(resources.GetObject("BugReportToolStripButton.Image"), System.Drawing.Image)
        Me.BugReportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BugReportToolStripButton.Name = "BugReportToolStripButton"
        Me.BugReportToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BugReportToolStripButton.Text = "Bug Report/Feature Suggestion"
        '
        'AboutToolStripButton
        '
        Me.AboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AboutToolStripButton.Image = CType(resources.GetObject("AboutToolStripButton.Image"), System.Drawing.Image)
        Me.AboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AboutToolStripButton.Name = "AboutToolStripButton"
        Me.AboutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AboutToolStripButton.Text = "About"
        '
        'OpenSidebarToolStripButton
        '
        Me.OpenSidebarToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OpenSidebarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenSidebarToolStripButton.Image = CType(resources.GetObject("OpenSidebarToolStripButton.Image"), System.Drawing.Image)
        Me.OpenSidebarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenSidebarToolStripButton.Name = "OpenSidebarToolStripButton"
        Me.OpenSidebarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenSidebarToolStripButton.Text = "Open Keyboard"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator1.Visible = False
        '
        'AnswerQuestionToolStripButton
        '
        Me.AnswerQuestionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnswerQuestionToolStripButton.Image = CType(resources.GetObject("AnswerQuestionToolStripButton.Image"), System.Drawing.Image)
        Me.AnswerQuestionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AnswerQuestionToolStripButton.Name = "AnswerQuestionToolStripButton"
        Me.AnswerQuestionToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AnswerQuestionToolStripButton.Text = "Answer Question"
        Me.AnswerQuestionToolStripButton.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.Location = New System.Drawing.Point(8, 8)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Size = New System.Drawing.Size(147, 84)
        Me.StylizedPanel1.Style = "Colors=#536ca4|#1a2640|#263552|#3a4d6b" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|0.3|0.8|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=3" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=#1f2b41" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=#4e79ae" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.StylizedPanel1.TabIndex = 0
        '
        'frmViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewer"
        Me.Text = "Thorn Viewer - Untitled"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.StylizedPanel2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GoToToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DonateToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BugReportToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AboutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenSidebarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel
    Friend WithEvents StylizedPanel2 As Tundra.StylizedPanel
    Friend WithEvents lblFamily As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtbDescription As Tundra.TransparentRichTextBox
    Friend WithEvents tcSlides As Thorn.DoubleBufferedTabs
    Friend WithEvents kuiMain As Thorn.KeyboardUI
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AnswerQuestionToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ForwardToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnVocabulary As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel1 As Tundra.DoubleBufferedPanel
End Class
