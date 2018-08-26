Public Class DoubleBufferedTabs
    Inherits TabControl
    Public Sub New()
        Me.DoubleBuffered = True
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub
End Class
