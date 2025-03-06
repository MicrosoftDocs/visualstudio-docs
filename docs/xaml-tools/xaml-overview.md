---
title: Use the XAML code editor and XAML Designer tools
description: Get basic information about the Extensible Application Markup Language (XAML) and how to work with the XAML code editor and XAML Designer tools in Visual Studio.
ms.date: 06/23/2020
ms.topic: overview
author: maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: xaml-tools
---
# Overview of XAML

Extensible Application Markup Language (XAML) is a declarative language that's based on XML. XAML is used extensively in the following types of applications to build user interfaces:

- [Windows Presentation Foundation (WPF) apps](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [Universal Windows Platform (UWP) apps](/windows/uwp/xaml-platform/xaml-overview)
- [Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)
- [.NET MAUI apps](/dotnet/maui/xaml)

The following XAML code defines a simple button control.

```xaml
<Button Click="ButtonClick">Show updates</Button>
```

XAML is also used to define workflows in [Windows WorkFlow Foundation (WF) apps](/dotnet/framework/windows-workflow-foundation/serializing-workflows-and-activities-to-and-from-xaml).

## XAML code editor

The [XAML code editor](xaml-code-editor.md) in the Visual Studio IDE includes all the tools you need to create WPF and UWP apps for the Windows platform, and for Xamarin.Forms and .NET MAUI. And although the IDE (integrated development environment) in Visual Studio has many features that you can use to develop apps for other platforms, it also has some features that are unique to XAML, too.

## XAML Designer

Visual Studio and Blend for Visual Studio provide a [XAML Designer](creating-a-ui-by-using-xaml-designer-in-visual-studio.md) that helps you build user interfaces (UI) for WPF, UWP, and Xamarin.Forms apps. You can drag controls from the Toolbox or Assets window and set properties in the Properties window. When you do so, Visual Studio and Blend for Visual Studio create the corresponding XAML code. If you prefer to edit the XAML code directly, you can do that too.

## What's new

For the latest information, refer the following resources:

- The **[Improvements to XAML tooling in Visual Studio 2019 version 16.7 Preview 1](https://devblogs.microsoft.com/visualstudio/improvements-to-xaml-tooling-in-visual-studio-2019-version-16-7-preview-1/)** blog post
- The **[What’s new in XAML developer tools in Visual Studio 2019](https://devblogs.microsoft.com/visualstudio/whats-new-in-xaml-developer-tools-in-visual-studio-2019-for-wpf-uwp/)** blog post
- The **[New XAML features in Visual Studio](https://youtu.be/yI9OyA4ZM2E)** video on YouTube

## See also

- [XAML in WPF apps](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [XAML in UWP apps](/windows/uwp/xaml-platform/xaml-overview)
- [XAML in Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)
- [XAML in .NET MAUI apps](/dotnet/maui/xaml/)
