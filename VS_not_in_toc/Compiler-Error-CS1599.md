---
title: "Compiler Error CS1599"
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
ms.assetid: 4cdb282d-0f5d-459b-afc1-8980fbb22067
caps.latest.revision: 10
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
# Compiler Error CS1599
Method or delegate cannot return type 'type'  
  
 Some types in the .NET Framework class library, for example, <xref:System.TypedReference?qualifyHint=False>, <xref:System.RuntimeArgumentHandle?qualifyHint=False> and <xref:System.ArgIterator?qualifyHint=False> cannot be used as return types because they can potentially be used to perform unsafe operations.  
  
 The following sample generates CS1599:  
  
```  
// CS1599.cs  
using System;  
  
class MyClass  
{  
   public static void Main()  
   {  
   }  
  
   public TypedReference Test1()   // CS1599  
   {  
      return null;  
   }  
  
   public ArgIterator Test2()   // CS1599  
   {  
      return null;  
   }  
}  
```