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

## Step 1: Determining dependencies

As mentioned in the [getting started page](getting-started-with-devinit.md), the first step is always to determine which dependencies and setup steps the project has. This will vary based on the specific project, but there are a few questions to consider:

- What runtimes or SDKs does my project depend on?
- Does my project require any packages (e.g. from Chocolatey)?
- Does my setup process require any actions to be taken (e.g. running a script)?
- Does my project have implicit dependencies on anything that is installed alongside Visual Studio?
  - If so, it's a good idea to include these in your devinit setup as well. That way, you can avoid coupling to the Visual Studio installation.

For eShopOnWeb, there are a few things we need to handle:

- Installing the latest version of the .NET Core SDK
- Installing the latest version of the .NET Entity Framework Core Tools CLI
- Installing SQL Server 2017 Express LocalDB
- Use the .NET Entity Framework CLI to update the local database to the latest migration

Next, we'll explore how to accomplish all of this in the context of devinit.

## Step 2: Constructing our setup steps

## Step 3: The .devinit.json

## Step 4: The setup script

## Step 5: The .devcontainer.json

## Step 6 (?)