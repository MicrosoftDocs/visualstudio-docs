---
title: "&#39;Finally&#39; must end with a matching &#39;End Try&#39;"
ms.custom: na
ms.date: 10/02/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 36cce657-186c-4ba0-a760-abcef9529f18
caps.latest.revision: 7
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
# &#39;Finally&#39; must end with a matching &#39;End Try&#39;
A `Finally` statement appears in your code without a matching `End Try`statement. `Finally` statements must be concluded with an `End Try` statement.  
  
 **Error ID:** BC30442  
  
### To correct this error  
  
1.  Remove the `Finally` statement.  
  
2.  Add an `End Try` statement to conclude the block.  
  
## See Also  
 [Try...Catch...Finally Statement](../Topic/Try...Catch...Finally%20Statement%20\(Visual%20Basic\).md)   
 [Structured Exception Handling Overview for Visual Basic](assetId:///bb81af80-a735-4873-9711-6151a48e418a)