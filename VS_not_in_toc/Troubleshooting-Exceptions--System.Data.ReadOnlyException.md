---
title: "Troubleshooting Exceptions: System.Data.ReadOnlyException"
ms.custom: na
ms.date: 10/02/2016
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
ms.assetid: 1ac5da38-c5af-4fec-8fe1-1b9dd5069e59
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
# Troubleshooting Exceptions: System.Data.ReadOnlyException
A <xref:System.Data.ReadOnlyException?qualifyHint=False> exception is thrown when there is an attempt to change the value of a read-only data column.  
  
## Associated Tips  
 **Change the column to read/write.**  
 This exception is thrown if you are attempting to change a value in a data column that is read-only. For more information, see <xref:System.Data.DataColumn?qualifyHint=False>.  
  
 **Make sure that you are modifying the data in the correct column.**  
 This exception is thrown if you are attempting to change a value in a data column that is read-only. For more information, see <xref:System.Data.DataColumn?qualifyHint=False>.  
  
## See Also  
 <xref:System.Data.ReadOnlyException?qualifyHint=False>   
 <xref:System.Data.DataRow.EndEdit?qualifyHint=False>   
 <xref:System.Data.DataRow.ItemArray?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)