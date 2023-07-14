---
title: "What's new in Visual Studio docs"
description: "What's new in the Visual Studio docs"
ms.date: 07/14/2023
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

## May 2023

### Debugger

**New articles**

- [Move the execution pointer to change the execution flow in the debugger](../debugger/move-the-execution-pointer-with-the-debugger.md)

**Updated articles**

- Update multithreaded debugging info:
  - [Walkthrough: Debug a multithreaded app using the Threads window (C#, Visual Basic, C++)](../debugger/how-to-use-the-threads-window.md) 
  - [Using the Tasks Window (C#, Visual Basic, C++)](../debugger/using-the-tasks-window.md)
- Update Parallel Stacks info:
  - [View the call stack and use the Call Stack window in the debugger](../debugger/how-to-use-the-call-stack-window.md)
  - [View threads and tasks in the Parallel Stacks window (C#, Visual Basic, C++)](../debugger/using-the-parallel-stacks-window.md)
  - [Walkthrough: Debugging a Parallel Application in Visual Studio (C#, Visual Basic, C++)](../debugger/walkthrough-debugging-a-parallel-application.md)
- [Navigate through code by using the Visual Studio debugger](../debugger/navigating-through-code-with-the-debugger.md) - Update text and links
- [Attach to running processes with the Visual Studio debugger](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md) - Add Edge updates for Attach to Process
- [Getting Started (Debug Interface Access SDK)](../debugger/debug-interface-access/getting-started-debug-interface-access-sdk.md) - Update DIA SDK filepaths and DLL names

### Extensibility

**New articles**

Documentation for the VisualStudio.Extensibility SDK, currently in preview, were migrated from the [VS Extensibility GitHub repo](https://github.com/Microsoft/VSExtensibility), as follows:

- [Add Visual Studio commands](../extensibility/visualstudio.extensibility/command/command.md)
- [Metadata localization overview](../extensibility/visualstudio.extensibility/command/localize-metadata.md)
- [Menus and Toolbars overview](../extensibility/visualstudio.extensibility/command/menus-and-toolbars.md)
- [Create Visual Studio debugger visualizers](../extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers.md)
- [Create Visual Studio dialogs](../extensibility/visualstudio.extensibility/dialog/dialog.md)
- [Extend Visual Studio documents](../extensibility/visualstudio.extensibility/document/documents.md)
- [Editor extensibility concepts](../extensibility/visualstudio.extensibility/editor/editor-concepts.md)
- [Editor RPC support](../extensibility/visualstudio.extensibility/editor/editor-rpc.md)
- [Use Visual Studio editor extensibility](../extensibility/visualstudio.extensibility/editor/editor.md)
- [Create your first Visual Studio extension](../extensibility/visualstudio.extensibility/get-started/create-your-first-extension.md)
- [Create your first VSSDK-compatible VisualStudio.Extensibility extension](../extensibility/visualstudio.extensibility/get-started/in-proc-extensions.md)
- [Introduction to VisualStudio.Extensibility for VS SDK users](../extensibility/visualstudio.extensibility/get-started/oop-extensibility-model-overview.md)
- [Create a simple extension](../extensibility/visualstudio.extensibility/get-started/tutorial-create-simple-extension.md)
- [VisualStudio.Extensibility SDK](../extensibility/visualstudio.extensibility/index.yml)
- [Rule-based activation constraints](../extensibility/visualstudio.extensibility/inside-the-sdk/activation-constraints.md)
- [Tutorial: Advanced remote UI](../extensibility/visualstudio.extensibility/inside-the-sdk/advanced-remote-ui.md)
- [Contributions and Configurations](../extensibility/visualstudio.extensibility/inside-the-sdk/contributions-and-configurations.md)
- [Components of a VisualStudio.Extensibility extension](../extensibility/visualstudio.extensibility/inside-the-sdk/extension-anatomy.md)
- [Inside Visual Studio Extensibility SDK](../extensibility/visualstudio.extensibility/inside-the-sdk/inside-the-sdk.md)
- [Logging extension diagnostics](../extensibility/visualstudio.extensibility/inside-the-sdk/logging.md)
- [Why Remote UI](../extensibility/visualstudio.extensibility/inside-the-sdk/remote-ui.md)
- [Write to the Visual Studio output window](../extensibility/visualstudio.extensibility/output-window/output-window.md)
- [Project query API concepts](../extensibility/visualstudio.extensibility/project/project-concepts.md)
- [Query the project API](../extensibility/visualstudio.extensibility/project/project.md)
- [Create Visual Studio tool windows](../extensibility/visualstudio.extensibility/tool-window/tool-window.md)
- [Create Visual Studio user prompts](../extensibility/visualstudio.extensibility/user-prompt/user-prompts.md)
- [About VisualStudio.Extensibility (Preview)](../extensibility/visualstudio.extensibility/visualstudio-extensibility.md)

### Get started

**Updated articles**

- [Tutorial: Create your first Universal Windows Platform application in Visual Studio with XAML and C&#35;](../get-started/csharp/tutorial-uwp.md) - Update text and links
- [What is Visual Studio?](../get-started/visual-studio-ide.md) - Revise overview article per feedback

### IDE

**New articles**

- [What is Sticky Scroll for Visual Studio?](../ide/editor-sticky-scroll.md)

**Updated articles**

- Update text and links:
  - [Work with GitHub accounts in Visual Studio](../ide/work-with-github-accounts.md)
  - [Visual Studio performance tips and tricks](../ide/visual-studio-performance-tips-and-tricks.md)
- [Sign in to Visual Studio on Windows](../ide/signing-in-to-visual-studio.md) - Restructure the article
- [Options dialog box: Text Editor \> General](../ide/reference/options-text-editor-general.md) - Add new Brace Pair Colorization & Sticky Scroll info
- [Learn about the Spell Checker](../ide/text-spell-checker.md) - Remove preview tags and update with recent changes & examples

### Install

**Updated articles**

- [Use command-line parameters to install, update, and manage Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md) - Add reference to winget configure using VS.DSC file

### MSBuild

**Updated articles**

- [Property functions](../msbuild/property-functions.md) - Review and update info

### Profiling

**New articles**

- [Reduce compute costs by using profiling tools to optimize code (C#, Visual Basic, C++, F#)](../profiling/optimize-code-using-profiling-tools.md)

**Updated articles**

- [Troubleshoot profiling errors and fix issues](../profiling/troubleshoot-profiler-errors.md) - Add info on ETW (Event Tracing for Windows) resource issues when profiling

### Test

**Updated articles**

- Apply documentation improvements:
  - [Code generation, compilation, and naming conventions in Microsoft Fakes](../test/code-generation-compilation-and-naming-conventions-in-microsoft-fakes.md)
  - [Isolate code under test with Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md)
  - [Use shims to isolate your app for unit testing](../test/using-shims-to-isolate-your-application-from-other-assemblies-for-unit-testing.md)
  - [Use stubs to isolate parts of your application from each other for unit testing](../test/using-stubs-to-isolate-parts-of-your-application-from-each-other-for-unit-testing.md)
  - [Configure unit tests by using a *.runsettings* file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)
- [Customize code coverage analysis](../test/customizing-code-coverage-analysis.md) - Update settings info

### Version control

**Updated articles**

- [How Visual Studio makes version control easy with Git](../version-control/git-with-visual-studio.md) - add new Performance & Productivity Enhancements section

### Community contributors

The following people contributed to Visual Studio content in May. Thank you! To learn more about how you can help too, see the [Microsoft Docs contributor guide](/contribute/).

- [AraHaan](https://github.com/AraHaan) - Ara Haan ![There were 1 pull requests merged by .](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [Fjarik](https://github.com/Fjarik) - Jiri Falta ![There were 1 pull requests merged by Jiri Falta.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [heh-ad](https://github.com/heh-ad) - Helmes He ![There were 1 pull requests merged by Helmes He.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [hyoshioka0128](https://github.com/hyoshioka0128) - Hiroshi Yoshioka ![There were 1 pull requests merged by Hiroshi Yoshioka.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [MatthewSteeples](https://github.com/MatthewSteeples) - Matthew Steeples ![There were 1 pull requests merged by Matthew Steeples.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [mavaddat](https://github.com/mavaddat) - Mavaddat Javid ![There were 1 pull requests merged by Mavaddat Javid.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [pd-jam](https://github.com/pd-jam) -  ![There were 1 pull requests merged by .](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [XuZhixuan](https://github.com/XuZhixuan) - Xu Zhixuan ![There were 1 pull requests merged by f(x,z)=xzx.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)

## April 2023

### Deployment

**New articles**

- [Build .NET ClickOnce applications from the command line](../deployment/building-dotnet-clickonce-applications-from-the-command-line.md)

**Updated articles**

- [Build ClickOnce applications from the command line](../deployment/building-clickonce-applications-from-the-command-line.md) - Add link to new Command-Line Build for .NET ClickOnce article

### Designers

**Updated articles**

- [Fix HDPI/scaling issues with Windows Forms Designer in Visual Studio](../designers/disable-dpi-awareness.md) - Shorten text to improve readability

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
- [Optimize Visual Studio startup time](../ide/optimize-visual-studio-startup-time.md) - Update text, links, and refresh for revised UI
- [How to: Change fonts, colors, and themes in Visual Studio](../ide/how-to-change-fonts-and-colors-in-visual-studio.md) - Update text
- [Walkthrough: Create a code snippet in Visual Studio](../ide/walkthrough-creating-a-code-snippet.md) - Add more detail to procedural instructions

### Install

**Updated articles**

- [Create, maintain, and deploy a network installation of Visual Studio](../install/create-a-network-installation-of-visual-studio.md) - Update the useLatestInstaller content & add link to Community edition

### MSBuild

**Updated articles**

- [MSBuild batching](../msbuild/msbuild-batching.md) - Document metadata-self referencing behavioral differences

### Profiling

**Updated articles**

- [Which performance tool should I use? (C#, Visual Basic, C++, F#)](../profiling/choose-performance-tool.md) - Update info about choosing your performance tool