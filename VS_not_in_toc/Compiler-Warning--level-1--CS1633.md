---
title: "Compiler Warning (level 1) CS1633"
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
ms.assetid: f31db218-f880-4fc4-ab34-8bcdc49011da
caps.latest.revision: 6
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
# Compiler Warning (level 1) CS1633
Unrecognized #pragma directive  
  
 The pragma used was not one of the known pragmas supported by the C# compiler. To resolve this error, use only pragmas supported.  
  
 The following sample generates CS1633:  
  
```  
// CS1633.cs  
// compile with: /W:1  
#pragma unknown  // CS1633  
  
class C  
{  
   public static void Main()  
   {  
   }  
}  
```