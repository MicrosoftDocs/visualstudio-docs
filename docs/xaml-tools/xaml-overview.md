---
title: XAML overview
ms.date: 07/31/2019
ms.topic: reference
author: jillre
ms.author: jillfra
manager: jillfra
---
# Overview of XAML

Extensible Application Markup Language (XAML) is a declarative language that's based on XML. XAML is used extensively in the following types of applications to build user interfaces:

- [Windows Presentation Foundation (WPF) apps](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [Universal Windows Platform (UWP) apps](/windows/uwp/xaml-platform/xaml-overview)
- [Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)

The following XAML code defines a simple button control.

```xaml
<Button Click="ButtonClick">Show updates</Button>
```

XAML is also used to define workflows in [Windows WorkFlow Foundation (WF) apps](/dotnet/framework/windows-workflow-foundation/serializing-workflows-and-activities-to-and-from-xaml).

## XAML Designer

Visual Studio and Blend for Visual Studio provide a XAML Designer that helps you build user interfaces (UI) for WPF, UWP, and Xamarin.Forms apps. You can drag controls from the Toolbox or Assets window and set properties in the Properties window. When you perform these actions, Visual Studio and Blend for Visual Studio create the corresponding XAML code. If you prefer to edit the XAML code directly, you can do that too.

The articles in this documentation set discuss the XAML Designer in Visual Studio and Blend for Visual Studio.

## See also

- [XAML in WPF apps](/dotnet/framework/wpf/advanced/xaml-in-wpf)
- [XAML in UWP apps](/windows/uwp/xaml-platform/xaml-overview)
- [XAML in Xamarin.Forms apps](/xamarin/xamarin-forms/xaml/)