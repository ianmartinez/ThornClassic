Public Class FreeResponseViewer
    Private mAssociatedPage As FreeResponseQuestionPage
    Public Property AssociatedPage As FreeResponseQuestionPage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As FreeResponseQuestionPage)
            mAssociatedPage = value
            UpdatePage()
        End Set
    End Property
    Public Property AssociatedID As Integer
    Public Sub UpdatePage()
        lblText.Text = AssociatedPage.Question
        lblText.Font = CurrentDocument.Properties.Font
        lblText.ForeColor = CurrentDocument.Properties.FontColor
        If AssociatedPage.Display.Type = DisplayType.None Then
            DisplayViewer1.Visible = False
            txtAnswer.Dock = DockStyle.Top
        End If
        DisplayViewer1.AssociatedDisplay = AssociatedPage.Display
        ResizeSplitter()
    End Sub

    Private Sub FreeResponseViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        UpdatePage()
    End Sub

    Private Sub txtAnswer_GotFocus(sender As Object, e As System.EventArgs) Handles txtAnswer.GotFocus
        frmViewer.kuiMain.TextControl = txtAnswer
    End Sub

    Private Sub txtAnswer_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer.TextChanged
        If frmViewer.CurrentAnswers.Keys.Contains(AssociatedID) Then
            frmViewer.CurrentAnswers.Remove(AssociatedID)
            frmViewer.CurrentAnswers.Add(AssociatedID, txtAnswer.Text)
        Else
            frmViewer.CurrentAnswers.Add(AssociatedID, txtAnswer.Text)
        End If
    End Sub

    Public Sub ResizeSplitter() Handles Me.Resize
        On Error Resume Next
        pnlMain.Panel2MinSize = Me.Height * 0.35
        pnlMain.SplitterDistance = lblText.Height + 5
    End Sub

    Private Sub DisplayViewer1_Load(sender As System.Object, e As System.EventArgs) Handles DisplayViewer1.Load

    End Sub

    Private Sub lblText_Click(sender As System.Object, e As System.EventArgs) Handles lblText.Click

    End Sub
End Class
