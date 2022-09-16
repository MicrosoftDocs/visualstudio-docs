---
title: ClickOnce for .NET 5+
description: "Learn about differences between ClickOnce for .NET 5+ versus ClickOnce for .NET Framework."
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
# ClickOnce for .NET 5+

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

This article describes the differences between ClickOnce for .NET 5+ versus ClickOnce for .NET Framework.

## Publish tool

Starting in Visual Studio 2019, ClickOnce for .NET 5+ uses the Publish tool instead of the Publish Wizard and properties pages. The Publish tool creates a *.pubxml* file. Most of the properties previously available in the wizard are available to configure in the Publish tool. For detailed instructions, see [Deploy a .NET Windows application using ClickOnce](../deployment/quickstart-deploy-using-clickonce-folder.md).

## MSBUILD

For building from the command line using MSBUILD, you need to specify the *.pubxml* file. For more information, see [Build .NET ClickOnce applications from the command line](../deployment/building-clickonce-applications-from-the-command-line.md#build-net-clickonce-applications-from-the-command-line).

## ApplicationDeployment class

In .NET 5+, you don't have programmatic access to the <xref:System.Deployment.Application.ApplicationDeployment> class or to APIs in the <xref:System.Deployment.Application> namespace.

## Mage.exe

In .NET 5+, use *dotnetmage.exe* instead of [Mage.exe](../deployment/clickonce-security-and-deployment.md#clickonce-tools) to create the ClickOnce deployment.

## URL rewrites

URL rewrites are not currently supported in ClickOnce for .NET 5+.

## Unsupported Publish properties on .NET 5+

For more information about these properties, see [Publish properties](../deployment/building-clickonce-applications-from-the-command-line.md#publish-properties).

Security settings

- Enable ClickOnce Security Settings
- TargetZone

Update settings

- UpdateMode > Background 
- UpdateInterval
- UpdateIntervalUnits