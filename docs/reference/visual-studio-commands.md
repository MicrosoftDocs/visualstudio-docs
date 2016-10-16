---
title: "Visual Studio Commands"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio, commands"
  - "commands, Visual Studio"
  - "command syntax"
ms.assetid: 76ffa394-ee89-4629-aba9-1a62b72e6cc1
caps.latest.revision: 16
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
# Visual Studio Commands
Visual Studio commands allow you to invoke a command from the **Command** window, **Immediate** window, or **Find/Command** box. In each case, the greater than sign (`>`) is used to indicate that a command rather than a search or debug operation is to follow.  
  
 You can find a complete list of commands and their syntax in the **Keyboard, Environment Options** dialog box.  
  
 The escape character for Visual Studio commands is a caret (^) character, which means that the character immediately following it is interpreted literally, rather than as a control character. This can be used to embed straight quotation marks ("), spaces, leading slashes, carets, or any other literal characters in a parameter or switch value, with the exception of switch names. For example,  
  
```  
>Edit.Find ^^t /regex  
```  
  
 A caret functions the same whether it is inside or outside quotation marks. If a caret is the last character on the line, it is ignored.  
  
 In localized versions of the IDE, command names can be entered either in the native language of the IDE or in English. For example, you can type either `File.NewFile` or `Fichier.NouveauFichier` in the French IDE to execute the same command.  
  
 Many commands have aliases. For a list of command aliases, see [Visual Studio Command Aliases](../reference/visual-studio-command-aliases.md).  
  
 The following commands take arguments and/or switches.  
  
|Command Name|Description|  
|------------------|-----------------|  
|[Add Existing Item](../reference/add-existing-item-command.md)|Adds an existing file to the current solution and opens it.|  
|[Add Existing Project](../reference/add-existing-project-command.md)|Adds an existing project to the current solution.|  
|[Add New Item](../reference/add-new-item-command.md)|Adds a new solution item, such as an .htm, .css, .txt, or frameset to the current solution and opens it.|  
|[Alias](../reference/alias-command.md)|Creates a new alias for a complete command, complete command and arguments, or even another alias.|  
|[Evaluate Statement](../reference/evaluate-statement-command.md)|Evaluates and displays the given statement.|  
|[Find](../reference/find-command.md)|Searches files using a subset of the options available on the **Find and Replace** control.|  
|[Find in Files](../reference/find-in-files-command.md)|Searches files using a subset of the options available on the [Find in Files](../ide/find-in-files.md).|  
|[Go To](../reference/go-to-command.md)|Moves the cursor to the specified line.|  
|[List Call Stack](../reference/list-call-stack-command.md)|Displays the current call stack.|  
|[List Disassembly](../reference/list-disassembly-command.md)|Begins the debug process and allows you to specify how errors are handled.|  
|[List Memory](../reference/list-memory-command.md)|Displays the contents of the specified range of memory.|  
|[List Modules](../reference/list-modules-command.md)|Lists the modules for the current process.|  
|[List Registers](../reference/list-registers-command.md)|Displays a list of registers.|  
|[List Source](../reference/list-source-command.md)|Displays the specified lines of source code.|  
|[List Threads](../reference/list-threads-command.md)|Displays a list of the threads in the current program.|  
|[Log Command Window Output](../reference/log-command-window-output-command.md)|Copies all input and output from the Command window into a file.|  
|[New File](../reference/new-file-command.md)|Creates a new file and adds it to the currently selected project.|  
|[Open File](../reference/open-file-command.md)|Opens an existing file and allows you to specify an editor.|  
|[Open Project](../reference/open-project-command.md)|Opens an existing project and allows you to add the project to the current solution.|  
|[Open Solution](../reference/open-solution-command.md)|Opens an existing solution.|  
|[Print](../reference/print-command.md)|Evaluates the expression and displays the results or the specified text.|  
|[Quick Watch Command](../reference/quick-watch-command.md)|Displays the selected or specified text in the **Expression** field of the **Quick Watch** dialog box.|  
|[Replace](../reference/replace-command.md)|Replaces text in files using a subset of the options available on the **Find and Replace** control.|  
|[Replace in Files](../reference/replace-in-files-command.md)|Replaces text in files using a subset of the options available in the [Replace in Files](../ide/replace-in-files.md).|  
|[Set Current Stack Frame](../reference/set-current-stack-frame-command.md)|Allows you to view a particular stack frame.|  
|[Set Current Thread](../reference/set-current-thread-command.md)|Allows you to view a particular thread.|  
|[Set Radix](../reference/set-radix-command.md)|Determines the number of bytes to view.|  
|[Shell](../reference/shell-command.md)|Launches programs from within [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] as though the command has been executed from the command prompt.|  
|[ShowWebBrowser Command](../reference/showwebbrowser-command.md)|Displays the URL you specify in a Web browser window either within the integrated development environment (IDE) or external to the IDE.|  
|[Start](../reference/start-command.md)|Begins the debug process and allows you to specify how errors are handled.|  
|[Path](../reference/symbol-path-command.md)|Sets the list of directories for the debugger to search for symbols.|  
|[Toggle Breakpoint](../reference/toggle-breakpoint-command.md)|Turns the breakpoint either on or off, depending on its current state, at the current location in the file.|  
|[Watch Command](../reference/watch-command.md)|Creates and opens a specified instance of a **Watch** window.|  
  
## See Also  
 [Command Window](../reference/command-window.md)   
 [Find/Command Box](../ide/find-command-box.md)   
 [Visual Studio Command Aliases](../reference/visual-studio-command-aliases.md)