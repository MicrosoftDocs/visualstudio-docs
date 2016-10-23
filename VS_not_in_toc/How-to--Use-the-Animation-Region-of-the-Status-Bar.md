---
title: "How to: Use the Animation Region of the Status Bar"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ec6fb915-7bc8-4a90-8156-70c1a243caff
caps.latest.revision: 14
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
# How to: Use the Animation Region of the Status Bar
The Animation region of the Visual Studio status bar displays a looping animation that indicates either a lengthy operation or an operation of indeterminate length (for example, building multiple projects in a solution).  
  
### To use the Animation region of the Visual Studio status bar  
  
1.  Obtain an instance of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar?qualifyHint=False> interface, which is made available through the <xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar?qualifyHint=False> service.  
  
2.  Start the animation by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.Animation?qualifyHint=False> method of the status bar. Pass in 1 as the value of the first parameter, and a reference to an animated icon as the value of the second parameter.  
  
3.  Stop the animation by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.Animation?qualifyHint=False> method of the status bar. Pass in 0 as the value of the first parameter, and a reference to the animated icon as the value of the second parameter.  
  
## Example  
 This example demonstrates how to run a built-in animation in the Animation region.  
  
 [!CODE [VSSDKAnimationStatusBar#1](../CodeSnippet/VS_Snippets_VSSDK/vssdkanimationstatusbar#1)]  
  
## See Also  
 [Extending the Status Bar](../Topic/Extending%20the%20Status%20Bar.md)   
 [How to: Read from and Write to the Feedback Region of the Status Bar](../VS_not_in_toc/How-to--Read-from-and-Write-to-the-Feedback-Region-of-the-Status-Bar.md)   
 [How to: Program the Progress Bar Region of the Status Bar](../VS_not_in_toc/How-to--Program-the-Progress-Bar-Region-of-the-Status-Bar.md)   
 [How to: Program the Designer Region of the Status Bar](../VS_not_in_toc/How-to--Program-the-Designer-Region-of-the-Status-Bar.md)