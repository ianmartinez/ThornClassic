<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RichTextEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RichTextEditor))
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.UndoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RedoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BoldToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ItalicToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.UnderlineToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StrikeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextColorToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.HighlightColorToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BackColorToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlignLeftToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AlignCenterToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AlignRightToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripSplitButton()
        Me.IndentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PxToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PxToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PxToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripSplitButton()
        Me.AddBulletsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveBulletsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddImageToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.rtbDoc = New Tundra.ExtendedRichTextBox()
        Me.MainToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainToolStrip
        '
        Me.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripButton, Me.RedoToolStripButton, Me.ToolStripSeparator6, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.CutToolStripButton, Me.ToolStripSeparator7, Me.FontToolStripButton, Me.ToolStripSeparator1, Me.BoldToolStripButton, Me.ItalicToolStripButton, Me.UnderlineToolStripButton, Me.StrikeToolStripButton, Me.ToolStripSeparator4, Me.TextColorToolStripButton, Me.HighlightColorToolStripButton, Me.BackColorToolStripButton, Me.ToolStripSeparator2, Me.AlignLeftToolStripButton, Me.AlignCenterToolStripButton, Me.AlignRightToolStripButton, Me.ToolStripSeparator3, Me.ToolStripButton11, Me.ToolStripButton10, Me.ToolStripSeparator5, Me.AddImageToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainToolStrip.Size = New System.Drawing.Size(553, 25)
        Me.MainToolStrip.TabIndex = 5
        Me.MainToolStrip.Text = "About"
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoToolStripButton.Image = CType(resources.GetObject("UndoToolStripButton.Image"), System.Drawing.Image)
        Me.UndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoToolStripButton.Name = "UndoToolStripButton"
        Me.UndoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.UndoToolStripButton.Text = "Undo"
        '
        'RedoToolStripButton
        '
        Me.RedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RedoToolStripButton.Image = CType(resources.GetObject("RedoToolStripButton.Image"), System.Drawing.Image)
        Me.RedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RedoToolStripButton.Name = "RedoToolStripButton"
        Me.RedoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.RedoToolStripButton.Text = "Redo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "Paste"
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "Cut"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'FontToolStripButton
        '
        Me.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FontToolStripButton.Image = CType(resources.GetObject("FontToolStripButton.Image"), System.Drawing.Image)
        Me.FontToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontToolStripButton.Name = "FontToolStripButton"
        Me.FontToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.FontToolStripButton.Text = "Font"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BoldToolStripButton
        '
        Me.BoldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BoldToolStripButton.Image = CType(resources.GetObject("BoldToolStripButton.Image"), System.Drawing.Image)
        Me.BoldToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BoldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BoldToolStripButton.Name = "BoldToolStripButton"
        Me.BoldToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BoldToolStripButton.Text = "Bold"
        '
        'ItalicToolStripButton
        '
        Me.ItalicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItalicToolStripButton.Image = CType(resources.GetObject("ItalicToolStripButton.Image"), System.Drawing.Image)
        Me.ItalicToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ItalicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ItalicToolStripButton.Name = "ItalicToolStripButton"
        Me.ItalicToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ItalicToolStripButton.Text = "Italic"
        '
        'UnderlineToolStripButton
        '
        Me.UnderlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UnderlineToolStripButton.Image = CType(resources.GetObject("UnderlineToolStripButton.Image"), System.Drawing.Image)
        Me.UnderlineToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UnderlineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UnderlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UnderlineToolStripButton.Name = "UnderlineToolStripButton"
        Me.UnderlineToolStripButton.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.UnderlineToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.UnderlineToolStripButton.Text = "Underline"
        '
        'StrikeToolStripButton
        '
        Me.StrikeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StrikeToolStripButton.Image = CType(resources.GetObject("StrikeToolStripButton.Image"), System.Drawing.Image)
        Me.StrikeToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StrikeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StrikeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StrikeToolStripButton.Name = "StrikeToolStripButton"
        Me.StrikeToolStripButton.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.StrikeToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.StrikeToolStripButton.Text = "Strike"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'TextColorToolStripButton
        '
        Me.TextColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TextColorToolStripButton.Image = CType(resources.GetObject("TextColorToolStripButton.Image"), System.Drawing.Image)
        Me.TextColorToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TextColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TextColorToolStripButton.Name = "TextColorToolStripButton"
        Me.TextColorToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.TextColorToolStripButton.Text = "Text Color"
        '
        'HighlightColorToolStripButton
        '
        Me.HighlightColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HighlightColorToolStripButton.Image = CType(resources.GetObject("HighlightColorToolStripButton.Image"), System.Drawing.Image)
        Me.HighlightColorToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HighlightColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HighlightColorToolStripButton.Name = "HighlightColorToolStripButton"
        Me.HighlightColorToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HighlightColorToolStripButton.Text = "Highlight Color"
        '
        'BackColorToolStripButton
        '
        Me.BackColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackColorToolStripButton.Image = CType(resources.GetObject("BackColorToolStripButton.Image"), System.Drawing.Image)
        Me.BackColorToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BackColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackColorToolStripButton.Name = "BackColorToolStripButton"
        Me.BackColorToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BackColorToolStripButton.Text = "Background Color"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AlignLeftToolStripButton
        '
        Me.AlignLeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignLeftToolStripButton.Image = CType(resources.GetObject("AlignLeftToolStripButton.Image"), System.Drawing.Image)
        Me.AlignLeftToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignLeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignLeftToolStripButton.Name = "AlignLeftToolStripButton"
        Me.AlignLeftToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AlignLeftToolStripButton.Text = "Align Left"
        '
        'AlignCenterToolStripButton
        '
        Me.AlignCenterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignCenterToolStripButton.Image = CType(resources.GetObject("AlignCenterToolStripButton.Image"), System.Drawing.Image)
        Me.AlignCenterToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignCenterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignCenterToolStripButton.Name = "AlignCenterToolStripButton"
        Me.AlignCenterToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AlignCenterToolStripButton.Text = "Align Center"
        '
        'AlignRightToolStripButton
        '
        Me.AlignRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignRightToolStripButton.Image = CType(resources.GetObject("AlignRightToolStripButton.Image"), System.Drawing.Image)
        Me.AlignRightToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignRightToolStripButton.Name = "AlignRightToolStripButton"
        Me.AlignRightToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AlignRightToolStripButton.Text = "Align Right"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndentToolStripMenuItem, Me.AlignToolStripMenuItem})
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripButton11.Text = "Indent"
        '
        'IndentToolStripMenuItem
        '
        Me.IndentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoneToolStripMenuItem, Me.PxToolStripMenuItem, Me.PxToolStripMenuItem1, Me.PxToolStripMenuItem2, Me.PxToolStripMenuItem3})
        Me.IndentToolStripMenuItem.Name = "IndentToolStripMenuItem"
        Me.IndentToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.IndentToolStripMenuItem.Text = "Indent"
        '
        'NoneToolStripMenuItem
        '
        Me.NoneToolStripMenuItem.Image = CType(resources.GetObject("NoneToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NoneToolStripMenuItem.Name = "NoneToolStripMenuItem"
        Me.NoneToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NoneToolStripMenuItem.Text = "None"
        '
        'PxToolStripMenuItem
        '
        Me.PxToolStripMenuItem.Image = CType(resources.GetObject("PxToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PxToolStripMenuItem.Name = "PxToolStripMenuItem"
        Me.PxToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.PxToolStripMenuItem.Text = "5px"
        '
        'PxToolStripMenuItem1
        '
        Me.PxToolStripMenuItem1.Image = CType(resources.GetObject("PxToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PxToolStripMenuItem1.Name = "PxToolStripMenuItem1"
        Me.PxToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.PxToolStripMenuItem1.Text = "10px"
        '
        'PxToolStripMenuItem2
        '
        Me.PxToolStripMenuItem2.Image = CType(resources.GetObject("PxToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.PxToolStripMenuItem2.Name = "PxToolStripMenuItem2"
        Me.PxToolStripMenuItem2.Size = New System.Drawing.Size(103, 22)
        Me.PxToolStripMenuItem2.Text = "15px"
        '
        'PxToolStripMenuItem3
        '
        Me.PxToolStripMenuItem3.Image = CType(resources.GetObject("PxToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.PxToolStripMenuItem3.Name = "PxToolStripMenuItem3"
        Me.PxToolStripMenuItem3.Size = New System.Drawing.Size(103, 22)
        Me.PxToolStripMenuItem3.Text = "20px"
        '
        'AlignToolStripMenuItem
        '
        Me.AlignToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeftToolStripMenuItem, Me.CenterToolStripMenuItem, Me.RightToolStripMenuItem})
        Me.AlignToolStripMenuItem.Name = "AlignToolStripMenuItem"
        Me.AlignToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.AlignToolStripMenuItem.Text = "Align"
        '
        'LeftToolStripMenuItem
        '
        Me.LeftToolStripMenuItem.Image = CType(resources.GetObject("LeftToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LeftToolStripMenuItem.Name = "LeftToolStripMenuItem"
        Me.LeftToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.LeftToolStripMenuItem.Text = "Left"
        '
        'CenterToolStripMenuItem
        '
        Me.CenterToolStripMenuItem.Image = CType(resources.GetObject("CenterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CenterToolStripMenuItem.Name = "CenterToolStripMenuItem"
        Me.CenterToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CenterToolStripMenuItem.Text = "Center"
        '
        'RightToolStripMenuItem
        '
        Me.RightToolStripMenuItem.Image = CType(resources.GetObject("RightToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RightToolStripMenuItem.Name = "RightToolStripMenuItem"
        Me.RightToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.RightToolStripMenuItem.Text = "Right"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBulletsToolStripMenuItem, Me.RemoveBulletsToolStripMenuItem})
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripButton10.Text = "List"
        '
        'AddBulletsToolStripMenuItem
        '
        Me.AddBulletsToolStripMenuItem.Image = CType(resources.GetObject("AddBulletsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddBulletsToolStripMenuItem.Name = "AddBulletsToolStripMenuItem"
        Me.AddBulletsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AddBulletsToolStripMenuItem.Text = "Add Bullets"
        '
        'RemoveBulletsToolStripMenuItem
        '
        Me.RemoveBulletsToolStripMenuItem.Image = CType(resources.GetObject("RemoveBulletsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveBulletsToolStripMenuItem.Name = "RemoveBulletsToolStripMenuItem"
        Me.RemoveBulletsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.RemoveBulletsToolStripMenuItem.Text = "Remove Bullets"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'AddImageToolStripButton
        '
        Me.AddImageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddImageToolStripButton.Image = CType(resources.GetObject("AddImageToolStripButton.Image"), System.Drawing.Image)
        Me.AddImageToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddImageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddImageToolStripButton.Name = "AddImageToolStripButton"
        Me.AddImageToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AddImageToolStripButton.Text = "Insert Image"
        '
        'dlgFont
        '
        Me.dlgFont.ShowColor = True
        '
        'rtbDoc
        '
        Me.rtbDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDoc.Location = New System.Drawing.Point(0, 25)
        Me.rtbDoc.Name = "rtbDoc"
        Me.rtbDoc.Size = New System.Drawing.Size(553, 354)
        Me.rtbDoc.TabIndex = 0
        Me.rtbDoc.Text = ""
        '
        'RichTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.rtbDoc)
        Me.Controls.Add(Me.MainToolStrip)
        Me.Name = "RichTextEditor"
        Me.Size = New System.Drawing.Size(553, 379)
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbDoc As Tundra.ExtendedRichTextBox
    Friend WithEvents MainToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FontToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BoldToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItalicToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UnderlineToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents StrikeToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AlignLeftToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextColorToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackColorToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents HighlightColorToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AlignCenterToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AlignRightToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents IndentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PxToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PxToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PxToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents AddBulletsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveBulletsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddImageToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents dlgFont As System.Windows.Forms.FontDialog
    Friend WithEvents UndoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RedoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator

End Class
