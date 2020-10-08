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

devinit is a great compliment to [GitHub Codespaces](https://github.com/features/codespaces) and devinit can be used to get a codespace setup so contributors can build, run, and debug right away.

To integrate with GitHub Codespaces, `devinit` needs to be called from the `postCreateCommand` defined in a `.devcontainer.json` file placed in the repo root. The string(s) in `postCreateCommand` are executed in the default shell, after the repo is cloned in the codespace. You can read more about `postCreateCommand` in the GitHub Codespaces [customization documentation](https://docs.github.com/github/developing-online-with-codespaces/configuring-codespaces-for-your-project). To add the `devinit` command, you can add `devinit init` to the `postCreateCommand` as shown in the examples below.

You can also execute `devinit init -f <path to .devinit.json>` from the Visual Studio Integrated Terminal once connected to your codespace.

## Examples

### With a .devinit.json file
In this example, the _.devcontainer.json_ file below is placed in the repo root alongside the _.devinit.json_ file. The files can also be placed in a _.devcontainer_ directory.

```json
{
  "postCreateCommand": "devinit init"
}
```

```json
{
  "postCreateCommand": ["<some other command>", "devinit init"]
}
```

### As commands
In this example _.devcontainer.json_ file below is placed in the repo root and `devinit run` is being called programmatically to run a tool  

```json
{
  "postCreateCommand": ["devinit run –t require-dotnetcoresdk"]
}
```

### From a terminal prompt

When the current working directory contains a _.devinit.json_ file.

```console
> devinit init
```

When the _.devinit.json_ is in another directory.

```console
> devinit init -f path/to/.devinit.json
```
