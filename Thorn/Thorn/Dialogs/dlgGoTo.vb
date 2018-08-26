Imports System.Windows.Forms

Public Class dlgGoTo

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        On Error Resume Next
        If Viewing = True Then
            frmViewer.tcSlides.SelectedIndex = cbPages.SelectedIndex
        Else
            frmMain.tcSlides.SelectedIndex = cbPages.SelectedIndex
        End If
        Me.Close()
    End Sub

    Private Sub dlgGoTo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        cbPages.Items.Clear()
        For Each CurrentTab As TabPage In frmMain.tcSlides.TabPages
            cbPages.Items.Add(CurrentTab.Text)
        Next
        cbPages.SelectedIndex = frmMain.tcSlides.SelectedIndex
    End Sub

    Private Sub cbPages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPages.SelectedIndexChanged

    End Sub
End Class
