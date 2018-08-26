
Public Class TextWorkspace
    Private mAssociatedPage As TextPage
    Public Property AssociatedPage As TextPage
        Get
            Return mAssociatedPage
        End Get
        Set(ByVal value As TextPage)
            mAssociatedPage = value
        End Set
    End Property

    Private Sub txtMain_GotFocus(sender As Object, e As System.EventArgs) Handles txtMain.GotFocus
        frmMain.kuiMain.TextControl = txtMain
    End Sub
    Private Sub txtMain_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMain.TextChanged
        AssociatedPage.Text = txtMain.Text
    End Sub

    Private Sub TextWorkspace_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtMain.Text = AssociatedPage.Text
    End Sub
End Class
