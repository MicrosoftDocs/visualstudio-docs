---
title: Visual Studio Professional 2019 workload and component IDs
titleSuffix: ""
description: "Use workload and component IDs to install Visual Studio by using the command line or to specify as a dependency in a VSIX manifest"
keywords:
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.date: 08/10/2021

ms.subservice: installation
ms.topic: include
---


## Visual Studio core editor (included with Visual Studio Professional 2019)

**ID:** Microsoft.VisualStudio.Workload.CoreEditor

**Description:** The Visual Studio core shell experience, including syntax-aware code editing, source code control and work item management.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.CoreEditor | Visual Studio core editor | 16.1.28811.260 | Required
Microsoft.VisualStudio.Component.StartPageExperiment.Cpp | Visual Studio Start Page for C++ Users | 16.0.28315.86 | Optional

## Azure development

**ID:** Microsoft.VisualStudio.Workload.Azure

**Description:** Azure SDKs, tools, and projects for developing cloud apps and creating resources using .NET and .NET Framework. Also includes tools for containerizing your application, including Docker support.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 16.10.31205.252 | Required
Component.Microsoft.VisualStudio.Web.AzureFunctions | Azure WebJobs Tools | 16.10.31205.252 | Required
Component.Microsoft.Web.LibraryManager | Library Manager | 16.10.31205.180 | Required
Component.Microsoft.WebTools.BrowserLink.WebLivePreview | Web Live Preview | 0.7.22.39845 | Required
Microsoft.Component.MSBuild | MSBuild | 16.11.33214.272 | Required
Microsoft.ComponentGroup.ClickOnce.Publish | ClickOnce Publishing for .NET  | 16.11.31603.221 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 16.0.28517.75 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 16.11.31605.320 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 16.0.28517.75 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 16.10.31205.252 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 16.3.29207.166 | Required
Microsoft.NetCore.Component.DevelopmentTools | .NET development tools | 16.11.33214.272 | Required
Microsoft.NetCore.Component.Web | .NET development tools | 16.11.33214.272 | Required
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 16.11.31827.77 | Required
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 16.11.31827.77 | Required
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 16.4.29313.120 | Required
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 16.4.29409.204 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 16.11.33214.272 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.FSharp.WebTemplates | F# language support for web projects | 16.3.29207.166 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 16.0.28517.75 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 16.11.31404.150 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 16.4.29318.151 | Required
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 16.0.28707.177 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 16.0.28517.75 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 16.3.29207.166 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.TypeScript.4.3 | TypeScript 4.3 SDK | 16.0.31506.151 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 16.10.31205.252 | Required
Microsoft.VisualStudio.ComponentGroup.Azure.Prerequisites | Azure development prerequisites | 16.10.31303.231 | Required
Microsoft.VisualStudio.ComponentGroup.AzureFunctions | Azure WebJobs Tools | 16.10.31205.180 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 16.10.31205.180 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 16.11.32413.511 | Required
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake and Stream Analytics Tools | 16.10.31205.252 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 16.11.31605.320 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 16.0.28517.75 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 16.11.31605.320 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 16.0.28516.191 | Recommended
Microsoft.VisualStudio.Component.AspNet45 | Advanced ASP.NET features | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.Azure.Kubernetes.Tools | Visual Studio Tools for Kubernetes | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.Azure.Powershell | Azure PowerShell | 16.5.29515.121 | Recommended
Microsoft.VisualStudio.Component.Azure.ResourceManager.Tools | Azure Resource Manager core tools | 16.4.29409.204 | Recommended
Microsoft.VisualStudio.Component.Azure.ServiceFabric.Tools | Service Fabric Tools | 16.4.29313.120 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton.BuildTools | Azure Cloud Services build tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.ComponentGroup.Azure.CloudServices | Azure Cloud Services tools | 16.10.31205.180 | Recommended
Microsoft.VisualStudio.ComponentGroup.Azure.ResourceManager.Tools | Azure Resource Manager tools | 16.0.28528.71 | Recommended
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 16.0.28517.75 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 16.10.31205.252 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 16.10.31205.252 | Optional
Microsoft.Net.Component.4.8.TargetingPack | .NET Framework 4.8 targeting pack | 16.4.29313.120 | Optional
Microsoft.Net.ComponentGroup.4.6.1.DeveloperTools | .NET Framework 4.6.1 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.8.DeveloperTools | .NET Framework 4.8 development tools | 16.4.29318.151 | Optional
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.Runtime.3.1 | .NET Core 3.1 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.Runtime.5.0 | .NET 5.0 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.SDK | .NET SDK (out of support) | 16.11.33214.272 | Optional
Microsoft.VisualStudio.Component.Azure.Storage.AzCopy | Azure Storage AzCopy | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 16.0.28625.61 | Optional

## Data storage and processing

**ID:** Microsoft.VisualStudio.Workload.Data

**Description:** Connect, develop, and test data solutions with SQL Server, Azure Data Lake, or Hadoop.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 16.10.31205.252 | Recommended
Component.Microsoft.Web.LibraryManager | Library Manager | 16.10.31205.180 | Recommended
Component.Microsoft.WebTools.BrowserLink.WebLivePreview | Web Live Preview | 0.7.22.39845 | Recommended
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake and Stream Analytics Tools | 16.10.31205.252 | Recommended
Microsoft.Component.MSBuild | MSBuild | 16.11.33214.272 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 16.11.31605.320 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 16.0.28517.75 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 16.11.31605.320 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 16.0.28517.75 | Recommended
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 16.10.31205.252 | Recommended
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 16.11.31605.320 | Recommended
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 16.3.29207.166 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 16.0.28516.191 | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 16.11.31827.77 | Recommended
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 16.0.28315.86 | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 16.11.31827.77 | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 16.4.29313.120 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton.BuildTools | Azure Cloud Services build tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 16.0.28625.61 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 16.4.29409.204 | Recommended
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 16.11.33214.272 | Recommended
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 16.0.28315.86 | Recommended
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 16.11.31404.150 | Recommended
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 16.4.29318.151 | Recommended
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 16.0.28625.61 | Recommended
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 16.0.28707.177 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 16.0.28315.86 | Recommended
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 16.0.28315.86 | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 16.0.28625.61 | Recommended
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 16.3.29207.166 | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 16.0.28625.61 | Recommended
Microsoft.VisualStudio.Component.TypeScript.4.3 | TypeScript 4.3 SDK | 16.0.31506.151 | Recommended
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 16.10.31205.180 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 16.11.32413.511 | Recommended
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 16.0.28315.86 | Optional

## Data science and analytical applications

**ID:** Microsoft.VisualStudio.Workload.DataScience

**Description:** Languages and tooling for creating data science applications, including Python and F#.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.PythonTools | Python language support | 16.11.31314.313 | Recommended
Microsoft.Component.PythonTools.Minicondax64 | Python miniconda (out of support) | 16.11.31314.313 | Recommended
Microsoft.Component.PythonTools.Web | Python web support | 16.10.31205.252 | Recommended
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 16.4.29409.204 | Recommended
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 16.0.28315.86 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 16.11.31404.150 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.TypeScript.4.3 | TypeScript 4.3 SDK | 16.0.31506.151 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 16.11.32413.511 | Recommended
Microsoft.ComponentGroup.PythonTools.NativeDevelopment | Python native development tools | 16.10.31205.180 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 16.0.28625.61 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 16.5.29515.121 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (Latest) | 16.11.32406.258 | Optional
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 16.4.29409.204 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.19041 | Windows 10 SDK (10.0.19041.0) | 16.10.31205.252 | Optional

## .NET desktop development

**ID:** Microsoft.VisualStudio.Workload.ManagedDesktop

**Description:** Build WPF, Windows Forms, and console applications using C#, Visual Basic, and F# with .NET and .NET Framework.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 16.11.33214.272 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 16.10.31205.252 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 16.3.29207.166 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 16.4.29318.151 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Prerequisites | .NET desktop development tools | 16.11.33214.272 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 16.0.28625.61 | Required
Component.Microsoft.VisualStudio.LiveShare | Live Share | 1.0.4441 | Recommended
Microsoft.ComponentGroup.Blend | Blend for Visual Studio | 16.0.28315.86 | Recommended
Microsoft.ComponentGroup.ClickOnce.Publish | ClickOnce Publishing for .NET  | 16.11.31603.221 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 16.11.31605.320 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 16.0.28517.75 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 16.11.31605.320 | Recommended
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 16.0.28517.75 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 16.0.28517.75 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 16.11.31605.320 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 16.0.28516.191 | Recommended
Microsoft.NetCore.Component.DevelopmentTools | .NET development tools | 16.11.33214.272 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 16.4.29409.204 | Recommended
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.DotNetModelBuilder | ML.NET Model Builder (Preview) | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | 16.0.28315.86 | Recommended
Microsoft.VisualStudio.Component.FSharp | F# language support | 16.0.28315.86 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 16.11.31404.150 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Recommended
Microsoft.VisualStudio.Component.TypeScript.4.3 | TypeScript 4.3 SDK | 16.0.31506.151 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 16.11.32413.511 | Recommended
Component.Dotfuscator | PreEmptive Protection - Dotfuscator | 16.10.31205.252 | Optional
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 16.10.31205.252 | Optional
Component.Microsoft.Web.LibraryManager | Library Manager | 16.10.31205.180 | Optional
Component.Microsoft.WebTools.BrowserLink.WebLivePreview | Web Live Preview | 0.7.22.39845 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 16.0.28517.75 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 16.10.31205.252 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 16.10.31205.252 | Optional
Microsoft.Net.Component.4.8.TargetingPack | .NET Framework 4.8 targeting pack | 16.4.29313.120 | Optional
Microsoft.Net.ComponentGroup.4.6.1.DeveloperTools | .NET Framework 4.6.1 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.8.DeveloperTools | .NET Framework 4.8 development tools | 16.4.29318.151 | Optional
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.Runtime.3.1 | .NET Core 3.1 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.Runtime.5.0 | .NET 5.0 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.SDK | .NET SDK (out of support) | 16.11.33214.272 | Optional
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 16.11.33214.272 | Optional
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 16.0.28315.86 | Optional
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 16.0.28315.86 | Optional
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 16.0.28625.61 | Optional
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 16.0.28707.177 | Optional
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 16.0.28315.86 | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 16.0.28625.61 | Optional
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 16.3.29207.166 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 16.0.28625.61 | Optional
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 16.10.31205.252 | Optional
Microsoft.VisualStudio.ComponentGroup.MSIX.Packaging | MSIX Packaging Tools | 16.10.31205.180 | Optional
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 16.10.31205.180 | Optional

## Game development with Unity

**ID:** Microsoft.VisualStudio.Workload.ManagedGame

**Description:** Create 2D and 3D games with Unity, a powerful cross-platform development environment.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Net.Component.3.5.DeveloperTools | .NET Framework 3.5 development tools | 16.0.28517.75 | Required
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.Unity | Visual Studio Tools for Unity | 16.0.28315.86 | Required
Component.UnityEngine.x64 | Unity Hub | 16.10.31205.252 | Recommended
Component.UnityEngine.x86 | Unity 5.6 32-bit Editor | 16.1.28811.260 | Recommended

## Linux development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeCrossPlat

**Description:** Create and debug applications running in a Linux environment.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.MDD.Linux | C++ for Linux Development | 16.5.29515.121 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 16.10.31205.252 | Required
Component.Linux.CMake | C++ CMake tools for Linux | 16.2.29003.222 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 16.11.32413.511 | Recommended
Component.MDD.Linux.GCC.arm | Embedded and IoT development tools | 16.5.29515.121 | Optional

## Desktop development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeDesktop

**Description:** Build modern C++ apps for Windows using tools of your choice, including MSVC, Clang, CMake, or MSBuild.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 16.11.33214.272 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.VC.Redist.14.Latest | C++ 2019 Redistributable Update | 16.5.29515.121 | Required
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Core | C++ core desktop features | 16.2.29012.281 | Required
Component.Microsoft.VisualStudio.LiveShare | Live Share | 1.0.4441 | Recommended
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 16.0.28625.61 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 16.11.31404.150 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.TypeScript.4.3 | TypeScript 4.3 SDK | 16.0.31506.151 | Recommended
Microsoft.VisualStudio.Component.VC.ASAN | C++ AddressSanitizer | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.VC.ATL | C++ ATL for latest v142 build tools (x86 & x64) | 16.4.29313.120 | Recommended
Microsoft.VisualStudio.Component.VC.CMake.Project | C++ CMake tools for Windows | 16.3.29103.31 | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 16.5.29515.121 | Recommended
Microsoft.VisualStudio.Component.VC.TestAdapterForBoostTest | Test Adapter for Boost.Test | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.VC.TestAdapterForGoogleTest | Test Adapter for Google Test | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (Latest) | 16.11.32406.258 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.19041 | Windows 10 SDK (10.0.19041.0) | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 16.11.32413.511 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions.CMake | JSON editor | 16.11.32413.511 | Recommended
Component.Incredibuild | Incredibuild - Build Acceleration | 16.10.31205.252 | Optional
Component.IncredibuildMenu | IncrediBuildMenu | 1.5.0.13 | Optional
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 16.0.28625.61 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 16.0.28517.75 | Optional
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Optional
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.VC.140 | MSVC v140 - VS 2015 C++ build tools (v14.00) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | C++ MFC for latest v142 build tools (x86 & x64) | 16.4.29313.120 | Optional
Microsoft.VisualStudio.Component.VC.CLI.Support | C++/CLI support for v142 build tools (Latest) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.VC.Llvm.Clang | C++ Clang Compiler for Windows (12.0.0) | 16.11.31603.221 | Optional
Microsoft.VisualStudio.Component.VC.Llvm.ClangToolset | C++ Clang-cl for v142 build tools (x64/x86) | 16.3.29207.166 | Optional
Microsoft.VisualStudio.Component.VC.Modules.x86.x64 | C++ Modules for v142 build tools (x64/x86 – experimental) | 16.0.28625.61 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (Latest) | 16.11.32406.258 | Optional
Microsoft.VisualStudio.Component.VC.v141.x86.x64 | MSVC v141 - VS 2017 C++ x64/x86 build tools (v14.16) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299 | Windows 10 SDK (10.0.16299.0) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17134 | Windows 10 SDK (10.0.17134.0) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17763 | Windows 10 SDK (10.0.17763.0) | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.18362 | Windows 10 SDK (10.0.18362.0) | 16.1.28829.92 | Optional
Microsoft.VisualStudio.Component.Windows11SDK.22000 | Windows 11 SDK (10.0.22000.0) | 16.11.31727.170 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Llvm.Clang | C++ Clang tools for Windows (12.0.0 - x64/x86) | 16.11.31603.221 | Optional

## Game development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeGame

**Description:** Use the full power of C++ to build professional games powered by DirectX, Unreal, or Cocos2d.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.VC.Redist.14.Latest | C++ 2019 Redistributable Update | 16.5.29515.121 | Required
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (Latest) | 16.11.32406.258 | Required
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 16.4.29409.204 | Required
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 16.0.28625.61 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Microsoft.VisualStudio.Component.VC.ASAN | C++ AddressSanitizer | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 16.5.29515.121 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.19041 | Windows 10 SDK (10.0.19041.0) | 16.10.31205.252 | Recommended
Component.Android.NDK.R16B | Android NDK (R16B) | 16.11.33423.256 | Optional
Component.Android.SDK25.Private | Android SDK setup (API level 25) (local install for Mobile development with C++) | 16.0.28625.61 | Optional
Component.Ant | Apache Ant (1.9.3) | 1.9.3.8 | Optional
Component.Cocos | Cocos | 16.0.28315.86 | Optional
Component.Incredibuild | Incredibuild - Build Acceleration | 16.10.31205.252 | Optional
Component.IncredibuildMenu | IncrediBuildMenu | 1.5.0.13 | Optional
Component.MDD.Android | C++ Android development tools | 16.0.28517.75 | Optional
Component.OpenJDK | OpenJDK (Adoptium distribution) | 16.11.31827.77 | Optional
Component.Unreal | Unreal Engine installer | 16.1.28810.153 | Optional
Component.Unreal.Android | Android IDE support for Unreal engine | 16.1.28810.153 | Optional
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 16.11.31605.320 | Optional
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 16.0.28517.75 | Optional
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 16.11.31605.320 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 16.0.28517.75 | Optional
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 16.0.28517.75 | Optional
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 16.10.31205.252 | Optional
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Optional
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 16.11.31605.320 | Optional
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 16.0.28516.191 | Optional
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 16.1.28829.92 | Optional
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Optional
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299 | Windows 10 SDK (10.0.16299.0) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17134 | Windows 10 SDK (10.0.17134.0) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17763 | Windows 10 SDK (10.0.17763.0) | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.18362 | Windows 10 SDK (10.0.18362.0) | 16.1.28829.92 | Optional
Microsoft.VisualStudio.Component.Windows11SDK.22000 | Windows 11 SDK (10.0.22000.0) | 16.11.31727.170 | Optional

## Mobile development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeMobile

**Description:** Build cross-platform applications for iOS, Android or Windows using C++.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Android.SDK25.Private | Android SDK setup (API level 25) (local install for Mobile development with C++) | 16.0.28625.61 | Required
Component.OpenJDK | OpenJDK (Adoptium distribution) | 16.11.31827.77 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 16.10.31205.252 | Required
Component.Android.NDK.R16B | Android NDK (R16B) | 16.11.33423.256 | Recommended
Component.Ant | Apache Ant (1.9.3) | 1.9.3.8 | Recommended
Component.MDD.Android | C++ Android development tools | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Component.Android.NDK.R16B_3264 | Android NDK (R16B) (32bit) | 16.11.33423.256 | Optional
Component.Google.Android.Emulator.API25.Private | Google Android Emulator (API Level 25) (local install) | 16.1.28810.153 | Optional
Component.HAXM.Private | Intel Hardware Accelerated Execution Manager (HAXM) (local install) | 16.0.28528.71 | Optional
Component.Incredibuild | Incredibuild - Build Acceleration | 16.10.31205.252 | Optional
Component.IncredibuildMenu | IncrediBuildMenu | 1.5.0.13 | Optional
Component.MDD.IOS | C++ iOS development tools | 16.0.28517.75 | Optional

## .NET cross-platform development (out of support)

**ID:** Microsoft.VisualStudio.Workload.NetCoreTools

**Description:** Build cross-platform applications using .NET, ASP.NET Core, HTML/JavaScript, and Containers including Docker support.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 16.10.31205.252 | Required
Component.Microsoft.Web.LibraryManager | Library Manager | 16.10.31205.180 | Required
Component.Microsoft.WebTools.BrowserLink.WebLivePreview | Web Live Preview | 0.7.22.39845 | Required
Microsoft.Component.MSBuild | MSBuild | 16.11.33214.272 | Required
Microsoft.ComponentGroup.ClickOnce.Publish | ClickOnce Publishing for .NET  | 16.11.31603.221 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 16.0.28517.75 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 16.11.31605.320 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 16.0.28517.75 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 16.10.31205.252 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 16.3.29207.166 | Required
Microsoft.NetCore.Component.DevelopmentTools | .NET development tools | 16.11.33214.272 | Required
Microsoft.NetCore.Component.Web | .NET development tools | 16.11.33214.272 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 16.4.29409.204 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 16.11.33214.272 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.FSharp.WebTemplates | F# language support for web projects | 16.3.29207.166 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 16.0.28517.75 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 16.11.31404.150 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 16.4.29318.151 | Required
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 16.0.28707.177 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 16.0.28517.75 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 16.3.29207.166 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.TypeScript.4.3 | TypeScript 4.3 SDK | 16.0.31506.151 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 16.10.31205.180 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 16.11.32413.511 | Required
Component.Microsoft.VisualStudio.LiveShare | Live Share | 1.0.4441 | Recommended
Component.Microsoft.VisualStudio.Web.AzureFunctions | Azure WebJobs Tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 16.5.29515.121 | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 16.11.31827.77 | Recommended
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 16.0.28315.86 | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 16.11.31827.77 | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 16.4.29313.120 | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 16.0.28625.61 | Recommended
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.DotNetModelBuilder | ML.NET Model Builder (Preview) | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.WslDebugging | .NET Debugging with WSL | 16.11.33214.272 | Recommended
Microsoft.VisualStudio.ComponentGroup.AzureFunctions | Azure WebJobs Tools | 16.10.31205.180 | Recommended
Microsoft.VisualStudio.ComponentGroup.Web.CloudTools | Cloud tools for web development | 16.10.31205.180 | Recommended
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.VisualStudio.ComponentGroup.IISDevelopment | Development time IIS support | 16.10.31205.180 | Optional
Microsoft.VisualStudio.ComponentGroup.MSIX.Packaging | MSIX Packaging Tools | 16.10.31205.180 | Optional

## Mobile development with .NET (out of support)

**ID:** Microsoft.VisualStudio.Workload.NetCrossPlat

**Description:** Build cross-platform applications for iOS, Android or Windows using Xamarin.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.OpenJDK | OpenJDK (Adoptium distribution) | 16.11.31827.77 | Required
Component.Xamarin | Xamarin | 16.10.31205.252 | Required
Component.Xamarin.RemotedSimulator | Xamarin Remoted Simulator | 16.11.32629.160 | Required
Microsoft.Component.MSBuild | MSBuild | 16.11.33214.272 | Required
Microsoft.ComponentGroup.ClickOnce.Publish | ClickOnce Publishing for .NET  | 16.11.31603.221 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 16.0.28517.75 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 16.10.31205.252 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 16.3.29207.166 | Required
Microsoft.NetCore.Component.DevelopmentTools | .NET development tools | 16.11.33214.272 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.Merq | Common Xamarin internal tools | 16.2.29012.281 | Required
Microsoft.VisualStudio.Component.MonoDebugger | Mono debugger | 16.0.28517.75 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions.TemplateEngine | ASP.NET templating engine | 16.11.32413.511 | Required
Component.Android.SDK30 | Android SDK setup (API level 30) | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended

## ASP.NET and web development

**ID:** Microsoft.VisualStudio.Workload.NetWeb

**Description:** Build web applications using ASP.NET Core, ASP.NET, HTML/JavaScript, and Containers including Docker support.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 16.10.31205.252 | Required
Component.Microsoft.Web.LibraryManager | Library Manager | 16.10.31205.180 | Required
Component.Microsoft.WebTools.BrowserLink.WebLivePreview | Web Live Preview | 0.7.22.39845 | Required
Microsoft.Component.MSBuild | MSBuild | 16.11.33214.272 | Required
Microsoft.ComponentGroup.ClickOnce.Publish | ClickOnce Publishing for .NET  | 16.11.31603.221 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 16.0.28517.75 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 16.11.31605.320 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 16.0.28517.75 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 16.10.31205.252 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 16.3.29207.166 | Required
Microsoft.NetCore.Component.DevelopmentTools | .NET development tools | 16.11.33214.272 | Required
Microsoft.NetCore.Component.Web | .NET development tools | 16.11.33214.272 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 16.4.29409.204 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 16.11.33214.272 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.FSharp.WebTemplates | F# language support for web projects | 16.3.29207.166 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 16.0.28517.75 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 16.11.31404.150 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 16.4.29318.151 | Required
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 16.0.28707.177 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 16.0.28517.75 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 16.3.29207.166 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.TypeScript.4.3 | TypeScript 4.3 SDK | 16.0.31506.151 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 16.10.31205.252 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 16.10.31205.180 | Required
Microsoft.VisualStudio.ComponentGroup.Web.Client | ASP.NET and web development tools | 16.10.31205.180 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 16.11.32413.511 | Required
Component.Microsoft.VisualStudio.LiveShare | Live Share | 1.0.4441 | Recommended
Component.Microsoft.VisualStudio.Web.AzureFunctions | Azure WebJobs Tools | 16.10.31205.252 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 16.11.31605.320 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 16.0.28517.75 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 16.11.31605.320 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 16.0.28516.191 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 16.5.29515.121 | Recommended
Microsoft.VisualStudio.Component.AspNet45 | Advanced ASP.NET features | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 16.11.31827.77 | Recommended
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 16.0.28315.86 | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 16.11.31827.77 | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 16.4.29313.120 | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 16.0.28625.61 | Recommended
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | 16.0.28315.86 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.WslDebugging | .NET Debugging with WSL | 16.11.33214.272 | Recommended
Microsoft.VisualStudio.ComponentGroup.AzureFunctions | Azure WebJobs Tools | 16.10.31205.180 | Recommended
Microsoft.VisualStudio.ComponentGroup.Web.CloudTools | Cloud tools for web development | 16.10.31205.180 | Recommended
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 16.0.28517.75 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 16.10.31205.252 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 16.10.31205.252 | Optional
Microsoft.Net.Component.4.8.TargetingPack | .NET Framework 4.8 targeting pack | 16.4.29313.120 | Optional
Microsoft.Net.ComponentGroup.4.6.1.DeveloperTools | .NET Framework 4.6.1 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.8.DeveloperTools | .NET Framework 4.8 development tools | 16.4.29318.151 | Optional
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.Runtime.3.1 | .NET Core 3.1 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.Runtime.5.0 | .NET 5.0 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.SDK | .NET SDK (out of support) | 16.11.33214.272 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 16.0.28625.61 | Optional
Microsoft.VisualStudio.ComponentGroup.AdditionalWebProjectTemplates | Additional project templates (previous versions) | 16.10.31205.180 | Optional
Microsoft.VisualStudio.ComponentGroup.IISDevelopment | Development time IIS support | 16.10.31205.180 | Optional

## Node.js development

**ID:** Microsoft.VisualStudio.Workload.Node

**Description:** Build scalable network applications using Node.js, an asynchronous event-driven JavaScript runtime. 

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 16.0.28517.75 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 16.11.31404.150 | Required
Microsoft.VisualStudio.Component.Node.Tools | Node.js development tools | 16.5.29515.121 | Required
Microsoft.VisualStudio.Component.TypeScript.4.3 | TypeScript 4.3 SDK | 16.0.31506.151 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 16.11.32413.511 | Required
Component.Microsoft.VisualStudio.LiveShare | Live Share | 1.0.4441 | Recommended
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 16.0.28517.75 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 16.5.29515.121 | Optional
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 16.4.29409.204 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (Latest) | 16.11.32406.258 | Optional

## Office/SharePoint development

**ID:** Microsoft.VisualStudio.Workload.Office

**Description:** Create Office and SharePoint add-ins, SharePoint solutions, and VSTO add-ins using C#, VB, and JavaScript.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 16.10.31205.252 | Required
Component.Microsoft.Web.LibraryManager | Library Manager | 16.10.31205.180 | Required
Component.Microsoft.WebTools.BrowserLink.WebLivePreview | Web Live Preview | 0.7.22.39845 | Required
Microsoft.Component.MSBuild | MSBuild | 16.11.33214.272 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 16.0.28517.75 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 16.11.31605.320 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 16.0.28517.75 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 16.10.31205.252 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Required
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 16.11.31605.320 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 16.3.29207.166 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 16.5.29515.121 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 16.4.29409.204 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 16.11.33214.272 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 16.0.28517.75 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 16.11.31404.150 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 16.4.29318.151 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Prerequisites | .NET desktop development tools | 16.11.33214.272 | Required
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 16.0.28707.177 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.Sharepoint.Tools | Office Developer Tools for Visual Studio | 16.4.29409.204 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 16.0.28517.75 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 16.3.29207.166 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.TypeScript.4.3 | TypeScript 4.3 SDK | 16.0.31506.151 | Required
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 16.0.28625.61 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.Workflow | Windows Workflow Foundation | 16.0.28315.86 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 16.10.31205.180 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 16.11.32413.511 | Required
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Microsoft.VisualStudio.Component.TeamOffice | Visual Studio Tools for Office (VSTO) | 16.4.29409.204 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 16.0.28517.75 | Recommended
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 16.0.28517.75 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 16.10.31205.252 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 16.10.31205.252 | Optional
Microsoft.Net.Component.4.8.TargetingPack | .NET Framework 4.8 targeting pack | 16.4.29313.120 | Optional
Microsoft.Net.ComponentGroup.4.6.1.DeveloperTools | .NET Framework 4.6.1 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 16.3.29207.166 | Optional
Microsoft.Net.ComponentGroup.4.8.DeveloperTools | .NET Framework 4.8 development tools | 16.4.29318.151 | Optional
Microsoft.NetCore.Component.Runtime.3.1 | .NET Core 3.1 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.Runtime.5.0 | .NET 5.0 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.SDK | .NET SDK (out of support) | 16.11.33214.272 | Optional
Microsoft.VisualStudio.ComponentGroup.Sharepoint.WIF | Windows Identity Foundation 3.5 | 16.0.28621.142 | Optional

## Python development

**ID:** Microsoft.VisualStudio.Workload.Python

**Description:** Editing, debugging, interactive development and source control for Python.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.PythonTools | Python language support | 16.11.31314.313 | Required
Component.CPython2.x64 | Python 2 64-bit (2.7.18) (out of support) | 2.7.18.2 | Optional
Component.CPython2.x86 | Python 2 32-bit (2.7.18) (out of support) | 2.7.18.2 | Optional
Component.CPython3.x64 | Python 3 64-bit (3.7.8)  (out of support) | 3.7.8.1 | Optional
Component.CPython3.x86 | Python 3 32-bit (3.7.8)  (out of support) | 3.7.8.1 | Optional
Component.CPython39.x64 | Python 3 64-bit (3.9.13) | 3.9.13 | Optional
Component.CPython39.x86 | Python 3 32-bit (3.9.13) | 3.9.13 | Optional
Component.Microsoft.VisualStudio.LiveShare | Live Share | 1.0.4441 | Optional
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 16.10.31205.252 | Optional
Component.Microsoft.Web.LibraryManager | Library Manager | 16.10.31205.180 | Optional
Component.Microsoft.WebTools.BrowserLink.WebLivePreview | Web Live Preview | 0.7.22.39845 | Optional
Microsoft.Component.IronPython | IronPython (out of support) | 16.10.31303.231 | Optional
Microsoft.Component.MSBuild | MSBuild | 16.11.33214.272 | Optional
Microsoft.Component.PythonTools.Minicondax64 | Python miniconda (out of support) | 16.11.31314.313 | Optional
Microsoft.Component.PythonTools.Web | Python web support | 16.10.31205.252 | Optional
Microsoft.ComponentGroup.PythonTools.NativeDevelopment | Python native development tools | 16.10.31205.180 | Optional
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 16.0.28517.75 | Optional
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 16.11.31605.320 | Optional
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 16.10.31205.252 | Optional
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Optional
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 16.3.29207.166 | Optional
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 16.11.31827.77 | Optional
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 16.0.28315.86 | Optional
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 16.11.31827.77 | Optional
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 16.4.29313.120 | Optional
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Azure.Waverton.BuildTools | Azure Cloud Services build tools | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 16.4.29409.204 | Optional
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 16.11.33214.272 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 16.0.28625.61 | Optional
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 16.0.28315.86 | Optional
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 16.11.31404.150 | Optional
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 16.4.29318.151 | Optional
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 16.0.28625.61 | Optional
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 16.0.28707.177 | Optional
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Optional
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Optional
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 16.0.28315.86 | Optional
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 16.0.28315.86 | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 16.0.28625.61 | Optional
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 16.3.29207.166 | Optional
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 16.0.28625.61 | Optional
Microsoft.VisualStudio.Component.TypeScript.4.3 | TypeScript 4.3 SDK | 16.0.31506.151 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 16.5.29515.121 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (Latest) | 16.11.32406.258 | Optional
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 16.4.29409.204 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.19041 | Windows 10 SDK (10.0.19041.0) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development tools prerequisites | 16.10.31205.180 | Optional
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 16.11.32413.511 | Optional

## Universal Windows Platform development

**ID:** Microsoft.VisualStudio.Workload.Universal

**Description:** Create applications for the Universal Windows Platform with C#, VB, or optionally C﻿+﻿+.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.NetFX.Native | .NET Native | 16.5.29515.121 | Required
Microsoft.ComponentGroup.Blend | Blend for Visual Studio | 16.0.28315.86 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 16.11.31605.320 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 16.5.29515.121 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 16.0.28315.86 | Required
Microsoft.VisualStudio.Component.Windows10SDK.19041 | Windows 10 SDK (10.0.19041.0) | 16.10.31205.252 | Required
Microsoft.VisualStudio.ComponentGroup.MSIX.Packaging | MSIX Packaging Tools | 16.10.31205.180 | Required
Microsoft.VisualStudio.ComponentGroup.UWP.NetCoreAndStandard | .NET Native and .NET Standard | 16.11.33214.272 | Required
Microsoft.VisualStudio.ComponentGroup.UWP.Support | Universal Windows Platform tools | 16.11.33214.272 | Required
Microsoft.VisualStudio.ComponentGroup.UWP.Xamarin | Universal Windows Platform tools for Xamarin | 16.10.31205.180 | Required
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Optional
Microsoft.NetCore.Component.Runtime.3.1 | .NET Core 3.1 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.Runtime.5.0 | .NET 5.0 Runtime (Out of support) | 16.11.33214.272 | Optional
Microsoft.NetCore.Component.SDK | .NET SDK (out of support) | 16.11.33214.272 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 16.0.28625.61 | Optional
Microsoft.VisualStudio.Component.UWP.VC.ARM64 | C++ Universal Windows Platform support for v142 build tools (ARM64) | 16.3.29207.166 | Optional
Microsoft.VisualStudio.Component.UWP.VC.ARM64EC | C++ Universal Windows Platform support for v142 build tools (ARM64EC – experimental) | 16.10.31303.231 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM | MSVC v142 - VS 2019 C++ ARM build tools (Latest) | 16.11.32406.258 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (Latest) | 16.11.32406.258 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM64EC | MSVC v142 - VS 2019 C++ ARM64EC build tools (Latest – experimental) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (Latest) | 16.11.32406.258 | Optional
Microsoft.VisualStudio.Component.VC.v141.ARM | MSVC v141 - VS 2017 C++ ARM build tools (v14.16) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.VC.v141.ARM64 | MSVC v141 - VS 2017 C++ ARM64 build tools (v14.16) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.VC.v141.x86.x64 | MSVC v141 - VS 2017 C++ x64/x86 build tools (v14.16) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299 | Windows 10 SDK (10.0.16299.0) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17134 | Windows 10 SDK (10.0.17134.0) | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.17763 | Windows 10 SDK (10.0.17763.0) | 16.0.28517.75 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.18362 | Windows 10 SDK (10.0.18362.0) | 16.1.28829.92 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.IpOverUsb | USB Device Connectivity | 16.10.31205.252 | Optional
Microsoft.VisualStudio.Component.Windows11SDK.22000 | Windows 11 SDK (10.0.22000.0) | 16.11.31727.170 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.VC | C++ (v142) Universal Windows Platform tools | 16.10.31205.180 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.VC.v141 | C++ (v141) Universal Windows Platform tools | 16.1.28810.153 | Optional

## Visual Studio extension development

**ID:** Microsoft.VisualStudio.Workload.VisualStudioExtension

**Description:** Create add-ons and extensions for Visual Studio, including new commands, code analyzers and tool windows.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 16.11.33214.272 | Required
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 16.0.28517.75 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 16.10.31205.252 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 16.4.29313.120 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 16.3.29207.166 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 16.1.28829.92 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 16.0.28714.129 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 16.10.31205.252 | Required
Microsoft.VisualStudio.Component.VSSDK | Visual Studio SDK | 16.0.28315.86 | Required
Microsoft.VisualStudio.ComponentGroup.VisualStudioExtension.Prerequisites | Visual Studio extension development prerequisites | 16.10.31205.180 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 16.10.31205.252 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 16.11.31603.221 | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 16.0.28625.61 | Recommended
Microsoft.Component.CodeAnalysis.SDK | .NET Compiler Platform SDK | 16.2.29003.222 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 16.5.29515.121 | Optional
Microsoft.VisualStudio.Component.DslTools | Modeling SDK | 16.0.28315.86 | Optional

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name | Version
--- | --- | ---
Component.GitHub.VisualStudio | GitHub extension for Visual Studio | 2.5.9.5485
Component.Xamarin.Profiler | Xamarin Profiler | 16.0.28315.86
Microsoft.Component.ClickOnce | ClickOnce Publishing | 16.11.31603.221
Microsoft.Component.HelpViewer | Help Viewer | 16.0.28625.61
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 16.4.29409.204
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 16.4.29409.204
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 16.4.29409.204
Microsoft.Net.Component.4.7.2.SDK | .NET Framework 4.7.2 SDK | 16.4.29409.204
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 16.4.29409.204
Microsoft.Net.Core.Component.SDK.2.2 | .NET Core 2.2 Runtime (Out of support) | 16.11.33027.164
Microsoft.Net.Core.Component.SDK.3.0 | .NET Core 3.0 Runtime (Out of support) | 16.11.33214.272
Microsoft.NetCore.ComponentGroup.DevelopmentTools.2.1 | Development Tools plus .NET Core 2.1 (Out of support) | 16.11.33027.164
Microsoft.NetCore.ComponentGroup.Web.2.1 | Web Development Tools plus .NET Core 2.1 (Out of support) | 16.11.33027.164
Microsoft.VisualStudio.Component.AzureDevOps.OfficeIntegration | Azure DevOps Office Integration | 16.0.28625.61
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | 16.0.28528.71
Microsoft.VisualStudio.Component.DependencyValidation.Community | Dependency Validation | 16.0.28517.75
Microsoft.VisualStudio.Component.Git | Git for Windows | 16.0.28625.61
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 16.0.28625.61
Microsoft.VisualStudio.Component.LinqToSql | LINQ to SQL tools | 16.0.28625.61
Microsoft.VisualStudio.Component.VC.14.20.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.20) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.20.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.20) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.20.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.20) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.20.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.20) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.20.ATL | C++ v14.20 ATL for v142 build tools (x86 & x64) | 16.1.28829.92
Microsoft.VisualStudio.Component.VC.14.20.ATL.ARM | C++ v14.20 ATL for v142 build tools (ARM) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.20.ATL.ARM.Spectre | C++ v14.20 ATL for v142 build tools with Spectre Mitigations (ARM) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.20.ATL.ARM64 | C++ v14.20 ATL for v142 build tools (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.20.ATL.ARM64.Spectre | C++ v14.20 ATL for v142 build tools with Spectre Mitigations (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.20.ATL.Spectre | C++ v14.20 ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.20.CLI.Support | C++/CLI support for v142 build tools (14.20) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.20.MFC | C++ v14.20 MFC for v142 build tools (x86 & x64) | 16.2.29003.222
Microsoft.VisualStudio.Component.VC.14.20.MFC.ARM | C++ v14.20 MFC for v142 build tools (ARM) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.20.MFC.ARM.Spectre | C++ v14.20 MFC for v142 build tools with Spectre Mitigations (ARM) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.20.MFC.ARM64 | C++ v14.20 MFC for v142 build tools (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.20.MFC.ARM64.Spectre | C++ v14.20 MFC for v142 build tools with Spectre Mitigations (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.20.MFC.Spectre | C++ v14.20 MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.20.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.20) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.20.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.20) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.21.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.21) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.21.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.21) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.21.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.21) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.21.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.21) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.21.ATL | C++ v14.21 ATL for v142 build tools (x86 & x64) | 16.2.29019.55
Microsoft.VisualStudio.Component.VC.14.21.ATL.ARM | C++ v14.21 ATL for v142 build tools (ARM) | 16.2.29019.55
Microsoft.VisualStudio.Component.VC.14.21.ATL.ARM.Spectre | C++ v14.21 ATL for v142 build tools with Spectre Mitigations (ARM) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.21.ATL.ARM64 | C++ v14.21 ATL for v142 build tools (ARM64) | 16.2.29019.55
Microsoft.VisualStudio.Component.VC.14.21.ATL.ARM64.Spectre | C++ v14.21 ATL for v142 build tools with Spectre Mitigations (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.21.ATL.Spectre | C++ v14.21 ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.21.CLI.Support | C++/CLI support for v142 build tools (14.21) | 16.3.29207.166
Microsoft.VisualStudio.Component.VC.14.21.MFC | C++ v14.21 MFC for v142 build tools (x86 & x64) | 16.2.29019.55
Microsoft.VisualStudio.Component.VC.14.21.MFC.ARM | C++ v14.21 MFC for v142 build tools (ARM) | 16.2.29019.55
Microsoft.VisualStudio.Component.VC.14.21.MFC.ARM.Spectre | C++ v14.21 MFC for v142 build tools with Spectre Mitigations (ARM) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.21.MFC.ARM64 | C++ v14.21 MFC for v142 build tools (ARM64) | 16.2.29019.55
Microsoft.VisualStudio.Component.VC.14.21.MFC.ARM64.Spectre | C++ v14.21 MFC for v142 build tools with Spectre Mitigations (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.21.MFC.Spectre | C++ v14.21 MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.21.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.21) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.21.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.21) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.22.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.22) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.22.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.22) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.22.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.22) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.22.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.22) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.22.ATL | C++ v14.22 ATL for v142 build tools (x86 & x64) | 16.4.29313.120
Microsoft.VisualStudio.Component.VC.14.22.ATL.ARM | C++ v14.22 ATL for v142 build tools (ARM) | 16.4.29313.120
Microsoft.VisualStudio.Component.VC.14.22.ATL.ARM.Spectre | C++ v14.22 ATL for v142 build tools with Spectre Mitigations (ARM) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.22.ATL.ARM64 | C++ v14.22 ATL for v142 build tools (ARM64) | 16.4.29313.120
Microsoft.VisualStudio.Component.VC.14.22.ATL.ARM64.Spectre | C++ v14.22 ATL for v142 build tools with Spectre Mitigations (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.22.ATL.Spectre | C++ v14.22 ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.22.CLI.Support | C++/CLI support for v142 build tools (14.22) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.22.MFC | C++ v14.22 MFC for v142 build tools (x86 & x64) | 16.4.29313.120
Microsoft.VisualStudio.Component.VC.14.22.MFC.ARM | C++ v14.22 MFC for v142 build tools (ARM) | 16.4.29313.120
Microsoft.VisualStudio.Component.VC.14.22.MFC.ARM.Spectre | C++ v14.22 MFC for v142 build tools with Spectre Mitigations (ARM) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.22.MFC.ARM64 | C++ v14.22 MFC for v142 build tools (ARM64) | 16.4.29313.120
Microsoft.VisualStudio.Component.VC.14.22.MFC.ARM64.Spectre | C++ v14.22 MFC for v142 build tools with Spectre Mitigations (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.22.MFC.Spectre | C++ v14.22 MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.22.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.22) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.22.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.22) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.23) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.23.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.23) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.23) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.23.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.23) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.ATL | C++ v14.23 ATL for v142 build tools (x86 & x64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.ATL.ARM | C++ v14.23 ATL for v142 build tools (ARM) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.ATL.ARM.Spectre | C++ v14.23 ATL for v142 build tools with Spectre Mitigations (ARM) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.23.ATL.ARM64 | C++ v14.23 ATL for v142 build tools (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.ATL.ARM64.Spectre | C++ v14.23 ATL for v142 build tools with Spectre Mitigations (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.ATL.Spectre | C++ v14.23 ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.CLI.Support | C++/CLI support for v142 build tools (14.23) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.23.MFC | C++ v14.23 MFC for v142 build tools (x86 & x64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.MFC.ARM | C++ v14.23 MFC for v142 build tools (ARM) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.MFC.ARM.Spectre | C++ v14.23 MFC for v142 build tools with Spectre Mitigations (ARM) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.MFC.ARM64 | C++ v14.23 MFC for v142 build tools (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.MFC.ARM64.Spectre | C++ v14.23 MFC for v142 build tools with Spectre Mitigations (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.MFC.Spectre | C++ v14.23 MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.23.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.23) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.23.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.23) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.14.24.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.24) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.24.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.24) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.24.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.24) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.24.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.24) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.24.ATL | C++ v14.24 ATL for v142 build tools (x86 & x64) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.24.ATL.ARM | C++ v14.24 ATL for v142 build tools (ARM) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.24.ATL.ARM.Spectre | C++ v14.24 ATL for v142 build tools with Spectre Mitigations (ARM) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.24.ATL.ARM64 | C++ v14.24 ATL for v142 build tools (ARM64) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.24.ATL.ARM64.Spectre | C++ v14.24 ATL for v142 build tools with Spectre Mitigations (ARM64) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.24.ATL.Spectre | C++ v14.24 ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.24.CLI.Support | C++/CLI support for v142 build tools (14.24) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.24.MFC | C++ v14.24 MFC for v142 build tools (x86 & x64) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.24.MFC.ARM | C++ v14.24 MFC for v142 build tools (ARM) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.24.MFC.ARM.Spectre | C++ v14.24 MFC for v142 build tools with Spectre Mitigations (ARM) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.24.MFC.ARM64 | C++ v14.24 MFC for v142 build tools (ARM64) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.24.MFC.ARM64.Spectre | C++ v14.24 MFC for v142 build tools with Spectre Mitigations (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.24.MFC.Spectre | C++ v14.24 MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.24.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.24) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.24.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.24) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.14.25.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.25) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.25.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.25) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.25) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.25.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.25) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.ATL | C++ v14.25 ATL for v142 build tools (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.ATL.ARM | C++ v14.25 ATL for v142 build tools (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.ATL.ARM.Spectre | C++ v14.25 ATL for v142 build tools with Spectre Mitigations (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.ATL.ARM64 | C++ v14.25 ATL for v142 build tools (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.ATL.ARM64.Spectre | C++ v14.25 ATL for v142 build tools with Spectre Mitigations (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.ATL.Spectre | C++ v14.25 ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.CLI.Support | C++/CLI support for v142 build tools (14.25) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.MFC | C++ v14.25 MFC for v142 build tools (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.MFC.ARM | C++ v14.25 MFC for v142 build tools (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.MFC.ARM.Spectre | C++ v14.25 MFC for v142 build tools with Spectre Mitigations (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.MFC.ARM64 | C++ v14.25 MFC for v142 build tools (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.MFC.ARM64.Spectre | C++ v14.25 MFC for v142 build tools with Spectre Mitigations (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.MFC.Spectre | C++ v14.25 MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.25.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.25) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.25.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.25) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.26) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.26.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.26) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.26) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.26.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.26) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.ATL | C++ v14.26 ATL for v142 build tools (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.ATL.ARM | C++ v14.26 ATL for v142 build tools (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.ATL.ARM.Spectre | C++ v14.26 ATL for v142 build tools with Spectre Mitigations (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.ATL.ARM64 | C++ v14.26 ATL for v142 build tools (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.ATL.ARM64.Spectre | C++ v14.26 ATL for v142 build tools with Spectre Mitigations (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.ATL.Spectre | C++ v14.26 ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.CLI.Support | C++/CLI support for v142 build tools (14.26) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.MFC | C++ v14.26 MFC for v142 build tools (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.MFC.ARM | C++ v14.26 MFC for v142 build tools (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.MFC.ARM.Spectre | C++ v14.26 MFC for v142 build tools with Spectre Mitigations (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.MFC.ARM64 | C++ v14.26 MFC for v142 build tools (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.MFC.ARM64.Spectre | C++ v14.26 MFC for v142 build tools with Spectre Mitigations (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.MFC.Spectre | C++ v14.26 MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.26.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.26) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.26.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.26) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.27) | 16.11.33328.57
Microsoft.VisualStudio.Component.VC.14.27.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.27) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.27) | 16.11.33328.57
Microsoft.VisualStudio.Component.VC.14.27.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.27) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.ATL | C++ v14.27 ATL for v142 build tools (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.ATL.ARM | C++ v14.27 ATL for v142 build tools (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.ATL.ARM.Spectre | C++ v14.27 ATL for v142 build tools with Spectre Mitigations (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.ATL.ARM64 | C++ v14.27 ATL for v142 build tools (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.ATL.ARM64.Spectre | C++ v14.27 ATL for v142 build tools with Spectre Mitigations (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.ATL.Spectre | C++ v14.27 ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.CLI.Support | C++/CLI support for v142 build tools (14.27) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.MFC | C++ v14.27 MFC for v142 build tools (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.MFC.ARM | C++ v14.27 MFC for v142 build tools (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.MFC.ARM.Spectre | C++ v14.27 MFC for v142 build tools with Spectre Mitigations (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.MFC.ARM64 | C++ v14.27 MFC for v142 build tools (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.MFC.ARM64.Spectre | C++ v14.27 MFC for v142 build tools with Spectre Mitigations (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.MFC.Spectre | C++ v14.27 MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.27.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.27) | 16.11.33328.57
Microsoft.VisualStudio.Component.VC.14.27.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.27) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.16.9.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.28-16.9) | 16.11.33328.57
Microsoft.VisualStudio.Component.VC.14.28.16.9.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.28-16.9) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.28-16.9) | 16.11.33328.57
Microsoft.VisualStudio.Component.VC.14.28.16.9.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.28-16.9) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.ATL | C++ v14.28 (16.9) ATL for v142 build tools (x86 & x64) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.ATL.ARM | C++ v14.28 (16.9) ATL for v142 build tools (ARM) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.ATL.ARM.Spectre | C++ v14.28 (16.9) ATL for v142 build tools with Spectre Mitigations (ARM) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.ATL.ARM64 | C++ v14.28 (16.9) ATL for v142 build tools (ARM64) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.ATL.ARM64.Spectre | C++ v14.28 (16.9) ATL for v142 build tools with Spectre Mitigations (ARM64) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.ATL.Spectre | C++ v14.28 (16.9) ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.CLI.Support | C++/CLI support for v142 build tools (14.28-16.9) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.MFC | C++ v14.28 (16.9) MFC for v142 build tools (x86 & x64) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.MFC.ARM | C++ v14.28 (16.9) MFC for v142 build tools (ARM) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.MFC.ARM.Spectre | C++ v14.28 (16.9) MFC for v142 build tools with Spectre Mitigations (ARM) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.MFC.ARM64 | C++ v14.28 (16.9) MFC for v142 build tools (ARM64) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.MFC.ARM64.Spectre | C++ v14.28 (16.9) MFC for v142 build tools with Spectre Mitigations (ARM64) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.MFC.Spectre | C++ v14.28 (16.9) MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.16.9.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.28-16.9) | 16.11.33328.57
Microsoft.VisualStudio.Component.VC.14.28.16.9.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.28-16.9) | 16.10.31303.231
Microsoft.VisualStudio.Component.VC.14.28.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.28-16.8) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.28.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.28-16.8) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.28-16.8) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.28.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.28-16.8) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.ATL | C++ v14.28 (16.8) ATL for v142 build tools (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.ATL.ARM | C++ v14.28 (16.8) ATL for v142 build tools (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.ATL.ARM.Spectre | C++ v14.28 (16.8) ATL for v142 build tools with Spectre Mitigations (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.ATL.ARM64 | C++ v14.28 (16.8) ATL for v142 build tools (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.ATL.ARM64.Spectre | C++ v14.28 (16.8) ATL for v142 build tools with Spectre Mitigations (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.ATL.Spectre | C++ v14.28 (16.8) ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.CLI.Support | C++/CLI support for v142 build tools (14.28-16.8) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.MFC | C++ v14.28 (16.8) MFC for v142 build tools (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.MFC.ARM | C++ v14.28 (16.8) MFC for v142 build tools (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.MFC.ARM.Spectre | C++ v14.28 (16.8) MFC for v142 build tools with Spectre Mitigations (ARM) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.MFC.ARM64 | C++ v14.28 (16.8) MFC for v142 build tools (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.MFC.ARM64.Spectre | C++ v14.28 (16.8) MFC for v142 build tools with Spectre Mitigations (ARM64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.MFC.Spectre | C++ v14.28 (16.8) MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.28.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.28-16.8) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.28.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.28-16.8) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.14.29.16.10.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.29-16.10) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.29.16.10.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.29-16.10) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.29-16.10) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.29.16.10.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.29-16.10) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.ATL | C++ v14.29 (16.10) ATL for v142 build tools (x86 & x64) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.ATL.ARM | C++ v14.29 (16.10) ATL for v142 build tools (ARM) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.ATL.ARM.Spectre | C++ v14.29 (16.10) ATL for v142 build tools with Spectre Mitigations (ARM) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.ATL.ARM64 | C++ v14.29 (16.10) ATL for v142 build tools (ARM64) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.ATL.ARM64.Spectre | C++ v14.29 (16.10) ATL for v142 build tools with Spectre Mitigations (ARM64) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.ATL.Spectre | C++ v14.29 (16.10) ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.CLI.Support | C++/CLI support for v142 build tools (14.29-16.10) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.MFC | C++ v14.29 (16.10) MFC for v142 build tools (x86 & x64) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.MFC.ARM | C++ v14.29 (16.10) MFC for v142 build tools (ARM) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.MFC.ARM.Spectre | C++ v14.29 (16.10) MFC for v142 build tools with Spectre Mitigations (ARM) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.MFC.ARM64 | C++ v14.29 (16.10) MFC for v142 build tools (ARM64) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.MFC.ARM64.Spectre | C++ v14.29 (16.10) MFC for v142 build tools with Spectre Mitigations (ARM64) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.MFC.Spectre | C++ v14.29 (16.10) MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.14.29.16.10.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.29-16.10) | 16.11.32428.96
Microsoft.VisualStudio.Component.VC.14.29.16.10.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.29-16.10) | 16.11.31314.313
Microsoft.VisualStudio.Component.VC.ATL.ARM | C++ ATL for latest v142 build tools (ARM) | 16.4.29313.120
Microsoft.VisualStudio.Component.VC.ATL.ARM.Spectre | C++ ATL for latest v142 build tools with Spectre Mitigations (ARM) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.ATL.ARM64 | C++ ATL for latest v142 build tools (ARM64) | 16.4.29313.120
Microsoft.VisualStudio.Component.VC.ATL.ARM64.Spectre | C++ ATL for latest v142 build tools with Spectre Mitigations (ARM64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.ATL.ARM64EC | C++ ATL for latest v142 build tools (ARM64EC - experimental) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.ATL.ARM64EC.Spectre | C++ ATL for latest v142 build tools with Spectre Mitigations (ARM64EC - experimental) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.ATL.Spectre | C++ ATL for latest v142 build tools with Spectre Mitigations (x86 & x64) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.ATLMFC.Spectre | C++ MFC for latest v142 build tools with Spectre Mitigations (x86 & x64) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.MFC.ARM | C++ MFC for latest v142 build tools (ARM) | 16.4.29313.120
Microsoft.VisualStudio.Component.VC.MFC.ARM.Spectre | C++ MFC for latest v142 build tools with Spectre Mitigations (ARM) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.MFC.ARM64 | C++ MFC for latest v142 build tools (ARM64) | 16.4.29313.120
Microsoft.VisualStudio.Component.VC.MFC.ARM64.Spectre | C++ MFC for latest v142 build tools with Spectre Mitigations (ARM64) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.MFC.ARM64EC | C++ MFC for latest v142 build tools (ARM64EC - experimental) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.MFC.ARM64EC.Spectre | C++ MFC for latest v142 build tools with Spectre Mitigations (ARM64EC - experimental) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.Redist.MSM | C++ 2019 Redistributable MSMs | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.Runtimes.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (Latest) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.Runtimes.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (Latest) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.Runtimes.ARM64EC.Spectre | MSVC v142 - VS 2019 C++ ARM64EC Spectre-mitigated libs (Latest - experimental) | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.Runtimes.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (Latest)  | 16.10.31205.252
Microsoft.VisualStudio.Component.VC.v141.ARM.Spectre | MSVC v141 - VS 2017 C++ ARM Spectre-mitigated libs (v14.16) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.v141.ARM64.Spectre | MSVC v141 - VS 2017 C++ ARM64 Spectre-mitigated libs (v14.16) | 16.5.29515.121
Microsoft.VisualStudio.Component.VC.v141.ATL | C++ ATL for v141 build tools (x86 & x64) | 16.0.28625.61
Microsoft.VisualStudio.Component.VC.v141.ATL.ARM | C++ ATL for v141 build tools (ARM) | 16.0.28625.61
Microsoft.VisualStudio.Component.VC.v141.ATL.ARM.Spectre | C++ ATL for v141 build tools with Spectre Mitigations (ARM) | 16.5.29721.120
Microsoft.VisualStudio.Component.VC.v141.ATL.ARM64 | C++ ATL for v141 build tools (ARM64) | 16.0.28625.61
Microsoft.VisualStudio.Component.VC.v141.ATL.ARM64.Spectre | C++ ATL for v141 build tools with Spectre Mitigations (ARM64) | 16.0.28625.61
Microsoft.VisualStudio.Component.VC.v141.ATL.Spectre | C++ ATL for v141 build tools with Spectre Mitigations (x86 & x64) | 16.0.28625.61
Microsoft.VisualStudio.Component.VC.v141.CLI.Support | C++/CLI support for v141 build tools (14.16) | 16.3.29207.166
Microsoft.VisualStudio.Component.VC.v141.MFC | C++ MFC for v141 build tools (x86 & x64) | 16.0.28625.61
Microsoft.VisualStudio.Component.VC.v141.MFC.ARM | C++ MFC for v141 build tools (ARM) | 16.2.28915.88
Microsoft.VisualStudio.Component.VC.v141.MFC.ARM.Spectre | C++ MFC for v141 build tools with Spectre Mitigations (ARM) | 16.0.28625.61
Microsoft.VisualStudio.Component.VC.v141.MFC.ARM64 | C++ MFC for v141 build tools (ARM64) | 16.0.28625.61
Microsoft.VisualStudio.Component.VC.v141.MFC.ARM64.Spectre | C++ MFC for v141 build tools with Spectre Mitigations (ARM64) | 16.0.28625.61
Microsoft.VisualStudio.Component.VC.v141.MFC.Spectre | C++ MFC for v141 build tools with Spectre Mitigations (x86 & x64) | 16.0.28625.61
Microsoft.VisualStudio.Component.VC.v141.x86.x64.Spectre | MSVC v141 - VS 2017 C++ x64/x86 Spectre-mitigated libs (v14.16) | 16.5.29515.121
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 16.0.28707.177
Microsoft.VisualStudio.Component.Windows10SDK.20348 | Windows 10 SDK (10.0.20348.0) | 16.11.31603.221
Microsoft.VisualStudio.Component.WinXP | C++ Windows XP Support for VS 2017 (v141) tools [Deprecated] | 16.10.31205.252
Microsoft.VisualStudio.Web.Mvc4.ComponentGroup | ASP.NET MVC 4 | 16.10.31205.180
