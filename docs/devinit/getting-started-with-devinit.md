---
title: Getting Started with devinit
description: Getting started guide for devinit.
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
# Getting Started with devinit

## Step 1: Get devinit

devinit is currently only available as part of GitHub Codespaces when using Visual Studio and is accessible from the integrated terminal in Visual Studio. In the future, devinit will be available as part of Visual Studio.

## Step 2: Define your environment

The most important step is to define your 'developer' environment in a [_.devinit.json_ file](devinit-json.md). This file will be used by devinit to create your environment when you run `devinit init`.

For this step, think about the instructions you'd give someone to get up and running with a project repository. For example, do they need to have SQL installed? A specific version of .NET Core? etc. Then for each of those dependencies, look for a corresponding devinit tool in the [list of tools](devinit-tool-list.md)) and add that to the repository's _.devinit.json_ file.

## Step 3: Profit! 💰

Now all someone has to do after cloning your repo is run `devinit init`.

```batch
> devinit init
```

If you're using [GitHub Codespaces](https://github.com/features/codespaces), you can configure `devinit init` to run automatically when the codespace is provisioned. To learn more have a look at the [devinit and GitHub Codespaces documentation](devinit-and-codespaces.md).
