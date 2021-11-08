---
title: Visual Studio Community 2017 workload and component IDs
titleSuffix: ""
description: "Use workload and component IDs to install Visual Studio by using the command line or to specify as a dependency in a VSIX manifest"
keywords:
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.date: 2/12/2019
ms.prod: visual-studio-windows
ms.technology: vs-installation
ms.topic: include
---
## Visual Studio core editor (included with Visual Studio Community 2017)

**ID:** Microsoft.VisualStudio.Workload.CoreEditor

**Description:** The Visual Studio core shell experience, including syntax-aware code editing, source code control and work item management.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.CoreEditor | Visual Studio core editor | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.StartPageExperiment.Cpp | Visual Studio Start Page for C++ Users | 15.0.27128.1 | Optional

## Azure development

**ID:** Microsoft.VisualStudio.Workload.Azure

**Description:** Azure SDKs, tools, and projects for developing cloud apps, creating resources, and building Containers including Docker support.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Required
Component.Microsoft.VisualStudio.Web.AzureFunctions | Microsoft Azure WebJobs Tools | 15.7.27617.1 | Required
Component.Microsoft.Web.LibraryManager | Library Manager | 15.8.27705.0 | Required
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.8.27825.0 | Required
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.Component.NetFX.Core.Runtime | .NET Core runtime | 15.0.26208.0 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.8.27825.0 | Required
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Required
Microsoft.NetCore.ComponentGroup.DevelopmentTools.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Required
Microsoft.NetCore.ComponentGroup.Web.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Required
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.9.28307.421 | Required
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.9.28307.421 | Required
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.9.28125.51 | Required
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 15.9.28230.55 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 15.9.28107.0 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.8.27906.1 | Required
Microsoft.VisualStudio.Component.DockerTools.BuildTools | Container development tools - Build Tools | 15.7.27617.1 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.FSharp.WebTemplates | F# language support for web projects | 15.9.28307.421 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.9.28125.51 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.7.27617.1 | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.9.28107.0 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TypeScript.3.1 | TypeScript 3.1 SDK | 15.0.28218.60 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.8.27825.0 | Required
Microsoft.VisualStudio.ComponentGroup.Azure.Prerequisites | Azure development prerequisites | 15.9.28107.0 | Required
Microsoft.VisualStudio.ComponentGroup.AzureFunctions | Microsoft Azure WebJobs Tools | 15.7.27617.1 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 15.9.28219.51 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Required
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake and Stream Analytics Tools | 15.9.28107.0 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.AspNet45 | Advanced ASP.NET features | 15.7.27625.0 | Recommended
Microsoft.VisualStudio.Component.Azure.MobileAppsSdk | Azure Mobile Apps SDK | 15.7.27625.0 | Recommended
Microsoft.VisualStudio.Component.Azure.ResourceManager.Tools | Azure Resource Manager core tools | 15.9.28107.0 | Recommended
Microsoft.VisualStudio.Component.Azure.ServiceFabric.Tools | Service Fabric Tools | 15.8.27825.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 15.9.28107.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton.BuildTools | Azure Cloud Services build tools | 15.7.27617.1 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.ComponentGroup.Azure.CloudServices | Azure Cloud Services tools | 15.0.26504.0 | Recommended
Microsoft.VisualStudio.ComponentGroup.Azure.ResourceManager.Tools | Azure Resource Manager tools | 15.0.27005.2 | Recommended
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.2.SDK | .NET Framework 4.7.2 SDK | 15.8.27825.0 | Optional
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 15.8.27825.0 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.2.DeveloperTools | .NET Framework 4.7.2 development tools | 15.8.27825.0 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Core.Component.SDK | .NET Core 2.0 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools | 15.6.27406.0 | Optional
Microsoft.NetCore.1x.ComponentGroup.Web | .NET Core 1.0 - 1.1 development tools for Web | 15.6.27406.0 | Optional
Microsoft.NetCore.ComponentGroup.DevelopmentTools | .NET Core 2.0 development tools | 15.8.27729.1 | Optional
Microsoft.NetCore.ComponentGroup.Web | .NET Core 2.0 development tools | 15.7.27625.0 | Optional
Microsoft.VisualStudio.Component.Azure.Storage.AzCopy | Azure Storage AzCopy | 15.0.26906.1 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 15.8.27924.0 | Optional

## Data storage and processing

**ID:** Microsoft.VisualStudio.Workload.Data

**Description:** Connect, develop, and test data solutions with SQL Server, Azure Data Lake, or Hadoop.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Recommended
Component.Microsoft.Web.LibraryManager | Library Manager | 15.8.27705.0 | Recommended
Component.Redgate.SQLSearch.VSExtension | Redgate SQL Search | 3.1.7.2062 | Recommended
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Recommended
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake and Stream Analytics Tools | 15.9.28107.0 | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.8.27825.0 | Recommended
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.8.27825.0 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.6.27406.0 | Recommended
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.9.28307.421 | Recommended
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.9.28307.421 | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.9.28125.51 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 15.9.28107.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton.BuildTools | Azure Cloud Services build tools | 15.7.27617.1 | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 15.9.28230.55 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 15.9.28107.0 | Recommended
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.8.27906.1 | Recommended
Microsoft.VisualStudio.Component.DockerTools.BuildTools | Container development tools - Build Tools | 15.7.27617.1 | Recommended
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.9.28125.51 | Recommended
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Recommended
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.6.27309.0 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.7.27617.1 | Recommended
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.9.28107.0 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.TypeScript.3.1 | TypeScript 3.1 SDK | 15.0.28218.60 | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.8.27825.0 | Recommended
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 15.9.28219.51 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Recommended
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 15.8.27825.0 | Optional

## Data science and analytical applications

**ID:** Microsoft.VisualStudio.Workload.DataScience

**Description:** Languages and tooling for creating data science applications, including Python, R and F#.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Anaconda3.x64 | Anaconda3 64-bit (5.2.0) | 5.2.0 | Recommended
Microsoft.Component.CookiecutterTools | Cookiecutter template support | 15.0.26621.2 | Recommended
Microsoft.Component.PythonTools | Python language support | 15.0.26823.1 | Recommended
Microsoft.Component.PythonTools.Web | Python web support | 15.9.28107.0 | Recommended
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 15.9.28107.0 | Recommended
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 15.8.27825.0 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.9.28125.51 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Recommended
Microsoft.VisualStudio.Component.R.Open | Microsoft R Client (3.3.2) | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.RHost | Runtime support for R development tools | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.Component.RTools | R language support | 15.0.26919.1 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.TypeScript.3.1 | TypeScript 3.1 SDK | 15.0.28218.60 | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Recommended
Component.Anaconda2.x64 | Anaconda2 64-bit (5.2.0) | 5.2.0 | Optional
Component.Anaconda2.x86 | Anaconda2 32-bit (5.2.0) | 5.2.0 | Optional
Component.Anaconda3.x86 | Anaconda3 32-bit (5.2.0) | 5.2.0 | Optional
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.6.27309.0 | Optional
Microsoft.ComponentGroup.PythonTools.NativeDevelopment | Python native development tools | 15.9.28307.102 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.VC.140 | VC++ 2015.3 v14.00 (v140) toolset for desktop | 15.7.27617.1 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 15.0.26823.1 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 version 15.9 v14.16 latest v141 tools | 15.9.28230.55 | Optional
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17763 | Windows 10 SDK (10.0.17763.0) | 15.9.28307.102 | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.6.27406.0 | Optional

## .NET desktop development

**ID:** Microsoft.VisualStudio.Workload.ManagedDesktop

**Description:** Build WPF, Windows Forms, and console applications using C#, Visual Basic, and F#.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.8.27825.0 | Required
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Prerequisites | .NET desktop development tools | 15.7.27625.0 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.6.27406.0 | Required
Microsoft.ComponentGroup.Blend | Blend for Visual Studio | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | 15.6.27406.0 | Recommended
Component.Dotfuscator | PreEmptive Protection - Dotfuscator | 15.0.26208.0 | Optional
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Optional
Component.Microsoft.Web.LibraryManager | Library Manager | 15.8.27705.0 | Optional
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Optional
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.2.SDK | .NET Framework 4.7.2 SDK | 15.8.27825.0 | Optional
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 15.8.27825.0 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.2.DeveloperTools | .NET Framework 4.7.2 development tools | 15.8.27825.0 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Core.Component.SDK | .NET Core 2.0 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Optional
Microsoft.NetCore.ComponentGroup.DevelopmentTools | .NET Core 2.0 development tools | 15.8.27729.1 | Optional
Microsoft.NetCore.ComponentGroup.DevelopmentTools.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Optional
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 15.9.28107.0 | Optional
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.8.27906.1 | Optional
Microsoft.VisualStudio.Component.DockerTools.BuildTools | Container development tools - Build Tools | 15.7.27617.1 | Optional
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.8.27825.0 | Optional
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 15.8.27825.0 | Optional
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.8.27729.1 | Optional
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.9.28125.51 | Optional
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Optional
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.7.27617.1 | Optional
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.9.28107.0 | Optional
Microsoft.VisualStudio.Component.TypeScript.3.1 | TypeScript 3.1 SDK | 15.0.28218.60 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 15.8.27924.0 | Optional
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.8.27825.0 | Optional
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 15.9.28219.51 | Optional
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Optional

## Game development with Unity

**ID:** Microsoft.VisualStudio.Workload.ManagedGame

**Description:** Create 2D and 3D games with Unity, a powerful cross-platform development environment.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Net.Component.3.5.DeveloperTools | .NET Framework 3.5 development tools | 15.6.27406.0 | Required
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Unity | Visual Studio Tools for Unity | 15.7.27617.1 | Required
Component.UnityEngine.x64 | Unity 2018.3 64-bit Editor | 15.9.28307.271 | Recommended
Component.UnityEngine.x86 | Unity 5.6 32-bit Editor | 15.6.27406.0 | Recommended

## Linux development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeCrossPlat

**Description:** Create and debug applications running in a Linux environment.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.MDD.Linux | Visual C++ for Linux Development | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.6.27406.0 | Required
Component.Linux.CMake | Visual C++ tools for CMake and Linux | 15.9.28307.102 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 version 15.9 v14.16 latest v141 tools | 15.9.28230.55 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.17763 | Windows 10 SDK (10.0.17763.0) | 15.9.28307.102 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Recommended
Component.MDD.Linux.GCC.arm | Embedded and IoT Development | 15.6.27309.0 | Optional

## Desktop development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeDesktop

**Description:** Build Windows desktop applications using the Microsoft C++ toolset, ATL, or MFC.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.VC.Redist.14.Latest | Visual C++ 2017 Redistributable Update | 15.6.27406.0 | Required
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Core | Visual C++ core desktop features | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 15.0.27005.2 | Recommended
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.VC.ATL | Visual C++ ATL for x86 and x64 | 15.7.27625.0 | Recommended
Microsoft.VisualStudio.Component.VC.CMake.Project | Visual C++ tools for CMake | 15.9.28307.102 | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 15.0.26823.1 | Recommended
Microsoft.VisualStudio.Component.VC.TestAdapterForBoostTest | Test Adapter for Boost.Test | 15.8.27906.1 | Recommended
Microsoft.VisualStudio.Component.VC.TestAdapterForGoogleTest | Test Adapter for Google Test | 15.8.27906.1 | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 version 15.9 v14.16 latest v141 tools | 15.9.28230.55 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.17763 | Windows 10 SDK (10.0.17763.0) | 15.9.28307.102 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Recommended
Component.Incredibuild | IncrediBuild - Build Acceleration | 15.7.27617.1 | Optional
Component.IncredibuildMenu | IncrediBuildMenu | 1.5.0.2 | Optional
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.6.27309.0 | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.VC.140 | VC++ 2015.3 v14.00 (v140) toolset for desktop | 15.7.27617.1 | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | Visual C++ MFC for x86 and x64 | 15.7.27625.0 | Optional
Microsoft.VisualStudio.Component.VC.CLI.Support | C++/CLI support | 15.6.27309.0 | Optional
Microsoft.VisualStudio.Component.VC.Modules.x86.x64 | Modules for Standard Library (experimental) | 15.6.27309.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.Desktop | Windows 10 SDK (10.0.15063.0) for Desktop C++ [x86 and x64] | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP | Windows 10 SDK (10.0.15063.0) for UWP: C#, VB, JS | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP.Native | Windows 10 SDK (10.0.15063.0) for UWP: C++ | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop | Windows 10 SDK (10.0.16299.0) for Desktop C++ [x86 and x64] | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop.arm | Windows 10 SDK (10.0.16299.0) for Desktop C++ [ARM and ARM64] | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17134 | Windows 10 SDK (10.0.17134.0) | 15.9.28307.102 | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.WinXP | Windows XP support for C++ | 15.8.27924.0 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Win81 | Windows 8.1 SDK and UCRT SDK | 15.6.27406.0 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.WinXP | Windows XP support for C++ | 15.8.27705.0 | Optional
Microsoft.VisualStudio.ComponentGroup.Windows10SDK.15063 | Windows 10 SDK (10.0.15063.0) | 15.8.27825.0 | Optional
Microsoft.VisualStudio.ComponentGroup.Windows10SDK.16299 | Windows 10 SDK (10.0.16299.0) | 15.8.27825.0 | Optional

## Game development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeGame

**Description:** Use the full power of C++ to build professional games powered by DirectX, Unreal, or Cocos2d.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.VC.Redist.14.Latest | Visual C++ 2017 Redistributable Update | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 version 15.9 v14.16 latest v141 tools | 15.9.28230.55 | Required
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 15.0.26823.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.17763 | Windows 10 SDK (10.0.17763.0) | 15.9.28307.102 | Recommended
Component.Android.NDK.R12B | Android NDK (R12B) | 12.1.10 | Optional
Component.Android.SDK23.Private | Android SDK setup (API level 23) (local install for Mobile development with JavaScript / C++) | 15.9.28016.0 | Optional
Component.Ant | Apache Ant (1.9.3) | 1.9.3.8 | Optional
Component.Cocos | Cocos | 15.0.26906.1 | Optional
Component.Incredibuild | IncrediBuild - Build Acceleration | 15.7.27617.1 | Optional
Component.IncredibuildMenu | IncrediBuildMenu | 1.5.0.2 | Optional
Component.MDD.Android | C++ Android development tools | 15.0.26606.0 | Optional
Component.OpenJDK | Microsoft distribution OpenJDK | 15.9.28125.51 | Optional
Component.Unreal | Unreal Engine installer | 15.8.27729.1 | Optional
Component.Unreal.Android | Visual Studio Android support for Unreal Engine | 15.9.28307.341 | Optional
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.6.27309.0 | Optional
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.8.27825.0 | Optional
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 15.9.28016.0 | Optional
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Optional
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.Desktop | Windows 10 SDK (10.0.15063.0) for Desktop C++ [x86 and x64] | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP | Windows 10 SDK (10.0.15063.0) for UWP: C#, VB, JS | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP.Native | Windows 10 SDK (10.0.15063.0) for UWP: C++ | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop | Windows 10 SDK (10.0.16299.0) for Desktop C++ [x86 and x64] | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop.arm | Windows 10 SDK (10.0.16299.0) for Desktop C++ [ARM and ARM64] | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17134 | Windows 10 SDK (10.0.17134.0) | 15.9.28307.102 | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.6.27406.0 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Win81 | Windows 8.1 SDK and UCRT SDK | 15.6.27406.0 | Optional
Microsoft.VisualStudio.ComponentGroup.Windows10SDK.15063 | Windows 10 SDK (10.0.15063.0) | 15.8.27825.0 | Optional
Microsoft.VisualStudio.ComponentGroup.Windows10SDK.16299 | Windows 10 SDK (10.0.16299.0) | 15.8.27825.0 | Optional

## Mobile development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeMobile

**Description:** Build cross-platform applications for iOS, Android or Windows using C++.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Android.SDK19.Private | Android SDK setup (API level 19) (local install for Mobile development with JavaScript / C++) | 15.9.28107.0 | Required
Component.Android.SDK21.Private | Android SDK setup (API level 21) (local install for Mobile development with JavaScript / C++) | 15.9.28016.0 | Required
Component.Android.SDK22.Private | Android SDK setup (API level 22) (local install for Mobile development with JavaScript / C++) | 15.9.28016.0 | Required
Component.Android.SDK23.Private | Android SDK setup (API level 23) (local install for Mobile development with JavaScript / C++) | 15.9.28016.0 | Required
Component.Android.SDK25.Private | Android SDK setup (API level 25) (local install for Mobile development with JavaScript / C++) | 15.9.28016.0 | Required
Component.OpenJDK | Microsoft distribution OpenJDK | 15.9.28125.51 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.6.27406.0 | Required
Component.Android.NDK.R15C | Android NDK (R15C) | 15.2.1 | Recommended
Component.Ant | Apache Ant (1.9.3) | 1.9.3.8 | Recommended
Component.MDD.Android | C++ Android development tools | 15.0.26606.0 | Recommended
Component.Android.NDK.R12B | Android NDK (R12B) | 12.1.10 | Optional
Component.Android.NDK.R12B_3264 | Android NDK (R12B) (32bit) | 12.1.11 | Optional
Component.Android.NDK.R13B | Android NDK (R13B) | 13.1.7 | Optional
Component.Android.NDK.R13B_3264 | Android NDK (R13B) (32bit) | 13.1.8 | Optional
Component.Android.NDK.R15C_3264 | Android NDK (R15C) (32bit) | 15.2.1 | Optional
Component.Google.Android.Emulator.API23.Private | Google Android Emulator (API Level 23) (local install) | 15.6.27413.0 | Optional
Component.HAXM.Private | Intel Hardware Accelerated Execution Manager (HAXM) (local install) | 15.9.28307.421 | Optional
Component.Incredibuild | IncrediBuild - Build Acceleration | 15.7.27617.1 | Optional
Component.IncredibuildMenu | IncrediBuildMenu | 1.5.0.2 | Optional
Component.MDD.IOS | C++ iOS development tools | 15.0.26621.2 | Optional

## .NET Core cross-platform development

**ID:** Microsoft.VisualStudio.Workload.NetCoreTools

**Description:** Build cross-platform applications using .NET Core, ASP.NET Core, HTML/JavaScript, and Containers including Docker support.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Required
Component.Microsoft.Web.LibraryManager | Library Manager | 15.8.27705.0 | Required
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.8.27825.0 | Required
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.8.27825.0 | Required
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Required
Microsoft.NetCore.ComponentGroup.DevelopmentTools.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Required
Microsoft.NetCore.ComponentGroup.Web.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 15.9.28107.0 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.8.27906.1 | Required
Microsoft.VisualStudio.Component.DockerTools.BuildTools | Container development tools - Build Tools | 15.7.27617.1 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.FSharp.WebTemplates | F# language support for web projects | 15.9.28307.421 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.9.28125.51 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.7.27617.1 | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.9.28107.0 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TypeScript.3.1 | TypeScript 3.1 SDK | 15.0.28218.60 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.6.27406.0 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 15.9.28219.51 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Required
Component.Microsoft.VisualStudio.Web.AzureFunctions | Microsoft Azure WebJobs Tools | 15.7.27617.1 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.8.27825.0 | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.9.28307.421 | Recommended
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.9.28307.421 | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.9.28125.51 | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 15.9.28230.55 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.8.27825.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.ComponentGroup.AzureFunctions | Microsoft Azure WebJobs Tools | 15.7.27617.1 | Recommended
Microsoft.VisualStudio.ComponentGroup.Web.CloudTools | Cloud tools for web development | 15.8.27729.1 | Recommended
Microsoft.Net.Core.Component.SDK | .NET Core 2.0 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools | 15.6.27406.0 | Optional
Microsoft.NetCore.1x.ComponentGroup.Web | .NET Core 1.0 - 1.1 development tools for Web | 15.6.27406.0 | Optional
Microsoft.NetCore.ComponentGroup.DevelopmentTools | .NET Core 2.0 development tools | 15.8.27729.1 | Optional
Microsoft.NetCore.ComponentGroup.Web | .NET Core 2.0 development tools | 15.7.27625.0 | Optional
Microsoft.VisualStudio.ComponentGroup.IISDevelopment | Development time IIS support | 15.9.28219.51 | Optional

## Mobile development with .NET

**ID:** Microsoft.VisualStudio.Workload.NetCrossPlat

**Description:** Build cross-platform applications for iOS, Android or Windows using Xamarin.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Xamarin | Xamarin | 15.8.27906.1 | Required
Component.Xamarin.RemotedSimulator | Xamarin Remoted Simulator | 15.6.27323.2 | Required
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.8.27825.0 | Required
Microsoft.Net.Core.Component.SDK | .NET Core 2.0 development tools | 15.6.27406.0 | Required
Microsoft.NetCore.ComponentGroup.DevelopmentTools | .NET Core 2.0 development tools | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.Merq | Common Xamarin internal tools | 15.8.27924.0 | Required
Microsoft.VisualStudio.Component.MonoDebugger | Mono debugger | 15.0.26720.2 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions.TemplateEngine | ASP.NET templating engine | 15.8.27729.1 | Required
Component.Android.SDK27 | Android SDK setup (API level 27) | 15.9.28016.0 | Recommended
Component.Google.Android.Emulator.API27 | Google Android Emulator (API Level 27) | 15.9.28307.421 | Recommended
Component.HAXM | Intel Hardware Accelerated Execution Manager (HAXM) (global install) | 15.9.28307.421 | Recommended
Component.OpenJDK | Microsoft distribution OpenJDK | 15.9.28125.51 | Recommended
Component.Xamarin.Inspector | Xamarin Workbooks | 15.0.26606.0 | Optional
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.8.27825.0 | Optional
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.8.27825.0 | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.8.27729.1 | Optional
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17763 | Windows 10 SDK (10.0.17763.0) | 15.9.28307.102 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.Xamarin | Universal Windows Platform tools for Xamarin | 15.9.28307.102 | Optional

## ASP.NET and web development

**ID:** Microsoft.VisualStudio.Workload.NetWeb

**Description:** Build web applications using ASP.NET, ASP.NET Core, HTML/JavaScript, and Containers including Docker support.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Required
Component.Microsoft.Web.LibraryManager | Library Manager | 15.8.27705.0 | Required
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.8.27825.0 | Required
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.8.27825.0 | Required
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Required
Microsoft.NetCore.ComponentGroup.DevelopmentTools.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Required
Microsoft.NetCore.ComponentGroup.Web.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 15.9.28107.0 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.8.27906.1 | Required
Microsoft.VisualStudio.Component.DockerTools.BuildTools | Container development tools - Build Tools | 15.7.27617.1 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.FSharp.WebTemplates | F# language support for web projects | 15.9.28307.421 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.9.28125.51 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.7.27617.1 | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.9.28107.0 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TypeScript.3.1 | TypeScript 3.1 SDK | 15.0.28218.60 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.8.27825.0 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 15.9.28219.51 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Required
Component.Microsoft.VisualStudio.Web.AzureFunctions | Microsoft Azure WebJobs Tools | 15.7.27617.1 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.8.27825.0 | Recommended
Microsoft.VisualStudio.Component.AspNet45 | Advanced ASP.NET features | 15.7.27625.0 | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.9.28307.421 | Recommended
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.9.28307.421 | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.9.28125.51 | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 15.9.28230.55 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 15.8.27924.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.ComponentGroup.AzureFunctions | Microsoft Azure WebJobs Tools | 15.7.27617.1 | Recommended
Microsoft.VisualStudio.ComponentGroup.Web.CloudTools | Cloud tools for web development | 15.8.27729.1 | Recommended
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.2.SDK | .NET Framework 4.7.2 SDK | 15.8.27825.0 | Optional
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 15.8.27825.0 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.2.DeveloperTools | .NET Framework 4.7.2 development tools | 15.8.27825.0 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Core.Component.SDK | .NET Core 2.0 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools | 15.6.27406.0 | Optional
Microsoft.NetCore.1x.ComponentGroup.Web | .NET Core 1.0 - 1.1 development tools for Web | 15.6.27406.0 | Optional
Microsoft.NetCore.ComponentGroup.DevelopmentTools | .NET Core 2.0 development tools | 15.8.27729.1 | Optional
Microsoft.NetCore.ComponentGroup.Web | .NET Core 2.0 development tools | 15.7.27625.0 | Optional
Microsoft.VisualStudio.ComponentGroup.IISDevelopment | Development time IIS support | 15.9.28219.51 | Optional
Microsoft.VisualStudio.Web.Mvc4.ComponentGroup | ASP.NET MVC 4 | 15.6.27406.0 | Optional

## Node.js development

**ID:** Microsoft.VisualStudio.Workload.Node

**Description:** Build scalable network applications using Node.js, an asynchronous event-driven JavaScript runtime. 

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.9.28125.51 | Required
Microsoft.VisualStudio.Component.Node.Build | Node.js MSBuild support | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.Node.Tools | Node.js development support | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Required
Microsoft.VisualStudio.Component.TestTools.Core | Testing tools core features | 15.7.27520.0 | Required
Microsoft.VisualStudio.Component.TypeScript.3.1 | TypeScript 3.1 SDK | 15.0.28218.60 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.8.27825.0 | Optional
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 15.9.28107.0 | Optional
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 version 15.9 v14.16 latest v141 tools | 15.9.28230.55 | Optional

## Office/SharePoint development

**ID:** Microsoft.VisualStudio.Workload.Office

**Description:** Create Office and SharePoint add-ins, SharePoint solutions, and VSTO add-ins using C#, VB, and JavaScript.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Required
Component.Microsoft.Web.LibraryManager | Library Manager | 15.8.27705.0 | Required
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.8.27825.0 | Required
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.8.27825.0 | Required
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 15.9.28107.0 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.8.27906.1 | Required
Microsoft.VisualStudio.Component.DockerTools.BuildTools | Container development tools - Build Tools | 15.7.27617.1 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.9.28125.51 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Prerequisites | .NET desktop development tools | 15.7.27625.0 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.Sharepoint.Tools | Office Developer Tools for Visual Studio | 15.8.27924.0 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.7.27617.1 | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.9.28107.0 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TypeScript.3.1 | TypeScript 3.1 SDK | 15.0.28218.60 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 15.8.27924.0 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.Workflow | Windows Workflow Foundation | 15.8.27825.0 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 15.9.28219.51 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.TeamOffice | Visual Studio Tools for Office (VSTO) | 15.7.27625.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.8.27729.1 | Recommended
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.2.SDK | .NET Framework 4.7.2 SDK | 15.8.27825.0 | Optional
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 15.8.27825.0 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.2.DeveloperTools | .NET Framework 4.7.2 development tools | 15.8.27825.0 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.6.27406.0 | Optional

## Python development

**ID:** Microsoft.VisualStudio.Workload.Python

**Description:** Editing, debugging, interactive development and source control for Python.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.PythonTools | Python language support | 15.0.26823.1 | Required
Component.CPython3.x64 | Python 3 64-bit (3.6.6) | 3.6.6 | Recommended
Microsoft.Component.CookiecutterTools | Cookiecutter template support | 15.0.26621.2 | Recommended
Microsoft.Component.PythonTools.Web | Python web support | 15.9.28107.0 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 15.9.28107.0 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.9.28125.51 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.TypeScript.3.1 | TypeScript 3.1 SDK | 15.0.28218.60 | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Recommended
Component.Anaconda2.x64 | Anaconda2 64-bit (5.2.0) | 5.2.0 | Optional
Component.Anaconda2.x86 | Anaconda2 32-bit (5.2.0) | 5.2.0 | Optional
Component.Anaconda3.x64 | Anaconda3 64-bit (5.2.0) | 5.2.0 | Optional
Component.Anaconda3.x86 | Anaconda3 32-bit (5.2.0) | 5.2.0 | Optional
Component.CPython2.x64 | Python 2 64-bit (2.7.14) | 2.7.14 | Optional
Component.CPython2.x86 | Python 2 32-bit (2.7.14) | 2.7.14 | Optional
Component.CPython3.x86 | Python 3 32-bit (3.6.6) | 3.6.6 | Optional
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 15.0.26720.2 | Optional
Component.Microsoft.Web.LibraryManager | Library Manager | 15.8.27705.0 | Optional
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Optional
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.8.27825.0 | Optional
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Optional
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26208.0 | Optional
Microsoft.Component.PythonTools.UWP | Python IoT support | 15.0.26606.0 | Optional
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.6.27309.0 | Optional
Microsoft.ComponentGroup.PythonTools.NativeDevelopment | Python native development tools | 15.9.28307.102 | Optional
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.8.27825.0 | Optional
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.8.27825.0 | Optional
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.9.28307.421 | Optional
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.9.28307.421 | Optional
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.9.28125.51 | Optional
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 15.9.28107.0 | Optional
Microsoft.VisualStudio.Component.Azure.Waverton.BuildTools | Azure Cloud Services build tools | 15.7.27617.1 | Optional
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.8.27729.1 | Optional
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.8.27906.1 | Optional
Microsoft.VisualStudio.Component.DockerTools.BuildTools | Container development tools - Build Tools | 15.7.27617.1 | Optional
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.8.27729.1 | Optional
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 15.8.27729.1 | Optional
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Optional
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.6.27309.0 | Optional
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Optional
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Optional
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.7.27617.1 | Optional
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.9.28107.0 | Optional
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VC.140 | VC++ 2015.3 v14.00 (v140) toolset for desktop | 15.7.27617.1 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 15.0.26823.1 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 version 15.9 v14.16 latest v141 tools | 15.9.28230.55 | Optional
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.8.27825.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17763 | Windows 10 SDK (10.0.17763.0) | 15.9.28307.102 | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.6.27406.0 | Optional
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 15.9.28219.51 | Optional

## Universal Windows Platform development

**ID:** Microsoft.VisualStudio.Workload.Universal

**Description:** Create applications for the Universal Windows Platform with C#, VB, JavaScript, or optionally C﻿+﻿+.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.8.27825.0 | Required
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26208.0 | Required
Microsoft.ComponentGroup.Blend | Blend for Visual Studio | 15.6.27406.0 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 development tools | 15.8.27924.0 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.9.28125.51 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.TypeScript.3.1 | TypeScript 3.1 SDK | 15.0.28218.60 | Required
Microsoft.VisualStudio.Component.UWP.Support | Universal Windows Platform tools | 15.9.28119.51 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.Windows10SDK.17763 | Windows 10 SDK (10.0.17763.0) | 15.9.28307.102 | Required
Microsoft.VisualStudio.ComponentGroup.UWP.Cordova | Universal Windows Platform tools for Cordova | 15.9.28307.102 | Required
Microsoft.VisualStudio.ComponentGroup.UWP.NetCoreAndStandard | .NET Native and .NET Standard | 15.8.27906.1 | Required
Microsoft.VisualStudio.ComponentGroup.UWP.Xamarin | Universal Windows Platform tools for Xamarin | 15.9.28307.102 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Required
Microsoft.Component.VC.Runtime.OSSupport | Visual C++ runtime for UWP | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.2.SDK | .NET Framework 4.7.2 SDK | 15.8.27825.0 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Phone.Emulator.15254 | Windows 10 Mobile Emulator (Fall Creators Update) | 15.0.27406.0 | Optional
Microsoft.VisualStudio.Component.UWP.VC.ARM64 | C++ Universal Windows Platform tools for ARM64 | 15.0.28125.51 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM | Visual C++ compilers and libraries for ARM | 15.8.27825.0 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM64 | Visual C++ compilers and libraries for ARM64 | 15.9.28230.55 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 version 15.9 v14.16 latest v141 tools | 15.9.28230.55 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.Desktop | Windows 10 SDK (10.0.15063.0) for Desktop C++ [x86 and x64] | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP | Windows 10 SDK (10.0.15063.0) for UWP: C#, VB, JS | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP.Native | Windows 10 SDK (10.0.15063.0) for UWP: C++ | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop | Windows 10 SDK (10.0.16299.0) for Desktop C++ [x86 and x64] | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop.arm | Windows 10 SDK (10.0.16299.0) for Desktop C++ [ARM and ARM64] | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17134 | Windows 10 SDK (10.0.17134.0) | 15.9.28307.102 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.IpOverUsb | USB Device Connectivity | 15.9.28307.102 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.VC | C++ Universal Windows Platform tools | 15.9.28307.102 | Optional
Microsoft.VisualStudio.ComponentGroup.Windows10SDK.15063 | Windows 10 SDK (10.0.15063.0) | 15.8.27825.0 | Optional
Microsoft.VisualStudio.ComponentGroup.Windows10SDK.16299 | Windows 10 SDK (10.0.16299.0) | 15.8.27825.0 | Optional

## Visual Studio extension development

**ID:** Microsoft.VisualStudio.Workload.VisualStudioExtension

**Description:** Create add-ons and extensions for Visual Studio, including new commands, code analyzers and tool windows.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.8.27825.0 | Required
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.8.27825.0 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.9.28016.0 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.VSSDK | Visual Studio SDK | 15.8.27729.1 | Required
Microsoft.VisualStudio.ComponentGroup.VisualStudioExtension.Prerequisites | Visual Studio extension development prerequisites | 15.7.27625.0 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.8.27729.1 | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26208.0 | Recommended
Component.Dotfuscator | PreEmptive Protection - Dotfuscator | 15.0.26208.0 | Optional
Microsoft.Component.CodeAnalysis.SDK | .NET Compiler Platform SDK | 15.0.27729.1 | Optional
Microsoft.Component.VC.Runtime.OSSupport | Visual C++ runtime for UWP | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.8.27825.0 | Optional
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.DslTools | Modeling SDK | 15.0.27005.2 | Optional
Microsoft.VisualStudio.Component.VC.ATL | Visual C++ ATL for x86 and x64 | 15.7.27625.0 | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | Visual C++ MFC for x86 and x64 | 15.7.27625.0 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 version 15.9 v14.16 latest v141 tools | 15.9.28230.55 | Optional

## Mobile development with JavaScript

**ID:** Microsoft.VisualStudio.Workload.WebCrossPlat

**Description:** Build Android, iOS and UWP apps using Tools for Apache Cordova.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.CordovaToolset.6.3.1 | Cordova 6.3.1 toolset | 15.7.27625.0 | Required
Component.WebSocket | WebSocket4Net | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.Cordova | Mobile development with JavaScript core features | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.JavaScript.ProjectSystem | JavaScript ProjectSystem and Shared Tooling | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.9.28125.51 | Required
Microsoft.VisualStudio.Component.TypeScript.2.3 | TypeScript 2.3 SDK | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.TypeScript.3.1 | TypeScript 3.1 SDK | 15.0.28218.60 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.8.27825.0 | Required
Component.Android.SDK23.Private | Android SDK setup (API level 23) (local install for Mobile development with JavaScript / C++) | 15.9.28016.0 | Optional
Component.Google.Android.Emulator.API23.Private | Google Android Emulator (API Level 23) (local install) | 15.6.27413.0 | Optional
Component.HAXM.Private | Intel Hardware Accelerated Execution Manager (HAXM) (local install) | 15.9.28307.421 | Optional
Component.OpenJDK | Microsoft distribution OpenJDK | 15.9.28125.51 | Optional
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.8.27825.0 | Optional
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.8.27825.0 | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 15.8.27729.1 | Optional
Microsoft.VisualStudio.Component.Git | Git for Windows | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Phone.Emulator.15254 | Windows 10 Mobile Emulator (Fall Creators Update) | 15.0.27406.0 | Optional
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17763 | Windows 10 SDK (10.0.17763.0) | 15.9.28307.102 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.Cordova | Universal Windows Platform tools for Cordova | 15.9.28307.102 | Optional

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name | Version
--- | --- | ---
Component.Android.Emulator | Visual Studio Emulator for Android | 15.6.27413.0
Component.Android.NDK.R11C | Android NDK (R11C) | 11.3.14
Component.Android.NDK.R11C_3264 | Android NDK (R11C) (32bit) | 11.3.16
Component.Android.SDK23 | Android SDK setup (API level 23) (global install) | 15.9.28107.0
Component.Android.SDK25 | Android SDK setup (API level 25) | 15.9.28107.0
Component.GitHub.VisualStudio | GitHub extension for Visual Studio | 2.5.2.2500
Component.Google.Android.Emulator.API23.V2 | Google Android Emulator (API Level 23) (global install) | 15.6.27413.0
Component.Google.Android.Emulator.API25 | Google Android Emulator (API Level 25) | 15.7.27604.0
Microsoft.Component.Blend.SDK.WPF | Blend for Visual Studio SDK for .NET | 15.6.27406.0
Microsoft.Component.HelpViewer | Help Viewer | 15.9.28307.421
Microsoft.VisualStudio.Component.DependencyValidation.Community | Dependency Validation | 15.0.26208.0
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 15.0.27005.2
Microsoft.VisualStudio.Component.LinqToSql | LINQ to SQL tools | 15.6.27406.0
Microsoft.VisualStudio.Component.Phone.Emulator | Windows 10 Mobile Emulator (Anniversary Edition) | 15.6.27406.0
Microsoft.VisualStudio.Component.Phone.Emulator.15063 | Windows 10 Mobile Emulator (Creators Update) | 15.6.27406.0
Microsoft.VisualStudio.Component.Runtime.Node.x86.6.4.0 | Runtime for components based on Node.js v6.4.0 (x86) | 15.7.27617.1
Microsoft.VisualStudio.Component.Runtime.Node.x86.7.4.0 | Runtime for components based on Node.js v7.4.0 (x86) | 15.7.27617.1
Microsoft.VisualStudio.Component.TypeScript.2.0 | TypeScript 2.0 SDK | 15.8.27729.1
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | 15.8.27729.1
Microsoft.VisualStudio.Component.TypeScript.2.2 | TypeScript 2.2 SDK | 15.8.27729.1
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.6.27406.0
Microsoft.VisualStudio.Component.TypeScript.2.6 | TypeScript 2.6 SDK | 15.0.27729.1
Microsoft.VisualStudio.Component.TypeScript.2.7 | TypeScript 2.7 SDK | 15.0.27729.1
Microsoft.VisualStudio.Component.TypeScript.2.8 | TypeScript 2.8 SDK | 15.0.27729.1
Microsoft.VisualStudio.Component.TypeScript.2.9 | TypeScript 2.9 SDK | 15.0.27924.0
Microsoft.VisualStudio.Component.TypeScript.3.0 | TypeScript 3.0 SDK | 15.0.27924.0
Microsoft.VisualStudio.Component.VC.ATL.ARM | Visual C++ ATL for ARM | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.ATL.ARM.Spectre | Visual C++ ATL for ARM with Spectre Mitigations | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.ATL.ARM64 | Visual C++ ATL for ARM64 | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.ATL.ARM64.Spectre | Visual C++ ATL for ARM64 with Spectre Mitigations | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.ATL.Spectre | Visual C++ ATL (x86/x64) with Spectre Mitigations | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.ATLMFC.Spectre | Visual C++ MFC for x86/x64 with Spectre Mitigations | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.ClangC2 | Clang/C2 (experimental) | 15.7.27520.0
Microsoft.VisualStudio.Component.VC.MFC.ARM | Visual C++ MFC for ARM | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.MFC.ARM.Spectre | Visual C++ MFC for ARM with Spectre Mitigations | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.MFC.ARM64 | Visual C++ MFC for ARM64 | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.MFC.ARM64.Spectre | Visual C++ MFC support for ARM64 with Spectre Mitigations | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.Runtimes.ARM.Spectre | VC++ 2017 version 15.9 v14.16 Libs for Spectre (ARM) | 15.9.28230.55
Microsoft.VisualStudio.Component.VC.Runtimes.ARM64.Spectre | VC++ 2017 version 15.9 v14.16 Libs for Spectre (ARM64) | 15.9.28230.55
Microsoft.VisualStudio.Component.VC.Runtimes.x86.x64.Spectre | VC++ 2017 version 15.9 v14.16 Libs for Spectre (x86 and x64) | 15.9.28230.55
Microsoft.VisualStudio.Component.VC.Tools.14.11 | VC++ 2017 version 15.4 v14.11 toolset | 15.0.27924.0
Microsoft.VisualStudio.Component.VC.Tools.14.12 | VC++ 2017 version 15.5 v14.12 toolset | 15.0.27924.0
Microsoft.VisualStudio.Component.VC.Tools.14.13 | VC++ 2017 version 15.6 v14.13 toolset | 15.0.27924.0
Microsoft.VisualStudio.Component.VC.Tools.14.14 | VC++ 2017 version 15.7 v14.14 toolset | 15.0.27924.0
Microsoft.VisualStudio.Component.VC.Tools.14.15 | VC++ 2017 version 15.8 v14.15 toolset | 15.0.28230.55
