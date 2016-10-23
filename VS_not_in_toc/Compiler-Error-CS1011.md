---
title: "Compiler Error CS1011"
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
ms.assetid: d4568471-b0f8-4c24-89f3-9c543521d1d8
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
# Compiler Error CS1011
Empty character literal  
  
 A [char](../Topic/char%20\(C%23%20Reference\).md) was declared and initialized to a null. The initialization of a `char` must specify a character.  
  
 The following sample generates CS1011:  
  
```  
// CS1011.cs  
class Sample  
{  
   public char CharField = '';   // CS1011  
}  
```