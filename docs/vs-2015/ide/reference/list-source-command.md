---
title: "List Source Command | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "Debug.ListSource"
helpviewer_keywords: 
  - "Debug.ListSource command"
  - "list source command"
  - "ListSource command"
ms.assetid: e45f08d2-f4a3-49c3-9452-aa60508e2f74
caps.latest.revision: 13
author: gewarren
ms.author: gewarren
manager: "ghogen"
---
# List Source Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [List Source Command](https://docs.microsoft.com/visualstudio/ide/reference/list-source-command).  
  
  
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
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)   
 [Command Window](../../ide/reference/command-window.md)



