---
title: Visual Studio for Mac Tour
description: "Visual Studio for Mac provides an integrated development environment to build .NET applications on macOS, including ASP.NET Core websites and Xamarin projects for iOS, Android, Mac, and Xamarin.Forms."
author: heiligerdankgesang
ms.author: dominicn
ms.date: 11/09/2020
ms.assetid: 7DC64A52-AA41-4F3A-A8A1-8A20BCD81CC7
ms.custom: video
---

# Visual Studio 2019 for Mac tour

Visual Studio for Mac is a .NET _integrated development environment_ on the Mac that can be used to edit, debug, and build code and then publish an app. In addition to a code editor and debugger, Visual Studio for Mac includes compilers, code completion tools, graphical designers, and source control features to ease the software development process.

Visual Studio for Mac supports many of the same file types as its Windows counterpart, such as `.csproj`, `.fsproj`, or `.sln` files, and supports features such as EditorConfig, meaning that you can use the IDE that works best for you.
Creating, opening, and developing an app will be a familiar experience for anyone who has previously used Visual Studio on Windows. In addition, Visual Studio for Mac employs many of the powerful tools that make its Windows counterpart such a powerful IDE. The Roslyn Compiler Platform is used for refactoring and IntelliSense. Its project system and build engine use MSBuild, and its source editor uses the same foundation as Visual Studio on Windows. It uses the same debugger engines for Xamarin and .NET Core apps, and the same designers for Xamarin.iOS and Xamarin.Android.

## What can I do in Visual Studio for Mac

Visual Studio for Mac supports the following types of development:

- ASP.NET Core web applications with C#, F#, and support for Razor pages, JavaScript, and TypeScript
- .NET Core console applications with C# or F#
- Cross-platform Unity games and applications with C#
- Android, iOS, tvOS, and watchOS applications in Xamarin with C# or F# and XAML
- Cocoa desktop apps in C# or F#

This article explores various sections of Visual Studio for Mac, providing a look at some of the features that make it a powerful tool for creating these applications.

## IDE tour

Visual Studio for Mac is organized into several sections for managing application files and settings, creating application code, and debugging.

## Getting started

When you start Visual Studio 2019 for Mac for the first time, new users will see a sign-in window. Sign-in with your Microsoft account to activate a paid license (if you have one) or link to Azure subscriptions. You can press **I'll do this later** and sign in later via the **Visual Studio > Sign in** menu item:

![Sign in to your Microsoft account](media/ide-tour-2019-start-signin.png)

You'll then be given the option to customize the IDE by selecting your preferred keyboard shortcuts: Visual Studio for Mac, Visual Studio, Visual Studio Code, or Xcode:

![Select your favorite keyboard shortcuts](media/ide-tour-2019-keyboard-shortcut.png)

After this initial setup experience, you'll see the _start window_ whenever you open Visual Studio 2019 for Mac, which shows a list of recent projects, and buttons to open an existing project or create a new one:

![Choose from recent projects, or create something new](media/ide-tour-2019-start-projects.png)

## Solutions and projects

The following image shows Visual Studio for Mac with an application loaded:

![Visual Studio for Mac with an application loaded](media/ide-tour-image17.png)

The following sections provide an overview of the major areas in Visual Studio for Mac.

## Solution Window

The Solution Window organizes the project(s) in a solution:

![Projects organized in the Solution Window](media/ide-tour-image18.png)

This is where files for the source code, resources, user interface, and dependencies are organized into platform-specific Projects.

For more information on using Projects and Solutions in Visual Studio for Mac, see the [Projects and Solutions](./projects-and-solutions.md) article.

## Assembly references

Assembly references for each project are available under the References folder:

![References folder in the Solution Window](media/ide-tour-image19.png)

Additional references are added using the **Edit References** dialog, which is displayed by double-clicking on the References folder, or by selecting **Edit References** on its context menu actions:

![Edit References Dialog](media/ide-tour-image20.png)

For more information on using References in Visual Studio for Mac, see the [Managing References in a Project](./managing-references-in-a-project.md) article.

## Dependencies / packages

All external dependencies used in your app are stored in the Dependencies or Packages folder, depending on whether you are in a .NET Core or Xamarin.iOS/Xamarin.Android project. These are usually provided in the form of a NuGet.

NuGet is the most popular package manager for .NET development. With Visual Studio's NuGet support, you can easily search for and add packages to your project to application.

To add a dependency to your application, right-click on the Dependencies / Packages folder, and select **Add Packages**:

![Add a NuGet package](media/ide-tour-image21.png)

Information on using a NuGet package in an application can be found in the [Including a NuGet project in your project](./nuget-walkthrough.md) article.

## Source Editor

Regardless of if you're writing in C#, XAML, or JavaScript, the code editor the shares the same core components with Visual Studio on Windows, with an entirely native user interface.

This brings some of the following features:

* Native macOS (Cocoa-based) user interface (tooltips, editor surface, margin adornments, text rendering, IntelliSense)
* IntelliSense type filtering and "show import items"
* Support for native text inputs
* RTL/BiDi language support
* Roslyn 3
* Multi-caret support
* Word wrap
* Updated IntelliSense UI
* Improved find/replace
* Snippet support 
* Format selection
* Inline lightbulbs

For more information on using the Source Editor in Visual Studio for Mac, see the [Source Editor](./source-editor.md) documentation.

To keep tabs visible at all times, you can take advantage of pinning them. This ensures that every time you launch a project, the tab you need will always appear. To pin a tab, hover over the tab and click the _pin_ icon:

![Pinning a tab](media/ide-tour-tabpin.png)

## Refactoring

Visual Studio for Mac provides two useful ways to refactor your code: Context Actions, and Source Analysis. You can read more about them in the [Refactoring](./refactoring.md) article.

## Debugging

Visual Studio for Mac has debuggers that support .NET Core, .NET Framework, Unity, and Xamarin projects. Visual Studio for Mac uses the .NET Core debugger and the Mono Soft Debugger, allowing the IDE to debug managed code across all platforms. For additional information on debugging, visit the [Debugging](./debugging.md) article.

The debugger contains rich visualizers for special types such as strings, colors, URLs, as well as sizes, coordinates, and bézier curves.

For more information on the debugger's data visualizations, visit the [Data Visualizations](./data-visualizations.md) article.

## Version control

Visual Studio for Mac integrates with Git and Subversion source control systems. Projects under source control are denoted with the branch listed next to the Solution name:

![Branch name to indicate project under source control](media/ide-tour-image22.png)

Files with uncommitted changes have an annotation on their icons in the Solution Window, as illustrated in the following image:

![Uncommitted files in the Solution Window](media/ide-tour-image23.png)

For more information on using version control in Visual Studio, see the [Version Control](./version-control.md) article.

## Next steps

- [Install Visual Studio for Mac](installation.md)
- [Review the available workloads](workloads.md)

## Related Video

> [!Video https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Visual-Studio-for-Mac-Overview/player]

## See also

- [Visual Studio IDE (on Windows)](/visualstudio/ide/visual-studio-ide)