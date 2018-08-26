Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class GradientButton
    Inherits Button
    Private mPositions As Single()
    Public Property Positions As Single()
        Get
            Return mPositions
        End Get
        Set(ByVal value As Single())
            mPositions = value
            Redraw()
            Refresh()
        End Set
    End Property

    Private mAngle As Integer
    Public Property Angle As Integer
        Get
            Return mAngle
        End Get
        Set(ByVal value As Integer)
            mAngle = value
            Redraw()
            Refresh()
        End Set
    End Property

    Private mColors As Color()
    Public Property Colors As Color()
        Get
            Return mColors
        End Get
        Set(ByVal value As Color())
            mColors = value
            Redraw()
            Refresh()
        End Set
    End Property

    Private mBorderColor As Color
    Public Property BorderColor As Color
        Get
            Return mBorderColor
        End Get
        Set(ByVal value As Color)
            mBorderColor = value
            Redraw()
            Refresh()
        End Set
    End Property

    Private mBorderRect As Rectangle
    Public Property BorderRect As Rectangle
        Get
            Return mBorderRect
        End Get
        Set(ByVal value As Rectangle)
            mBorderRect = value
            Redraw()
            Refresh()
        End Set
    End Property

    Private mNoDraw As Boolean
    Public Property NoDraw As Boolean
        Get
            Return mNoDraw
        End Get
        Set(ByVal value As Boolean)
            mNoDraw = value
            Redraw()
            Refresh()
        End Set
    End Property

    Private mTransparencyImage As Boolean
    Public Property TransparencyImage As Boolean
        Get
            Return mTransparencyImage
        End Get
        Set(ByVal value As Boolean)
            mTransparencyImage = value
            Redraw()
            Refresh()
        End Set
    End Property

    Private mNoDoubleBuffered As Boolean
    Public Property NoDoubleBuffered As Boolean
        Get
            Return mNoDoubleBuffered
        End Get
        Set(ByVal value As Boolean)
            mNoDoubleBuffered = value
            If NoDoubleBuffered = True Then
                DoubleBuffered = False
            Else
                DoubleBuffered = True
            End If
            Redraw()
            Refresh()
        End Set
    End Property
    Public Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)
        UpdateStyles()
    End Sub

    Public Sub Redraw()
        On Error Resume Next
        If NoDraw = False Then
            Dim b As New ColorBlend()
            Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
            Dim rectb As New Rectangle(rect.X + BorderRect.X, rect.Y + BorderRect.Y, rect.Width + BorderRect.Width, rect.Height + BorderRect.Height)
            Dim back As New Bitmap(rectb.Width, rectb.Height)
            Dim gr As Graphics = Graphics.FromImage(back)
            If TransparencyImage = True Then
                Dim br As New TextureBrush(My.Resources.Transparent2)
                gr.FillRectangle(br, rect)
            End If
            b.Colors = Colors
            b.Positions = Positions
            Dim g As New LinearGradientBrush(rect, Color.Transparent, Color.Transparent, Angle)
            g.InterpolationColors = b
            gr.FillRectangle(g, rect)
            gr.DrawRectangle(New Pen(New SolidBrush(BorderColor), 1), rectb)
            Me.Image = back
            Me.ImageAlign = ContentAlignment.MiddleCenter
        End If
    End Sub
    Private Sub GradientButton_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Redraw()
    End Sub
End Class
