Imports System.ComponentModel
Imports System.Windows.Forms
Imports Tundra

Public Class KeyboardUI
    Inherits FlowLayoutPanel
    Private mTextControl As TextBoxBase
    Public Event KeyboardPressed()
    Public Property TextControl As TextBoxBase
        Get
            Return mTextControl
        End Get
        Set(ByVal value As TextBoxBase)
            mTextControl = value
        End Set
    End Property

    Private Keys As New Dictionary(Of String, String)
    Private Sub CreateKeys()
        Me.Controls.Clear()
        Me.Padding = New Padding(5)
        Me.Margin = New Padding(5)
        For Each key As KeyValuePair(Of String, String) In Keys
            Dim keybutton As New StylizedButton
            keybutton.Style = My.Resources.KeyStyle
            Dim tooltip As New ToolTip
            keybutton.AutoSize = True
            keybutton.MinimumSize = New Size(32, 32)
            keybutton.Margin = New Padding(2)
            keybutton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            keybutton.Text = key.Key
            If Not key.Value = Nothing Then tooltip.SetToolTip(keybutton, key.Value)
            AddHandler keybutton.Click, AddressOf TypeKey
            Controls.Add(keybutton)
        Next
    End Sub

    Public Sub AddKeys(ByVal KeyValue As String, ByVal KeyTooltip As String)
        On Error Resume Next
        Keys.Add(KeyValue, KeyTooltip)
        CreateKeys()
    End Sub

    Public Sub SetKeys(ByVal NewKeys As Dictionary(Of String, String))
        Keys = NewKeys
        CreateKeys()
    End Sub

    Public Sub RemoveKeys(ByVal KeyValue As String)
        Keys.Remove(KeyValue)
        CreateKeys()
    End Sub

    Public Function GetKeys() As Dictionary(Of String, String)
        Return Keys
    End Function

    Public Sub ClearKeys()
        Keys.Clear()
        CreateKeys()
    End Sub

    Private Sub TypeKey(ByVal sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        Dim senderbutton As StylizedButton = CType(sender, StylizedButton)
        TextControl.AppendText(senderbutton.Text)
    End Sub

    Public Sub New()
        Me.AutoScroll = True
    End Sub
End Class
