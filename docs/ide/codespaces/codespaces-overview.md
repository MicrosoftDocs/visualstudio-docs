---
title: Overview of GitHub Codespaces (Preview)
description: Learn more about GitHub Codespaces and how it can help extend extend your development environment to the cloud.
ms.topic: overview
ms.date: 09/04/2020
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: vs-2019
---

# What is Codespaces? (Preview)

Welcome to GitHub CodeSpaces! We're glad you're here.

GitHub CodeSpaces provides you with a cloud-powered development environment for any activity, whether it's a long-term project, or a short-term task like reviewing a pull request. You can work with a codespace from within Visual Studio 2019 ([sign up for the Preview](https://aka.ms/vsfutures-signup)).

Additionally, GitHub CodeSpaces brings many of the benefits of DevOps, like repeatability and reliability&mdash;which have typically been reserved for production workloads&mdash;to a development environment. You can also personalize GitHub CodeSpaces so that the tools, processes, and configurations that you prefer and rely on are there, too.

This document will explain key concepts and introduce Codespaces features. If you're looking for an abridged version, check out [the Codespaces quickstart](/visualstudio/codespaces/quickstarts/vs/).

> [!IMPORTANT]
> You must sign up for the Private Preview to use Codespaces. This Private Preview release is not intended for use on production computers or for creating production code. For more information about Preview releases, see the [Visual Studio 2019 Preview release notes](/visualstudio/releases/2019/release-notes-preview/). And for more information about installing and updating Visual Studio 2019, see [Update Visual Studio to the most recent release](../../install/update-visual-studio.md).

## Concepts and features

GitHub CodeSpaces features are built on top of a few fundamental concepts. This section covers those concepts and gives a brief tour of the features.

### Remote development

GitHub CodeSpaces conceptually and technically extends the [Visual Studio Code Remote Development extensions](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.vscode-remote-extensionpack). As explained in the [Remote Development with VS Code](https://code.visualstudio.com/blogs/2019/05/02/remote-development) blog post, the following quote sums up the problem solved by Codespaces:

>"_We saw many developers trying to develop against containers and remote VMs configured with specific development and runtime stacks, simply because it is too hard, too disruptive, and in some cases impossible, to set up these development environments locally. We've all experienced this problem. Unless we feel it's time to flatten that machine, we hesitate to try out a new stack like Rust, Go, Node, or Python3, for fear of 'messing up' our current, well-tuned environment._"

Remote-capable tools empower developers but usually add overhead of machine management. Environment configuration often complicates onboarding and context-switching. GitHub CodeSpaces removes the barriers to rapid onboarding and context-switching by enabling the simultaneous existence of many environments.

GitHub CodeSpaces focuses on managed solutions that allow you to focus on productivity over setup. Developers that prefer to manage their own environments can explore [Visual Studio Code remote development](https://code.visualstudio.com/docs/remote/remote-overview).

### About codespaces

A codespace is the "backend" half of GitHub CodeSpaces. It's where all of the compute associated with software development happens: compiling, debugging, restoring, etc. Creating a codespace prepares everything you need to complete a task, review a PR, or start a new project. Codespaces configure the runtime, compiler, debugger, editor, custom dotfile configurations, editor extensions, and the source code required to work on a project.

Cloud-hosted codespaces provide the following benefits:

- They're fast to create and disposable. Create as many as you need (up to subscription limits) and then dispose of them when you are finished.
- They're managed, which reduces the overall maintenance for you.
- They have predictable pricing and you only pay for what you use. And, there's built-in autosuspend to eliminate runaway costs.
- They save compute resources. When you move your development workload to the cloud, it frees the limited resources on your personal machine.

### Custom configuration

GitHub CodeSpaces is built to accommodate the widest variety of projects or tasks. You can start with smart-configuration features that provide common defaults, or fine-tune a codespace with custom JSON and Dockerfile configuration.

Flexible configuration allows developers to rapidly onboard on projects with unique configuration and requirements that are difficult to apply on a local machine. Additionally, reproducible codespaces eliminate "works on my machine" problems.

### Personal configuration

We know that preserving personal preferences is critical to make developing on a cloud-hosted codespace feel familiar and natural. GitHub CodeSpaces layers individualized customizations on top of a codespace configuration. Personal preferences and configuration for editors and  terminals are supported by GitHub CodeSpaces.

A codespace can be created with a user-specific collection of custom dotfiles (for example, `.bashrc`, `.gitconfig`, etc.), and GitHub CodeSpaces automatically synchronizes your Git identity, themes, and settings so every codespace you create looks and feels the way you like, regardless of the project-specific environment capabilities.

## See also

- [Quickstart: GitHub CodeSpaces in Visual Studio 2019 (Preview)](/visualstudio/codespaces/quickstarts/vs/)
- [How to: Use Visual Studio with Codespaces (Preview)](use-visual-studio-with-codespaces.md)
- [How to: Customize Codespaces (Preview)](customize-codespaces.md)