---
title: "Walkthrough: Displaying Statement Completion | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], new - statement completion"
ms.assetid: f3152c4e-7673-4047-a079-2326941d1c83
caps.latest.revision: 37
ms.author: gregvanl
manager: jillfra
---
# Walkthrough: Displaying Statement Completion
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can implement language-based statement completion by defining the identifiers for which you want to provide completion and then triggering a completion session. You can define statement completion in the context of a language service, define your own file name extension and content type and then display completion for just that type, or you can trigger completion for an existing content type—for example, "plaintext". This walkthrough shows how to trigger statement completion for the "plaintext" content type, which is the content type of text files. The "text" content type is the ancestor of all other content types, including code and XML files.  
  
 Statement completion is typically triggered by typing certain characters—for example, by typing the beginning of an identifier such as "using". It is typically dismissed by pressing the Spacebar, Tab, or Enter key to commit a selection. You can implement the IntelliSense features that are triggered by typing a character by using a command handler for the keystrokes (the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface) and a handler provider that implements the <xref:Microsoft.VisualStudio.Editor.IVsTextViewCreationListener> interface. To create the completion source, which is the list of identifiers that participate in completion, implement the <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSource> interface and a completion source provider (the <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSourceProvider> interface). The providers are Managed Extensibility Framework (MEF) component parts. They are responsible for exporting the source and controller classes and importing services and brokers—for example, the <xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService>, which enables navigation in the text buffer, and the <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionBroker>, which triggers the completion session.  
  
 This walkthrough shows how to implement statement completion for a hard-coded set of identifiers. In full implementations, the language service and the language documentation are responsible for providing that content.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).  
  
## Creating a MEF Project  
  
#### To create a MEF project  
  
1. Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution `CompletionTest`.  
  
2. Add an Editor Classifier item template to the project. For more information, see [Creating an Extension with an Editor Item Template](../extensibility/creating-an-extension-with-an-editor-item-template.md).  
  
3. Delete the existing class files.  
  
4. Add the following references to the project and make sure that **CopyLocal** is set to `false`:  
  
     Microsoft.VisualStudio.Editor  
  
     Microsoft.VisualStudio.Language.Intellisense  
  
     Microsoft.VisualStudio.OLE.Interop  
  
     Microsoft.VisualStudio.Shell.14.0  
  
     Microsoft.VisualStudio.Shell.Immutable.10.0  
  
     Microsoft.VisualStudio.TextManager.Interop  
  
## Implementing the Completion Source  
 The completion source is responsible for collecting the set of identifiers and adding the content to the completion window when a user types a completion trigger, such as the first letters of an identifier. In this example, the identifiers and their descriptions are hard-coded in the <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSource.AugmentCompletionSession%2A> method. In most real-world uses, you would use your language’s parser to get the tokens to populate the completion list.  
  
#### To implement the completion source  
  
1. Add a class file and name it `TestCompletionSource`.  
  
2. Add these imports:  
  
     [!code-csharp[VSSDKCompletionTest#1](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletionsource.cs#1)]
     [!code-vb[VSSDKCompletionTest#1](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletionsource.vb#1)]  
  
3. Modify the class declaration for `TestCompletionSource` so that it implements <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSource>:  
  
     [!code-csharp[VSSDKCompletionTest#2](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletionsource.cs#2)]
     [!code-vb[VSSDKCompletionTest#2](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletionsource.vb#2)]  
  
4. Add private fields for the source provider, the text buffer, and a list of <xref:Microsoft.VisualStudio.Language.Intellisense.Completion> objects (which correspond to the identifiers that will participate in the completion session):  
  
     [!code-csharp[VSSDKCompletionTest#3](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletionsource.cs#3)]
     [!code-vb[VSSDKCompletionTest#3](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletionsource.vb#3)]  
  
5. Add a constructor that sets the source provider and buffer. The `TestCompletionSourceProvider` class is defined in later steps:  
  
     [!code-csharp[VSSDKCompletionTest#4](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletionsource.cs#4)]
     [!code-vb[VSSDKCompletionTest#4](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletionsource.vb#4)]  
  
6. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSource.AugmentCompletionSession%2A> method by adding a completion set that contains the completions you want to provide in the context. Each completion set contains a set of <xref:Microsoft.VisualStudio.Language.Intellisense.Completion> completions, and corresponds to a tab of the completion window. (In Visual Basic projects, the completion window tabs are named **Common** and **All**.) The FindTokenSpanAtPosition method is defined in the next step.  
  
     [!code-csharp[VSSDKCompletionTest#5](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletionsource.cs#5)]
     [!code-vb[VSSDKCompletionTest#5](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletionsource.vb#5)]  
  
7. The following method is used to find the current word from the position of the cursor:  
  
     [!code-csharp[VSSDKCompletionTest#6](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletionsource.cs#6)]
     [!code-vb[VSSDKCompletionTest#6](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletionsource.vb#6)]  
  
8. Implement the `Dispose()` method:  
  
     [!code-csharp[VSSDKCompletionTest#7](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletionsource.cs#7)]
     [!code-vb[VSSDKCompletionTest#7](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletionsource.vb#7)]  
  
## Implementing the Completion Source Provider  
 The completion source provider is the MEF component part that instantiates the completion source.  
  
#### To implement the completion source provider  
  
1. Add a class named `TestCompletionSourceProvider` that implements <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSourceProvider>. Export this class with a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "plaintext" and a <xref:Microsoft.VisualStudio.Utilities.NameAttribute> of "test completion".  
  
     [!code-csharp[VSSDKCompletionTest#8](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletionsource.cs#8)]
     [!code-vb[VSSDKCompletionTest#8](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletionsource.vb#8)]  
  
2. Import a <xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService>, which is used to find the current word in the completion source.  
  
     [!code-csharp[VSSDKCompletionTest#9](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletionsource.cs#9)]
     [!code-vb[VSSDKCompletionTest#9](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletionsource.vb#9)]  
  
3. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSourceProvider.TryCreateCompletionSource%2A> method to instantiate the completion source.  
  
     [!code-csharp[VSSDKCompletionTest#10](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletionsource.cs#10)]
     [!code-vb[VSSDKCompletionTest#10](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletionsource.vb#10)]  
  
## Implementing the Completion Command Handler Provider  
 The completion command handler provider is derived from a <xref:Microsoft.VisualStudio.Editor.IVsTextViewCreationListener>, which listens for a text view creation event and converts the view from an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView>—which enables the addition of the command to the command chain of the Visual Studio shell—to an <xref:Microsoft.VisualStudio.Text.Editor.ITextView>. Because this class is a MEF export, you can also use it to import the services that are required by the command handler itself.  
  
#### To implement the completion command handler provider  
  
1. Add a file named `TestCompletionCommandHandler`.  
  
2. Add these using statements:  
  
     [!code-csharp[VSSDKCompletionTest#11](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs#11)]
     [!code-vb[VSSDKCompletionTest#11](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb#11)]  
  
3. Add a class named `TestCompletionHandlerProvider` that implements <xref:Microsoft.VisualStudio.Editor.IVsTextViewCreationListener>. Export this class with a <xref:Microsoft.VisualStudio.Utilities.NameAttribute> of "token completion handler", a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "plaintext", and a <xref:Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute> of <xref:Microsoft.VisualStudio.Text.Editor.PredefinedTextViewRoles.Editable>.  
  
     [!code-csharp[VSSDKCompletionTest#12](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs#12)]
     [!code-vb[VSSDKCompletionTest#12](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb#12)]  
  
4. Import the <xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService>, which enables conversion from a <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> to a <xref:Microsoft.VisualStudio.Text.Editor.ITextView>, a <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionBroker>, and a <xref:Microsoft.VisualStudio.Shell.SVsServiceProvider> that enables access to standard Visual Studio services.  
  
     [!code-csharp[VSSDKCompletionTest#13](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs#13)]
     [!code-vb[VSSDKCompletionTest#13](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb#13)]  
  
5. Implement the <xref:Microsoft.VisualStudio.Editor.IVsTextViewCreationListener.VsTextViewCreated%2A> method to instantiate the command handler.  
  
     [!code-csharp[VSSDKCompletionTest#14](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs#14)]
     [!code-vb[VSSDKCompletionTest#14](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb#14)]  
  
## Implementing the Completion Command Handler  
 Because statement completion is triggered by keystrokes, you must implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface to receive and process the keystrokes that trigger, commit, and dismiss the completion session.  
  
#### To implement the completion command handler  
  
1. Add a class named `TestCompletionCommandHandler` that implements <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>:  
  
    [!code-csharp[VSSDKCompletionTest#15](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs#15)]
    [!code-vb[VSSDKCompletionTest#15](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb#15)]  
  
2. Add private fields for the next command handler (to which you pass the command), the text view, the command handler provider (which enables access to various services), and a completion session:  
  
    [!code-csharp[VSSDKCompletionTest#16](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs#16)]
    [!code-vb[VSSDKCompletionTest#16](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb#16)]  
  
3. Add a constructor that sets the text view and the provider fields, and adds the command to the command chain:  
  
    [!code-csharp[VSSDKCompletionTest#17](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs#17)]
    [!code-vb[VSSDKCompletionTest#17](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb#17)]  
  
4. Implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A> method by passing the command along:  
  
    [!code-csharp[VSSDKCompletionTest#18](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs#18)]
    [!code-vb[VSSDKCompletionTest#18](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb#18)]  
  
5. Implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A> method. When this method receives a keystroke, it must do one of these things:  
  
   - Allow the character to be written to the buffer, and then trigger or filter completion. (Printing characters do this.)  
  
   - Commit the completion, but do not allow the character to be written to the buffer. (Whitespace, Tab, and Enter do this when a completion session is displayed.)  
  
   - Allow the command to be passed on to the next handler. (All other commands.)  
  
     Because this method may display UI, call <xref:Microsoft.VisualStudio.Shell.VsShellUtilities.IsInAutomationFunction%2A> to make sure that it is not called in an automation context:  
  
     [!code-csharp[VSSDKCompletionTest#19](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs#19)]
     [!code-vb[VSSDKCompletionTest#19](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb#19)]  
  
6. This code is a private method that triggers the completion session:  
  
    [!code-csharp[VSSDKCompletionTest#20](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs#20)]
    [!code-vb[VSSDKCompletionTest#20](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb#20)]  
  
7. The next example is a private method that unsubscribes from the <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseSession.Dismissed> event:  
  
    [!code-csharp[VSSDKCompletionTest#21](../snippets/csharp/VS_Snippets_VSSDK/vssdkcompletiontest/cs/testcompletioncommandhandler.cs#21)]
    [!code-vb[VSSDKCompletionTest#21](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkcompletiontest/vb/testcompletioncommandhandler.vb#21)]  
  
## Building and Testing the Code  
 To test this code, build the CompletionTest solution and run it in the experimental instance.  
  
#### To build and test the CompletionTest solution  
  
1. Build the solution.  
  
2. When you run this project in the debugger, a second instance of Visual Studio is instantiated.  
  
3. Create a text file and type some text that includes the word "add".  
  
4. As you type first "a" and then "d", a list that contains "addition" and "adaptation" should be displayed. Notice that addition is selected. When you type another "d", the list should contain only "addition", which is now selected. You can commit "addition" by pressing the Spacebar, Tab, or Enter key, or dismiss the list by typing Esc or any other key.  
  
## See Also  
 [Walkthrough: Linking a Content Type to a File Name Extension](../extensibility/walkthrough-linking-a-content-type-to-a-file-name-extension.md)
