Public Class MultipleChoiceViewer
    Private mAssociatedPage As MultipleChoiceQuestionPage
    Public Property AssociatedPage As MultipleChoiceQuestionPage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As MultipleChoiceQuestionPage)
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
            pnlAnswers.Dock = DockStyle.Top
        End If
        For Each Answer As String In AssociatedPage.AnswerChoices
            Dim button As New Tundra.StylizedRadioButton
            button.AutoSize = True
            button.Style = My.Resources.KeyStyle
            button.Text = Answer
            AddHandler button.CheckedChanged, AddressOf CheckChanged
            pnlAnswers.Controls.Add(button)
        Next
        DisplayViewer1.AssociatedDisplay = AssociatedPage.Display
        ResizeSplitter()
    End Sub

    Private Sub CheckChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim button As Tundra.StylizedRadioButton = CType(sender, Tundra.StylizedRadioButton)
        If frmViewer.CurrentAnswers.Keys.Contains(AssociatedID) Then
            frmViewer.CurrentAnswers.Remove(AssociatedID)
            frmViewer.CurrentAnswers.Add(AssociatedID, button.Text)
        Else
            frmViewer.CurrentAnswers.Add(AssociatedID, button.Text)
        End If
    End Sub

    Private Sub MultipleChoiceViewer_Load(sender As System.Object, e As System.EventArgs)
        UpdatePage()
    End Sub

    Public Sub ResizeSplitter() Handles Me.Resize
        On Error Resume Next
        pnlMain.Panel2MinSize = Me.Height * 0.35
        pnlMain.SplitterDistance = lblText.Height + 5
    End Sub

    Private Sub DisplayViewer1_Load(sender As System.Object, e As System.EventArgs) Handles DisplayViewer1.Load

    End Sub

    Private Sub MultipleChoiceViewer_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
