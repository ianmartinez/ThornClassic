<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDisplay
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.rbNone = New System.Windows.Forms.RadioButton()
        Me.rbText = New System.Windows.Forms.RadioButton()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.rbImage = New System.Windows.Forms.RadioButton()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.txtWebpage = New System.Windows.Forms.TextBox()
        Me.rbWebPage = New System.Windows.Forms.RadioButton()
        Me.rbMedia = New System.Windows.Forms.RadioButton()
        Me.btnImportMedia = New System.Windows.Forms.Button()
        Me.dlgOpenMedia = New System.Windows.Forms.OpenFileDialog()
        Me.dlgOpenImage = New System.Windows.Forms.OpenFileDialog()
        Me.txtMediaTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.pMain = New Thorn.Player()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(267, 343)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(348, 343)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'rbNone
        '
        Me.rbNone.AutoSize = True
        Me.rbNone.Checked = True
        Me.rbNone.Location = New System.Drawing.Point(12, 12)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Size = New System.Drawing.Size(51, 17)
        Me.rbNone.TabIndex = 5
        Me.rbNone.TabStop = True
        Me.rbNone.Text = "None"
        Me.rbNone.UseVisualStyleBackColor = True
        '
        'rbText
        '
        Me.rbText.AutoSize = True
        Me.rbText.Location = New System.Drawing.Point(12, 35)
        Me.rbText.Name = "rbText"
        Me.rbText.Size = New System.Drawing.Size(49, 17)
        Me.rbText.TabIndex = 6
        Me.rbText.Text = "Text:"
        Me.rbText.UseVisualStyleBackColor = True
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(97, 34)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(324, 20)
        Me.txtText.TabIndex = 7
        '
        'rbImage
        '
        Me.rbImage.AutoSize = True
        Me.rbImage.Location = New System.Drawing.Point(12, 101)
        Me.rbImage.Name = "rbImage"
        Me.rbImage.Size = New System.Drawing.Size(57, 17)
        Me.rbImage.TabIndex = 8
        Me.rbImage.Text = "Image:"
        Me.rbImage.UseVisualStyleBackColor = True
        '
        'btnImage
        '
        Me.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImage.Location = New System.Drawing.Point(98, 86)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(325, 47)
        Me.btnImage.TabIndex = 9
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'txtWebpage
        '
        Me.txtWebpage.Location = New System.Drawing.Point(97, 60)
        Me.txtWebpage.Name = "txtWebpage"
        Me.txtWebpage.Size = New System.Drawing.Size(324, 20)
        Me.txtWebpage.TabIndex = 11
        '
        'rbWebPage
        '
        Me.rbWebPage.AutoSize = True
        Me.rbWebPage.Location = New System.Drawing.Point(12, 61)
        Me.rbWebPage.Name = "rbWebPage"
        Me.rbWebPage.Size = New System.Drawing.Size(79, 17)
        Me.rbWebPage.TabIndex = 10
        Me.rbWebPage.Text = "Web Page:"
        Me.rbWebPage.UseVisualStyleBackColor = True
        '
        'rbMedia
        '
        Me.rbMedia.AutoSize = True
        Me.rbMedia.Location = New System.Drawing.Point(12, 142)
        Me.rbMedia.Name = "rbMedia"
        Me.rbMedia.Size = New System.Drawing.Size(57, 17)
        Me.rbMedia.TabIndex = 12
        Me.rbMedia.Text = "Media:"
        Me.rbMedia.UseVisualStyleBackColor = True
        '
        'btnImportMedia
        '
        Me.btnImportMedia.Location = New System.Drawing.Point(97, 139)
        Me.btnImportMedia.Name = "btnImportMedia"
        Me.btnImportMedia.Size = New System.Drawing.Size(75, 23)
        Me.btnImportMedia.TabIndex = 13
        Me.btnImportMedia.Text = "Import..."
        Me.btnImportMedia.UseVisualStyleBackColor = True
        '
        'dlgOpenMedia
        '
        Me.dlgOpenMedia.Filter = "Audio files|*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mid;*.midi;*.rmi;*.aif;*.aifc;*.aiff;" & _
    "*.au;*.snd;*.wav;*.cda;*.m4a|Video Files|*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*." & _
    "mov|All Files|*.*"
        '
        'dlgOpenImage
        '
        Me.dlgOpenImage.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|All file" & _
    "s (*.*)|*.*"
        '
        'txtMediaTitle
        '
        Me.txtMediaTitle.Location = New System.Drawing.Point(245, 310)
        Me.txtMediaTitle.Name = "txtMediaTitle"
        Me.txtMediaTitle.Size = New System.Drawing.Size(135, 20)
        Me.txtMediaTitle.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Media Title:"
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(386, 308)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(37, 23)
        Me.btnSet.TabIndex = 18
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'pMain
        '
        Me.pMain.Location = New System.Drawing.Point(180, 139)
        Me.pMain.Media = Nothing
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(243, 165)
        Me.pMain.TabIndex = 17
        '
        'dlgDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 378)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.pMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMediaTitle)
        Me.Controls.Add(Me.btnImportMedia)
        Me.Controls.Add(Me.rbMedia)
        Me.Controls.Add(Me.txtWebpage)
        Me.Controls.Add(Me.rbWebPage)
        Me.Controls.Add(Me.btnImage)
        Me.Controls.Add(Me.rbImage)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.rbText)
        Me.Controls.Add(Me.rbNone)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplay"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Display"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents rbNone As System.Windows.Forms.RadioButton
    Friend WithEvents rbText As System.Windows.Forms.RadioButton
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents rbImage As System.Windows.Forms.RadioButton
    Friend WithEvents btnImage As System.Windows.Forms.Button
    Friend WithEvents txtWebpage As System.Windows.Forms.TextBox
    Friend WithEvents rbWebPage As System.Windows.Forms.RadioButton
    Friend WithEvents rbMedia As System.Windows.Forms.RadioButton
    Friend WithEvents btnImportMedia As System.Windows.Forms.Button
    Friend WithEvents dlgOpenMedia As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgOpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtMediaTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pMain As Player
    Friend WithEvents btnSet As System.Windows.Forms.Button

End Class
