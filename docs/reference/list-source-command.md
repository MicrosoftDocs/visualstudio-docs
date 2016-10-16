---
title: "List Source Command"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "Debug.ListSource"
helpviewer_keywords: 
  - "Debug.ListSource command"
  - "list source command"
  - "ListSource command"
ms.assetid: e45f08d2-f4a3-49c3-9452-aa60508e2f74
caps.latest.revision: 6
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# List Source Command
Displays the specified lines of source code.  
  
## Syntax  
  
```  
Debug.ListSource [/Count:number] [/Current] [/File:filename]  
[/Line:number] [/ShowLineNumbers:yes|no]  
```  
  
## Switches  
 /Count:`number`  
 Optional. Specifies the number of lines to display.  
  
 /Current  
 Optional. Shows the current line.  
  
 /File:`filename`  
 Optional. Path of the file to show. If no filename is specified, the command shows the source code for the line of the current statement.  
  
 /Line:`number`  
 Optional. Shows a specific line number.  
  
 /ShowLineNumbers:`yes|no`  
 Optional. Specifies whether to display line numbers.  
  
## Remarks  
  
## Example  
 This example lists the source code from line 4 of the file Form1.vb, with line numbers visible.  
  
```  
Debug.ListSource /File:"C:\Visual Studio Projects\Form1.vb" /Line:4 /ShowLineNumbers:yes  
```  
  
## See Also  
 [Visual Studio Commands](../reference/visual-studio-commands.md)   
 [Command Window](../reference/command-window.md)