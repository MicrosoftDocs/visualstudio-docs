---
title: "Compiler Error CS1040"
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
ms.assetid: a988d665-ead5-489f-922d-ff2c4dd8a922
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
# Compiler Error CS1040
Preprocessor directives must appear as the first non-whitespace character on a line  
  
 A [preprocessor directive](../Topic/C%23%20Preprocessor%20Directives.md) was found on a line and was not the first token on the line. A directive must be the first token on the line.  
  
 The following sample generates CS1040:  
  
```  
// CS1040.cs  
/* Define a symbol, X */ #define X   // CS1040  
  
// try the following two lines instead  
// /* Define a symbol, X */  
// #define X  
  
public class MyClass  
{  
   public static void Main()  
   {  
   }  
}  
```