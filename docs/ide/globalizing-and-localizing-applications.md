---
title: Localization tools
ms.date: 02/15/2019
ms.topic: reference
helpviewer_keywords:
  - "globalization [Visual Studio]"
  - "Visual Basic code, international applications"
  - "C#, international applications"
  - "localization [Visual Studio]"
  - "world-ready applications"
  - "international applications [Visual Studio]"
ms.assetid: 4d9815ae-3e80-4b4d-933d-f8309aee18d5
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Develop globalized and localized apps

Visual Studio makes developing for an international audience easy by taking advantage of services built into [.NET](/dotnet/standard/globalization-localization/).

For example, the project system for Windows Forms apps can generate resource files for both the fallback UI culture and each additional UI culture. When you build a project in Visual Studio, the resource files are compiled from the Visual Studio XML format (.resx) to an intermediate binary format (.resources), which are then embedded in satellite assemblies. For more information, see [Resource files in Visual Studio](/dotnet/framework/resources/creating-resource-files-for-desktop-apps#VSResFiles) and [Create satellite assemblies for desktop apps](/dotnet/framework/resources/creating-satellite-assemblies-for-desktop-apps).

For information about creating apps for bidirectional languages in Visual Studio, see [Create apps for Arabic and Hebrew](creating-applications-in-bi-directional-languages.md).

## See also

- [Globalize and localize .NET apps](/dotnet/standard/globalization-localization/)
- [Resources in .NET apps](/dotnet/framework/resources/)