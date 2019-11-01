---
title: "List Memory Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "debug.listmemory"
helpviewer_keywords:
  - "Debug.ListMemory command"
  - "ListMemory command"
  - "list memory command"
ms.assetid: a84de361-a6a6-4f6d-96aa-a0d4a424371e
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: jillfra
---
# List Memory Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Displays the contents of the specified range of memory.

## Syntax

```
Debug.ListMemory [/ANSI|Unicode] [/Count:number] [/Format:formattype]
[/Hex|Signed|Unsigned] [expression]
```

## Arguments
 `expression`
 Optional. The memory address from which to begin displaying memory.

## Switches
 /ANSI&#124;Unicode
 Optional. Display the memory as characters corresponding to the bytes of memory, either ANSI or Unicode.

 /Count:`number`
 Optional. Determines how many bytes of memory to display, starting at `expression`.

 /Format:`formattype`
 Optional. Format type for viewing memory information in the **Memory** window; may be OneByte, TwoBytes, FourBytes, EightBytes, Float (32-bit), or Double (64-bit). If OneByte is used, `/Unicode` is unavailable.

 /Hex&#124;Signed&#124;Unsigned
 Optional. Specifies the format for viewing numbers: as signed, unsigned, or hexadecimal.

## Remarks
 Instead of writing out a complete **Debug.ListMemory** command with all switches, you can invoke the command using predefined aliases with certain switches preset to specified values. For example, instead of entering:

```
>Debug.ListMemory /Format:float /Count:30 /Unicode
```

 you can write:

```
>df /Count:30 /Unicode
```

 Here is a list of the available aliases for the **Debug.ListMemory** command:

|Alias|Command and Switches|
|-----------|--------------------------|
|**d**|Debug.ListMemory|
|**da**|Debug.ListMemory /Ansi|
|**db**|Debug.ListMemory /Format:OneByte|
|**dc**|Debug.ListMemory /Format:FourBytes /Ansi|
|**dd**|Debug.ListMemory /Format:FourBytes|
|**df**|Debug.ListMemory /Format:Float|
|**dq**|Debug.ListMemory /Format:EightBytes|
|**du**|Debug.ListMemory /Unicode|

## Example

```
>Debug.ListMemory /Format:float /Count:30 /Unicode
```

## See Also
 [List Call Stack Command](../../ide/reference/list-call-stack-command.md)
 [List Threads Command](../../ide/reference/list-threads-command.md)
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
 [Command Window](../../ide/reference/command-window.md)
 [Find/Command Box](../../ide/find-command-box.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
