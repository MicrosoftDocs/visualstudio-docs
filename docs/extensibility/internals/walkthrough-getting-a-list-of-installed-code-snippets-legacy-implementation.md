---
title: Getting a List of Installed Code Snippets (Legacy) | Microsoft Docs
description: Learn how to get all code snippets for a specific language GUID. The shortcuts for those snippets can be inserted into an IntelliSense completion list.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- snippets, retrieving list
- code snippets, retrieving list
- GetSnippets method
ms.assetid: 7d142f8b-35b1-44c4-a13e-f89f6460c906
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Walkthrough: Getting a List of Installed Code Snippets (Legacy Implementation)
A code snippet is a piece of code that can be inserted into the source buffer either with a menu command (which allows choosing among a list of installed code snippets) or by selecting a snippet shortcut from an IntelliSense completion list.

 The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionManager.EnumerateExpansions%2A> method gets all code snippets for a specific language GUID. The shortcuts for those snippets can be inserted into an IntelliSense completion list.

 See [Support for Code Snippets in a Legacy Language Service](../../extensibility/internals/support-for-code-snippets-in-a-legacy-language-service.md) for details about implementing code snippets in a managed package framework (MPF) language service.

### To retrieve a list of code snippets

1. The following code shows how to get a list of code snippets for a given language. The results are stored in an array of <xref:Microsoft.VisualStudio.TextManager.Interop.VsExpansion> structures. This method uses the static <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> method to get the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> interface from the <xref:Microsoft.VisualStudio.TextManager.Interop.SVsTextManager> service. However, you can also use the service provider given to your VSPackage and call the <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider.QueryService%2A> method.

    ```csharp
    using System;
    using System.Collections;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Package;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.TextManager.Interop;

    [Guid("00000000-0000-0000-0000-000000000000")] //create a new GUID for the language service
    namespace TestLanguage
    {
        class TestLanguageService : LanguageService
        {
            private void GetSnippets(Guid languageGuid,
                                     ref ArrayList expansionsList)
            {
                IVsTextManager textManager = (IVsTextManager)Package.GetGlobalService(typeof(SVsTextManager));
                if (textManager != null)
                {
                    IVsTextManager2 textManager2 = (IVsTextManager2)textManager;
                    if (textManager2 != null)
                    {
                        IVsExpansionManager expansionManager = null;
                        textManager2.GetExpansionManager(out expansionManager);
                        if (expansionManager != null)
                        {
                            // Tell the environment to fetch all of our snippets.
                            IVsExpansionEnumeration expansionEnumerator = null;
                            expansionManager.EnumerateExpansions(languageGuid,
                            0,     // return all info
                            null,    // return all types
                            0,     // return all types
                            1,     // include snippets without types
                            0,     // do not include duplicates
                            out expansionEnumerator);
                            if (expansionEnumerator != null)
                            {
                                // Cache our expansions in a VsExpansion array
                                uint count   = 0;
                                uint fetched = 0;
                                VsExpansion expansionInfo = new VsExpansion();
                                IntPtr[] pExpansionInfo   = new IntPtr[1];

                                // Allocate enough memory for one VSExpansion structure. This memory is filled in by the Next method.
                                pExpansionInfo[0] = Marshal.AllocCoTaskMem(Marshal.SizeOf(expansionInfo));

                                expansionEnumerator.GetCount(out count);
                                for (uint i = 0; i < count; i++)
                                {
                                    expansionEnumerator.Next(1, pExpansionInfo, out fetched);
                                    if (fetched > 0)
                                    {
                                        // Convert the returned blob of data into a structure that can be read in managed code.
                                        expansionInfo = (VsExpansion)Marshal.PtrToStructure(pExpansionInfo[0], typeof(VsExpansion));

                                        if (!String.IsNullOrEmpty(expansionInfo.shortcut))
                                        {
                                            expansionsList.Add(expansionInfo);
                                        }
                                    }
                                }
                                Marshal.FreeCoTaskMem(pExpansionInfo[0]);
                            }
                        }
                    }
                }
            }
        }
    }
    ```

### To call the GetSnippets method

1. The following method shows how to call the `GetSnippets` method at the completion of a parsing operation. The <xref:Microsoft.VisualStudio.Package.LanguageService.OnParseComplete%2A> method is called after a parsing operation that was started with the reason <xref:Microsoft.VisualStudio.Package.ParseReason>.

> [!NOTE]
> The `expansionsList` array list is cached for performance reasons. Changes to the snippets are not reflected in the list until the language service is stopped and reloaded (for example, by stopping and restarting [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]).

```csharp
class TestLanguageService : LanguageService
{
    private ArrayList expansionsList;

    public override void OnParseComplete(ParseRequest req)
    {
        if (this.expansionsList == null)
        {
            this.expansionsList = new ArrayList();
            GetSnippets(this.GetLanguageServiceGuid(),
                ref this.expansionsList);
        }
    }
}
```

### To use the snippet information

1. The following code shows how to use the snippet information returned by the `GetSnippets` method. The `AddSnippets` method is called from the parser in response to any parse reason that is used to populate a list of code snippets. This should take place after the full parse has been done for the first time.

     The `AddDeclaration` method builds a list of declarations that is later displayed in a completion list.

     The `TestDeclaration` class contains all the information that can be displayed in a completion list as well as the type of declaration.

    ```csharp
    class TestAuthoringScope : AuthoringScope
    {
        public void AddDeclarations(TestDeclaration declaration)
        {
            if (m_declarations == null)
                m_declarations = new List<TestDeclaration>();
            m_declarations.Add(declaration);
         }
    }
    class TestDeclaration
    {
        private string m_name;
        private string m_description;
        private string m_type;

        public TestDeclaration(string name, string desc, string type)
        {
            m_name = name;
            m_description = desc;
            m_type = type;
        }

    class TestLanguageService : LanguageService
    {
        internal void AddSnippets(ref TestAuthoringScope scope)
        {
            if (this.expansionsList != null && this.expansionsList.Count > 0)
            {
                int count = this.expansionsList.Count;
                for (int i = 0; i < count; i++)
                {
                    VsExpansion expansionInfo = (VsExpansion)this.expansionsList[i];
                    scope.AddDeclaration(new TestDeclaration(expansionInfo.title,
                         expansionInfo.description,
                         "snippet"));
                }
            }
        }
    }

    ```

## See also
- [Support for Code Snippets in a Legacy Language Service](../../extensibility/internals/support-for-code-snippets-in-a-legacy-language-service.md)
