---
title: "How to: Read from and Write to the Feedback Region of the Status Bar"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e639561c-e1e7-4660-b2a2-8bca80f34a29
caps.latest.revision: 12
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
# How to: Read from and Write to the Feedback Region of the Status Bar
The Feedback region of the Visual Studio status bar displays text. You can set and retrieve text, display static text, and highlight the displayed text.  
  
### To use the Feedback region of the Visual Studio Status bar  
  
1.  Obtain an instance of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar?qualifyHint=False> interface, which is made available through the <xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar?qualifyHint=False> service.  
  
2.  Determine whether the status bar is frozen by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.IsFrozen?qualifyHint=False> method of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar?qualifyHint=False> instance.  
  
3.  Set the text of the Feedback region by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.SetText?qualifyHint=False> method and passing in a text string.  
  
4.  Read the text of the Feedback region by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.GetText?qualifyHint=False> method.  
  
## Example  
 This example demonstrates how to write text to and read text from the Feedback region.  
  
 [!CODE [VSSDKFeedbackStatusBar#1](../CodeSnippet/VS_Snippets_VSSDK/vssdkfeedbackstatusbar#1)]  
  
 In the above example, the code does the following things:  
  
-   Obtains an instance of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar?qualifyHint=False> interface from the <xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar?qualifyHint=False> service.  
  
-   Checks to see if the status bar is frozen by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.IsFrozen?qualifyHint=False> method.  
  
-   Inhibits further updates to the status bar by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.FreezeOutput?qualifyHint=False> method.  
  
-   Reads the text from the status bar by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.GetText?qualifyHint=False> method and displays it in a message box.  
  
-   Allows updates to the status bar by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.FreezeOutput?qualifyHint=False> and passing 0 in the parameter.  
  
-   Clears the contents of the status bar by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.Clear?qualifyHint=False> method.  
  
## See Also  
 [Extending the Status Bar](../Topic/Extending%20the%20Status%20Bar.md)   
 [How to: Program the Progress Bar Region of the Status Bar](../VS_not_in_toc/How-to--Program-the-Progress-Bar-Region-of-the-Status-Bar.md)   
 [How to: Use the Animation Region of the Status Bar](../VS_not_in_toc/How-to--Use-the-Animation-Region-of-the-Status-Bar.md)   
 [How to: Program the Designer Region of the Status Bar](../VS_not_in_toc/How-to--Program-the-Designer-Region-of-the-Status-Bar.md)