---
title: devinit Configuration File
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# devinit Configuration File

## File Location

The `devinit.exe init` command is driven via the `.devinit.json` file. By default, `devinit.exe` looks for the file in the following locations:

- `{current-directory}\\.devinit.json`
- `{current-directory}\\.devinit\devinit.json`

The `.devinit` file can also be specified explicitly via the `--file` option.

### Directories and Relative Paths

Paths are relative to the location where `devinit.exe` is running. Typically the current working directory from which `devinit.exe` was executed.

## File Format

```json
{
    "$schema": "http://schemas.codespaces.visualstudio.com/devinit/v1",
    "comments": "string",
    "run": [
        {
            "comments": "string",
            "tool": "string",
            "input": "string|null|undefined",
            "additionalOptions": "string|null|undefined"
        }
    ]
}
```

### Property Values

| Name         | Type   | Required | Value                             |
|--------------|--------|----------|-----------------------------------|
| **comments** | string | No       | Comments for the file.            |
| **run**      | array  | Yes      | [RunTool object](#RunTool-object) |

#### Run Tool object

| Name                  | Type   | Required | Value                                                                                                      |
|-----------------------|--------|----------|------------------------------------------------------------------------------------------------------------|
| **comments**          | string | No       | Comments for the tool entry.                                                                               |
| **tool**              | string | Yes      | The tool name. See the `devinit.exe list` command for a listing of available tools.                        |
| **input**             | string | No       | The tool input. Varies by tool. For example, the required version, the package ID, the filename, or folder.|
| **additionalOptions** | string | No       | Additional command-line arguments to be passed to the tool.                                                |

## Examples

For more examples of using `devinit`, see the [Samples section](/samples).