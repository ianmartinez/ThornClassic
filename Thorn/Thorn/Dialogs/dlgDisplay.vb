Imports System.Windows.Forms
Imports System.IO

Public Class dlgDisplay
    Private mDisplay As Display
    Public Property Display As Display
        Get
            Return mDisplay
        End Get
        Set(ByVal value As Display)
            mDisplay = value
            On Error Resume Next
            Refresh()
            pMain.Media = Display.Media
        End Set
    End Property
    Private Sub dlgDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtText.Text = Display.Text
        txtWebpage.Text = Display.Url
        btnImage.BackgroundImage = Display.Image
        pMain.Media = Display.Media
        txtMediaTitle.Text = Display.Media.Title
        If Display.Type = DisplayType.Image Then
            rbImage.Checked = True
        ElseIf Display.Type = DisplayType.Media Then
            rbMedia.Checked = True
        ElseIf Display.Type = DisplayType.Text Then
            rbText.Checked = True
        ElseIf Display.Type = DisplayType.WebBrowser Then
            rbWebPage.Checked = True
        Else
            rbNone.Checked = True
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If rbNone.Checked = True Then
            Display.Type = DisplayType.None
        ElseIf rbImage.Checked = True Then
            Display.Type = DisplayType.Image
        ElseIf rbMedia.Checked = True Then
            Display.Type = DisplayType.Media
        ElseIf rbText.Checked = True Then
            Display.Type = DisplayType.Text
        ElseIf rbWebPage.Checked = True Then
            Display.Type = DisplayType.WebBrowser
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnImportMedia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportMedia.Click
        Try
            If dlgOpenMedia.ShowDialog = Windows.Forms.DialogResult.OK Then
                Display.Media.FileExt = dlgOpenMedia.FileName.Split(".").Last
                Display.Media.Bytes = File.ReadAllBytes(dlgOpenMedia.FileName)
                pMain.Media = Display.Media
            End If
        Catch ex As Exception
            If TypeOf ex.GetBaseException Is OutOfMemoryException Then
                MessageBox.Show("File is too big.")
            End If
        End Try
    End Sub

    Private Sub txtText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtText.TextChanged
        Display.Text = txtText.Text
    End Sub

    Private Sub txtWebpage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWebpage.TextChanged
        Display.Url = txtWebpage.Text
    End Sub

    Private Sub btnImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImage.Click
        If dlgOpenImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            Display.Image = Image.FromFile(dlgOpenImage.FileName)
            btnImage.BackgroundImage = Display.Image
        End If
    End Sub

    Private Sub wmpMedia_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Player1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pMain.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMediaTitle.TextChanged

    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        Display.Media.Title = txtMediaTitle.Text
        pMain.Media = Display.Media
    End Sub
End Class
