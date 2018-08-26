Public Class ImageViewer
    Private mAssociatedPage As ImagePage
    Public Property AssociatedPage As ImagePage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As ImagePage)
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
        pctImage.Image = AssociatedPage.Image
        lblText.Font = CurrentDocument.Properties.Font
        lblText.ForeColor = CurrentDocument.Properties.FontColor
        ResizeSplitter()
    End Sub

    Private Sub ImageViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        UpdatePage()
    End Sub

    Public Sub ResizeSplitter() Handles Me.Resize
        On Error Resume Next
        pnlMain.Panel2MinSize = Me.Height * 0.35
        pnlMain.SplitterDistance = lblText.Height + 5
    End Sub
End Class
