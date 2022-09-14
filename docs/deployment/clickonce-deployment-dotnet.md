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
# ClickOnce for .NET 5/6

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

This article describes the differences between ClickOnce for .NET 5+ versus and ClickOnce for .NET Framework.

## ClickOnce UI

.NET 5+ uses the Publish tool instead of the old Publish Wizard & properties pages. The Publish tool creates a pubxml file.
For MSBUILD command line, you need to specify the pubxml file (details)

## ApplicationDeployment class

Not supported in .NET 5+
 
## Mage.exe

.NET 5+ uses dotnetmage.exe instead
 
## URL rewrites

Not (currently) supported in .NET 5+
 
## Unsupported Publish properties on .NET 5+

Enable ClickOnce Security Settings (Security setting)
TargetZone (Security setting)
UpdateMode > Background 
UpdateInterval
UpdateIntervalUnits