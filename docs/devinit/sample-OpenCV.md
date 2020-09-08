---
title: OpenCV
description: Example customization using devinit for the opencv/opencv repo.
ms.date: 08/28/2020
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# OpenCV

This example illustrates the customizations needed to by [OpenCV](https://github.com/opencv/opencv) to be automatically provisioned in a [Codespace with Visual Studio 2019](https://docs.microsoft.com/visualstudio/codespaces/quickstarts/vs).

## .devcontainer.json

Contents of the `.devcontainer.json` file in the repo root.

```json
{
  "postCreateCommand": "devinit init"
}
```

## .devinit.json

Contents of the [`.devinit.json`](~/devinit/devinit-json.md) file. This file needs to be in the same folder as `.devcontainer.json`.

```json
{
    "run": [
        {
            "comments": "Example that will install Ubuntu 20.04 using WSL2, and configure it with various packages.",
            "tool": "wsl-install",
            "input": "https://aka.ms/wslubuntu2004",
            "additionalOptions": "--wsl-version 2 --post-create-command 'apt-get update && apt-get install g++ gcc g++-9 gcc-9 cmake gdb ninja-build zip rsync -y'"
        }
    ]
}
```