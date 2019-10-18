---
title: "Alias Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "tools.alias"
helpviewer_keywords: 
  - "aliases, Visual Studio commands"
  - "commands, aliases"
  - "Tools.Alias command"
  - "command aliases"
  - "alias command"
ms.assetid: bdf857df-b5d5-450f-8c10-a6fd4dccc130
caps.latest.revision: 19
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Alias Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Creates a new alias for a complete command, complete command and arguments, or another alias.  
  
> [!TIP]
> Typing `>alias` without any arguments displays the current list of aliases and their definitions.  
  
## Syntax  
  
```  
Tools.Alias [/delete] [/reset] [aliasname] [aliasstring]  
```  
  
## Arguments  
 `aliasname`  
 Optional. The name for the new alias. If no value is supplied for `aliasname`, a list of the current aliases and their definitions appears.  
  
 `aliasstring`  
 Optional. The complete command name or existing alias and any parameters that you want to create as an alias. If no value is supplied for `aliasstring`, the alias name and alias string for the specified alias displays.  
  
## Switches  
 /delete or /del or /d  
 Optional. Deletes the specified alias, removing it from autocompletion.  
  
 /reset  
 Optional. Resets the list of pre-defined aliases to its original settings. That is, it restores all pre-defined aliases and removes all user-defined aliases.  
  
## Remarks  
 Since aliases represent commands, they must be located at the beginning of the command line.  
  
 When issuing this command, you should include the switches immediately after the command, not after the aliases, otherwise the switch itself will be included as part of the alias string.  
  
 The `/reset` switch asks for a confirmation before the aliases are restored. There is no short form of `/reset`.  
  
## Examples  
 This example creates a new alias, `upper`, for the complete command Edit.MakeUpperCase.  
  
```  
>Tools.Alias upper Edit.MakeUpperCase  
```  
  
 This example deletes the alias, `upper`.  
  
```  
>Tools.alias /delete upper  
```  
  
 This example displays a list of all current aliases and definitions.  
  
```  
>Tools.Alias  
```  
  
## See also  
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)   
 [Command Window](../../ide/reference/command-window.md)   
 [Find/Command Box](../../ide/find-command-box.md)   
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
