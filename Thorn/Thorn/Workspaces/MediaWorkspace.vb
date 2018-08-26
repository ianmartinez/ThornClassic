Imports System.IO

Public Class MediaWorkspace
    Private mAssociatedPage As MediaPage
    Public Property AssociatedPage As MediaPage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As MediaPage)
            mAssociatedPage = value
        End Set
    End Property
    Public Sub Pause()
        pMain.Pause()
    End Sub
    Public Sub Modify()
        txtTitle.Text = AssociatedPage.Media.Title
        txtCaption.Text = AssociatedPage.Caption
        txtCaption.Enabled = AssociatedPage.HasCaption
        cbCaption.Checked = AssociatedPage.HasCaption
        pMain.Media = AssociatedPage.Media
    End Sub
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        If dlgOpenMedia.ShowDialog = Windows.Forms.DialogResult.OK Then
            AssociatedPage.Media.FileExt = dlgOpenMedia.FileName.Split(".").Last
            AssociatedPage.Media.Bytes = File.ReadAllBytes(dlgOpenMedia.FileName)
            pMain.Media = AssociatedPage.Media
        End If
    End Sub

    Private Sub cbCaption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCaption.CheckedChanged
        AssociatedPage.HasCaption = cbCaption.Checked
        txtCaption.Enabled = cbCaption.Checked
    End Sub

    Private Sub txtCaption_GotFocus(sender As Object, e As System.EventArgs) Handles txtCaption.GotFocus
        frmMain.kuiMain.TextControl = txtCaption
    End Sub

    Private Sub txtCaption_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCaption.TextChanged
        AssociatedPage.Caption = txtCaption.Text
    End Sub

    Private Sub pMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pMain.Load

    End Sub

    Private Sub MediaWorkspace_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Modify()
        Pause()
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        AssociatedPage.Media.Title = txtTitle.Text
        pMain.Media = AssociatedPage.Media
    End Sub

    Private Sub txtTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitle.TextChanged
        AssociatedPage.Media.Title = txtTitle.Text
    End Sub
End Class
