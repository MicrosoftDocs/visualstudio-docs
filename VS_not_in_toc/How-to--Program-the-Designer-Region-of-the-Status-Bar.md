---
title: "How to: Program the Designer Region of the Status Bar"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 735a86bb-80b2-4557-9677-00799856017f
caps.latest.revision: 11
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# How to: Program the Designer Region of the Status Bar
The Designer region of the Visual Studio status bar displays information that pertains to editing, for example, the line number or column number of the cursor location.  
  
### To program the Designer region of the Visual Studio status bar  
  
1.  Obtain an instance of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar?qualifyHint=False> interface, which is made available through the <xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar?qualifyHint=False> service.  
  
2.  Update the Designer region of the status bar by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.SetInsMode?qualifyHint=False> method and <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.SetLineColChar?qualifyHint=False> method of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar?qualifyHint=False> instance.  
  
## Example  
 This example demonstrates how to program the Designer region of the status bar.  
  
 [!CODE [VSSDKDesignerStatusBar#1](../CodeSnippet/VS_Snippets_VSSDK/vssdkdesignerstatusbar#1)]  
  
## See Also  
 [Extending the Status Bar](../Topic/Extending%20the%20Status%20Bar.md)   
 [How to: Read from and Write to the Feedback Region of the Status Bar](../VS_not_in_toc/How-to--Read-from-and-Write-to-the-Feedback-Region-of-the-Status-Bar.md)   
 [How to: Program the Progress Bar Region of the Status Bar](../VS_not_in_toc/How-to--Program-the-Progress-Bar-Region-of-the-Status-Bar.md)   
 [How to: Use the Animation Region of the Status Bar](../VS_not_in_toc/How-to--Use-the-Animation-Region-of-the-Status-Bar.md)