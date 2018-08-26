Imports System.IO
Imports System.Windows.Forms

Public Class Player
    Private mMedia As MediaFile
    Public Property Media As MediaFile
        Get
            Return mMedia
        End Get
        Set(ByVal value As MediaFile)
            mMedia = value
            Refresh()
            UpdateMedia()
        End Set
    End Property
    Public Sub Pause()
        wmpMain.Ctlcontrols.pause()
    End Sub
    Private Sub UpdateMedia()
        On Error Resume Next
        lblTitle.Text = Media.Title
        If lblTitle.Text = "" Then
            pnlTitle.Visible = False
        Else
            pnlTitle.Visible = True
        End If
        wmpMain.close()
        If Directory.Exists(Application.LocalUserAppDataPath & "\media") = False Then Directory.CreateDirectory(Application.LocalUserAppDataPath & "\media")
        File.WriteAllBytes(Application.LocalUserAppDataPath & "\media" & "." & Media.FileExt, Media.Bytes)
        wmpMain.URL = Application.LocalUserAppDataPath & "\media" & "." & Media.FileExt
        wmpMain.Ctlcontrols.stop()
        GC.Collect()
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wmpMain.Enter

    End Sub

    Private Sub Player_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub Player_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        wmpMain.Ctlcontrols.pause()
    End Sub

    Private Sub Player_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        wmpMain.Ctlcontrols.pause()
    End Sub

    Private Sub Player_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub wmpMain_Enter(sender As System.Object, e As System.EventArgs) Handles wmpMain.Enter

    End Sub

    Private Sub lblTitle_Click(sender As System.Object, e As System.EventArgs) Handles lblTitle.Click

    End Sub
End Class
