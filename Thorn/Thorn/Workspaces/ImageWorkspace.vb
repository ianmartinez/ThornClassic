Public Class ImageWorkspace
    Private mAssociatedPage As ImagePage
    Public Property AssociatedPage As ImagePage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As ImagePage)
            mAssociatedPage = value
        End Set
    End Property
    Private Sub pctMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbCaption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCaption.CheckedChanged
        txtCaption.Enabled = cbCaption.Checked
        AssociatedPage.HasCaption = cbCaption.Checked
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        If dlgOpen.ShowDialog() = DialogResult.OK Then
            pnlImage.BackgroundImage = Image.FromFile(dlgOpen.FileName)
            AssociatedPage.Image = Image.FromFile(dlgOpen.FileName)
        End If
    End Sub

    Private Sub txtCaption_GotFocus(sender As Object, e As System.EventArgs) Handles txtCaption.GotFocus
        frmMain.kuiMain.TextControl = txtCaption
    End Sub

    Private Sub txtCaption_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCaption.TextChanged
        AssociatedPage.Caption = txtCaption.Text
    End Sub

    Private Sub ImageWorkspace_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCaption.Text = AssociatedPage.Caption
        cbCaption.Checked = AssociatedPage.HasCaption
        pnlImage.BackgroundImage = AssociatedPage.Image
    End Sub

    Private Sub pctImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctImage.Click

    End Sub
End Class
