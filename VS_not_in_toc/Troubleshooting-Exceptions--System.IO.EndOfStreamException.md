---
title: "Troubleshooting Exceptions: System.IO.EndOfStreamException"
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
ms.assetid: 1271e6f6-3a0d-49f0-9ff4-178d480687be
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
# Troubleshooting Exceptions: System.IO.EndOfStreamException
An <xref:System.IO.EndOfStreamException?qualifyHint=False> exception is thrown when there is an attempt to read past the end of a stream.  
  
## Associated Tips  
 **Check whether the end of the file has been reached before reading.**  
 Use the <xref:System.IO.StreamReader.Peek?qualifyHint=False> method to check the end of the file before reading from the stream.  
  
## See Also  
 <xref:System.IO.EndOfStreamException?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)   
 [How to: Read and Write to a Newly Created Data File](../Topic/How%20to:%20Read%20and%20Write%20to%20a%20Newly%20Created%20Data%20File.md)   
 [How to: Open and Append to a Log File](../Topic/How%20to:%20Open%20and%20Append%20to%20a%20Log%20File.md)