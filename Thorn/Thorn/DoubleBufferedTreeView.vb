Imports System.Windows.Forms

Public Class DoubleBufferedTreeView
    Inherits TreeView
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

    Public Sub New()
        'Me.DoubleBuffered = True
        'SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        'UpdateStyles()
    End Sub

    Private Sub DoubleBufferedTreeView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If NoDraw = False Then Refresh()
    End Sub
End Class
