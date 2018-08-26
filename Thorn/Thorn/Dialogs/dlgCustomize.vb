Imports System.Drawing.Drawing2D

Public Class dlgCustomize
    Private CurrentIcon As Image
    Private dlgColor As New ExtendedColorDialog

    Private Sub btnBrowseIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseIcon.Click
        If dlgOpenIcon.ShowDialog() = DialogResult.OK Then
            pctIcon.BackgroundImage = Image.FromFile(dlgOpenIcon.FileName)
            CurrentIcon = Image.FromFile(dlgOpenIcon.FileName)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        ' Main
        CurrentDocument.Properties.Title = txtTitle.Text
        CurrentDocument.Properties.Author = txtAuthor.Text
        CurrentDocument.Properties.Website = txtWebsite.Text
        CurrentDocument.Properties.Icon = CurrentIcon
        CurrentDocument.Properties.Description = txtDescription.Text
        ' Language Data
        CurrentDocument.Properties.LanguageName = txtLanguageName.Text
        CurrentDocument.Properties.LanguageFamily = txtLanguageFamily.Text
        CurrentDocument.Properties.LanguageType = IIf(rbLanguageNatural.Checked = True, LanguageType.Natural, LanguageType.Constructed)
        If rbLanguageCriticallyEndangered.Checked = True Then
            CurrentDocument.Properties.LanguageStatus = LanguageStatus.CriticallyEndangered
        ElseIf rbLanguageEndangered.Checked = True Then
            CurrentDocument.Properties.LanguageStatus = LanguageStatus.Endangered
        Else
            CurrentDocument.Properties.LanguageStatus = LanguageStatus.NotEndangered
        End If
        CurrentDocument.Properties.LanguageDescription = txtLanguageDescription.Text
        ' Background
        If rbNone.Checked = True Then
            CurrentDocument.Properties.BackgroundType = BackgroundType.None
        ElseIf rbImage.Checked = True Then
            CurrentDocument.Properties.BackgroundType = BackgroundType.Image
        ElseIf rbSolidColor.Checked = True Then
            CurrentDocument.Properties.BackgroundType = BackgroundType.SolidColor
        ElseIf rbGradient.Checked = True Then
            CurrentDocument.Properties.BackgroundType = BackgroundType.Gradient
        End If
        If rbDefault.Checked = True Then
            CurrentDocument.Properties.BackgroundImageLayout = ImageLayout.None
        ElseIf rbTile.Checked = True Then
            CurrentDocument.Properties.BackgroundImageLayout = ImageLayout.Tile
        ElseIf rbCenter.Checked = True Then
            CurrentDocument.Properties.BackgroundImageLayout = ImageLayout.Center
        ElseIf rbStretch.Checked = True Then
            CurrentDocument.Properties.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf rbZoom.Checked = True Then
            CurrentDocument.Properties.BackgroundImageLayout = ImageLayout.Zoom
        End If
        CurrentDocument.Properties.BackgroundImage = pctBackground.BackgroundImage
        CurrentDocument.Properties.BackgroundColor = btnSolidColor.BackColor
        CurrentDocument.Properties.BackgroundBlendAngle = btnBackgroundGradient.Angle
        CurrentDocument.Properties.BackgroundBlendColors = btnBackgroundGradient.Colors
        CurrentDocument.Properties.BackgroundBlendPositions = btnBackgroundGradient.Positions
        ' Text
        CurrentDocument.Properties.Font = btnFont.Font
        CurrentDocument.Properties.FontColor = btnFontColor.BackColor

        CurrentDocument.Properties.TitleFont = btnTitleFont.Font
        CurrentDocument.Properties.TitleFontColor = btnTitleFontColor.BackColor

        frmMain.CurrentDocumentUpdate()
        Me.Close()
    End Sub

    Private Sub dlgCustomize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        ' Main
        txtTitle.Text = CurrentDocument.Properties.Title
        txtAuthor.Text = CurrentDocument.Properties.Author
        txtWebsite.Text = CurrentDocument.Properties.Website
        CurrentIcon = CurrentDocument.Properties.Icon
        txtDescription.Text = CurrentDocument.Properties.Description
        ' Language Data
        txtLanguageName.Text = CurrentDocument.Properties.LanguageName
        txtLanguageFamily.Text = CurrentDocument.Properties.LanguageFamily
        If CurrentDocument.Properties.LanguageType = LanguageType.Natural Then
            rbLanguageNatural.Checked = True
        Else
            rbLanguageConstructed.Checked = True
        End If
        If CurrentDocument.Properties.LanguageStatus = LanguageStatus.CriticallyEndangered Then
            rbLanguageCriticallyEndangered.Checked = True
        ElseIf CurrentDocument.Properties.LanguageStatus = LanguageStatus.Endangered Then
            rbLanguageEndangered.Checked = True
        Else
            rbLanguageNotEndangered.Checked = True
        End If
        txtLanguageDescription.Text = CurrentDocument.Properties.LanguageDescription
        ' Background
        If CurrentDocument.Properties.BackgroundType = BackgroundType.None Then
            rbNone.Checked = True
        ElseIf CurrentDocument.Properties.BackgroundType = BackgroundType.Image Then
            rbImage.Checked = True
        ElseIf CurrentDocument.Properties.BackgroundType = BackgroundType.SolidColor Then
            rbSolidColor.Checked = True
        ElseIf CurrentDocument.Properties.BackgroundType = BackgroundType.Gradient Then
            rbGradient.Checked = True
        End If
        If CurrentDocument.Properties.BackgroundImageLayout = ImageLayout.None Then
            rbDefault.Checked = True
        ElseIf CurrentDocument.Properties.BackgroundImageLayout = ImageLayout.Tile Then
            rbTile.Checked = True
        ElseIf CurrentDocument.Properties.BackgroundImageLayout = ImageLayout.Center Then
            rbCenter.Checked = True
        ElseIf CurrentDocument.Properties.BackgroundImageLayout = ImageLayout.Stretch Then
            rbStretch.Checked = True
        ElseIf CurrentDocument.Properties.BackgroundImageLayout = ImageLayout.Zoom Then
            rbZoom.Checked = True
        End If
        pctBackground.BackgroundImage = CurrentDocument.Properties.BackgroundImage
        btnSolidColor.BackColor = CurrentDocument.Properties.BackgroundColor
        btnBackgroundGradient.Angle = CurrentDocument.Properties.BackgroundBlendAngle
        btnBackgroundGradient.Colors = CurrentDocument.Properties.BackgroundBlendColors
        btnBackgroundGradient.Positions = CurrentDocument.Properties.BackgroundBlendPositions
        ' Text
        btnFont.Font = CurrentDocument.Properties.Font
        btnFontColor.BackColor = CurrentDocument.Properties.FontColor
        lblPreview.ForeColor = btnFontColor.BackColor
        lblPreview.Font = btnFont.Font

        btnTitleFont.Font = CurrentDocument.Properties.TitleFont
        btnTitleFontColor.BackColor = CurrentDocument.Properties.TitleFontColor
        lblTitlePreview.ForeColor = btnTitleFontColor.BackColor
        lblTitlePreview.Font = btnTitleFont.Font
    End Sub

    Private Sub btnSolidColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolidColor.Click
        dlgColor.Color = btnSolidColor.BackColor
        If dlgColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnSolidColor.BackColor = dlgColor.Color
        End If
    End Sub

    Private Sub btnFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFontColor.Click
        dlgColor.Color = btnFontColor.BackColor
        If dlgColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnFontColor.BackColor = dlgColor.Color
        End If
        lblPreview.ForeColor = btnFontColor.BackColor
        lblPreview.Font = btnFont.Font
    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        Try
            dlgFont.Color = btnFontColor.BackColor

            If dlgFont.ShowDialog = Windows.Forms.DialogResult.OK Then
                btnFont.Font = dlgFont.Font
                btnFontColor.BackColor = dlgFont.Color
            End If
            lblPreview.ForeColor = btnFontColor.BackColor
            lblPreview.Font = btnFont.Font
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        If dlgOpenImage.ShowDialog() = DialogResult.OK Then
            pctBackground.BackgroundImage = Image.FromFile(dlgOpenImage.FileName)
        End If
    End Sub

    Private Sub rbDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDefault.CheckedChanged
        If rbDefault.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.None
        ElseIf rbTile.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Tile
        ElseIf rbCenter.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Center
        ElseIf rbStretch.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf rbZoom.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Zoom
        End If
    End Sub

    Private Sub rbTile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTile.CheckedChanged
        If rbDefault.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.None
        ElseIf rbTile.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Tile
        ElseIf rbCenter.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Center
        ElseIf rbStretch.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf rbZoom.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Zoom
        End If
    End Sub

    Private Sub rbCenter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCenter.CheckedChanged
        If rbDefault.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.None
        ElseIf rbTile.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Tile
        ElseIf rbCenter.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Center
        ElseIf rbStretch.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf rbZoom.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Zoom
        End If
    End Sub

    Private Sub rbStretch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStretch.CheckedChanged
        If rbDefault.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.None
        ElseIf rbTile.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Tile
        ElseIf rbCenter.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Center
        ElseIf rbStretch.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf rbZoom.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Zoom
        End If
    End Sub

    Private Sub rbZoom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbZoom.CheckedChanged
        If rbDefault.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.None
        ElseIf rbTile.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Tile
        ElseIf rbCenter.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Center
        ElseIf rbStretch.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf rbZoom.Checked = True Then
            pctBackground.BackgroundImageLayout = ImageLayout.Zoom
        End If
    End Sub

    Private Sub btnTitleFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTitleFontColor.Click
        dlgColor.Color = btnTitleFontColor.BackColor
        If dlgColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnTitleFontColor.BackColor = dlgColor.Color
        End If
        lblTitlePreview.ForeColor = btnTitleFontColor.BackColor
        lblTitlePreview.Font = btnTitleFont.Font
    End Sub

    Private Sub btnTitleFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTitleFont.Click
        Try
            dlgFont.Color = btnTitleFontColor.BackColor
            If dlgFont.ShowDialog = Windows.Forms.DialogResult.OK Then
                btnTitleFont.Font = dlgFont.Font
                btnTitleFontColor.BackColor = dlgFont.Color
            End If
            lblTitlePreview.ForeColor = btnTitleFontColor.BackColor
            lblTitlePreview.Font = btnTitleFont.Font
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBackgroundGradient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackgroundGradient.Click
        Cursor = Cursors.WaitCursor
        dlgGradient.Colors = btnBackgroundGradient.Colors
        dlgGradient.Positions = btnBackgroundGradient.Positions
        dlgGradient.Angle = btnBackgroundGradient.Angle
        If dlgGradient.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnBackgroundGradient.Colors = dlgGradient.Colors
            btnBackgroundGradient.Positions = dlgGradient.Positions
            btnBackgroundGradient.Angle = dlgGradient.Angle
        End If
        Cursor = Cursors.Default
    End Sub
End Class