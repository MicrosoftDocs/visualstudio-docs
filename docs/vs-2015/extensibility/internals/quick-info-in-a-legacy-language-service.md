---
title: "Quick Info in a Legacy Language Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Quick Info, supporting in language services [managed package framework]"
  - "IntelliSense, Quick Info"
  - "language services [managed package framework], IntelliSense Quick Info"
ms.assetid: 159ccb0b-f5d6-4912-b88b-e9612924ed5e
caps.latest.revision: 17
ms.author: gregvanl
manager: jillfra
---
# Quick Info in a Legacy Language Service
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

IntelliSense Quick Info shows information about an identifier in the source when the user either places the caret in the identifier and selects **Quick Info** from the **IntelliSense** menu or holds the mouse cursor over the identifier. This causes a tool tip to appear with information about the identifier. This information typically consists of the identifier type. When the debug engine is active, this information might include the current value. The debug engine supplies expression values , while the language service handles only identifiers.  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more, see [Walkthrough: Displaying QuickInfo Tooltips](../../extensibility/walkthrough-displaying-quickinfo-tooltips.md).  
  
> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.  
  
 The managed package framework (MPF) language service classes provide full support for displaying the IntelliSense Quick Info tool tip. All you have to do is supply the text to be displayed and enable the quick info feature.  
  
 The text to be displayed is obtained by calling the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method parser with a parse reason value of <xref:Microsoft.VisualStudio.Package.ParseReason>. This reason tells the parser to obtain the type information (or whatever is appropriate to be displayed in the Quick Info tool tip) for the identifier at the location specified in the <xref:Microsoft.VisualStudio.Package.ParseRequest> object. The <xref:Microsoft.VisualStudio.Package.ParseRequest> object is what was passed to the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method.  
  
 The parser must parse everything up to the position in the <xref:Microsoft.VisualStudio.Package.ParseRequest> object in order to determine the types of all identifiers. Then the parser must get the identifier at the parse request location. Finally, the parser must pass the tool tip data associated with that identifier to the <xref:Microsoft.VisualStudio.Package.AuthoringScope> object so that object can return the text from the <xref:Microsoft.VisualStudio.Package.AuthoringScope.GetDataTipText%2A> method.  
  
## Enabling the Quick Info Feature  
 To enable the Quick Info feature, you must set the `CodeSense` and `QuickInfo` named parameters of the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute>.These attributes set the <xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableCodeSense%2A> and <xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableQuickInfo%2A> properties.  
  
## Implementing the Quick Info Feature  
 The <xref:Microsoft.VisualStudio.Package.ViewFilter> class handles the IntelliSense Quick Info operation. When the <xref:Microsoft.VisualStudio.Package.ViewFilter> class receives the <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID> command, the class calls the <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method with the parse reason of <xref:Microsoft.VisualStudio.Package.ParseReason> and the location of the caret at the time the <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID> command was sent. The <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method parser must then parse the source up to the given location and then parse the identifier at the given location to determine what to display in the Quick Info tool tip.  
  
 Most parsers do an initial parse of the entire source file and store the results in a parse tree. The complete parse is carried out when <xref:Microsoft.VisualStudio.Package.ParseReason> is passed to <xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource%2A> method. Other kinds of parsing can then use the parse tree to obtain the desired information.  
  
 For example, the parse reason value of <xref:Microsoft.VisualStudio.Package.ParseReason> can find the identifier at the source location and look it up in the parse tree to obtain the type information. This type information is then passed to the <xref:Microsoft.VisualStudio.Package.AuthoringScope> class, and is returned by the <xref:Microsoft.VisualStudio.Package.AuthoringScope.GetDataTipText%2A> method.
