---
title: "&#39;End&#39; statement cannot be used in class library projects"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c8606b17-b50b-4014-b76e-b748d57e9389
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
# &#39;End&#39; statement cannot be used in class library projects
Class library projects used to create DLLs do not allow the use of the `End` keyword to stop the execution of code in a procedure.  
  
 **Error ID:** BC30615  
  
### To correct this error  
  
-   Use control structures such as `While` and `For` to control the flow of program execution.  
  
## See Also  
 [Control Flow](../Topic/Control%20Flow%20in%20Visual%20Basic.md)