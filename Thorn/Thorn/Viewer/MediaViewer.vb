Public Class MediaViewer
    Private mAssociatedPage As MediaPage
    Public Property AssociatedPage As MediaPage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As MediaPage)
            mAssociatedPage = value
            UpdatePage()
        End Set
    End Property
    Public Sub UpdatePage()
        If AssociatedPage.HasCaption = True Then
            pnlMain.Panel1Collapsed = False
        Else
            pnlMain.Panel1Collapsed = True
        End If
        lblText.Text = AssociatedPage.Caption
        pMain.Media = AssociatedPage.Media
        lblText.Font = CurrentDocument.Properties.Font
        lblText.ForeColor = CurrentDocument.Properties.FontColor
        pnlMain.SplitterDistance = TextRenderer.MeasureText(lblText.Text, lblText.Font).Height
        ResizeSplitter()
    End Sub

    Private Sub MediaViewer_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        UpdatePage()
    End Sub

    Public Sub ResizeSplitter() Handles Me.Resize
        On Error Resume Next
        pnlMain.Panel2MinSize = Me.Height * 0.35
        pnlMain.SplitterDistance = lblText.Height + 5
    End Sub
End Class
