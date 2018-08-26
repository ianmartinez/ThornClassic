<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCustomize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCustomize))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtLanguageDescription = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbLanguageNotEndangered = New System.Windows.Forms.RadioButton()
        Me.rbLanguageEndangered = New System.Windows.Forms.RadioButton()
        Me.rbLanguageCriticallyEndangered = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbLanguageConstructed = New System.Windows.Forms.RadioButton()
        Me.rbLanguageNatural = New System.Windows.Forms.RadioButton()
        Me.txtLanguageName = New System.Windows.Forms.TextBox()
        Me.txtLanguageFamily = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBrowseIcon = New System.Windows.Forms.Button()
        Me.pctIcon = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudVersion = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DoubleBufferedTabs1 = New Thorn.DoubleBufferedTabs()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnBackgroundGradient = New Thorn.GradientButton()
        Me.btnSolidColor = New System.Windows.Forms.Button()
        Me.rbGradient = New System.Windows.Forms.RadioButton()
        Me.rbSolidColor = New System.Windows.Forms.RadioButton()
        Me.pctBackground = New System.Windows.Forms.PictureBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.rbImage = New System.Windows.Forms.RadioButton()
        Me.rbNone = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbZoom = New System.Windows.Forms.RadioButton()
        Me.rbDefault = New System.Windows.Forms.RadioButton()
        Me.rbStretch = New System.Windows.Forms.RadioButton()
        Me.rbTile = New System.Windows.Forms.RadioButton()
        Me.rbCenter = New System.Windows.Forms.RadioButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.gbTitleFont = New System.Windows.Forms.GroupBox()
        Me.btnTitleFontColor = New System.Windows.Forms.Button()
        Me.lblTitlePreview = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnTitleFont = New System.Windows.Forms.Button()
        Me.gbFont = New System.Windows.Forms.GroupBox()
        Me.btnFontColor = New System.Windows.Forms.Button()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.dlgOpenImage = New System.Windows.Forms.OpenFileDialog()
        Me.dlgOpenIcon = New System.Windows.Forms.OpenFileDialog()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pctIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DoubleBufferedTabs1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.pctBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.gbTitleFont.SuspendLayout()
        Me.gbFont.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(375, 404)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(294, 404)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtLanguageDescription)
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Controls.Add(Me.txtLanguageName)
        Me.TabPage3.Controls.Add(Me.txtLanguageFamily)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(430, 360)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Language Data"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtLanguageDescription
        '
        Me.txtLanguageDescription.Location = New System.Drawing.Point(72, 110)
        Me.txtLanguageDescription.Multiline = True
        Me.txtLanguageDescription.Name = "txtLanguageDescription"
        Me.txtLanguageDescription.Size = New System.Drawing.Size(352, 221)
        Me.txtLanguageDescription.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbLanguageNotEndangered)
        Me.Panel2.Controls.Add(Me.rbLanguageEndangered)
        Me.Panel2.Controls.Add(Me.rbLanguageCriticallyEndangered)
        Me.Panel2.Location = New System.Drawing.Point(72, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(352, 20)
        Me.Panel2.TabIndex = 25
        '
        'rbLanguageNotEndangered
        '
        Me.rbLanguageNotEndangered.AutoSize = True
        Me.rbLanguageNotEndangered.Checked = True
        Me.rbLanguageNotEndangered.Location = New System.Drawing.Point(222, 0)
        Me.rbLanguageNotEndangered.Name = "rbLanguageNotEndangered"
        Me.rbLanguageNotEndangered.Size = New System.Drawing.Size(103, 17)
        Me.rbLanguageNotEndangered.TabIndex = 2
        Me.rbLanguageNotEndangered.TabStop = True
        Me.rbLanguageNotEndangered.Text = "Not Endangered"
        Me.rbLanguageNotEndangered.UseVisualStyleBackColor = True
        '
        'rbLanguageEndangered
        '
        Me.rbLanguageEndangered.AutoSize = True
        Me.rbLanguageEndangered.Location = New System.Drawing.Point(133, 0)
        Me.rbLanguageEndangered.Name = "rbLanguageEndangered"
        Me.rbLanguageEndangered.Size = New System.Drawing.Size(83, 17)
        Me.rbLanguageEndangered.TabIndex = 1
        Me.rbLanguageEndangered.Text = "Endangered"
        Me.rbLanguageEndangered.UseVisualStyleBackColor = True
        '
        'rbLanguageCriticallyEndangered
        '
        Me.rbLanguageCriticallyEndangered.AutoSize = True
        Me.rbLanguageCriticallyEndangered.Location = New System.Drawing.Point(3, 0)
        Me.rbLanguageCriticallyEndangered.Name = "rbLanguageCriticallyEndangered"
        Me.rbLanguageCriticallyEndangered.Size = New System.Drawing.Size(124, 17)
        Me.rbLanguageCriticallyEndangered.TabIndex = 0
        Me.rbLanguageCriticallyEndangered.Text = "Critically Endangered"
        Me.rbLanguageCriticallyEndangered.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Status:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbLanguageConstructed)
        Me.Panel1.Controls.Add(Me.rbLanguageNatural)
        Me.Panel1.Location = New System.Drawing.Point(72, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 20)
        Me.Panel1.TabIndex = 23
        '
        'rbLanguageConstructed
        '
        Me.rbLanguageConstructed.AutoSize = True
        Me.rbLanguageConstructed.Checked = True
        Me.rbLanguageConstructed.Location = New System.Drawing.Point(68, 0)
        Me.rbLanguageConstructed.Name = "rbLanguageConstructed"
        Me.rbLanguageConstructed.Size = New System.Drawing.Size(82, 17)
        Me.rbLanguageConstructed.TabIndex = 1
        Me.rbLanguageConstructed.TabStop = True
        Me.rbLanguageConstructed.Text = "Constructed"
        Me.rbLanguageConstructed.UseVisualStyleBackColor = True
        '
        'rbLanguageNatural
        '
        Me.rbLanguageNatural.AutoSize = True
        Me.rbLanguageNatural.Location = New System.Drawing.Point(3, 0)
        Me.rbLanguageNatural.Name = "rbLanguageNatural"
        Me.rbLanguageNatural.Size = New System.Drawing.Size(59, 17)
        Me.rbLanguageNatural.TabIndex = 0
        Me.rbLanguageNatural.Text = "Natural"
        Me.rbLanguageNatural.UseVisualStyleBackColor = True
        '
        'txtLanguageName
        '
        Me.txtLanguageName.Location = New System.Drawing.Point(72, 6)
        Me.txtLanguageName.Name = "txtLanguageName"
        Me.txtLanguageName.Size = New System.Drawing.Size(352, 20)
        Me.txtLanguageName.TabIndex = 14
        '
        'txtLanguageFamily
        '
        Me.txtLanguageFamily.Location = New System.Drawing.Point(72, 32)
        Me.txtLanguageFamily.Name = "txtLanguageFamily"
        Me.txtLanguageFamily.Size = New System.Drawing.Size(352, 20)
        Me.txtLanguageFamily.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Description:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Type:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Family:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtWebsite)
        Me.TabPage1.Controls.Add(Me.txtDescription)
        Me.TabPage1.Controls.Add(Me.txtTitle)
        Me.TabPage1.Controls.Add(Me.txtAuthor)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btnBrowseIcon)
        Me.TabPage1.Controls.Add(Me.pctIcon)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.nudVersion)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(430, 360)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(79, 58)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(345, 20)
        Me.txtWebsite.TabIndex = 14
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(79, 137)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(345, 217)
        Me.txtDescription.TabIndex = 12
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(79, 6)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(345, 20)
        Me.txtTitle.TabIndex = 2
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(79, 32)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(345, 20)
        Me.txtAuthor.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Website:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Description:"
        '
        'btnBrowseIcon
        '
        Me.btnBrowseIcon.Location = New System.Drawing.Point(364, 108)
        Me.btnBrowseIcon.Name = "btnBrowseIcon"
        Me.btnBrowseIcon.Size = New System.Drawing.Size(60, 23)
        Me.btnBrowseIcon.TabIndex = 10
        Me.btnBrowseIcon.Text = "Import..."
        Me.btnBrowseIcon.UseVisualStyleBackColor = True
        '
        'pctIcon
        '
        Me.pctIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctIcon.Location = New System.Drawing.Point(79, 110)
        Me.pctIcon.Name = "pctIcon"
        Me.pctIcon.Size = New System.Drawing.Size(279, 20)
        Me.pctIcon.TabIndex = 9
        Me.pctIcon.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Icon:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Version:"
        '
        'nudVersion
        '
        Me.nudVersion.DecimalPlaces = 2
        Me.nudVersion.Location = New System.Drawing.Point(79, 84)
        Me.nudVersion.Name = "nudVersion"
        Me.nudVersion.Size = New System.Drawing.Size(345, 20)
        Me.nudVersion.TabIndex = 5
        Me.nudVersion.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Author:"
        '
        'DoubleBufferedTabs1
        '
        Me.DoubleBufferedTabs1.Controls.Add(Me.TabPage1)
        Me.DoubleBufferedTabs1.Controls.Add(Me.TabPage3)
        Me.DoubleBufferedTabs1.Controls.Add(Me.TabPage5)
        Me.DoubleBufferedTabs1.Controls.Add(Me.TabPage4)
        Me.DoubleBufferedTabs1.Location = New System.Drawing.Point(12, 12)
        Me.DoubleBufferedTabs1.Name = "DoubleBufferedTabs1"
        Me.DoubleBufferedTabs1.SelectedIndex = 0
        Me.DoubleBufferedTabs1.Size = New System.Drawing.Size(438, 386)
        Me.DoubleBufferedTabs1.TabIndex = 10
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnBackgroundGradient)
        Me.TabPage5.Controls.Add(Me.btnSolidColor)
        Me.TabPage5.Controls.Add(Me.rbGradient)
        Me.TabPage5.Controls.Add(Me.rbSolidColor)
        Me.TabPage5.Controls.Add(Me.pctBackground)
        Me.TabPage5.Controls.Add(Me.btnImport)
        Me.TabPage5.Controls.Add(Me.rbImage)
        Me.TabPage5.Controls.Add(Me.rbNone)
        Me.TabPage5.Controls.Add(Me.Panel3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(430, 360)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Background"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnBackgroundGradient
        '
        Me.btnBackgroundGradient.Angle = 90
        Me.btnBackgroundGradient.BorderColor = System.Drawing.Color.Transparent
        Me.btnBackgroundGradient.BorderRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.btnBackgroundGradient.Colors = New System.Drawing.Color() {System.Drawing.Color.Azure, System.Drawing.Color.LightBlue}
        Me.btnBackgroundGradient.Image = CType(resources.GetObject("btnBackgroundGradient.Image"), System.Drawing.Image)
        Me.btnBackgroundGradient.Location = New System.Drawing.Point(26, 233)
        Me.btnBackgroundGradient.Name = "btnBackgroundGradient"
        Me.btnBackgroundGradient.NoDoubleBuffered = False
        Me.btnBackgroundGradient.NoDraw = False
        Me.btnBackgroundGradient.Positions = New Single() {0.0!, 1.0!}
        Me.btnBackgroundGradient.Size = New System.Drawing.Size(398, 23)
        Me.btnBackgroundGradient.TabIndex = 32
        Me.btnBackgroundGradient.TransparencyImage = True
        Me.btnBackgroundGradient.UseVisualStyleBackColor = True
        '
        'btnSolidColor
        '
        Me.btnSolidColor.BackColor = System.Drawing.Color.White
        Me.btnSolidColor.Location = New System.Drawing.Point(26, 181)
        Me.btnSolidColor.Name = "btnSolidColor"
        Me.btnSolidColor.Size = New System.Drawing.Size(398, 23)
        Me.btnSolidColor.TabIndex = 25
        Me.btnSolidColor.UseVisualStyleBackColor = False
        '
        'rbGradient
        '
        Me.rbGradient.AutoSize = True
        Me.rbGradient.Location = New System.Drawing.Point(6, 210)
        Me.rbGradient.Name = "rbGradient"
        Me.rbGradient.Size = New System.Drawing.Size(65, 17)
        Me.rbGradient.TabIndex = 24
        Me.rbGradient.Text = "Gradient"
        Me.rbGradient.UseVisualStyleBackColor = True
        '
        'rbSolidColor
        '
        Me.rbSolidColor.AutoSize = True
        Me.rbSolidColor.Location = New System.Drawing.Point(7, 158)
        Me.rbSolidColor.Name = "rbSolidColor"
        Me.rbSolidColor.Size = New System.Drawing.Size(75, 17)
        Me.rbSolidColor.TabIndex = 23
        Me.rbSolidColor.Text = "Solid Color"
        Me.rbSolidColor.UseVisualStyleBackColor = True
        '
        'pctBackground
        '
        Me.pctBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctBackground.Location = New System.Drawing.Point(26, 76)
        Me.pctBackground.Name = "pctBackground"
        Me.pctBackground.Size = New System.Drawing.Size(398, 76)
        Me.pctBackground.TabIndex = 16
        Me.pctBackground.TabStop = False
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(359, 50)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(65, 23)
        Me.btnImport.TabIndex = 15
        Me.btnImport.Text = "Import..."
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'rbImage
        '
        Me.rbImage.AutoSize = True
        Me.rbImage.Location = New System.Drawing.Point(7, 30)
        Me.rbImage.Name = "rbImage"
        Me.rbImage.Size = New System.Drawing.Size(54, 17)
        Me.rbImage.TabIndex = 1
        Me.rbImage.Text = "Image"
        Me.rbImage.UseVisualStyleBackColor = True
        '
        'rbNone
        '
        Me.rbNone.AutoSize = True
        Me.rbNone.Checked = True
        Me.rbNone.Location = New System.Drawing.Point(7, 7)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Size = New System.Drawing.Size(51, 17)
        Me.rbNone.TabIndex = 0
        Me.rbNone.TabStop = True
        Me.rbNone.Text = "None"
        Me.rbNone.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rbZoom)
        Me.Panel3.Controls.Add(Me.rbDefault)
        Me.Panel3.Controls.Add(Me.rbStretch)
        Me.Panel3.Controls.Add(Me.rbTile)
        Me.Panel3.Controls.Add(Me.rbCenter)
        Me.Panel3.Location = New System.Drawing.Point(26, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(327, 23)
        Me.Panel3.TabIndex = 22
        '
        'rbZoom
        '
        Me.rbZoom.AutoSize = True
        Me.rbZoom.Location = New System.Drawing.Point(240, 3)
        Me.rbZoom.Name = "rbZoom"
        Me.rbZoom.Size = New System.Drawing.Size(52, 17)
        Me.rbZoom.TabIndex = 21
        Me.rbZoom.Text = "Zoom"
        Me.rbZoom.UseVisualStyleBackColor = True
        '
        'rbDefault
        '
        Me.rbDefault.AutoSize = True
        Me.rbDefault.Checked = True
        Me.rbDefault.Location = New System.Drawing.Point(0, 3)
        Me.rbDefault.Name = "rbDefault"
        Me.rbDefault.Size = New System.Drawing.Size(59, 17)
        Me.rbDefault.TabIndex = 17
        Me.rbDefault.TabStop = True
        Me.rbDefault.Text = "Default"
        Me.rbDefault.UseVisualStyleBackColor = True
        '
        'rbStretch
        '
        Me.rbStretch.AutoSize = True
        Me.rbStretch.Location = New System.Drawing.Point(175, 3)
        Me.rbStretch.Name = "rbStretch"
        Me.rbStretch.Size = New System.Drawing.Size(59, 17)
        Me.rbStretch.TabIndex = 20
        Me.rbStretch.Text = "Stretch"
        Me.rbStretch.UseVisualStyleBackColor = True
        '
        'rbTile
        '
        Me.rbTile.AutoSize = True
        Me.rbTile.Location = New System.Drawing.Point(65, 3)
        Me.rbTile.Name = "rbTile"
        Me.rbTile.Size = New System.Drawing.Size(42, 17)
        Me.rbTile.TabIndex = 18
        Me.rbTile.Text = "Tile"
        Me.rbTile.UseVisualStyleBackColor = True
        '
        'rbCenter
        '
        Me.rbCenter.AutoSize = True
        Me.rbCenter.Location = New System.Drawing.Point(113, 3)
        Me.rbCenter.Name = "rbCenter"
        Me.rbCenter.Size = New System.Drawing.Size(56, 17)
        Me.rbCenter.TabIndex = 19
        Me.rbCenter.Text = "Center"
        Me.rbCenter.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.gbTitleFont)
        Me.TabPage4.Controls.Add(Me.gbFont)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(430, 360)
        Me.TabPage4.TabIndex = 5
        Me.TabPage4.Text = "Text"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'gbTitleFont
        '
        Me.gbTitleFont.Controls.Add(Me.btnTitleFontColor)
        Me.gbTitleFont.Controls.Add(Me.lblTitlePreview)
        Me.gbTitleFont.Controls.Add(Me.Label15)
        Me.gbTitleFont.Controls.Add(Me.Label16)
        Me.gbTitleFont.Controls.Add(Me.btnTitleFont)
        Me.gbTitleFont.Location = New System.Drawing.Point(6, 160)
        Me.gbTitleFont.Name = "gbTitleFont"
        Me.gbTitleFont.Size = New System.Drawing.Size(418, 153)
        Me.gbTitleFont.TabIndex = 31
        Me.gbTitleFont.TabStop = False
        Me.gbTitleFont.Text = "Title Font"
        '
        'btnTitleFontColor
        '
        Me.btnTitleFontColor.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnTitleFontColor.Location = New System.Drawing.Point(46, 81)
        Me.btnTitleFontColor.Name = "btnTitleFontColor"
        Me.btnTitleFontColor.Size = New System.Drawing.Size(366, 23)
        Me.btnTitleFontColor.TabIndex = 26
        Me.btnTitleFontColor.UseVisualStyleBackColor = False
        '
        'lblTitlePreview
        '
        Me.lblTitlePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitlePreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitlePreview.Location = New System.Drawing.Point(6, 16)
        Me.lblTitlePreview.Name = "lblTitlePreview"
        Me.lblTitlePreview.Size = New System.Drawing.Size(406, 62)
        Me.lblTitlePreview.TabIndex = 0
        Me.lblTitlePreview.Text = "Lorem Ipsum"
        Me.lblTitlePreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Font:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Color:"
        '
        'btnTitleFont
        '
        Me.btnTitleFont.AutoSize = True
        Me.btnTitleFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTitleFont.Location = New System.Drawing.Point(46, 110)
        Me.btnTitleFont.MaximumSize = New System.Drawing.Size(378, 0)
        Me.btnTitleFont.Name = "btnTitleFont"
        Me.btnTitleFont.Size = New System.Drawing.Size(366, 35)
        Me.btnTitleFont.TabIndex = 28
        Me.btnTitleFont.Text = "Lorem Ipsum"
        Me.btnTitleFont.UseVisualStyleBackColor = False
        '
        'gbFont
        '
        Me.gbFont.Controls.Add(Me.btnFontColor)
        Me.gbFont.Controls.Add(Me.lblPreview)
        Me.gbFont.Controls.Add(Me.Label13)
        Me.gbFont.Controls.Add(Me.Label12)
        Me.gbFont.Controls.Add(Me.btnFont)
        Me.gbFont.Location = New System.Drawing.Point(6, 6)
        Me.gbFont.Name = "gbFont"
        Me.gbFont.Size = New System.Drawing.Size(418, 148)
        Me.gbFont.TabIndex = 30
        Me.gbFont.TabStop = False
        Me.gbFont.Text = "Main Font"
        '
        'btnFontColor
        '
        Me.btnFontColor.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnFontColor.Location = New System.Drawing.Point(46, 81)
        Me.btnFontColor.Name = "btnFontColor"
        Me.btnFontColor.Size = New System.Drawing.Size(366, 23)
        Me.btnFontColor.TabIndex = 26
        Me.btnFontColor.UseVisualStyleBackColor = False
        '
        'lblPreview
        '
        Me.lblPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPreview.Location = New System.Drawing.Point(6, 16)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(406, 62)
        Me.lblPreview.TabIndex = 0
        Me.lblPreview.Text = "Lorem Ipsum"
        Me.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Font:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Color:"
        '
        'btnFont
        '
        Me.btnFont.AutoSize = True
        Me.btnFont.Location = New System.Drawing.Point(46, 110)
        Me.btnFont.MaximumSize = New System.Drawing.Size(378, 0)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(366, 23)
        Me.btnFont.TabIndex = 28
        Me.btnFont.Text = "Lorem Ipsum"
        Me.btnFont.UseVisualStyleBackColor = False
        '
        'dlgOpenImage
        '
        Me.dlgOpenImage.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|All file" & _
    "s (*.*)|*.*"
        '
        'dlgOpenIcon
        '
        Me.dlgOpenIcon.Filter = "Icons (*.ico)|*.ico|All files (*.*)|*.*"
        '
        'dlgFont
        '
        Me.dlgFont.ShowColor = True
        '
        'dlgCustomize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 439)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.DoubleBufferedTabs1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCustomize"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customize"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pctIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVersion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DoubleBufferedTabs1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.pctBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.gbTitleFont.ResumeLayout(False)
        Me.gbTitleFont.PerformLayout()
        Me.gbFont.ResumeLayout(False)
        Me.gbFont.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbLanguageNotEndangered As System.Windows.Forms.RadioButton
    Friend WithEvents rbLanguageEndangered As System.Windows.Forms.RadioButton
    Friend WithEvents rbLanguageCriticallyEndangered As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbLanguageConstructed As System.Windows.Forms.RadioButton
    Friend WithEvents rbLanguageNatural As System.Windows.Forms.RadioButton
    Friend WithEvents txtLanguageName As System.Windows.Forms.TextBox
    Friend WithEvents txtLanguageFamily As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseIcon As System.Windows.Forms.Button
    Friend WithEvents pctIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudVersion As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DoubleBufferedTabs1 As Thorn.DoubleBufferedTabs
    Friend WithEvents txtLanguageDescription As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents btnSolidColor As System.Windows.Forms.Button
    Friend WithEvents rbGradient As System.Windows.Forms.RadioButton
    Friend WithEvents rbSolidColor As System.Windows.Forms.RadioButton
    Friend WithEvents pctBackground As System.Windows.Forms.PictureBox
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents rbImage As System.Windows.Forms.RadioButton
    Friend WithEvents rbNone As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rbZoom As System.Windows.Forms.RadioButton
    Friend WithEvents rbDefault As System.Windows.Forms.RadioButton
    Friend WithEvents rbStretch As System.Windows.Forms.RadioButton
    Friend WithEvents rbTile As System.Windows.Forms.RadioButton
    Friend WithEvents rbCenter As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dlgOpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgOpenIcon As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnFont As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnFontColor As System.Windows.Forms.Button
    Friend WithEvents lblPreview As System.Windows.Forms.Label
    Friend WithEvents dlgFont As System.Windows.Forms.FontDialog
    Friend WithEvents gbTitleFont As System.Windows.Forms.GroupBox
    Friend WithEvents btnTitleFontColor As System.Windows.Forms.Button
    Friend WithEvents lblTitlePreview As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnTitleFont As System.Windows.Forms.Button
    Friend WithEvents gbFont As System.Windows.Forms.GroupBox
    Friend WithEvents btnBackgroundGradient As GradientButton
End Class
