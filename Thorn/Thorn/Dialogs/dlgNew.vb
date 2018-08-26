Imports System.Windows.Forms
Public Class dlgNew

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        CurrentDocument = New ThornFile
        CurrentDocument.Properties.Title = txtTitle.Text
        CurrentDocument.Properties.LanguageName = txtLanguageName.Text
        Dim TPage = New TitlePage
        TPage.Text = txtTitle.Text
        CurrentDocument.Pages.Add(TPage)
        frmMain.CurrentDocumentUpdate()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
