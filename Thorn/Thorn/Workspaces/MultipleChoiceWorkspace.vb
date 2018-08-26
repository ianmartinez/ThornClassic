Public Class MultipleChoiceWorkspace
    Private mAssociatedPage As MultipleChoiceQuestionPage
    Public Property AssociatedPage As MultipleChoiceQuestionPage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As MultipleChoiceQuestionPage)
            mAssociatedPage = value
        End Set
    End Property

    Private Sub txtQuestion_GotFocus(sender As Object, e As System.EventArgs) Handles txtQuestion.GotFocus
        frmMain.kuiMain.TextControl = txtQuestion
    End Sub


    Private Sub txtQuestion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuestion.TextChanged
        AssociatedPage.Question = txtQuestion.Text
    End Sub

    Private Sub txtCorrectAnswer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AssociatedPage.CorrectAnswer = cbCorrectAnswer.SelectedText
    End Sub

    Private Sub dgvMain_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellEndEdit
        ' On Error Resume Next
        AssociatedPage.AnswerChoices.Clear()
        cbCorrectAnswer.Items.Clear()
        For i = 0 To dgvMain.Rows.Count - 1
            Dim answer As String = dgvMain.Rows(i).Cells(0).Value
            If Not answer = Nothing Then
                cbCorrectAnswer.Items.Add(answer)
                AssociatedPage.AnswerChoices.Add(answer)
            End If
        Next
    End Sub

    Private Sub MultipleChoiceWorkspace_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        txtQuestion.Text = AssociatedPage.Question
        cbCorrectAnswer.SelectedText = AssociatedPage.CorrectAnswer
        txtHint.Text = AssociatedPage.Hint
        For Each Answer As String In AssociatedPage.AnswerChoices
            dgvMain.Rows.Add(Answer)
        Next
        cbCorrectAnswer.Items.Clear()
        For i = 0 To dgvMain.Rows.Count - 1
            Dim answer As String = dgvMain.Rows(i).Cells(0).Value
            cbCorrectAnswer.Items.Add(answer)
        Next
        cbCorrectAnswer.SelectedItem = AssociatedPage.CorrectAnswer
    End Sub

    Private Sub txtHint_GotFocus(sender As Object, e As System.EventArgs) Handles txtHint.GotFocus
        frmMain.kuiMain.TextControl = txtHint
    End Sub

    Private Sub txtHint_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHint.TextChanged
        AssociatedPage.Hint = txtHint.Text
    End Sub

    Private Sub dgvMain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellContentClick

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        dlgDisplay.Display = Me.AssociatedPage.Display
        If dlgDisplay.ShowDialog = DialogResult.OK Then
            Me.AssociatedPage.Display = dlgDisplay.Display
        End If
    End Sub

    Private Sub cbCorrectAnswer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbCorrectAnswer.SelectedIndexChanged
        AssociatedPage.CorrectAnswer = cbCorrectAnswer.SelectedItem.ToString
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
