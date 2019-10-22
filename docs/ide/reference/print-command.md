---
title: Debug.Print
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "debug.print"
helpviewer_keywords:
  - "Debug.Print command"
  - "Print method"
  - "Print command"
ms.assetid: 0412d381-590a-483f-bab4-6e1cca095645
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Print command

Evaluates an expression or displays specified text.

## Syntax

```cmd
>Debug.Print text
```

## Arguments

`text`

Required. The expression to evaluate or the text to display.

## Remarks

You can use the question mark (?) as an alias for this command. So, for example, the command

```cmd
>Debug.Print expA
```

can also be written as

```cmd
? expA
```

Both versions of this command return the current value of the expression `expA`.

## Example

```cmd
>Debug.Print DateTime.Now.Day
```

## See also

- [Evaluate Statement Command](../../ide/reference/evaluate-statement-command.md)
- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)