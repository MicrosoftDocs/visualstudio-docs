---
title: Localization tools
description: Learn about the localization tools that are included in Visual Studio and how to use them to create localized applications in multiple languages.
ms.custom: SEO-VS-2020
ms.date: 02/15/2019
ms.topic: reference
helpviewer_keywords:
- globalization [Visual Studio]
- Visual Basic code, international applications
- C#, international applications
- localization [Visual Studio]
- world-ready applications
- international applications [Visual Studio]
ms.assetid: 4d9815ae-3e80-4b4d-933d-f8309aee18d5
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Develop globalized and localized apps

Visual Studio makes developing for an international audience easy by taking advantage of services built into [.NET](/dotnet/standard/globalization-localization/).

For example, the project system for Windows Forms apps can generate resource files for both the fallback UI culture and each additional UI culture. When you build a project in Visual Studio, the resource files are compiled from the Visual Studio XML format (.resx) to an intermediate binary format (.resources), which are then embedded in satellite assemblies. For more information, see [Resource files in Visual Studio](/dotnet/framework/resources/creating-resource-files-for-desktop-apps#VSResFiles) and [Create satellite assemblies for desktop apps](/dotnet/framework/resources/creating-satellite-assemblies-for-desktop-apps).

## Bidirectional languages

You can use Visual Studio to create applications that correctly display text in languages written right-to-left, including Arabic and Hebrew. For some features, you can simply set properties. In other cases, you must implement features in code.

> [!NOTE]
> In order to enter and display bidirectional languages, you must be working with a version of Windows that is configured with the appropriate language. This can either be an English version of Windows with the appropriate language pack installed, or the appropriately localized version of Windows.

### Apps that support bidirectional languages

- Windows apps

   You can create fully bidirectional applications that include support for bidirectional text, right-to-left reading order, and mirroring (reversing the layout of windows, menus, dialog boxes, and so on). Except for mirroring, these features are available by default or as property settings. Mirroring is supported inherently for some features, such as message boxes. However, in other cases you must implement mirroring in code. For more information, see [bidirectional support for Windows Forms applications](/dotnet/framework/winforms/advanced/bi-directional-support-for-windows-forms-applications).

- Web apps

   Web services support sending and receiving UTF-8 and Unicode text, making them suitable for applications that involve bidirectional languages. Web client applications rely on browsers for their user interface, so the degree of bidirectional support in a web application is dependent on how well the user's browser supports those bidirectional features. In Visual Studio, you can create applications with support for Arabic or Hebrew text, right-to-left reading order, file encoding, and local culture settings. For more information, see [Bidirectional support for ASP.NET web applications](/previous-versions/6eedwbtt(v=vs.140)).

> [!NOTE]
> Console apps do not include text support for bidirectional languages. This is a consequence of how Windows works with console applications.

## See also

- [Support for bidirectional languages in Visual Studio](use-bidirectional-languages.md)
- [Globalize and localize .NET apps](/dotnet/standard/globalization-localization/)
- [Resources in .NET apps](/dotnet/framework/resources/)