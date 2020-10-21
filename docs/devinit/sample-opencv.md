---
title: OpenCV
description: Example customization using devinit to target both Linux and Windows for the OpenCV repository.
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
# OpenCV

This example illustrates how to customize [GitHub Codespaces](https://github.com/features/codespaces) in order to develop with a multiplatform projects such as [opencv/OpenCV](https://github.com/opencv/opencv).

The following customizations are already applied on the fork [microsoft/OpenCV](https://github.com/microsoft/opencv) and allow to build targeting either Windows and Ubuntu.

## Customization with devcontainer.json and devinit.json

The `.devcontainer` directory needs to contain the following files:

  * devcontainer.json
  * devinit.json

### devcontainer.json

The following is the content of the _devcontainer.json_ file.

```json
{
  "postCreateCommand": "devinit init"
}
```

The `postCreateCommand` launches the  [devinit](docs\devinit\devinit-and-codespaces.md) tool, which consumes _devinit.json_.


### devinit.json

The following is the content of the [_devinit.json_](devinit-json.md) file.

```json
{
    "run": [
        {
            "comments": "Example that will install Ubuntu 20.04 using WSL2, and configure it with various packages useful for C++ development.",
            "tool": "wsl-install",
            "input": "https://aka.ms/wslubuntu2004",
            "additionalOptions": "--wsl-version 2 --post-create-command 'apt-get update && apt-get install g++ gcc g++-9 gcc-9 cmake gdb ninja-build zip rsync -y'"
        }
    ]
}
```
This file needs to be in the same folder as _devcontainer.json_.
The _devinit.json_ is the file consumed by the devinit tool.

In this sample, the [wsl-install](./tool-wsl-install.md) tool is used to create a WSL instance running Ubuntu 20.04, and provisioning it with essential C++ development tools.
## Targeting Windows or Linux

A default configuration targeting Windows is always created a named `x64-Debug`, which allows to build targeting Windows.

By adding the mentioned files, upon Codespace instance creation, Visual Studio provisions a new SSH connection in the [Connection Manager](https://docs.microsoft.com/en-us/cpp/linux/connect-to-your-remote-linux-computer?view=vs-2019), and creates a new configuration in the Configuration picker that targets the Ubuntu instance via the SSH connection.

![Configuration targeting Ubuntu](.\media\350481fa-9935-4f59-8e76-4e232efd2e08.png).

By selecting the highlighted configuration that targets WSL, it is possible to build and debug the OpenCV's build targets.
