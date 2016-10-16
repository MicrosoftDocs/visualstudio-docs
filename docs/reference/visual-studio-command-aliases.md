---
title: "Visual Studio Command Aliases"
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
  - "aliases, Visual Studio commands"
  - "Visual Studio, commands"
  - "predefined command aliases"
  - "commands, aliases"
  - "Visual Studio commands"
  - "pre-defined command aliases"
  - "command aliases"
ms.assetid: de8bb378-8c1c-4087-a9a5-537fa8314c19
caps.latest.revision: 17
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Visual Studio Command Aliases
Aliases provide a means for entering a command into the **Find/Command** box or **Command** window by shortening the text needed to execute the command. For example, instead of entering `>File.OpenFile` to display the **Open File** dialog box, you can use the pre-defined alias `>of`.  
  
 Type `alias` in the **Command**window to display a list of the current aliases and their definitions. Type `>cls` to clear the contents of the **Command** window. If you want to see an alias for a specific command, type `alias <command name>`.  
  
 You can easily create your own alias for one of the Visual Studio commands (with or without arguments). For example, the syntax for aliasing `File.NewFile MyFile.txt` is `alias MyAlias File.NewFile MyFile.txt`. You can delete one of your aliases with `alias <alias name> /delete`  
  
 The table below contains a list of the pre-defined Visual Studio command aliases. Some command names have more than one pre-defined alias. Click the links for the command names below to display detailed topics that explain the correct syntax, arguments, and switches for those commands.  
  
|Command Name|Alias|Complete Name|  
|------------------|-----------|-------------------|  
|[Print Command](../reference/print-command.md)|?|Debug.Print|  
|[Quick Watch Command](../reference/quick-watch-command.md)|??|Debug.Quickwatch|  
|Add New Project|AddProj|File.AddNewProject|  
|[Alias Command](../reference/alias-command.md)|Alias|Tools.Alias|  
|Autos window|Autos|Debug.Autos|  
|Breakpoints window|bl|Debug.Breakpoints|  
|Toggle Breakpoint|bp|Debug.ToggleBreakPoint|  
|Call Stack window|CallStack|Debug.CallStack|  
|Clear Bookmarks|ClearBook|Edit.ClearBookmarks|  
|Close|Close|File.Close|  
|Close All Documents|CloseAll|Window.CloseAllDocuments|  
|Clear All|cls|Edit.ClearAll|  
|Command mode|cmd|View.CommandWindow|  
|View Code|code|View.ViewCode|  
|[List Memory Command](../reference/list-memory-command.md)|d|Debug.ListMemory|  
|[List Memory Command](../reference/list-memory-command.md) as ANSI|da|Debug.ListMemory /Ansi|  
|[List Memory Command](../reference/list-memory-command.md) One Byte format|db|Debug.ListMemory /Format:OneByte|  
|[List Memory Command](../reference/list-memory-command.md) as ANSI with Four Byte format|dc|Debug.ListMemory /Format:FourBytes /Ansi|  
|[List Memory Command](../reference/list-memory-command.md) Four Byte format|dd|Debug.ListMemory /Format:FourBytes|  
|Delete to BOL|DelBOL|Edit.DeleteToBOL|  
|Delete to EOL|DelEOL|Edit.DeleteToEOL|  
|Delete Horizontal Whitespace|DelHSp|Edit.DeleteHorizontalWhitespace|  
|View Designer|designer|View.ViewDesigner|  
|[List Memory Command](../reference/list-memory-command.md) Float format|df|Debug.ListMemory/Format:Float|  
|Disassembly window|disasm|Debug.Disassembly|  
|[List Memory Command](../reference/list-memory-command.md) Eight Byte format|dq|Debug.ListMemory /Format:EightBytes|  
|[List Memory Command](../reference/list-memory-command.md) as Unicode|du|Debug.ListMemory /Unicode|  
|[Evaluate Statement Command](../reference/evaluate-statement-command.md)|eval|Debug.EvaluateStatement|  
|Exit|Exit|File.Exit|  
|Format Selection|format|Edit.FormatSelection|  
|Full Screen|FullScreen|View.FullScreen|  
|[Start Command](../reference/start-command.md)|g|Debug.Start|  
|[Go To Command](../reference/go-to-command.md)|GotoLn|Edit.GoTo|  
|Go to Brace|GotoBrace|Edit.GotoBrace|  
|F1Help|Help|Help.F1Help|  
|Immediate Mode|immed|Tools.ImmediateMode|  
|Insert File as Text|InsertFile|Edit.InsertFileAsText|  
|[List Call Stack Command](../reference/list-call-stack-command.md)|kb|Debug.ListCallStack|  
|Make Lower Case|Lcase|Edit.MakeLowercase|  
|Cut Line|LineCut|Edit.LineCut|  
|Delete Line|LineDel|Edit.LineDelete|  
|List Members|ListMembers|Edit.ListMembers|  
|Locals window|Locals|Debug.Locals|  
|[Log Command Window Output Command](../reference/log-command-window-output-command.md)|Log|Tools.LogCommandWindowOutput|  
|Command Window Mark Mode|mark|Tools.CommandWindowMarkMode|  
|Memory window|Memory Memory1|Debug.Memory1|  
|Memory Window 2|Memory2|Debug.Memory2|  
|Memory Window 3|Memory3|Debug.Memory3|  
|Memory Window 4|Memory4|Debug.Memory4|  
|[Set Radix Command](../reference/set-radix-command.md)|n|Debug.SetRadix|  
|[ShowWebBrowser Command](../reference/showwebbrowser-command.md)|nav navigate|View.ShowWebBrowser|  
|Next Bookmark|NextBook|Edit.NextBookmark|  
|[New File Command](../reference/new-file-command.md)|nf|File.NewFile|  
|New Project|np NewProj|File.NewProject|  
|[Open File Command](../reference/open-file-command.md)|of Open|File.OpenFile|  
|[Open Project Command](../reference/open-project-command.md)|op|File.OpenProject|  
|Collapse to Definitions/Stop Outlining|OutlineDefs StopOutlining|Edit.CollapsetoDefinitions|  
|Step Over|p|Debug.StepOver|  
|Parameter Information|ParamInfo|Edit.ParameterInfo|  
|Step Out|pr|Debug.StepOut|  
|Previous Bookmark|PrevBook|Edit.PreviousBookmark|  
|Print File|print|File.Print|  
|Properties Window|props|View.PropertiesWindow|  
|Stop|q|Debug.StopDebugging|  
|Redo|redo|Edit.Redo|  
|Registers window|registers|Debug.Registers|  
|Run to Cursor|rtc|Debug.RunToCursor|  
|Save Selected Items|save|File.SaveSelectedItems|  
|Save All|SaveAll|File.SaveAll|  
|Save As|SaveAs|File.SaveSelectedItemsAs|  
|[Shell Command](../reference/shell-command.md)|shell|Tools.Shell|  
|Stop Find In Files|StopFind|Edit.FindInFiles /stop|  
|Swap Anchor|SwapAnchor|Edit.SwapAnchor|  
|Step Into|t|Debug.StepInto|  
|Tabify Selection|tabify|Edit.TabifySelection|  
|Tasklist window|TaskList|View.TaskList|  
|Threads window|Threads|Debug.Threads|  
|Tile Horizontally|TileH|Window.TileHorizontally|  
|Tile Vertically|TileV|Window.TileVertically|  
|Toggle Bookmark|ToggleBook|Edit.ToggleBookmark|  
|Toolbox window|toolbox|View.Toolbox|  
|[List Disassembly Command](../reference/list-disassembly-command.md)|u|Debug.ListDisassembly|  
|Make Uppercase|Ucase|Edit.MakeUppercase|  
|Undo|undo|Edit.Undo|  
|Untabify Selection|Untabify|Edit.UntabifySelection|  
|Watch window|Watch|Debug.WatchN|  
|Toggle Word Wrap|WordWrap|Edit.ToggleWordWrap|  
|List Processes|&#124;|Debug.ListProcesses|  
|[List Threads Command](../reference/list-threads-command.md)|~ ~*k ~\*kb|Debug.ListThreads Debug.ListTheads /AllThreads|  
  
## See Also  
 [Visual Studio Commands](../reference/visual-studio-commands.md)   
 [Command Window](../reference/command-window.md)   
 [Find/Command Box](../ide/find-command-box.md)