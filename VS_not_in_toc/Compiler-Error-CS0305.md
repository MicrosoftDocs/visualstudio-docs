---
title: "Compiler Error CS0305"
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
ms.assetid: a862c484-01fe-4067-b0f4-15a618e7f8a1
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
# Compiler Error CS0305
Using the generic type 'generic type' requires 'number' type arguments  
  
 This error occurs when the expected number of type arguments was not found. To resolve C0305, use the required number of type arguments.  
  
## Example  
 The following sample generates CS0305.  
  
```  
// CS0305.cs  
public class MyList<T> {}  
public class MyClass<T> {}  
  
class MyClass  
{  
   public static void Main()  
   {  
      MyList<MyClass, MyClass> list1 = new MyList<MyClass>();   // CS0305  
      MyList<MyClass> list2 = new MyList<MyClass>();   // OK  
   }  
}  
```