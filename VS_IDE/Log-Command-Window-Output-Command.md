---
title: "Log Command Window Output Command"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d4ecec35-5af4-4954-8d60-2cd24583fbb4
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
# Log Command Window Output Command
Copies all input and output from the **Command** window into a file.  
  
## Syntax  
  
```  
Tools.LogCommandWindowOutput [filename] [/on|/off] [/overwrite]  
```  
  
## Arguments  
 `filename`  
 Optional. The name of the log file. By default, the file is created in the user's profile folder. If the file name already exists, the log is appended to the end of the existing file. If no file is specified, the last file specified is used. If no previous file exists, a default log file is created, called cmdline.log.  
  
> [!TIP]
>  To change the location where the log file is saved, enter the full path of the file, surrounded by quotation marks if the path contains any spaces.  
  
## Switches  
 /on  
 Optional. Starts the log for the **Command** window in the specified file and appends the file with the new information.  
  
 /off  
 Optional. Stops the log for the **Command** window.  
  
 /overwrite  
 Optional. If the file specified in the `filename` argument matches an existing file, the file is overwritten.  
  
## Remarks  
 If no file is specified, the file cmdline.log is created by default. By default, the alias for this command is Log.  
  
## Examples  
 This example creates a new log file, cmdlog, and starts the command log.  
  
```  
>Tools.LogCommandWindowOutput cmdlog  
```  
  
 This example stops logging commands.  
  
```  
>Tools.LogCommandWindowOutput /off  
```  
  
 This example resumes the logging of commands in the previously used log file.  
  
```  
>Tools.LogCommandWindowOutput /on  
```  
  
## See Also  
 [Visual Studio Commands](../VS_IDE/Visual-Studio-Commands.md)   
 [Command Window](../VS_IDE/Command-Window.md)   
 [Find/Command Box](../VS_IDE/Find-Command-Box.md)   
 [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md)