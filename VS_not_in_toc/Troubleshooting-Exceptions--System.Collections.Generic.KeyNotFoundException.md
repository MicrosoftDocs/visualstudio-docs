---
title: "Troubleshooting Exceptions: System.Collections.Generic.KeyNotFoundException"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: de33f5bb-5709-46fe-b889-7105dbd24299
caps.latest.revision: 8
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
# Troubleshooting Exceptions: System.Collections.Generic.KeyNotFoundException
A <xref:System.Collections.Generic.KeyNotFoundException?qualifyHint=False> is thrown when an attempt is made to retrieve a key or key value pair from a collection using a nonexistent key.  
  
## Associated Tips  
 **Check that the key you are using exists in the collection you are attempting to access.**  
 This exception occurs when an operation attempts to retrieve an element in a collection using a key that does not exist in that collection.  
  
### Remarks  
 The <xref:System.Collections.Generic.Dictionary`2.ContainsKey?qualifyHint=False> method can be used to determine whether a key exists.  
  
## See Also  
 <xref:System.Collections.Generic?qualifyHint=False>   
 <xref:System.Collections.Generic.KeyNotFoundException?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)