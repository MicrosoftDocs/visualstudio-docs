    <ProvideLanguageCodeExpansion(
    SnippetUtilities.LanguageServiceGuidStr,
    "TestSnippets",
    0,
    "TestSnippets",
    "%InstallRoot%\TestSnippets\Snippets\%LCID%\SnippetsIndex.xml",
    SearchPaths:="%InstallRoot%\TestSnippets\Snippets\%LCID%\",
    ForceCreateDirs:="%InstallRoot%\TestSnippets\Snippets\%LCID%\")>
    Friend Class TestCompletionCommandHandler
        Implements IOleCommandTarget
        Implements IVsExpansionClient