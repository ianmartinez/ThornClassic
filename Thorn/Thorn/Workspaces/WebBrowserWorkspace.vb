
Public Class WebBrowserWorkspace
    Private mAssociatedPage As WebBrowserPage
    Public Property AssociatedPage As WebBrowserPage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As WebBrowserPage)
            mAssociatedPage = value
        End Set
    End Property

   
    Private Sub WebBrowserWorkspace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtURL.Text = AssociatedPage.url
    End Sub

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        On Error Resume Next
        wbMain.ScriptErrorsSuppressed = True
        wbMain.Navigate(txtURL.Text)
        AssociatedPage.URL = txtURL.Text
    End Sub
End Class
