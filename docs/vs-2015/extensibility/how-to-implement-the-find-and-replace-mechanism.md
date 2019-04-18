---
title: "How to: Implement the Find and Replace Mechanism | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - find and replace"
ms.assetid: bbd348db-3d19-42eb-99a2-3e808528c0ca
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# How to: Implement the Find and Replace Mechanism
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio provides two ways of implementing Find/Replace. One way is to pass a text image to the shell and let it handle searching, highlighting, and replacing text. This allows users to specify multiple text spans. Alternatively, your VSPackage can control this functionality itself. In both cases you must notify the shell about the current target and the targets for all open documents.  
  
### To implement Find/Replace  
  
1. Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget> interface on one of the objects returned by the frame properties <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID> or <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID>. If you are creating a custom editor, you should implement this interface as part of the custom editor class.  
  
2. Use the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.GetCapabilities%2A> method to specify the options that your editor supports and to indicate whether it implements text image searching.  
  
     If your editor supports text image searching, implement <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.GetSearchImage%2A>.  
  
     Otherwise, implement <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Find%2A> and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Replace%2A>.  
  
3. If you implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Find%2A> and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Replace%2A> methods, you can simplify your searching tasks by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper> interface.  
  
## See Also  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper>   
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget>   
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Find%2A>   
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.GetSearchImage%2A>   
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Replace%2A>   
 <xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID>
