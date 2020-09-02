---
title: Frequently Asked Questions
description: Frequently asked questions for the devinit tool and customization of Codespaces for Visual Studio.
ms.date: 08/28/2020
ms.topic: reference
author: andster
ms.author: andster
manager: jillfra
ms.workload:
- multiple
---
# Frequently asked questions

## Is devinit just for Codespaces for Visual Studio 2019?

For now `devinit` is only available as part of the Private Preview of Visual Studio 2019 for Codespaces.

## There's no tool for the dependency I need!

We're sorry! If you're part of the private preview for Codespaces with Visual Studio 2019, you can get back to us through the feedback channel for the private preview. If you're not part of the private preview we'd still love your feedback on what you need, and you can file an issue on our [Visual Studio Docs](https://github.com/MicrosoftDocs/visualstudio-docs/) with the label `devinit` to request support for the tool you need.

## Something went wrong, how do I debug?

If `devinit` is failing the first thing to try is the `--verbose / -v` flag to get more information. Likely the underlying tool that `devinit` is calling into is encountering an issue. The verbose log information should include a clue as to where to look next.

## Why not just a script?

Setting up environments via a script is a time old technique and can work great. If it works for you, then use it! `devinit` is another option for developers for when scripts aren't the best choice.

## Why not a container?

Containers, and docker, are great tools to deploy an environment via code. There's a few reasons that containers might not be the right solution for you:

1. If you want to use a Windows Client based development environment.
1. If you already have an OS and just want to tweak that rather than deploy a new environment.

For those reasons `devinit` is about customizing the Windows environment you currently have.

## Working with others

`devinit` is all about enabling the use of the wide ecosystem that's out there to deploy and configure the dependencies your app might have. `devinit` has an opionon on some things and might deliver those things, `devinit` is mostly about enabling other tools to be executed from a declative json file.

Today, `devinit` is just getting started and our [list of tools](devinit-tool-list) is just a beginning.