Imports Tundra.Aero
Public Class frmViewer
    Private CurrentTab As Integer
    Public CurrentAnswers As New Dictionary(Of Integer, String)
    Public AnsweredList As New List(Of Integer)
    Public Correct As Integer
    Public Sub RedrawAero()
        If DWMEnabled() Then
            ToolStrip1.BackColor = Color.Black
            Me.ToolStrip1.RenderMode = ToolStripRenderMode.System
            Me.ToolStrip1.Renderer = New FixedSR
            If SplitContainer1.Panel2Collapsed = True Then
                Extend(Me, 0, 0, ToolStrip1.Height, 0, False)
            Else
                SplitContainer1.Panel2.BackColor = Color.Black
                Extend(Me, 0, SplitContainer1.Panel2.Width, ToolStrip1.Height, 0, False)
            End If
        End If
    End Sub

    Public Sub CurrentDocumentUpdate()
        On Error Resume Next
        tcSlides.TabPages.Clear()
        Me.Text = String.Format("Thorn Viewer{0}{1}", IIf(CurrentDocument.Properties.Title = "", "", " - "), CurrentDocument.Properties.Title)
        For i = 0 To CurrentDocument.Pages.Count - 1
            Dim CurrentPage As Page = CurrentDocument.Pages.Item(i)
            Dim ti As New TabPage()
            ti.Padding = New Padding(3)
            ti.BackColor = SystemColors.Window
            tcSlides.TabPages.Add(ti)
            Dim CurrentTabPage As TabPage = tcSlides.TabPages.Item(i)
            Dim Back As New BackgroundPanel
            CurrentTabPage.Controls.Add(Back)
            Back.UpdateBackground()
            Back.Dock = DockStyle.Fill
            CurrentTabPage.Text = String.Format("Page {0}{1}{2}", i + 1, IIf(CurrentPage.Title = "", "", " - "), CurrentPage.Title)
            If CurrentPage.PageType = PageType.Text Then
                Dim TextViewer As New TextViewer
                TextViewer.AssociatedPage = CurrentPage
                Back.Controls.Add(TextViewer)
                TextViewer.Dock = DockStyle.Fill
            ElseIf CurrentPage.PageType = PageType.Title Then
                Dim TitleViewer As New TitleViewer
                TitleViewer.AssociatedPage = CurrentPage
                Back.Controls.Add(TitleViewer)
                TitleViewer.Dock = DockStyle.Fill
            ElseIf CurrentPage.PageType = PageType.Image Then
                Dim ImageViewer As New ImageViewer
                ImageViewer.AssociatedPage = CurrentPage
                Back.Controls.Add(ImageViewer)
                ImageViewer.Dock = DockStyle.Fill
                ImageViewer.ResizeSplitter()
            ElseIf CurrentPage.PageType = PageType.FreeResponse Then
                Dim FreeResponseViewer As New FreeResponseViewer
                FreeResponseViewer.AssociatedPage = CurrentPage
                FreeResponseViewer.AssociatedID = i
                Back.Controls.Add(FreeResponseViewer)
                FreeResponseViewer.Dock = DockStyle.Fill
                FreeResponseViewer.ResizeSplitter()
            ElseIf CurrentPage.PageType = PageType.MultipleChoice Then
                Dim MultipleChoiceViewer As New MultipleChoiceViewer
                CurrentTabPage.Controls.Add(MultipleChoiceViewer)
                MultipleChoiceViewer.AssociatedPage = CurrentPage
                MultipleChoiceViewer.AssociatedID = i
                Back.Controls.Add(MultipleChoiceViewer)
                MultipleChoiceViewer.Dock = DockStyle.Fill
                MultipleChoiceViewer.ResizeSplitter()
            ElseIf CurrentPage.PageType = PageType.WebBrowser Then
                Dim WebBrowser As New WebBrowser
                Dim WebBrowserPage As WebBrowserPage = CType(CurrentPage, WebBrowserPage)
                WebBrowser.ScriptErrorsSuppressed = True
                Back.Padding = New Padding(5)
                Back.Controls.Add(WebBrowser)
                WebBrowser.Navigate(WebBrowserPage.URL)
                WebBrowser.Dock = DockStyle.Fill
            ElseIf CurrentPage.PageType = PageType.Media Then
                Dim MediaViewer As New MediaViewer
                Back.Controls.Add(MediaViewer)
                MediaViewer.AssociatedPage = CurrentPage
                MediaViewer.Dock = DockStyle.Fill
                MediaViewer.ResizeSplitter()
            End If
        Next
        If tcSlides.TabCount = 0 Then
            tcSlides.Visible = False
        Else
            tcSlides.Visible = True
        End If
        tcSlides.SelectedIndex = 0
        tcSlides_SelectedIndexChanged(Me, Nothing)
        AnsweredList.Clear()
    End Sub

    Private Sub frmViewer_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Viewing = False
    End Sub

    Private Sub frmViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        kuiMain.SetKeys(CurrentDocument.Keyboard)
        lblName.Text = CurrentDocument.Properties.LanguageName
        lblFamily.Text = "Family: " & CurrentDocument.Properties.LanguageFamily
        lblType.Text = "Type: " & CurrentDocument.Properties.LanguageType.ToString
        If CurrentDocument.Properties.LanguageStatus = LanguageStatus.NotEndangered Then
            lblStatus.Text = "Status: Not Endangered"
        ElseIf CurrentDocument.Properties.LanguageStatus = LanguageStatus.Endangered Then
            lblStatus.Text = "Status: Endangered"
        Else
            lblStatus.Text = "Status: Critically Endangered"
        End If
        rtbDescription.Text = CurrentDocument.Properties.LanguageDescription
        RedrawAero()
        CurrentDocumentUpdate()
        Viewing = True
    End Sub

    Private Sub frmViewer_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    End Sub

    Private Sub frmViewer_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        RedrawAero()
    End Sub

    Private Sub frmViewer_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then RedrawAero()
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As System.Object, e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        RedrawAero()
    End Sub

    Private Sub lblFamily_Click(sender As System.Object, e As System.EventArgs) Handles lblFamily.Click

    End Sub

    Private Sub OpenSidebarToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenSidebarToolStripButton.Click
        If SplitContainer1.Panel2Collapsed = True Then
            SplitContainer1.Panel2Collapsed = False
        Else
            SplitContainer1.Panel2Collapsed = True
        End If
        RedrawAero()
    End Sub

    Private Sub pnlBackground_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub kuiMain_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles kuiMain.Paint

    End Sub

    Private Sub tcSlides_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tcSlides.SelectedIndexChanged
        CurrentTab = tcSlides.SelectedIndex
        If TypeOf CurrentDocument.Pages.Item(CurrentTab) Is QuestionPage Then
            AnswerQuestionToolStripButton.Visible = True
            ToolStripSeparator1.Visible = True
        Else
            AnswerQuestionToolStripButton.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub

    Private Sub AnswerQuestionToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles AnswerQuestionToolStripButton.Click
        Dim CurrentAnswer As String = CurrentAnswers(CurrentTab)
        If TypeOf CurrentDocument.Pages.Item(CurrentTab) Is FreeResponseQuestionPage Then
            Dim QuestionPage As FreeResponseQuestionPage = CType(CurrentDocument.Pages.Item(CurrentTab), FreeResponseQuestionPage)
            If AnsweredList.Contains(CurrentTab) Then
                MessageBox.Show("You've already answered this question.")
            End If

            If QuestionPage.CorrectAnswers.Contains(CurrentAnswer) Then
                Correct += 1
                MessageBox.Show(Correct & " correct")
                AnsweredList.Add(CurrentTab)
            Else
                If Not QuestionPage.Hint = "" Then MessageBox.Show(QuestionPage.Hint)
            End If

            If Not tcSlides.SelectedIndex >= tcSlides.TabCount - 1 Then
                tcSlides.SelectedIndex += 1
            Else
                MessageBox.Show("You've reached the end.")
            End If

        ElseIf TypeOf CurrentDocument.Pages.Item(CurrentTab) Is MultipleChoiceQuestionPage Then
            Dim QuestionPage As MultipleChoiceQuestionPage = CType(CurrentDocument.Pages.Item(CurrentTab), MultipleChoiceQuestionPage)
            If AnsweredList.Contains(CurrentTab) Then
                MessageBox.Show("You've already answered this question.")
            End If

            If QuestionPage.CorrectAnswer = CurrentAnswer Then
                Correct += 1
                MessageBox.Show(Correct & " correct")
                AnsweredList.Add(CurrentTab)
            Else
                If Not QuestionPage.Hint = "" Then MessageBox.Show(QuestionPage.Hint)
            End If

            If Not tcSlides.SelectedIndex >= tcSlides.TabCount - 1 Then
                tcSlides.SelectedIndex += 1
            Else
                MessageBox.Show("You've reached the end.")
            End If
        End If
    End Sub

    Private Sub AboutToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripButton.Click
        dlgAbout.ShowDialog()
    End Sub

    Private Sub GoToToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles GoToToolStripButton.Click
        dlgGoTo.ShowDialog()
    End Sub

    Private Sub BackToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles BackToolStripButton.Click
        If Not tcSlides.SelectedIndex <= 0 Then tcSlides.SelectedIndex -= 1
    End Sub

    Private Sub ForwardToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles ForwardToolStripButton.Click
        If Not tcSlides.SelectedIndex >= tcSlides.TabCount - 1 Then
            tcSlides.SelectedIndex += 1
        Else
            MessageBox.Show("You've reached the end.")
        End If
    End Sub

    Private Sub BugReportToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles BugReportToolStripButton.Click
        dlgContact.rbBug.Checked = True
        dlgContact.ShowDialog()
    End Sub

    Private Sub btnVocabulary_Click(sender As System.Object, e As System.EventArgs) Handles btnVocabulary.Click
        dlgReadVocabulary.Show()
    End Sub
End Class