---
title: "Compiler Error CS0448"
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
ms.assetid: f577ab4c-1c8c-4a10-80a8-9ba9f66c3d25
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
# Compiler Error CS0448
The return type for ++ or -- operator must be the containing type or derived from the containing type  
  
 When you override the `++` or `--` operators, they must return the same type as the containing type, or return a type that is derived from the containing type.  
  
## Example  
 The following sample generates CS0448.  
  
```  
// CS0448.cs  
class C5  
{  
   public static int operator ++(C5 c) { return null; }   // CS0448  
   public static C5 operator --(C5 c) { return null; }   // OK  
   public static void Main() {}  
}  
```  
  
## Example  
 The following sample generates CS0448.  
  
```  
// CS0448_b.cs  
public struct S  
{  
   public static S? operator ++(S s) { return new S(); }   // CS0448  
   public static S? operator --(S s) { return new S(); }   // CS0448  
}  
  
public struct T  
{  
// OK  
   public static T operator --(T t) { return new T(); }  
   public static T operator ++(T t) { return new T(); }  
  
   public static T? operator --(T? t) { return new T(); }  
   public static T? operator ++(T? t) { return new T(); }  
  
   public static void Main() {}  
}  
```