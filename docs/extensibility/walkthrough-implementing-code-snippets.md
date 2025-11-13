---
title: 'Walkthrough: Implementing Code Snippets'
description: You can create code snippets and include them in an editor extension. Learn how to create/register code snippets by using this walkthrough.
ms.date: 11/04/2016
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
dev_langs:
- CSharp
- VB
---
# Walkthrough: Implement code snippets

You can create code snippets and include them in an editor extension so that users of the extension can add them to their own code.

 A code snippet is a fragment of code or other text that can be incorporated in a file. To view all snippets that have been registered for particular programming languages, on the **Tools** menu, click **Code Snippet Manager**. To insert a snippet in a file, right-click where you want the snippet, click Insert Snippet, or **Surround With**, locate the snippet you want, and then double-click it. Press **Tab** or **Shift**+**Tab** to modify the relevant parts of the snippet and then press **Enter** or **Esc** to accept it. For more information, see [Code snippets](../ide/code-snippets.md).

 A code snippet is contained in an XML file that has the .snippet* file name extension. A snippet can contain fields that are highlighted after the snippet is inserted so that the user can find and change them. A snippet file also provides information for the **Code Snippet Manager** so that it can display the snippet name in the correct category. For information about the snippet schema, see [Code snippets schema reference](../ide/code-snippets-schema-reference.md).

 This walkthrough teaches how to accomplish these tasks:

1. Create and register code snippets for a specific language.

2. Add the **Insert Snippet** command to a shortcut menu.

3. Implement snippet expansion.

   This walkthrough is based on [Walkthrough: Display statement completion](../extensibility/walkthrough-displaying-statement-completion.md).

## Create and register code snippets
 Typically, code snippets are associated with a registered language service. However, you do not have to implement a <xref:Microsoft.VisualStudio.Package.LanguageService> to register code snippets. Instead, just specify a GUID in the snippet index file and then use the same GUID in the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageCodeExpansionAttribute> that you add to your project.

 The following steps demonstrate how to create code snippets and associate them with a specific GUID.

1. Create the following directory structure:

    **%InstallDir%\TestSnippets\Snippets\1033\\**

    where *%InstallDir%* is the Visual Studio installation folder. (Although this path is typically used to install code snippets, you can specify any path.)

2. In the \1033\ folder, create an *.xml* file and name it **TestSnippets.xml**. (Although this name is typically used for a snippet index file, you can specify any name as long as it has an *.xml* file name extension.) Add the following text, and then delete the placeholder GUID and add your own.

   ```xml
   <?xml version="1.0" encoding="utf-8" ?>
   <SnippetCollection>
       <Language Lang="TestSnippets" Guid="{00000000-0000-0000-0000-000000000000}">
           <SnippetDir>
               <OnOff>On</OnOff>
               <Installed>true</Installed>
               <Locale>1033</Locale>
               <DirPath>%InstallRoot%\TestSnippets\Snippets\%LCID%\</DirPath>
               <LocalizedName>Snippets</LocalizedName>
           </SnippetDir>
       </Language>
   </SnippetCollection>
   ```

3. Create a file in the snippet folder, name it **test**`.snippet`, and then add the following text:

   ```xml
   <?xml version="1.0" encoding="utf-8" ?>
   <CodeSnippets  xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
       <CodeSnippet Format="1.0.0">
           <Header>
               <Title>Test replacement fields</Title>
               <Shortcut>test</Shortcut>
               <Description>Code snippet for testing replacement fields</Description>
               <Author>MSIT</Author>
               <SnippetTypes>
                   <SnippetType>Expansion</SnippetType>
               </SnippetTypes>
           </Header>
           <Snippet>
               <Declarations>
                   <Literal>
                     <ID>param1</ID>
                       <ToolTip>First field</ToolTip>
                       <Default>first</Default>
                   </Literal>
                   <Literal>
                       <ID>param2</ID>
                       <ToolTip>Second field</ToolTip>
                       <Default>second</Default>
                   </Literal>
               </Declarations>
               <References>
                  <Reference>
                      <Assembly>System.Windows.Forms.dll</Assembly>
                  </Reference>
               </References>
               <Code Language="TestSnippets">
                   <![CDATA[MessageBox.Show("$param1$");
        MessageBox.Show("$param2$");]]>
               </Code>
           </Snippet>
       </CodeSnippet>
   </CodeSnippets>
   ```

   The following steps show how to register the code snippets.

### To register code snippets for a specific GUID

1. Open the **CompletionTest** project. For information about how to create this project, see [Walkthrough: Display statement completion](../extensibility/walkthrough-displaying-statement-completion.md).

2. In the project, add references to the following assemblies:

    - Microsoft.VisualStudio.TextManager.Interop

    - Microsoft.VisualStudio.TextManager.Interop.8.0

    - microsoft.msxml

3. In the project, open the **source.extension.vsixmanifest** file.

4. Make sure that the **Assets** tab contains a **VsPackage** content type and that **Project** is set to the name of the project.

5. Select the CompletionTest project and in the Properties window set **Generate Pkgdef File** to **true**. Save the project.

6. Add a static `SnippetUtilities` class to the project.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet22":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet22":::
     ---

7. In the SnippetUtilities class, define a GUID and give it the value that you used in the *SnippetsIndex.xml* file.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet23":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet23":::
     ---

8. Add the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageCodeExpansionAttribute> to the `TestCompletionHandler` class. This attribute can be added to any public or internal (non-static) class in the project. (You may have to add a `using` directive for the Microsoft.VisualStudio.Shell namespace.)

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet24":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet24":::
     ---

9. Build and run the project. In the experimental instance of Visual Studio that starts when the project is run, the snippet you just registered should be displayed in the **Code Snippets Manager** under the **TestSnippets** language.

## Add the Insert Snippet command to the shortcut menu
 The **Insert Snippet** command is not included on the shortcut menu for a text file. Therefore, you must enable the command.

#### To add the Insert Snippet command to the shortcut menu

1. Open the `TestCompletionCommandHandler` class file.

     Because this class implements <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>, you can activate the **Insert Snippet** command in the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method. Before you enable the command, check that this method is not being called inside an automation function because when the **Insert Snippet** command is clicked, it displays the snippet picker user interface (UI).

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet25":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet25":::
     ---

2. Build and run the project. In the experimental instance, open a file that has the *.zzz* file name extension and then right-click anywhere in it. The **Insert Snippet** command should appear on the shortcut menu.

## Implement snippet expansion in the Snippet Picker UI
 This section shows how to implement code snippet expansion so that the snippet picker UI is displayed when **Insert Snippet** is clicked on the shortcut menu. A code snippet is also expanded when a user types the code-snippet shortcut and then presses **Tab**.

 To display the snippet picker UI and to enable navigation and post-insertion snippet acceptance, use the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A> method. The insertion itself is handled by the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient.OnItemChosen%2A> method.

 The implementation of code snippet expansion uses legacy <xref:Microsoft.VisualStudio.TextManager.Interop> interfaces. When you translate from the current editor classes to the legacy code, remember that the legacy interfaces use a combination of line numbers and column numbers to specify locations in a text buffer, but the current classes use one index. Therefore, if a buffer has three lines each of which has 10 characters (plus a newline, which counts as one character), the fourth character on the third line is at position 27 in the current implementation, but it is at line 2, position 3 in the old implementation.

#### To implement snippet expansion

1. To the file that contains the `TestCompletionCommandHandler` class, add the following `using` directives.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet26":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet26":::
     ---

2. Make the `TestCompletionCommandHandler` class implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient> interface.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet27":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet27":::
     ---

3. In the `TestCompletionCommandHandlerProvider` class, import the <xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService>.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs" id="Snippet28":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb" id="Snippet28":::
     ---

4. Add some private fields for the code expansion interfaces and the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView>.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet29":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet29":::
     ---

5. In the constructor of the `TestCompletionCommandHandler` class, set the following fields.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet30":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet30":::
     ---

6. To display the snippet picker when the user clicks the **Insert Snippet** command, add the following code to the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A> method. (To make this explanation more readable, the `Exec()`code that's used for statement completion is not shown; instead, blocks of code are added to the existing method.) Add the following block of code after the code that checks for a character.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet31":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet31":::
     ---

7. If a snippet has fields that can be navigated, the expansion session is kept open until the expansion is explicitly accepted; if the snippet has no fields, the session is closed and is returned as `null` by the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionManager.InvokeInsertionUI%2A> method. In the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A> method, after the snippet picker UI code that you added in the previous step, add the following code to handle snippet navigation (when the user presses **Tab** or **Shift**+**Tab** after snippet insertion).

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet32":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet32":::
     ---

8. To insert the code snippet when the user types the corresponding shortcut and then presses **Tab**, add code to the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A> method. The private method that inserts the snippet will be shown in a later step. Add the following code after the navigation code that you added in the previous step.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet33":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet33":::
     ---

9. Implement the methods of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient> interface. In this implementation, the only methods of interest are <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient.EndExpansion%2A> and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient.OnItemChosen%2A>. The other methods should just return <xref:Microsoft.VisualStudio.VSConstants.S_OK>.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet34":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet34":::
     ---

10. Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionClient.OnItemChosen%2A> method. The helper method that actually inserts the expansions is covered in a later step. The <xref:Microsoft.VisualStudio.TextManager.Interop.TextSpan> provides line and column information, which you can get from the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView>.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet35":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet35":::
     ---

11. The following private method inserts a code snippet, based either on the shortcut or on the title and path. It then calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansion.InsertNamedExpansion%2A> method with the snippet.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/snippetutilities.cs" id="Snippet36":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/snippetutilities.vb" id="Snippet36":::
     ---

## Build and test code snippet expansion
 You can test whether snippet expansion works in your project.

1. Build the solution. When you run this project in the debugger, a second instance of Visual Studio is started.

2. Open a text file and type some text.

3. Right-click somewhere in the text and then click **Insert Snippet**.

4. The snippet picker UI should appear with a pop-up that says **Test replacement fields**. Double-click the pop-up.

     The following snippet should be inserted.

    ```
    MessageBox.Show("first");
    MessageBox.Show("second");
    ```

     Don't press **Enter** or **Esc**.

5. Press **Tab** and **Shift**+**Tab** to toggle between "first" and "second".

6. Accept the insertion by pressing either **Enter** or **Esc**.

7. In a different part of the text, type "test" and then press **Tab**. Because "test" is the code-snippet shortcut, the snippet should be inserted again.
