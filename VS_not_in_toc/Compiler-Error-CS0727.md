---
title: "Compiler Error CS0727"
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
ms.assetid: 54bfb87e-d759-4310-a8ab-02dccd06337c
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
# Compiler Error CS0727
Invalid format specifier  
  
 This error occurs in the debugger. When you type a variable name into one of the debugger windows, you can follow it with a comma, and then a format specifier. Examples are: myInt, h; or myString,nq. This error arises when the compiler is completely unable to parse what you typed in. To resolve this error, retype the variable name, optionally followed by a comma and a [valid Format Specifier](../VS_debugger/Format-Specifiers-in-C#.md).