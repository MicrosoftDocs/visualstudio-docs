---
title: Frequently Asked Questions
description: Frequently asked questions for the devinit tool.
ms.date: 08/28/2020
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
> [!IMPORTANT]
> As of April 12th 2021, connecting to GitHub Codespaces from Visual Studio 2019 will no longer be supported and this private preview has concluded. We’re focused on evolving experiences for a cloud-powered inner loop and VDI solutions optimized for a broad set of Visual Studio workloads. As part of this `devinit` and associated tools will no longer be available. We encourage you to be involved in our developer community forum for Visual Studio for information on future previews and roadmap information.

# Frequently asked questions for devinit

## Is devinit just for GitHub Codespaces?

For now, devinit is only available as part of the GitHub Codespaces private beta. However, we have plans to include devinit in an upcoming release of Visual Studio 2019.

## Is it Windows only?
Yes, devinit is focused on creating developer environments that work for developers using Visual Studio, which means Windows. We are considering other platforms but many of them already have great solutions in place so we wanted to start with Visual Studio and Windows.

## There's no tool for the dependency I need!

We're sorry! If you're part of the GitHub Codespaces private beta, you can get back to us through the feedback channel for the private beta. If you're not part of the private beta, we'd still love your feedback on what you need, and you can file an issue on our [Visual Studio Docs](https://github.com/MicrosoftDocs/visualstudio-docs/) with the label `devinit` to request support for the tool you need.

## Something went wrong, how do I debug?

If devinit is failing, the first thing to try is the `--verbose / -v` flag to get more information. Likely the underlying tool that devinit is calling into is encountering an issue. The verbose log information should include a clue as to where to look next.

## Why not just a script?

Setting up environments via a script is a time old technique and can work great. If it works for you, then use it! devinit is another option for developers for when scripts aren't the best choice.

## Why not a container?

Containers, and Docker, are great tools to deploy an environment via code. There's a few reasons that containers might not be the right solution for you:

1. If you want to use a Windows desktop based development environment.
1. If you already have an OS, and just want to tweak that rather than deploy a new environment.

For those reasons devinit is about customizing the Windows environment you currently have.

## What about other VM creation tools (for example, Terraform, Packer, Chef, Vagrant, etc.)

There's lots of great tools for creating Windows images and you should use them! However, we couldn't find one that fulfilled all the scenarios we had in mind. We want devinit to be a tool for developers to customize their environment with whatever is needed for a particular repo and to have great integration with Visual Studio, rather than be a tool to create VM images.

## What about winget?

devinit isn't a package manager like winget, and we don't want it to be. We do want you to be able to use winget with devinit and we're working on a tool for just that.

## How are restarts handled?

If anything that devinit installs requires a reboot of the OS, then an error message will be outputted to the console. You'll need to then reboot the OS at a time that suits you. After rebooting, you might need to rerun devinit if all the dependencies weren't installed.

## Working with others

devinit is all about enabling the use of the wide ecosystem that's out there to deploy and configure the dependencies your app might have. While devinit has an opinion about what it delivers, devinit is mostly about enabling other tools to be executed from a declarative JSON file.

Today, devinit is just getting started and our [list of tools](devinit-tool-list.md) is just a beginning.
