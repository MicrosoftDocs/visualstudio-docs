---
title: "Intercepting Legacy Language Service Commands | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "commands, intercepting language service"
  - "language services, intercepting commands"
ms.assetid: eea69f03-349c-44bb-bd4f-4925c0dc3e55
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# Intercepting Legacy Language Service Commands
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

With [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)], you can have the language service intercept commands that the text view would otherwise handle. This is useful for language-specific behavior that the text view does not manage. You can intercept these commands by adding one or more command filters to the text view from your language service.  
  
## Getting and Routing the Command  
 A command filter is an <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> object that monitors certain character sequences or key commands. You can associate more than one command filter with a single text view. Each text view maintains a chain of command filters. After you create a new command filter, you add the filter to the chain for the appropriate text view.  
  
 Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.AddCommandFilter%2A> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> to add your command filter to the chain. When you call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.AddCommandFilter%2A>, [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] returns another command filter to which you can pass the commands that your command filter does not handle.  
  
 You have the following options for command handling:  
  
- Handle the command and then pass the command on to the next command filter in the chain.  
  
- Handle the command and do not pass the command on to the next command filter.  
  
- Do not handle the command, but pass the command on to the next command filter.  
  
- Ignore the command. Do not handle it in the current filter, and do not pass it on to the next filter.  
  
  For information about which commands your language service should handle, see [Important Commands for Language Service Filters](../../extensibility/internals/important-commands-for-language-service-filters.md).
