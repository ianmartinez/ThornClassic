Public Class dlgAdd
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If lvTypes.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a page type")
            Exit Sub
        End If
        On Error Resume Next
        Dim Page As New Page
        If lvTypes.Items(2).Selected = True Then
            Page = New ImagePage
        ElseIf lvTypes.Items(1).Selected = True Then
            Page = New TextPage
        ElseIf lvTypes.Items(0).Selected = True Then
            Page = New TitlePage
        ElseIf lvTypes.Items(3).Selected = True Then
            Page = New MultipleChoiceQuestionPage
        ElseIf lvTypes.Items(4).Selected = True Then
            Page = New FreeResponseQuestionPage
        ElseIf lvTypes.Items(5).Selected = True Then
            Page = New WebBrowserPage
        ElseIf lvTypes.Items(6).Selected = True Then
            Page = New MediaPage
        End If
        Page.Title = txtTitle.Text
        CurrentDocument.Pages.Add(Page)
        frmMain.CurrentDocumentUpdate()
        frmMain.tcSlides.SelectTab(CurrentDocument.Pages.Count - 1)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dlgAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvTypes.Items(0).Selected = True
    End Sub
End Class