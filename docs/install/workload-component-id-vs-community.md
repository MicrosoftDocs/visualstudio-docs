---
title: Visual Studio Community 2017 workload and component IDs | Microsoft Docs
description: "Use workload and component IDs to install Visual Studio by using the command line or to specify as a dependency in a VSIX manifest"
keywords: 
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.date: 12/01/2017
ms.topic: article
helpviewer_keywords: 
  - "workload ID, Visual Studio"
  - "component ID, Visual Studio"
  - "install Visual Studio, administrator guide"
ms.service: 
ms.technology: 
  - "vs-acquisition"
ms.assetid: 58494fc3-12de-4761-bd4a-74b54f72bfb3
ms.workload: 
  - "multiple"
---

# Visual Studio Community 2017 workload and component IDs

The tables on this page list the IDs that you can use to install Visual Studio by using the command line or that you can specify as a dependency in a VSIX manifest. Note that we will add additional components as we release updates to Visual Studio.

Also note the following about the page:

* Each workload has its own section, followed by the workload ID and a table of the components that are available for the workload.
* By default, the **Required** components will be installed when you install the workload. If you choose to, you can also install the **Recommended** and **Optional** components.
* We've also added a section that lists the additional components that are not affiliated with any workload.

When you set dependencies in your VSIX manifest, you must specify Component IDs only. Use the tables on this page to determine our minimum component dependencies. In some scenarios, this might mean that you specify only one component from a workload. In other scenarios, it might mean that you specify multiple components from a single workload or multiple components from multiple workloads. For more information, see the [How to: Migrate Extensibility Projects to Visual Studio 2017](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md) page.

For more information about how to use these IDs, see [Use Command-Line Parameters to Install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) page.

## Visual Studio core editor (included with Visual Studio Community 2017)

**ID:** Microsoft.VisualStudio.Workload.CoreEditor

**Description:** The Visual Studio core shell experience, including syntax-aware code editing, source code control and work item management.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.CoreEditor | Visual Studio core editor | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.StartPageExperiment.Cpp | Visual Studio Start Page for C++ Users | 15.0.27128.1 | Optional

## Azure development

**ID:** Microsoft.VisualStudio.Workload.Azure

**Description:** Azure SDK, tools, and projects for developing cloud apps and creating resources.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Required
Component.Microsoft.VisualStudio.Web.AzureFunctions | Microsoft Azure WebJobs Tools | 15.0.27128.1 | Required
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Required
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Required
Microsoft.Component.NetFX.Core.Runtime | .NET Core runtime | 15.0.26208.0 | Required
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Required
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.0.26606.0 | Required
Microsoft.Net.Core.Component.SDK | .NET Core 1.0 - 1.1 development tools | 15.0.26606.0 | Required
Microsoft.NetCore.ComponentGroup.DevelopmentTools | .NET Core 2.0 development tools | 15.0.27019.1 | Required
Microsoft.NetCore.ComponentGroup.Web | .NET Core 2.0 development tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.0.26823.1 | Required
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.10.50912.1 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.0.27128.1 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26919.1 | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.0.26906.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26208.0 | Required
Microsoft.VisualStudio.ComponentGroup.Azure.Prerequisites | Azure development prerequisites | 15.0.27128.1 | Required
Microsoft.VisualStudio.ComponentGroup.AzureFunctions | Microsoft Azure WebJobs Tools | 15.0.27128.1 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Required
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake and Stream Analytics Tools | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.Azure.MobileAppsSdk | Azure Mobile Apps SDK | 15.0.26504.0 | Recommended
Microsoft.VisualStudio.Component.Azure.ResourceManager.Tools | Azure Resource Manager core tools | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.Azure.ServiceFabric.Tools | Service Fabric Tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.ComponentGroup.Azure.CloudServices | Azure Cloud Services tools | 15.0.26504.0 | Recommended
Microsoft.VisualStudio.ComponentGroup.Azure.ResourceManager.Tools | Azure Resource Manager tools | 15.0.27005.2 | Recommended
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.0.26208.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.0.26208.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.0.27128.1 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.0.27019.1 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.0.26419.1 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.0.26621.2 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.0.27019.1 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.0.27005.2 | Optional
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools for Desktop | 15.0.26919.1 | Optional
Microsoft.NetCore.1x.ComponentGroup.Web | .NET Core 1.0 - 1.1 development tools for Web | 15.0.26919.1 | Optional
Microsoft.VisualStudio.Component.Azure.Storage.AzCopy | Azure Storage AzCopy | 15.0.26906.1 | Optional
Microsoft.VisualStudio.Component.PowerShell.Tools | PowerShell tools | 3.0.552 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 15.0.27005.2 | Optional

## Data storage and processing

**ID:** Microsoft.VisualStudio.Workload.Data

**Description:** Connect, develop, and test data solutions with SQL Server, Azure Data Lake, or Hadoop.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Recommended
Component.Redgate.SQLSearch.VSExtension | Redgate SQL Search | 2.4.2.1439 | Recommended
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Recommended
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake and Stream Analytics Tools | 15.0.27005.2 | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Recommended
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.0.26823.1 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.10.50912.1 | Recommended
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26919.1 | Recommended
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.0.26906.1 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 15.0.27102.0 | Optional

## Data science and analytical applications

**ID:** Microsoft.VisualStudio.Workload.DataScience

**Description:** Languages and tooling for creating data science applications, including Python, R and F#.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Anaconda3.x64 | Anaconda3 64-bit (5.0.0) | 5.0.0 | Recommended
Microsoft.Component.CookiecutterTools | Cookiecutter template support | 15.0.26621.2 | Recommended
Microsoft.Component.PythonTools | Python language support | 15.0.26823.1 | Recommended
Microsoft.Component.PythonTools.Web | Python web support | 15.0.27005.2 | Recommended
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.0.27019.1 | Recommended
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.10.50912.1 | Recommended
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 15.0.27102.0 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.R.Open | Microsoft R Client (3.3.2) | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.RHost | Runtime support for R development tools | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.RTools | R language support | 15.0.26919.1 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Recommended
Component.Anaconda2.x64 | Anaconda2 64-bit (5.0.0) | 5.0.0 | Optional
Component.Anaconda2.x86 | Anaconda2 32-bit (5.0.0) | 5.0.0 | Optional
Component.Anaconda3.x86 | Anaconda3 32-bit (5.0.0) | 5.0.0 | Optional
Microsoft.ComponentGroup.PythonTools.NativeDevelopment | Python native development tools | 15.0.27005.2 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.0.26823.1 | Optional
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.140 | VC++ 2015.3 v140 toolset for desktop (x86,x64) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26606.0 | Optional
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 15.0.26823.1 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop | Windows 10 SDK (10.0.16299.0) for Desktop C++ [x86 and x64] | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.0.27128.1 | Optional

## .NET desktop development

**ID:** Microsoft.VisualStudio.Workload.ManagedDesktop

**Description:** Build WPF, Windows Forms, and console applications using C#, Visual Basic, and F#.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Required
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Prerequisites | .NET desktop development tools | 15.0.27102.0 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Required
Microsoft.ComponentGroup.Blend | Blend for Visual Studio | 15.0.27005.2 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | 15.0.26208.0 | Recommended
Component.Dotfuscator | PreEmptive Protection - Dotfuscator | 15.0.26208.0 | Optional
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.0.26208.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.0.26208.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.0.27128.1 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.0.27019.1 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.0.26419.1 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.0.26621.2 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.0.27019.1 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.0.27005.2 | Optional
Microsoft.Net.Core.Component.SDK | .NET Core 1.0 - 1.1 development tools | 15.0.26606.0 | Optional
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools for Desktop | 15.0.26919.1 | Optional
Microsoft.NetCore.ComponentGroup.DevelopmentTools | .NET Core 2.0 development tools | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 15.0.27102.0 | Optional
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26919.1 | Optional
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 15.0.27005.2 | Optional
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26208.0 | Optional

## Game development with Unity

**ID:** Microsoft.VisualStudio.Workload.ManagedGame

**Description:** Create 2D and 3D games with Unity, a powerful cross-platform development environment.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Net.Component.3.5.DeveloperTools | .NET Framework 3.5 development tools | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Unity | Visual Studio Tools for Unity | 15.0.27005.2 | Required
Component.UnityEngine.x64 | Unity 2017.2 64-bit Editor | 15.0.27128.1 | Recommended
Component.UnityEngine.x86 | Unity 5.6 32-bit Editor | 15.0.27102.0 | Recommended

## Linux development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeCrossPlat

**Description:** Create and debug applications running in a Linux environment.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.0.26621.2 | Required
Component.Linux.CMake | Visual C++ tools for CMake and Linux | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop | Windows 10 SDK (10.0.16299.0) for Desktop C++ [x86 and x64] | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Recommended
Component.MDD.Linux | Visual C++ for Linux Development | 15.0.27005.2 | Optional
Component.MDD.Linux.GCC.arm | Embedded and IoT Development | 15.0.27102.0 | Optional

## Desktop development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeDesktop

**Description:** Build classic Windows-based applications using the power of the Visual C++ toolset, ATL, and optional features like MFC and C++/CLI.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.VC.Redist.14.Latest | Visual C++ 2017 Redistributable Update | 15.0.27019.1 | Required
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Core | Visual C++ core desktop features | 15.0.27102.0 | Required
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.0.26823.1 | Recommended
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.VC.CMake.Project | Visual C++ tools for CMake | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 15.0.26823.1 | Recommended
Microsoft.VisualStudio.Component.VC.TestAdapterForBoostTest | Test Adapter for Boost.Test | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.VC.TestAdapterForGoogleTest | Test Adapter for Google Test | 15.0.27102.0 | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop | Windows 10 SDK (10.0.16299.0) for Desktop C++ [x86 and x64] | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Recommended
Component.Incredibuild | IncrediBuild - Build Acceleration | 15.0.27019.1 | Optional
Component.IncredibuildMenu | IncrediBuildMenu | 1.5.0.2 | Optional
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.0.27019.1 | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.VC.140 | VC++ 2015.3 v140 toolset for desktop (x86,x64) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.ATL | Visual C++ ATL support | 15.0.26823.1 | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | MFC and ATL support (x86 and x64) | 15.0.27005.2 | Optional
Microsoft.VisualStudio.Component.VC.ClangC2 | Clang/C2 (experimental) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.CLI.Support | C++/CLI support | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.Modules.x86.x64 | Modules for Standard Library (experimental) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.Desktop | Windows 10 SDK (10.0.15063.0) for Desktop C++ [x86 and x64] | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP | Windows 10 SDK (10.0.15063.0) for UWP: C#, VB, JS | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP.Native | Windows 10 SDK (10.0.15063.0) for UWP: C++ | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.WinXP | Windows XP support for C++ | 15.0.27019.1 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Win81 | Windows 8.1 SDK and UCRT SDK | 15.0.27019.1 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.WinXP | Windows XP support for C++ | 15.0.27019.1 | Optional

## Game development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeGame

**Description:** Use the full power of C++ to build professional games powered by DirectX, Unreal, or Cocos2d.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.VC.Redist.14.Latest | Visual C++ 2017 Redistributable Update | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.0.26823.1 | Recommended
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 15.0.26823.1 | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop | Windows 10 SDK (10.0.16299.0) for Desktop C++ [x86 and x64] | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.0.27128.1 | Recommended
Component.Android.NDK.R12B | Android NDK (R12B) | 12.1.9 | Optional
Component.Android.SDK23.Private | Android SDK setup (API level 23) (local install) | 15.0.27128.1 | Optional
Component.Ant | Apache Ant (1.9.3) | 1.9.3.7 | Optional
Component.Cocos | Cocos | 15.0.26906.1 | Optional
Component.Incredibuild | IncrediBuild - Build Acceleration | 15.0.27019.1 | Optional
Component.IncredibuildMenu | IncrediBuildMenu | 1.5.0.2 | Optional
Component.JavaJDK | Java SE Development Kit (8.0.1120.15) | 15.0.26403.0 | Optional
Component.MDD.Android | C++ Android development tools | 15.0.26606.0 | Optional
Component.Unreal | Unreal Engine installer | 15.0.26621.2 | Optional
Component.Unreal.Android | Visual Studio Android support for Unreal Engine | 15.0.27005.2 | Optional
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.0.27019.1 | Optional
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Optional
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.0.26606.0 | Optional
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.Desktop | Windows 10 SDK (10.0.15063.0) for Desktop C++ [x86 and x64] | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP | Windows 10 SDK (10.0.15063.0) for UWP: C#, VB, JS | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP.Native | Windows 10 SDK (10.0.15063.0) for UWP: C++ | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.0.26208.0 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Win81 | Windows 8.1 SDK and UCRT SDK | 15.0.27019.1 | Optional

## Mobile development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeMobile

**Description:** Build cross-platform applications for iOS, Android or Windows using C++.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26606.0 | Required
Component.Android.NDK.R13B | Android NDK (R13B) | 13.1.6 | Recommended
Component.Android.SDK19 | Android SDK setup (API level 19 and 21) | 15.0.27128.1 | Recommended
Component.Android.SDK22 | Android SDK setup (API level 22) | 15.0.27128.1 | Recommended
Component.Android.SDK25 | Android SDK setup (API level 25) | 15.0.27128.1 | Recommended
Component.Ant | Apache Ant (1.9.3) | 1.9.3.7 | Recommended
Component.MDD.Android | C++ Android development tools | 15.0.26606.0 | Recommended
Component.Android.NDK.R12B | Android NDK (R12B) | 12.1.9 | Optional
Component.Android.NDK.R12B_3264 | Android NDK (R12B) (32bit) | 12.1.10 | Optional
Component.Android.NDK.R13B_3264 | Android NDK (R13B) (32bit) | 13.1.7 | Optional
Component.Android.SDK23 | Android SDK setup (API level 23) (global install) | 15.0.27128.1 | Optional
Component.Google.Android.Emulator.API23.V2 | Google Android Emulator (API Level 23) (global install) | 15.0.27128.1 | Optional
Component.HAXM | Intel Hardware Accelerated Execution Manager (HAXM) (global install) | 15.0.27128.1 | Optional
Component.Incredibuild | IncrediBuild - Build Acceleration | 15.0.27019.1 | Optional
Component.IncredibuildMenu | IncrediBuildMenu | 1.5.0.2 | Optional
Component.JavaJDK | Java SE Development Kit (8.0.1120.15) | 15.0.26403.0 | Optional
Component.MDD.IOS | C++ iOS development tools | 15.0.26621.2 | Optional

## .NET Core cross-platform development

**ID:** Microsoft.VisualStudio.Workload.NetCoreTools

**Description:** Build cross-platform applications using .NET Core, ASP.NET Core, HTML/JavaScript, and Containers including Docker support.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Core.Component.SDK | .NET Core 1.0 - 1.1 development tools | 15.0.26606.0 | Required
Microsoft.NetCore.ComponentGroup.DevelopmentTools | .NET Core 2.0 development tools | 15.0.27019.1 | Required
Microsoft.NetCore.ComponentGroup.Web | .NET Core 2.0 development tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Recommended
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Recommended
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.0.26823.1 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.10.50912.1 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26919.1 | Recommended
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.0.26906.1 | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Recommended
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools for Desktop | 15.0.26919.1 | Optional
Microsoft.NetCore.1x.ComponentGroup.Web | .NET Core 1.0 - 1.1 development tools for Web | 15.0.26919.1 | Optional
Microsoft.VisualStudio.ComponentGroup.IISDevelopment | Development time IIS support | 15.0.26720.2 | Optional

## Mobile development with .NET

**ID:** Microsoft.VisualStudio.Workload.NetCrossPlat

**Description:** Build cross-platform applications for iOS, Android or Windows using Xamarin.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Required
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Required
Microsoft.Net.Core.Component.SDK | .NET Core 1.0 - 1.1 development tools | 15.0.26606.0 | Required
Microsoft.NetCore.ComponentGroup.DevelopmentTools | .NET Core 2.0 development tools | 15.0.27019.1 | Required
Microsoft.NetCore.ComponentGroup.Web | .NET Core 2.0 development tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.10.50912.1 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26919.1 | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.0.26906.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26208.0 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions.TemplateEngine | ASP.NET templating engine | 15.0.27102.0 | Required
Component.Android.NDK.R13B | Android NDK (R13B) | 13.1.6 | Recommended
Component.Android.SDK25 | Android SDK setup (API level 25) | 15.0.27128.1 | Recommended
Component.Google.Android.Emulator.API25 | Google Android Emulator (API Level 25) | 15.0.27128.1 | Recommended
Component.HAXM | Intel Hardware Accelerated Execution Manager (HAXM) (global install) | 15.0.27128.1 | Recommended
Component.JavaJDK | Java SE Development Kit (8.0.1120.15) | 15.0.26403.0 | Recommended
Component.Xamarin | Xamarin | 15.0.27009.1 | Recommended
Component.Xamarin.Inspector | Xamarin Workbooks | 15.0.26606.0 | Recommended
Component.Xamarin.RemotedSimulator | Xamarin Remoted Simulator | 15.0.27005.2 | Recommended
Component.Xamarin.SdkManager | Xamarin SDK Manager | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Merq | Common Xamarin internal tools | 15.0.26720.2 | Recommended
Microsoft.VisualStudio.Component.MonoDebugger | Mono debugger | 15.0.26720.2 | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Optional
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.0.27005.2 | Optional
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.0.27128.1 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.Xamarin | Universal Windows Platform tools for Xamarin | 15.0.27005.2 | Optional

## ASP.NET and web development

**ID:** Microsoft.VisualStudio.Workload.NetWeb

**Description:** Build web applications using ASP.NET, ASP.NET Core, HTML/JavaScript, and Containers including Docker support.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Net.Core.Component.SDK | .NET Core 1.0 - 1.1 development tools | 15.0.26606.0 | Required
Microsoft.NetCore.ComponentGroup.DevelopmentTools | .NET Core 2.0 development tools | 15.0.27019.1 | Required
Microsoft.NetCore.ComponentGroup.Web | .NET Core 2.0 development tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Recommended
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Recommended
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.0.26823.1 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.10.50912.1 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26919.1 | Recommended
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.0.26906.1 | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Recommended
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.0.26208.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.0.26208.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.0.27128.1 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.0.27019.1 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.0.26419.1 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.0.26621.2 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.0.27019.1 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.0.27005.2 | Optional
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools for Desktop | 15.0.26919.1 | Optional
Microsoft.NetCore.1x.ComponentGroup.Web | .NET Core 1.0 - 1.1 development tools for Web | 15.0.26919.1 | Optional
Microsoft.VisualStudio.ComponentGroup.IISDevelopment | Development time IIS support | 15.0.26720.2 | Optional
Microsoft.VisualStudio.Web.Mvc4.ComponentGroup | ASP.NET MVC 4 | 15.0.26606.0 | Optional

## Node.js development

**ID:** Microsoft.VisualStudio.Workload.Node

**Description:** Build scalable network applications using Node.js, an asynchronous event-driven JavaScript runtime.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.Node.Tools | Node.js support | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26208.0 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.10.50912.1 | Optional
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26606.0 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.27019.1 | Optional

## Office/SharePoint development

**ID:** Microsoft.VisualStudio.Workload.Office

**Description:** Create Office and SharePoint add-ins, SharePoint solutions, and VSTO add-ins using C#, VB, and JavaScript.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Required
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Required
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.10.50912.1 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Prerequisites | .NET desktop development tools | 15.0.27102.0 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Sharepoint.Tools | Office Developer Tools for Visual Studio | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26919.1 | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.0.26906.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Workflow | Windows Workflow Foundation | 15.0.27005.2 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.TeamOffice | Visual Studio Tools for Office (VSTO) | 15.0.26606.0 | Recommended

## Python development

**ID:** Microsoft.VisualStudio.Workload.Python

**Description:** Editing, debugging, interactive development and source control for Python.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.CPython3.x64 | Python 3 64-bit (3.6.3) | 3.6.3.1 | Recommended
Microsoft.Component.CookiecutterTools | Cookiecutter template support | 15.0.26621.2 | Recommended
Microsoft.Component.PythonTools | Python language support | 15.0.26823.1 | Recommended
Microsoft.Component.PythonTools.Web | Python web support | 15.0.27005.2 | Recommended
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.10.50912.1 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Recommended
Component.Anaconda2.x64 | Anaconda2 64-bit (5.0.0) | 5.0.0 | Optional
Component.Anaconda2.x86 | Anaconda2 32-bit (5.0.0) | 5.0.0 | Optional
Component.Anaconda3.x64 | Anaconda3 64-bit (5.0.0) | 5.0.0 | Optional
Component.Anaconda3.x86 | Anaconda3 32-bit (5.0.0) | 5.0.0 | Optional
Component.CPython2.x64 | Python 2 64-bit (2.7.14) | 2.7.14 | Optional
Component.CPython2.x86 | Python 2 32-bit (2.7.14) | 2.7.14 | Optional
Component.CPython3.x86 | Python 3 32-bit (3.6.3) | 3.6.3.1 | Optional
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Optional
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Optional
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Optional
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Optional
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26208.0 | Optional
Microsoft.Component.PythonTools.UWP | Python IoT support | 15.0.26606.0 | Optional
Microsoft.ComponentGroup.PythonTools.NativeDevelopment | Python native development tools | 15.0.27005.2 | Optional
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Optional
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.0.26606.0 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.0.26823.1 | Optional
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.0.27005.2 | Optional
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.0.26823.1 | Optional
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26606.0 | Optional
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.0.26606.0 | Optional
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26919.1 | Optional
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.0.26906.1 | Optional
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.140 | VC++ 2015.3 v140 toolset for desktop (x86,x64) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26606.0 | Optional
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 15.0.26823.1 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.0.26606.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop | Windows 10 SDK (10.0.16299.0) for Desktop C++ [x86 and x64] | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.0.27128.1 | Optional
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools | 15.0.27005.2 | Optional

## Universal Windows Platform development

**ID:** Microsoft.VisualStudio.Workload.Universal

**Description:** Create applications for the Universal Windows Platform with C#, VB, JavaScript, or optionally C﻿+﻿+.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Required
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26208.0 | Required
Microsoft.ComponentGroup.Blend | Blend for Visual Studio | 15.0.27005.2 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Required
Microsoft.Net.Core.Component.SDK | .NET Core 1.0 - 1.1 development tools | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.UWP.Support | Universal Windows Platform tools | 15.0.26906.1 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.0.27128.1 | Required
Microsoft.VisualStudio.ComponentGroup.UWP.Cordova | Universal Windows Platform tools for Cordova | 15.0.27005.2 | Required
Microsoft.VisualStudio.ComponentGroup.UWP.NetCoreAndStandard | .NET Native and .NET Standard | 15.0.27102.0 | Required
Microsoft.VisualStudio.ComponentGroup.UWP.Xamarin | Universal Windows Platform tools for Xamarin | 15.0.27005.2 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Required
Microsoft.Component.VC.Runtime.OSSupport | Visual C++ runtime for UWP | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.0.26823.1 | Optional
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Phone.Emulator.15063 | Windows 10 Mobile Emulator (Creators Update) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26606.0 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM | Visual C++ compilers and libraries for ARM | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP | Windows 10 SDK (10.0.15063.0) for UWP: C#, VB, JS | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.0.27128.1 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.VC | C++ Universal Windows Platform tools | 15.0.27019.1 | Optional

## Visual Studio extension development

**ID:** Microsoft.VisualStudio.Workload.VisualStudioExtension

**Description:** Create add-ons and extensions for Visual Studio, including new commands, code analyzers and tool windows.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.27019.1 | Required
Microsoft.VisualStudio.ComponentGroup.VisualStudioExtension.Prerequisites | Visual Studio extension development prerequisites | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.0.27005.2 | Recommended
Component.Dotfuscator | PreEmptive Protection - Dotfuscator | 15.0.26208.0 | Optional
Microsoft.Component.CodeAnalysis.SDK | .NET Compiler Platform SDK | 15.0.27128.1 | Optional
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Optional
Microsoft.Component.VC.Runtime.OSSupport | Visual C++ runtime for UWP | 15.0.27019.1 | Optional
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.DslTools | Modeling SDK | 15.0.27005.2 | Optional
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.ATL | Visual C++ ATL support | 15.0.26823.1 | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | MFC and ATL support (x86 and x64) | 15.0.27005.2 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26606.0 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VSSDK | Visual Studio SDK | 15.0.26919.1 | Optional

## Mobile development with JavaScript

**ID:** Microsoft.VisualStudio.Workload.WebCrossPlat

**Description:** Build Android, iOS and UWP apps using Tools for Apache Cordova.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.CordovaToolset.6.3.1 | Cordova 6.3.1 toolset | 15.0.26504.0 | Required
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.Cordova | Mobile development with JavaScript core features | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.ProjectSystem | JavaScript ProjectSystem and Shared Tooling | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.TypeScript.2.3 | TypeScript 2.3 SDK | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.0.27019.1 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Required
Component.Android.SDK23.Private | Android SDK setup (API level 23) (local install) | 15.0.27128.1 | Optional
Component.Google.Android.Emulator.API23.Private | Google Android Emulator (API Level 23) (local install) | 15.0.27128.1 | Optional
Component.HAXM.Private | Intel Hardware Accelerated Execution Manager (HAXM) (local install) | 15.0.27128.1 | Optional
Component.JavaJDK | Java SE Development Kit (8.0.1120.15) | 15.0.26403.0 | Optional
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Optional
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.0.27005.2 | Optional
Microsoft.VisualStudio.Component.Git | Git for Windows | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.Phone.Emulator.15063 | Windows 10 Mobile Emulator (Creators Update) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.0.27128.1 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.Cordova | Universal Windows Platform tools for Cordova | 15.0.27005.2 | Optional

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name | Version
--- | --- | ---
Component.Android.Emulator | Visual Studio Emulator for Android | 15.0.27128.1
Component.Android.NDK.R11C | Android NDK (R11C) | 11.3.13
Component.Android.NDK.R11C_3264 | Android NDK (R11C) (32bit) | 11.3.15
Component.GitHub.VisualStudio | GitHub extension for Visual Studio | 2.2.0.10
Microsoft.Component.Blend.SDK.WPF | Blend for Visual Studio SDK for .NET | 15.0.27005.2
Microsoft.Component.HelpViewer | Help Viewer | 15.0.27005.2
Microsoft.VisualStudio.Component.DependencyValidation.Community | Dependency Validation | 15.0.26208.0
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 15.0.27005.2
Microsoft.VisualStudio.Component.LinqToSql | LINQ to SQL tools | 15.0.26208.0
Microsoft.VisualStudio.Component.Phone.Emulator | Windows 10 Mobile Emulator (Anniversary Edition) | 15.0.27019.1
Microsoft.VisualStudio.Component.TestTools.Core | Testing tools core features | 15.0.26606.0
Microsoft.VisualStudio.Component.TypeScript.2.0 | TypeScript 2.0 SDK | 15.0.26504.0
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | 15.0.26208.0
Microsoft.VisualStudio.Component.TypeScript.2.2 | TypeScript 2.2 SDK | 15.0.26504.0
Microsoft.VisualStudio.Component.VC.Tools.14.11 | VC++ 2017 version 15.4 v14.11 toolset | 15.0.27128.1
Microsoft.VisualStudio.Component.VC.Tools.ARM64 | Visual C++ compilers and libraries for ARM64 | 15.0.27019.1
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop.arm | Windows 10 SDK (10.0.16299.0) for Desktop C++ [ARM and ARM64] | 15.0.27128.1

## Get support
Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:
* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/), and ask questions and find answers.
* You can also engage with us and other Visual Studio developers through our [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).  (This option requires a [GitHub](https://github.com/) account.)

## See also

* [Visual Studio workload and component IDs](workload-and-component-ids.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
  * [Command-line parameter examples](command-line-parameter-examples.md)
* [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)
