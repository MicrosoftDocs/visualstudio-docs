---
title: "Visual Studio Installer Projects | Microsoft Docs"
ms.date: "12/03/2019"
ms.topic: "conceptual"
helpviewer_keywords:
  - "installer projects"
  - "installer projects, overview"
author: ruconard
ms.author: ruconard
manager: ruconard
ms.workload:
  - "multiple"
---
# Visual Studio Installer Projects Extension

Packaging applications as an MSI is often accomplished using the Visual Studio Installer Projects Extension.

You can download the extension here:
[Visual Studio Installer Projects](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2017InstallerProjects)

## Update for .NET Core
1. Pick “PublishItemsOutputGroup” instead of “Primary Output” to get the correct output for .Net Core 3.x projects.
2. To create a self-contained installer, set the “PublishProfilePath” property on the “PublishItemsOutputGroup” node in the setup project to the relative path a publish profile with the correct properties set.
