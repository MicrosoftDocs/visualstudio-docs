---
title: "Compiler Error CS1948"
ms.custom: na
ms.date: 10/02/2016
ms.devlang: 
  - CSharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3dac3abe-0edd-4ee1-8fb1-bc597ea63e1f
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
# Compiler Error CS1948
The range variable 'name' cannot have the same name as a method type parameter  
  
 The same declaration space cannot contain two declarations of the same identifier.  
  
### To correct this error  
  
1.  Change the name of the range variable or the type parameter.  
  
## Example  
 The following example generates CS1948 because the identifier `T` is used for the range variable and for the type parameter on method `TestMethod`:  
  
```  
// cs1948.cs  
using System.Linq;  
class Test  
{  
    public void TestMethod<T>(T t)  
    {  
        var x = from T in Enumerable.Range(1, 100) // CS1948  
                select T;  
    }  
}  
```