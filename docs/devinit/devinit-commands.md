---
title: devinit Commands
description: Details on how to use devinit commands to install components. 
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
# devinit commands

## Init

```batch
> devinit init
```

Initialize the environment by running the tools specified in a [_.devinit.json_](devinit-json.md) file in the current working directory.  

### Options for init

Optional options for the `devinit init` command.

| Argument             | Required | Description                                                               |
|----------------------|----------|---------------------------------------------------------------------------|
| -f, --file           | No       | Path to the _.devinit.json_ file.                                         |
| --error-action       | No       | Specifies how to handle errors. Options: Stop, Ignore, Continue (default). |
| -v,--verbose         | No       | Emit verbose output.                                                      |
| -n,--dry-run         | No       | Dry run.                                                                  |

## Run

```batch
> devinit run -t <toolname>
```

Runs the specific tool, parameters are listed below. See [documentation](devinit-tool-list.md) for each tool for specific usage.

### Options for run

Options for the `devinit run` command.

| Argument                                  | Required | Description                                                                          |
|--------------------------------|----------|--------------------------------------------------------------------------------------|
| -t,--tool                                 | Yes      | Required. The tool name.                                                             |
| -i,--input                                | No       | The tool input value. For example, a filename, package, or name.                           |
| --error-action                            | No       | Specifies how to handle tool errors: Stop, Ignore, Continue. The default is to stop. |
| -v,--verbose                              | No       | Emit verbose output.                                                                 |
| -n,--dry-run                              | No       | Dry run.                                                                             |
| --&lt;arg1&gt; &lt;arg2&gt; &lt;argN&gt;  | No       | Additional command-line arguments to the tool.                                       |

#### Note on additional command line arguments

Using an `<arg>` that includes a space in its value must include an additional pair of escaped quotes.

```batch
> devinit run -t <toolname> -<somearg> "<some value>"
```

For installing dotnet into a specific directory `C:\Program Files\dotnet`:

```batch
> devinit run -t require-dotnetcoresdk --"-InstallDir \"C:\Program Files\dotnet\""
```

## List

```batch
> devinit list
```

Prints a list of all the available tools.

## Show

```batch
> devinit show -t <toolname>
```

| Argument       | Required | Description                                                                          |
|----------------|----------|--------------------------------------------------------------------------------------|
| -t,--tool      | Yes      | Required. The tool name.                                                             |

Prints help information for a given tool.

## Version

```batch
> devinit version
```

Prints the current version information for devinit.

## Help

```batch
> devinit help
> devinit help list
```

Prints the help text for devinit or for a specific command `devinit <command>`.
 