Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports UtilityLibraries

Namespace StringLibraryTests
    <TestClass>
    Public Class UnitTest1
        <TestMethod>
        Sub TestStartsWithUpper()
            ' Tests that we expect to return true.
            Dim words() As String = {"Alphabet", "Zebra", "ABC", "Αθήνα", "Москва"}
            For Each word In words
                Dim result As Boolean = word.StartsWithUpper()
                Assert.IsTrue(result,
                              $"Expected for '{word}': true; Actual: {result}")
            Next
        End Sub

        <TestMethod>
        Sub TestDoesNotStartWithUpper()
            ' Tests that we expect to return false.
            Dim words() As String = {"alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " "}
            For Each word In words
                Dim result As Boolean = word.StartsWithUpper()
                Assert.IsFalse(result,
                               $"Expected for '{word}': false; Actual: {result}")
            Next
        End Sub

        <TestMethod>
        Sub DirectCallWithNullOrEmpty()
            ' Tests that we expect to return false.
            Dim words() As String = {String.Empty, Nothing}
            For Each word In words
                Dim result As Boolean = StringLibrary.StartsWithUpper(word)
                Assert.IsFalse(result,
                               $"Expected for '{If(word Is Nothing, " < null > ", word)}': " +
                               $"false; Actual: {result}")

                'result = StringLibrary.StartsWithLower(word)
                'Assert.IsFalse(result,
                '               $"Expected for {If(word Is Nothing, " < null > ", word)}': " +
                '               $"false; Actual: {result}")
            Next
        End Sub

        '<TestMethod>
        'Sub TestStartsWithLower()
        '    ' Tests that we expect to return true.
        '    Dim words() As String = {"alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство"}
        '    For Each word In words
        '        Dim result As Boolean = word.StartsWithLower()
        '        Assert.IsTrue(result,
        '                      $"Expected for '{word}': true; Actual: {result}")
        '    Next
        'End Sub

        '<TestMethod>
        'Public Sub TestDoesNotStartWithLower()
        '    ' Tests that we expect to return false.
        '    Dim words() As String = {"Alphabet", "Zebra", "ABC", "Αθήνα", "Москва",
        '                       "1234", ".", ";", " "}
        '    For Each word In words
        '        Dim result As Boolean = word.StartsWithLower()
        '        Assert.IsFalse(result,
        '                       $"Expected for '{word}': false; Actual: {result}")
        '    Next
        'End Sub

        '<TestMethod>
        'Public Sub TestHasEmbeddedSpaces()
        '    ' Tests that we expect to return true.
        '    Dim phrases() As String = {"one car", "Name" + vbTab + "Description",
        '                               "Line1" + vbCrLf + "Line2", "Line3" + vbLf + "Line4",
        '                               "Line5" + ChrW(&HB) + "Line6", "Line7" + ChrW(&HC) + "Line8",
        '                               "Line0009" + vbCr + "Line10", "word1" + ChrW(&HA0) + "word2"}
        '    For Each phrase In phrases
        '        Dim result As Boolean = phrase.HasEmbeddedSpaces()
        '        Assert.IsTrue(result,
        '                      $"Expected for '{phrase}': true; Actual: {result}")
        '    Next
        'End Sub
    End Class
End Namespace

