---
title: "Contained Languages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - contained languages"
ms.assetid: b75bbb51-8e42-41b1-bece-09ab0b1f03cc
caps.latest.revision: 19
ms.author: gregvanl
manager: jillfra
---
# Contained Languages
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)] 

*Contained languages* are languages that are contained by other languages. For example, HTML in [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] pages may contain [!INCLUDE[csprcs](../includes/csprcs-md.md)] or [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] scripts. A dual-language architecture is required for the .aspx file editor to provide IntelliSense, colorization, and other editing features for both the HTML and the scripting language.  
  
## Implementation  
 The most important interface you need to implement for contained languages is the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsContainedLanguage> interface. This interface is implemented by any language that can be hosted inside a primary language. It gives access to the language service’s colorizer, text view filter, and primary language service ID. The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsContainedLanguageFactory> enables you to create an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsContainedLanguage> interface. The following steps show you how to implement a contained language:  
  
1. Use `QueryService()` to get the language service ID and the interface ID of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsContainedLanguageFactory>.  
  
2. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsContainedLanguageFactory.GetLanguage%2A> method to create an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsContainedLanguage> interface. Pass an <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> interface, one or more [item IDs](<xref:Microsoft.VisualStudio.VSConstants.VSITEMID>) and an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator> interface.  
  
3. The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator> interface, which is the text buffer coordinator object, provides the basic services that are required to map locations in a primary file into the secondary language’s buffer.  
  
     For example, in a single .aspx file, the primary file includes the ASP, HTML and all the code that is contained. However, the secondary buffer,  includes just the contained code, together with any class definitions, to make the secondary buffer a valid code file. The buffer coordinator handles the work of coordinating edits from one buffer to the other.  
  
4. The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator.SetSpanMappings%2A> method, which is the primary language, tells the buffer coordinator what text within its buffer is mapped to corresponding text in the secondary buffer.  
  
     The language passes in an array of the <xref:Microsoft.VisualStudio.TextManager.Interop.NewSpanMapping> structure, which currently only includes a primary and a secondary span.  
  
5. The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator.MapPrimaryToSecondarySpan%2A> method and the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator.MapSecondaryToPrimarySpan%2A> method provide the mapping from primary to secondary buffer and vice versa.
