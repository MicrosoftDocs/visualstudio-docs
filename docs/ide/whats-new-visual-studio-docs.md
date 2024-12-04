---
title: "What's new in Visual Studio docs"
description: Discover recent changes in the Visual Studio documentation, including updated articles about getting started, the IDE, and deployment.
ms.date: 12/02/2024
helpviewer_keywords:
  - "Visual Studio, what's new, docs"
  - "what's new [Visual Studio]"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
ms.topic: conceptual
---
# What's new in Visual Studio docs

Welcome to what's new in Visual Studio docs. The following sections provide details on the previous three months of new and updated content.

## November 2024

### Debugger

**New articles**

- [Get started with breakpoints in the Visual Studio debugger](../debugger/get-started-with-breakpoints.md)
- [IDiaStackWalkHelper::addressForVA](../debugger/debug-interface-access/idiastackwalkhelper-addressforva.md)
- [IDiaStackWalkHelper::getFunctionFragmentsForVA](../debugger/debug-interface-access/idiastackwalkhelper-functionfragmentsforva.md)
- [IDiaStackWalkHelper::getNumberOfFunctionFragmentsForVA](../debugger/debug-interface-access/idiastackwalkhelper-numberoffunctionfragmentsforva.md)

**Updated articles**

- [Use the right type of breakpoint](../debugger/using-breakpoints.md) - Refactor breakpoints article and incorporate review feedback
- [Use the Memory windows in the Visual Studio debugger (C#, C++, Visual Basic, F#)](../debugger/memory-windows.md) - Update article on Memory windows
- [First look at the Visual Studio Debugger](../debugger/debugger-feature-tour.md) - Update debugger content for viewing return values
- [IDiaStackWalkHelper::pdataForVA](../debugger/debug-interface-access/idiastackwalkhelper-pdataforva.md) - Add docs for 3 missing IDiaStackWalkHelper functions
- [IDiaStackWalkHelper](../debugger/debug-interface-access/idiastackwalkhelper.md) - Add docs for 3 missing IDiaStackWalkHelper functions
- [SymTagEnum](../debugger/debug-interface-access/symtagenum.md) - Fix broken links due to improper code escapes

### Deployment

**Updated articles**

- [Visual Studio Installer Projects Extension and .NET](../deployment/installer-projects-net-core.md) - Update .NET installer projects article

### Extensibility

**Updated articles**

- [Overview](../extensibility/visualstudio.extensibility/diagnostics/visualstudio-extensibility-diagnostics-extension.md) - Add 17.12 documentation to VisualStudio.Extensibility
- [Use Visual Studio editor extensibility](../extensibility/visualstudio.extensibility/editor/editor.md) - Add 17.12 documentation to VisualStudio.Extensibility
- [Write to the Visual Studio output window](../extensibility/visualstudio.extensibility/output-window/output-window.md) - Updating docs for VS.Extensibility output window in 17.12

### IDE

**Updated articles**

- [Code style preferences](../ide/code-styles-and-code-cleanup.md) - Clarify code cleanup instructions
- [Create, work with, and delete Visual Studio projects and solutions](../ide/creating-solutions-and-projects.md) - Add new copy between VS instances features
- [Configure trust settings for files and folders](../ide/reference/trust-settings.md) - Add VS 17.12 feature MOTW (Mark of the Web)
- [Find in Files](../ide/find-in-files.md) - Update Find in Files for 17.12 for refresh and modify options
- [Use Visual Studio search](../ide/visual-studio-search.md) - Update for 17.12 for new All In One Search features
- [Quick Actions](../ide/quick-actions.md) - Add instruction for invoking quick actions, refactor
- [Fonts and Colors, Environment, Options dialog box](../ide/reference/fonts-and-colors-environment-options-dialog-box.md) - Add collapsible text indicators to table
- [Sign in to Visual Studio with accounts that require multifactor authentication (MFA)](../ide/work-with-multi-factor-authentication.md) - Add access denied text

### Profiling

**Updated articles**

- [Visualize dotnet counters from the Visual Studio profiler](../profiling/dotnet-counters-tool.md) - Add content for .NET Meters histogram tool

### Test

**Updated articles**

- [Debug and analyze unit tests with Test Explorer](../test/debug-unit-tests-with-test-explorer.md) - Add content for debugging unit tests with Copilot

### Community contributors

The following people contributed to the Visual Studio docs during this period. Thank you! Learn how to contribute by following the links under "Get involved" in the [what's new landing page](index.yml).

- [Michael-K-Stein](https://github.com/Michael-K-Stein) - Michael Kuperfish Steinberg ![4 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-4-green)
- [alexravenna](https://github.com/alexravenna) - Alex Ravenna ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [cathei](https://github.com/cathei) - Maxwell Keonwoo Kang ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [PhilKang0704](https://github.com/PhilKang0704) - Phil ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [prasoonpankaj](https://github.com/prasoonpankaj) - Prasoon Pankaj ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [saranshsaini](https://github.com/saranshsaini) - Saransh Saini ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)

## October 2024

### Azure

**Updated articles**

- [Add a connection to an Azure SQL Database](../azure/azure-sql-database-add-connected-service.md) - Connected Services security updates for 17.12
- [Adding Azure Storage by using Visual Studio Connected Services](../azure/vs-azure-tools-connected-services-storage.md) - Connected Services security updates for 17.12
- [Add Key Vault to your web application by using Visual Studio Connected Services](../azure/vs-key-vault-add-connected-service.md) - Connected Services security updates for 17.12
- [Create an Azure Cloud Services (extended support) project with Visual Studio](../azure/vs-azure-tools-azure-project-create.md) - Retire classic cloud services
- [Manage roles in Azure Cloud Services (extended support)](../azure/vs-azure-tools-cloud-service-project-managing-roles.md) - Retire classic cloud services
- [Configure Azure Cloud Services (extended support) roles with Visual Studio](../azure/vs-azure-tools-configure-roles-for-cloud-service.md) - Retire classic cloud services
- [Debug an Azure Cloud Services (extended support) service in Visual Studio](../azure/vs-azure-tools-debug-cloud-services-virtual-machines.md) - Retire classic cloud services
- [Set up diagnostics for Azure Cloud Services (extended support) and virtual machines](../azure/vs-azure-tools-diagnostics-for-cloud-services-and-virtual-machines.md) - Retire classic cloud services

### Containers

**New articles**

- [Build a container project from the command line](../containers/container-build-from-command-line.md)
- [Use SSL for containerized ASP.NET Core apps](../containers/container-certificate-management.md)
- [Customize container images for debugging](../containers/container-debug-customization.md)
- [Set the container entry point](../containers/container-entry-point.md)
- [Customize container volume mapping](../containers/container-volume-mapping.md)

**Updated articles**

- [Container Tools launch settings](../containers/container-launch-settings.md) - Launch profile settings for 17.12
- [Tutorial: Create a multi-container app with Docker Compose](../containers/tutorial-multicontainer.md) - Update the Docker Compose multicontainer tutorial for .NET 8
- [Customize Docker containers in Visual Studio](../containers/container-build.md) - Split up large article about customizing containerized app projects
- [Debug apps in a local Docker container](../containers/edit-and-refresh.md) - Split up large article about customizing containerized app projects

### Debugger

**New articles**

- [Send command-line arguments to a debugee (C++)](../debugger/specify-command-line-arguments.md)

**Updated articles**

- [Tabular visualizers in Visual Studio](../debugger/view-data-in-tabular-visualizer.md) - Update debugger article on tabular visualizer with Copilot content
- [Project settings for a C++ debug configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md) - draft new command arguments topic
- [Specify symbol (.pdb) and source files in the Visual Studio debugger (C#, C++, Visual Basic, F#)](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md) - Update debug pdb documentation.

### Deployment

**New articles**

- [Manage web deployment settings](../deployment/web-deployment-settings.md)

**Updated articles**

- [Quickstart: Publish an ASP.NET web app](../deployment/quickstart-deploy-aspnet-web-app.md) - Web deployment settings - new article

### Extensibility

**New articles**

- [Choose the right Visual Studio extensibility model for you](../extensibility/visualstudio.extensibility/extensibility-models.md)

### Get started

**Updated articles**

- [Tutorial: Get started with C# and ASP.NET Core in Visual Studio](../get-started/csharp/tutorial-aspnet-core.md) - Freshness updates

### IDE

**Updated articles**

- [Set multiple startup projects](../ide/how-to-set-multiple-startup-projects.md) - Add coverage of multi-project launch profiles
- [Build and clean projects and solutions in Visual Studio](../ide/building-and-cleaning-projects-and-solutions-in-visual-studio.md) - Review and update. Add batch build.
- [/Build (devenv.exe)](../ide/reference/build-devenv-exe.md) - Add info about building setup projects
- [Title not found in: ](../ide/whats-new-visual-studio-docs.md) - What's new in Visual Studio docs - update for September

### Install

**Updated articles**

- [Configure installation default settings using a response file](../install/automated-installation-with-response-file.md) - Add specific 2019 and 2022 examples

### JavaScript

**New articles**

- [Create a React app in Visual Studio](../javascript/create-react-app.md)

**Updated articles**

- [Create a React project](../javascript/tutorial-create-react-app.md) - Add Tutorial for React, update React, Vue, Angular articles

### Modeling

**Updated articles**

- [Customize File Storage and XML Serialization](../modeling/customizing-file-storage-and-xml-serialization.md) - Added a note about DSL modeling changes regarding BinaryFormatter

### MSBuild

**Updated articles**

- [MSBuild command-line reference](../msbuild/msbuild-command-line-reference.md) - Change formatting for better localization
- [Tutorial: Use MSBuild](../msbuild/walkthrough-using-msbuild.md) - Review and update

### Profiling

**Updated articles**

- [Case study: Isolate a performance issue (C#, Visual Basic, F#)](../profiling/isolate-performance-issue.md) - Update Copilot information in the VS Profiling case studies
- [Case Study: Beginner's guide to optimizing code and reducing compute costs (C#, Visual Basic, C++, F#)](../profiling/optimize-code-using-profiling-tools.md) - Update Copilot information in the VS Profiling case studies
- [Identify hot paths with a flame graph (C#, Visual Basic, C++, F#)](../profiling/flame-graph.md) - Update Flame Graph article with additional context and information

### Windows

**Updated articles**

- [Visual Studio documentation](../windows/index.yml) - Remove low traffic and out-of-date links, add some links

### Community contributors

The following people contributed to the Visual Studio docs during this period. Thank you! Learn how to contribute by following the links under "Get involved" in the [what's new landing page](index.yml).

- [Michael-K-Stein](https://github.com/Michael-K-Stein) - Michael Kuperfish Steinberg ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [NenoLoje](https://github.com/NenoLoje) - Neno Loje ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [PhilKang0704](https://github.com/PhilKang0704) - Phil ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)

## September 2024

### Debugger

**Updated articles**

- [View and change variable values with DataTips in the code editor](../debugger/view-data-values-in-data-tips-in-the-code-editor.md) - Add details to CPU Insights article and debug with Copilot
- [Inspect an exception using the Exception Helper](../debugger/exception-helper.md) - Update Exception Helper article for debugging async exceptions

### Extensibility

**Updated articles**

- [Using VisualStudio.Extensibility SDK and VSSDK together](../extensibility/visualstudio.extensibility/get-started/in-proc-extensions.md) - Update outdated VisualStudio.Extensibility in-proc docs

### Get started

**Updated articles**

- [Tutorial: Open a project from a repo](../get-started/tutorial-open-project-from-repo.md) - Updated images and text
- [Tutorial: Extend C# console app and debug in Visual Studio (part 2 of 2)](../get-started/csharp/tutorial-console-part-2.md) - Update article for user feedback
- [Tutorial: Learn to use the code editor with Visual Basic](../get-started/visual-basic/tutorial-editor.md) - Review and update

### IDE

**Updated articles**

- [Options, Text Editor, C#, IntelliSense](../ide/reference/options-text-editor-csharp-intellisense.md) - Update for latest options in product
- [Use regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md) - Regular expressions examples and clarifications
- [AI assistance when you write code](../ide/visual-studio-whole-line-completions.md) - Intellicode Tools, Options UI updates
- [Manage project and solution properties](../ide/managing-project-and-solution-properties.md) - Add more info & screenshots on Solution properties context menu and dialog
- [Get better answers by setting the context for GitHub Copilot Chat in Visual Studio](../ide/copilot-chat-context.md) - Add more info on context used by chat
- [Bookmark code in Visual Studio](../ide/setting-bookmarks-in-code.md) - Fix issue on bookmark discoverability

### Install

**Updated articles**

- [Install Visual Studio](../install/install-visual-studio.md) - Add sign-in info to install doc

### Profiling

**Updated articles**

- [Case study: Isolate a performance issue (C#, Visual Basic, F#)](../profiling/isolate-performance-issue.md)
  - Add Copilot instructions for profiling case study articles
  - Revise profiling article on isolating a performance issue to use a case study format
- [Case Study: Beginner's guide to optimizing code and reducing compute costs (C#, Visual Basic, C++, F#)](../profiling/optimize-code-using-profiling-tools.md) - Add Copilot instructions for profiling case study articles
- [Analyze performance by using CPU profiling in the Performance Profiler (C#, Visual Basic, C++, F#)](../profiling/cpu-usage.md) - Incorporate review feedback for CPU Usage article

### Test

**Updated articles**

- [Microsoft.CodeCoverage.Console tool](../test/microsoft-code-coverage-console-tool.md) - Add usage details related to Microsoft.CodeCoverage.Console usage

### Community contributors

The following people contributed to the Visual Studio docs during this period. Thank you! Learn how to contribute by following the links under "Get involved" in the [what's new landing page](index.yml).

- [cmkaya](https://github.com/cmkaya) - Cem Kaya ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [Meir017](https://github.com/Meir017) - Meir Blachman ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [PhilKang0704](https://github.com/PhilKang0704) - Phil ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [Rageking8](https://github.com/Rageking8) -  ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [sailro](https://github.com/sailro) - Sebastien Lebreton ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [Vincezhaoc](https://github.com/Vincezhaoc) - Vince Zhao ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)
- [vritme](https://github.com/vritme) -  ![1 pull requests.](https://img.shields.io/badge/Merged%20Pull%20Requests-1-green)

