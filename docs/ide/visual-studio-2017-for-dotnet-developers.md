---
title: "Visual Studio 2017 for .NET Developers | Microsoft Docs"
description: "Overview of Visual Studio 2017 features to help you write better .NET code faster."
author: "kuhlenh"
ms.author: "kaseyu"
manager: ghogen
ms.technology: vs-ide-general
ms.date: "01/16/2018"
ms.topic: "article"
helpviewer_keywords:
  - "editor"
ms.workload:
  - "dotnet"
---

# Visual Studio 2017 Productivity Guide for .NET Developers
[Visual Studio 2017](https://www.visualstudio.com/downloads/) makes developers more productive than ever! We’ve made major performance and reliability improvements with regards to solution startup and load, test discovery, and typing latency. We’ve also added and enhanced features to help you write better code faster. Some of these features include: navigation to decompiled assemblies, variable name suggestions as you type, a hierarchy-view in the Test Explorer, Go To All (_Ctrl+T_) to navigate to file/type/member/symbol declarations, an intelligent Exception Helper, code style configuration and enforcement, and many refactorings and code fixes. 

Follow this guide to take your work to the next level.

##  I’m used to my keyboard shortcuts from a different extension/editor/IDE.

If you are coming from another IDE or coding environment, you may find installing one of these extensions helpful:

- [Emacs Emulation](https://marketplace.visualstudio.com/items?itemName=JustinClareburtMSFT.EmacsEmulation)
- [HotKeys for Visual Studio (ReSharper/IntelliJ)](https://marketplace.visualstudio.com/items?itemName=JustinClareburtMSFT.HotKeys)
- [VSVim](https://marketplace.visualstudio.com/items?itemName=JaredParMSFT.VsVim)

The following are popular Visual Studio shortcuts. 
> Note: Some extensions unbind default Visual Studio keybindings and you must restore the keybindings to use the commands below. To restore your keybindings to Visual Studio's defaults, go to **Tools > Import and Export Settings... > Reset all settings** or **Tools > Options > Keyboard > Reset**.

| Shortcut (All Profiles) | Command | Description |
|-|-|-|
| **Ctrl+T** | Go To All | Navigate to any file/type/member/symbol declaration |
| **F12** (also **Ctrl+Click**) | Go To Definition | Navigate to where a symbol is defined |
| **Ctrl+F12** | Go To Implementation | Navigate from a base type or member to its various implementations |
| **Shift+F12** | Find All References | See all symbol or literal references |
| **Ctrl**+**.** (also **Alt+Enter** in C# Profile) | Quick Actions and Refactorings | See what code fixes, code generation actions, refactorings, or other quick actions are available at your cursor position or code selection |
| **Ctrl**+**D** | Duplicate line | Duplicates the line of code that the cursor is in (available in **Visual Studio 2017 version 15.6** and later) |
| **Shift**+**Alt**+**+**/**-** | Expand/Contract selection | Expands or contracts the current selection in the editor (available in **Visual Studio 2017 version 15.5** and later) |
| **Ctrl+Q** | Quick Launch | Search all Visual Studio settings |
| **F5** | Start Debugging | Start debugging your application |
| **Ctrl+F5** | Run without Debug | Run your application locally without debugging |
| **Ctrl+K,D** (Default Profile) or **Ctrl+E,D** (C# Profile) | Format Document | Cleans up formatting violations in your file based on your newline, spacing, and indentation settings |
| **Ctrl+\\,E** (Default Profile) or **Ctrl+W,E** (C# Profile) | View Error List | See all errors in your document, project, or solution |

## I need a way to quickly navigate to files or types.
Visual Studio 2017 has a feature called Go To All (_Ctrl+T_). From this feature you can quickly jump to any file, type, member, or symbol declaration.
- Change the location of this search bar or turn off the 'live navigation preview' with the 'gear' icon
- Filter results using our query syntax (e.g., "t mytype"). You can also scope your search to just the current document.
- camelCase matching is supported!

## My team has code style rules that we enforce.
You can use an .editorconfig file to codify coding conventions. We recommend installing the [EditorConfig Language Services extension](https://aka.ms/editorconfig) for adding and editing an .editorconfig file. We recommend you check out the [documentation](https://aka.ms/editorconfigDocs) for all .NET coding convention options.

## I need more refactorings and code fixes.
Visual Studio 2017 comes with a lot of refactorings, code generation actions, and code fixes which you can see in our [documentation](https://aka.ms/refactorings). Red squiggles represent errors, green squiggles represent warnings, and three gray dots represent code suggestions.

You can access code fixes by clicking the lightbulb/screwdriver icon or by pressing '_Ctrl+._' or '_Alt+Enter_'. Each fix comes with a preview window that shows a live code diff of how the fix works.

Here are some popular quick fixes and refactorings: Rename, Extract Method, Change Method Signature, Generate Constructor, Generate Method, Move Type to File, Add Null-Check, Add Parameter, Remove Unnecessary Usings.

Refactorings and code fixes can be easily written with [Roslyn analyzers](https://github.com/dotnet/roslyn/wiki/Getting-Started-Writing-a-Custom-Analyzer-&-Code-Fix). Several community members have written *free* extensions that add additional code inspections: Roslynator and SonarLint for Visual Studio. 

## I need Find Usages, Go To Implementation, Navigate To Decompiled Assemblies
Visual Studio 2017 has many features to help you search and navigate your codebase--including Find All References (_Shift+F12_), Go To Implementation (_Ctrl+F12_), Go To Definition (_F12_ or _Ctrl+Click_). Navigate To Decompiled Assemblies was added in version 15.6. To turn on this feature, go to _Tools > Options > Text Editor > C# > Advanced > Enable navigation to decompiled sources_.

## I want to run and see my unit tests.
We have two offerings for unit testing in Visual Studio 2017: Test Explorer and Live Unit Testing. We’ve greatly improved the speed of test discovery in the Test Explorer in VS2017 15.6 and we also are redesigning the UI to allow for hierarchical sorting in 15.6.

Visual Studio also has a unit testing feature called [Live Unit Testing](https://docs.microsoft.com/en-us/visualstudio/test/live-unit-testing). Live Unit Testing continuously runs in the background, runs tests impacted by your code change, and updates inline editor icons to let you know the status of your tests.

## What other features do I need to know about?
Here is a list of editor and productivity features to make writing code more efficient. Some features may need to be enabled because they are off-by-default (they may index things on your machine, are controversial, or are currently experimental).
- **Locate File in Solution Explorer** will highlight the active file in the Solution Explorer.
  - _Tools>Options>Projects and Solutions>Track Active Item in Solution Explorer_
- **Add usings for types in reference assemblies and NuGet packages** will show a lightbulb with a code fix to install a NuGet package for an unreferenced type.
  - Tools>Options>Text Editor>C#>Advanced>Suggest usings for types in reference assemblies and Suggest usings for types in NuGet packages
- *Enable full solution analysis* to see all errors in your solution in the Error List.
  - Tools>Options>Text Editor>C#>Advanced>Enable full solution analysis
- **Enable navigation to decompiled sources** which will allow you to Go To Definition on types/members from external sources and use the ILSpy decompiler to show method bodies.
  - Tools>Options>Text Editor>C#>Advanced>Enable navigation to decompiled sources
- **Completion/Suggestion Mode** in IntelliSense will change completion behavior. Developers with IntelliJ backgrounds tend to change the setting here from the default.
  - Menu > Edit > IntelliSense -> Toggle Completion Mode
- We have **code snippets** to help stub out common boilerplate (press ‘Tab’ twice). See the [full list](https://docs.microsoft.com/en-us/visualstudio/ide/visual-csharp-code-snippets).

## Missing a feature that makes you productive or experiencing poor performance?
There are several ways to leave us feedback:
- .NET feature requests can be filed on our [GitHub](https://github.com/dotnet/roslyn/issues)
- Visual Studio feature requests, bugs, and performance issues can be filed by using the 'Send Feedback' icon at the top of your Visual Studio window.

# Overview of Visual Studio 2017 for .NET Developers

## Smart code editor

- [Documentation: Using IntelliSense](using-intellisense.md)
- [Documentation: Smart editor features](writing-code-in-the-code-and-text-editor.md)

Visual Studio has a deep understanding of your code via the .NET ("Roslyn") compiler to provide you with smart editing features like syntax colorization, code completion, spell-checking mistyped variables, unimported type resolution, outlining, structure visualizers, [CodeLens](find-code-changes-and-other-history-with-codelens.md), call hierarchy, hover-able quick info, parameter help, as well as tools for refactoring, applying quick actions, and generating code.

![Visual Studio smart code editor](../ide/media/VSIDE_Productivity_SmartCodeEditor.png "VSIDE_Productivity_SmartCodeEditor")

## Navigate and search your codebase

[Documentation: Navigating code](navigating-code.md)

Quickly navigate your .NET code by jumping to any file, type, member, or symbol declaration with the *Go To All* shortcut (**Ctrl+T**). Find all the references of a symbol or literal in your code, including references across .NET languages (**Shift+F12**). And use our targeted navigation commands to help you jump directly to symbol definitions (**F12**) or implementations (**Ctrl+F12**).

![Go To All and Find All References](../ide/media/VSIDE_Productivity_Navigation.png "VSIDE_Productivity_Navigation")

## Live code analysis for code quality

[Documentation: Refactorings and quick actions](refactoring-code-generation-quick-actions.md)

Visual Studio has live code diagnostics to help you improve your code quality by detecting errors and potentially problematic code. We provide quick-actions (**Ctrl**+**.**) to resolve detected problems across your document, project, or solution. Enable *full-solution analysis* to find issues across your entire solution even if you don’t have those files open in the editor.

Additionally, use code suggestions to learn best practices, stub or generate code, refactor code, and adopt new language features with the **Ctrl**+**.** shortcut.

![Apply quick fixes and refactorings using the lightbulb menu](../ide/media/VSIDE_Productivity_CodeAnalysis.png "VSIDE_Productivity_CodeAnalysis")

## Unit testing

[Documentation: Unit testing in Visual Studio](../test/improve-code-quality.md)

Run and debug your unit tests based on the MSTest, NUnit, or XUnit testing frameworks for any application targeting .NET Framework, .NET Standard, or .NET Core. Explore and review your tests in the *Test Explorer* or immediately see how code changes impact your unit tests inside the editor with *Live Unit Testing* (Enterprise SKU only).

![Live Unit Testing in Visual Studio](../ide/media/VSIDE_Productivity_LiveUnitTesting.png "VSIDE_Productivity_LiveUnitTesting")

## Code consistency and style

- [Documentation: Portable custom editor options](create-portable-custom-editor-options.md)
- [Documentation: EditorConfig code style settings for .NET](editorconfig-code-style-settings-reference.md)

Visual Studio enables coding convention configuration, detects coding style violations, and provides quick-fixes to remedy style issues with the **Ctrl**+**.** shortcut. Configure and enforce your team’s formatting, naming, and code style conventions across a repository—allowing overriding values at the project and file level—using *EditorConfig*.

![Configure and enforce coding conventions with EditorConfig](../ide/media/VSIDE_Productivity_CodeStyle.png "VSIDE_Productivity_CodeStyle")

## Debugging

[Documentation: Debugging in Visual Studio](../debugger/index.md)

Visual Studio includes a top-notch debugger that allows you to debug your .NET applications targeting the .NET Framework, .NET Standard, and .NET Core. Toggle and set conditional breakpoints (**F9**), step into method calls, evaluate LINQ and lambda expressions, set variable watches, reattach to processes, examine your call stack, or even make live code edits while debugging with *Edit and Continue*.

If your service runs in Azure, use *Snapshot debugging* to diagnose issues on your live, deployed cloud applications in Visual Studio 2017 Enterprise.

![Debugging in Visual Studio](../ide/media/VSIDE_Productivity_Debugging.png "VSIDE_Productivity_Debugging")

## Version control

[Documentation: Version control in Visual Studio](/vsts/index)

Use git or TFVC to store and update your code in Visual Studio. Inside the editor, organize local changes with Team Explorer and use the status bar to track pending commits and changes. Set up continuous integration and delivery inside of Visual Studio with our [Continuous Delivery Tools for Visual Studio](https://marketplace.visualstudio.com/items?itemName=VSIDEDevOpsMSFT.ContinuousDeliveryToolsforVisualStudio) extension to adopt the agile developer workflow.

![Source control in Visual Studio](../ide/media/VSIDE_Productivity_SourceControl.png "VSIDE_Productivity_SourceControl")

## Extensibility

[Documentation: Extending Visual Studio](../extensibility/index.md)

Visual Studio has a rich ecosystem of extensions that you can install or create as you need them. Install extensions from the *Extension Gallery* or the *Visual Studio Marketplace*, build your own editor plugin with the *VS SDK*, or create your own live code analyzer or refactoring using the *.NET Compiler Platform SDK*. You can find additional code fixes and suggestions by downloading the [Microsoft Code Analysis](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.MicrosoftCodeAnalysis2017) extension.

![The Visual Studio Extension Gallery](../ide/media/VSIDE_Productivity_Extensibility.png "VSIDE_Productivity_Extensibility")

