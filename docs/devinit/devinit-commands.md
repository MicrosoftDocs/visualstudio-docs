---
title: devinit Commands
description: Details on how to use devinit commands to install components. 
ms.date: 08/28/2020
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
> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

# devinit commands

## Init

```console
devinit init
```

Initialize the environment by running the tools specified in a [.devinit.json](devinit-json.md) file.

### Options for init

Optional options for the `devinit init` command.

| Argument             | Required | Description                                                               |
|----------------------|----------|---------------------------------------------------------------------------|
| -f,--file            | No       | Path to the `.devinit.json` file.                                         |
| --error-action       | No       | Specifies how to handle errors. Options: Stop, Ignore, Continue (default).|
| -v,--verbose         | No       | Emit verbose output.                                                      |
| -n,--dry-run         | No       | Dry run.                                                                  |

#### --file argument

Specifies the path to the _devinit.json_ file. If --file is not specified, we search for a default file in the following locations:

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

#### --error-action argument

See [below](#options-for-run).

#### --verbose switch

See [below](#options-for-run).

#### --dry-run switch

See [below](#options-for-run).

## Run

```console
devinit run -t <toolname>
```

Runs the specific tool, parameters are listed below. See [documentation](devinit-tool-list.md) for each tool for specific usage.

### Options for run

Options for the `devinit run` command.

| Argument                                      | Required | Description                                                                          |
|-----------------------------------------------|----------|--------------------------------------------------------------------------------------|
| -t,--tool                                     | Yes      | Required. The tool name.                                                             |
| -i,--input                                    | No       | The tool input value. For example, a filename, package, or name.                     |
| --error-action                                | No       | Specifies how to handle tool errors: Stop, Ignore, Continue. The default is to stop. |
| -v,--verbose                                  | No       | Emit verbose output.                                                                 |
| -n,--dry-run                                  | No       | Dry run.                                                                             |
| --&lt;arg1&gt; &lt;arg2&gt; ... &lt;argN&gt;  | No       | Additional command-line arguments to the tool.                                       |

#### --error-action argument

Specifies the action to take if a tool returns a non-zero exit code. The valid values are:

| Argument | Description                                                                                                                                                                                                                                                                           |
|----------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| continue | Continue processing other tools after emitting an error to standard error. The devinit.exe exit code is non-zero (failure). This behavior is similar to the Stop error action, but processing is continued. `continue` is the default error-action for the init command.              |
| ignore   | Continue processing other tools after emitting a warning to standard output. DevInit process exit code should always be zero (success). The `ignore` setting ignores all errors.                                                                                                      |
| stop     | Emits an error to standard error and stops processing tools. The devinit.exe exit code is non-zero (failure). This is similar to the continue error action, but processing is halted at the first error encountered. `stop` is the default error-action for all commands except init. |

#### --dry-run switch

Echo tool commands that would be run. Some tools may take further action as documented for that tool. 

#### --verbose switch

Emit verbose output to standard output. If the tool to be executed supports a verbose option, propagate the verbose switch to the tool.

#### --dry-run switch

Echo tool commands that would be run, but do not execute any tools.

#### Additional command-line arguments

Using an `<arg>` that includes a space in its value must include an additional pair of escaped quotes.

```console
devinit run -t <toolname> -<somearg> "<some value>"
```

For installing dotnet into a specific directory `C:\Program Files\dotnet`:

```console
devinit run -t require-dotnetcoresdk --"-InstallDir \"C:\Program Files\dotnet\""
```

## List

```console
devinit list
```

Prints a list of all the available tools.

## Show

```console
devinit show -t <toolname>
```

| Argument       | Required | Description                                                                          |
|----------------|----------|--------------------------------------------------------------------------------------|
| -t,--tool      | Yes      | Required. The tool name.                                                             |

Prints help information for a given tool.

## Version

```console
devinit version
```

Prints the current version information for devinit.

## Help

```console
devinit help
devinit help list
```

Prints the help text for devinit or for a specific command `devinit <command>`.
 
