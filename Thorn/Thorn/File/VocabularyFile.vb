Imports System.Net.Mail
Imports System.Net
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.CodeDom.Compiler
Imports System.Resources
Imports System.Windows.Forms
Imports Ionic.Zip
Imports Tundra.ZiaFile

<Serializable()>
Public Class VocabularyFile
    Public VocabularyList As New List(Of Vocabulary)

    Public Sub Save(ByVal FilePath As String)
        VocabularyFileAccess.Save(FilePath, Me)
    End Sub

    Public Sub Open(ByVal FilePath)
        Dim NewVocabularyFile As VocabularyFile = VocabularyFileAccess.Open(FilePath)
        Me.VocabularyList = NewVocabularyFile.VocabularyList
    End Sub

    Public Sub New()
    End Sub
End Class

Module VocabularyFileAccess
    Sub Save(ByVal FilePath As String, ByVal VocabularyFile As VocabularyFile)
        On Error Resume Next
        Dim zip As New ZipFile
        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression

        Dim guid As Guid = System.Guid.NewGuid

        Dim tmp As String = Application.LocalUserAppDataPath & "\zip-" & guid.ToString
        IO.Directory.Delete(tmp, True)
        IO.Directory.CreateDirectory(tmp)

        Dim vocabimagefolder As String = tmp & "\vocab_images\"
        IO.Directory.CreateDirectory(vocabimagefolder)

        Dim ValueCollection As New List(Of ZiaLine)

        'Vocabulary
        ValueCollection.Add(New ZiaLine(LineType.Comment, "Vocabulary"))
        For i = 0 To VocabularyFile.VocabularyList.Count - 1
            Dim vocab As Vocabulary = VocabularyFile.VocabularyList.Item(i)
            ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Vocabulary " & i, ToCompatible(vocab.Word) & "|" & ToCompatible(vocab.Translation)))
            vocab.Picture.Save(vocabimagefolder & i)
        Next
        System.IO.File.WriteAllText(tmp & "\data.zia", Tundra.ZiaFile.Write(ValueCollection))
        zip.AddDirectory(tmp)
        zip.Save(FilePath)
    End Sub

    Public Function Open(ByVal FilePath As String) As VocabularyFile
        On Error Resume Next
        Dim zip As New ZipFile(FilePath)
        Dim guid As Guid = System.Guid.NewGuid
        Dim vocabfile As New VocabularyFile

        Dim tmp As String = Application.LocalUserAppDataPath & "\zip-" & guid.ToString
        System.IO.Directory.Delete(tmp, True)
        IO.Directory.CreateDirectory(tmp)
        zip.ExtractAll(tmp)
        Dim vocabimagefolder As String = tmp & "\vocab_images\"
        IO.Directory.CreateDirectory(vocabimagefolder)

        Dim datafile = Tundra.ZiaFile.Read(System.IO.File.ReadAllText(tmp & "\data.zia"))
        Dim KeyValueList As List(Of KeyValuePair(Of String, String)) = datafile.ToList
        For Each item As KeyValuePair(Of String, String) In KeyValueList
            If Not item.Key.StartsWith("Vocabulary") Then Continue For
            Dim vocab As New Vocabulary
            Dim i As Integer = item.Key.Remove(0, "Vocabulary ".Count)
            vocab.Word = item.Value.Split("|").GetValue(0)
            vocab.Translation = item.Value.Split("|").GetValue(1)
            If File.Exists(vocabimagefolder & i) Then vocab.Picture = Image.FromFile(vocabimagefolder & i)
            vocabfile.VocabularyList.Add(vocab)
        Next

        zip.Dispose()
        Return vocabfile
    End Function
End Module

