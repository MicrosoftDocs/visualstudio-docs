---
title: Visual Studio Enterprise 2026 workload and component IDs
titleSuffix: ""
description: "Use workload and component IDs to install Visual Studio by using the command line or to specify as a dependency in a VSIX manifest"
keywords:
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.date: 11/11/2025
ms.subservice: installation
ms.topic: include
---
## Visual Studio core editor (included with Visual Studio Enterprise 2026)

**ID:** Microsoft.VisualStudio.Workload.CoreEditor

**Description:** The Visual Studio core shell experience, including syntax-aware code editing, source code control and work item management.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.CoreEditor | Visual Studio core editor | 18.0.11101.78 | Required

## Azure and AI development

**ID:** Microsoft.VisualStudio.Workload.Azure

**Description:** Azure SDKs, tools, and projects for developing cloud apps (including AI agents) and creating resources using .NET and .NET Framework. Also tools for containerizing your application, including Docker support.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 18.0.11101.84 | Required
Component.Microsoft.VisualStudio.Web.AzureFunctions | Azure WebJobs Tools | 18.0.11101.84 | Required
Component.Microsoft.Web.LibraryManager | Library Manager | 18.0.11101.84 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 18.0.11101.78 | Required
Microsoft.Component.MSBuild | MSBuild | 18.0.11101.78 | Required
Microsoft.ComponentGroup.ClickOnce.Publish | ClickOnce Publishing for .NET  | 18.0.11101.84 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 18.0.11101.84 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 18.0.11101.84 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 18.0.11101.84 | Required
Microsoft.NetCore.Component.DevelopmentTools | Development tools for .NET | 18.0.11101.78 | Required
Microsoft.NetCore.Component.Runtime.10.0 | .NET 10.0 Runtime (Long Term Support) | 18.0.11201.18 | Required
Microsoft.NetCore.Component.SDK | .NET SDK | 18.0.11201.18 | Required
Microsoft.NetCore.Component.Web | Web development tools for .NET | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.FSharp.WebTemplates | F# language support for web projects | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2025 LocalDB | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.TypeScript.TSServer | TypeScript Server | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development prerequisites | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.Azure.Prerequisites | Azure development prerequisites | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.AzureFunctions | Development tools for Azure Functions and Azure WebJobs | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development prerequisites | 18.0.11111.16 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 18.0.11101.84 | Required
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
ComponentGroup.Microsoft.NET.AppModernization | GitHub Copilot app modernization | 18.0.11131.115 | Recommended
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake and Stream Analytics Tools | 18.0.11101.84 | Recommended
Microsoft.Net.Component.4.8.TargetingPack | .NET Framework 4.8 targeting pack | 18.0.11101.84 | Recommended
Microsoft.Net.ComponentGroup.4.8.DeveloperTools | .NET Framework 4.8 development tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.AspNet | .NET Framework project and item templates | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.AspNet45 | Advanced ASP.NET features | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 18.0.11101.78 | Recommended
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 18.0.11101.84 | Optional
Microsoft.Net.Component.4.8.1.SDK | .NET Framework 4.8.1 SDK | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.8.1.TargetingPack | .NET Framework 4.8.1 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.ComponentGroup.4.6.2-4.7.1.DeveloperTools | .NET Framework 4.6.2-4.7.1 development tools | 18.0.11101.84 | Optional
Microsoft.Net.ComponentGroup.4.8.1.DeveloperTools | .NET Framework 4.8.1 development tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 18.0.11101.84 | Optional

## Data storage and processing

**ID:** Microsoft.VisualStudio.Workload.Data

**Description:** Connect, develop, and test data solutions with SQL Server, Azure Data Lake, or Hadoop.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake and Stream Analytics Tools | 18.0.11101.84 | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | 18.0.11101.78 | Recommended
Microsoft.Component.MSBuild | MSBuild | 18.0.11101.78 | Recommended
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 18.0.11101.84 | Recommended
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 18.0.11101.84 | Recommended
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2025 LocalDB | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 18.0.11101.84 | Optional

## Data science and analytical applications

**ID:** Microsoft.VisualStudio.Workload.DataScience

**Description:** Languages and tooling for creating data science applications, including Python and F#.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
Microsoft.Component.PythonTools | Python language support | 18.0.11101.78 | Recommended
Microsoft.Component.PythonTools.Web | Python web support | 18.0.11101.78 | Recommended
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.TypeScript.TSServer | TypeScript Server | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 18.0.11101.84 | Recommended
Microsoft.ComponentGroup.PythonTools.NativeDevelopment | Python native development tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.14.44.17.14.x86.x64 | MSVC v143 - VS 2022 C++ x64/x86 build tools (v14.44-17.14) | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC Build Tools for x64/x86 (Latest) | 18.0.11123.170 | Optional
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Windows11SDK.26100 | Windows 11 SDK (10.0.26100.6901) | 18.0.11201.18 | Optional

## .NET desktop development

**ID:** Microsoft.VisualStudio.Workload.ManagedDesktop

**Description:** Build WPF, Windows Forms, and console applications using C#, Visual Basic, and F# with .NET and .NET Framework.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.ClickOnce | ClickOnce Publishing | 18.0.11101.78 | Required
Microsoft.Component.MSBuild | MSBuild | 18.0.11101.78 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 18.0.11101.84 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 18.0.11101.84 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 18.0.11101.84 | Required
Microsoft.NetCore.Component.Runtime.10.0 | .NET 10.0 Runtime (Long Term Support) | 18.0.11201.18 | Required
Microsoft.NetCore.Component.SDK | .NET SDK | 18.0.11201.18 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Prerequisites | .NET desktop development tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 18.0.11101.78 | Required
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
ComponentGroup.Microsoft.NET.AppModernization | GitHub Copilot app modernization | 18.0.11131.115 | Recommended
Microsoft.ComponentGroup.Blend | Blend for Visual Studio | 18.0.11101.84 | Recommended
Microsoft.ComponentGroup.ClickOnce.Publish | ClickOnce Publishing for .NET  | 18.0.11101.84 | Recommended
Microsoft.Net.Component.4.8.TargetingPack | .NET Framework 4.8 targeting pack | 18.0.11101.84 | Recommended
Microsoft.Net.ComponentGroup.4.8.DeveloperTools | .NET Framework 4.8 development tools | 18.0.11101.84 | Recommended
Microsoft.NetCore.Component.DevelopmentTools | Development tools for .NET | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.DotNetModelBuilder | ML.NET Model Builder | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.FSharp | F# language support | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.LiveUnitTesting | Live Unit Testing | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 18.0.11101.84 | Recommended
Component.Microsoft.VisualStudio.LiveShare.2022 | Live Share | 1.0.5949 | Optional
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 18.0.11101.84 | Optional
Component.Microsoft.Web.LibraryManager | Library Manager | 18.0.11101.84 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 18.0.11101.84 | Optional
Microsoft.Net.Component.4.8.1.SDK | .NET Framework 4.8.1 SDK | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.8.1.TargetingPack | .NET Framework 4.8.1 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.ComponentGroup.4.6.2-4.7.1.DeveloperTools | .NET Framework 4.6.2-4.7.1 development tools | 18.0.11101.84 | Optional
Microsoft.Net.ComponentGroup.4.8.1.DeveloperTools | .NET Framework 4.8.1 development tools | 18.0.11101.84 | Optional
Microsoft.NetCore.Component.Web | Web development tools for .NET | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.CodeClone | Code Clone | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.CodeMap | Code Map | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.FSharp.Desktop | F# desktop language support | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.FSharp.WebTemplates | F# language support for web projects | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2025 LocalDB | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.TypeScript.TSServer | TypeScript Server | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Web | ASP.NET and web development prerequisites | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 18.0.11101.78 | Optional
Microsoft.VisualStudio.ComponentGroup.ArchitectureTools.Managed | Architecture and analysis tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.MSIX.Packaging | MSIX Packaging Tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development prerequisites | 18.0.11111.16 | Optional
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 18.0.11101.84 | Optional

## Game development with Unity

**ID:** Microsoft.VisualStudio.Workload.ManagedGame

**Description:** Create 2D and 3D games with Unity, a powerful cross-platform development environment.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Unity | Visual Studio Tools for Unity | 18.0.11101.78 | Required
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
Microsoft.VisualStudio.Component.HLSL | HLSL Tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Component.UnityEngine.x64 | Unity Hub | 18.0.11101.78 | Optional

## Linux, Mac, and embedded development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeCrossPlat

**Description:** Create and debug applications running in a Linux or Mac environment or on an embedded device.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.MDD.Linux | C++ for Linux and Mac Development | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 18.0.11101.78 | Required
Component.Linux.CMake | C++ CMake tools for Linux and Mac | 18.0.11101.84 | Recommended
Component.Linux.RemoteFileExplorer | Remote File Explorer for Linux and Mac | 18.0.11101.84 | Recommended
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 18.0.11101.84 | Recommended
Component.MDD.Linux.GCC.arm | Legacy Embedded and IoT tools [Deprecated] | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.Embedded | Embedded and IoT tools [Deprecated] | 18.0.11101.78 | Optional

## Desktop development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeDesktop

**Description:** Build modern C++ apps for Windows using tools of your choice, including MSVC, Clang, CMake, or MSBuild.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.VC.Redist.14.Latest | Visual C++ v14 Redistributable Update | 18.0.11123.170 | Required
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Core | C++ core desktop features | 18.0.11101.84 | Required
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
ComponentGroup.Microsoft.NET.AppModernization | GitHub Copilot app modernization | 18.0.11131.115 | Recommended
Microsoft.VisualStudio.Component.CppBuildInsights | C++ Build Insights | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.VC.14.44.17.14.ATL | C++ v14.44 (17.14) ATL for v143 build tools (x86 & x64) | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.VC.14.44.17.14.x86.x64 | MSVC v143 - VS 2022 C++ x64/x86 build tools (v14.44-17.14) | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.VC.ASAN | MSVC AddressSanitizer | 18.0.11123.170 | Recommended
Microsoft.VisualStudio.Component.VC.ATL | C++ ATL for x64/x86 (Latest MSVC) | 18.0.11123.170 | Recommended
Microsoft.VisualStudio.Component.VC.CMake.Project | C++ CMake tools for Windows | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.VC.TestAdapterForBoostTest | Test Adapter for Boost.Test | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.VC.TestAdapterForGoogleTest | Test Adapter for Google Test | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC Build Tools for x64/x86 (Latest) | 18.0.11123.170 | Recommended
Microsoft.VisualStudio.Component.Vcpkg | vcpkg package manager | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.Windows11SDK.26100 | Windows 11 SDK (10.0.26100.6901) | 18.0.11201.18 | Recommended
Microsoft.VisualStudio.Component.Windows11Sdk.WindowsPerformanceToolkit | Windows Performance Toolkit | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions.CMake | JSON editor | 18.0.11101.84 | Recommended
Component.Incredibuild | Incredibuild - Build Acceleration | 18.0.11101.84 | Optional
Component.IncredibuildMenu | IncredibuildMenu | 1.6.0.8 | Optional
Component.Microsoft.VisualStudio.LiveShare.2022 | Live Share | 1.0.5949 | Optional
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 18.0.11101.84 | Optional
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.TypeScript.TSServer | TypeScript Server | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.14.44.17.14.CLI.Support | C++/CLI support for v143 build tools (14.44-17.14) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.14.44.17.14.MFC | C++ v14.44 (17.14) MFC for v143 build tools (x86 & x64) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.140 | MSVC v140 - VS 2015 C++ build tools (v14.00) (Out of support) | 18.0.11201.18 | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | C++ MFC for x64/x86 (Latest MSVC) | 18.0.11123.170 | Optional
Microsoft.VisualStudio.Component.VC.CLI.Support | C++/CLI support (Latest MSVC) | 18.0.11123.170 | Optional
Microsoft.VisualStudio.Component.VC.Llvm.Clang | C++ Clang Compiler for Windows (20.1.8) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.Llvm.ClangToolset | MSBuild support for LLVM (clang-cl) toolset | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.v141.x86.x64 | MSVC v141 - VS 2017 C++ x64/x86 build tools (v14.16) | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.Windows11SDK.22621 | Windows 11 SDK (10.0.22621.0) | 18.0.11101.78 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Llvm.Clang | C++ Clang tools for Windows (20.1.8 - x64/x86) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.VC.Tools.142.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.29) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.VC.Tools.143.x86.x64 | MSVC v143 - VS 2022 C++ x64/x86 build tools (v14.44) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 18.0.11101.84 | Optional

## Game development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeGame

**Description:** Use the full power of C++ to build professional games powered by DirectX, Unreal, or Cocos2d.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.VC.Redist.14.Latest | Visual C++ v14 Redistributable Update | 18.0.11123.170 | Required
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 18.0.11101.84 | Required
Component.Unreal.Debugger | Visual Studio debugger tools for Unreal Engine Blueprints | 18.0.11101.84 | Recommended
Component.Unreal.Ide | Visual Studio Tools for Unreal Engine | 18.0.11101.78 | Recommended
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 18.0.11101.78 | Recommended
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 18.0.11101.84 | Recommended
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 18.0.11101.84 | Recommended
Microsoft.Net.Component.4.8.TargetingPack | .NET Framework 4.8 targeting pack | 18.0.11101.84 | Recommended
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 18.0.11101.84 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4.8 development tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.CppBuildInsights | C++ Build Insights | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.HLSL | HLSL Tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.VC.14.44.17.14.x86.x64 | MSVC v143 - VS 2022 C++ x64/x86 build tools (v14.44-17.14) | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.VC.ASAN | MSVC AddressSanitizer | 18.0.11123.170 | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC Build Tools for x64/x86 (Latest) | 18.0.11123.170 | Recommended
Microsoft.VisualStudio.Component.Vcpkg | vcpkg package manager | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.Windows11SDK.26100 | Windows 11 SDK (10.0.26100.6901) | 18.0.11201.18 | Recommended
Microsoft.VisualStudio.Component.Windows11Sdk.WindowsPerformanceToolkit | Windows Performance Toolkit | 18.0.11101.84 | Recommended
Component.Android.NDK.R23C | Android NDK (R23C) | 18.0.11101.84 | Optional
Component.Android.NDK.R27C | Android NDK (R27C) | 18.0.11101.84 | Optional
Component.Android.SDK.MAUI | Android SDK setup | 18.0.11101.84 | Optional
Component.Cocos | Cocos | 18.0.11101.78 | Optional
Component.Incredibuild | Incredibuild - Build Acceleration | 18.0.11101.84 | Optional
Component.IncredibuildMenu | IncredibuildMenu | 1.6.0.8 | Optional
Component.MDD.Android | C++ Android development tools | 18.0.11101.84 | Optional
Component.OpenJDK | OpenJDK (Microsoft distribution) | 18.0.11101.84 | Optional
Component.Unreal | Unreal Engine installer | 18.0.11101.78 | Optional
Component.Unreal.Android | Android Visual Studio Tools for Unreal Engine | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Unreal.TestAdapter | Unreal Engine Test Adapter | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Windows11SDK.22621 | Windows 11 SDK (10.0.22621.0) | 18.0.11101.78 | Optional

## Mobile development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeMobile

**Description:** Build cross-platform applications for iOS, Android or Windows using C++.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Android.SDK.MAUI | Android SDK setup | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 18.0.11101.78 | Required
Component.Android.NDK.R27C | Android NDK (R27C) | 18.0.11101.84 | Recommended
Component.MDD.Android | C++ Android development tools | 18.0.11101.84 | Recommended
Component.OpenJDK | OpenJDK (Microsoft distribution) | 18.0.11101.84 | Recommended
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Recommended
Component.Android.NDK.R23C | Android NDK (R23C) | 18.0.11101.84 | Optional
Component.Incredibuild | Incredibuild - Build Acceleration | 18.0.11101.84 | Optional
Component.IncredibuildMenu | IncredibuildMenu | 1.6.0.8 | Optional
Component.MDD.IOS | C++ iOS development tools | 18.0.11101.84 | Optional

## .NET Multi-platform App UI development

**ID:** Microsoft.VisualStudio.Workload.NetCrossPlat

**Description:** Build Android, iOS, Windows, and Mac apps from a single codebase using C# with .NET MAUI.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
android | .NET SDK for Android | 36.1.2.0 | Required
Component.OpenJDK | OpenJDK (Microsoft distribution) | 18.0.11101.84 | Required
ios | .NET SDK for iOS | 26.0.11017 | Required
maccatalyst | .NET SDK for Mac Catalyst | 26.0.11017 | Required
maui.blazor | .NET MAUI SDK for Blazor Desktop | 10.0.0.7243 | Required
maui.core | .NET MAUI SDK Core | 10.0.0.7243 | Required
maui.windows | .NET MAUI SDK for Windows | 10.0.0.7243 | Required
Microsoft.Component.MSBuild | MSBuild | 18.0.11101.78 | Required
Microsoft.ComponentGroup.ClickOnce.Publish | ClickOnce Publishing for .NET  | 18.0.11101.84 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 18.0.11101.84 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 18.0.11101.84 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 18.0.11101.84 | Required
microsoft.net.runtime.android | .NET 10.0 Android Build Tools | 10.1.25.52411 | Required
microsoft.net.runtime.android.aot | .NET 10.0 Android Build Tools (AoT) | 10.1.25.52411 | Required
microsoft.net.runtime.android.aot.net9 | .NET 9.0 Android Build Tools (AoT) | 10.1.25.52411 | Required
microsoft.net.runtime.android.net9 | .NET 9.0 Android Build Tools | 10.1.25.52411 | Required
microsoft.net.runtime.ios | .NET 10.0 iOS Build Tools | 10.1.25.52411 | Required
microsoft.net.runtime.ios.net9 | .NET 9.0 iOS Build Tools | 10.1.25.52411 | Required
microsoft.net.runtime.maccatalyst | .NET 10.0 Mac Catalyst Build Tools | 10.1.25.52411 | Required
microsoft.net.runtime.maccatalyst.net9 | .NET 9.0 Mac Catalyst Build Tools | 10.1.25.52411 | Required
microsoft.net.runtime.mono.tooling | .NET 10.0 Shared Mobile Build Tools | 10.1.25.52411 | Required
microsoft.net.runtime.mono.tooling.net9 | .NET 9.0 Shared Mobile Build Tools | 10.1.25.52411 | Required
Microsoft.NetCore.Component.DevelopmentTools | Development tools for .NET | 18.0.11101.78 | Required
Microsoft.NetCore.Component.Runtime.10.0 | .NET 10.0 Runtime (Long Term Support) | 18.0.11201.18 | Required
Microsoft.NetCore.Component.SDK | .NET SDK | 18.0.11201.18 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.TypeScript.TSServer | TypeScript Server | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.Maui.All | .NET MAUI | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.Maui.Android | .NET MAUI for Android | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.Maui.Blazor | Blazor support for .NET MAUI Applications | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.Maui.iOS | .NET MAUI for iOS | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.Maui.MacCatalyst | .NET MAUI for Mac Catalyst | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.Maui.Shared | .NET MAUI development tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.Maui.Windows | .NET MAUI for Windows | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.MSIX.Packaging | MSIX Packaging Tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions.TemplateEngine | ASP.NET templating engine | 18.0.11101.84 | Required
runtimes.ios | .NET 10.0 iOS Runtimes | 10.1.25.52411 | Required
runtimes.ios.net9 | .NET 9.0 iOS Runtimes | 10.1.25.52411 | Required
runtimes.maccatalyst | .NET 10.0 Mac Catalyst Build Tools | 10.1.25.52411 | Required
runtimes.maccatalyst.net9 | .NET 9.0 Mac Catalyst Build Tools | 10.1.25.52411 | Required
Component.Android.SDK.MAUI | Android SDK setup | 18.0.11101.84 | Recommended
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
ComponentGroup.Microsoft.NET.AppModernization | GitHub Copilot app modernization | 18.0.11131.115 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.LiveUnitTesting | Live Unit Testing | 18.0.11101.84 | Recommended

## ASP.NET and web development

**ID:** Microsoft.VisualStudio.Workload.NetWeb

**Description:** Build web applications using ASP.NET Core, ASP.NET, HTML/JavaScript, and Containers including Docker support.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 18.0.11101.84 | Required
Component.Microsoft.Web.LibraryManager | Library Manager | 18.0.11101.84 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 18.0.11101.78 | Required
Microsoft.Component.MSBuild | MSBuild | 18.0.11101.78 | Required
Microsoft.ComponentGroup.ClickOnce.Publish | ClickOnce Publishing for .NET  | 18.0.11101.84 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 18.0.11101.84 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 18.0.11101.84 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 18.0.11101.84 | Required
Microsoft.NetCore.Component.DevelopmentTools | Development tools for .NET | 18.0.11101.78 | Required
Microsoft.NetCore.Component.Runtime.10.0 | .NET 10.0 Runtime (Long Term Support) | 18.0.11201.18 | Required
Microsoft.NetCore.Component.SDK | .NET SDK | 18.0.11201.18 | Required
Microsoft.NetCore.Component.Web | Web development tools for .NET | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.FSharp.WebTemplates | F# language support for web projects | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2025 LocalDB | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.TypeScript.TSServer | TypeScript Server | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development prerequisites | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development prerequisites | 18.0.11111.16 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 18.0.11101.84 | Required
Component.Microsoft.VisualStudio.Web.AzureFunctions | Azure WebJobs Tools | 18.0.11101.84 | Recommended
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
ComponentGroup.Microsoft.NET.AppModernization | GitHub Copilot app modernization | 18.0.11131.115 | Recommended
Microsoft.Net.Component.4.8.TargetingPack | .NET Framework 4.8 targeting pack | 18.0.11101.84 | Recommended
Microsoft.Net.ComponentGroup.4.8.DeveloperTools | .NET Framework 4.8 development tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.AspNet | .NET Framework project and item templates | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.AspNet45 | Advanced ASP.NET features | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.LiveUnitTesting | Live Unit Testing | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.WslDebugging | .NET Debugging with WSL | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.ComponentGroup.AzureFunctions | Development tools for Azure Functions and Azure WebJobs | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.ComponentGroup.Web.CloudTools | Cloud tools for web development | 18.0.11123.170 | Recommended
Component.Microsoft.VisualStudio.LiveShare.2022 | Live Share | 1.0.5949 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 18.0.11101.84 | Optional
Microsoft.Net.Component.4.8.1.SDK | .NET Framework 4.8.1 SDK | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.8.1.TargetingPack | .NET Framework 4.8.1 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.ComponentGroup.4.6.2-4.7.1.DeveloperTools | .NET Framework 4.6.2-4.7.1 development tools | 18.0.11101.84 | Optional
Microsoft.Net.ComponentGroup.4.8.1.DeveloperTools | .NET Framework 4.8.1 development tools | 18.0.11101.84 | Optional
microsoft.net.runtime.mono.tooling | .NET 10.0 Shared Mobile Build Tools | 10.1.25.52411 | Optional
microsoft.net.runtime.mono.tooling.net6 | .NET 6.0 Shared Mobile Build Tools | 10.1.25.52411 | Optional
microsoft.net.runtime.mono.tooling.net7 | .NET 7.0 Shared Mobile Build Tools | 10.1.25.52411 | Optional
microsoft.net.runtime.mono.tooling.net8 | .NET 8.0 Shared Mobile Build Tools | 10.1.25.52411 | Optional
microsoft.net.runtime.mono.tooling.net9 | .NET 9.0 Shared Mobile Build Tools | 10.1.25.52411 | Optional
microsoft.net.sdk.emscripten | .NET WebAssembly Build Tools (Emscripten) | 10.1.25.52411 | Optional
microsoft.net.sdk.emscripten.net6 | .NET WebAssembly Build Tools for .NET 6 (Emscripten) | 10.1.25.52411 | Optional
microsoft.net.sdk.emscripten.net7 | .NET WebAssembly Build Tools for .NET 7 (Emscripten) | 10.1.25.52411 | Optional
microsoft.net.sdk.emscripten.net8 | .NET WebAssembly Build Tools for .NET 8 (Emscripten) | 10.1.25.52411 | Optional
microsoft.net.sdk.emscripten.net9 | .NET WebAssembly Build Tools for .NET 9 (Emscripten) | 10.1.25.52411 | Optional
Microsoft.NetCore.Component.Runtime.8.0 | .NET 8.0 Runtime (Long Term Support) | 18.0.11201.18 | Optional
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.CodeClone | Code Clone | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.CodeMap | Code Map | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.TeamsFx | Microsoft 365 Agents Toolkit | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.AdditionalWebProjectTemplates | Additional project templates (previous versions) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.ArchitectureTools.Managed | Architecture and analysis tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.IISDevelopment | Development time IIS support | 18.0.11101.84 | Optional
wasm.tools | .NET 10.0 WebAssembly Build Tools | 10.1.25.52411 | Optional
wasm.tools.net6 | .NET 6.0 WebAssembly Build Tools | 10.1.25.52411 | Optional
wasm.tools.net7 | .NET 7.0 WebAssembly Build Tools | 10.1.25.52411 | Optional
wasm.tools.net8 | .NET 8.0 WebAssembly Build Tools | 10.1.25.52411 | Optional
wasm.tools.net9 | .NET 9.0 WebAssembly Build Tools | 10.1.25.52411 | Optional

## Node.js development

**ID:** Microsoft.VisualStudio.Workload.Node

**Description:** Build scalable network applications using Node.js, an asynchronous event-driven JavaScript runtime. 

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Node.Tools | Node.js development tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.TypeScript.TSServer | TypeScript Server | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 18.0.11101.84 | Required
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 18.0.11101.78 | Recommended
Component.Microsoft.VisualStudio.LiveShare.2022 | Live Share | 1.0.5949 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.14.44.17.14.x86.x64 | MSVC v143 - VS 2022 C++ x64/x86 build tools (v14.44-17.14) | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC Build Tools for x64/x86 (Latest) | 18.0.11123.170 | Optional

## Microsoft 365 development

**ID:** Microsoft.VisualStudio.Workload.Office

**Description:** Create Office and SharePoint add-ins, SharePoint solutions, and VSTO add-ins using C#, VB, and JavaScript.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Microsoft.VisualStudio.RazorExtension | Razor Language Services | 18.0.11101.84 | Required
Component.Microsoft.Web.LibraryManager | Library Manager | 18.0.11101.84 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 18.0.11101.78 | Required
Microsoft.Component.MSBuild | MSBuild | 18.0.11101.78 | Required
Microsoft.ComponentGroup.ClickOnce.Publish | ClickOnce Publishing for .NET  | 18.0.11101.84 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 18.0.11101.84 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 18.0.11101.84 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 18.0.11101.84 | Required
Microsoft.NetCore.Component.DevelopmentTools | Development tools for .NET | 18.0.11101.78 | Required
Microsoft.NetCore.Component.Runtime.10.0 | .NET 10.0 Runtime (Long Term Support) | 18.0.11201.18 | Required
Microsoft.NetCore.Component.SDK | .NET SDK | 18.0.11201.18 | Required
Microsoft.NetCore.Component.Web | Web development tools for .NET | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.FSharp | F# language support | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.FSharp.WebTemplates | F# language support for web projects | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Prerequisites | .NET desktop development tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.MSODBC.SQL | SQL Server ODBC Driver | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.MSSQL.CMDLnUtils | SQL Server Command Line Utilities | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Sharepoint.Tools | Office Developer Tools for Visual Studio | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2025 LocalDB | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.TypeScript.TSServer | TypeScript Server | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development prerequisites | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Workflow | Windows Workflow Foundation | 18.0.11101.78 | Required
Microsoft.VisualStudio.ComponentGroup.Web | ASP.NET and web development prerequisites | 18.0.11111.16 | Required
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 18.0.11101.84 | Required
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
Microsoft.Net.Component.4.8.TargetingPack | .NET Framework 4.8 targeting pack | 18.0.11101.84 | Recommended
Microsoft.Net.ComponentGroup.4.8.DeveloperTools | .NET Framework 4.8 development tools | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.TeamOffice | Visual Studio Tools for Office (VSTO) | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 18.0.11101.78 | Recommended
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 18.0.11101.84 | Optional
Microsoft.Net.Component.4.8.1.SDK | .NET Framework 4.8.1 SDK | 18.0.11101.78 | Optional
Microsoft.Net.Component.4.8.1.TargetingPack | .NET Framework 4.8.1 targeting pack | 18.0.11101.78 | Optional
Microsoft.Net.ComponentGroup.4.6.2-4.7.1.DeveloperTools | .NET Framework 4.6.2-4.7.1 development tools | 18.0.11101.84 | Optional
Microsoft.Net.ComponentGroup.4.8.1.DeveloperTools | .NET Framework 4.8.1 development tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.Sharepoint.WIF | Windows Identity Foundation 3.5 | 18.0.11101.84 | Optional

## Python development

**ID:** Microsoft.VisualStudio.Workload.Python

**Description:** Editing, debugging, interactive development and source control for Python.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.PythonTools | Python language support | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Required
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Recommended
Component.CPython39.x64 | Python 3 64-bit (3.9.13) (out of support) | 3.9.13.1 | Optional
Component.Microsoft.VisualStudio.LiveShare.2022 | Live Share | 1.0.5949 | Optional
Microsoft.Component.PythonTools.Web | Python web support | 18.0.11101.78 | Optional
Microsoft.ComponentGroup.PythonTools.NativeDevelopment | Python native development tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.TypeScript.TSServer | TypeScript Server | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.14.44.17.14.x86.x64 | MSVC v143 - VS 2022 C++ x64/x86 build tools (v14.44-17.14) | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC Build Tools for x64/x86 (Latest) | 18.0.11123.170 | Optional
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Windows11SDK.26100 | Windows 11 SDK (10.0.26100.6901) | 18.0.11201.18 | Optional
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 18.0.11101.84 | Optional

## WinUI application development

**ID:** Microsoft.VisualStudio.Workload.Universal

**Description:** Build applications for the Windows platform using WinUI with C# or optionally C﻿+﻿+.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.ClickOnce | ClickOnce Publishing | 18.0.11101.78 | Required
Microsoft.Component.MSBuild | MSBuild | 18.0.11101.78 | Required
Microsoft.Component.NetFX.Native | .NET Native | 18.0.11101.78 | Required
Microsoft.ComponentGroup.Blend | Blend for Visual Studio | 18.0.11101.84 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 18.0.11101.84 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 18.0.11101.84 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 18.0.11101.84 | Required
Microsoft.NetCore.Component.Runtime.10.0 | .NET 10.0 Runtime (Long Term Support) | 18.0.11201.18 | Required
Microsoft.NetCore.Component.Runtime.8.0 | .NET 8.0 Runtime (Long Term Support) | 18.0.11201.18 | Required
Microsoft.NetCore.Component.SDK | .NET SDK | 18.0.11201.18 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 18.0.11101.78 | Required
Microsoft.VisualStudio.Component.WindowsAppSdkSupport.CSharp | .NET WinUI app development tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.UWP.NetCoreAndStandard | .NET Native and .NET Standard | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.WindowsAppDevelopment.Prerequisites | .NET WinUI app development prerequisites | 18.0.11101.84 | Required
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.CodeClone | Code Clone | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.CodeMap | Code Map | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2025 LocalDB | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.UWP.VC.ARM64 | C++ Universal Windows Platform support for ARM64/ARM64EC build tools (Latest MSVC) | 18.0.11123.170 | Optional
Microsoft.VisualStudio.Component.UWP.VC.ARM64EC | C++ Universal Windows Platform support for ARM64EC build tools (Latest MSVC) | 18.0.11123.170 | Optional
Microsoft.VisualStudio.Component.VC.14.29.16.11.ARM | MSVC v142 - VS 2019 C++ ARM build tools (v14.29-16.11) | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.14.29.16.11.ARM64 | MSVC v142 - VS 2019 C++ ARM64 build tools (v14.29-16.11) | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.14.44.17.14.ARM | MSVC v143 - VS 2022 C++ ARM build tools (v14.44-17.14) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.14.44.17.14.ARM64 | MSVC v143 - VS 2022 C++ ARM64/ARM64EC build tools (v14.44-17.14) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.14.44.17.14.x86.x64 | MSVC v143 - VS 2022 C++ x64/x86 build tools (v14.44-17.14) | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | C++ core features | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.Redist.14.Latest | Visual C++ v14 Redistributable Update | 18.0.11123.170 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM64 | MSVC Build Tools for ARM64/ARM64EC (Latest) | 18.0.11123.170 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM64EC | MSVC Build Tools for ARM64EC (Latest) | 18.0.11123.170 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | MSVC Build Tools for x64/x86 (Latest) | 18.0.11123.170 | Optional
Microsoft.VisualStudio.Component.VC.v141.ARM | MSVC v141 - VS 2017 C++ ARM build tools (v14.16) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.Component.VC.v141.ARM64 | MSVC v141 - VS 2017 C++ ARM64 build tools (v14.16) | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VC.v141.x86.x64 | MSVC v141 - VS 2017 C++ x64/x86 build tools (v14.16) | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.IpOverUsb | USB Device Connectivity | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.Windows11SDK.22621 | Windows 11 SDK (10.0.22621.0) | 18.0.11101.78 | Optional
Microsoft.VisualStudio.Component.Windows11SDK.26100 | Windows 11 SDK (10.0.26100.6901) | 18.0.11201.18 | Optional
Microsoft.VisualStudio.Component.WindowsAppSdkSupport.Cpp | C++ WinUI app development tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.ArchitectureTools.Managed | Architecture and analysis tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.MSIX.Packaging | MSIX Packaging Tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Core | C++ core desktop features | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.Support | Universal Windows Platform tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.VC | C++ Universal Windows Platform tools (Latest MSVC) | 18.0.11123.170 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.VC.v141 | C++ (v141) Universal Windows Platform tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.VC.v142 | C++ (v142) Universal Windows Platform tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.VC.v143 | C++ (v143) Universal Windows Platform tools | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.VC.Tools.142.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.29) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.VC.Tools.143.x86.x64 | MSVC v143 - VS 2022 C++ x64/x86 build tools (v14.44) | 18.0.11101.84 | Optional
Microsoft.VisualStudio.ComponentGroup.WindowsAppDevelopment.VC | C++ WinUI app development tools | 18.0.11101.84 | Optional

## Visual Studio extension development

**ID:** Microsoft.VisualStudio.Workload.VisualStudioExtension

**Description:** Create add-ons and extensions for Visual Studio, including new commands, code analyzers and tool windows.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 18.0.11101.78 | Required
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 18.0.11101.84 | Required
Microsoft.Net.Component.4.7.2.TargetingPack | .NET Framework 4.7.2 targeting pack | 18.0.11101.84 | Required
Microsoft.Net.Component.4.8.SDK | .NET Framework 4.8 SDK | 18.0.11101.84 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.7.2 development tools | 18.0.11101.84 | Required
Microsoft.NetCore.Component.Runtime.10.0 | .NET 10.0 Runtime (Long Term Support) | 18.0.11201.18 | Required
Microsoft.NetCore.Component.Runtime.8.0 | .NET 8.0 Runtime (Long Term Support) | 18.0.11201.18 | Required
Microsoft.NetCore.Component.SDK | .NET SDK | 18.0.11201.18 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | .NET profiling tools | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 18.0.11101.84 | Required
Microsoft.VisualStudio.Component.VSSDK | Visual Studio SDK | 18.0.11101.84 | Required
Microsoft.VisualStudio.ComponentGroup.VisualStudioExtension.Prerequisites | Visual Studio extension development prerequisites | 18.0.11101.84 | Required
Component.VisualStudio.GitHub.Copilot | GitHub Copilot | 18.0.11201.18 | Recommended
Microsoft.Component.CodeAnalysis.SDK | .NET Compiler Platform SDK | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.IntelliCode | IntelliCode | 18.0.11121.172 | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 18.0.11101.84 | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 18.0.11101.78 | Recommended
Microsoft.VisualStudio.Component.DslTools | Modeling SDK | 18.0.11101.78 | Optional

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name | Version
--- | --- | ---
Component.Microsoft.Windows.DriverKit | Windows Driver Kit | 10.0.26100.12
macos | .NET SDK for macOS | 26.0.11017
Microsoft.Component.HelpViewer | Help Viewer | 18.0.11101.84
Microsoft.Net.Component.3.5.DeveloperTools | .NET Framework 3.5 development tools | 18.0.11101.84
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 18.0.11101.78
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 18.0.11101.84
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 18.0.11101.84
Microsoft.Net.Component.4.7.2.SDK | .NET Framework 4.7.2 SDK | 18.0.11101.78
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 18.0.11101.78
Microsoft.Net.Core.Component.SDK.2.1 | .NET Core 2.1 Runtime (Out of support) | 18.0.11101.84
Microsoft.NetCore.Component.Runtime.3.1 | .NET Core 3.1 Runtime (Out of support) | 18.0.11101.84
Microsoft.NetCore.Component.Runtime.5.0 | .NET 5.0 Runtime (Out of support) | 18.0.11101.84
Microsoft.NetCore.Component.Runtime.6.0 | .NET 6.0 Runtime (Out of support) | 18.0.11201.18
Microsoft.NetCore.Component.Runtime.7.0 | .NET 7.0 Runtime (Out of support) | 18.0.11201.18
Microsoft.NetCore.Component.Runtime.9.0 | .NET 9.0 Runtime | 18.0.11201.18
Microsoft.NetCore.ComponentGroup.DevelopmentTools.2.1 | Development Tools for .NET Core 2.1 (Out of support) | 18.0.11101.84
Microsoft.NetCore.ComponentGroup.Web.2.1 | Web development tools for .NET Core 2.1 (Out of support) | 18.0.11101.78
Microsoft.VisualStudio.Component.AzureDevOps.OfficeIntegration | Azure DevOps Office Integration | 18.0.11101.84
Microsoft.VisualStudio.Component.Debugger.Arm64RemoteDebugger | ARM64 Remote Debugger | 18.0.11101.78
Microsoft.VisualStudio.Component.Git | Git for Windows | 18.0.11101.78
Microsoft.VisualStudio.Component.LinqToSql | LINQ to SQL tools | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.29.16.11.ARM.Spectre | MSVC v142 - VS 2019 C++ ARM Spectre-mitigated libs (v14.29-16.11) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.14.29.16.11.ARM64.Spectre | MSVC v142 - VS 2019 C++ ARM64 Spectre-mitigated libs (v14.29-16.11) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.29.16.11.ATL | C++ v14.29 (16.11) ATL for v142 build tools (x86 & x64) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.14.29.16.11.ATL.ARM | C++ v14.29 (16.11) ATL for v142 build tools (ARM) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.29.16.11.ATL.ARM.Spectre | C++ v14.29 (16.11) ATL for v142 build tools with Spectre Mitigations (ARM) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.29.16.11.ATL.ARM64 | C++ v14.29 (16.11) ATL for v142 build tools (ARM64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.29.16.11.ATL.ARM64.Spectre | C++ v14.29 (16.11) ATL for v142 build tools with Spectre Mitigations (ARM64) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.14.29.16.11.ATL.Spectre | C++ v14.29 (16.11) ATL for v142 build tools with Spectre Mitigations (x86 & x64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.29.16.11.CLI.Support | C++/CLI support for v142 build tools (14.29-16.11) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.14.29.16.11.MFC | C++ v14.29 (16.11) MFC for v142 build tools (x86 & x64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.29.16.11.MFC.ARM | C++ v14.29 (16.11) MFC for v142 build tools (ARM) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.14.29.16.11.MFC.ARM.Spectre | C++ v14.29 (16.11) MFC for v142 build tools with Spectre Mitigations (ARM) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.14.29.16.11.MFC.ARM64 | C++ v14.29 (16.11) MFC for v142 build tools (ARM64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.29.16.11.MFC.ARM64.Spectre | C++ v14.29 (16.11) MFC for v142 build tools with Spectre Mitigations (ARM64) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.14.29.16.11.MFC.Spectre | C++ v14.29 (16.11) MFC for v142 build tools with Spectre Mitigations (x86 & x64) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.14.29.16.11.x86.x64 | MSVC v142 - VS 2019 C++ x64/x86 build tools (v14.29-16.11) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.14.29.16.11.x86.x64.Spectre | MSVC v142 - VS 2019 C++ x64/x86 Spectre-mitigated libs (v14.29-16.11) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.ARM.Spectre | MSVC v143 - VS 2022 C++ ARM Spectre-mitigated libs (v14.44-17.14) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.ARM64.Spectre | MSVC v143 - VS 2022 C++ ARM64/ARM64EC Spectre-mitigated libs (v14.44-17.14) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.14.44.17.14.ATL.ARM | C++ v14.44 (17.14) ATL for v143 build tools (ARM) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.ATL.ARM.Spectre | C++ v14.44 (17.14) ATL for v143 build tools with Spectre Mitigations (ARM) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.ATL.ARM64 | C++ v14.44 (17.14) ATL for v143 build tools (ARM64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.ATL.ARM64.Spectre | C++ v14.44 (17.14) ATL for v143 build tools with Spectre Mitigations (ARM64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.ATL.Spectre | C++ v14.44 (17.14) ATL for v143 build tools with Spectre Mitigations (x86 & x64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.MFC.ARM | C++ v14.44 (17.14) MFC for v143 build tools (ARM) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.MFC.ARM.Spectre | C++ v14.44 (17.14) MFC for v143 build tools with Spectre Mitigations (ARM) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.MFC.ARM64 | C++ v14.44 (17.14) MFC for v143 build tools (ARM64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.MFC.ARM64.Spectre | C++ v14.44 (17.14) MFC for v143 build tools with Spectre Mitigations (ARM64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.MFC.Spectre | C++ v14.44 (17.14) MFC for v143 build tools with Spectre Mitigations (x86 & x64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.44.17.14.x86.x64.Spectre | MSVC v143 - VS 2022 C++ x64/x86 Spectre-mitigated libs (v14.44-17.14) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.14.50.18.0.ARM64 | MSVC Build Tools v14.50 for ARM64/ARM64EC | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.ARM64.Spectre | C++ Spectre-mitigated libraries for ARM64/ARM64EC (MSVC v14.50) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.ATL | C++ ATL for x64/x86 (MSVC v14.50) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.ATL.ARM64 | C++ ATL for ARM64 (MSVC v14.50) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.ATL.ARM64.Spectre | C++ ATL with Spectre mitigations for ARM64 (MSVC v14.50) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.ATL.Spectre | C++ ATL with Spectre mitigations for x64/x86 (MSVC v14.50) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.CLI.Support | C++/CLI support (MSVC v14.50) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.MFC | C++ MFC for x64/x86 (MSVC v14.50) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.MFC.ARM64 | C++ MFC for ARM64 (MSVC v14.50) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.MFC.ARM64.Spectre | C++ MFC with Spectre mitigations for ARM64 (MSVC v14.50) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.MFC.Spectre | C++ MFC with Spectre mitigations for x64/x86 (MSVC v14.50) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.x86.x64 | MSVC Build Tools v14.50 for x64/x86 | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.14.50.18.0.x86.x64.Spectre | C++ Spectre-mitigated libraries for x64/x86 (MSVC v14.50) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.ATL.ARM64 | C++ ATL for ARM64/ARM64EC (Latest MSVC) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.ATL.ARM64.Spectre | C++ ATL with Spectre mitigations for ARM64/ARM64EC (Latest MSVC) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.ATL.Spectre | C++ ATL with Spectre mitigations for x64/x86 (Latest MSVC) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.ATLMFC.Spectre | C++ MFC with Spectre mitigations for x64/x86 (Latest MSVC) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.MFC.ARM64 | C++ MFC for ARM64/ARM64EC (Latest MSVC) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.MFC.ARM64.Spectre | C++ MFC with Spectre mitigations for ARM64/ARM64EC (Latest MSVC) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.Redist.MSM | Visual C++ v14 Redistributable MSMs | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.Runtimes.ARM64.Spectre | C++ Spectre-mitigated libraries for ARM64/ARM64EC (Latest MSVC) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.Runtimes.x86.x64.Spectre | C++ Spectre-mitigated libraries for x64/x86 (Latest MSVC) | 18.0.11123.170
Microsoft.VisualStudio.Component.VC.v141.ARM.Spectre | MSVC v141 - VS 2017 C++ ARM Spectre-mitigated libs (v14.16) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.v141.ARM64.Spectre | MSVC v141 - VS 2017 C++ ARM64 Spectre-mitigated libs (v14.16) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.v141.ATL | C++ ATL for v141 build tools (x86 & x64) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.v141.ATL.ARM | C++ ATL for v141 build tools (ARM) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.v141.ATL.ARM.Spectre | C++ ATL for v141 build tools with Spectre Mitigations (ARM) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.v141.ATL.ARM64 | C++ ATL for v141 build tools (ARM64) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.v141.ATL.ARM64.Spectre | C++ ATL for v141 build tools with Spectre Mitigations (ARM64) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.v141.ATL.Spectre | C++ ATL for v141 build tools with Spectre Mitigations (x86 & x64) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.v141.CLI.Support | C++/CLI support for v141 build tools (14.16) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.v141.MFC | C++ MFC for v141 build tools (x86 & x64) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.v141.MFC.ARM | C++ MFC for v141 build tools (ARM) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.v141.MFC.ARM.Spectre | C++ MFC for v141 build tools with Spectre Mitigations (ARM) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.v141.MFC.ARM64 | C++ MFC for v141 build tools (ARM64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.v141.MFC.ARM64.Spectre | C++ MFC for v141 build tools with Spectre Mitigations (ARM64) | 18.0.11101.78
Microsoft.VisualStudio.Component.VC.v141.MFC.Spectre | C++ MFC for v141 build tools with Spectre Mitigations (x86 & x64) | 18.0.11101.84
Microsoft.VisualStudio.Component.VC.v141.x86.x64.Spectre | MSVC v141 - VS 2017 C++ x64/x86 Spectre-mitigated libs (v14.16) | 18.0.11101.78
Microsoft.VisualStudio.Component.WinXP | C++ Windows XP Support for VS 2017 (v141) tools [Deprecated] | 18.0.11101.84
Microsoft.VisualStudio.Web.Mvc4.ComponentGroup | ASP.NET MVC 4 | 18.0.11101.84
tvos | .NET SDK for tvOS | 26.0.11017
