Imports System.IO
Imports Tundra.Aero

Public Class frmMain
    Private Updating As Boolean

    Public Sub RedrawAero()
        If DWMEnabled() Then
            MainToolStrip.BackColor = Color.Black
            Me.MainToolStrip.RenderMode = ToolStripRenderMode.System
            Me.MainToolStrip.Renderer = New FixedSR
            If SplitContainer1.Panel2Collapsed = True Then
                Extend(Me, 0, 0, MainToolStrip.Height, 0, False)
            Else
                SplitContainer1.Panel2.BackColor = Color.Black
                Extend(Me, 0, SplitContainer1.Panel2.Width, MainToolStrip.Height, 0, False)
            End If
        End If
    End Sub
    Public Sub CurrentDocumentUpdate()
        On Error Resume Next
        Updating = True
        tcSlides.TabPages.Clear()
        Me.Text = String.Format("Thorn{0}{1}", IIf(CurrentDocument.Properties.Title = "", "", " - "), CurrentDocument.Properties.Title)
        For i = 0 To CurrentDocument.Pages.Count - 1
            Dim CurrentPage As Page = CurrentDocument.Pages.Item(i)
            'tcSlides.TabPages.Add(New TabPage("Page " & i + 1 & " - " & CurrentPage.Title))
            Dim ti As New TabPage()
            ti.Padding = New Padding(3)
            ti.BackColor = SystemColors.Window
            tcSlides.TabPages.Add(ti)
            Dim CurrentTabPage As TabPage = tcSlides.TabPages.Item(i)
            If CurrentPage.PageType = PageType.Text Then
                Dim TextWorkspace As New TextWorkspace
                TextWorkspace.AssociatedPage = CurrentPage
                CurrentTabPage.Controls.Add(TextWorkspace)
                CurrentTabPage.Text = String.Format("Page {1}{2}{3} ({0})", "Text", i + 1, IIf(CurrentPage.Title = "", "", " - "), CurrentPage.Title)
                TextWorkspace.Dock = DockStyle.Fill
            ElseIf CurrentPage.PageType = PageType.Title Then
                Dim TitleWorkspace As New TitleWorkspace
                TitleWorkspace.AssociatedPage = CurrentPage
                CurrentTabPage.Controls.Add(TitleWorkspace)
                CurrentTabPage.Text = String.Format("Page {1}{2}{3} ({0})", "Title", i + 1, IIf(CurrentPage.Title = "", "", " - "), CurrentPage.Title)
                TitleWorkspace.Dock = DockStyle.Fill
            ElseIf CurrentPage.PageType = PageType.Image Then
                Dim ImageWorkspace As New ImageWorkspace
                ImageWorkspace.AssociatedPage = CurrentPage
                CurrentTabPage.Text = String.Format("Page {1}{2}{3} ({0})", "Image", i + 1, IIf(CurrentPage.Title = "", "", " - "), CurrentPage.Title)
                CurrentTabPage.Controls.Add(ImageWorkspace)
                ImageWorkspace.Dock = DockStyle.Fill
            ElseIf CurrentPage.PageType = PageType.FreeResponse Then
                Dim FreeResponseWorkspace As New FreeResponseWorkspace
                FreeResponseWorkspace.AssociatedPage = CurrentPage
                CurrentTabPage.Controls.Add(FreeResponseWorkspace)
                CurrentTabPage.Text = String.Format("Page {1}{2}{3} ({0})", "Free Response", i + 1, IIf(CurrentPage.Title = "", "", " - "), CurrentPage.Title)
                FreeResponseWorkspace.Dock = DockStyle.Fill
            ElseIf CurrentPage.PageType = PageType.MultipleChoice Then
                Dim MultipleChoiceWorkspace As New MultipleChoiceWorkspace
                CurrentTabPage.Controls.Add(MultipleChoiceWorkspace)
                MultipleChoiceWorkspace.AssociatedPage = CurrentPage
                CurrentTabPage.Text = String.Format("Page {1}{2}{3} ({0})", "Multiple Choice", i + 1, IIf(CurrentPage.Title = "", "", " - "), CurrentPage.Title)
                MultipleChoiceWorkspace.Dock = DockStyle.Fill
            ElseIf CurrentPage.PageType = PageType.WebBrowser Then
                Dim WebBrowserWorkspace As New WebBrowserWorkspace
                CurrentTabPage.Controls.Add(WebBrowserWorkspace)
                WebBrowserWorkspace.AssociatedPage = CurrentPage
                CurrentTabPage.Text = String.Format("Page {1}{2}{3} ({0})", "Web Browser", i + 1, IIf(CurrentPage.Title = "", "", " - "), CurrentPage.Title)
                WebBrowserWorkspace.Dock = DockStyle.Fill
            ElseIf CurrentPage.PageType = PageType.Media Then
                Dim MediaWorkspace As New MediaWorkspace
                CurrentTabPage.Controls.Add(MediaWorkspace)
                MediaWorkspace.AssociatedPage = CurrentPage
                CurrentTabPage.Text = String.Format("Page {1}{2}{3} ({0})", "Media", i + 1, IIf(CurrentPage.Title = "", "", " - "), CurrentPage.Title)
                MediaWorkspace.Dock = DockStyle.Fill
                MediaWorkspace.Modify()
            End If
        Next
        If tcSlides.TabCount = 0 Then
            tcSlides.Visible = False
        Else
            tcSlides.Visible = True
        End If
        tcSlides.SelectedIndex = SelectedPage
        kuiMain.SetKeys(CurrentDocument.Keyboard)
        Updating = False
    End Sub

    Public Sub ChangePageType(ByVal PageType As PageType)
        If CurrentDocument.Pages.Count = 0 Then Exit Sub
        If CurrentDocument.Pages.Item(SelectedPage).PageType = PageType Then Exit Sub
        If MessageBox.Show("If you change the page type, you will lose all information on the current page. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Dim NewPage As New Page
            If PageType = PageType.Image Then
                NewPage = New ImagePage
            ElseIf PageType = PageType.Text Then
                NewPage = New TextPage
            ElseIf PageType = PageType.Title Then
                NewPage = New TitlePage
            ElseIf PageType = PageType.MultipleChoice Then
                NewPage = New MultipleChoiceQuestionPage
            ElseIf PageType = PageType.FreeResponse Then
                NewPage = New FreeResponseQuestionPage
            ElseIf PageType = PageType.WebBrowser Then
                NewPage = New WebBrowserPage
            End If
            NewPage.Title = CurrentDocument.Pages.Item(SelectedPage).Title
            CurrentDocument.Pages.Item(SelectedPage) = NewPage
            CurrentDocumentUpdate()
        End If
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        System.IO.Directory.Delete(Application.LocalUserAppDataPath)
        My.Settings.Save()
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Directory.CreateDirectory(AutosaveDir)
        CurrentDocument.ThornData.ThornVersion = 0
        CurrentDocument = New ThornFile
        If File.Exists(My.Application.CommandLineArgs(0)) Then CurrentDocument.Open(My.Application.CommandLineArgs(0))
        CurrentDocumentUpdate()
        If tcSlides.TabCount = 0 Then
            SelectedPage = 0
            tcSlides.Visible = False
        End If
        SplitContainer1.Panel2Collapsed = True
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        RedrawAero()
    End Sub

    Private Sub tcSlides_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcSlides.SelectedIndexChanged

        For Each p As TabPage In tcSlides.TabPages
            For Each c As Control In p.Controls
                If TypeOf c Is MediaWorkspace Then
                    Dim pl As MediaWorkspace = CType(c, MediaWorkspace)
                    pl.Pause()
                End If
            Next
        Next
        If Updating = True Then Exit Sub
        If tcSlides.SelectedIndex = -1 Then
            SelectedPage = 0
            tcSlides.Visible = False
        Else
            tcSlides.Visible = True
            SelectedPage = tcSlides.SelectedIndex
        End If
    End Sub

    Private Sub NewToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripButton.Click
        dlgNew.ShowDialog()
    End Sub

    Private Sub OpenToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripButton.Click
        If dlgOpen.ShowDialog() = DialogResult.OK Then
            CurrentDocument.Open(dlgOpen.FileName)
            CurrentDocumentUpdate()
            tmrWork.Enabled = True
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click
        If File.Exists(CurrentDocument.DocumentPath) = True Then
            CurrentDocument.Save(CurrentDocument.DocumentPath)
            tmrWork.Enabled = True
        Else
            If dlgSave.ShowDialog() = DialogResult.OK Then
                CurrentDocument.Save(dlgSave.FileName)
                tmrWork.Enabled = True
            End If
        End If
    End Sub

    Private Sub VocabularyToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles VocabularyToolStripButton.Click
        dlgVocabulary.Show()
    End Sub

    Private Sub KeyboardToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles KeyboardToolStripButton.Click
        dlgKeyboard.ShowDialog()
    End Sub

    Private Sub AboutToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripButton.Click
        dlgAbout.ShowDialog()
    End Sub

    Private Sub PagePropertiesToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PagePropertiesToolStripButton.Click
        If CurrentDocument.Pages.Count = 0 Then Exit Sub
        dlgPageProperties.ShowDialog()
    End Sub

    Private Sub CustomizeToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles CustomizeToolStripButton.Click
        dlgCustomize.ShowDialog()
    End Sub

    Private Sub BugReportToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        dlgContact.rbBug.Checked = True
        dlgContact.ShowDialog()
    End Sub

    Private Sub SaveAsToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveAsToolStripButton.Click
        If dlgSave.ShowDialog() = DialogResult.OK Then
            CurrentDocument.Save(dlgSave.FileName)
            tmrWork.Enabled = True
        End If
    End Sub

    Private Sub RemoveAllToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RemoveAllToolStripButton.Click
        If MessageBox.Show("Are you sure you want to remove all pages? This cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            CurrentDocument.Pages.Clear()
            CurrentDocumentUpdate()
        End If
    End Sub

    Private Sub AddToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles AddToolStripButton.Click
        dlgAdd.ShowDialog()
    End Sub

    Private Sub RemoveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RemoveToolStripButton.Click
        On Error Resume Next
        Dim PageAfter As Integer = tcSlides.SelectedIndex
        CurrentDocument.Pages.RemoveAt(tcSlides.SelectedIndex)
        If PageAfter <= CurrentDocument.Pages.Count - 1 Then
            tcSlides.SelectTab(PageAfter)
        Else
            tcSlides.SelectTab(CurrentDocument.Pages.Count - 1)
        End If
        CurrentDocumentUpdate()
    End Sub

    Private Sub MultipleChoiceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MultipleChoiceToolStripMenuItem.Click
        ChangePageType(PageType.MultipleChoice)
    End Sub

    Private Sub TextToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TextToolStripMenuItem.Click
        ChangePageType(PageType.Text)
    End Sub

    Private Sub VideoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MediaToolStripMenuItem.Click
        ChangePageType(PageType.Media)
    End Sub

    Private Sub FreeResponseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FreeResponseToolStripMenuItem.Click
        ChangePageType(PageType.FreeResponse)
    End Sub

    Private Sub TitleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TitleToolStripMenuItem.Click
        ChangePageType(PageType.Title)
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImageToolStripMenuItem.Click
        ChangePageType(PageType.Image)
    End Sub

    Private Sub WebBrowserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WebBrowserToolStripMenuItem.Click
        ChangePageType(PageType.WebBrowser)
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles GoToToolStripButton.Click
        dlgGoTo.ShowDialog()
    End Sub

    Private Sub BackToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles BackToolStripButton.Click
        MovePageBack()
    End Sub

    Private Sub ForwardToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles ForwardToolStripButton.Click
        MovePageForward()
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As System.Object, e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        RedrawAero()
    End Sub

    Private Sub OpenKeyboardToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenKeyboardToolStripButton.Click
        If SplitContainer1.Panel2Collapsed = True Then
            SplitContainer1.Panel2Collapsed = False
        Else
            SplitContainer1.Panel2Collapsed = True
        End If
        RedrawAero()
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        RedrawAero()
    End Sub

    Private Sub frmMain_ResizeBegin(sender As Object, e As System.EventArgs) Handles Me.ResizeBegin
        SuspendLayout()
    End Sub

    Private Sub frmMain_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd
        ResumeLayout()
    End Sub

    Private Sub frmMain_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then RedrawAero()
    End Sub

    Private Sub RunToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RunToolStripButton.Click
        frmViewer.Show()
    End Sub

    Private Sub tmrWork_Tick(sender As Object, e As EventArgs) Handles tmrWork.Tick

    End Sub
End Class
