Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class thGradientPanel
    Inherits Panel
    Private mPositions As Single()
    Public Property Positions As Single()
        Get
            Return mPositions
        End Get
        Set(ByVal value As Single())
            mPositions = value
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

            Refresh()
        End Set
    End Property
    Public Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)
        UpdateStyles()
    End Sub

    Private Sub thGradientPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        On Error Resume Next
        If NoDraw = False Then
            Dim b As New ColorBlend()
            b.Colors = Colors
            b.Positions = Positions
            Dim rect As New Rectangle(-1, -1, Me.Width + 2, Me.Height + 2)
            Dim g As New LinearGradientBrush(rect, Color.Transparent, Color.Transparent, Angle)
            g.InterpolationColors = b
            e.Graphics.FillRectangle(g, rect)
            Dim rectb As New Rectangle(rect.X + BorderRect.X, rect.Y + BorderRect.Y, rect.Width + BorderRect.Width, rect.Height + BorderRect.Height)
            e.Graphics.DrawRectangle(New Pen(New SolidBrush(BorderColor), 1), rectb)
        End If
    End Sub

    Private Sub thGradientPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If NoDraw = False Then Refresh()
    End Sub
End Class
