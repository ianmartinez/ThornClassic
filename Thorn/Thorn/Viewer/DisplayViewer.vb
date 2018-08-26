Imports Tundra

Public Class DisplayViewer
    Private mAssociatedDisplay As Display
    Public Property AssociatedDisplay As Display
        Get
            Return mAssociatedDisplay
        End Get
        Set(ByVal value As Display)
            mAssociatedDisplay = value
            UpdateDisplay()
        End Set
    End Property
    Public Sub UpdateDisplay()
        On Error Resume Next
        Me.Controls.Clear()
        If AssociatedDisplay.Type = DisplayType.None Then
        ElseIf AssociatedDisplay.Type = DisplayType.Text Then
            Dim tRichTextBox As New GrowLabel
            tRichTextBox.AutoSize = False
            tRichTextBox.Dock = DockStyle.Top
            tRichTextBox.BorderStyle = Windows.Forms.BorderStyle.None
            tRichTextBox.Text = AssociatedDisplay.Text
            tRichTextBox.Font = New Font(CurrentDocument.Properties.Font, FontStyle.Italic)
            tRichTextBox.ForeColor = CurrentDocument.Properties.FontColor
            Me.AutoScroll = True
            Me.Controls.Add(tRichTextBox)
        ElseIf AssociatedDisplay.Type = DisplayType.WebBrowser Then
            Dim WebBrowser As New WebBrowser
            WebBrowser.Dock = DockStyle.Fill
            WebBrowser.Navigate(AssociatedDisplay.Url)
            Me.Controls.Add(WebBrowser)
        ElseIf AssociatedDisplay.Type = DisplayType.Image Then
            Dim PictureBox As New PictureBox
            PictureBox.Dock = DockStyle.Fill
            PictureBox.Image = AssociatedDisplay.Image
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom
            Me.Controls.Add(PictureBox)
        ElseIf AssociatedDisplay.Type = DisplayType.Media Then
            Dim Player As New Player
            Player.Dock = DockStyle.Fill
            Player.Media = AssociatedDisplay.Media
            Me.Controls.Add(Player)
        End If
    End Sub

    Private Sub DisplayViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        UpdateDisplay()
    End Sub
End Class
