---
title: "Troubleshooting Exceptions: System.IO.PathTooLongException"
ms.custom: na
ms.date: 10/01/2016
ms.devlang: 
  - JScript
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8912c425-bf91-42e3-82d8-bee6b2062db3
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
# Troubleshooting Exceptions: System.IO.PathTooLongException
A <xref:System.IO.PathTooLongException?qualifyHint=False> exception is thrown when a path name or file name is longer than the system-defined maximum length.  
  
## Associated Tips  
 **Make sure the path is not longer than the system-defined maximum.**  
 On Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.  
  
## See Also  
 <xref:System.IO.PathTooLongException?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)   
 [How to: Parse File Paths](../Topic/How%20to:%20Parse%20File%20Paths%20in%20Visual%20Basic.md)