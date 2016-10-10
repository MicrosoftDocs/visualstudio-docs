---
title: "Compiler Error CS0687"
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
ms.assetid: b51c5e7c-f4de-4aa4-97b1-ebe220cd19b0
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
# Compiler Error CS0687
The namespace alias qualifier '::' always resolves to a type or namespace so is illegal here. Consider using '.' instead.  
  
 This error occurs if you used something which the parser interpreted as a type in an unexpected place. A type or namespace name is valid only in a member access expression, using the member access (**.**) operator. This could occur if you used the global scope operator (::) in another context.  
  
## Example  
 The following sample generates CS0687:  
  
```  
// CS0687.cs  
  
using M = Test;  
using System;  
  
public class Test   
{  
    public static int x = 77;  
  
    public static void Main()   
    {  
        Console.WriteLine(M::x); // CS0687  
        // To resolve use the following line instead:  
        // Console.WriteLine(M.x);  
    }  
}  
```