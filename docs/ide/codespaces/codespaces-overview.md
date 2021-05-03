---
title: Overview of GitHub Codespaces (Preview)
description: Learn more about GitHub Codespaces with Visual Studio and how it can help extend your development environment to the cloud.
ms.topic: overview
ms.date: 09/04/2020
author: gregvanl
ms.author: gregvanl
manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: vs-2019
---

# What is GitHub Codespaces? (Preview)

> [!Important]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We're focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. We encourage you to be involved in our [developer community forum](https://developercommunity.visualstudio.com/home) for Visual Studio for information on future previews and roadmap information.

Welcome to Codespaces! We're glad you're here.

GitHub Codespaces provides you with a cloud-powered development environment for any activity, whether it's a long-term project, or a short-term task like reviewing a pull request.

Additionally, GitHub Codespaces brings many of the benefits of DevOps, like repeatability and reliability&mdash;which have typically been reserved for production workloads&mdash;to a development environment. You can also personalize GitHub Codespaces so that the tools, processes, and configurations that you prefer and rely on are there, too.

This document will explain key concepts and introduce Codespaces features. If you're looking to get started, check out [Use Visual Studio with a codespace](use-visual-studio-with-codespaces.md).

## Concepts and features

GitHub Codespaces features are built on top of a few fundamental concepts. This section covers those concepts and gives a brief tour of the features.

### Remote development

Many developers today try to code in remote setups or VMs that are configured with specific development and runtime stacks. They do so because it's too hard, too disruptive, and in some cases, near impossible to set up these development environments locally. Also, individuals want to try out new technologies or new frameworks without the fear of "messing up" the machines they need for their day-to-day work.

While using remote environments and remote-capable tools empowers developers, there is often the overhead of machine management. Environment configuration often complicates onboarding and context-switching. GitHub Codespaces removes the barriers to rapid onboarding and context-switching by enabling many environments to exist simultaneously.

GitHub Codespaces provides managed solutions that allow you to focus on productivity over setup. GitHub Codespaces conceptually and technically extends Visual Studio 2019 for remote development.

### About codespaces

A codespace is the "backend" half of GitHub Codespaces. It's where all of the compute associated with software development happens: compiling, debugging, restoring, etc. Creating a codespace prepares everything you need to complete a task, review a PR, or start a new project. Codespaces configure the runtime, compiler, debugger, editor, custom dotfile configurations, and the source code required to work on a project.

Cloud-hosted codespaces provide the following benefits:

- They're fast to create and disposable. Create as many as you need (up to account limits) and then dispose of them when you are finished.
- They're managed, which reduces the overall maintenance for you.
- They have predictable pricing and you only pay for what you use. And, there's built-in autosuspend to eliminate runaway costs.
- They save compute resources. When you move your development workload to the cloud, it frees the limited resources on your personal machine.

## Custom configuration

GitHub Codespaces is built to accommodate the widest variety of projects or tasks. You can start with smart-configuration features that provide common defaults, or fine-tune a codespace with [custom configuration](customize-codespaces.md).

Flexible configuration allows developers to rapidly onboard on projects with unique configuration and requirements that are difficult to apply on a local machine. Additionally, reproducible codespaces eliminate "works on my machine" problems.

## Personal configuration

We know that preserving personal preferences is critical to make developing on a cloud-hosted codespace feel familiar and natural. GitHub Codespaces layers individualized customizations on top of a codespace configuration. Personal preferences and configuration for editors and  terminals are supported by GitHub Codespaces.

A codespace can be created with a user-specific collection of [custom dotfiles](https://docs.github.com/github/developing-online-with-codespaces/personalizing-codespaces-for-your-account) (for example, `.bashrc`, `.gitconfig`, etc.), and GitHub Codespaces automatically synchronizes your Git identity, themes, and settings so every codespace you create looks and feels the way you like, regardless of the project-specific environment capabilities.

## See also

* [How to use Visual Studio with a codespace](use-visual-studio-with-codespaces.md)
* [How to customize a codespace](customize-codespaces.md)
* [Supported Visual Studio features](supported-features-codespaces.md)
