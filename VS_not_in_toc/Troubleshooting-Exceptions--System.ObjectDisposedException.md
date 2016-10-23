---
title: "Troubleshooting Exceptions: System.ObjectDisposedException"
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
ms.assetid: 702912b6-e927-4f8e-8b7c-2e1880312b0e
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
# Troubleshooting Exceptions: System.ObjectDisposedException
An <xref:System.ObjectDisposedException?qualifyHint=False> exception is thrown when an operation is attempted on a disposed object, such as a closed stream or registry key.  
  
## Associated Tips  
 **Make sure you have not released a resource before attempting to use it.**  
 For example, if attempting to manipulate a stream, make sure it has not been previously closed.  
  
## See Also  
 <xref:System.ObjectDisposedException?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)