<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveAsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.KeyboardToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.VocabularyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PagePropertiesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomizeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RemoveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RemoveAllToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TypesToolStripButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.QuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultipleChoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreeResponseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GoToToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BackToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ForwardToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RunToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenKeyboardToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tcSlides = New Thorn.DoubleBufferedTabs()
        Me.kuiMain = New Thorn.KeyboardUI()
        Me.tmrWork = New System.Windows.Forms.Timer(Me.components)
        Me.MainToolStrip.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Thorn files (*.th)|*.th|All files (*.*)|*.*"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Thorn files (*.th)|*.th|All files (*.*)|*.*"
        '
        'MainToolStrip
        '
        Me.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.SaveAsToolStripButton, Me.toolStripSeparator, Me.KeyboardToolStripButton, Me.VocabularyToolStripButton, Me.PagePropertiesToolStripButton, Me.CustomizeToolStripButton, Me.toolStripSeparator1, Me.AddToolStripButton, Me.RemoveToolStripButton, Me.RemoveAllToolStripButton, Me.TypesToolStripButton, Me.ToolStripSeparator2, Me.GoToToolStripButton, Me.BackToolStripButton, Me.ForwardToolStripButton, Me.ToolStripSeparator3, Me.RunToolStripButton, Me.ToolStripSeparator4, Me.AboutToolStripButton, Me.OpenKeyboardToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MainToolStrip.Size = New System.Drawing.Size(684, 25)
        Me.MainToolStrip.TabIndex = 4
        Me.MainToolStrip.Text = "About"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "Save"
        '
        'SaveAsToolStripButton
        '
        Me.SaveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveAsToolStripButton.Image = CType(resources.GetObject("SaveAsToolStripButton.Image"), System.Drawing.Image)
        Me.SaveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveAsToolStripButton.Name = "SaveAsToolStripButton"
        Me.SaveAsToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveAsToolStripButton.Text = "Save As"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'KeyboardToolStripButton
        '
        Me.KeyboardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KeyboardToolStripButton.Image = CType(resources.GetObject("KeyboardToolStripButton.Image"), System.Drawing.Image)
        Me.KeyboardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KeyboardToolStripButton.Name = "KeyboardToolStripButton"
        Me.KeyboardToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.KeyboardToolStripButton.Text = "Keyboard"
        '
        'VocabularyToolStripButton
        '
        Me.VocabularyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VocabularyToolStripButton.Image = CType(resources.GetObject("VocabularyToolStripButton.Image"), System.Drawing.Image)
        Me.VocabularyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.VocabularyToolStripButton.Name = "VocabularyToolStripButton"
        Me.VocabularyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.VocabularyToolStripButton.Text = "Vocabulary"
        '
        'PagePropertiesToolStripButton
        '
        Me.PagePropertiesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PagePropertiesToolStripButton.Image = CType(resources.GetObject("PagePropertiesToolStripButton.Image"), System.Drawing.Image)
        Me.PagePropertiesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PagePropertiesToolStripButton.Name = "PagePropertiesToolStripButton"
        Me.PagePropertiesToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PagePropertiesToolStripButton.Text = "Page Properties"
        '
        'CustomizeToolStripButton
        '
        Me.CustomizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomizeToolStripButton.Image = CType(resources.GetObject("CustomizeToolStripButton.Image"), System.Drawing.Image)
        Me.CustomizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CustomizeToolStripButton.Name = "CustomizeToolStripButton"
        Me.CustomizeToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CustomizeToolStripButton.Text = "Customization"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolStripButton.Image = CType(resources.GetObject("AddToolStripButton.Image"), System.Drawing.Image)
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AddToolStripButton.Text = "Add Page"
        '
        'RemoveToolStripButton
        '
        Me.RemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveToolStripButton.Image = CType(resources.GetObject("RemoveToolStripButton.Image"), System.Drawing.Image)
        Me.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveToolStripButton.Name = "RemoveToolStripButton"
        Me.RemoveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.RemoveToolStripButton.Text = "Remove Page"
        '
        'RemoveAllToolStripButton
        '
        Me.RemoveAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveAllToolStripButton.Image = CType(resources.GetObject("RemoveAllToolStripButton.Image"), System.Drawing.Image)
        Me.RemoveAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveAllToolStripButton.Name = "RemoveAllToolStripButton"
        Me.RemoveAllToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.RemoveAllToolStripButton.Text = "Remove All"
        '
        'TypesToolStripButton
        '
        Me.TypesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TypesToolStripButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuestionToolStripMenuItem, Me.ImageToolStripMenuItem, Me.TitleToolStripMenuItem, Me.TextToolStripMenuItem, Me.MediaToolStripMenuItem, Me.WebBrowserToolStripMenuItem})
        Me.TypesToolStripButton.Image = CType(resources.GetObject("TypesToolStripButton.Image"), System.Drawing.Image)
        Me.TypesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TypesToolStripButton.Name = "TypesToolStripButton"
        Me.TypesToolStripButton.Size = New System.Drawing.Size(32, 22)
        Me.TypesToolStripButton.Text = "Types"
        '
        'QuestionToolStripMenuItem
        '
        Me.QuestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MultipleChoiceToolStripMenuItem, Me.FreeResponseToolStripMenuItem})
        Me.QuestionToolStripMenuItem.Image = CType(resources.GetObject("QuestionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuestionToolStripMenuItem.Name = "QuestionToolStripMenuItem"
        Me.QuestionToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.QuestionToolStripMenuItem.Text = "Question"
        '
        'MultipleChoiceToolStripMenuItem
        '
        Me.MultipleChoiceToolStripMenuItem.Image = CType(resources.GetObject("MultipleChoiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MultipleChoiceToolStripMenuItem.Name = "MultipleChoiceToolStripMenuItem"
        Me.MultipleChoiceToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.MultipleChoiceToolStripMenuItem.Text = "Multiple Choice"
        '
        'FreeResponseToolStripMenuItem
        '
        Me.FreeResponseToolStripMenuItem.Image = CType(resources.GetObject("FreeResponseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FreeResponseToolStripMenuItem.Name = "FreeResponseToolStripMenuItem"
        Me.FreeResponseToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.FreeResponseToolStripMenuItem.Text = "Free Response"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Image = CType(resources.GetObject("ImageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'TitleToolStripMenuItem
        '
        Me.TitleToolStripMenuItem.Image = CType(resources.GetObject("TitleToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem"
        Me.TitleToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.TitleToolStripMenuItem.Text = "Title"
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.Image = CType(resources.GetObject("TextToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.TextToolStripMenuItem.Text = "Text"
        '
        'MediaToolStripMenuItem
        '
        Me.MediaToolStripMenuItem.Image = CType(resources.GetObject("MediaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MediaToolStripMenuItem.Name = "MediaToolStripMenuItem"
        Me.MediaToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.MediaToolStripMenuItem.Text = "Media"
        '
        'WebBrowserToolStripMenuItem
        '
        Me.WebBrowserToolStripMenuItem.Image = CType(resources.GetObject("WebBrowserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WebBrowserToolStripMenuItem.Name = "WebBrowserToolStripMenuItem"
        Me.WebBrowserToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.WebBrowserToolStripMenuItem.Text = "Web Browser"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'RunToolStripButton
        '
        Me.RunToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RunToolStripButton.Image = CType(resources.GetObject("RunToolStripButton.Image"), System.Drawing.Image)
        Me.RunToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RunToolStripButton.Name = "RunToolStripButton"
        Me.RunToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.RunToolStripButton.Text = "Run"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        'OpenKeyboardToolStripButton
        '
        Me.OpenKeyboardToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OpenKeyboardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenKeyboardToolStripButton.Image = CType(resources.GetObject("OpenKeyboardToolStripButton.Image"), System.Drawing.Image)
        Me.OpenKeyboardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenKeyboardToolStripButton.Name = "OpenKeyboardToolStripButton"
        Me.OpenKeyboardToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenKeyboardToolStripButton.Text = "Open Keyboard"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(684, 344)
        Me.SplitContainer1.SplitterDistance = 516
        Me.SplitContainer1.TabIndex = 5
        '
        'tcSlides
        '
        Me.tcSlides.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcSlides.Location = New System.Drawing.Point(0, 0)
        Me.tcSlides.Name = "tcSlides"
        Me.tcSlides.SelectedIndex = 0
        Me.tcSlides.Size = New System.Drawing.Size(516, 344)
        Me.tcSlides.TabIndex = 2
        '
        'kuiMain
        '
        Me.kuiMain.AutoScroll = True
        Me.kuiMain.BackColor = System.Drawing.Color.Transparent
        Me.kuiMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kuiMain.Location = New System.Drawing.Point(0, 0)
        Me.kuiMain.Margin = New System.Windows.Forms.Padding(5)
        Me.kuiMain.Name = "kuiMain"
        Me.kuiMain.Padding = New System.Windows.Forms.Padding(5)
        Me.kuiMain.Size = New System.Drawing.Size(164, 344)
        Me.kuiMain.TabIndex = 0
        Me.kuiMain.TextControl = Nothing
        '
        'tmrWork
        '
        Me.tmrWork.Interval = 2500
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 369)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MainToolStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(100, 400)
        Me.Name = "frmMain"
        Me.Text = "Thorn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sp5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbDesign As System.Windows.Forms.ToolBarButton
    Friend WithEvents QuestionWorkspace1 As Thorn.MultipleChoiceWorkspace
    Friend WithEvents tbRun As System.Windows.Forms.ToolBarButton
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MainToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveAsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KeyboardToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents VocabularyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PagePropertiesToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomizeToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RemoveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GoToToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ForwardToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RunToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RemoveAllToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TypesToolStripButton As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents QuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MultipleChoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FreeResponseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BugReportToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AboutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenKeyboardToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents kuiMain As Thorn.KeyboardUI
    Friend WithEvents tcSlides As Thorn.DoubleBufferedTabs
    Friend WithEvents tmrWork As Timer
End Class
