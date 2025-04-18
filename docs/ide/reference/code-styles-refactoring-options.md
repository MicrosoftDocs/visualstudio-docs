---
title: .NET code refactoring options
description: Learn about the code-style options for refactoring .NET code.
ms.date: 08/18/2023
ms.topic: reference
dev_langs:
- CSharp
- VB
ms.custom: "ide-ref"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---

# .NET code refactoring options

The code refactoring options in this article apply to both C# and Visual Basic.

The options described in this article don't have a severity and don't appear in the Error List as warnings or suggestions. Instead, they're only used during a refactoring in Visual Studio.

For .NET code style rules that apply during build and refactoring, that is, those that have an ID of the form `IDEXXXX`, see [Code style rules](/dotnet/fundamentals/code-analysis/style-rules/).

Example *.editorconfig* file:

```ini
# .NET formatting rules
[*.{cs,vb}]
dotnet_style_operator_placement_when_wrapping = end_of_line
```

## dotnet\_style\_operator\_placement\_when_wrapping

Use this option to customize how you want operators placed when wrapping lines of code during a refactor.

| Property                 | Value                                         | Description                                  |
|--------------------------|-----------------------------------------------|----------------------------------------------|
| **Option name**          | dotnet_style_operator_placement_when_wrapping |                                              |
| **Applicable languages** | C# and Visual Basic                           |                                              |
| **Introduced version**   | Visual Studio 2022                            |                                              |
| **Option values**        | `end_of_line`                                 | Place operator at the end of a line.         |
|                          | `beginning_of_line`                           | Place operator on a new line.                |
| **Default value**        | `beginning_of_line`                           |                                              |

Code examples:

```csharp
// dotnet_style_operator_placement_when_wrapping = end_of_line
if (true && 
    true)

// dotnet_style_operator_placement_when_wrapping = beginning_of_line
if (true
    && true)
```
