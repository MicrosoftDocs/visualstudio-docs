---
title: Visual Studio for Mac Tour
description: "Visual Studio for Mac provides an integrated development environment to build .NET applications on macOS, including ASP.NET Core websites and Xamarin projects for iOS, Android, Mac, and Xamarin.Forms."
author: heiligerdankgesang
ms.author: dominicn
ms.date: 02/07/2019
ms.assetid: 7DC64A52-AA41-4F3A-A8A1-8A20BCD81CC7
ms.custom: video
---

# Visual Studio 2017 for Mac tour

> [!NOTE]
> Visual Studio 2019 for Mac is [now available](installation.md).

Visual Studio for Mac is a .NET _integrated development environment_ on the Mac that can be used to edit, debug, and build code and then publish an app. In addition to expected features, such as a standard editor and debugger, Visual Studio for Mac includes compilers, code completion tools, graphical designers, and source control to ese the software development process.

Visual Studio for Mac supports many of the same file types as its Windows counterpart, such as `.csproj`, `.fsproj`, or `.sln` files, and supports features such as EditorConfig, meaning that you can use the IDE that works best for you.
Creating, opening, and developing an app will be a familiar experience for anyone who has previously used Visual Studio on Windows. In addition, Visual Studio for Mac employs many of the powerful tools that make its Windows counterpart such a powerful IDE. The Roslyn Compiler Platform is used for refactoring and IntelliSense. Its project system and build engine use MSBuild, and its source editor supports TextMate bundles. It uses the same debugger engines for Xamarin and .NET Core apps, and the same designers for Xamarin.iOS and Xamarin.Android.

## What can I do in Visual Studio for Mac

Visual Studio for Mac supports the following types of development:

- ASP.NET Core web applications with C#, F#, and support for Razor pages, JavaScript and TypeScript
- .NET Core console applications with C# or F#
- Cross-platform Unity games and applications with C#
- Android, iOS, tvOS, and watchOS applications in Xamarin with C# or F# and XAML
- Cocoa desktop apps in C# or F#

This article explores various sections of Visual Studio for Mac, providing a look at some of the features that make it a powerful tool for creating these applications.

## IDE Tour

Visual Studio for Mac is organized into several sections for managing application files and settings, creating application code, and debugging.

## Welcome Screen

When launched, Visual Studio for Mac displays a *Welcome Screen*:

![Welcome Screen](media/ide-tour-image1.png)

The Welcome Screen contains the following sections:

- **Toolbar** - Provides quick access to the search bar. When a solution is loaded, the toolbar is used to set app configurations, for debugging, and for displaying errors.
- **Getting Started** - Provides quick access to useful topics for developers getting started with Visual Studio for Mac.
- **Recent Solutions** - Provides quick access to recently opened solutions, as well as convenient buttons to open or create projects.
- **Developer News** - A news feed that keeps you up-to-date on the latest Microsoft Developer information.

## Solutions and Projects

The following image shows Visual Studio for Mac with an application loaded:

![Visual Studio for Mac with an application loaded](media/ide-tour-image17.png)

The following sections provide an overview of the major areas in Visual Studio for Mac.

## Solution Pad

The Solution Pad organizes the project(s) in a solution:

![Projects organized in Solution Pad](media/ide-tour-image18.png)

This is where files for the source code, resources, user interface, and dependencies are organized into platform-specific Projects.

For more information on using Projects and Solutions in Visual Studio for Mac, see the [Projects and Solutions](/visualstudio/mac/projects-and-solutions) article.

## Assembly References

Assembly references for each project are available under the References folder:

![References folder in solution pad](media/ide-tour-image19.png)

Additional references are added using the **Edit References** dialog, which is displayed by double-clicking on the References folder, or by selecting **Edit References** on its context menu actions:

![Edit References Dialog](media/ide-tour-image20.png)

For more information on using References in Visual Studio for Mac, see the [Managing References in a Project](/visualstudio/mac/managing-references-in-a-project) article.

## Dependencies / Packages

All external dependencies used in your app are stored in the Dependencies or Packages folder, depending on whether you are in a .Net Core or Xamarin.iOS/Xamarin.Android project. These are usually provided in the form of a NuGet.

NuGet is the most popular package manager for .NET development. With Visual Studio's NuGet support, you can easily search for and add packages to your project to application.

To add a dependency to your application, right-click on the Dependencies / Packages folder, and select **Add Packages**:

![Add a NuGet package](media/ide-tour-image21.png)

Information on using a NuGet package in an application can be found in the [Including a NuGet project in your project](/visualstudio/mac/nuget-walkthrough) article.

## Refactoring

Visual Studio for Mac provides two useful ways to refactor your code: Context Actions, and Source Analysis. You can read more about them in the [Refactoring](/visualstudio/mac/refactoring) article.

## Debugging

Visual Studio for Mac has a native debugger allowing debugging support for Xamarin.iOS, Xamarin.Mac, and Xamarin.Android applications. Visual Studio for Mac uses the Mono Soft Debugger, which is implemented into the Mono runtime, allowing the IDE to debug managed code across all platforms. For additional information on debugging, visit the [Debugging](/visualstudio/mac/debugging) article.

The debugger contains rich visualizers for special types such as strings, colors, URLs, as well as sizes, co-ordinates, and bézier curves.

For more information on the debugger's data visualizations, visit the [Data Visualizations](/visualstudio/mac/data-visualizations) article.

## Version Control

Visual Studio for Mac integrates with Git and Subversion source control systems. Projects under source control are denoted with the branch listed next to the Solution name:

![Branch name to indicate project under source control](media/ide-tour-image22.png)

Files with uncommitted changes have an annotation on their icons in the Solution Pane, as illustrated in the following image:

![Uncommitted files in solution pad](media/ide-tour-image23.png)

For more information on using version control in Visual Studio, see the [Version Control](/visualstudio/mac/version-control) article.

## Related Video

> [!Video https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Visual-Studio-for-Mac-Overview/player]

## See also

- [Visual Studio IDE (on Windows)](/visualstudio/ide/visual-studio-ide)
