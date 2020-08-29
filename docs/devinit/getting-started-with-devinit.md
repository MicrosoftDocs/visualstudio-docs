---
title: Getting Started with devinit
lang: en-US
ms.date: 8/28/200
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# Getting Started with devinit

## Step 1: Get devinit

### Windows

>[!IMPORTANT]
>`devinit` is only available as part of the Private Preview of Visual Studio 2019 for Codespaces and is accessible from the terminal in Visual Studio.

In the future `devinit` will be available as part of Visual Studio.

## Step 2: Define your environment

The most important step is to define your 'developer' environment in a [`.devinit.json` file](docs/devinit-json.html). This file will be used by devinit to create your environment when you run `devinit init`.

For this step, think about the instructions you'd give someone to get up and running in the repo. For example, do they need to have SQL installed? A specific version of .NET Core? etc. Then for each of those dependencies look for a corresponding `devini` tool over in the [list of tools](tools/readme.md)) and add that to your repos `.devinit.json` file.

## Step 3: Profit! 💰

Now all someone has to do after cloning your repo is run `devinit init`.
```batch
> devinit init
```

If you're using [Visual Studio Codespaces](https://visualstudio.microsoft.com/services/visual-studio-codespaces/) you can configure `devinit init` to run automatically when the Codespace is provisioned, to do that have a look at the [devinit and Codespaces documentation](docs/codespaces.html).
