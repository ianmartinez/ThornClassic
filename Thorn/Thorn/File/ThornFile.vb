Imports System.IO
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.CodeDom.Compiler
Imports System.Resources
Imports System.Reflection
Imports System.Drawing
Imports System.Windows.Forms
Imports Tundra
Imports Ionic.Zip
Imports System.Text.RegularExpressions

<Serializable()>
Public Enum LanguageType
    Natural = 0
    Constructed = 1
End Enum

<Serializable()>
Public Enum LanguageStatus
    CriticallyEndangered = 0
    Endangered = 1
    NotEndangered = 2
End Enum

<Serializable()>
Public Enum BackgroundType
    None = 0
    Image = 1
    SolidColor = 2
    Gradient = 3
End Enum

<Serializable()>
Public Enum PageType
    Image = 0
    Text = 1
    Title = 2
    FreeResponse = 3
    MultipleChoice = 4
    WebBrowser = 5
    Media = 6
End Enum

<Serializable()>
Public Enum DisplayType
    None = 0
    Image = 1
    Text = 2
    WebBrowser = 3
    Media = 4
End Enum

<Serializable()>
Public Class ThornData
    Public Modified = False
    Public ThornVersion As String = Application.ProductVersion
End Class

<Serializable()>
Public Class DocumentProperties
    ' Main
    Public Title As String
    Public Author As String
    Public Website As String
    Public Version As Decimal = 1.0
    Public Icon As Image = Nothing
    Public Description As String
    ' Language Data
    Public LanguageName As String = "Untitled"
    Public LanguageFamily As String = "Isolate"
    Public LanguageType As LanguageType = LanguageType.Natural
    Public LanguageStatus As LanguageStatus = LanguageStatus.NotEndangered
    Public LanguageDescription As String
    ' Background
    Public BackgroundType As BackgroundType = BackgroundType.None
    Public BackgroundImageLayout As ImageLayout = ImageLayout.None
    Public BackgroundImage As Image
    Public BackgroundColor As Color = Color.White
    Public BackgroundBlendPositions() As Single = {0, 1}
    Public BackgroundBlendColors() As Color = {Color.Azure, Color.LightBlue}
    Public BackgroundBlendAngle As Integer = 90
    ' Text
    Public Font As Font = SystemFonts.DefaultFont
    Public FontColor As Color = SystemColors.ControlText
    Public TitleFont As Font = SystemFonts.DefaultFont
    Public TitleFontColor As Color = SystemColors.ControlText
End Class

<Serializable()>
Public Class MediaFile
    Public Bytes() As Byte
    Public FileExt As String
    Public Title As String
End Class

<Serializable()>
Public Class Display
    Public Type As DisplayType
    Public Text As String
    Public Image As Image
    Public Media As New MediaFile
    Public Url As String
End Class

<Serializable()>
Public Class Page
    Public Title As String
    Public PageType As PageType
End Class

<Serializable()>
Public Class TextPage
    Inherits Page
    Public Text As String

    Public Sub New()
        Me.PageType = PageType.Text
    End Sub
End Class

<Serializable()>
Public Class WebBrowserPage
    Inherits Page
    Public URL As String

    Public Sub New()
        Me.PageType = PageType.WebBrowser
    End Sub
End Class

<Serializable()>
Public Class MediaPage
    Inherits Page
    Public Media As New MediaFile
    Public HasCaption As Boolean
    Public Caption As String
    Public Sub New()
        Me.PageType = PageType.Media
    End Sub
End Class

<Serializable()>
Public Class TitlePage
    Inherits Page
    Public Text As String

    Public Sub New()
        Me.PageType = PageType.Title
    End Sub
End Class

<Serializable()>
Public Class ImagePage
    Inherits Page
    Public Image As Image
    Public HasCaption As Boolean
    Public Caption As String

    Public Sub New()
        Me.PageType = PageType.Image
    End Sub
End Class

<Serializable()>
Public Class QuestionPage
    Inherits Page
    Public Question As String
    Public Display As New Display
    Public Hint As String
    Public Sub New()
    End Sub
End Class

<Serializable()>
Public Class FreeResponseQuestionPage
    Inherits QuestionPage
    Public CorrectAnswers As New List(Of String)

    Public Sub New()
        Me.PageType = PageType.FreeResponse
    End Sub
End Class

<Serializable()>
Public Class MultipleChoiceQuestionPage
    Inherits QuestionPage
    Public CorrectAnswer As String
    Public AnswerChoices As New List(Of String)

    Public Sub New()
        Me.PageType = PageType.MultipleChoice
    End Sub
End Class

<Serializable()>
Public Class Vocabulary
    Public Word As String
    Public Translation As String
    Public Picture As Image

    Public Sub New()

    End Sub
End Class


<Serializable()>
Public Class ThornFile
    Public ThornData As New ThornData
    Public Properties As New DocumentProperties
    Public DocumentPath As String
    Public Pages As New List(Of Page)
    Public Keyboard As New Dictionary(Of String, String)
    'Public Resources As New Dictionary(Of String, Object)
    Public VocabularyList As New List(Of Vocabulary)

    Public Sub Save(ByVal FilePath As String, Optional ByVal Autosave As Boolean = False)
        If File.Exists(FilePath) Then File.Delete(FilePath)
        ThornFileAccess.Save(FilePath, Me)
        ThornFileAccess.Save(FilePath, Me)
        If Autosave = False Then
            Me.DocumentPath = FilePath
        End If
        Me.ThornData.Modified = False
    End Sub

    Public Sub Open(ByVal FilePath)
        Dim NewThornFile As ThornFile = ThornFileAccess.Open(FilePath)
        Me.ThornData = NewThornFile.ThornData
        Me.Properties = NewThornFile.Properties
        Me.Pages = NewThornFile.Pages
        Me.Keyboard = NewThornFile.Keyboard
        Me.VocabularyList = NewThornFile.VocabularyList
        Me.DocumentPath = FilePath
        Me.ThornData.Modified = False
    End Sub

    Public Sub New()
    End Sub
End Class

Module ThornFileAccess
    Dim resourcesfolder As String
    Sub Save(ByVal FilePath As String, ByVal ThornFile As ThornFile)
        On Error Resume Next
        Dim zip As New ZipFile
        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression

       Dim guid As Guid = System.Guid.NewGuid

        Dim tmp As String = Application.LocalUserAppDataPath & "\zip-" & guid.ToString
        IO.Directory.Delete(tmp, True)
        IO.Directory.CreateDirectory(tmp)

        resourcesfolder = tmp & "\resources\"
        IO.Directory.CreateDirectory(resourcesfolder)
        Dim vocabimagefolder As String = tmp & "\vocab_images\"
        IO.Directory.CreateDirectory(vocabimagefolder)

        Dim ValueCollection As New List(Of ZiaLine)

        'Thorn Data
        ValueCollection.Add(New ZiaLine(LineType.Comment, "Thorn"))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Thorn Version", ThornFile.ThornData.ThornVersion))
        ValueCollection.Add(New ZiaLine(LineType.Blank))

        ValueCollection.Add(New ZiaLine(LineType.Comment, "Customization"))
        'Main
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Title", ToCompatible(ThornFile.Properties.Title)))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Author", ToCompatible(ThornFile.Properties.Author)))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Website", ToCompatible(ThornFile.Properties.Website)))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Version", ThornFile.Properties.Version))
        ThornFile.Properties.Icon.Save(tmp & "\" & "icon.png", System.Drawing.Imaging.ImageFormat.Png)
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Description", ToCompatible(ThornFile.Properties.Description)))
        'Language Data
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Language Name", ToCompatible(ThornFile.Properties.LanguageName)))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Language Family", ToCompatible(ThornFile.Properties.LanguageFamily)))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Language Type", ThornFile.Properties.LanguageType))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Language Status", ThornFile.Properties.LanguageStatus))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Language Description", ToCompatible(ThornFile.Properties.LanguageDescription)))
        'Background
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Background Type", ThornFile.Properties.BackgroundType))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Language Image Layout", ThornFile.Properties.BackgroundImageLayout))
        ThornFile.Properties.BackgroundImage.Save(tmp & "\" & "background.png", System.Drawing.Imaging.ImageFormat.Png)
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Background Color", ZiaFile.ToCompatibleColor(ThornFile.Properties.BackgroundColor)))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Background Blend Positions", ZiaFile.ToCompatibleSingleList(ThornFile.Properties.BackgroundBlendPositions)))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Background Blend Colors", ZiaFile.ToCompatibleColorList(ThornFile.Properties.BackgroundBlendColors)))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Background Blend Angle", ThornFile.Properties.BackgroundBlendAngle))
        'Text
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Font", ZiaFile.ToCompatibleFont(ThornFile.Properties.Font)))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Font Color", ZiaFile.ToCompatibleColor(ThornFile.Properties.FontColor)))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Title Font", ZiaFile.ToCompatibleFont(ThornFile.Properties.TitleFont)))
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Title Font Color", ZiaFile.ToCompatibleColor(ThornFile.Properties.TitleFontColor)))
        ValueCollection.Add(New ZiaLine(LineType.Blank))

        'Keyboard
        ValueCollection.Add(New ZiaLine(LineType.Comment, "Keyboard"))
        Dim Keyprogress As Integer = 0
        For Each key As KeyValuePair(Of String, String) In ThornFile.Keyboard
            ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Keyboard " & Keyprogress, ToCompatible(key.Key) & "|" & ToCompatible(key.Value)))
            Keyprogress += 1
        Next
        ValueCollection.Add(New ZiaLine(LineType.Blank))

        'Vocabulary
        ValueCollection.Add(New ZiaLine(LineType.Comment, "Vocabulary"))
        For i = 0 To ThornFile.VocabularyList.Count - 1
            Dim vocab As Vocabulary = ThornFile.VocabularyList.Item(i)
            ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Vocabulary " & i, ToCompatible(vocab.Word) & "|" & ToCompatible(vocab.Translation)))
            vocab.Picture.Save(vocabimagefolder & i)
        Next
        ValueCollection.Add(New ZiaLine(LineType.Blank))

        'Pages
        ValueCollection.Add(New ZiaLine(LineType.Comment, "Pages"))
        For i = 0 To ThornFile.Pages.Count - 1
            Dim page As Page = ThornFile.Pages.Item(i)
            ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Type", page.PageType))
            ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Title", page.Title))
            If page.PageType = PageType.Title Then
                Dim titlepage = CType(page, TitlePage)
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Text", ToCompatible(titlepage.Text)))
            ElseIf page.PageType = PageType.Text Then
                Dim textpage = CType(page, TextPage)
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Text", ToCompatible(textpage.Text)))
            ElseIf page.PageType = PageType.Image Then
                Dim imagepage = CType(page, ImagePage)
                imagepage.Image.Save(resourcesfolder & "\Page " & i & " Image")
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " HasCaption", imagepage.HasCaption))
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Caption", ToCompatible(imagepage.Caption)))
            ElseIf page.PageType = PageType.WebBrowser Then
                Dim webbrowserpage = CType(page, WebBrowserPage)
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " URL", webbrowserpage.URL))
            ElseIf page.PageType = PageType.Media Then
                Dim mediapage = CType(page, MediaPage)
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Media", ToCompatibleMedia(mediapage.Media, i & "." & mediapage.Media.FileExt)))
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " HasCaption", mediapage.HasCaption))
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Caption", ToCompatible(mediapage.Caption)))
            ElseIf page.PageType = PageType.FreeResponse Then
                Dim freeresponsepage = CType(page, FreeResponseQuestionPage)
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Question", freeresponsepage.Question))
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Hint", freeresponsepage.Hint))
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Display", ToCompatibleDisplay(freeresponsepage.Display, i)))
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " CorrectAnswers", ToCompatibleStringList(freeresponsepage.CorrectAnswers)))
            ElseIf page.PageType = PageType.MultipleChoice Then
                Dim multiplechoicepage = CType(page, MultipleChoiceQuestionPage)
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Question", multiplechoicepage.Question))
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Hint", multiplechoicepage.Hint))
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " CorrectAnswer", multiplechoicepage.CorrectAnswer))
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " Display", ToCompatibleDisplay(multiplechoicepage.Display, i)))
                ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Page " & i & " AnswerChoices", ToCompatibleStringList(multiplechoicepage.AnswerChoices)))
            End If
        Next
        ValueCollection.Add(New ZiaLine(LineType.Blank))
        System.IO.File.WriteAllText(tmp & "\data.zia", ZiaFile.Write(ValueCollection))
        zip.AddDirectory(tmp)
        zip.Save(FilePath)
    End Sub

    Public Function Open(ByVal FilePath As String) As ThornFile
        On Error Resume Next
        Dim zip As New ZipFile(FilePath)

        Dim guid As Guid = System.Guid.NewGuid

        Dim tmp As String = Application.LocalUserAppDataPath & "\zip-" & guid.ToString
        IO.Directory.Delete(tmp, True)
        IO.Directory.CreateDirectory(tmp)

        zip.ExtractAll(tmp)
        resourcesfolder = tmp & "\resources\"
        IO.Directory.CreateDirectory(resourcesfolder)
        Dim vocabimagefolder As String = tmp & "\vocab_images\"
        IO.Directory.CreateDirectory(vocabimagefolder)

        Dim datafile = ZiaFile.Read(System.IO.File.ReadAllText(tmp & "\data.zia"))
        Dim newthornfile As New ThornFile
        'Thorn
        newthornfile.ThornData.ThornVersion = ZiaFile.Search(datafile, "Thorn Version")
        'Main
        newthornfile.Properties.Title = ZiaFile.Search(datafile, "Title")
        newthornfile.Properties.Author = ZiaFile.Search(datafile, "Author")
        newthornfile.Properties.Website = ZiaFile.Search(datafile, "Website")
        newthornfile.Properties.Version = ZiaFile.Search(datafile, "Version")
        If File.Exists(tmp & "\" & "icon.png") Then newthornfile.Properties.Icon = Image.FromFile(tmp & "\" & "icon.png")
        newthornfile.Properties.Description = ZiaFile.Search(datafile, "Description")
        'Language
        newthornfile.Properties.LanguageName = ZiaFile.Search(datafile, "Language Name")
        newthornfile.Properties.LanguageFamily = ZiaFile.Search(datafile, "Language Family")
        newthornfile.Properties.LanguageType = ZiaFile.Search(datafile, "Language Type")
        newthornfile.Properties.LanguageStatus = ZiaFile.Search(datafile, "Language Status")
        newthornfile.Properties.LanguageDescription = ZiaFile.Search(datafile, "Language Description")
        'Background
        newthornfile.Properties.BackgroundType = ZiaFile.Search(datafile, "Background Type")
        newthornfile.Properties.BackgroundImageLayout = ZiaFile.Search(datafile, "Background Image Layout")
        If File.Exists(tmp & "\" & "background.png") Then newthornfile.Properties.BackgroundImage = Image.FromFile(tmp & "\" & "background.png")
        newthornfile.Properties.BackgroundColor = ZiaFile.ReadColor(ZiaFile.Search(datafile, "Background Color"))
        newthornfile.Properties.BackgroundBlendColors = ZiaFile.ReadColorList(ZiaFile.Search(datafile, "Background Blend Colors"))
        newthornfile.Properties.BackgroundBlendPositions = ZiaFile.ReadSingleList(ZiaFile.Search(datafile, "Background Blend Positions"))
        newthornfile.Properties.BackgroundBlendAngle = ZiaFile.Search(datafile, "Background Blend Angle")
        'Font
        newthornfile.Properties.Font = ReadFont(ZiaFile.Search(datafile, "Font"))
        newthornfile.Properties.FontColor = ZiaFile.ReadColor(ZiaFile.Search(datafile, "Font Color"))
        newthornfile.Properties.TitleFont = ReadFont(ZiaFile.Search(datafile, "Title Font"))
        newthornfile.Properties.TitleFontColor = ZiaFile.ReadColor(ZiaFile.Search(datafile, "Title Font Color"))
        Dim KeyValueList As List(Of KeyValuePair(Of String, String)) = datafile.ToList
        'Keyboard
        For Each item As KeyValuePair(Of String, String) In KeyValueList
            If Not item.Key.StartsWith("Keyboard") Then Continue For
            newthornfile.Keyboard.Add(item.Value.Split({"|"}, StringSplitOptions.RemoveEmptyEntries).GetValue(0), item.Value.Split({"|"}, StringSplitOptions.RemoveEmptyEntries).GetValue(1))
        Next
        'Vocabulary
        For Each item As KeyValuePair(Of String, String) In KeyValueList
            If Not item.Key.StartsWith("Vocabulary") Then Continue For
            Dim vocab As New Vocabulary
            Dim i As Integer = item.Key.Remove(0, "Vocabulary ".Count)
            vocab.Word = item.Value.Split("|").GetValue(0)
            vocab.Translation = item.Value.Split("|").GetValue(1)
            If File.Exists(vocabimagefolder & i) Then vocab.Picture = Image.FromFile(vocabimagefolder & i)
            newthornfile.VocabularyList.Add(vocab)
        Next
        'Pages
        For Each item As KeyValuePair(Of String, String) In KeyValueList
            If Not item.Key.StartsWith("Page") Then Continue For
            Dim i As Integer = item.Key.Split(" ").GetValue(1)
            Dim keytype As String = item.Key.Split(" ").GetValue(2)
            If keytype = "Type" Then
                Dim PageType As PageType = item.Value
                If PageType = Thorn.PageType.Title Then
                    newthornfile.Pages.Add(New TitlePage)
                ElseIf PageType = Thorn.PageType.Text Then
                    newthornfile.Pages.Add(New TextPage)
                ElseIf PageType = Thorn.PageType.Image Then
                    newthornfile.Pages.Add(New ImagePage)
                ElseIf PageType = Thorn.PageType.WebBrowser Then
                    newthornfile.Pages.Add(New WebBrowserPage)
                ElseIf PageType = Thorn.PageType.Media Then
                    newthornfile.Pages.Add(New MediaPage)
                ElseIf PageType = Thorn.PageType.FreeResponse Then
                    newthornfile.Pages.Add(New FreeResponseQuestionPage)
                ElseIf PageType = Thorn.PageType.MultipleChoice Then
                    newthornfile.Pages.Add(New MultipleChoiceQuestionPage)
                End If
            Else
                Dim PageType As PageType = newthornfile.Pages.Item(i).PageType
                Dim Page As Page = newthornfile.Pages.Item(i)
                Page.Title = ZiaFile.Search(datafile, "Page " & i & " Title")
                If PageType = Thorn.PageType.Title Then
                    Dim TitlePage = CType(Page, TitlePage)
                    TitlePage.Text = ZiaFile.Search(datafile, "Page " & i & " Text")
                ElseIf PageType = Thorn.PageType.Text Then
                    Dim TextPage = CType(Page, TextPage)
                    TextPage.Text = ZiaFile.Search(datafile, "Page " & i & " Text")
                ElseIf PageType = Thorn.PageType.Image Then
                    Dim ImagePage = CType(Page, ImagePage)
                    ImagePage.Image = Image.FromFile(resourcesfolder & "\Page " & i & " Image")
                    ImagePage.HasCaption = ZiaFile.Search(datafile, "Page " & i & " HasCaption")
                    ImagePage.Caption = ZiaFile.Search(datafile, "Page " & i & " Caption")
                ElseIf PageType = Thorn.PageType.WebBrowser Then
                    Dim WebBrowserPage = CType(Page, WebBrowserPage)
                    WebBrowserPage.URL = ZiaFile.Search(datafile, "Page " & i & " URL")
                ElseIf PageType = Thorn.PageType.Media Then
                    Dim MediaPage = CType(Page, MediaPage)
                    MediaPage.HasCaption = ZiaFile.Search(datafile, "Page " & i & " HasCaption")
                    MediaPage.Caption = ZiaFile.Search(datafile, "Page " & i & " Caption")
                    MediaPage.Media = FromCompatibleMedia(ZiaFile.Search(datafile, "Page " & i & " Media"))
                ElseIf PageType = Thorn.PageType.FreeResponse Then
                    Dim FreeResponseQuestionPage = CType(Page, FreeResponseQuestionPage)
                    FreeResponseQuestionPage.Question = ZiaFile.Search(datafile, "Page " & i & " Question")
                    FreeResponseQuestionPage.Hint = ZiaFile.Search(datafile, "Page " & i & " Hint")
                    FreeResponseQuestionPage.Display = FromCompatibleDisplay(ZiaFile.Search(datafile, "Page " & i & " Display"))
                    FreeResponseQuestionPage.CorrectAnswers = ZiaFile.Search(datafile, "Page " & i & " CorrectAnswers").Split({"|"}, StringSplitOptions.RemoveEmptyEntries).ToList
                ElseIf PageType = Thorn.PageType.MultipleChoice Then
                    Dim MultipleChoiceQuestionPage = CType(Page, MultipleChoiceQuestionPage)
                    MultipleChoiceQuestionPage.Question = ZiaFile.Search(datafile, "Page " & i & " Question")
                    MultipleChoiceQuestionPage.Hint = ZiaFile.Search(datafile, "Page " & i & " Hint")
                    MultipleChoiceQuestionPage.Display = FromCompatibleDisplay(ZiaFile.Search(datafile, "Page " & i & " Display"))
                    MultipleChoiceQuestionPage.CorrectAnswer = ZiaFile.Search(datafile, "Page " & i & " CorrectAnswer")
                    MultipleChoiceQuestionPage.AnswerChoices = ZiaFile.Search(datafile, "Page " & i & " AnswerChoices").Split({"|"}, StringSplitOptions.RemoveEmptyEntries).ToList
                End If
            End If
        Next
        zip.Dispose()
        Return newthornfile
    End Function

    Public Function ToCompatibleMedia(ByVal Source As MediaFile, ByVal MediaFileName As String) As String
        On Error Resume Next
        File.WriteAllBytes(resourcesfolder & MediaFileName, Source.Bytes)
        Return (String.Format("{0},{1}", Source.Title, MediaFileName))
    End Function

    Public Function FromCompatibleMedia(ByVal Source As String) As MediaFile
        On Error Resume Next
        Dim Title As String = Source.Split(",").GetValue(0)
        Dim Data As String = Source.Split(",").GetValue(1)
        Dim newmediafile As New MediaFile
        newmediafile.Title = Title
        newmediafile.Bytes = File.ReadAllBytes(resourcesfolder & Data)
        newmediafile.FileExt = Data.Split(".").GetValue(1)
        Return newmediafile
    End Function

    Public Function ToCompatibleDisplay(ByVal Source As Display, ByVal FileName As String) As String
        On Error Resume Next
        If Source.Type = DisplayType.None Then
            Return "0"
        ElseIf Source.Type = DisplayType.Image Then
            Dim ImageDir = resourcesfolder & FileName
            Source.Image.Save(ImageDir)
            Return (String.Format("{0}|{1}", CInt(Source.Type), FileName))
        ElseIf Source.Type = DisplayType.Text Then
            Return (String.Format("{0}|{1}", CInt(Source.Type), ToCompatible(Source.Text)))
        ElseIf Source.Type = DisplayType.WebBrowser Then
            Return (String.Format("{0}|{1}", CInt(Source.Type), Source.Url))
        ElseIf Source.Type = DisplayType.Media Then
            Return (String.Format("{0}|{1}", CInt(Source.Type), ToCompatibleMedia(Source.Media, FileName & "." & Source.Media.FileExt)))
        End If
    End Function
    Public Function FromCompatibleDisplay(ByVal Source As String) As Display
        On Error Resume Next
        Dim Type As DisplayType = CInt(Source.Split("|").GetValue(0))
        Dim Data As String = Source.Split("|").GetValue(1)
        Dim Disp As New Display
        Disp.Type = Type
        If Type = DisplayType.None Then
        ElseIf Type = DisplayType.Image Then
            Disp.Image = Image.FromFile(resourcesfolder & Data)
        ElseIf Type = DisplayType.Text Then
            Disp.Text = Data
        ElseIf Type = DisplayType.WebBrowser Then
            Disp.Url = Data
        ElseIf Type = DisplayType.Media Then
            Disp.Media = FromCompatibleMedia(Source)
        End If
        Return Disp
    End Function
End Module