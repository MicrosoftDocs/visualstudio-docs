---
title: "Write and debug XAML code by using XAML Hot Reload"
description: "XAML Hot Reload, or XAML edit and continue, allows you to make changes to your XAML code while running apps"
ms.date: 11/08/2021
ms.topic: conceptual
helpviewer_keywords:
  - "xaml edit and continue"
  - "xaml hot reload"
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.custom: "contperf-fy22q1"
ms.technology: vs-xaml-tools
ms.workload:
  - "multiple"
---
# XAML Hot Reload: Write and debug your WPF and UWP apps while they're running

With XAML Hot Reload, you can incrementally build and test XAML code with the benefit of the running app's data context, authentication state, and other real-world complexity that's hard to simulate during design-time.

> [!TIP]
> If you've arrived here by way of the XAML Hot Reload user interface (UI), welcome! You're in the right place to learn more about XAML Hot Reload.
>
> But, if you're here for help troubleshooting XAML Hot Reload, see [Troubleshooting XAML Hot Reload](xaml-hot-reload-troubleshooting.md) instead.

Available in both Visual Studio and Blend for Visual Studio, XAML Hot Reload is especially helpful in these scenarios:

* Fixing UI problems found in your XAML code after the app was started in debug mode.

* Building a new UI component for an app that is under development, while taking advantage of your app's runtime context.

|Supported Application Types|Operating System and Tools|
|-|-|-|
|Windows Presentation Foundation (WPF) |.NET Framework 4.6+ and .NET Core</br>Windows 7 and later |
|Universal Windows apps (UWP)|Windows 10 and later, with the [Windows 10 SDK](https://developer.microsoft.com/windows/downloads/windows-10-sdk) 14393+ and later|

> [!NOTE]
> If you're using Xamarin.Forms, see [XAML Hot Reload for Xamarin.Forms](/xamarin/xamarin-forms/xaml/hot-reload).

The following animation shows an instance of using Live Visual Tree to open some source code and then using XAML Hot Reload to change the text and color of a button.

:::image type="content" source="media/vs-2022/xaml-hot-reload-live-visual-tree.gif" alt-text="An animation of the Live Visual Tree opening source code and using XAML Hot Reload to change UI elements.":::

> [!NOTE]
> Visual Studio XAML Hot Reload is currently supported only when you're running an application in Visual Studio or Blend for Visual Studio with the debugger attached (**F5** or **Start debugging**). You can't enable this experience by using [Attach to process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md) unless you [manually set an environment variable](xaml-hot-reload-troubleshooting.md#verify-that-you-use-start-debugging-rather-than-attach-to-process).

## Known limitations

The following are known limitations of XAML Hot Reload. To work around any limitation that you run into, just stop the debugger, and then complete the operation.

|Limitation|WPF|UWP|Notes|
|-|-|-|-|
|Wiring events to controls while the app is running|Not Supported|Not supported|See error: *Ensure Event Failed*. In WPF, you can reference an existing event handler. In UWP apps, referencing an existing event handler isn't supported.|
|Creating resource objects in a resource dictionary such as those in your app's Page/Window or *App.xaml*|Supported starting in Visual Studio 2019 [version 16.2](/visualstudio/releases/2019/release-notes-v16.2) and later|Supported|Examples: <br>- Adding a `SolidColorBrush` into a resource dictionary for use as a `StaticResource`.</br>Note: Static resources, style converters, and other elements written into a resource dictionary can be applied/used while using XAML Hot Reload. Only the creation of the resource isn't supported.</br> - Changing the resource dictionary `Source` property.|
|Adding new controls, classes, windows, or other files to your project while the app is running|Not Supported|Not Supported|None|
|Managing NuGet packages (adding/removing/updating packages)|Not Supported|Not Supported|None|
|Changing data binding that uses the {x:Bind} markup extension|N/A|Supported starting in Visual Studio 2019|This requires Windows 10 version 1809 (build 10.0.17763) and later. Not supported in Visual Studio 2017 or previous versions.|
|Changing x:Uid directives isn't supported|N/A|Not Supported|None|
|Using multiple processes | Supported | Supported | Supported in Visual Studio 2019 [version 16.6](/visualstudio/releases/2019/release-notes-v16.6) and later. |

## Error messages

You might come across the following errors while using XAML Hot Reload.

|Error message|Description|
|-|-|
|Ensure Event Failed|Error indicates you're attempting to wire an event to one of your controls, which isn't supported while your application is running.|
|This change isn't supported by XAML Hot Reload and won't be applied during the debugging session.|Error indicates that the change you're attempting isn't supported by XAML Hot Reload. Stop the debugging session, make the change, and then restart the debugging session.  |

If you find an unsupported scenario that you'd like to see supported, let us know by using our [Suggest a feature](../ide/suggest-a-feature.md) option.

## See also

* [Troubleshooting XAML Hot Reload](xaml-hot-reload-troubleshooting.md)
* [XAML Hot Reload for Xamarin.Forms](/xamarin/xamarin-forms/xaml/hot-reload)
* [Edit and Continue (Visual C#)](../debugger/edit-and-continue-visual-csharp.md)
