---
title: "Support for Code Snippets in a Legacy Language Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "snippets, supporting in language services"
  - "code snippets, supporting in language services [managed package framework]"
  - "language services [managed package framework], supporting code snippets"
ms.assetid: 7490325b-acee-4c2d-ac56-1cd5db1a1083
caps.latest.revision: 29
ms.author: gregvanl
manager: jillfra
---
# Support for Code Snippets in a Legacy Language Service
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A code snippet is a piece of code that is inserted into the source file. The snippet itself is an XML-based template with a set of fields. These fields are highlighted after the snippet is inserted and can have different values depending on the context in which the snippet is inserted. Immediately after the snippet is inserted, the language service can format the snippet.  
  
 The snippet is inserted in a special edit mode that allows the fields of the snippet to be navigated by using the TAB key. The fields can support IntelliSense-style drop-down menus. The user commits the snippet to the source file by typing either the ENTER or the ESC key. To learn more about snippets, please see [Code Snippets](../../ide/code-snippets.md).  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more, see [Walkthrough: Implementing Code Snippets](../../extensibility/walkthrough-implementing-code-snippets.md).  
  
> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.  
  
## Managed Package Framework Support for Code Snippets  
 The managed package framework (MPF) supports most snippet functionality, from reading the template to inserting the snippet and enabling the special edit mode. Support is managed through the <xref:Microsoft.VisualStudio.Package.ExpansionProvider> class.  
  
 When the <xref:Microsoft.VisualStudio.Package.Source> class is instantiated, the <xref:Microsoft.VisualStudio.Package.LanguageService.CreateExpansionProvider%2A> method in the <xref:Microsoft.VisualStudio.Package.LanguageService> class is called to obtain an <xref:Microsoft.VisualStudio.Package.ExpansionProvider> object (note that the base <xref:Microsoft.VisualStudio.Package.LanguageService> class always returns a new <xref:Microsoft.VisualStudio.Package.ExpansionProvider> object for each <xref:Microsoft.VisualStudio.Package.Source> object).  
  
 The MPF does not support expansion functions. An expansion function is a named function that is embedded in a snippet template and returns one or more values to be placed in a field. The values are returned by the language service itself through an <xref:Microsoft.VisualStudio.Package.ExpansionFunction> object. The <xref:Microsoft.VisualStudio.Package.ExpansionFunction> object must be implemented by the language service to support expansion functions.  
  
## Providing Support for Code Snippets  
 To enable support for code snippets, you must provide or install the snippets and you must provide the means for the user to insert those snippets. There are three steps to enabling support for code snippets:  
  
1. Installing the snippet files.  
  
2. Enabling code snippets for your language service.  
  
3. Invoking the <xref:Microsoft.VisualStudio.Package.ExpansionProvider> object.  
  
### Installing the Snippet Files  
 All snippets for a language are stored as templates in XML files, typically one snippet template per file. For details on the XML schema used for code snippet templates, see [Code Snippets Schema Reference](../../ide/code-snippets-schema-reference.md). Each snippet template is identified with a language ID. This language ID is specified in the registry and is put into the `Language` attribute of the \<Code> tag in the template.  
  
 There are typically two locations where snippet template files are stored: 1) where your language was installed and 2) in the user's folder. These locations are added to the registry so that the Visual Studio **Code Snippets Manager** can find the snippets. The user's folder is where snippets created by the user are stored.  
  
 The typical folder layout for the installed snippet template files looks like this: *[InstallRoot]*\\*[TestLanguage]*\Snippets\\*[LCID]*\Snippets.  
  
 *[InstallRoot]* is the folder your language is installed in.  
  
 *[TestLanguage]* is the name of your language as a folder name.  
  
 *[LCID]* is the locale ID. This is how localized versions of your snippets are stored. For example, the locale ID for English is 1033, so *[LCID]* is replaced by 1033.  
  
 One additional file must be supplied and that is an index file, typically called SnippetsIndex.xml or ExpansionsIndex.xml (you can use any valid filename ending in .xml). This file is typically stored in the *[InstallRoot]*\\*[TestLanguage]* folder and specifies the exact location of the snippets folder as well as the language ID and GUID of the language service that uses the snippets. The exact path of the index file is put into the registry as described later in "Installing the Registry Entries". Here is an example of a SnippetsIndex.xml file:  
  
```  
<?xml version="1.0" encoding="utf-8" ?>  
<SnippetCollection>  
    <Language Lang="Testlanguage" Guid="{b614a40a-80d9-4fac-a6ad-fc2868fff7cd}">  
        <SnippetDir>  
            <OnOff>On</OnOff>  
            <Installed>true</Installed>  
            <Locale>1033</Locale>  
            <DirPath>%InstallRoot%\TestLanguage\Snippets\%LCID%\Snippets\</DirPath>  
            <LocalizedName>Snippets</LocalizedName>  
        </SnippetDir>  
    </Language>  
</SnippetCollection>  
```  
  
 The \<Language> tag specifies the language ID (the `Lang` attribute) and the language service GUID.  
  
 This example assumes you have installed your language service in the Visual Studio installation folder. The %LCID% is replaced with the user's current locale ID. Multiple \<SnippetDir> tags can be added, one for each different directory and locale. In addition, a snippet folder can contain subfolders, each of which is identified in the index file with the \<SnippetSubDir> tag that is embedded in a \<SnippetDir> tag.  
  
 Users can also create their own snippets for your language. These are typically stored in the user's settings folder, for example *[TestDocs]*\Code Snippets\\*[TestLanguage]*\Test Code Snippets, where *[TestDocs]* is the location of the user's settings folder for Visual Studio.  
  
 The following substitution elements can be placed in the path stored in the \<DirPath> tag in the index file.  
  
|Element|Description|  
|-------------|-----------------|  
|%LCID%|Locale ID.|  
|%InstallRoot%|Root installation folder for Visual Studio, for example, C:\Program Files\Microsoft Visual Studio 8.|  
|%ProjDir%|Folder containing the current project.|  
|%ProjItem%|Folder containing the current project item.|  
|%TestDocs%|Folder in the user's settings folder, for example, C:\Documents and Settings\\*[username]*\My Documents\Visual Studio\8.|  
  
### Enabling Code Snippets for Your Language Service  
 You can enable code snippets for your language service by adding the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageCodeExpansionAttribute> attribute to your VSPackage (see [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md) for details). The <xref:Microsoft.VisualStudio.Shell.ProvideLanguageCodeExpansionAttribute.ShowRoots%2A> and <xref:Microsoft.VisualStudio.Shell.ProvideLanguageCodeExpansionAttribute.SearchPaths%2A> parameters are optional, but you should include the `SearchPaths` named parameter in order to inform the **Code Snippets Manager** of the location of your snippets.  
  
 The following is an example of how to use this attribute:  
  
```  
[ProvideLanguageCodeExpansion(  
         typeof(TestSnippetLanguageService),  
         "Test Snippet Language",          // Name of language used as registry key  
         0,                               // Resource ID of localized name of language service  
         "Test Snippet Language",        // Name of Language attribute in snippet template  
         @"%InstallRoot%\Test Snippet Language\Snippets\%LCID%\SnippetsIndex.xml",  // Path to snippets index  
         SearchPaths = @"%InstallRoot%\Test Snippet Language\Snippets\%LCID%\")]    // Path to snippets  
```  
  
### Calling the Expansion Provider  
 The language service controls the insertion of any code snippet, as well as the way insertion is invoked.  
  
## Calling the Expansion Provider for Code Snippets  
 There are two ways to invoke the expansion provider: by using a menu command or by using a shortcut from a completion list.  
  
### Inserting a Code Snippet by using a Menu Command  
 To use a menu command to display the snippet browser, you add a menu command and then call the <xref:Microsoft.VisualStudio.Package.ExpansionProvider.DisplayExpansionBrowser%2A> method in the <xref:Microsoft.VisualStudio.Package.ExpansionProvider> interface in response to that menu command.  
  
1. Add a command and a button to your .vsct file. You can find instructions for doing so in [Walkthrough: Creating a Menu Command By Using the Visual Studio Package Template](https://msdn.microsoft.com/library/1985fa7d-aad4-4866-b356-a125b6a246de).  
  
2. Derive a class from the <xref:Microsoft.VisualStudio.Package.ViewFilter> class and override the <xref:Microsoft.VisualStudio.Package.ViewFilter.QueryCommandStatus%2A> method to indicate support for the new menu command. This example always enables the menu command.  
  
    ```csharp  
    using Microsoft.VisualStudio.Package;  
  
    namespace TestLanguagePackage  
    {  
        class TestViewFilter : ViewFilter  
        {  
            public TestViewFilter(CodeWindowManager mgr, IVsTextView view)  
                : base(mgr, view)  
            {  
            }  
  
            protected override int QueryCommandStatus(ref Guid guidCmdGroup,  
                                                      uint nCmdId)  
            {  
                int hr = base.QueryCommandStatus(ref guidCmdGroup, nCmdId);  
                // If the base class did not recognize the command then  
                // see if we can handle the command.  
                if (hr == (int)Microsoft.VisualStudio.OLE.Interop.Constants.OLECMDERR_E_UNKNOWNGROUP)  
                {  
                    if (guidCmdGroup == GuidList.guidTestLanguagePackageCmdSet)  
                    {  
                        if (nCmdId == PkgCmdIDList.InvokeCodeSnippetsBrowser)  
                        {  
                            hr = (int)(OLECMDF.OLECMDF_SUPPORTED | OLECMDF.OLECMDF_ENABLED);  
                        }  
                    }  
                }  
                return hr;  
            }  
        }  
    }  
    ```  
  
3. Override the <xref:Microsoft.VisualStudio.Package.ViewFilter.HandlePreExec%2A> method in the <xref:Microsoft.VisualStudio.Package.ViewFilter> class to obtain the <xref:Microsoft.VisualStudio.Package.ExpansionProvider> object and call the <xref:Microsoft.VisualStudio.Package.ExpansionProvider.DisplayExpansionBrowser%2A> method on that object.  
  
    ```csharp  
    using Microsoft.VisualStudio.Package;  
  
    namespace TestLanguagePackage  
    {  
        class TestViewFilter : ViewFilter  
        {  
            public override bool HandlePreExec(ref Guid guidCmdGroup,  
                                               uint nCmdId,  
                                               uint nCmdexecopt,  
                                               IntPtr pvaIn,  
                                               IntPtr pvaOut)  
            {  
                if (base.HandlePreExec(ref guidCmdGroup,  
                                       nCmdId,  
                                       nCmdexecopt,  
                                       pvaIn,  
                                       pvaOut))  
                {  
                    // Base class handled the command.  Do nothing more here.  
                    return true;  
                }  
  
                if (guidCmdGroup == GuidList.guidTestLanguagePackageCmdSet)  
                {  
                    if (nCmdId == PkgCmdIDList.InvokeCodeSnippetsBrowser)  
                    {  
                        ExpansionProvider ep = this.GetExpansionProvider();  
                        if (this.TextView != null && ep != null)  
                        {  
                            bool bDisplayed = ep.DisplayExpansionBrowser(  
                                this.TextView,  
                                "TestLanguagePackage Snippet:",  
                                null,  
                                false,  
                                null,  
                                false);  
                        }  
                        return true;   // Handled the command.  
                    }  
                }  
                return false;   // Did not handle the command.  
            }  
        }  
    }  
  
    ```  
  
     The following methods in the <xref:Microsoft.VisualStudio.Package.ExpansionProvider> class are called by Visual Studio in the given order during the process of inserting the snippet:  
  
4. <xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnItemChosen%2A>  
  
5. <xref:Microsoft.VisualStudio.Package.ExpansionProvider.IsValidKind%2A>  
  
6. <xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnBeforeInsertion%2A>  
  
7. <xref:Microsoft.VisualStudio.Package.ExpansionProvider.FormatSpan%2A>  
  
8. <xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnAfterInsertion%2A>  
  
     After the <xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnAfterInsertion%2A> method is called, the snippet has been inserted and the <xref:Microsoft.VisualStudio.Package.ExpansionProvider> object is in a special edit mode used for modifying a snippet that has just been inserted.  
  
### Inserting a code snippet by using a shortcut  
 Implementation of a shortcut from a completion list is much more involved than implementing a menu command. You must first add snippet shortcuts to the IntelliSense word completion list. Then you must detect when a snippet shortcut name has been inserted as a result of completion. Finally, you must obtain the snippet title and path using the shortcut name and pass that information to the <xref:Microsoft.VisualStudio.Package.ExpansionProvider.InsertNamedExpansion%2A> method on the <xref:Microsoft.VisualStudio.Package.ExpansionProvider> method.  
  
 To add snippet shortcuts to the word completion list, add them to the <xref:Microsoft.VisualStudio.Package.Declarations> object in your <xref:Microsoft.VisualStudio.Package.AuthoringScope> class. You must make sure you can identify the shortcut as a snippet name. For an example, see [Walkthrough: Getting a List of Installed Code Snippets (Legacy Implementation)](../../extensibility/internals/walkthrough-getting-a-list-of-installed-code-snippets-legacy-implementation.md).  
  
 You can detect the insertion of the code snippet shortcut in the <xref:Microsoft.VisualStudio.Package.Declarations.OnAutoComplete%2A> method of the <xref:Microsoft.VisualStudio.Package.Declarations> class. Because the snippet name has already been inserted into the source file, it must be removed when the expansion is inserted. The <xref:Microsoft.VisualStudio.Package.ExpansionProvider.InsertNamedExpansion%2A> method takes a span that describes the point of insertion for the snippet; if the span includes the entire snippet name in the source file, that name is replaced by the snippet.  
  
 Here is a version of a <xref:Microsoft.VisualStudio.Package.Declarations> class that handles snippet insertion given a shortcut name. Other methods in the <xref:Microsoft.VisualStudio.Package.Declarations> class have been omitted for clarity. Note that the constructor of this class takes a <xref:Microsoft.VisualStudio.Package.LanguageService> object. This can be passed in from your version of the <xref:Microsoft.VisualStudio.Package.AuthoringScope> object (for example, your implementation of the <xref:Microsoft.VisualStudio.Package.AuthoringScope> class might take the <xref:Microsoft.VisualStudio.Package.LanguageService> object in its constructor and pass that object on to your `TestDeclarations` class constructor).  
  
```  
[C#]  
using Microsoft.VisualStudio.Package;  
using Microsoft.VisualStudio.TextManager.Interop;  
  
namespace TestLanguagePackage  
{  
    internal class TestDeclarations : Declarations  
    {  
        private ArrayList       declarations;  
        private LanguageService languageService;  
        private TextSpan        commitSpan;  
  
        public TestDeclarations(LanguageService langService)  
            : base()  
        {  
            languageService = langService;  
            declarations = new ArrayList();  
        }  
  
        // This method is used to add declarations to the internal list.  
        public void AddDeclaration(TestDeclaration declaration)  
        {  
            declarations.Add(declaration);  
        }  
  
        // This method is called to get the string to commit to the source buffer.  
        // Note that the initial extent is only what the user has typed so far.  
        public override string OnCommit(IVsTextView textView,  
                                        string textSoFar,  
                                        char commitCharacter,  
                                        int index,  
                                        ref TextSpan initialExtent)  
        {  
            // We intercept this call only to get the initial extent  
            // of what was committed to the source buffer.  
            commitSpan = initialExtent;  
  
            return base.OnCommit(textView,  
                                 textSoFar,  
                                 commitCharacter,  
                                 index,  
                                 ref initialExtent);  
        }  
  
        // This method is called after the string has been committed to the source buffer.  
        public override char OnAutoComplete(IVsTextView textView,  
                                            string committedText,  
                                            char commitCharacter,  
                                            int index)  
        {  
            TestDeclaration item = declarations[index] as TestDeclaration;  
            if (item != null)  
            {  
                // In this example, TestDeclaration identifies types with a string.  
                // You can choose a different approach.  
                if (item.Type == "snippet")  
                {  
                    Source src = languageService.GetSource(textView);  
                    if (src != null)  
                    {  
                        ExpansionProvider ep = src.GetExpansionProvider();  
                        if (ep != null)  
                        {  
                            string title;  
                            string path;  
                            int commitLength = commitSpan.iEndIndex - commitSpan.iStartIndex;  
                            if (commitLength < committedText.Length)  
                            {  
                                // Replace everything that was inserted  
                                // so calculate the span of the full  
                                // insertion, taking into account what  
                                // was inserted when the commitSpan  
                                // was obtained in the first place.  
                                commitSpan.iEndIndex += (committedText.Length - commitLength);  
                            }  
  
                            if (ep.FindExpansionByShortcut(textView,  
                                                           committedText,  
                                                           commitSpan,  
                                                           true,  
                                                           out title,  
                                                           out path))  
                            {  
                                ep.InsertNamedExpansion(textView,  
                                                        title,  
                                                        path,  
                                                        commitSpan,  
                                                        false);  
                            }  
                        }  
                    }  
                }  
            }  
            return '\0';  
        }  
    }  
}  
```  
  
 When the language service gets the shortcut name, it calls the <xref:Microsoft.VisualStudio.Package.ExpansionProvider.FindExpansionByShortcut%2A> method to obtain the filename and code snippet title. The language service then calls the <xref:Microsoft.VisualStudio.Package.ExpansionProvider.InsertNamedExpansion%2A> method in the <xref:Microsoft.VisualStudio.Package.ExpansionProvider> class to insert the code snippet. The following methods are called by Visual Studio in the given order in the <xref:Microsoft.VisualStudio.Package.ExpansionProvider> class during the process of inserting the snippet:  
  
1. <xref:Microsoft.VisualStudio.Package.ExpansionProvider.IsValidKind%2A>  
  
2. <xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnBeforeInsertion%2A>  
  
3. <xref:Microsoft.VisualStudio.Package.ExpansionProvider.FormatSpan%2A>  
  
4. <xref:Microsoft.VisualStudio.Package.ExpansionProvider.OnAfterInsertion%2A>  
  
   For more information on getting a list of installed code snippets for your language service, see [Walkthrough: Getting a List of Installed Code Snippets (Legacy Implementation)](../../extensibility/internals/walkthrough-getting-a-list-of-installed-code-snippets-legacy-implementation.md).  
  
## Implementing the ExpansionFunction Class  
 An expansion function is a named function that is embedded in a snippet template and returns one or more values to be placed in a field. In order to support expansion functions in your language service, you must derive a class from the <xref:Microsoft.VisualStudio.Package.ExpansionFunction> class and implement the <xref:Microsoft.VisualStudio.Package.ExpansionFunction.GetCurrentValue%2A> method. You must then override the <xref:Microsoft.VisualStudio.Package.LanguageService.CreateExpansionFunction%2A> method in the <xref:Microsoft.VisualStudio.Package.LanguageService> class to return a new instantiation of your version of the <xref:Microsoft.VisualStudio.Package.ExpansionFunction> class for each expansion function you support. If you support a list of possible values from an expansion function, you must also override the <xref:Microsoft.VisualStudio.Package.ExpansionFunction.GetIntellisenseList%2A> method in the <xref:Microsoft.VisualStudio.Package.ExpansionFunction> class to return a list of those values.  
  
 An expansion function that takes arguments or needs to access other fields should not be associated with an editable field, as the expansion provider might not be fully initialized by the time the expansion function is called. As a result, the expansion function is not able to obtain the value of its arguments or any other field.  
  
### Example  
 Here is an example of how a simple expansion function called `GetName` might be implemented. This expansion function appends a number to a base class name each time the expansion function is instantiated (which corresponds to each time the associated code snippet is inserted).  
  
```csharp  
using Microsoft.VisualStudio.Package;  
  
namespace TestLanguagePackage  
{  
    public class TestLanguageService : LanguageService  
    {  
        private int classNameCounter = 0;  
  
        public override ExpansionFunction CreateExpansionFunction(  
            ExpansionProvider provider,  
            string functionName)  
        {  
            ExpansionFunction function = null;  
            if (functionName == "GetName")  
            {  
                ++classNameCounter;  
                function = new TestGetNameExpansionFunction(provider, classNameCounter);  
            }  
            return function;  
        }  
    }  
  
    internal class TestGetNameExpansionFunction : ExpansionFunction  
    {  
        private int nameCount;  
  
        TestGetNameExpansionFunction(ExpansionProvider provider, int counter)  
            : base(provider)  
        {  
            nameCount = counter;  
        }  
  
        public override string GetCurrentValue()  
        {  
            string name = "TestClass";  
            name += nameCount.ToString();  
            return name;  
        }  
    }  
}  
```  
  
## See Also  
 [Legacy Language Service Features](../../extensibility/internals/legacy-language-service-features1.md)   
 [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md)   
 [Code Snippets](../../ide/code-snippets.md)   
 [Walkthrough: Getting a List of Installed Code Snippets (Legacy Implementation)](../../extensibility/internals/walkthrough-getting-a-list-of-installed-code-snippets-legacy-implementation.md)
