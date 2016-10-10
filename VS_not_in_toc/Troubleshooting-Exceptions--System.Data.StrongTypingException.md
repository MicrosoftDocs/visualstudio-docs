---
title: "Troubleshooting Exceptions: System.Data.StrongTypingException"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 90859ce2-3696-43cb-baf4-7daf98d8e2e1
caps.latest.revision: 9
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
# Troubleshooting Exceptions: System.Data.StrongTypingException
A <xref:System.Data.StrongTypingException?qualifyHint=False> occurs when the user accesses a <xref:System.DBNull?qualifyHint=False> value in a strongly typed <xref:System.Data.DataTable.DataSet?qualifyHint=False>.  
  
## Associated Tips  
 **Add error handling for the StrongTypingException.**  
 Place the code accessing the <xref:System.Data.DataTable.DataSet?qualifyHint=False> in a `Try…Catch` block and catch the <xref:System.Data.StrongTypingException?qualifyHint=False>.  
  
## See Also  
 <xref:System.Data.DataTable.DataSet?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)   
 [Try...Catch...Finally Statement](../Topic/Try...Catch...Finally%20Statement%20\(Visual%20Basic\).md)   
 [Dataset tools in Visual Studio](../VS_raddata/Dataset-tools-in-Visual-Studio.md)