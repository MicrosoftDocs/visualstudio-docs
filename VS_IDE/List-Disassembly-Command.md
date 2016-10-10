---
title: "List Disassembly Command"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: eb363e35-e86a-4121-966f-991210c27e2a
caps.latest.revision: 13
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
# List Disassembly Command
Begins the debug process and allows you to specify how errors are handled.  
  
## Syntax  
  
```  
Debug.ListDisassembly [/count:number] [/endaddress:expression]  
[/codebytes:yes|no] [/source:yes|no] [/symbolnames:yes|no]  
[/linenumbers:yes|no]  
```  
  
## Switches  
 Each switch can be invoked using either its complete form or a short form.  
  
 /count: `number` [or] /c: `number` [or] /length: `number` [or] /l: `number`  
 Optional. Number of instructions to display. Default value is 8.  
  
 /endaddress: `expression` [or] /e: `expression`  
 Optional. Address at which to stop disassembly.  
  
 /codebytes:`yes`&#124;`no` [or] /bytes:`yes`&#124;`no` [or] /b:`yes`&#124;`no`  
 Optional. Indicates whether to display code bytes. Default value is `no`.  
  
 /source:`yes`&#124;`no` [or] /s:`yes`&#124;`no`  
 Optional. Indicates whether to display source code. Default value is `no`.  
  
 /symbolnames:`yes`&#124;`no` [or] /names:`yes`&#124;`no` [or] /n:`yes`&#124;`no`  
 Optional. Indicates whether to display symbols names. Default value is `yes`.  
  
 [/linenumbers:`yes`&#124;`no`]  
 Optional. Enables the viewing of line numbers associated with the source code. The /source switch must have a value of `yes` to use the /linenumbers switch.  
  
## Example  
  
```  
>Debug.ListDisassembly  
```  
  
## See Also  
 [List Call Stack Command](../VS_IDE/List-Call-Stack-Command.md)   
 [List Threads Command](../VS_IDE/List-Threads-Command.md)   
 [Visual Studio Commands](../VS_IDE/Visual-Studio-Commands.md)   
 [Command Window](../VS_IDE/Command-Window.md)   
 [Find/Command Box](../VS_IDE/Find-Command-Box.md)   
 [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md)