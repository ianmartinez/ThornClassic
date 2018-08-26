Imports System.Windows.Forms

Public Class ExtendedColorDialog
    Private mColor As Color
    Public Property Color As Color
        Get
            Return mColor
        End Get
        Set(ByVal value As Color)
            mColor = value
        End Set
    End Property
    Private Suspend As Boolean = False
    Private Sub UpdateColor(Optional ByVal Load As Boolean = False)
        Suspend = True
        If Load = True Then
            nudA.Value = Color.A
            nudR.Value = Color.R
            nudG.Value = Color.G
            nudB.Value = Color.B
        End If
        Suspend = False
        tbA.Value = nudA.Value
        tbR.Value = nudR.Value
        tbG.Value = nudG.Value
        tbB.Value = nudB.Value
        Color = Color.FromArgb(nudA.Value, nudR.Value, nudG.Value, nudB.Value)
        pnlNew.Colors = {Color, Color}
    End Sub
    Private Sub ExtendedColorDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Color = Nothing Then
            Color = Drawing.Color.Black
        End If
        pnlOld.Colors = {Color, Color}
        For Each c As Control In DoubleBufferedPanel1.Controls
            If TypeOf c Is Button Then
                AddHandler c.Click, AddressOf btnColor_Click
            End If
        Next
        UpdateColor(True)
    End Sub

    Private Sub nudOpacity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Color = Color.FromArgb(nudA.Value, Color)
    End Sub

    Private Sub tbOpacity_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Color = Color.FromArgb(tbA.Value, Color)
    End Sub


    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Suspend = True
        Dim sButton As Button = CType(sender, Button)
        Color = sButton.BackColor
        nudA.Value = Color.A
        nudR.Value = Color.R
        nudG.Value = Color.G
        nudB.Value = Color.B
        tbA.Value = Color.A
        tbR.Value = Color.R
        tbG.Value = Color.G
        tbB.Value = Color.B
        UpdateColor()
        Suspend = False
    End Sub

    Private Sub nudR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudR.ValueChanged
        If Suspend = False Then
            tbR.Value = nudR.Value
            UpdateColor()
        End If
    End Sub

    Private Sub tbR_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbR.Scroll
        If Suspend = False Then
            nudR.Value = tbR.Value
        End If
    End Sub

    Private Sub nudG_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudG.ValueChanged
        If Suspend = False Then
            tbG.Value = nudG.Value
            UpdateColor()
        End If
    End Sub

    Private Sub tbG_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbG.Scroll
        If Suspend = False Then
            nudG.Value = tbG.Value
        End If
    End Sub

    Private Sub nudB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudB.ValueChanged
        If Suspend = False Then
            tbB.Value = nudB.Value
            UpdateColor()
        End If
    End Sub

    Private Sub tbB_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbB.Scroll
        If Suspend = False Then
            nudB.Value = tbB.Value
        End If
    End Sub

    Private Sub nudA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudA.ValueChanged
        If Suspend = False Then
            tbA.Value = nudA.Value
            UpdateColor()
        End If
    End Sub

    Private Sub tbA_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbA.Scroll
        If Suspend = False Then
            nudA.Value = tbA.Value
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
