﻿
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms

Public Class GrowLabel
    Inherits Label
    Private mGrowing As Boolean
    Public Sub New()
        Me.AutoSize = False
    End Sub
    Private Sub resizeLabel()
        If mGrowing Then
            Return
        End If
        Try
            mGrowing = True
            Dim sz As New Size(Me.Width, Int32.MaxValue)
            sz = TextRenderer.MeasureText(Me.Text, Me.Font, sz, TextFormatFlags.WordBreak)
            Me.Height = sz.Height
        Finally
            mGrowing = False
        End Try
    End Sub
    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        resizeLabel()
    End Sub
    Protected Overrides Sub OnFontChanged(e As EventArgs)
        MyBase.OnFontChanged(e)
        resizeLabel()
    End Sub
    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        resizeLabel()
    End Sub
End Class