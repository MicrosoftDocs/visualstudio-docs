---
title: "Statement Completion in a Legacy Language Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "statement completion"
  - "language services, statement completion"
ms.assetid: 617439dc-3f0e-4e5f-b346-3e4e7fcf3c1b
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Statement Completion in a Legacy Language Service
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Statement completion is the process by which the language service helps users finish a language keyword or element that they have started typing in the core editor. This topic discusses how statement completion works and how to implement it in your language service.  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more about the new way to implement statement completion, see [Walkthrough: Displaying Statement Completion](../../extensibility/walkthrough-displaying-statement-completion.md).  
  
> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.  
  
## Implementing Statement Completion  
 In the core editor, statement completion activates a special UI that interactively helps you more easily and quickly write code. Statement completion helps by displaying pertinent objects or classes when they are needed, which avoids you having to remember specific elements or having to look them up in a Help reference topic.  
  
 To implement statement completion, your language must have a statement completion trigger, which can be parsed. For example, [!INCLUDE[vbprvb](../../includes/vbprvb-md.md)] uses a dot (.) operator, while [!INCLUDE[vcprvc](../../includes/vcprvc-md.md)] uses an arrow (->) operator. A language service can use more than one trigger to initiate statement completion. These triggers are programmed in the command filter.  
  
## Command Filters and Triggers  
 Command filters intercept occurrences of your trigger or triggers. To add the command filter to the view, implement the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> interface and attach it to the view by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.AddCommandFilter%2A> method. You can use the same command filter (<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>) for all aspects of your language service, such as statement completion, error markers, and method tips. For more information, see [Intercepting Legacy Language Service Commands](../../extensibility/internals/intercepting-legacy-language-service-commands.md).  
  
 When the trigger is entered in the editor — specifically, the text buffer — your language service then calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateCompletionStatus%2A> method. This causes the editor to bring up the UI so that the user can choose from the statement completion candidates. This method requires you to implement <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCompletionSet> and the <xref:Microsoft.VisualStudio.TextManager.Interop.UpdateCompletionFlags> flags as parameters. The list of completion items appears in a scrolling list box. As the user continues typing, the selection within the list box is updated to reflect the closest match to the most recent characters typed. The core editor implements the UI for statement completion, but the language service must implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCompletionSet> interface to define a set of candidate completion items for the statement.  
  
## See Also  
 [Intercepting Legacy Language Service Commands](../../extensibility/internals/intercepting-legacy-language-service-commands.md)
