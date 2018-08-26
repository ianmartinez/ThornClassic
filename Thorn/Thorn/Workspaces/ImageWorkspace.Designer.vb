<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageWorkspace
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
        Me.pnlImage = New thGradientPanel()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.pctImage = New System.Windows.Forms.PictureBox()
        Me.cbCaption = New System.Windows.Forms.CheckBox()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.pnlImage.SuspendLayout()
        CType(Me.pctImage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.scMain.Panel1.Controls.Add(Me.pnlImage)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.txtCaption)
        Me.scMain.Panel2.Controls.Add(Me.cbCaption)
        Me.scMain.Size = New System.Drawing.Size(387, 309)
        Me.scMain.SplitterDistance = 270
        Me.scMain.TabIndex = 6
        '
        'pnlImage
        '
        Me.pnlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlImage.Controls.Add(Me.btnImport)
        Me.pnlImage.Controls.Add(Me.pctImage)
        Me.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlImage.Location = New System.Drawing.Point(0, 0)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(387, 270)
        Me.pnlImage.TabIndex = 6
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.BackColor = System.Drawing.Color.Transparent
        Me.btnImport.Location = New System.Drawing.Point(309, 3)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 5
        Me.btnImport.Text = "Import..."
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'pctImage
        '
        Me.pctImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctImage.Location = New System.Drawing.Point(0, 0)
        Me.pctImage.Name = "pctImage"
        Me.pctImage.Size = New System.Drawing.Size(387, 270)
        Me.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctImage.TabIndex = 6
        Me.pctImage.TabStop = False
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
        'dlgOpen
        '
        Me.dlgOpen.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|All file" & _
            "s (*.*)|*.*"
        '
        'ImageWorkspace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.scMain)
        Me.Name = "ImageWorkspace"
        Me.Size = New System.Drawing.Size(387, 309)
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel2.ResumeLayout(False)
        Me.scMain.Panel2.PerformLayout()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.pnlImage.ResumeLayout(False)
        CType(Me.pctImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCaption As System.Windows.Forms.TextBox
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents cbCaption As System.Windows.Forms.CheckBox
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnlImage As thGradientPanel
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents pctImage As System.Windows.Forms.PictureBox

End Class
