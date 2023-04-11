---
title: "XAML Hot Reload for WPF and UWP apps"
description: "XAML Hot Reload, or XAML edit and continue, allows you to make changes to your XAML code while running apps"
ms.date: 02/25/2022
ms.topic: conceptual
helpviewer_keywords:
  - "xaml edit and continue"
  - "xaml hot reload"
author: maddymontaquila
ms.author: maleger
manager: jmartens
ms.custom: "contperf-fy22q1"
ms.technology: vs-xaml-tools
ms.workload:
  - "multiple"
monikerRange: ">=vs-2019"
---
# What is XAML Hot Reload for WPF and UWP apps? (Visual Studio)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

With XAML Hot Reload, you can incrementally build and test XAML code for your WPF and UWP apps. You can do so with the benefit of the running app's data context, authentication state, and other real-world complexity that's hard to simulate during design-time.

> [!TIP]
> If you've arrived here by way of the XAML Hot Reload user interface (UI), welcome! You're in the right place to learn more about XAML Hot Reload.
>
> But, if you're here for help troubleshooting XAML Hot Reload, see [Troubleshooting XAML Hot Reload](xaml-hot-reload-troubleshooting.md) instead.

## Where to get XAML Hot Reload

Visual Studio XAML Hot Reload is currently supported only when you're running an application in **Visual Studio** -or- **Blend for Visual Studio** with the debugger attached (**F5** or **Start debugging**).

You can't enable this experience by using [Attach to process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md) unless you [manually set an environment variable](xaml-hot-reload-troubleshooting.md#verify-that-you-use-start-debugging-rather-than-attach-to-process).

## Applications for XAML Hot Reload

XAML Hot Reload is especially helpful in these scenarios:

* Fixing UI problems found in your XAML code after the app was started in debug mode.

* Building a new UI component for an app that is under development, while taking advantage of your app's runtime context.

## Supported OS

|Supported Application Types|Operating System and Tools|
|-|-|-|
|Windows Presentation Foundation (WPF) |.NET Framework 4.6+ and .NET Core</br>Windows 7 and later |
|Universal Windows apps (UWP)|Windows 10 and later, with the [Windows 10 SDK](https://developer.microsoft.com/windows/downloads/windows-sdk/) 14393+ and later|

If you're using **Xamarin.Forms**, see [XAML Hot Reload for Xamarin.Forms](/xamarin/xamarin-forms/xaml/hot-reload).

## Example

The following animation shows an instance of using Live Visual Tree to open some source code and then using XAML Hot Reload to change the text and color of a button.

:::image type="content" source="media/vs-2022/xaml-hot-reload-live-visual-tree.gif" alt-text="An animation of the Live Visual Tree opening source code and using XAML Hot Reload to change UI elements.":::

## See also

* [Troubleshooting XAML Hot Reload](xaml-hot-reload-troubleshooting.md)
* [XAML Hot Reload for Xamarin.Forms](/xamarin/xamarin-forms/xaml/hot-reload)
* [Edit and Continue (Visual C#)](../debugger/edit-and-continue-visual-csharp.md)
* [XAML data binding diagnostics](xaml-data-binding-diagnostics.md)
