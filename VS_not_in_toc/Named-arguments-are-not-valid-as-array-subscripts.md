---
title: "Named arguments are not valid as array subscripts"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a25025c9-0763-4c19-9e9b-cffb9aacaa8a
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
# Named arguments are not valid as array subscripts
An array index is specified using the syntax for passing a procedure argument by name, for example `Array(Index := 10)`. This syntax is not valid for array subscripts.  
  
 **Error ID:** BC30075  
  
### To correct this error  
  
-   Use an ordinary variable or constant expression as the array index, for example `Array(10)`.  
  
## See Also  
 [NOTINBUILD Overview of Arrays in Visual Basic](assetId:///ca50e2f2-b4d2-4c57-9169-9abbcc3392d8)   
 [Passing Arguments by Position and by Name](../Topic/Passing%20Arguments%20by%20Position%20and%20by%20Name%20\(Visual%20Basic\).md)