---
title: devinit Configuration File
description: Documentation for the .devinit.json manifest file for devinit.
ms.date: 11/02/2020
ms.topic: reference
author: andysterland
ms.author: andster
manager: jmartens
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# devinit configuration file

> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

The `.devinit.json` file defines the system-wide dependencies that your application needs in order to run and build. System-wide dependencies are things like Node.js, SQL Server, IIS, RabbitMQ, Docker, etc. These are the sort of things you would normally install on your dev box that aren't installed by a specific repo. It's not a place to define application-specific dependencies like you would in package managers such as NuGet or NPM. It is, however, a place to define that you need those package managers.

## File location

The `devinit init` command is driven via the `.devinit.json` file. By default, `devinit` looks for the file in the following locations:

* {current-directory}\\.devinit.json
* {current-directory}\\devinit.json
* {current-directory}\\.devinit\\.devinit.json
* {current-directory}\\.devinit\\devinit.json
* {current-directory}\\devinit\\.devinit.json
* {current-directory}\\devinit\\devinit.json
* {current-directory}\\.devcontainer\\.devinit.json
* {current-directory}\\.devcontainer\\devinit.json

> [!NOTE]
> If multiple default files are found, then devinit will use the file that appears first in the above list.

The `.devinit.json` file can also be specified explicitly via the `--file`/`-f` option.

### Directories and relative paths

Paths are relative to the location where devinit is running. This is typically the current working directory from which `devinit` was executed.

## File Format
In a `.devinit.json`, you can specify more than one tool to run. In the `run` section, you can put any number of objects. An example of this is seen in our sample [.devinit.json](sample-all-tool.md) with all of our tools.

```json
{
    "$schema": "https://json.schemastore.org/devinit.schema-3.0",
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

For more examples of using devinit, see the [Samples section](sample-readme.md).
