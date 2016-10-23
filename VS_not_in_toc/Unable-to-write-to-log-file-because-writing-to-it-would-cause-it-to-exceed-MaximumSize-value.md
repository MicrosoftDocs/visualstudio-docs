---
title: "Unable to write to log file because writing to it would cause it to exceed MaximumSize value"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 61747a9c-e460-424b-a365-73cdba9dd428
caps.latest.revision: 10
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
# Unable to write to log file because writing to it would cause it to exceed MaximumSize value
The <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener?qualifyHint=False> class could not write to the log file because:  
  
-   The log file size (in bytes) is greater than the value of the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.MaxFileSize?qualifyHint=False> property  
  
     —and—  
  
-   The value of the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.DiskSpaceExhaustedBehavior?qualifyHint=False> property was <xref:Microsoft.VisualBasic.Logging.DiskSpaceExhaustedOption?qualifyHint=False>.  
  
### To correct this error  
  
1.  Archive the existing logs and remove them from the computer to allow the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener?qualifyHint=False> object to create new logs.  
  
2.  Change the value of the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.MaxFileSize?qualifyHint=False> property to allow for larger logs.  
  
3.  Set the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.DiskSpaceExhaustedBehavior?qualifyHint=False> property to <xref:Microsoft.VisualBasic.Logging.DiskSpaceExhaustedOption?qualifyHint=False> to discard messages without warning if the log is too large.  
  
## See Also  
 <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.MaxFileSize?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.DiskSpaceExhaustedBehavior?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener?qualifyHint=False>   
 [My.Application.Log Object](../Topic/My.Application.Log%20Object.md)   
 [My.Log Object](../Topic/My.Log%20Object.md)