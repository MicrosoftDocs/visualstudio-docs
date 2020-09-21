---
title: devinit Configuration File
description: Documentation for the .devinit.json manifest file for devinit.
ms.date: 08/28/2020
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# devinit configuration file

## File location

The `devinit.exe init` command is driven via the _.devinit.json_ file. By default, `devinit.exe` looks for the file in the following locations:

- _{current-directory}\\_
- _{current-directory}\\.devinit\\_
- _{current-directory}\\.devcontainer\\_

The _._ in the directory and file names can be omitted.

The _.devinit.json_ file can also be specified explicitly via the `--file`/`-f` option.

### Directories and relative paths

Paths are relative to the location where devinit is running. This is typically the current working directory from which `devinit` was executed.

## File Format

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-2.0",
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

### Property values

| Name         | Type   | Required | Value                              |
|--------------|--------|----------|------------------------------------|
| **comments** | string | No       | Comments for the file.             |
| **run**      | array  | Yes      | [RunTool object](#run-tool-object) |

#### Run tool object

| Name                  | Type   | Required | Value                                                                                                      |
|-----------------------|--------|----------|------------------------------------------------------------------------------------------------------------|
| **comments**          | string | No       | Comments for the tool entry.                                                                               |
| **tool**              | string | Yes      | The tool name. See the `devinit list` command for a listing of available tools.                            |
| **input**             | string | No       | The tool input. Varies by tool. For example, the required version, the package ID, the filename, or folder.|
| **additionalOptions** | string | No       | Additional command-line arguments to be passed to the tool.                                                |

## Examples

For more examples of using devinit, see the [Samples section](samples.md).
