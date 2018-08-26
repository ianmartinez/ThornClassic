Imports System.Drawing
Public Class RichTextEditor
    Private dlgColor As New ExtendedColorDialog
    Public ReadOnly AssociatedRichTextBox As RichTextBox = Me.rtbDoc
    Private Sub FontToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FontToolStripButton.Click
        dlgFont.Font = rtbDoc.SelectionFont
        dlgFont.ShowApply = True
        If dlgFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            rtbDoc.SelectionFont = dlgFont.Font
        End If
    End Sub

    Private Sub BoldToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles BoldToolStripButton.Click
        rtbDoc.SelectionFont = New Font(rtbDoc.SelectionFont, rtbDoc.SelectionFont.Style Xor FontStyle.Bold)
    End Sub

    Private Sub ItalicToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles ItalicToolStripButton.Click
        rtbDoc.SelectionFont = New Font(rtbDoc.SelectionFont, rtbDoc.SelectionFont.Style Xor FontStyle.Italic)
    End Sub

    Private Sub UnderlineToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles UnderlineToolStripButton.Click
        rtbDoc.SelectionFont = New Font(rtbDoc.SelectionFont, rtbDoc.SelectionFont.Style Xor FontStyle.Underline)
    End Sub

    Private Sub StrikeToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles StrikeToolStripButton.Click
        rtbDoc.SelectionFont = New Font(rtbDoc.SelectionFont, rtbDoc.SelectionFont.Style Xor FontStyle.Strikeout)
    End Sub

    Private Sub TextColorToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles TextColorToolStripButton.Click
        dlgColor.Color = rtbDoc.SelectionColor
        If dlgColor.ShowDialog = DialogResult.OK Then
            rtbDoc.SelectionColor = dlgColor.Color
        End If
    End Sub

    Private Sub HighlightColorToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles HighlightColorToolStripButton.Click
        dlgColor.Color = rtbDoc.SelectionBackColor
        If dlgColor.ShowDialog = DialogResult.OK Then
            rtbDoc.SelectionBackColor = dlgColor.Color
        End If
    End Sub

    Private Sub BackColorToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles BackColorToolStripButton.Click
        dlgColor.Color = rtbDoc.BackColor
        If dlgColor.ShowDialog = DialogResult.OK Then
            rtbDoc.BackColor = dlgColor.Color
        End If
    End Sub

    Private Sub AlignLeftToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles AlignLeftToolStripButton.Click
        rtbDoc.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub AlignCenterToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles AlignCenterToolStripButton.Click
        rtbDoc.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub AlignRightToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles AlignRightToolStripButton.Click
        rtbDoc.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub NoneToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NoneToolStripMenuItem.Click
        rtbDoc.SelectionIndent = 0
    End Sub

    Private Sub PxToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PxToolStripMenuItem.Click
        rtbDoc.SelectionIndent = 5
    End Sub

    Private Sub PxToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PxToolStripMenuItem1.Click
        rtbDoc.SelectionIndent = 10
    End Sub

    Private Sub PxToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles PxToolStripMenuItem2.Click
        rtbDoc.SelectionIndent = 15
    End Sub

    Private Sub PxToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles PxToolStripMenuItem3.Click
        rtbDoc.SelectionIndent = 20
    End Sub

    Private Sub LeftToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        rtbDoc.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        rtbDoc.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RightToolStripMenuItem.Click
        rtbDoc.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub AddBulletsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddBulletsToolStripMenuItem.Click
        rtbDoc.BulletIndent = 10
        rtbDoc.SelectionBullet = True
    End Sub

    Private Sub RemoveBulletsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveBulletsToolStripMenuItem.Click
        rtbDoc.SelectionBullet = False
    End Sub

    Private Sub UndoToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles UndoToolStripButton.Click
        If rtbDoc.CanUndo Then rtbDoc.Undo()
    End Sub

    Private Sub RedoToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles RedoToolStripButton.Click
        If rtbDoc.CanRedo Then rtbDoc.Redo()
    End Sub

    Private Sub CopyToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripButton.Click
        rtbDoc.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles PasteToolStripButton.Click
        rtbDoc.Paste()
    End Sub

    Private Sub CutToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles CutToolStripButton.Click
        rtbDoc.Cut()
    End Sub
End Class
