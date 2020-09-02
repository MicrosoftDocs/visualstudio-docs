---
title: devinit Commands
description: Details on how to use devinit commands to install components. 
ms.date: 08/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# devinit Commands

## Init
```batch
> devinit init
```
Initialize the environment by running the tools specified in a [`.devinit.json`](devinit-json) file in the current working directory.  

### Options
Optional options for the `devinit init` command.

| Argument     | Required | Description                       |
|--------------|----------|-----------------------------------|
| **--File**   | No       | Path to the `.devinit.json` file. |

## Run
```batch
> devinit run <toolname>
```
Runs the specific tool, optional parameters are listed below. See [documentation](devinit-tool-list) for each tool for specific usage.

### Options
Options for the `devinit run` command.
| Argument          | Required | Description                                                                           |   |
|-------------------|----------|---------------------------------------------------------------------------------------|---|
|-t,--tool         | Yes      | Required. The tool name.                                                              |   |
|-i,--input        | No       | The tool input value. For example, filename, package name.                            |   |
|--error-action     | No       | Specifies how to handle tool errors: Stop, Ignore, Continue. The default is to stop.  |   |
|-v,--verbose      | No       | Emit verbose output.                                                                  |   |
|-n,--dry-run      | No       | Dry run.                                                                              |   |
|--&lt;arg&gt;      | No       | Additional command line arguments to the tool.                                        |   |

#### Note on additional command line arguments
Using an `<arg>` that includes a space in its value must include an additional pair of escaped quotes.
```batch
> devinit run -t <toolname> -- -<somearg> "\"<some value>\""
```
For installing `dotnet` into a specific directory `C:\Program Files\dotnet`:
```batch
> devinit run -t require-dotnetcoresdk -- -InstallDir "\"C:\Program Files\tool\""
```
For installing `dotnet` into a specific directory `C:\Workspace\dotnet`:
```batch
> devinit run -t require-dotnetcoresdk -- -InstallDir "C:\Workspace\dotnet"
```

## List
```batch
> devinit list
```
Prints a list of all the available tools.


## Version
```batch
> devinit version
```
Prints the current version information for `devinit`.

## Help
```batch
> devinit help 
> devinit help list
```
Prints the help text for `devinit` or for a specific command `devinit <command>`.


## Verbose Mode

```batch
> devinit <command> -v
> devinit <command> --verbose
```
Enable verbose logging for the command applicable to all commands.

