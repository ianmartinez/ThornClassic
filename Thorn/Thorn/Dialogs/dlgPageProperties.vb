Imports System.Windows.Forms

Public Class dlgPageProperties
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        On Error Resume Next
        CurrentDocument.Pages.Item(SelectedPage).Title = txtTitle.Text
        frmMain.CurrentDocumentUpdate()
        Me.Close()
    End Sub

    Private Sub dlgPageProperties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        txtTitle.Text = CurrentDocument.Pages.Item(SelectedPage).Title
    End Sub
End Class
