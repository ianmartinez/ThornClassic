Public Class TitleViewer
    Private mAssociatedPage As TitlePage
    Public Property AssociatedPage As TitlePage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As TitlePage)
            mAssociatedPage = value
            UpdatePage()
        End Set
    End Property
    Public Sub UpdatePage()
        lblTitle.Text = AssociatedPage.Text
        lblTitle.Font = CurrentDocument.Properties.TitleFont
        lblTitle.ForeColor = CurrentDocument.Properties.TitleFontColor
    End Sub

    Private Sub TitlePageViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        UpdatePage()
    End Sub
End Class
