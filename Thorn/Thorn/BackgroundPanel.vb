Public Class BackgroundPanel
    Inherits thGradientPanel
    Public Sub UpdateBackground()
        If CurrentDocument.Properties.BackgroundType = BackgroundType.None Then
            Me.Colors = {Color.Transparent, Color.Transparent}
            Me.Positions = {0, 1}
            Me.NoDraw = True
        ElseIf CurrentDocument.Properties.BackgroundType = BackgroundType.SolidColor Then
            Me.BackColor = CurrentDocument.Properties.BackgroundColor
            Me.Colors = {Color.Transparent, Color.Transparent}
            Me.Positions = {0, 1}
            Me.NoDraw = True
        ElseIf CurrentDocument.Properties.BackgroundType = BackgroundType.Gradient Then
            Me.Colors = CurrentDocument.Properties.BackgroundBlendColors
            Me.Positions = CurrentDocument.Properties.BackgroundBlendPositions
            Me.Angle = CurrentDocument.Properties.BackgroundBlendAngle
            Me.NoDraw = False
        ElseIf CurrentDocument.Properties.BackgroundType = BackgroundType.Image Then
            Me.Colors = {Color.Transparent, Color.Transparent}
            Me.Positions = {0, 1}
            Me.BackgroundImage = CurrentDocument.Properties.BackgroundImage
            Me.BackgroundImageLayout = CurrentDocument.Properties.BackgroundImageLayout
            Me.NoDraw = True
        End If
    End Sub
End Class
