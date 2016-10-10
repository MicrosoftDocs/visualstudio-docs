---
title: "Compiler Error CS0248"
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
ms.assetid: a7ddfd26-a836-47b8-b432-53876e06da31
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
# Compiler Error CS0248
Cannot create an array with a negative size  
  
 An array size was specified with a negative number. For more information, see [Arrays](../Topic/Arrays%20\(C%23%20Programming%20Guide\).md).  
  
## Example  
 The following sample generates CS0248:  
  
```  
// CS0248.cs  
class MyClass  
{  
    public static void Main()  
    {  
        int[] myArray = new int[-3] {1,2,3};   // CS0248, pass a nonnegative number  
    }  
}  
```