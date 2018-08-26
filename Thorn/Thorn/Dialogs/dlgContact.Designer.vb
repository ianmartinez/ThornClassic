<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgContact
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
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblAt = New System.Windows.Forms.Label()
        Me.cbEmail = New System.Windows.Forms.ComboBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.rbBug = New System.Windows.Forms.RadioButton()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.rbSuggestions = New System.Windows.Forms.RadioButton()
        Me.rbOther = New System.Windows.Forms.RadioButton()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.tbrRating = New System.Windows.Forms.TrackBar()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.lblTerrible = New System.Windows.Forms.Label()
        Me.lblGreat = New System.Windows.Forms.Label()
        CType(Me.tbrRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(267, 280)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 19
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(348, 280)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(111, 12)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 20)
        Me.txtEmail.TabIndex = 20
        '
        'lblAt
        '
        Me.lblAt.AutoSize = True
        Me.lblAt.Location = New System.Drawing.Point(267, 15)
        Me.lblAt.Name = "lblAt"
        Me.lblAt.Size = New System.Drawing.Size(18, 13)
        Me.lblAt.TabIndex = 21
        Me.lblAt.Text = "@"
        '
        'cbEmail
        '
        Me.cbEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmail.FormattingEnabled = True
        Me.cbEmail.Items.AddRange(New Object() {"aol.com", "att.net", "comcast.net", "earthlink.net", "gmail.com", "hotmail.com", "live.com", "outlook.com", "verizon.net", "yahoo.com"})
        Me.cbEmail.Location = New System.Drawing.Point(291, 12)
        Me.cbEmail.Name = "cbEmail"
        Me.cbEmail.Size = New System.Drawing.Size(132, 21)
        Me.cbEmail.TabIndex = 22
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 15)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(72, 13)
        Me.lblEmail.TabIndex = 23
        Me.lblEmail.Text = "Sender Email:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 41)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(93, 13)
        Me.lblPassword.TabIndex = 25
        Me.lblPassword.Text = "Sender Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(111, 38)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(312, 20)
        Me.txtPassword.TabIndex = 24
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(111, 125)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMessage.Size = New System.Drawing.Size(312, 149)
        Me.txtMessage.TabIndex = 26
        '
        'rbBug
        '
        Me.rbBug.AutoSize = True
        Me.rbBug.Location = New System.Drawing.Point(111, 64)
        Me.rbBug.Name = "rbBug"
        Me.rbBug.Size = New System.Drawing.Size(54, 17)
        Me.rbBug.TabIndex = 27
        Me.rbBug.TabStop = True
        Me.rbBug.Text = "A Bug"
        Me.rbBug.UseVisualStyleBackColor = True
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(12, 66)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(46, 13)
        Me.lblSubject.TabIndex = 28
        Me.lblSubject.Text = "Subject:"
        '
        'rbSuggestions
        '
        Me.rbSuggestions.AutoSize = True
        Me.rbSuggestions.Location = New System.Drawing.Point(171, 64)
        Me.rbSuggestions.Name = "rbSuggestions"
        Me.rbSuggestions.Size = New System.Drawing.Size(83, 17)
        Me.rbSuggestions.TabIndex = 29
        Me.rbSuggestions.TabStop = True
        Me.rbSuggestions.Text = "Suggestions"
        Me.rbSuggestions.UseVisualStyleBackColor = True
        '
        'rbOther
        '
        Me.rbOther.AutoSize = True
        Me.rbOther.Location = New System.Drawing.Point(260, 64)
        Me.rbOther.Name = "rbOther"
        Me.rbOther.Size = New System.Drawing.Size(51, 17)
        Me.rbOther.TabIndex = 30
        Me.rbOther.TabStop = True
        Me.rbOther.Text = "Other"
        Me.rbOther.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(12, 128)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(53, 13)
        Me.lblMessage.TabIndex = 31
        Me.lblMessage.Text = "Message:"
        '
        'tbrRating
        '
        Me.tbrRating.AutoSize = False
        Me.tbrRating.Location = New System.Drawing.Point(156, 87)
        Me.tbrRating.Name = "tbrRating"
        Me.tbrRating.Size = New System.Drawing.Size(228, 32)
        Me.tbrRating.TabIndex = 32
        Me.tbrRating.Value = 5
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Location = New System.Drawing.Point(12, 91)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(84, 13)
        Me.lblRating.TabIndex = 33
        Me.lblRating.Text = "Rating of Thorn:"
        '
        'lblTerrible
        '
        Me.lblTerrible.AutoSize = True
        Me.lblTerrible.Location = New System.Drawing.Point(108, 91)
        Me.lblTerrible.Name = "lblTerrible"
        Me.lblTerrible.Size = New System.Drawing.Size(42, 13)
        Me.lblTerrible.TabIndex = 34
        Me.lblTerrible.Text = "Terrible"
        '
        'lblGreat
        '
        Me.lblGreat.AutoSize = True
        Me.lblGreat.Location = New System.Drawing.Point(390, 91)
        Me.lblGreat.Name = "lblGreat"
        Me.lblGreat.Size = New System.Drawing.Size(33, 13)
        Me.lblGreat.TabIndex = 35
        Me.lblGreat.Text = "Great"
        '
        'dlgContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.lblGreat)
        Me.Controls.Add(Me.lblTerrible)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.tbrRating)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.rbOther)
        Me.Controls.Add(Me.rbSuggestions)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.rbBug)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.cbEmail)
        Me.Controls.Add(Me.lblAt)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgContact"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Contact"
        CType(Me.tbrRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblAt As System.Windows.Forms.Label
    Friend WithEvents cbEmail As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents rbBug As System.Windows.Forms.RadioButton
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents rbSuggestions As System.Windows.Forms.RadioButton
    Friend WithEvents rbOther As System.Windows.Forms.RadioButton
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents tbrRating As System.Windows.Forms.TrackBar
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents lblTerrible As System.Windows.Forms.Label
    Friend WithEvents lblGreat As System.Windows.Forms.Label

End Class
