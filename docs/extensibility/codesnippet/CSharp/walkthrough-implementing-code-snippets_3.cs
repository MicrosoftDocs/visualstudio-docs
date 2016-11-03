    [ProvideLanguageCodeExpansion(
    SnippetUtilities.LanguageServiceGuidStr,
    "TestSnippets", //the language name
    0,              //the resource id of the language
    "TestSnippets", //the language ID used in the .snippet files
    @"%InstallRoot%\TestSnippets\Snippets\%LCID%\TestSnippets.xml",
        //the path of the index file
    SearchPaths = @"%InstallRoot%\TestSnippets\Snippets\%LCID%\",
    ForceCreateDirs = @"%InstallRoot%\TestSnippets\Snippets\%LCID%\")]
    internal class TestCompletionCommandHandler : IOleCommandTarget