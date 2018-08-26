Imports System.Windows.Forms

Public Class dlgGradient
    Private dlgColor As New ExtendedColorDialog
    Private mPositions As Single()
    Public Property Positions As Single()
        Get
            Return mPositions
        End Get
        Set(ByVal value As Single())
            mPositions = value
            UpdatePanel()
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
            UpdatePanel()
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
            UpdatePanel()
            Refresh()
        End Set
    End Property
    Private Suspend As Boolean = False
    Private Sub UpdatePanel()
        If Suspend = True Then Exit Sub
        SuspendLayout()
        On Error Resume Next
        pnlNew.Angle = Angle
        pnlNew.Positions = Positions
        pnlNew.Colors = Colors
        dgvMain.Rows.Clear()
        For i = 0 To Positions.Count - 1
            dgvMain.Rows.Add(Positions.GetValue(i), CType(Colors.GetValue(i), Color).ToArgb)
        Next
        nudAngle.Value = Angle
        pnlNew.Refresh()
        ResumeLayout()
    End Sub
    Private Sub UpdateDgv()
        Suspend = True
        Angle = nudAngle.Value
        Dim pos As New List(Of Single)
        Dim col As New List(Of Color)
        For Each dgvr As DataGridViewRow In dgvMain.Rows
            If Not dgvr.IsNewRow Then
                pos.Add(dgvr.Cells("Position").Value)
                col.Add(Drawing.Color.FromArgb(dgvr.Cells("Color").Value))
            End If
        Next
        Positions = pos.ToArray
        Colors = col.ToArray
        Suspend = False
        UpdatePanel()
    End Sub
    Private Sub dgvMain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellContentClick

        If e.ColumnIndex = 1 Then
            dlgColor.Color = System.Drawing.Color.FromArgb(dgvMain.Rows(e.RowIndex).Cells("Color").Value)
            If dlgColor.ShowDialog = DialogResult.OK Then
                dgvMain.Rows(e.RowIndex).Cells("Color").Value = dlgColor.Color.ToArgb
                UpdateDgv()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        On Error Resume Next
        dgvMain.Rows.Clear()
    End Sub

    Private Sub nudAngle_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudAngle.ValueChanged
        On Error Resume Next

        Angle = nudAngle.Value
    End Sub

    Private Sub dgvMain_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellEndEdit
        If Suspend = False Then UpdateDgv()
    End Sub

    Private Sub dgvMain_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellValueChanged
      
    End Sub

    Private Sub dlgGradient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlOld.Angle = Angle
        pnlOld.Positions = Positions
        pnlOld.Colors = Colors
        pnlOld.Refresh()
        UpdatePanel()

        For Each tp As TabPage In tcGradients.TabPages
            For Each c As Control In tp.Controls
                If TypeOf c Is Button Then
                    AddHandler c.Click, AddressOf btnGradient_Click
                End If
            Next
        Next
    End Sub
    Private Sub btnGradient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sButton As GradientButton = CType(sender, GradientButton)
        Colors = sButton.Colors
        Positions = sButton.Positions
        Angle = sButton.Angle
        UpdatePanel()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        On Error Resume Next
        dgvMain.Rows.Remove(dgvMain.SelectedRows.Item(0))
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
