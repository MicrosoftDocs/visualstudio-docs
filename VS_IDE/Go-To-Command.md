---
title: "Go To Command"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 201e1dd2-6701-467d-8cc1-faec2ef20511
caps.latest.revision: 10
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Go To Command
Moves the cursor to the specified line.  
  
## Syntax  
  
```  
Edit.GoTo [linenumber]  
```  
  
## Arguments  
 `linenumber`  
 Optional. An integer representing the number of the line to go to.  
  
## Remarks  
 The line numbering begins at one. If the value of `linenumber` is less than one, the first line displays. If the value of `linenumber` is greater than the number of the last line, the last line displays.  
  
 If a value for `linenumber` is not specified, the **Go To Line** dialog box displays.  
  
 The alias for this command is GoToLn.  
  
## Example  
  
```  
>Edit.GoTo 125  
```  
  
## See Also  
 [Visual Studio Commands](../VS_IDE/Visual-Studio-Commands.md)   
 [Command Window](../VS_IDE/Command-Window.md)   
 [Find/Command Box](../VS_IDE/Find-Command-Box.md)   
 [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md)