---
title: "Nullable modifier cannot be used with a variable whose implicit type is &#39;Object&#39;"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 50b2a2ad-248d-4faa-820d-bcdf0e8b4aad
caps.latest.revision: 3
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
# Nullable modifier cannot be used with a variable whose implicit type is &#39;Object&#39;
A variable declaration includes the nullable type modifier (?), but does not specify a type or infer a type by assigning a value to the declared variable.  
  
 **Error ID:** BC33112  
  
### To correct this error  
  
-   Specify a type when declaring the nullable variable. The type cannot be <xref:System.Object?qualifyHint=False>.  
  
-   Assign a value when declaring the nullable variable. The type of the nullable variable will be inferred from the assigned value. The type of the value cannot be <xref:System.Object?qualifyHint=False>.  
  
## See Also  
 [Nullable Value Types](../Topic/Nullable%20Value%20Types%20\(Visual%20Basic\).md)