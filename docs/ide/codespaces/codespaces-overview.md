---
title: What is Visual Studio Codespaces (Preview)?
description: Learn more about cloud-powered Codespaces and how to use them with Visual Studio 2019.
ms.topic: overview
ms.date: 09/02/2020
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: vs-2019
---

# What is Visual Studio Codespaces? (Preview)

Welcome to Visual Studio Codespaces! We're glad you're here.

Visual Studio Codespaces provides you with a cloud-powered development codespace for any activity, whether it's a long-term project, or a short-term task like reviewing a pull request. You can work with a codespace from within Visual Studio 2019 ([sign up for the Private Preview](https://aka.ms/vsfutures-signup)). You can even connect your own self-hosted codespace to Visual Studio Codespaces at no cost.

Additionally, Visual Studio Codespaces brings many of the benefits of DevOps, like repeatability and reliability&mdash;which have typically been reserved for production workloads&mdash;to a development codespace. However, Visual Studio Codespaces is also personalizable to allow developers to leverage the tools, processes and configurations that they've come to love and rely on.

This document will explain key concepts and introduce Codespaces features. If you're looking for an abridged version, check out [the quickstarts](../quickstarts/browser.md).

> [!IMPORTANT]
> You must sign up for the Private Preview and have an Azure Subscription to use Codespaces If you don't already have an Azure Subscription, create one at [https://azure.microsoft.com/free/](https://azure.microsoft.com/free/). After you have an Azure subscription, [sign up for the Private Preview](https://aka.ms/vsfutures-signup).

## Concepts and features

Visual Studio Codespaces features are built on top of a few fundamental concepts. This section covers those concepts and gives a brief tour of features.

### Remote development

Visual Studio Codespaces conceptually and technically extends the [Visual Studio Code Remote Development extensions](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.vscode-remote-extensionpack). As explained in the [Remote Development with VS Code](https://code.visualstudio.com/blogs/2019/05/02/remote-development) blog post, the following quote sums up the problem solved by Codespaces:

>"_We saw many developers trying to develop against containers and remote VMs configured with specific development and runtime stacks, simply because it is too hard, too disruptive, and in some cases impossible, to set up these development codespaces locally. We've all experienced this problem. Unless we feel it's time to flatten that machine, we hesitate to try out a new stack like Rust, Go, Node, or Python3, for fear of 'messing up' our current, well-tuned codespace._"

Remote-capable tools empower developers but usually add overhead of machine management. Codespace configuration often complicates onboarding and context switching. Visual Studio Codespaces removes the barriers to rapid onboarding and context switching by enabling the simultaneous existence of many codespaces.

Visual Studio Codespaces focuses on managed solutions that allow you to focus on productivity over setup. Developers that prefer to manage their own codespaces can explore [Visual Studio Code's Remote Development](https://code.visualstudio.com/docs/remote/remote-overview).

### Codespaces

A codespace is the "backend" half of Visual Studio Codespaces. It's where all of the compute associated with software development happens: compiling, debugging, restoring, etc. Creating a codespace prepares everything you need to complete a task, review a PR, or start a new project. Codespaces configures the runtime, compiler, debugger, editor, custom dotfile configurations, editor extensions, and the source code required to work on a project.

Cloud-hosted development codespaces provide the benefits associated with Azure:

- They are fast to create and disposable. Create as many as you need (up to subscription limits), and dispose of them when you are finished.
- They are managed, reducing overall maintenance for you.
- They have predictable pricing and you only pay for what you use, with built in auto-suspend to eliminate runaway costs.
- Moving your development workload to the cloud frees the limited resources on your personal machine.

In addition to cloud-hosted codespaces, Visual Studio Codespaces also allows you to register and connect your own self-hosted codespaces. This functionality allows you to use existing codespaces, and still experience some of the benefits of Visual Studio Codespaces.

### Editors and IDEs

In addition to "backend" codespaces, Visual Studio Codespaces supports these "frontend" editors:

- Visual Studio Code
- Visual Studio 2019 (Private Preview)
- Visual Studio Code-based editor in the browser

Linux codespaces (Public Preview) are accessible from Visual Studio Code and our Visual Studio Code-based editor in the browser. Windows codespaces (Private Preview) are accessible from all three "frontend" editors.

This array of editor options allows developers to use their preferred tooling from anywhere. This experience is extended with support for extensions from [the Visual Studio Marketplace](https://marketplace.visualstudio.com/).

### Custom configuration

Visual Studio Codespaces is built to accommodate the widest variety of projects or tasks. Developers can start with smart-configuration features that provide common defaults, or finely-tune a codespace with custom JSON and Dockerfile configuration.

Flexible configuration allows developers to rapidly onboard on projects with unique configuration and requirements that are difficult to apply on a local machine. Additionally, reproducible development codespaces eliminate "works on my machine" problems.

### Personal configuration

Preserving personal preferences is critical to make development on a cloud-hosted codespace feel familiar and natural. Visual Studio Codespaces layers individualized configuration on top of a codespace configuration. Personal preferences and configuration for editors, terminal are supported by Visual Studio Codespaces.

A codespace can be created with a user specific collection of custom dotfiles (e.g. `.bashrc`, `.gitconfig`, etc.), and we automatically synchronize your Git identity, themes and settings so every codespace you create looks and feels the way you like, regardless of the project-specific codespace capabilities.

## See also

- [Quickstart: Visual Studio Codespaces in Visual Studio 2019 (Preview)](../quickstarts/vs.md)
- [How to: Use Codespaces in Visual Studio 2019 (Preview)](../how-to/vside.md)