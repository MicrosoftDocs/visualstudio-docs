---
title: Getting Started with devinit
description: Getting started guide for devinit.
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
# Getting Started with devinit

devinit is a tool that you can use to enable anyone to get to code and be productive in your repository by running a simple command. You can use devinit to define all the system wide dependencies that your repository needs be it something like SQL server, Node, docker or IIS. Devinit can invoke other tools and package managers to install what your repository needs. You just have to define those dependencies in a json file named  `.devinit.json` and then the next person to use your repository just has to run `devinit init` to install all those dependencies. So, rather than spending half a day onboarding onto a new repository it can be done in minutes.

devinit isn't a package manager or a Virtual Machine (VM) configuration tool in of itself. It's really just a task runner for a manifest file, named [`.devinit.json'](devinit-json.md), that defines those system wide dependencies that your application needs. To install these dependencies devinit makes use of tools that you might already be using such as [Chocolatey](https://chocolatey.org/), or [winget](https://docs.microsoft.com/en-us/windows/package-manager/winget/), etc. ([full list](devinit-tool-list.md)). By using these tools rather than distributing software directly devinit gives your the convenience of using the tool of your choice and enabling you to use existing configuration, for example a [`packages.config`](https://chocolatey.org/docs/commands-install#packagesconfig) file for Chocolatey.  

## Step 1: Get devinit

devinit is currently only available as part of GitHub Codespaces when using Visual Studio and is accessible from the integrated terminal in Visual Studio. In the future, devinit will be available as part of Visual Studio.

## Step 2: Define your environment

The most important step is to define your 'development' environment in a [_.devinit.json_ file](devinit-json.md). This file will be used by devinit to create your environment when you run `devinit init`.

For this step, think about the instructions you'd give someone to get up and running with a project repository. For example, do they need to have SQL installed? A specific version of .NET Core? etc. Then for each of those dependencies, look for a corresponding devinit tool in the [list of tools](devinit-tool-list.md) and add that to the repository's _.devinit.json_ file. You can also see a selection of examples over in the [samples documentation](sample-all-tool.md).

## Step 3: Enjoy!

Now all someone has to do after cloning your repo is run `devinit init`.

```console
devinit init
```

If you're using [GitHub Codespaces](https://github.com/features/codespaces), you can configure `devinit init` to run automatically when the codespace is provisioned. To learn more have a look at the [devinit and GitHub Codespaces documentation](devinit-and-codespaces.md).
