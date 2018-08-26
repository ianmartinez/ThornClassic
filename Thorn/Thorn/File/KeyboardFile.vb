Imports System.Net.Mail
Imports System.Net
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.CodeDom.Compiler
Imports System.Resources
Imports Tundra.ZiaFile

<Serializable()>
Public Class KeyboardFile
    Public Keyboard As New Dictionary(Of String, String)

    Public Sub Save(ByVal FilePath As String)
        KeyboardFileAccess.Save(FilePath, Me)
    End Sub

    Public Sub Open(ByVal FilePath)
        Dim NewKeyboardFile As KeyboardFile = KeyboardFileAccess.Open(FilePath)
        Me.Keyboard = NewKeyboardFile.Keyboard
    End Sub

    Public Sub New()
    End Sub
End Class

Module KeyboardFileAccess
    Sub Save(ByVal FilePath As String, ByVal KeyboardFile As KeyboardFile)
        Dim ValueCollection As New List(Of ZiaLine)
        ValueCollection.Add(New ZiaLine(LineType.KeyValue, "Thorn", My.Application.Info.Version.ToString))
        For Each Key As KeyValuePair(Of String, String) In KeyboardFile.Keyboard
            ValueCollection.Add(New ZiaLine(LineType.KeyValue, Key.Key, Key.Value))
        Next
        System.IO.File.WriteAllText(FilePath, Write(ValueCollection))
    End Sub

    Public Function Open(ByVal FilePath As String) As KeyboardFile
        Dim Source As String = System.IO.File.ReadAllText(FilePath, System.Text.Encoding.UTF8)
        If Source = Nothing Then Return Nothing
        Dim Data = Read(Source)
        Dim KeyboardFile As New KeyboardFile
        For Each Key As KeyValuePair(Of String, String) In Data
            If Key.Key = "Thorn" Then Continue For
            KeyboardFile.Keyboard.Add(Key.Key, Key.Value)
        Next
        Return KeyboardFile
    End Function
End Module

