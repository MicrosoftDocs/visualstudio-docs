---
title: "Visual Studio docs: History of what's new "
titleSuffix: ""
description: "History of what's new in Visual Studio docs"
ms.date: 12/04/2020
helpviewer_keywords:
  - "Visual Studio, what's new, docs"
  - "what's new [Visual Studio]"
ms.assetid: 511DAFC7-896E-449A-BFF7-0E8F7BBA8A78
author: JoshuaPartlow
ms.author: joshuapa
manager: jillfra
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.topic: conceptual
ms.workload:
  - "multiple"
---

# History of what's new in Visual Studio docs

Welcome to the history of what's new in Visual Studio docs. This article contains the major changes to the docs prior to November 2020 (starting July 2020). For the latest What's New, see [Visual Studio docs: What's new in the docs](whats-new-visual-studio-docs.md).

## October 2020
### Code quality

**Updated articles**
- [Code analyzers](../code-quality/index.yml) - CA refactor for .NET 5

### Containers

**Updated articles**

- [Quickstart: Use Docker with a React Single-page App in Visual Studio](../containers/container-tools-react.md)
  - Container Tools: remove references to old image repository
  - Update Containers React tutorial for .NET 3.1 and VS 16.7
- [How Bridge to Kubernetes works](../containers/overview-bridge-to-kubernetes.md) - Bridge to Kubernetes: add limitations
- [Debug apps in a local Docker container](../containers/edit-and-refresh.md) - Docker Toolbox

### Debugger

**New articles**

- [DirectX 12 Support in Visual Studio](../debugger/graphics/visual-studio-graphics-diagnostics-directx-12.md) - Vsdg dx12

**Updated articles**

- [Debug ASP.NET or ASP.NET Core apps in Visual Studio](../debugger/how-to-enable-debugging-for-aspnet-applications.md) - Debugger content fixes for GitHub issues
- [Use breakpoints in the Visual Studio debugger](../debugger/using-breakpoints.md) - Debugger content fixes for GitHub issues
- [Debug Azure services in Visual Studio](../debugger/debug-azure-apps.md) - SEO and link updates for snapshot debugger
- [Debug live ASP.NET Azure apps using the Snapshot Debugger](../debugger/debug-live-azure-applications.md) - SEO and link updates for snapshot debugger
- [Remote Debugging](../debugger/remote-debugging.md) - SEO and link updates for snapshot debugger
- [Overview of Visual Studio Graphics Diagnostics](../debugger/graphics/overview-of-visual-studio-graphics-diagnostics.md) - Vsdg dx12
- [Visual Studio Graphics Diagnostics](../debugger/graphics/visual-studio-graphics-diagnostics.md) - Vsdg dx12

### Get started

**Updated articles**

- [Tutorial: Extend a simple C# console app](../get-started/csharp/tutorial-console-part-2.md) - Debugging additions for extended C# tutorial

### IDE

**New articles**

- [Use Visual Studio search](./visual-studio-search.md) - VS Search document

### Install

**Updated articles**

- [Visual Studio build numbers and release dates](../install/visual-studio-build-numbers-and-release-dates.md)
  - add 16.7.7 and 16.8 Preview 6 data
  - add 16.8 Preview 5 info

### MSBuild

**Updated articles**

- [Walkthrough: Use MSBuild](../msbuild/walkthrough-using-msbuild.md) - MSBuild walkthrough: add standalone install steps

### Profiling

**Updated articles**

- [Analyze memory usage](../profiling/analyze-memory-usage.md)
  - Memory usage updates for profiling - links and clarifications
  - Memory usage tool updates
- [Analyze memory usage without debugging in the Performance Profiler](../profiling/memory-usage-without-debugging2.md)
  - Memory usage updates for profiling - links and clarifications
  - Memory usage tool updates
- [First look at profiling tools](../profiling/profiling-feature-tour.md)
  - Memory usage updates for profiling - links and clarifications
  - Memory usage tool updates
- [Run profiling tools with or without the debugger](../profiling/running-profiling-tools-with-or-without-the-debugger.md)
  - Memory usage updates for profiling - links and clarifications
  - Memory usage tool updates
- [Analyze CPU usage without debugging in the Performance Profiler](../profiling/cpu-usage.md) - Memory usage tool updates

### Windows

**Updated articles**

- [Visual Studio documentation | Microsoft Docs](../windows/index.yml) - Windows hub updates

### XAML tools

**New articles**

- [Use Design Time Data with the XAML Designer in Visual Studio](../xaml-tools/xaml-designtime-data.md)
  - Added extensibility section to XAML design-time docs
  - New design-time XAML article

## September 2020
### Code quality

**New articles**

- [CA1416: Validate platform compatibility](/dotnet/fundamentals/code-analysis/quality-rules/ca1416) - Documenting CA1416 Validate platform compatibility
- [CA1834: Use StringBuilder.Append(char) for single character strings](/dotnet/fundamentals/code-analysis/quality-rules/ca1834) - Docs for CA1834

**Updated**

- [Overview of source code analysis](../code-quality/roslyn-analyzers-overview.md) - Code analysis updates for .NET refactor
- [Configure code quality analysis](../code-quality/use-roslyn-analyzers.md) - Code analysis updates for .NET refactor

### Containers

**New articles**

- [Use Bridge to Kubernetes](../containers/bridge-to-kubernetes.md) - Local Process with Kubernetes rebranding to Bridge to Kubernetes
- [How Bridge to Kubernetes works](../containers/overview-bridge-to-kubernetes.md) - Local Process with Kubernetes rebranding to Bridge to Kubernetes

### Deployment

**Updated articles**

- [Deploy your app to a folder, IIS, Azure, or another destination](../deployment/deploying-applications-services-and-components-resources.md) - Deployment updates
- [Deploy an app to a folder using Visual Studio](../deployment/quickstart-deploy-to-local-folder.md) - Deployment updates

### IDE

**New articles**

- [New Git experience in Visual Studio (Preview)](./git-with-visual-studio.md) - add New Git Experience content (Preview)
- [C++ EditorConfig formatting conventions](./cpp-editorconfig-properties.md) - new article
- [What is GitHub Codespaces? (Preview)](./codespaces/codespaces-overview.md) - add Codespaces (Preview) content
- [How to customize a codespace (Preview)](./codespaces/customize-codespaces.md) - add Codespaces (Preview) content
- [Supported Visual Studio features (Preview)](./codespaces/supported-features-codespaces.md) - add Codespaces (Preview) content
- [How to use Visual Studio with a codespace (Preview)](./codespaces/use-visual-studio-with-codespaces.md) - add Codespaces (Preview) content

**Updated articles**

- [.NET coding convention settings for EditorConfig](/dotnet/fundamentals/code-analysis/code-style-rule-options) - updated editorconfig
- [Language conventions](/dotnet/fundamentals/code-analysis/style-rules/language-rules) - missing examples

### Install

**New articles**

- [Visual Studio on ARM-powered devices](../install/visual-studio-on-arm-devices.md) - Adding doc for VS on ARM

**Updated articles**

- [Troubleshoot network-related errors when you install or use Visual Studio](../install/troubleshooting-network-related-errors-in-visual-studio.md) - Add workaround for feedback auth proxy crash

### Profiling

**Updated articles**

- [Measure memory usage in Visual Studio](../profiling/memory-usage.md) - Updates to profiling feature tour
- [PerfTips](../profiling/perftips.md) - Updates to profiling feature tour
- [First look at profiling tools](../profiling/profiling-feature-tour.md) - Updates to profiling feature tour
- [Run profiling tools with or without the debugger](../profiling/running-profiling-tools-with-or-without-the-debugger.md)
  - Updates to profiling feature tour
  - Content performance improvements

## August 2020
### Azure

**New articles**

- [Add Azure Application Insights by using Visual Studio Connected Services](../azure/azure-app-insights-add-connected-service.md) - Connected services for VS 2019 16.7
- [Add Azure Cache for Redis by using Visual Studio Connected Services](../azure/azure-cache-for-redis-add-connected-service.md) - Connected services for VS 2019 16.7
- [Add Azure Cosmos DB to your app by using Visual Studio Connected Services](../azure/azure-cosmosdb-add-connected-service.md) - Connected services for VS 2019 16.7
- [Add Azure SignalR by using Visual Studio Connected Services](../azure/azure-signalr-add-connected-service.md) - Connected services for VS 2019 16.7
- [Add a connection to Azure SQL Database](../azure/azure-sql-database-add-connected-service.md) - Connected services for VS 2019 16.7

**Updated articles**

- [Adding Azure storage by using Visual Studio Connected Services](../azure/vs-azure-tools-connected-services-storage.md)
  - Connected services for VS 2019 16.7
  - Azure storage connected services article: update UI and project types supported

### Code quality

**New articles**

- [CA1310: Specify StringComparison for correctness](/dotnet/fundamentals/code-analysis/quality-rules/ca1310) - Add documentation for CA1310 and update documentation for CA1307
- [CA1837: Use Environment.ProcessId instead of Process.GetCurrentProcess().Id](/dotnet/fundamentals/code-analysis/quality-rules/ca1837) - Docs for CA1837
- [CA1838: Avoid `StringBuilder` parameters for P/Invokes](/dotnet/fundamentals/code-analysis/quality-rules/ca1838) - Add documentation for CA1838
- [CA2008: Do not create tasks without passing a TaskScheduler](/dotnet/fundamentals/code-analysis/quality-rules/ca2008) - Add documentation for CA2008
- [CA2249: Consider using String.Contains instead of String.IndexOf](/dotnet/fundamentals/code-analysis/quality-rules/ca2249) - Docs for CA2249
- [CA2361: Ensure autogenerated class containing DataSet.ReadXml() is not used with untrusted data](/dotnet/fundamentals/code-analysis/quality-rules/ca2361) - More DataSet/DataTable rules
- [CA2362: Unsafe DataSet or DataTable in autogenerated serializable type can be vulnerable to remote code execution attacks](/dotnet/fundamentals/code-analysis/quality-rules/ca2362) - More DataSet/DataTable rules
- [IL3000: Avoid using accessing Assembly file path when publishing as a single-file](/dotnet/fundamentals/code-analysis/quality-rules/il3000) - Add documentation for IL3000
- [IL3001: Avoid accessing Assembly file path when publishing as a single file](/dotnet/fundamentals/code-analysis/quality-rules/il3001) - Add docs for IL3001

**Updated**

- [CA1002: Do not expose generic lists](/dotnet/fundamentals/code-analysis/quality-rules/ca1002) - Add Configurability - Api Surface section
- [CA1046: Do not overload operator equals on reference types](/dotnet/fundamentals/code-analysis/quality-rules/ca1046) - Add Configurability - Api Surface section
- [CA1307: Specify StringComparison for clarity](/dotnet/fundamentals/code-analysis/quality-rules/ca1307) - Add documentation for CA1310 and update documentation for CA1307
- [CA1700: Do not name enum values &#39;Reserved&#39;](/dotnet/fundamentals/code-analysis/quality-rules/ca1700) - Add Configurability - Api Surface section
- [CA1707: Identifiers should not contain underscores](/dotnet/fundamentals/code-analysis/quality-rules/ca1707) - Add Configurability - Api Surface section
- [CA1822: Mark members as static](/dotnet/fundamentals/code-analysis/quality-rules/ca1822) - Add Configurability - Api Surface section
- [CA2351: Ensure DataSet.ReadXml()'s input is trusted](/dotnet/fundamentals/code-analysis/quality-rules/ca2351) - More DataSet/DataTable rules
- [Install third-party analyzers](../code-quality/install-roslyn-analyzers.md) - changed structure and titles for code analysis documentation

### Containers

**Updated articles**

- [Deploy an ASP.NET container to a container registry using Visual Studio](../containers/hosting-web-apps-in-docker.md) - Container Tools updates for Visual Studio 16.7 Publish UI
- [Get started with Visual Studio Kubernetes Tools](../containers/bridge-to-kubernetes.md) - Kubernetes tutorial: Add steps for removal

### Deployment

**New articles**

- [Visual Studio Installer Projects Extension and .NET Core 3.1](../deployment/installer-projects-net-core.md) - Creating new help page for installer projects .NET Core 3.1 features

**Updated articles**

- [Deploy your app to a folder, IIS, Azure, or another destination](../deployment/deploying-applications-services-and-components-resources.md) - Deployment updates
- [Deployment in Visual Studio](../deployment/index.yml) - Deployment updates

### Extensibility

**Updated articles**
- [Project Subtypes](../extensibility/internals/project-subtypes.md) - Fix list items indentation
- [Color value reference for Visual Studio](../extensibility/ux-guidelines/color-value-reference-for-visual-studio.md) - AB#1759333 Fix missing column headers

### Get started

**Updated articles**

- [Step 5: Deploy your ASP.NET Core app to Azure](../get-started/csharp/tutorial-aspnet-core-ef-step-05.md) - Video tutorial updates for new Connected Services UI

### IDE

**New articles**

- [Change the F1 help key in Visual Studio](./not-in-toc/change-f1-help-key.md) - Refactor default F1 Help page
- [F1 help for the text editor](./not-in-toc/default-f1-text-editor.md) - Refactor default F1 Help page
- [Convert `typeof` to `nameof`](./reference/convert-typeof-to-nameof.md) - Convert typeof to nameof refactoring
- [Simplify LINQ expression](./reference/simplify-linq-expression.md) - Simplify LINQ expression refactoring

**Updated articles**

- [Customize window layouts in Visual Studio](./customizing-window-layouts-in-visual-studio.md) - add monikered vertical document tabs info to Customize Window Layouts article.
- [How to report a problem with Visual Studio or Visual Studio Installer](./how-to-report-a-problem-with-visual-studio.md)
  - Added more info to NMI
  - Redid the whole Report a Problem page
- [F1 help](./not-in-toc/default.md) - Refactor default F1 Help page
- [AutoRecover, Environment, Options dialog box](./reference/autorecover-environment-options-dialog-box.md) - add info about updated autosave file locations
- [Options, Text Editor, Basic (Visual Basic), Advanced](./reference/options-text-editor-basic-visual-basic.md) - Added basic documentation for inline parameter name hints
- [Options, Text Editor, C#, Advanced](./reference/options-text-editor-csharp-advanced.md) - Added basic documentation for inline parameter name hints
- [Visual Studio performance tips and tricks](./visual-studio-performance-tips-and-tricks.md) - add 'disable map mode' and 'disable word wrap' info
- [What's new in Visual Studio 2019](./whats-new-visual-studio-2019.md) - update What's New in Visual Studio 2019 with 16.7 GA info

### RTVS

**Updated articles**

- [Work with SQL Server and R](../rtvs/integrating-sql-server-with-r.md) - corrected tables to include column headers

## July 2020
### Code quality

**New articles**

- [CA1417: Do not use `OutAttribute` on string parameters for P/Invokes](/dotnet/fundamentals/code-analysis/quality-rules/ca1417) - Add documentation for CA1417
- [CA1805: Do not initialize unnecessarily.](/dotnet/fundamentals/code-analysis/quality-rules/ca1805) - Add docs for CA1805
- [CA1836: Prefer IsEmpty over Count when available](/dotnet/fundamentals/code-analysis/quality-rules/ca1836) - Add documentation for CA1836 (Prefer IsEmpty over Count)
- [CA2016: Forward the CancellationToken parameter to methods that take one](/dotnet/fundamentals/code-analysis/quality-rules/ca2016) - Document CA2016 - Forward the CancellationToken parameter to methods that take one
- [CA2350: Ensure DataTable.ReadXml()'s input is trusted](/dotnet/fundamentals/code-analysis/quality-rules/ca2350) - Initial DataSet / DataTable deserialization rules docs
- [CA2351: Ensure DataSet.ReadXml()'s input is trusted](/dotnet/fundamentals/code-analysis/quality-rules/ca2351) - Initial DataSet / DataTable deserialization rules docs
- [CA2352: Unsafe DataSet or DataTable in serializable type can be vulnerable to remote code execution attacks](/dotnet/fundamentals/code-analysis/quality-rules/ca2352) - Initial DataSet / DataTable deserialization rules docs
- [CA2353: Unsafe DataSet or DataTable in serializable type](/dotnet/fundamentals/code-analysis/quality-rules/ca2353) - Initial DataSet / DataTable deserialization rules docs
- [CA2354: Unsafe DataSet or DataTable in deserialized object graph can be vulnerable to remote code execution attack](/dotnet/fundamentals/code-analysis/quality-rules/ca2354) - Initial DataSet / DataTable deserialization rules docs
- [CA2355: Unsafe DataSet or DataTable in deserialized object graph](/dotnet/fundamentals/code-analysis/quality-rules/ca2355) - Initial DataSet / DataTable deserialization rules docs
- [CA2356: Unsafe DataSet or DataTable type in web deserialized object graph](/dotnet/fundamentals/code-analysis/quality-rules/ca2356) - Initial DataSet / DataTable deserialization rules docs

### Containers

**New articles**

- [Configure Local Process with Kubernetes](../containers/configure-bridge-to-kubernetes.md) - Local Process with Kubernetes: yaml configuration
- [Use Local Process with Kubernetes (preview)](../containers/bridge-to-kubernetes.md) - Dev spaces migration
- [How Local Process with Kubernetes works](../containers/overview-bridge-to-kubernetes.md)
  - Local Process for Kubernetes: Add routing section
  - Dev spaces migration

### Cross platform

**Updated articles**

- [Change log (Visual Studio Tools for Unity, Windows)](/gamedev/unity/change-log-visual-studio-tools-for-unity.md) - Bump VSTU changelog to 4.7.1.0
- [Change Log (Visual Studio Tools for Unity, Mac)](/gamedev/unity/change-log-visual-studio-tools-for-unity-mac.md) - Bump VSTUM changelog to 2.7.1.0

### Get started

**New articles**

- [Tutorial: Extend a simple C# console app](../get-started/csharp/tutorial-console-part-2.md) - Release extend sidewalk tutorial first version

### IDE

**New articles**

- [Developer Community guidelines](./developer-community-guidelines.md) - Added DevCom Guidelines
- [IntelliSense completion for unimported types and extension methods](./reference/intellisense-completion-unimported-types-extension-methods.md)

### Install

**New articles**

- [Update Visual Studio using a minimal offline layout](../install/update-minimal-layout.md) - Document minimal layout feature
- [Visual Studio enterprise guide](../install/visual-studio-enterprise-guide.md) - Enterprise guide

### JavaScript

**New articles**

- [Compile TypeScript code (Node.js)](../javascript/compile-typescript-code-npm.md) - TypeScript compile and build
- [Compile TypeScript code (ASP.NET Core)](../javascript/compile-typescript-code-nuget.md) - TypeScript compile and build

### MSBuild

**New articles**

- [Common MSBuild item metadata](../msbuild/common-msbuild-item-metadata.md) - MSBuild: add table for optional metadata with Link and LinkBase
- [Solution filters in MSBuild](../msbuild/solution-filters.md) - MSBuild solution filters

### Test

**New articles**

- [Debug and analyze unit tests with Test Explorer](../test/debug-unit-tests-with-test-explorer.md) - Test Explorer performance work

**Updated articles**

- [Configure unit tests by using a *.runsettings* file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)
  - Updates to configuring unit tests using a runsettings file
  - Blame option description was changed and example was added.