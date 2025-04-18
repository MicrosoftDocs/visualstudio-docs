---
title: "JSON002: Probable JSON string detected"
description: "Learn about code analysis rule JSON002: Probable JSON string detected"
ms.date: 03/07/2024
ms.topic: reference
f1_keywords:
- JSON002
helpviewer_keywords:
- JSON002
dev_langs:
- CSharp
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: jmartens
ms.subservice: general-ide
---
# Probable JSON string detected (JSON002)

| Property                 | Value                                         |
|--------------------------|-----------------------------------------------|
| **Rule ID**              | JSON002                                       |
| **Title**                | Probable JSON string detected                 |
| **Category**             | Style                                         |
| **Subcategory**          | N/A                                           |
| **Applicable languages** | C#, Visual Basic                              |
| **Options**              | N/A                                           |

## Overview

This rule flags places where a JSON literal string is detected but is not explicitly identified. JSON is identified by using an inline comment or comment preceding the JSON string such as `//lang=json` or `//lang=json,strict`. The latter comment uses strict mode for JSON interpretation.

This rule may not be flagged in the editor if the JSON editor options are enabled in **Tools** > **Options** > **Text Editor** > **C#** | **Visual Basic** > **Advanced** > **JSON strings**.

This rule is IDE-only and not applicable for command-line scenarios.

## Options

This rule does not support any options. For options available to configure in the IDE when JSON is specified, see [Invalid JSON pattern (JSON001)](../reference/JSON001.md).

## Example

The following code snippet shows an example where a probable JSON string may be detected.

```csharp
// Code with violations
var v = """{ "pie": true, "cherry": [1, 2, 3] }""";

// Fixed code
// lang=json,strict
var v = """{ "pie": true, "cherry": [1, 2, 3] }""";

// Fixed code
var v = /*lang=json,strict*/ """{ "pie": true, "cherry": [1, 2, 3] }""";
```

## Suppress a warning

If you want to suppress only a single violation, add preprocessor directives to your source file to disable and then re-enable the rule.

```csharp
#pragma warning disable JSON002
// The code that's violating the rule is on this line.
#pragma warning restore JSON002
```

To disable the rule for a file, folder, or project, set its severity to `none` in the [configuration file](/dotnet/fundamentals/code-analysis/configuration-files).

```ini
[*.{cs,vb}]
dotnet_diagnostic.JSON002.severity = none
```

For more information, see [How to suppress code analysis warnings](/dotnet/fundamentals/code-analysis/suppress-warnings).

## See also

- [JSON001](../reference/JSON001.md)