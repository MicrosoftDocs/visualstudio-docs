---
title: "What's new in Visual Studio docs"
description: "What's new in the Visual Studio docs"
ms.date: 05/03/2023
helpviewer_keywords:
  - "Visual Studio, what's new, docs"
  - "what's new [Visual Studio]"
ms.assetid: 89844796-621B-4EF5-9D76-197084B011CB
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.prod: visual-studio-windows
ms.topic: conceptual
ms.workload:
  - "multiple"
---
# What's new in Visual Studio docs

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Welcome to what's new in Visual Studio docs. The following sections provide details on the previous three months of new and updated content.

## April 2023

### Deployment

**New articles**

- [Build .NET ClickOnce applications from the command line](../deployment/building-dotnet-clickonce-applications-from-the-command-line.md)

**Updated articles**

- [Build ClickOnce applications from the command line](../deployment/building-clickonce-applications-from-the-command-line.md) - Add link to command-line build for .NET ClickOnce

### Designers

**Updated articles**

- [Fix HDPI/scaling issues with Windows Forms Designer in Visual Studio](../designers/disable-dpi-awareness.md) - Shorten text to improve readability.

### Extensibility

**Updated articles**

- [VSIX extension schema 2.0 reference](../extensibility/vsix-extension-schema-2-0-reference.md) - Add information about placeholders in VSIX manifest files

### Get started

**Updated articles**

- [What is Visual Studio?](../get-started/visual-studio-ide.md) - Revise the Overview content

### IDE

**New articles**

- [What is the GitHub Copilot extension for Visual Studio?](../ide/visual-studio-github-copilot-extension.md)

**Updated articles**

- [Bookmark code in Visual Studio](../ide/setting-bookmarks-in-code.md) - Update text, links, and screenshots
- [Sign in to Visual Studio on Windows](../ide/signing-in-to-visual-studio.md) - Update text and screenshots
- [Make code work in Visual Studio](../ide/find-and-fix-code-errors.md) - Update text and links
- [Optimize Visual Studio startup time](../ide/optimize-visual-studio-startup-time.md) - Update text, links & refresh for revised UI
- [How to: Change fonts, colors, and themes in Visual Studio](../ide/how-to-change-fonts-and-colors-in-visual-studio.md) - Update text
- [Walkthrough: Create a code snippet in Visual Studio](../ide/walkthrough-creating-a-code-snippet.md) - Add more detail to procedural instructions

### Install

**Updated articles**

- [Create, maintain, and deploy a network installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md) - Update the --useLatestInstaller content & add link to Community SKU

### MSBuild

**Updated articles**

- [MSBuild batching](../msbuild/msbuild-batching.md) - Document metadata-self referencing behavioral differences

### Profiling

**Updated articles**

- [Which performance tool should I use? (C#, Visual Basic, C++, F#)](../profiling/choose-performance-tool.md) - Update article on choosing your performance tool

### Community contributors

The following people contributed to Visual Studio content in April. Thank you! To learn more about how you can help too, see the [Microsoft Docs contributor guide](/contribute/).

- [jrdodds](https://github.com/jrdodds) - Jonathan Dodds (1)
- [kmgallahan](https://github.com/kmgallahan) - Kevin Gallahan (1)
- [robinhood2014](https://github.com/robinhood2014) - Brandon Taylor (1)
- [soroosh-chabi](https://github.com/soroosh-chabi) - Soroosh Chabi (1)
- [Tim-Maes](https://github.com/Tim-Maes) - Tim Maes (1)

## March 2023

### Debugger

**New articles**

- [Debugging Native Code FAQs](../debugger/debugging-native-code-faqs.yml)

**Updated articles**

- [Diagnose problems after deployment using IntelliTrace (C#, Visual Basic)](../debugger/diagnose-problems-after-deployment.md) - Remove IntelliTrace content related to MMA end-of-life

### Get started

**Updated articles**

- Update text, links, and screenshots:
  - [Tutorial: Add reference variables and a timer control to your matching game WinForms app](../get-started/csharp/tutorial-windows-forms-match-game-labels.md)
  - [Tutorial: Display a message in your matching game WinForms app](../get-started/csharp/tutorial-windows-forms-match-game-play.md)

### IDE

**New articles**

- [Access multiple accounts associated with the Visual Studio sign-in account](./sign-in-access-multiple-accounts.md)

**Updated articles**

- [Learn about Solution Explorer](./use-solution-explorer.md) - Add new Quick Add info
- [How to: Specify build events (C#)](./how-to-specify-build-events-csharp.md) - Add more information and examples about how to create build events
- Update text and links:
  - [Walkthrough: Create a code snippet](./walkthrough-creating-a-code-snippet.md)
  - [Make code work in Visual Studio](./find-and-fix-code-errors.md)
  - [Manage application settings (.NET)](./managing-application-settings-dotnet.md)

### Install

**Updated articles**

- [Command-line parameter examples for Visual Studio installation](../install/command-line-parameter-examples.md) - Apply minor fixes to installer command-line info

### JavaScript

**Updated articles**

- [Debug a JavaScript or TypeScript app in Visual Studio](../javascript/debug-nodejs.md) - Update Debug JavaScript and TypeScript info
- [Tutorial: Create a Node.js and React app in Visual Studio](../javascript/tutorial-nodejs-with-react-and-jsx.md) - Update npm packages and Node.js info 

### MSBuild

**New articles**

- [Customize a build to handle generated files](../msbuild/customize-builds-for-generated-files.md)
- [Customize the build by folder](../msbuild/customize-by-directory.md)
- [Customize C++ builds](../msbuild/customize-cpp-builds.md)
- [Customize all .NET builds](../msbuild/customize-net-builds.md)
- [Customize the solution build](../msbuild/customize-solution-build.md)
- [Customize your local build](../msbuild/customize-your-local-build.md)

**Updated articles**

- [MSBuild targets](../msbuild/msbuild-targets.md) - Add link to .NET.SDK.Publish.targets and explanation
- [MSBuild](../msbuild/msbuild.md) - Review and add information that more accurately reflects usage on non-Windows platforms
- [Common MSBuild project properties](../msbuild/common-msbuild-project-properties.md) Add CustomAfterMicrosoftCommonTargets info
- [Customize your build](../msbuild/customize-your-build.md) - Update the 'Customize Builds' section

### Profiling

**Updated articles**

- [Troubleshoot profiling errors and fix issues](../profiling/troubleshoot-profiler-errors.md) - Update profiling troubleshooting article with dropped events error
- [Analyze CPU usage without debugging in the Performance Profiler (C#, Visual Basic, C++, F#)](../profiling/cpu-usage.md) - Add updates for CPU Usage call count
- Update instrumentation articles for 17.6 Preview:
  - [Instrumentation in Visual Studio (C#, Visual Basic, C++, F#)](../profiling/instrumentation-overview.md)
  - [Instrument your .NET applications in Visual Studio (C#, C++, Visual Basic, F#)](../profiling/instrumentation.md)

### Version control

**Updated articles**

- [Create a Git repository from Visual Studio](../version-control/git-create-repository.md) - Add .gitignore info

### XAML tools

**New articles**

- [XAML Hot Reload and its impact on performance diagnostic in Visual Studio](../xaml-tools/xaml-hot-reload-impact-performance.md)

## February 2023

### Data tools

**Updated articles**

- [Create a database and add tables in Visual Studio](../data-tools/create-a-sql-database-by-using-a-designer.md) - Update and add clarifications

### Debugger

**Updated articles**

- [How to: Enable and disable Edit and Continue (C#, VB, C++)](../debugger/how-to-enable-and-disable-edit-and-continue.md) - Update configuration commands, Spy++ docs
- [Inspect an exception using the Exception Helper](../debugger/exception-helper.md) - Add info to view exception stack frames in the call stack window
- [View the call stack and use the Call Stack window in the debugger](../debugger/how-to-use-the-call-stack-window.md) - Add info to view exception stack frames in the call stack window

### Designers

**Updated articles**

- [Disable DPI-awareness to fix HDPI / scaling issues with Windows Forms Designer in Visual Studio](../designers/disable-dpi-awareness.md) - Add 'What is DPI and why does it matter' section, plus other updates

### Extensibility

**Updated articles**

- [Walkthrough: Publish a Visual Studio extension](../extensibility/walkthrough-publishing-a-visual-studio-extension.md) - Update to the 'Remove the extension' steps

### Get started

**New articles**

- [Tutorial: Create your first Windows App SDK application in Visual Studio with XAML and C&#35;](../get-started/csharp/tutorial-wasdk.md)

**Updated articles**

- [Welcome to the Visual Studio IDE | Visual Basic](../get-started/visual-basic/visual-studio-ide.md) - Update text, links, and screenshots

### IDE

**New articles**

- [Learn about the Text Spell Checker (Preview)](./text-spell-checker.md)

**Updated articles**

- [JavaScript IntelliSense](./javascript-intellisense.md) - Update content related to JavaScript IntelliSense language service
- [Find references in your code](./finding-references.md) - Add 'Clear All Filters' info to the 'Filter By Reference Type' section
- [How to: Manage editor modes](./how-to-manage-editor-modes.md) - Update the View.FullScreen keyboard shortcut
- [Sign in to Visual Studio with accounts that require multi-factor authentication (MFA)](./work-with-multi-factor-authentication.md) - Add troubleshooting steps

### Install

**Updated articles**

- Update for the [17.5](/visualstudio/releases/2022/release-notes-v17.5) release:
  - [Use command-line parameters to install, update, and manage Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md)
  - [Command-line parameter examples for Visual Studio installation](../install/command-line-parameter-examples.md)
  - [Create, maintain, and deploy a network installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md)
  - [Create an offline installation package of Visual Studio for local installation](../install/create-an-offline-installation-of-visual-studio.md)
  - [Import or export installation configurations](../install/import-export-installation-configurations.md)

### JavaScript

**Updated articles**

- Update React, Angular, and Vue with ASP.NET Core for the [17.5](/visualstudio/releases/2022/release-notes-v17.5) release:
  - [Tutorial: Create an ASP.NET Core app with React in Visual Studio](../javascript/tutorial-asp-net-core-with-react.md)
  - [Tutorial: Create an ASP.NET Core app with Angular in Visual Studio](../javascript/tutorial-asp-net-core-with-angular.md)
  - [Tutorial: Create an ASP.NET Core app with Vue in Visual Studio](../javascript/tutorial-asp-net-core-with-vue.md)

### MSBuild

**New articles**

- [Fix intermittent build failures](../msbuild/fix-intermittent-build-failures.md)

**Updated articles**

- [Customize your build](../msbuild/customize-your-build.md) - Add code example and discussion of where to set properties

### Profiling

**Updated articles**

- [Which performance tool should I use? (C#, Visual Basic, C++, F#)](../profiling/choose-performance-tool.md) - Clarify content on when to use performance tools

### Test

**Updated articles**

- [Use the MSTest framework in unit tests](../test/using-microsoft-visualstudio-testtools-unittesting-members-in-unit-tests.md) - Add documentation for the DeploymentItem attribute