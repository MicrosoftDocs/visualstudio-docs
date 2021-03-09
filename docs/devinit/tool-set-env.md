---
title: set-env
description: devinit tool require-set-env.
ms.date: 11/20/2020
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
# set-env

The `set-env` tool can be used to set environment variables for use in the current process. The environment variables are set only in the current process and will be used by other `devinit` tools if they run in that process.

This tool makes use of the .NET Core `Environment.SetEnvironment` API and has the same limitations as that API. For more information, please see the [documentation](/dotnet/api/system.environment.setenvironmentvariable?view=netcore-3.1&preserve-view=true) for `Environment.SetEnvironment`.

## Usage

| Name                                         | Type   | Required | Value                                                                       |
|----------------------------------------------|--------|----------|-----------------------------------------------------------------------------|
| **comments**                                 | string | No       | Optional comments property. Not used.                                       |
| [**input**](#input)                          | string | No       | The input to the tool. See [Input](#input) below for details.               |
| [**additionalOptions**](#additional-options) | string | No       | See [Additional options](#additional-options) below for details.            |

### Input

The `set-env` tool takes a single string as an input on the `input` property. The string should be formatted a string of semi-colon (;) delimited key value pairs (name=value) and four possible actions based on the value of the `input` property.

| Action       | Input            | Description                                                                                                                                                              | Example             |
|--------------|------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------|
| **list all** | empty or omitted | List all of the current environment variables.                                                                                                                           | `"input":""`        |
| **list one** | string           | List the value of a specific environment variable by name.                                                                                                               | `"input":"foo"`     |
| **add**      | string           | Sets the value of an environment variable as key value pair. Adds a new environment variable if not already present or set the value of an existing environment variable | `"input":"foo=bar"` |
| **delete**   | string           | Deletes an existing environment variable by passing in an empty value string.                                                                                            | `"input":"foo="`    |

An `input` string can contain an environment variable expansion for example `%userprofile%`, which is expanded when the value is read.

### Additional options

 `--user`, `--process`, or `--machine` can be included to specify where to set environment variables. By default, we target the user. For more information about possible targets for environment variables, see [EnvironmentVariableTarget](https://docs.microsoft.com/dotnet/api/system.environmentvariabletarget).

### Default behavior

The default behavior of the `set-env` tool is to list all of the current environment variables.

## Usage in a codespace

If you're using a codespace, you can set environment variables used in the codespace through customizing the `remoteEnv` property in [`.devcontainer.json`](https://code.visualstudio.com/docs/remote/devcontainerjson-reference) file.

## Example usage
Below are examples of how to run `set-env` using a `.devinit.json`.

#### .devinit.json that will set an environment variable, `foo`, to value, `bar`:
```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-3.0",
  "run": [
    {
      "tool": "set-env",
      "input": "foo=bar",
    }
  ]
}
```

#### .devinit.json that will set an environment variable, `foo`, to value, `bar`, stored in the environment block associated with the current process:
```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-3.0",
  "run": [
    {
      "tool": "set-env",
      "input": "foo=bar",
      "additionalOptions": "--process",
    }
  ]
}
```

#### .devinit.json that will display the value of an environment variable:
```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-3.0",
  "run": [
    {
      "tool": "set-env",
      "input": "foo",
    }
  ]
}
```

#### .devinit.json that will list all the environment variables:
```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-3.0",
  "run": [
    {
      "tool": "set-env",
    }
  ]
}
```

#### .devinit.json that will delete an environment variable:
```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-3.0",
  "run": [
    {
      "tool": "set-env",
      "input": "foo=",
    }
  ]
}
```


#### .devinit.json that will use environment variable expansion:
```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-3.0",
  "run": [
    {
      "tool": "set-env",
      "input": "_savedPath=%path%",
    }
  ]
}
```

#### .devinit.json that will set an environment variable value using path manipulation:
```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-3.0",
  "run": [
    {
      "tool": "set-env",
      "input": "path=%path%;%userprofile%\\CustomFolder",
    }
  ]
}
```

#### .devinit.json that will restore path from saved copy:
```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-3.0",
  "run": [
    {
      "tool": "set-env",
      "input": "path=%_savedPath%",
    }
  ]
}
```
