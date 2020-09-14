---
title: devinit and Visual Studio Codespaces
description: Learn how to customize a Codespace for Visual Studio using devinit.
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
# devinit and Github Codespaces for Visual Studio

`devinit` is a great compliment to [Github Codespaces for Visual Studio](https://visualstudio.microsoft.com/services/visual-studio-codespaces) and `devinit` can be used to get a Codespace setup so contributors can build, run, and debug right away.

To integrate with a Github Codespaces for Visual Studio, `devinit` needs to be called from the `postCreateCommand` defined in a `.devcontainer.json` file placed in the repo root. The string(s) in `postCreateCommand` are executed after the repo is cloned in the default shell of the Codespace. You can read more about `postCreateCommand` in the Github Codespaces [customization documentation](https://docs.github.com/en/github/developing-online-with-codespaces/configuring-codespaces-for-your-project). To add the `devinit` command, you can add `devinit init` to the `postCreateCommand` as shown in the examples below.

You can also execute `devinit init -f <path to .devinit.json>` from the Visual Studio Integrated Terminal once connected to your Codespace.

## Examples

### With a .devinit.json file
In this example, the `.devcontainer.json` file below is placed in the repo root alongside `.devinit.json` file. The files can also be placed in a `.devcontainer` folder.

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
In this example `.devcontainer.json` file below is placed in the repo root and `devinit` is being called programmatically to run a tool  

```json
{
  "postCreateCommand": ["devinit –t require-dotnetsdk"]
}
```

### From a terminal prompt

When the current working directory contains a `.devinit.json` file.

```batch
> devinit init
```

When the `.devinit.json` is in another directory.

```batch
> devinit init -f path/to/.devinit.json
```
