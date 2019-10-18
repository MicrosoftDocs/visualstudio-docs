---
title: "Print Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "debug.print"
helpviewer_keywords:
  - "Debug.Print command"
  - "Print method"
  - "Print command"
ms.assetid: 0412d381-590a-483f-bab4-6e1cca095645
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# Print Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Evaluates an expression, or displays specified text.

## Syntax

```
Debug.Print text
```

## Arguments
 `text`
 Required. The expression to evaluate or the text to display.

## Remarks
 You can use the question mark (?) as an alias for this command. So, for example, the command

```
>Debug.Print expA
```

 can also be written

```
>? expA
```

 Both versions of this command will return the current value of the expression `expA`.

## Example

```
>Debug.Print varA
```

## See Also
 [Evaluate Statement Command](../../ide/reference/evaluate-statement-command.md)
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
 [Command Window](../../ide/reference/command-window.md)
 [Find/Command Box](../../ide/find-command-box.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
