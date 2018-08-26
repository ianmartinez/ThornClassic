Public Class FreeResponseWorkspace
    Private mAssociatedPage As FreeResponseQuestionPage
    Public Property AssociatedPage As FreeResponseQuestionPage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As FreeResponseQuestionPage)
            mAssociatedPage = value
        End Set
    End Property

    Private Sub txtQuestion_GotFocus(sender As Object, e As System.EventArgs) Handles txtQuestion.GotFocus
        frmMain.kuiMain.TextControl = txtQuestion
    End Sub

    Private Sub txtQuestion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuestion.TextChanged
        AssociatedPage.Question = txtQuestion.Text
    End Sub

    Private Sub FreeResponseWorkspace_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        txtQuestion.Text = AssociatedPage.Question
        txtHint.Text = AssociatedPage.Hint
        For Each Answer As String In AssociatedPage.CorrectAnswers
            dgvMain.Rows.Add(Answer)
        Next
    End Sub

    Private Sub dgvMain_CellBeginEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvMain.CellBeginEdit

    End Sub

    Private Sub dgvMain_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellEndEdit
        AssociatedPage.CorrectAnswers.Clear()
        For i = 0 To dgvMain.Rows.Count - 1
            Dim answer As String = dgvMain.Rows(i).Cells(0).Value
            If Not answer = Nothing Then AssociatedPage.CorrectAnswers.Add(answer)
        Next
    End Sub

    Private Sub txtHint_GotFocus(sender As Object, e As System.EventArgs) Handles txtHint.GotFocus
        frmMain.kuiMain.TextControl = txtHint
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHint.TextChanged
        AssociatedPage.Hint = txtHint.Text
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        dlgDisplay.Display = Me.AssociatedPage.Display
        If dlgDisplay.ShowDialog = DialogResult.OK Then
            Me.AssociatedPage.Display = dlgDisplay.Display
        End If
    End Sub

    Private Sub dgvMain_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellContentClick

    End Sub

    Private Sub dgvMain_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvMain.CellFormatting

    End Sub
End Class
