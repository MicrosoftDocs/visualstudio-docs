---
title: Devinit tutorial
description: Tutorial for devinit.
ms.date: 11/12/2020
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
# Devinit Tutorial

In this tutorial, we'll explore setting up the [eShopOnWeb repository](https://github.com/andysterland/eShopOnWeb) with devinit. This tutorial assumes that devinit is already available, as described in the [getting started page](getting-started-with-devinit.md).

## Step 1: Determining setup steps

As mentioned in the [getting started page](getting-started-with-devinit.md), the first step is always to determine which dependencies and setup steps your project has. This will vary based on the specific project, but there are a few questions to consider:

- What runtimes or SDKs does your project depend on?
- Does your project require any packages (for example, from Chocolatey)?
- Does your setup process require any actions to be taken (for example, running a script)?
- Does your project have implicit dependencies on anything that is installed alongside Visual Studio?
  - If so, it's a good idea to include these in your devinit setup as well. That way, you can avoid coupling to the Visual Studio installation.

One of the best ways to determine this information is by exploring the manual setup steps you currently have for your repository. For eShopOnWeb, there are a few things we need to handle:

- Installing the latest version of the .NET Core SDK
- Installing the latest version of the .NET Entity Framework Core Tools CLI
- Installing SQL Server 2017 Express LocalDB
- Use the .NET Entity Framework CLI to update the local database to the latest migration

Next, we'll explore how to accomplish all of this in the context of devinit.

## Step 2: The .devinit.json

## Step 3: The setup script

## Step 4: The .devcontainer.json

## Step 5 (?)