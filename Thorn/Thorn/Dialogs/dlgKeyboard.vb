Imports System.Windows.Forms

Public Class dlgKeyboard
    Private IsLoading As Boolean

    Private Sub dgvMain_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellEndEdit
       
    End Sub

    Private Sub dlgKeyboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IsLoading = True
        kuiMain.SetKeys(CurrentDocument.Keyboard)
        dgvMain.Rows.Clear()
        For Each key As KeyValuePair(Of String, String) In kuiMain.GetKeys
            dgvMain.Rows.Add(key.Key, key.Value)
        Next
        IsLoading = False
        kuiMain.ClearKeys()
        For i = 0 To dgvMain.Rows.Count - 1
            Dim keyvalue As String = dgvMain.Rows(i).Cells(0).Value
            If Not keyvalue = Nothing Then kuiMain.AddKeys(keyvalue, dgvMain.Rows(i).Cells(1).Value)
        Next
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        CurrentDocument.Keyboard = kuiMain.GetKeys
        frmMain.kuiMain.SetKeys(CurrentDocument.Keyboard)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MessageBox.Show("Are you sure you want to clear all of the keys? This cannot be undone.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            CurrentDocument.Keyboard.Clear()
            dlgKeyboard_Load(sender, e)
        End If
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Keyboard As New KeyboardFile
            Keyboard.Open(dlgOpen.FileName)
            CurrentDocument.Keyboard = Keyboard.Keyboard
            dlgKeyboard_Load(sender, e)
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnUpdate_Click(Me, e)
            Dim Keyboard As New KeyboardFile
            Keyboard.Keyboard = kuiMain.GetKeys
            Keyboard.Save(dlgSave.FileName)
        End If
    End Sub

    Private Sub dgvMain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellContentClick

    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If IsLoading = True Then Exit Sub
        kuiMain.ClearKeys()
        For i = 0 To dgvMain.Rows.Count - 1
            Dim keyvalue As String = dgvMain.Rows(i).Cells(0).Value
            If Not keyvalue = Nothing Then kuiMain.AddKeys(keyvalue, dgvMain.Rows(i).Cells(1).Value)
        Next
    End Sub
End Class
