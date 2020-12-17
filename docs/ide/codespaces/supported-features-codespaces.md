---
title: Supported Visual Studio features (Preview)
description: Learn about the Visual Studio IDE features available when working with GitHub Codespaces.
ms.topic: how-to
ms.date: 09/21/2020
author: gregvanl
ms.author: gregvanl
manager: jillfra
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: vs-2019
---

# Supported Visual Studio features (Preview)

Visual Studio provides a rich development experience when connecting to a codespace. You get the Visual Studio inner-loop tools you're familiar with to edit, debug, test, and version your source code as well as productivity features like project templates, rich code navigation, and IntelliSense.

In the current GitHub Codespaces [public beta](https://github.com/features/codespaces), some Visual Studio features may not have full support or may be initially missing. The following sections outline what you can expect with Visual Studio and the GitHub Codespaces beta and what you can look forward to in the future. 

This is **not meant to be an exhaustive list**, but to explain Visual Studio's general capabilities when connected to a codespace.

> [!NOTE]
> If there is a feature you are missing while using codespaces with Visual Studio, please let us know by opening an issue on [Visual Studio Developer Community](https://aka.ms/feedback/report?space=8). This helps us prioritize the most wanted features.

> [!NOTE]
> The features described below are for Visual Studio and not the two other GitHub Codespaces clients; Visual Studio Code and the in-browser editor.

## Edit and navigation

You should notice little difference editing source code in a codespace as you get smart language features like IntelliSense, code navigation, diagnostics, and suggestions.

* IntelliSense*
* Code navigation*
* Code formatting with Format Document
* Syntax highlighting
* Quick Info*
* HTML, CSS, Razor editors* - Partial support.
* JavaScript and TypeScript editor* - Partial support.

Not yet available:

* IntelliSense* - Some of the autocompletion/member list filters are unavailable. Completion for unimported types and IntelliSense in watch window not yet available.
* Code navigation* - Most commands supported. Go To Base and Find in Files with path specification are not yet supported.
* Quick Info* - Colorization in quick info is not supported.
* HTML, CSS, Razor editors* - Diagnostics, IntelliSense completion, quick info, smart indent. Currently no support for semantic colorization, navigation commands, etc.
* JavaScript and TypeScript editor* - Script blocks (for example, JavaScript content in HTML and CSHTML files) and semantic highlighting are not yet supported. Known issues with lightbulb features and linting.
* CMake Targets View
* CMake Project Settings editor
* Ctrl+F7 (compile file)
* CodeLens
* Code snippets
* IntelliCode

## Application types and configuration

Most application types and project configurations are supported, but you will need to edit your project code directly without the help of visual designers. For more configuration guidance, see [How to customize a codespace](customize-codespaces.md).

* Project and item templates
* .NET Core and ASP.NET Core projects
* C++ console apps - CMake and vcxproj supported
* C++ apps that target Linux - Mostly supported for non-GUI. Ability to install and provision WSL, platform-specific IntelliSense, and build.
* Project file editing - Mostly supported. Missing some completion, syntax highlighting, and advanced editing features.
* GitHub accounts - Can be used to create and connect to Codespaces, and access resources available to the account on GitHub.
* Azure CLI - Does not share the signed-in Visual Studio identity or keychain accounts. Browser-based login is not supported but you can authenticate inside the integrated terminal using: `az login --use-device-code`.

Not yet available:

* UI designers - WinForms, WPF, and Resource designers
* Visual Basic and F# projects
* .NET Framework targeted projects
* Docker Compose projects
* Project property pages
* Authentication options in ASP.NET Core templates
* Apps that require a GUI to install - Anything that can be installed with the terminal is supported (including the chocolatey installer), but the actual GUI won't be immediately available. Enabling full screen Live Share to access the GUIs is a current workaround. Administration consoles are not accessible. Apps that require a reboot to install aren't supported.
* Managed identities for Azure resources in Visual Studio
* Intranet resources (private network) - Currently, codespaces won't be able to connect to any resource that requires a VPN.
* Extensions - No extensions are supported when using Codespaces with Visual Studio.

## Debugging

Essential inner loop debugging is supported including setting breakpoints, basic stepping into code, inspecting variables, and the local, autos, and watch windows. Some additional windows, customizations, and visualizers are not supported.

* Breakpoints*
* Basic stepping
* Locals, autos, watch windows* - Partial support.
* Symbol server, source server, and importing/exporting data tips are all partially supported.

Not yet available:

* Breakpoints* - Breakpoint labels, Data breakpoints, and Set breakpoint in Disassembly window is in progress. Importing and exporting breakpoints is partially supported.
* Locals, autos, watch windows* - Some functionality such as statement completion in search box and search box navigation.
* UI customizations - Pinnable properties and hide template parameters not supported.
* Visualizers - C++ natvis partially supported. Disassembly window, XAML Visual diagnostics, Custom .NET Visualizers, and Dataset Visualizers are not supported.
* Additional debugger windows - Processes windows partially supported. Parallel Stacks window - Tasks View, Diagnostics Hub, and Find source/symbol dialog are not supported.
* Some debugger workflows - Attach to process, Just in Time (JIT) debugger, Dump debugging, Profiling, and IntelliTrace are not supported. C++ Just My Code stepping is partially supported.
* Edit and Continue - Not supported for both managed and native code.
* Threading features - Freeze/thaw threads, Rename thread, and show threads in source are not supported.
* Additional stepping features - Automatic Step over properties and operators (.NET Core) and Step into Specific are not supported. 

## Features

When working with Visual Studio connected to a codespace, you get the same accessibility features as when working locally.

* Source Control - Full Git support through the new [Git window](https://devblogs.microsoft.com/visualstudio/improved-git-experience-in-visual-studio-2019/).
* Accessibility - There is one known issue with assistive technology not being able to access the appcasting of a debugged app. Besides this limitation, we don't believe there are any other compatibility issues that don't already exist in the local Visual Studio experience. Please let us know if you detect bugs by filing an issue on [developer community](https://aka.ms/feedback/report?space=8).
* Publishing - Publish to Azure through GitHub Actions is supported.
* Connected services - App Insights, KeyVault, Storage, SQL, Redis, Cosmos, openAPI, and gRPC are partially supported.
* Test Explorer* - Mostly supported.

Not yet available:

* Test Explorer* - Some features such as default architecture selection, run tests in parallel, playlists, etc. Known issues with debugging a unit test, run settings, and some additional enterprise features. Profiling unit tests is not supported.
* NuGet Package Manager UI - NuGet command line is supported.
* Enterprise testing features - Live Unit Testing, Microsoft Fakes, Code coverage, and IntelliTest not supported.
* Advanced publishing scenarios - Selective publishing, FTP publishing, preview changes, quick publish tool bar, etc.

## See also

* [What is GitHub Codespaces?](codespaces-overview.md)
* [How to use Visual Studio with a codespace](use-visual-studio-with-codespaces.md)
* [How to customize a codespace](customize-codespaces.md)
