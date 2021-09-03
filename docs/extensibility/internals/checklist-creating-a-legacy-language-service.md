---
title: 'Checklist: Creating a Legacy Language Service | Microsoft Docs'
description: Learn the basic steps you must take to create a legacy language service for the Visual Studio core editor.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- language services
- language services, native code
ms.assetid: 8b73b341-a33a-4ab5-9390-178c9e563d2d
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Checklist: Create a legacy language service
The following checklist summarizes the basic steps you must take in order to create a language service for the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] core editor. To integrate your language service into [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], you must create a debug expression evaluator. For more information, see [Write a CLR expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md) in the [Visual Studio debugger extensibility](../../extensibility/debugger/visual-studio-debugger-extensibility.md).

## Steps to create a language service

1. Implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage> interface.

    - In your VSPackage, implement the <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider> interface to provide the language service.

    - Make your language service available to the integrated development environment (IDE) in your <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.SetSite%2A> implementation.

2. Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo> interface in the main language service class.

     The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo> interface is the starting point of interaction between the core editor and the language service.

### Optional features
 The following features are optional and can be implemented in any order. These features increase the functionality of your language service.

- Syntax coloring

  Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer> interface. Your implementation of this interface should the parser information to return the appropriate color information.

  The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo.GetColorizer%2A> method returns the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer> interface. A separate colorizer instance is created for each text buffer, so you should implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer> interface separately. For more information, see [Syntax coloring in a legacy language service](../../extensibility/internals/syntax-coloring-in-a-legacy-language-service.md).

- Code window

  Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindowManager> interface to enable the language service to receive notification of when a new code window is created.

  The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo.GetCodeWindowManager%2A> method returns the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindowManager> interface. The language service can then add special UI to the code window in <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindowManager.AddAdornments%2A>. The language service can also do any special processing, such as adding a text view filter in <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindowManager.OnNewView%2A>.

- Text view filter

  To provide IntelliSense statement completion in a language service, you must intercept some of the commands that the text view would otherwise handle. To intercept these commands, complete the following steps:

  - Implement <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> to participate in the command chain and handle editor commands.

  - Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.AddCommandFilter%2A> method and pass in your <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> implementation.

  - Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.RemoveCommandFilter%2A> method when you detach from the view so that these commands are no longer passed to you.

  Commands that must be handled depend on the services that are provided. For more information, see [Important commands for language service filters](../../extensibility/internals/important-commands-for-language-service-filters.md).

  > [!NOTE]
  > The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewFilter> interface must be implemented on the same object as the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface.

- Statement completion

  Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCompletionSet> interface.

  Support the statement completion command (that is, <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID>) and call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateCompletionStatus%2A> method in the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> interface, passing the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCompletionSet> interface. For more information, see [Statement completion in a legacy language service](../../extensibility/internals/statement-completion-in-a-legacy-language-service.md).

- Method tips

  Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData> interface to provide data for the method tip window.

  Install the text view filter to handle commands appropriately, so that you know when to show a method data tip window. For more information, see [Parameter Info in a legacy language service](../../extensibility/internals/parameter-info-in-a-legacy-language-service1.md).

- Error markers

  Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient> interface.

  Create the error marker objects that implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient> interface and call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines.CreateLineMarker%2A> method, passing the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient> interface of the error marker object.

  Typically each error marker manages an item in the task list window.

- Task list items

  Implement a task item class providing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskItem> interface.

  Implement a task provider class providing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskProvider> interface and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskProvider2> interface.

  Implement a task enumerator class providing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEnumTaskItems> interface.

  Register the task provider with the task list's <xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskList.RegisterTaskProvider%2A> method.

  Obtain the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskList> interface by calling the language service's service provider with the service GUID <xref:Microsoft.VisualStudio.Shell.Interop.SVsTaskList>.

  Create task item objects and call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskList.RefreshTasks%2A> method in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskList> interface when there are new or updated tasks.

- Comment task items

  Use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsCommentTaskInfo> interface and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEnumCommentTaskTokens> interface to obtain the comment task tokens.

  Obtain an <xref:Microsoft.VisualStudio.Shell.Interop.IVsCommentTaskInfo> interface from the <xref:Microsoft.VisualStudio.Shell.Interop.SVsTaskList> service.

  Obtain the <xref:Microsoft.VisualStudio.Shell.Interop.IVsEnumCommentTaskTokens> interface from the <xref:Microsoft.VisualStudio.Shell.Interop.IVsCommentTaskInfo.EnumTokens%2A> method.

  Implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTaskListEvents> interface to listen for changes in the token list.

- Outlining

  There are several options for supporting outlining. For example, you can support the **Collapse to Definitions** command, provide editor-controlled outline regions, or support client-controlled regions. For more information, see [How to: Provide expanded outlining support in a legacy language service](../../extensibility/internals/how-to-provide-expanded-outlining-support-in-a-legacy-language-service.md).

- Language service registration

  For more information about how to register a language service, see [Register a legacy language service](../../extensibility/internals/registering-a-legacy-language-service2.md) and [Manage VSPackages](../../extensibility/managing-vspackages.md).

- Context-sensitive help

  Provide context to the editor in one of the following ways:

  - Provide context for text markers by implementing the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerContextProvider> interface.

  - Provide all user context by implementing the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageContextProvider> interface.

## See also
- [Develop a legacy language service](../../extensibility/internals/developing-a-legacy-language-service.md)
- [Write a CLR expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
