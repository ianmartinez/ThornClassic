Imports System.Windows.Forms

Public Class dlgReadVocabulary
    Private Sub dlgReadVocabulary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
End Class
