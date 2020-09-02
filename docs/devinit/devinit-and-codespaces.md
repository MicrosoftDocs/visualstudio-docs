---
title: Devinit and Visual Studio Codespaces
description: Learn how to customize a Codespace for Visual Studio using devinit.
ms.date: 008/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# Devinit and Visual Studio Codespaces

`devinit` is a great compliment to [Visual Studio Codespaces](https://visualstudio.microsoft.com/services/visual-studio-codespaces) and `devinit` can be used to get a Visual Studio Codespace setup so contributors can build, run, and debug right away.

To integrate with a Visual Studio Codespace `devinit` needs to be called from the `postCreateCommand` defined in a `.devcontainer.json` file placed in the repo root. The string(s) in `postCreateCommand` are executed after the repo is cloned in the default shell of the Codespace. You can read more about `postCreateCommand` in the Visual Studio Codespace [customization documentation](https://docs.microsoft.com/en-us/visualstudio/online/reference/configuring). To add the `devinit` command, you can add `devinit init` to the `postCreateCommand` as shown in the examples below.

## Examples

### With a .devinit.json File
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

### As Commands
In this example `.devcontainer.json` file below is placed in the repo root and `devinit` is being called programmatically to run a tool  
```json
{
  "postCreateCommand": ["devinit –t require-dotnetsdk"]
}
```