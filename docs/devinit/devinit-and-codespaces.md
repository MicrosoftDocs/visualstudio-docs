---
title: devinit and GitHub Codespaces
description: Learn how to customize a codespace for Visual Studio using devinit.
ms.date: 08/28/2020
ms.topic: reference
author: andysterland
ms.author: andster
manager: jillfra
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# devinit and GitHub Codespaces

devinit is a great complement to [GitHub Codespaces](https://github.com/features/codespaces) and devinit can be used to get a codespace setup so contributors can build, run, and debug right away.

> [!IMPORTANT]
> Before integrating devinit with your codespace, you first need to make sure you have a `.devinit.json` file that defines your dependencies. For more information on how to create a `.devinit.json`, read the [getting started documentation](getting-started-with-devinit.md).

Inside of a GitHub Codespace, your application is built and run in the cloud. Being in the cloud means that your application doesn't have access to local resources on your machines. These include tools or programs that you have installed locally. If your application needs any system-wide dependencies to be installed or configured, it needs to be done on each codespace. The easiest way to achieve that is to use a `.devinit.json` file.

To make sure that a codespace is created with the dependencies your application needs, `devinit` needs to be run when the codespace is created. This can be done by calling `devinit init` from the `postCreateCommand` defined in a `.devcontainer.json` file placed in the repository root. The string(s) in `postCreateCommand` are executed in the default shell, after the repo is cloned in the codespace. You can read more about `postCreateCommand` in the GitHub Codespaces [customization documentation](https://docs.github.com/github/developing-online-with-codespaces/configuring-codespaces-for-your-project). To add the `devinit` command, you can add `devinit init` to the `postCreateCommand` as shown in the examples below.

You can also execute `devinit init -f <path to .devinit.json>` from the Visual Studio Integrated Terminal once connected to your codespace.

## Examples

In both examples below, the `.devinit.json` is in the repository root alongside `.devcontainer.json`.

### With a .devcontainer.json file

In this example, the `.devcontainer.json` file below is placed in the repo root alongside the `.devinit.json` file. The files can also be placed in a `.devcontainer` directory.

```json
{
  "postCreateCommand": "devinit init"
}
```

When the `.devinit.json` is in another directory, the -f flag may be used.

```json
{
  "postCreateCommand": "devinit init -f path\\to\\.devinit.json"
}

```

```json
{
  "postCreateCommand": ["<some other command>", "devinit init"]
}
```

You can find more examples of using devinit in our [documentation](sample-all-tool.md) and on GitHub in the [.NET Core example](https://github.com/microsoft/devinit-example-dotnet-core) and [Node.js example](https://github.com/microsoft/devinit-example-nodejs) repositories.

### As commands

In this example, `.devcontainer.json` file below is placed in the repo root and `devinit run` is being called directly from the command line to run an individual tool.  

```json
{
  "postCreateCommand": ["devinit run –t require-dotnetcoresdk"]
}
```

### From a terminal prompt

When the current working directory contains a `.devinit.json` file.

```console
devinit init
```

When the `.devinit.json` is in another directory.

```console
devinit init -f path/to/.devinit.json
```
