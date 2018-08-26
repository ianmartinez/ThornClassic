Imports System.Windows.Forms
Imports System.Net.Mail

Public Class dlgContact
    Private smtp As String = " "
    Private subject As String = " "
    Private rating As String = "Unrated"
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Try
            Cursor = Cursors.WaitCursor
            If cbEmail.SelectedItem = "aol.com" Then
                smtp = "smtp.aol.com"
            ElseIf cbEmail.SelectedItem = "att.net" Then
                smtp = "outbound.att.net"
            ElseIf cbEmail.SelectedItem = "comcast.net" Then
                smtp = "smtp.comcast.net"
            ElseIf cbEmail.SelectedItem = "earthlink.net" Then
                smtp = "smtpauth.earthlink.net"
            ElseIf cbEmail.SelectedItem = "gmail.com" Then
                smtp = "smtp.gmail.com"
            ElseIf cbEmail.SelectedItem = "hotmail.com" Then
                smtp = "smtp.live.com"
            ElseIf cbEmail.SelectedItem = "live.com" Then
                smtp = "smtp.live.com"
            ElseIf cbEmail.SelectedItem = "outlook.com" Then
                smtp = "smtp.live.com"
            ElseIf cbEmail.SelectedItem = "verizon.net" Then
                smtp = "outgoing.verizon.net"
            ElseIf cbEmail.SelectedItem = "yahoo.com" Then
                smtp = "mail.yahoo.com"
            End If

            If rbBug.Checked = True Then
                subject = "Bug - " & "Thorn " & Application.ProductVersion
            ElseIf rbSuggestions.Checked = True Then
                subject = "Suggestion - " & "Thorn " & Application.ProductVersion
            ElseIf rbOther.Checked = True Then
                subject = "Other - " & "Thorn " & Application.ProductVersion
            Else
                MessageBox.Show("Please select a subject before sending.")
                Exit Sub
            End If
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(txtEmail.Text.Replace(" ", "") + "@" + cbEmail.SelectedItem, txtPassword.Text)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = smtp

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtEmail.Text + "@" + cbEmail.SelectedItem)
            e_mail.To.Add("contact@fennecsoft.com")
            e_mail.Subject = subject & " - " & rating & " Stars"
            e_mail.IsBodyHtml = False
            e_mail.Body = txtMessage.Text
            Smtp_Server.Send(e_mail)
            Me.Close()
            Cursor = Cursors.Default
        Catch error_t As Exception
            Cursor = Cursors.Default
            MessageBox.Show("There was an error sending the message. Make sure your username and password are typed correctly.")
        End Try
    End Sub

    Private Sub dlgContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbEmail.SelectedItem = "gmail.com"
    End Sub

    Private Sub tbrRating_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrRating.Scroll
        rating = tbrRating.Value
    End Sub
End Class
