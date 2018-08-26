Module ThornCommon
    Public CurrentDocument As ThornFile
    Public Viewing As Boolean = False
    Public AutosaveDir As String = Application.LocalUserAppDataPath & "\autosave"
    Public SelectedPage As Integer = 0
    Public Sub MovePageBack()
        If SelectedPage > 0 Then
            Dim I = SelectedPage - 1
            CurrentDocument.Pages.Insert(I, CurrentDocument.Pages.Item(SelectedPage))
            CurrentDocument.Pages.RemoveAt(SelectedPage + 1)
            SelectedPage = I
            frmMain.CurrentDocumentUpdate()
        End If
    End Sub
    Public Sub MovePageForward()
        If SelectedPage < CurrentDocument.Pages.Count - 1 Then
            Dim I = SelectedPage + 2
            CurrentDocument.Pages.Insert(I, CurrentDocument.Pages.Item(SelectedPage))
            CurrentDocument.Pages.RemoveAt(SelectedPage)
            SelectedPage = I - 1
            frmMain.CurrentDocumentUpdate()
        End If
    End Sub
End Module
