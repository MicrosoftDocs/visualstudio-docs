---
title: What is Visual Studio Codespaces?
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

# What is Visual Studio Codespaces?

Welcome to Visual Studio Codespaces! We're glad you're here.

Visual Studio Codespaces provides cloud-powered development environments for any activity - whether it's a long-term project, or a short-term task like reviewing a pull request. You can work with these environments from Visual Studio Code, Visual Studio 2019 ([sign up for the Private Preview](https://aka.ms/vsfutures-signup)), or a browser-based editor that's accessible anywhere! You can even connect your own self-hosted environments to Visual Studio Codespaces at no cost.

Additionally, Visual Studio Codespaces brings many of the benefits of DevOps, like repeatability and reliability, which have typically been reserved for production workloads, to development environments. However, Visual Studio Codespaces is also personalizable to allow developers to leverage the tools, processes and configurations that they have come to love and rely on.

This document will explain key concepts and introduce Codespaces features. If you're looking for an abridged version, check out [the quickstarts](../quickstarts/browser.md).

## Concepts and features

Visual Studio Codespaces features are built on top of a few fundamental concepts. This section covers those concepts and gives a brief tour of features.

### Remote development

Visual Studio Codespaces conceptually and technically extends the [Visual Studio Code Remote Development extensions](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.vscode-remote-extensionpack). As explained in the [Remote Development with VS Code](https://code.visualstudio.com/blogs/2019/05/02/remote-development) blog post, the following quote sums up the problem solved by Codespaces:

>"_We saw many developers trying to develop against containers and remote VMs configured with specific development and runtime stacks, simply because it is too hard, too disruptive, and in some cases impossible, to set up these development environments locally. We've all experienced this problem. Unless we feel it's time to flatten that machine, we hesitate to try out a new stack like Rust, Go, Node, or Python3, for fear of 'messing up' our current, well-tuned environment._"

Remote-capable tools empower developers but usually add overhead of machine management. Environment configuration often complicates onboarding and context switching. Visual Studio Codespaces removes the barriers to rapid onboarding and context switching by enabling the simultaneous existence of many environments.

Visual Studio Codespaces focuses on managed solutions that allow you to focus on productivity over setup. Developers that prefer to manage their own environments can explore [Visual Studio Code's Remote Development](https://code.visualstudio.com/docs/remote/remote-overview).

### Environments

An environment is the "backend" half of Visual Studio Codespaces. It's where all of the compute associated with software development happens: compiling, debugging, restoring, etc. Creating a Codespace prepares everything you need to complete a task, review a PR, or start a new project. Codespaces configures the runtime, compiler, debugger, editor, custom dotfile configurations, editor extensions, and the source code required to work on a project.

Cloud-hosted development environments provide the benefits associated with Azure:

- They are fast to create and disposable. Create as many as you need (up to subscription limits), and dispose of them when you are finished.
- They are managed, reducing overall maintenance for you.
- They have predictable pricing and you only pay for what you use, with built in auto-suspend to eliminate runaway costs.
- Moving your development workload to the cloud frees the limited resources on your personal machine.

In addition to cloud-hosted environments, Visual Studio Codespaces also allows you to register and connect your own self-hosted environments. This functionality allows you to use existing environments, and still experience some of the benefits of Visual Studio Codespaces.

### Editors and IDEs

In addition to "backend" environments, Visual Studio Codespaces supports these "frontend" editors:

- Visual Studio Code
- Visual Studio 2019 (Private Preview)
- Visual Studio Code-based editor in the browser

Linux environments (Public Preview) are accessible from Visual Studio Code and our Visual Studio Code-based editor in the browser. Windows environments (Private Preview) are accessible from all three "frontend" editors.

This array of editor options allows developers to use their preferred tooling from anywhere. This experience is extended with support for extensions from [the Visual Studio Marketplace](https://marketplace.visualstudio.com/).

### Custom configuration

Visual Studio Codespaces is built to accommodate the widest variety of projects or tasks. Developers can start with smart-configuration features that provide common defaults, or finely-tune environments with custom JSON and Dockerfile configuration.

Flexible configuration allows developers to rapidly onboard on projects with unique configuration and requirements that are difficult to apply on a local machine. Additionally, reproducible development environments eliminate "works on my machine" problems.

### Personal configuration

Preserving personal preferences is critical to make development on a cloud-hosted environment feel familiar and natural. Visual Studio Codespaces layers individualized configuration on top of environment configuration. Personal preferences and configuration for editors, terminal are supported by Visual Studio Codespaces.

Environments can be created with a user specific collection of custom dotfiles (e.g. `.bashrc`, `.gitconfig`, etc.), and we automatically synchronize your Git identity, themes and settings so every environment you create looks and feels the way you like, regardless of the project specific environment capabilities.

## See also

- [Quickstart: Visual Studio Codespaces in Visual Studio 2019](../quickstarts/vs.md)
- [How to: Use Codespaces in Visual Studio 2019](../how-to/vside.md)