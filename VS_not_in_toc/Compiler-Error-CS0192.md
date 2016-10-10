---
title: "Compiler Error CS0192"
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
ms.assetid: d3fb6d18-dbf3-42c3-a280-afe55b97c2d1
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
# Compiler Error CS0192
Fields of static readonly field 'name' cannot be passed ref or out (except in a static constructor)  
  
 A field (variable) marked with the [readonly](../Topic/readonly%20\(C%23%20Reference\).md) keyword cannot be passed either to a [ref](../Topic/ref%20\(C%23%20Reference\).md) or [out](../Topic/out%20\(C%23%20Reference\).md) parameter except inside a constructor. For more information, see [Fields](../Topic/Fields%20\(C%23%20Programming%20Guide\).md).  
  
 CS0192 also results if the `readonly` field is [static](../Topic/static%20\(C%23%20Reference\).md) and the constructor is not marked `static`.  
  
## Example  
 The following sample generates CS0192.  
  
```  
// CS0192.cs  
class MyClass  
{  
    public readonly int TestInt = 6;  
    static void TestMethod(ref int testInt)  
    {  
        testInt = 0;  
    }  
  
    MyClass()  
    {  
        TestMethod(ref TestInt);   // OK  
    }  
  
    public void PassReadOnlyRef()  
    {  
        TestMethod(ref TestInt);   // CS0192  
    }  
  
    public static void Main()  
    {  
    }  
}  
```