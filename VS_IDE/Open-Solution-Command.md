---
title: "Open Solution Command"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 61de76c8-69d7-4cdb-b605-e132f45d05d9
caps.latest.revision: 10
manager: ghogen
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
# Open Solution Command
Opens an existing solution, closing any other open solutions.  
  
## Syntax  
  
```  
File.OpenSolution filename  
```  
  
## Arguments  
 `Filename`  
 Required. The full path and file name of the solution to open.  
  
 The syntax for the `filename` argument requires that paths containing spaces use quotation marks.  
  
## Remarks  
 Auto completion tries to locate the correct path and file name as you type.  
  
## Example  
 This example opens the solution, Test1.sln.  
  
```  
>File.OpenSolution "c:\MySolutions\Test1\Test1.sln"  
```  
  
## See Also  
 [Visual Studio Commands](../VS_IDE/Visual-Studio-Commands.md)   
 [Command Window](../VS_IDE/Command-Window.md)   
 [Find/Command Box](../VS_IDE/Find-Command-Box.md)   
 [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md)