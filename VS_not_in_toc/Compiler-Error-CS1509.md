---
title: "Compiler Error CS1509"
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
ms.assetid: 51a475c3-f085-49cb-89b0-c6582b68653f
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
# Compiler Error CS1509
Referenced file 'file' is not an assembly; use '/addmodule' option instead  
  
 An output file (output file 1), produced in a compilation that used [/target:module](../Topic/-target:module%20\(C%23%20Compiler%20Options\).md) (does not have an assembly manifest), was specified to [/reference](../Topic/-reference%20\(C%23%20Compiler%20Options\).md). So, rather than appending an assembly to the assembly for the current program, the metadata information in output file 1 will be added to the assembly for the current program.