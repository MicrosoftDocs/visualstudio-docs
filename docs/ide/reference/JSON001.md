---
title: "JSON001: Invalid JSON pattern"
description: "Learn about code analysis rule JSON001: Invalid JSON pattern"
ms.date: 03/07/2024
f1_keywords:
- JSON001
helpviewer_keywords:
- JSON001
dev_langs:
- CSharp
---
# Invalid JSON pattern (JSON001)

| Property                 | Value                                         |
|--------------------------|-----------------------------------------------|
| **Rule ID**              | JSON001                                       |
| **Title**                | Invalid JSON pattern                          |
| **Category**             | Style                                         |
| **Subcategory**          | N/A                                           |
| **Applicable languages** | C#, Visual Basic                              |
| **Options**              | N/A                               |

## Overview

This rule flags places where JSON does not conform to required format. The rule applies to recognized JSON, which is determined by the inclusion of a comment preceding the JSON string, either `//lang=json` or `//lang=json,strict`. The latter comment uses strict mode for JSON interpretation.

This rule is IDE-only and not applicable for command-line scenarios.

## Options

Options specify the behavior that you want the rule to enforce.

For recognized JSON, you set the options in Visual Studio by selecting **Tools** > **Options** > **Text Editor** > **C#** > **Advanced**. The following options are available:

| Property                                      | Description                                   |
|-----------------------------------------------|-----------------------------------------------|
| **Colorize JSON strings**                     | Specifies whether to colorize JSON strings.   |
| **Report invalid JSON**                       | Specifies whether to report invalid JSON.     |
| **Highlight related components under cursor** | Specifies whether highlighting is applied      |

## Example

The following code snippet shows an example with invalid JSON.

```csharp
// Code with violations
// lang=json,strict
var v = """{ "foo": true, "bar": [1, 2, 3 }""";

// Fixed code
// lang=json,strict
var v = """{ "foo": true, "bar": [1, 2, 3] }""";

// Code with violations
//lang=json,strict
var v = """
{
   "foo": true, 
   // Comments not allowed in strict mode
   "bar": [1, 2, 3]
}
""";

// Fixed code
//lang=json
var v = """
{
   "foo": true, 
   // Comments allowed if not using strict mode
   "bar": [1, 2, 3]
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

To disable the rule for a file, folder, or project, set its severity to `none` in the [configuration file](../configuration-files.md).

```ini
[*.{cs,vb}]
dotnet_diagnostic.JSON001.severity = none
```

For more information, see [How to suppress code analysis warnings](../suppress-warnings.md).

## See also

- JSON002