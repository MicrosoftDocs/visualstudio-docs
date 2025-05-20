---
title: ClickOnce for .NET 5 and later on Windows
description: Discover the differences between ClickOnce for .NET Core 3.1 and .NET 5 and later versions, versus ClickOnce for .NET Framework.
ms.date: 05/16/2025
ms.topic: how-to
helpviewer_keywords:
  - "deployment, ClickOnce for .NET 5+"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
monikerRange: '>= vs-2019'
---
# ClickOnce for .NET on Windows

This article describes the differences between ClickOnce for .NET Core 3.1, .NET 5, and later, versus ClickOnce for .NET Framework.

## Publish tool

Starting in Visual Studio 2019, ClickOnce for .NET Core 3.1 and .NET 5 or later uses the Publish tool instead of the Publish Wizard and properties pages. The Publish tool creates a *.pubxml* file, called a *publish profile*. Most of the properties previously available in the wizard are available to configure in the Publish tool. For detailed instructions, see [Deploy a .NET Windows application using ClickOnce](../deployment/quickstart-deploy-using-clickonce-folder.md).

## MSBUILD

For building from the command line using MSBUILD, you need to specify the *.pubxml* file. For more information, see [Build .NET ClickOnce applications from the command line](../deployment/building-dotnet-clickonce-applications-from-the-command-line.md).

## ApplicationDeployment class

In .NET Core 3.1, .NET 5, and .NET 6, you don't have programmatic access to the <xref:System.Deployment.Application.ApplicationDeployment> class or to other APIs in the <xref:System.Deployment.Application> namespace.

::: moniker range=">=vs-2022"
Starting in .NET 7, you can access properties in the `ApplicationDeployment` class using environment variables. For more information, see [Access ClickOnce deployment properties in .NET](../deployment/access-clickonce-deployment-properties-dotnet.md).
::: moniker-end

## Mage.exe

In .NET Core 3.1 and .NET 5 and later, use *dotnet-mage.exe* instead of [Mage.exe](../deployment/clickonce-security-and-deployment.md#clickonce-tools) to create the ClickOnce deployment.

You can install *dotnet-mage.exe* using the [NuGet package](https://www.nuget.org/packages/Microsoft.DotNet.Mage/).

To access activation data using *dotnet-mage.exe*, see [Access ClickOnce activation data for .NET](../deployment/access-clickonce-activation-data-dotnet.md).

## Unsupported Publish properties on .NET Core 3.1 and .NET 5 and later

Security settings

- [Enable ClickOnce Security Settings](../deployment/code-access-security-for-clickonce-applications.md) (Code access security)
- [TargetZone](../deployment/securing-clickonce-applications.md#zones)

Update settings

- [UpdateInterval](../deployment/choosing-a-clickonce-update-strategy.md#specify-update-intervals)
- [UpdateIntervalUnits](../deployment/choosing-a-clickonce-update-strategy.md#specify-update-intervals)
- [UpdateMode > Background](../deployment/building-clickonce-applications-from-the-command-line.md#publish-properties)