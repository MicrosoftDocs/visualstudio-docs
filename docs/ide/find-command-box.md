---
title: Find-Command Box
description: Learn about the Find/Command box and how you can use it to search for text and run Visual Studio commands.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
- vs.findcommandbox
helpviewer_keywords:
- Find/Command box
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Find/Command box

You can search for text and run Visual Studio commands from the **Find/Command** box. The **Find/Command** box is still available as a toolbar control, but is no longer visible by default. You can display the **Find/Command** box by choosing **Add or Remove Buttons** on the **Standard** toolbar and then choosing **Find**.

To run a [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] command, preface it with a greater than (**>**) sign.

The **Find/Command** box retains the last 20 items entered and displays them in a drop-down list. You can navigate through the list by choosing the **arrow keys**.

![Find&#47;Command Box](../ide/media/findcommandbox.png)

## Searching for text

By default, when you specify text in the **Find/Command** box and then choose the **Enter** key, Visual Studio searches the current document or tool window using the options that are specified in the **Find in Files** dialog box. For more information, see [Finding and replacing text](../ide/finding-and-replacing-text.md).

## Entering commands

To use the **Find/Command** box to issue a single [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] command or alias rather than search for text, preface the command with a greater than (**>**) symbol. For example:

```
>File.NewFile c:\temp\MyFile /t:"General\Text File"
```

Alternatively, you can also use the **Command** window to enter and execute single or multiple commands. Some commands or aliases can be entered and executed by themselves; others have required arguments in their syntax. For a list of commands that have arguments, see [Visual Studio commands](../ide/reference/visual-studio-commands.md).

## Escape characters

A caret (**^**) character in a command means that the character immediately following it is interpreted literally, rather than as a control character. This can be used to embed straight quotation marks (**"**), spaces, leading slashes, carets, or any other literal characters in a parameter or switch value, with the exception of switch names. For example:

```
>Edit.Find ^^t /regex
```

A caret functions the same whether it is inside or outside quotation marks. If a caret is the last character on the line, it is ignored.

## See also

- [Command window](../ide/reference/command-window.md)
- [Finding and replacing text](../ide/finding-and-replacing-text.md)
