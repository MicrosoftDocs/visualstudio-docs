---
title: ClickOnce for .NET 5 and later on Windows
description: "Learn about differences between ClickOnce for .NET Core 3.1, .NET 5 and later versus ClickOnce for .NET Framework."
ms.date: 09/14/2022
ms.topic: how-to
helpviewer_keywords:
  - "deployment, ClickOnce for .NET 5+"
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
monikerRange: '>= vs-2019'
ms.workload:
  - "multiple"
---
# ClickOnce for .NET on Windows

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

This article describes the differences between ClickOnce for .NET Core 3.1, .NET 5, and later, versus ClickOnce for .NET Framework.

## Publish tool

Starting in Visual Studio 2019, ClickOnce for .NET Core 3.1 and .NET 5 or later uses the Publish tool instead of the Publish Wizard and properties pages. The Publish tool creates a *.pubxml* file, called a *publish profile*. Most of the properties previously available in the wizard are available to configure in the Publish tool. For detailed instructions, see [Deploy a .NET Windows application using ClickOnce](../deployment/quickstart-deploy-using-clickonce-folder.md).

## MSBUILD

For building from the command line using MSBUILD, you need to specify the *.pubxml* file. For more information, see [Build .NET ClickOnce applications from the command line](../deployment/building-clickonce-applications-from-the-command-line.md#build-net-clickonce-applications-from-the-command-line).

## ApplicationDeployment class

In .NET Core 3.1 and .NET 5 and later, you don't have programmatic access to the <xref:System.Deployment.Application.ApplicationDeployment> class or to other APIs in the <xref:System.Deployment.Application> namespace.

## Mage.exe

In .NET Core 3.1 and .NET 5 and later, use *dotnetmage.exe* instead of [Mage.exe](../deployment/clickonce-security-and-deployment.md#clickonce-tools) to create the ClickOnce deployment.

## Unsupported Publish properties on .NET Core 3.1 and .NET 5 and later

Security settings

- [Enable ClickOnce Security Settings](../deployment/code-access-security-for-clickonce-applications) (Code access security)
- [TargetZone](../deployment/securing-clickonce-applications.md#zones)

Update settings

- [UpdateInterval](../deployment/choosing-a-clickonce-update-strategy.md#specify-update-intervals)
- [UpdateIntervalUnits](../deployment/choosing-a-clickonce-update-strategy.md#specify-update-intervals)
- [UpdateMode > Background](../deployment/building-clickonce-applications-from-the-command-line.md#publish-properties)