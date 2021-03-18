---
title: Getting Started with devinit
description: Getting started guide for devinit.
ms.date: 11/18/2020
ms.topic: reference
author: andysterland
ms.author: andster
manager: jmartens
ms.workload:
- multiple
monikerRange: ">= vs-2019"
ms.prod: visual-studio-windows
ms.technology: devinit
---
# Getting Started with devinit

> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

devinit is a tool that you can use to enable anyone to get to code and be productive in your repository by running a simple command. You can use devinit to define all the system-wide dependencies that your repository needs something like SQL server, Node.js, Docker, or IIS. Devinit can invoke other tools and package managers to install what your repository needs. You define those dependencies in a JSON file named [.devinit.json](devinit-json.md) and then the next person to use your repository just has to run [`devinit init`](devinit-commands.md#init) to install all those dependencies. So, rather than spending half a day onboarding onto a new repository, it can be done in minutes.

devinit isn't a package manager or a Virtual Machine (VM) configuration tool in and of itself. It's a task runner for a manifest file, named [.devinit.json](devinit-json.md), that defines the system-wide dependencies that your application needs. To install these dependencies, devinit makes use of tools that you might already be using, such as [Chocolatey](https://chocolatey.org). You can review the available tools in the [full list](devinit-tool-list.md). By using these tools rather than distributing software directly, devinit gives you the convenience of using the tool of your choice and enabling you to use existing configurations, for example, a [packages.config](https://chocolatey.org/docs/commands-install#packagesconfig) file for Chocolatey.  

## Step 1: Get devinit

devinit is currently only available as part of GitHub Codespaces when using Visual Studio and is accessible from the integrated terminal in Visual Studio. In the future, devinit will be available as part of Visual Studio.

## Step 2: Define your environment

The most important step is to define your 'development' environment in a [.devinit.json file](devinit-json.md). This file will be used by devinit to create your environment when you run `devinit init`.

For this step, think about the instructions you'd give someone to get up and running with a project repository. For example, do they need to have SQL installed? A specific version of .NET Core? And so on. Then for each of those dependencies, look for a corresponding devinit tool in the [list of tools](devinit-tool-list.md) and add that to the repository's `.devinit.json` file.

You can also see a selection of examples over in the [samples documentation](sample-readme.md), or check out the [tutorial](tutorial.md).

## Step 3: Enjoy!

Now all someone has to do after cloning your repo is run `devinit init`.

```console
devinit init
```

If you're using [GitHub Codespaces](https://github.com/features/codespaces), you can configure `devinit init` to run automatically when the codespace is provisioned. To learn more, have a look at the [devinit and GitHub Codespaces documentation](devinit-and-codespaces.md).
