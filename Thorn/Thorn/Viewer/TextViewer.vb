Public Class TextViewer
    Private mAssociatedPage As TextPage
    Public Property AssociatedPage As TextPage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As TextPage)
            mAssociatedPage = value
            UpdatePage()
        End Set
    End Property
    Public Sub UpdatePage()
        rtbText.Text = AssociatedPage.Text
        rtbText.Font = CurrentDocument.Properties.Font
        rtbText.ForeColor = CurrentDocument.Properties.FontColor

    End Sub
    Private Sub TextViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        UpdatePage()
    End Sub

    Private Sub rtbText_TextChanged(sender As System.Object, e As System.EventArgs) Handles rtbText.TextChanged

    End Sub
End Class
