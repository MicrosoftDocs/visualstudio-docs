---
title: "Visual Studio Commands"
ms.custom: na
ms.date: 10/06/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 76ffa394-ee89-4629-aba9-1a62b72e6cc1
caps.latest.revision: 16
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
# Visual Studio Commands
Visual Studio commands allow you to invoke a command from the **Command** window, **Immediate** window, or **Find/Command** box. In each case, the greater than sign (`>`) is used to indicate that a command rather than a search or debug operation is to follow.  
  
 You can find a complete list of commands and their syntax in the **Keyboard, Environment Options** dialog box.  
  
 The escape character for Visual Studio commands is a caret (^) character, which means that the character immediately following it is interpreted literally, rather than as a control character. This can be used to embed straight quotation marks ("), spaces, leading slashes, carets, or any other literal characters in a parameter or switch value, with the exception of switch names. For example,  
  
```  
>Edit.Find ^^t /regex  
```  
  
 A caret functions the same whether it is inside or outside quotation marks. If a caret is the last character on the line, it is ignored.  
  
 In localized versions of the IDE, command names can be entered either in the native language of the IDE or in English. For example, you can type either `File.NewFile` or `Fichier.NouveauFichier` in the French IDE to execute the same command.  
  
 Many commands have aliases. For a list of command aliases, see [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md).  
  
 The following commands take arguments and/or switches.  
  
|Command Name|Description|  
|------------------|-----------------|  
|[Add Existing Item](../VS_IDE/Add-Existing-Item-Command.md)|Adds an existing file to the current solution and opens it.|  
|[Add Existing Project](../VS_IDE/Add-Existing-Project-Command.md)|Adds an existing project to the current solution.|  
|[Add New Item](../VS_IDE/Add-New-Item-Command.md)|Adds a new solution item, such as an .htm, .css, .txt, or frameset to the current solution and opens it.|  
|[Alias](../VS_IDE/Alias-Command.md)|Creates a new alias for a complete command, complete command and arguments, or even another alias.|  
|[Evaluate Statement](../VS_IDE/Evaluate-Statement-Command.md)|Evaluates and displays the given statement.|  
|[Find](../VS_IDE/Find-Command.md)|Searches files using a subset of the options available on the **Find and Replace** control.|  
|[Find in Files](../VS_IDE/Find-in-Files-Command.md)|Searches files using a subset of the options available on the [Find in Files](../VS_IDE/Find-in-Files.md).|  
|[Go To](../VS_IDE/Go-To-Command.md)|Moves the cursor to the specified line.|  
|[List Call Stack](../VS_IDE/List-Call-Stack-Command.md)|Displays the current call stack.|  
|[List Disassembly](../VS_IDE/List-Disassembly-Command.md)|Begins the debug process and allows you to specify how errors are handled.|  
|[List Memory](../VS_IDE/List-Memory-Command.md)|Displays the contents of the specified range of memory.|  
|[List Modules](../VS_IDE/List-Modules-Command.md)|Lists the modules for the current process.|  
|[List Registers](../VS_IDE/List-Registers-Command.md)|Displays a list of registers.|  
|[List Source](../VS_IDE/List-Source-Command.md)|Displays the specified lines of source code.|  
|[List Threads](../VS_IDE/List-Threads-Command.md)|Displays a list of the threads in the current program.|  
|[Log Command Window Output](../VS_IDE/Log-Command-Window-Output-Command.md)|Copies all input and output from the Command window into a file.|  
|[New File](../VS_IDE/New-File-Command.md)|Creates a new file and adds it to the currently selected project.|  
|[Open File](../VS_IDE/Open-File-Command.md)|Opens an existing file and allows you to specify an editor.|  
|[Open Project](../VS_IDE/Open-Project-Command.md)|Opens an existing project and allows you to add the project to the current solution.|  
|[Open Solution](../VS_IDE/Open-Solution-Command.md)|Opens an existing solution.|  
|[Print](../VS_IDE/Print-Command.md)|Evaluates the expression and displays the results or the specified text.|  
|[Quick Watch Command](../VS_IDE/Quick-Watch-Command.md)|Displays the selected or specified text in the **Expression** field of the **Quick Watch** dialog box.|  
|[Replace](../VS_IDE/Replace-Command.md)|Replaces text in files using a subset of the options available on the **Find and Replace** control.|  
|[Replace in Files](../VS_IDE/Replace-In-Files-Command.md)|Replaces text in files using a subset of the options available in the [Replace in Files](../VS_IDE/Replace-in-Files.md).|  
|[Set Current Stack Frame](../VS_IDE/Set-Current-Stack-Frame-Command.md)|Allows you to view a particular stack frame.|  
|[Set Current Thread](../VS_IDE/Set-Current-Thread-Command.md)|Allows you to view a particular thread.|  
|[Set Radix](../VS_IDE/Set-Radix-Command.md)|Determines the number of bytes to view.|  
|[Shell](../VS_IDE/Shell-Command.md)|Launches programs from within Visual Studio as though the command has been executed from the command prompt.|  
|[ShowWebBrowser Command](../VS_IDE/ShowWebBrowser-Command.md)|Displays the URL you specify in a Web browser window either within the integrated development environment (IDE) or external to the IDE.|  
|[Start](../VS_IDE/Start-Command.md)|Begins the debug process and allows you to specify how errors are handled.|  
|[Path](../VS_IDE/Symbol-Path-Command.md)|Sets the list of directories for the debugger to search for symbols.|  
|[Toggle Breakpoint](../VS_IDE/Toggle-Breakpoint-Command.md)|Turns the breakpoint either on or off, depending on its current state, at the current location in the file.|  
|[Watch Command](../VS_IDE/Watch-Command.md)|Creates and opens a specified instance of a **Watch** window.|  
  
## See Also  
 [Command Window](../VS_IDE/Command-Window.md)   
 [Find/Command Box](../VS_IDE/Find-Command-Box.md)   
 [Visual Studio Command Aliases](../VS_IDE/Visual-Studio-Command-Aliases.md)