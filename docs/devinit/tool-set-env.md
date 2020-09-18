---
title: set-env
description: devinit tool require-set-env.
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
# set-env

The `set-env` tool can be used to set environment variables for use in the current process. The environment variables are set only in the current process and will be used by other `devinit` tools if they run in that process.

This tool makes use of the .NET Core `Environment.SetEnvironment` API and has the same limitations as that API. For more information, please see the [documentation](https://docs.microsoft.com/dotnet/api/system.environment.setenvironmentvariable?view=netcore-3.1&preserve-view=true) for `Environment.SetEnvironment`.

## Usage

| Name                                         | Type   | Required | Value                                                                       |
|----------------------------------------------|--------|----------|-----------------------------------------------------------------------------|
| **comments**                                 | string | No       | Optional comments property. Not used.                                       |
| [**input**](#input)                          | string | No       | The input to the tool. See [Input](#input) below for details.               |
| [**additionalOptions**](#additional-options) | string | No       | Not used. See [Additional options](#additional-options) below for details.  |

### Input

The `set-env` tool takes a single string as an input on the `input` property. The string should be formatted a string of semi-colon (;) delimited key value pairs (name=value) and four possible actions based on the value of the `input` property.

| Action       | Input            | Description                                                                                                                                                              | Example             |
|--------------|------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------|
| **list all** | empty or omitted | List all the current environment variables.                                                                                                                              | `"input":""`        |
| **list one** | string           | List the value of a specific environment variable by name.                                                                                                               | `"input":"foo"`     |
| **add**      | string           | Sets the value of an environment variable as key value pair. Adds a new environment variable if not already present or set the value of an existing environment variable | `"input":"foo=bar"` |
| **delete**   | string           | Deletes an existing environment variable by passing in an empty value string.                                                                                            | `"input":"foo="`    |

An `input` string can contain an environment variable expansion for example `%userprofile%`, which is expanded when the value is read.

### Additional options

Not used.

## Example usage

```json
{
  "$schema": "https://json.schemastore.org/devinit.schema-2.0",
  "comments": "A sample dot-devinit file demonstrating the set-env tool.",
  "run": [
    {
      "tool": "set-env",
      "input": "foo=bar",
      "comments": "To set an environment variable, set input to 'name=value'."
    },
    {
      "tool": "set-env",
      "input": "foo",
      "comments": "To display the value of a single environment variable, set input to the name of the variable."
    },
    {
      "tool": "set-env",
      "comments": "To list all environment variables, pass no input."
    },
    {
      "tool": "set-env",
      "input": "foo=",
      "comments": "To delete an environment variable, pass input of 'name='."
    },
    {
      "tool": "set-env",
      "input": "foo",
      "comments": "Trying to display a variable that doesn't exist results in a warning."
    },
    {
      "tool": "set-env",
      "input": "_savedPath=%path%",
      "comments": "Envrionment variable expansion is supported."
    },
    {
      "tool": "set-env",
      "input": "path=%path%;%userprofile%\\CustomFolder",
      "comments": "Shows path manipulation. Note: Variables set here are not persisted."
    },
    {
      "tool": "set-env",
      "input": "path=%_savedPath%",
      "comments": "Restore path from saved copy."
    }
  ]
}
```
