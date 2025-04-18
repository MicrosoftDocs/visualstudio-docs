---
title: "JSON001: Invalid JSON pattern"
description: "Learn about code analysis rule JSON001: Invalid JSON pattern"
ms.date: 03/07/2024
ms.topic: reference
f1_keywords:
- JSON001
helpviewer_keywords:
- JSON001
dev_langs:
- CSharp
ms.custom: "ide-ref"
author: Mikejo5000
ms.author: mikejo
manager: jmartens
ms.subservice: general-ide
---
# Invalid JSON pattern (JSON001)

| Property                 | Value                                         |
|--------------------------|-----------------------------------------------|
| **Rule ID**              | JSON001                                       |
| **Title**                | Invalid JSON pattern                          |
| **Category**             | Style                                         |
| **Subcategory**          | N/A                                           |
| **Applicable languages** | C#, Visual Basic                              |
| **Options**              | See [Options](#options) section.              |

## Overview

This rule flags places where a JSON literal string does not conform to required syntax. The rule applies to identified JSON, which is determined by the inclusion of an inline comment or comment preceding the JSON string, such as `//lang=json` or `//lang=json,strict`. The latter comment uses strict mode for JSON interpretation.

This rule is IDE-only and not applicable for command-line scenarios.

## Options

Options specify the behavior that you want the rule to enforce.

For code recognized as JSON, you set the options in Visual Studio by selecting **Tools** > **Options** > **Text Editor** > **C#** | **Visual Basic** > **Advanced**. The following options are available under the **JSON strings** section:

| Property                                      | Description                                           |
|-----------------------------------------------|-------------------------------------------------------|
| **Colorize JSON strings**                     | Specifies whether to colorize JSON strings.           |
| **Report invalid JSON**                       | Specifies whether to report invalid JSON.             |
| **Highlight related components under cursor** | Specifies whether [Quick Actions](../../ide/quick-actions.md)</br>uses highlighting.     |

## Example

The following code snippet shows an example with invalid JSON.

```csharp
// Code with violations
// lang=json,strict
var v = """{ "pie": true, "cherry": [1, 2, 3 }""";

// Fixed code
// lang=json,strict
var v = """{ "pie": true, "cherry": [1, 2, 3] }""";

// Code with violations
//lang=json,strict
var v = """
{
   "pie": true, 
   // Comments not allowed in strict mode
   "cherry": [1, 2, 3]
}
""";

// Fixed code
//lang=json
var v = """
{
   "pie": true, 
   // Comments allowed if not using strict mode
   "cherry": [1, 2, 3]
}
""";
```

## Suppress a warning

If you want to suppress only a single violation, add preprocessor directives to your source file to disable and then re-enable the rule.

```csharp
#pragma warning disable JSON001
// The code that's violating the rule is on this line.
#pragma warning restore JSON001
```

To disable the rule for a file, folder, or project, set its severity to `none` in the [configuration file](/dotnet/fundamentals/code-analysis/configuration-files).

```ini
[*.{cs,vb}]
dotnet_diagnostic.JSON001.severity = none
```

For more information, see [How to suppress code analysis warnings](/dotnet/fundamentals/code-analysis/suppress-warnings).

## See also

- [JSON002](../reference/JSON002.md)