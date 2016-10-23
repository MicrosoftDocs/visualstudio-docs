---
title: "Compiler Error CS0041"
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
ms.assetid: 80dbfe00-8cdb-4275-9574-8a215c7139d6
caps.latest.revision: 16
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
# Compiler Error CS0041
The fully qualified name for 'type' is too long for debug information. Compile without '/debug' option.  
  
 This error can occur when using the [/debug](../Topic/-debug%20\(C%23%20Compiler%20Options\).md) compiler option. If you encounter this error, try to delete the PDB files in the bin directory and recompiling. If you are still encountering this error, you may have to repair or reinstall Visual Studio.