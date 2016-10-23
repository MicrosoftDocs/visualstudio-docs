---
title: "Compiler Error CS1109"
ms.custom: na
ms.date: 10/01/2016
ms.devlang: 
  - CSharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bebe56b8-3831-4ebb-a49e-e0364b4c11a7
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
# Compiler Error CS1109
Extension Methods must be defined on top level static classes, 'name' is a nested class.  
  
 Extension methods cannot be defined in nested classes.  
  
## Example  
 The following example generates CS1109 because the class `Extension` is nested inside the class `Out`:  
  
```  
// cs1109.cs  
public class Test  
{  
}  
static class Out  
{  
    static class Extension  
    {  
        static void ExtMethod(this Test c) // CS1109  
        {  
        }  
    }  
}  
```  
  
## See Also  
 [Extension Methods](../Topic/Extension%20Methods%20\(C%23%20Programming%20Guide\).md)