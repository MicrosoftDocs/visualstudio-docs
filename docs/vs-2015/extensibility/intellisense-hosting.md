---
title: "IntelliSense Hosting | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - IntelliSense hosting"
ms.assetid: 20c61f8a-d32d-47e2-9c67-bf721e2cbead
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# IntelliSense Hosting
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio enables IntelliSense hosting. IntellSense hosting lets you provide IntelliSense for code that is not hosted by the Visual Studio text editor.  
  
## IntelliSense Hosting Usage  
 In Visual Studio, any code that has access to a completion set and a text buffer can obtain IntelliSense windows from anywhere in the user interface (UI). Some example scenarios of this are completion in the **Watch** window or in the condition field of a breakpoint properties window.  
  
### Implementation Interfaces  
  
#### IVsIntellisenseHost  
 Any UI component that hosts IntelliSense pop-up windows must support the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost> interface. The default core editor text view includes a stock <xref:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost> interface implementation to retain the current IntelliSense functionality. For the most part, the methods of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost> interface represent a subset of what is implemented on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> interface. The subset includes IntelliSense UI handling, caret and selection manipulation, and simple text replacement functionality. In addition, the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost> interface enables separate IntelliSense "subject" and "context" so that IntelliSense can be provided for subjects that do not directly exist in the text buffer that is being used for context.  
  
#### IVsIntellisenseHost.GetHostFlags  
 An <xref:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost> interface provider must implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.GetHostFlags%2A> method to enable a client to determine what type of IntelliSense features the host supports.  
  
 The host flags, defined in [IntelliSenseHostFlags](../extensibility/intellisensehostflags.md), are summarized below.  
  
|IntelliSense Host Flag|Description|  
|----------------------------|-----------------|  
|IHF_READONLYCONTEXT|Setting this flag means that the context buffer is read-only and editing occurs only within the subject text.|  
|IHF_NOSEPERATESUBJECT|Setting this flag means that there is no separate IntelliSense subject. The subject exists in the context buffer, such as in the traditional <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> IntelliSense system.|  
|IHF_SINGLELINESUBJECT|Setting this flag means that the subject is not multi-line capable, such as in a single line edit in the **Watch** window.|  
|IHF_FORCECOMMITTOCONTEXT|If this flag is set and the context buffer must be updated, the host enables the read-only flag on the context buffer to be ignored and edits to proceed.|  
|IHF_OVERTYPE|Editing (in subject or context) should be done in overtype mode.|  
  
#### IVsIntellisenseHost.BeforeCompletorCommit and IVsIntellisenseHost.AfterCompletorCommit  
 These callback methods are called by the completion window before and after text is committed, to enable pre-processing and post-processing.  
  
#### IVsIntellisenseCompletor  
 The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseCompletor> interface is a co-creatable version of the standard completion window that is used by the integrated development environment (IDE). Any <xref:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost> interface can quickly implement IntelliSense by using this completor interface.  
  
## See Also  
 <xref:Microsoft.VisualStudio.TextManager.Interop>
