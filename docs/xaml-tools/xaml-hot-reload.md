---
title: "XAML Hot Reload for WPF and UWP apps"
description: Modify XAML code in running .NET MAUI, WinUI 3, Windows Presentation Foundation (WPF), or Universal Windows Platform (UWP) apps with edit and continue features in XAML Hot Reload.
ms.date: 04/24/2025
ms.topic: concept-article
helpviewer_keywords:
  - "xaml edit and continue"
  - "xaml hot reload"
author: maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: xaml-tools
monikerRange: ">=vs-2019"
---
# What is XAML Hot Reload? 

With XAML Hot Reload, you can incrementally build and test XAML code for your .NET MAUI, WPF, UWP, and WinUI 3 apps. You can do so with the benefit of the running app's data context, authentication state, and other real-world complexity that's hard to simulate during design-time.

> [!TIP]
> If you've arrived here by way of the XAML Hot Reload user interface (UI), welcome! You're in the right place to learn more about XAML Hot Reload.
>
> But, if you're here for help troubleshooting XAML Hot Reload, see [Troubleshooting XAML Hot Reload](/troubleshoot/developer/visualstudio/tools-utilities/xaml-hot-reload-troubleshooting) instead.

## Where to get XAML Hot Reload

Visual Studio XAML Hot Reload is supported when you're running an application in **Visual Studio** -or- **Blend for Visual Studio** (if supported by the framework) with the debugger attached (**F5** or **Start debugging**).

Starting in Visual Studio 2022 version 17.14 Preview 2, XAML Hot Reload and [XAML Live Preview](../xaml-tools/xaml-live-preview.md) are available at design-time and not just during a debugging session.

You can't enable this experience by using [Attach to process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md) unless you [manually set an environment variable](/troubleshoot/developer/visualstudio/tools-utilities/xaml-hot-reload-troubleshooting#verify-that-you-use-start-debugging-rather-than-attach-to-process).

## Scenarios for XAML Hot Reload

XAML Hot Reload is especially helpful in these scenarios:

* Fixing UI problems found in your XAML code.

* Building a new UI component for an app that is under development, while taking advantage of your app's runtime context.

## Supported OS

|Supported Application Types|Operating System and Tools|
|---|---|
|.NET MAUI|.NET 6+|
|Windows Presentation Foundation (WPF) |.NET Framework 4.6+, .NET Core, and .NET 5+</br>Windows 7 and later |
|Universal Windows apps (UWP)|Windows 10 and later, with the [Windows 10 SDK](https://developer.microsoft.com/windows/downloads/windows-sdk/) 14393+ and later|
|WinUI 3|Windows 10, version 1809 and later, with the Windows App SDK|

If you're using **.NET MAUI**, see [XAML Hot Reload for .NET MAUI](/dotnet/maui/xaml/hot-reload) for more details.

## Example

The following animation shows an instance of using Live Visual Tree to open some source code and then using XAML Hot Reload to change the text and color of a button.

:::image type="content" source="media/vs-2022/xaml-hot-reload-live-visual-tree.gif" alt-text="An animation of the Live Visual Tree opening source code and using XAML Hot Reload to change UI elements.":::

## Related content

* [Troubleshooting XAML Hot Reload](/troubleshoot/developer/visualstudio/tools-utilities/xaml-hot-reload-troubleshooting)
* [XAML Hot Reload for .NET MAUI](/dotnet/maui/xaml/hot-reload)
* [Edit and Continue (Visual C#)](../debugger/edit-and-continue-visual-csharp.md)
* [XAML data binding diagnostics](xaml-data-binding-diagnostics.md)
