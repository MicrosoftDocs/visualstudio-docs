---
title: "Introducing Visual Studio for Mac"
description: 
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: 3A130EC1-DD8C-4125-9034-B08D7AF7EA65
---

# Welcome to Mac!

Visual Studio for Mac is a modern, sophisticated IDE with many features for creating mobile, desktop, and web applications. It supports development of the following:

* Mobile with .NET: Android, iOS, tvOS, watchOS
* Mac desktop apps
* .NET Core applications
* ASP.NET Core Web applications
* Cross-platform Unity games

It includes a rich editor, debugging, native platform integration with iOS, Mac and Android, and integrated source control to name just of few of its many features.

This topic surveys various sections of Visual Studio for Mac, providing a look at some of the features that make it a powerful tool for creating cross-platform applications.

## Installation

Follow the steps in the [Installation](../installation.md) guide to download and Install Visual Studio for Mac.

## Language Support

Visual Studio for supports development in C# and F#, by default.

### C#

C# is the mostly commonly used language that can be used to create cross-platform applications in Visual Studio for Mac. This includes full support for all C# 6 features, which you can read more about in the [C# 6 New Features Overview](https://developer.xamarin.com/guides/cross-platform/advanced/csharp_six/).

### F#

F# is a strongly-typed functional programming language designed to run on .NET. It is available as a programming language to Visual Studio for Mac users on Android, Mac and iOS. For more information on using F# and to view samples created in the language, visit the [F#](https://developer.xamarin.com/guides/cross-platform/fsharp/) guides.

## Platform Support

## .NET Core

[.NET Core](https://www.microsoft.com/net/core#macos) is a platform for creating applications that run on Windows, Linux, and Mac. Visual Studio for Mac has support for loading, creating, running, and debugging .NET Core projects.

In order to run .NET Core projects the .NET Core SDK should be downloaded and installed.

.NET Core support includes:

* C# and F# IntelliSense.
* .NET Core project templates for console, library, and web applications.
* Full debugging support, including breakpoints, call stack, watch window, etc.
* NuGet PackageReferences and MSBuild-based restore.
* Integrated unit testing support for running and debugging tests with the Visual Studio Test Platform that is included with the  .NET Core SDK.
* Migration from old project.json format.

## Xamarin

First-class support for [Xamarin](https://developer.xamarin.com/) allows you to develop rich native experiences for Android, macOS, iOS, tvOS, and watchOS. Xamarin.Forms cross-platform applications help you share XAML-based UI code between Android, iOS, and macOS without limiting access to native functionality.

### Android

Visual Studio has its own integrated Android SDK manager.

For Android applications, Visual Studio for Mac includes its own designer, which works with Android `.axml` files to
visually construct user interfaces. Visual Studio for Mac will open these files in its Android designer, as shown below:

![](media/intro-image31.png)

For more information on the Android designer see the [Designer Overview](https://developer.xamarin.com/Android/Guides/User_Interface/Designer_Overview) document.

### iOS

The iOS Designer is fully integrated with Visual Studio for Mac and enables visual editing of .xib and Storyboard files to create iOS, tvOS, and WatchOS UIs and transitions. The entire user interface can be built using drag-and-drop functionality between the Toolbox and Design Surface, while using an intuitive approach to handling events. The iOS Designer also supports [custom controls](https://developer.xamarin.com/guides/ios/user_interface/designer/ios_designable_controls_overview/) with the added benefit of design-time rendering.

![](media/intro-image30.png)

For more information on using the iOS Designer, refer to the [Designer](https://developer.xamarin.com/guides/ios/user_interface/designer) documents.

### Mac

Xamarin provides native Mac API bindings allowing you to create beautiful Mac applications.

For more information on using writing Mac applications with Visual Studio for Mac, refer to the [Xamarin.Mac](https://developer.xamarin.com/guides/#mac) documentation.

## Gaming

Visual Studio for Mac provides support for cross-platform games development with Unity 5.6.1.

Xamarin provides a number of powerful game development libraries, allowing you to create beautiful and exciting games within Visual Studio for Mac for Xamarin.Android and Xamarin.iOS:

* [CocosSharp](https://developer.xamarin.com/guides/cross-platform/game_development/cocossharp/)
* [MonoGames](https://developer.xamarin.com/guides/cross-platform/game_development/monogame/)
* [UrhoSharp](https://developer.xamarin.com/guides/cross-platform/game_development/urho/)

It also provides a 2D graphics drawing API, [SkiaSharp](https://developer.xamarin.com/guides/cross-platform/drawing/).

### Integration with additional Xamarin Products

Visual Studio for Mac has built in integration for [Xamarin Test Cloud](https://developer.xamarin.com/guides/testcloud/introduction-to-test-cloud/). This can be added automatically when creating a new supported project that is supported by the platform:

![](media/intro-testcloud.png)

### Using the Profiler

The preview version of Xamarin Profiler has three instruments available for profiling. The [Introduction to the Xamarin Profiler](https://developer.xamarin.com/guides/cross-platform/deployment,_testing,_and_metrics/xamarin-profiler/) guide explores what these instruments measure and how they analyze your application, and clarifies the meaning of the data presented on each screen.

The Profiler can only be used with a Xamarin Enterprise subscription.

### Using the Inspector

The Xamarin Inspector brings an interactive C# console with tools to users. It can be used as a debugging or diagnostics aid when inspecting live applications, as a teaching tool, as a documentation tool or an experimentation tool.

It consists of a standalone application that provides a rich C# console that can target various programming platforms (Android, iOS, Mac and Windows) as well as integrating into the debugging workflow of your IDE.

The Inspector can only be used with a Xamarin Enterprise subscription.

For more information refer to the [Xamarin Inspector](https://developer.xamarin.com/guides/cross-platform/inspector/) guide.

### Using Workbooks

Xamarin Workbooks provide a blend of documentation and code that is perfect for experimentation, learning, and creating guides and teaching aids. Create a rich C# workbook for Android, iOS, Mac, or WPF, and get instant live results as you learn these APIs.

For more information refer to the [Xamarin Workbooks](https://developer.xamarin.com/guides/cross-platform/workbooks/) guide.


## First steps

* **Get the big picture** - To get an overview of many of the major features in Visual Studio for Mac, see the Visual Studio for Mac [IDE Tour](~/ide-tour.md)
* **Setup** - To learn about how to download and install Visual Studio, see the [Installation](~/installation.md) guide.
Settings - To learn how to customize Visual Studio to fit the way you like to work. See Personalizing the Visual Studio IDE.
* **Xamarin Tutorials** - To learn more about how to develop code with Xamarin, go to the Xamarin [Developer Center](https://developer.xamarin.com)
* **Videos** - To learn more about other features and aspects of Visual Studio for Mac, check out videos on the [Xamarin University](https://university.xamarin.com)