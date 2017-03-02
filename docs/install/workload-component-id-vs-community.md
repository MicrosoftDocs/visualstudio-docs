---
# required metadata

title: [Visual Studio Community 2017 workload and component IDs | Microsoft Docs]
description: "Use workload and component IDs to install Visual Studio by using the command line or to specify as a dependency in a VSIX manifest"
keywords:
author: [TerryGLee]
ms.author: [tglee]
manager: [ghogen]
ms.date:  03/07/2017
ms.topic: article
helpviewer_keywords:
  - "workload ID, Visual Studio"
  - "component ID, Visual Studio"
  - "install Visual Studio, administrator guide"
ms.prod: "visual-studio-dev15"
ms.service: 
ms.technology:
  - "vs-ide-install"
  - "vs-ide-sdk"
ms.assetid: 58494fc3-12de-4761-bd4a-74b54f72bfb3
translation.priority.ht:
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt:
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---

# Visual Studio Community 2017 workload and component IDs

The tables on this page list the IDs that you can use to install Visual Studio by using the command line or that you can specify as a dependency in a VSIX manifest. Note that we will add additional components as we release updates to Visual Studio.

Also note the following about the page:

* Each workload has its own section, followed by the workload ID and a table of the components that are available for the workload.
* By default, the **Required** components will be installed when you install the workload. If you choose to, you can also install the **Recommended** and **Optional** components.
* We’ve also added a section that lists the additional components that are not affiliated with any workload.

> [!IMPORTANT]
> When you set dependencies in your VSIX manifest, you must specify Component IDs only. Use the tables on this page to determine our minimum component dependencies. In some scenarios, this might mean that you specify only one component from a workload. In other scenarios, it might mean that you specify multiple components from a single workload or multiple components from multiple workloads. For more information, see the [How to: Migrate Extensibility Projects to Visual Studio 2017](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md) page.

For more information about how to use these IDs, see [Use Command-Line Parameters to Install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) page.


## Visual Studio core editor (included with Visual Studio Community 2017)

**ID:** Microsoft.VisualStudio.Workload.CoreEditor

**Description:** The Visual Studio core shell experience, including syntax-aware code editing, source code control and work item management.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.CoreEditor | Visual Studio core editor | 15.0.26004.1 | Required


## Azure development

**ID:** Microsoft.VisualStudio.Workload.Azure

**Description:** Azure SDK, tools, and projects for developing cloud apps and creating resources.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 15.0.26004.1 | Required
Microsoft.Component.NetFX.Core.Runtime | .NET Core runtime | 15.0.26109.1 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26004.1 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26206.0 | Required
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 15.0.26206.0 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.9.170119.3 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.26004.1 | Required
Microsoft.VisualStudio.ComponentGroup.Azure.Prerequisites | Azure development prerequisites | 15.0.26109.1 | Required
Component.WebSocket | WebSocket4Net | 15.0.26109.1 | Recommended
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake Tools | 15.0.26109.1 | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.MobileAppsSdk | Azure Mobile Apps SDK | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.ResourceManager.Tools | Azure Resource Manager core tools | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.ServiceFabric.Tools | Service Fabric Tools | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.0.26127.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Azure.Storage.AzCopy | Azure Storage AzCopy | 15.0.26206.0 | Optional
Microsoft.VisualStudio.Component.PowerShell.Tools | PowerShell tools | 3.0.427 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 15.0.26109.1 | Optional


## Data storage and processing

**ID:** Microsoft.VisualStudio.Workload.Data

**Description:** Connect, develop and test data solutions using SQL Server, Azure Data Lake, Hadoop or Azure ML.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Redgate.ReadyRoll | Redgate ReadyRoll | 1.13.21.2875 | Recommended
Component.Redgate.SQLPrompt.VsPackage | Redgate SQL Prompt | 7.4.0.464 | Recommended
Component.Redgate.SQLSearch.VSExtension | Redgate SQL Search | 2.3.9.1092 | Recommended
Component.WebSocket | WebSocket4Net | 15.0.26109.1 | Recommended
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake Tools | 15.0.26109.1 | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.26004.1 | Recommended
Microsoft.Component.MSBuild | MSBuild | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.9.170119.3 | Recommended
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.0.26127.0 | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.0.26206.0 | Optional


## .NET desktop development

**ID:** Microsoft.VisualStudio.Workload.ManagedDesktop

**Description:** Build WPF, Windows Forms and console applications using the .NET Framework.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.26004.1 | Required
Microsoft.Component.MSBuild | MSBuild | 15.0.26004.1 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26004.1 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26004.1 | Required
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.LiveUnitTesting | Live Unit Testing | 15.0.26206.0 | Recommended
Component.Dotfuscator | PreEmptive Protection - Dotfuscator | 15.0.26109.1 | Optional
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.CodeClone | Code Clone | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.CodeMap | Code Map | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.0.26206.0 | Optional
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26004.1 | Optional


## Game development with Unity

**ID:** Microsoft.VisualStudio.Workload.ManagedGame

**Description:** Create 2D and 3D games with Unity, a powerful cross-platform development environment.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Unity | Visual Studio Tools for Unity | 15.0.26206.0 | Required
Component.UnityEngine | Unity editor | 15.0.26109.1 | Recommended


## Linux development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeCrossPlat

**Description:** Create and debug applications running in a Linux environment.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.MDD.Linux | Visual C++ for Linux Development | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.0.26004.1 | Required


## Desktop development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeDesktop

**Description:** Build classic Windows-based applications using the power of the Visual C++ toolset, ATL, and optional features like MFC and C++/CLI.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.CodeMap | Code Map | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.VC.CMake.Project | Visual C++ tools for CMake | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.0.26127.0 | Recommended
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.VC.140 | VC++ 2015.3 v140 toolset (x86,x64) | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.VC.ATL | Visual C++ ATL support | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | MFC and ATL support (x86 and x64) | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.VC.ClangC2 | Clang/C2 (experimental) | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.VC.CLI.Support | C++/CLI support | 15.0.26206.0 | Optional
Microsoft.VisualStudio.Component.VC.Modules.x86.x64 | Standard Library Modules | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.0.26127.0 | Optional
Microsoft.VisualStudio.Component.WinXP | Windows XP support for C++ | 15.0.26109.1 | Optional


## Game development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeGame

**Description:** Use the full power of C++ to build professional games powered by DirectX, Unreal, or Cocos2d.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.0.26127.0 | Recommended
Component.Cocos | Cocos | 15.0.26109.1 | Optional
Component.Unreal | Unreal Engine installer | 15.0.26109.1 | Optional
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.0.26127.0 | Optional


## Mobile development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeMobile

**Description:** Build cross-platform applications for iOS, Android or Windows using C++.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26109.1 | Required
Component.Android.NDK.R13B | Android NDK (R13B) | 13.1.6 | Recommended
Component.Android.SDK19 | Android SDK setup (API level 19 and 21) | 15.0.26109.1 | Recommended
Component.Android.SDK22 | Android SDK setup (API level 22) | 15.0.26109.1 | Recommended
Component.Ant | Apache Ant (1.9.3) | 1.9.3.7 | Recommended
Component.MDD.Android | C++ Android development tools | 15.0.26109.1 | Recommended
Component.Android.Emulator | Visual Studio Emulator for Android | 15.0.26206.0 | Optional
Component.Android.NDK.R11C | Android NDK (R11C) | 11.3.13 | Optional
Component.Android.NDK.R11C_3264 | Android NDK (R11C) (32bit) | 11.3.14 | Optional
Component.Android.NDK.R12B | Android NDK (R12B) | 12.1.9 | Optional
Component.Android.NDK.R12B_3264 | Android NDK (R12B) (32bit) | 12.1.9 | Optional
Component.Android.NDK.R13B_3264 | Android NDK (R13B) (32bit) | 13.1.6 | Optional
Component.Android.SDK23 | Android SDK setup (API level 23) | 15.0.26109.1 | Optional
Component.Google.Android.Emulator.API23.V2 | Google Android Emulator (API Level 23) | 15.0.26109.1 | Optional
Component.HAXM | Intel Hardware Accelerated Execution Manager (HAXM) | 15.0.26206.0 | Optional
Component.JavaJDK | Java SE Development Kit (8.0.920.14) | 15.0.26004.1 | Optional
Component.MDD.IOS | C++ iOS development tools | 15.0.26109.1 | Optional


## .NET Core cross-platform development

**ID:** Microsoft.VisualStudio.Workload.NetCoreTools

**Description:** Build cross-platform applications using .NET Core, ASP.NET Core, HTML, JavaScript, and CSS

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.WebSocket | WebSocket4Net | 15.0.26109.1 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.26004.1 | Required
Microsoft.Component.MSBuild | MSBuild | 15.0.26004.1 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26004.1 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26004.1 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26004.1 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26206.0 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.9.170119.3 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.0.26206.0 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.0.26127.0 | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.0.26206.0 | Recommended


## Mobile development with .NET

**ID:** Microsoft.VisualStudio.Workload.NetCrossPlat

**Description:** Build cross-platform applications for iOS, Android or Windows using Xamarin.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.Xamarin | Xamarin | 15.0.26206.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26004.1 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.26109.1 | Required
Component.Android.NDK.R13B_3264 | Android NDK (R13B) (32bit) | 13.1.6 | Recommended
Component.Android.SDK23 | Android SDK setup (API level 23) | 15.0.26109.1 | Recommended
Component.Google.Android.Emulator.API23.V2 | Google Android Emulator (API Level 23) | 15.0.26109.1 | Recommended
Component.HAXM | Intel Hardware Accelerated Execution Manager (HAXM) | 15.0.26206.0 | Recommended
Component.JavaJDK | Java SE Development Kit (8.0.920.14) | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.26004.1 | Optional
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26206.0 | Optional
Microsoft.VisualStudio.Component.CodeClone | Code Clone | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.CodeMap | Code Map | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.Phone.Emulator | Windows 10 Mobile Emulator (Anniversary Edition) | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.0.26127.0 | Optional


## ASP.NET and web development

**ID:** Microsoft.VisualStudio.Workload.NetWeb

**Description:** Build web applications using ASP.NET, ASP.NET Core, HTML, JavaScript, and CSS.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.WebSocket | WebSocket4Net | 15.0.26109.1 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.26004.1 | Required
Microsoft.Component.MSBuild | MSBuild | 15.0.26004.1 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26004.1 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26004.1 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26004.1 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26206.0 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.9.170119.3 | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | 15.0.26206.0 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | 15.0.26127.0 | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26004.1 | Required
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26004.1 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.DockerTools | Container development tools | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.LiveUnitTesting | Live Unit Testing | 15.0.26206.0 | Recommended
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | 15.0.26109.1 | Recommended
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.CodeClone | Code Clone | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.CodeMap | Code Map | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.FSharp | F# language support | 15.0.26206.0 | Optional
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 15.0.26004.1 | Optional


## Node.js development

**ID:** Microsoft.VisualStudio.Workload.Node

**Description:** Build scalable network applications using Node.js, an asynchronous event-driven JavaScript runtime. 

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Node.Tools | Node.js support | 15.0.26206.0 | Required
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.9.170119.3 | Recommended
Microsoft.VisualStudio.Component.Git | Git for Windows | 15.0.26004.1 | Recommended
Component.WebSocket | WebSocket4Net | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26206.0 | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.26109.1 | Optional


## Universal Windows Platform development

**ID:** Microsoft.VisualStudio.Workload.Universal

**Description:** Create applications for the Universal Windows Platform with C#, VB, JavaScript, or optionally C﻿++.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.WebSocket | WebSocket4Net | 15.0.26109.1 | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.26004.1 | Required
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26206.0 | Required
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.0.26127.0 | Required
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 15.0.26004.1 | Recommended
Microsoft.Component.VC.Runtime.OSSupport | Visual C++ runtime for UWP | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.CodeClone | Code Clone | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.CodeMap | Code Map | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.Phone.Emulator | Windows 10 Mobile Emulator (Anniversary Edition) | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM | Visual C++ compilers and libraries for ARM | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.0.26004.1 | Optional


## Visual Studio extension development

**ID:** Microsoft.VisualStudio.Workload.VisualStudioExtension

**Description:** Create add-ons and extensions for Visual Studio, including new commands, code analyzers and tool windows.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.26004.1 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26004.1 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.CodeClone | Code Clone | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.CodeMap | Code Map | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | 15.0.26109.1 | Recommended
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | 15.0.26004.1 | Recommended
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | 15.0.26004.1 | Recommended
Component.Dotfuscator | PreEmptive Protection - Dotfuscator | 15.0.26109.1 | Optional
Microsoft.Component.MSBuild | MSBuild | 15.0.26004.1 | Optional
Microsoft.Component.VC.Runtime.OSSupport | Visual C++ runtime for UWP | 15.0.26004.1 | Optional
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26206.0 | Optional
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.DslTools | Modeling SDK | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.VC.ATL | Visual C++ ATL support | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | MFC and ATL support (x86 and x64) | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.VSSDK | Visual Studio SDK | 15.0.26206.0 | Optional


## Mobile development with JavaScript

**ID:** Microsoft.VisualStudio.Workload.WebCrossPlat

**Description:** Build Android, iOS and UWP apps using Tools for Apache Cordova.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Component.CordovaToolset.6.3.1 | Cordova 6.3.1 toolset | 15.0.26004.1 | Required
Component.WebSocket | WebSocket4Net | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.Cordova | Mobile development with JavaScript core features | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | 15.0.26109.1 | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | 15.0.26004.1 | Required
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | 15.0.26109.1 | Required
Component.Android.SDK23 | Android SDK setup (API level 23) | 15.0.26109.1 | Optional
Component.Google.Android.Emulator.API23.V2 | Google Android Emulator (API Level 23) | 15.0.26109.1 | Optional
Component.HAXM | Intel Hardware Accelerated Execution Manager (HAXM) | 15.0.26206.0 | Optional
Component.JavaJDK | Java SE Development Kit (8.0.920.14) | 15.0.26004.1 | Optional
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.26004.1 | Optional
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | 15.0.26206.0 | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.Git | Git for Windows | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.Phone.Emulator | Windows 10 Mobile Emulator (Anniversary Edition) | 15.0.26109.1 | Optional
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26004.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.0.26127.0 | Optional

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name | Version
--- | --- | ---
Component.GitHub.VisualStudio | GitHub extension for Visual Studio | 2.1.1.4
Microsoft.Component.Blend.SDK.WPF | Blend for Visual Studio SDK for .NET | 15.0.26004.1
Microsoft.Component.HelpViewer | Help Viewer | 15.0.26004.1
Microsoft.Net.Component.3.5.DeveloperTools | .NET Framework 3.5 development tools | 15.0.26004.1
Microsoft.VisualStudio.Component.DependencyValidation.Community | Dependency Validation | 15.0.26004.1
Microsoft.VisualStudio.Component.LinqToSql | LINQ to SQL tools | 15.0.26004.1
Microsoft.VisualStudio.Component.TestTools.Core | Testing tools core features | 15.0.26004.1
Microsoft.VisualStudio.Component.TypeScript.2.0 | TypeScript 2.0 SDK | 15.0.26004.1





## See also

* [Visual Studio workload and component IDs](workload-and-component-ids.md)
* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)