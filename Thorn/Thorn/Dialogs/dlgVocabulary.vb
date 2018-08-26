Imports System.Windows.Forms
Public Class dlgVocabulary

    Private Sub dlgVocabulary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvMain.Rows.Clear()
        On Error Resume Next
        For i = 0 To CurrentDocument.VocabularyList.Count - 1
            Dim vocab As Vocabulary = CurrentDocument.VocabularyList.Item(i)
            dgvMain.Rows.Add(vocab.Word, vocab.Translation, vocab.Picture)
            Dim imgcell As DataGridViewImageCell = dgvMain.Rows(i).Cells(2)
            imgcell.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            dgvMain.Rows(i).Height = (vocab.Picture.Height * dgvMain.Columns(2).Width) / vocab.Picture.Width
        Next
        dgvMain.Columns("Picture").DefaultCellStyle.NullValue = New Bitmap(1, 1)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        CurrentDocument.VocabularyList.Clear()
        For i = 0 To dgvMain.Rows.Count - 1
            Dim wordvalue As String = dgvMain.Rows(i).Cells(0).Value
            Dim NewVocab As New Vocabulary
            NewVocab.Word = wordvalue
            NewVocab.Translation = dgvMain.Rows(i).Cells(1).Value
            NewVocab.Picture = dgvMain.Rows(i).Cells(2).Value
            If Not wordvalue = Nothing Then CurrentDocument.VocabularyList.Add(NewVocab)
        Next
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dgvMain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellContentClick

    End Sub

    Private Sub dgvMain_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMain.CellDoubleClick
        If e.ColumnIndex = 2 Then
            If dlgOpenImage.ShowDialog = DialogResult.OK Then
                Dim img As Image = Image.FromFile(dlgOpenImage.FileName)
                Dim imgcell As DataGridViewImageCell = dgvMain.Rows(e.RowIndex).Cells(e.ColumnIndex)
                imgcell.Value = Image.FromFile(dlgOpenImage.FileName)
                imgcell.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
                dgvMain.Rows(e.RowIndex).Height = (img.Height * dgvMain.Columns(e.ColumnIndex).Width) / img.Width
            End If
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MessageBox.Show("Are you sure you want to clear all of the keys? This cannot be undone.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            CurrentDocument.VocabularyList.Clear()
            dlgVocabulary_Load(sender, e)
        End If
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Vocabulary As New VocabularyFile
            Vocabulary.Open(dlgOpen.FileName)
            CurrentDocument.VocabularyList = Vocabulary.VocabularyList
            dlgVocabulary_Load(sender, e)
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Vocabulary As New VocabularyFile
            For i = 0 To dgvMain.Rows.Count - 1
                Dim wordvalue As String = dgvMain.Rows(i).Cells(0).Value
                Dim NewVocab As New Vocabulary
                NewVocab.Word = wordvalue
                NewVocab.Translation = dgvMain.Rows(i).Cells(1).Value
                NewVocab.Picture = dgvMain.Rows(i).Cells(2).Value
                If Not wordvalue = Nothing Then Vocabulary.VocabularyList.Add(NewVocab)
            Next
            Vocabulary.VocabularyList = CurrentDocument.VocabularyList
            Vocabulary.Save(dlgSave.FileName)
        End If
    End Sub
End Class
