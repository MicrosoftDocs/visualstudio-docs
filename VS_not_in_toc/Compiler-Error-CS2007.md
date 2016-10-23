---
title: "Compiler Error CS2007"
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
ms.assetid: 9be20e8e-2424-4435-9371-778fb12823c0
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
# Compiler Error CS2007
Unrecognized command-line option: 'option'  
  
 The compiler was passed a string that was not a [compiler option](../Topic/C%23%20Compiler%20Options.md), even though it began with a forward slash (/).  
  
 The following sample generates CS2007:  
  
```  
// CS2007.cs  
// compile with: /recur  
// CS2007 expected  
class x  
{  
   public static void Main() {}  
}  
```