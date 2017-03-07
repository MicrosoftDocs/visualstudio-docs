---
title: [Visual Studio Professional 2017 workload and component IDs | Microsoft Docs]
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
ms.assetid: 5719032b-2c2e-416e-a281-a4573ec74e38
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

# Visual Studio Professional 2017 component directory

The tables on this page list the IDs that you can use to install Visual Studio by using the command line or that you can specify as a dependency in a VSIX manifest. Note that we will add additional components as we release updates to Visual Studio.

Also note the following about the page:

* Each workload has its own section, followed by the workload ID and a table of the components that are available for the workload.
* By default, the **Required** components will be installed when you install the workload. If you choose to, you can also install the **Recommended** and **Optional** components.
* We’ve also added a section that lists the additional components that are not affiliated with any workload.

When you set dependencies in your VSIX manifest, you must specify Component IDs only. Use the tables on this page to determine our minimum component dependencies. In some scenarios, this might mean that you specify only one component from a workload. In other scenarios, it might mean that you specify multiple components from a single workload or multiple components from multiple workloads. For more information, see the [How to: Migrate Extensibility Projects to Visual Studio 2017](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md) page.

For more information about how to use these IDs, see [Use Command-Line Parameters to Install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) page.

## Visual Studio core editor (included with Visual Studio Professional 2017)

**ID:** Microsoft.VisualStudio.Workload.CoreEditor

**Description:** The Visual Studio core shell experience, including syntax-aware code editing, source code control and work item management.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.VisualStudio.Component.CoreEditor | Visual Studio core editor | Required


## Azure development

**ID:** Microsoft.VisualStudio.Workload.Azure

**Description:** Azure SDK, tools, and projects for developing cloud apps and creating resources.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.Component.MSBuild | MSBuild | Required
Microsoft.Component.NetFX.Core.Runtime | .NET Core runtime | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | Required
Microsoft.Net.Core.Component.SDK | .NET Core 1.0.1 development tools | Required
Microsoft.NetCore.ComponentGroup.Web | .NET Core 1.0 - 1.1 development tools | Required
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | Required
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Required
Microsoft.VisualStudio.ComponentGroup.Azure.Prerequisites | Azure development prerequisites | Required
Component.WebSocket | WebSocket4Net | Recommended
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake Tools | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | Recommended
Microsoft.VisualStudio.Component.Azure.MobileAppsSdk | Azure Mobile Apps SDK | Recommended
Microsoft.VisualStudio.Component.Azure.ResourceManager.Tools | Azure Resource Manager core tools | Recommended
Microsoft.VisualStudio.Component.Azure.ServiceFabric.Tools | Service Fabric Tools | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | Recommended
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | Recommended
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | Recommended
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | Recommended
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | Recommended
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | Recommended
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | Recommended
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | Recommended
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | Recommended
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | Recommended
Microsoft.VisualStudio.ComponentGroup.Azure.CloudServices | Azure Cloud Services tools | Recommended
Microsoft.VisualStudio.ComponentGroup.Azure.ResourceManager.Tools | Azure Resource Manager tools | Recommended
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | Optional
Microsoft.VisualStudio.Component.Azure.Storage.AzCopy | Azure Storage AzCopy | Optional
Microsoft.VisualStudio.Component.PowerShell.Tools | PowerShell tools | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | Optional


## Data storage and processing

**ID:** Microsoft.VisualStudio.Workload.Data

**Description:** Connect, develop and test data solutions using SQL Server, Azure Data Lake, Hadoop or Azure ML.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Component.Redgate.ReadyRoll | Redgate ReadyRoll | Recommended
Component.Redgate.SQLPrompt.VsPackage | Redgate SQL Prompt | Recommended
Component.Redgate.SQLSearch.VSExtension | Redgate SQL Search | Recommended
Component.WebSocket | WebSocket4Net | Recommended
Microsoft.Component.Azure.DataLake.Tools | Azure Data Lake Tools | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | Recommended
Microsoft.Component.MSBuild | MSBuild | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | Recommended
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | Recommended
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | Recommended
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | Recommended
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | Recommended
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | Recommended
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | Recommended
Microsoft.VisualStudio.Component.Azure.Compute.Emulator | Azure Compute Emulator | Recommended
Microsoft.VisualStudio.Component.Azure.Storage.Emulator | Azure Storage Emulator | Recommended
Microsoft.VisualStudio.Component.Azure.Waverton | Azure Cloud Services core tools | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | Recommended
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | Recommended
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | Recommended
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | Recommended
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | Recommended
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | Recommended
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | Recommended
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | Recommended
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | Recommended
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | Recommended
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | Recommended
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | Recommended
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Recommended
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | Recommended
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | Recommended
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | Recommended
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | Recommended
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | Recommended
Microsoft.VisualStudio.Component.FSharp | F# language support | Optional


## .NET desktop development

**ID:** Microsoft.VisualStudio.Workload.ManagedDesktop

**Description:** Build WPF, Windows Forms and console applications using the .NET Framework.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.Component.ClickOnce | ClickOnce Publishing | Required
Microsoft.Component.MSBuild | MSBuild | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | Required
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Prerequisites | .NET desktop development tools | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | Required
Microsoft.ComponentGroup.Blend | Blend for Visual Studio | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | Recommended
Microsoft.VisualStudio.Component.LiveUnitTesting | Live Unit Testing | Recommended
Component.Dotfuscator | PreEmptive Protection - Dotfuscator | Optional
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | Optional
Microsoft.Net.Core.Component.SDK | .NET Core 1.0.1 development tools | Optional
Microsoft.NetCore.ComponentGroup.DevelopmentTools | .NET Core 1.0 - 1.1 development tools | Optional
Microsoft.VisualStudio.Component.CodeClone | Code Clone | Optional
Microsoft.VisualStudio.Component.CodeMap | Code Map | Optional
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | Optional
Microsoft.VisualStudio.Component.FSharp | F# language support | Optional
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | Optional
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | Optional
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | Optional
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | Optional
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | Optional
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | Optional
Microsoft.VisualStudio.ComponentGroup.ArchitectureTools.Managed | Architecture and analysis tools | Optional


## Game development with Unity

**ID:** Microsoft.VisualStudio.Workload.ManagedGame

**Description:** Create 2D and 3D games with Unity, a powerful cross-platform development environment.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Required
Microsoft.VisualStudio.Component.Unity | Visual Studio Tools for Unity | Required
Component.UnityEngine | Unity editor | Recommended


## Linux development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeCrossPlat

**Description:** Create and debug applications running in a Linux environment.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Component.MDD.Linux | Visual C++ for Linux Development | Required
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | Required
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | Required


## Desktop development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeDesktop

**Description:** Build classic Windows-based applications using the power of the Visual C++ toolset, ATL, and optional features like MFC and C++/CLI.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.Component.MSBuild | MSBuild | Required
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | Required
Microsoft.VisualStudio.Component.CodeMap | Code Map | Required
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | Required
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | Required
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | Required
Microsoft.VisualStudio.ComponentGroup.ArchitectureTools.Native | Architecture tools for C++ | Required
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Core | Visual C++ core desktop features | Required
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | Recommended
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Recommended
Microsoft.VisualStudio.Component.VC.CMake.Project | Visual C++ tools for CMake | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | Recommended
Component.Incredibuild | IncrediBuild | Optional
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | Optional
Microsoft.VisualStudio.Component.VC.140 | VC++ 2015.3 v140 toolset (x86,x64) | Optional
Microsoft.VisualStudio.Component.VC.ATL | Visual C++ ATL support | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | MFC and ATL support (x86 and x64) | Optional
Microsoft.VisualStudio.Component.VC.ClangC2 | Clang/C2 (experimental) | Optional
Microsoft.VisualStudio.Component.VC.CLI.Support | C++/CLI support | Optional
Microsoft.VisualStudio.Component.VC.Modules.x86.x64 | Standard Library Modules | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | Optional
Microsoft.VisualStudio.Component.WinXP | Windows XP support for C++ | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Win81 | Windows 8.1 SDK and UCRT SDK | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.WinXP | Windows XP support for C++ | Optional


## Game development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeGame

**Description:** Use the full power of C++ to build professional games powered by DirectX, Unreal, or Cocos2d.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | Required
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | Recommended
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Recommended
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | Recommended
Microsoft.VisualStudio.Component.VC.DiagnosticTools | C++ profiling tools | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | Recommended
Component.Cocos | Cocos | Optional
Component.Incredibuild | IncrediBuild | Optional
Component.Unreal | Unreal Engine installer | Optional
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | Optional
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | Optional
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | Optional
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | Optional
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | Optional
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | Optional
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | Optional
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | Optional
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Optional
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Win81 | Windows 8.1 SDK and UCRT SDK | Optional


## Mobile development with C++

**ID:** Microsoft.VisualStudio.Workload.NativeMobile

**Description:** Build cross-platform applications for iOS, Android or Windows using C++.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | Required
Component.Android.NDK.R13B | Android NDK (R13B) | Recommended
Component.Android.SDK19 | Android SDK setup (API level 19 and 21) | Recommended
Component.Android.SDK22 | Android SDK setup (API level 22) | Recommended
Component.Ant | Apache Ant (1.9.3) | Recommended
Component.MDD.Android | C++ Android development tools | Recommended
Component.Android.Emulator | Visual Studio Emulator for Android | Optional
Component.Android.NDK.R11C | Android NDK (R11C) | Optional
Component.Android.NDK.R11C_3264 | Android NDK (R11C) (32bit) | Optional
Component.Android.NDK.R12B | Android NDK (R12B) | Optional
Component.Android.NDK.R12B_3264 | Android NDK (R12B) (32bit) | Optional
Component.Android.NDK.R13B_3264 | Android NDK (R13B) (32bit) | Optional
Component.Android.SDK23 | Android SDK setup (API level 23) | Optional
Component.Google.Android.Emulator.API23.V2 | Google Android Emulator (API Level 23) | Optional
Component.HAXM | Intel Hardware Accelerated Execution Manager (HAXM) | Optional
Component.Incredibuild | IncrediBuild | Optional
Component.JavaJDK | Java SE Development Kit (8.0.920.14) | Optional
Component.MDD.IOS | C++ iOS development tools | Optional


## .NET Core cross-platform development

**ID:** Microsoft.VisualStudio.Workload.NetCoreTools

**Description:** Build cross-platform applications using .NET Core, ASP.NET Core, HTML, JavaScript, and CSS

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Component.WebSocket | WebSocket4Net | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | Required
Microsoft.Component.MSBuild | MSBuild | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | Required
Microsoft.Net.Core.Component.SDK | .NET Core 1.0.1 development tools | Required
Microsoft.NetCore.ComponentGroup.Web | .NET Core 1.0 - 1.1 development tools | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | Required
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | Required
Microsoft.VisualStudio.Component.DockerTools | Container development tools | Recommended


## Mobile development with .NET

**ID:** Microsoft.VisualStudio.Workload.NetCrossPlat

**Description:** Build cross-platform applications for iOS, Android or Windows using Xamarin.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | Required
Component.Android.NDK.R13B | Android NDK (R13B) | Recommended
Component.Android.SDK23 | Android SDK setup (API level 23) | Recommended
Component.Google.Android.Emulator.API23.V2 | Google Android Emulator (API Level 23) | Recommended
Component.HAXM | Intel Hardware Accelerated Execution Manager (HAXM) | Recommended
Component.JavaJDK | Java SE Development Kit (8.0.920.14) | Recommended
Component.Xamarin | Xamarin | Recommended
Component.Xamarin.Inspector | Xamarin Workbooks | Recommended
Component.Xamarin.Profiler | Xamarin Profiler | Recommended
Component.Xamarin.RemotedSimulator | Xamarin Remoted Simulator | Recommended
Microsoft.VisualStudio.Component.FSharp | F# language support | Recommended
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | Recommended
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Recommended
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | Recommended
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Recommended
Microsoft.Component.ClickOnce | ClickOnce Publishing | Optional
Microsoft.Component.NetFX.Native | .NET Native | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | Optional
Microsoft.VisualStudio.Component.CodeClone | Code Clone | Optional
Microsoft.VisualStudio.Component.CodeMap | Code Map | Optional
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | Optional
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | Optional
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | Optional
Microsoft.VisualStudio.Component.Phone.Emulator | Windows 10 Mobile Emulator (Anniversary Edition) | Optional
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | Optional
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | Optional
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | Optional
Microsoft.VisualStudio.ComponentGroup.ArchitectureTools.Managed | Architecture and analysis tools | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.Xamarin | Universal Windows Platform tools for Xamarin (2.0) | Optional


## ASP.NET and web development

**ID:** Microsoft.VisualStudio.Workload.NetWeb

**Description:** Build web applications using ASP.NET, ASP.NET Core, HTML, JavaScript, and CSS.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Component.WebSocket | WebSocket4Net | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | Required
Microsoft.Component.MSBuild | MSBuild | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | Required
Microsoft.Net.Core.Component.SDK | .NET Core 1.0.1 development tools | Required
Microsoft.NetCore.ComponentGroup.Web | .NET Core 1.0 - 1.1 development tools | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | Required
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | Required
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | Recommended
Microsoft.VisualStudio.Component.CloudExplorer | Cloud Explorer | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | Recommended
Microsoft.VisualStudio.Component.DockerTools | Container development tools | Recommended
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | Recommended
Microsoft.VisualStudio.Component.LiveUnitTesting | Live Unit Testing | Recommended
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | Recommended
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | Optional
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | Optional
Microsoft.VisualStudio.Component.CodeClone | Code Clone | Optional
Microsoft.VisualStudio.Component.CodeMap | Code Map | Optional
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | Optional
Microsoft.VisualStudio.Component.FSharp | F# language support | Optional
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | Optional
Microsoft.VisualStudio.ComponentGroup.ArchitectureTools.Managed | Architecture and analysis tools | Optional
Microsoft.VisualStudio.Web.Mvc4.ComponentGroup | ASP.NET MVC 4 | Optional


## Node.js development

**ID:** Microsoft.VisualStudio.Workload.Node

**Description:** Build scalable network applications using Node.js, an asynchronous event-driven JavaScript runtime.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | Required
Microsoft.VisualStudio.Component.Node.Tools | Node.js support | Required
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | Recommended
Microsoft.VisualStudio.Component.Git | Git for Windows | Recommended
Component.WebSocket | WebSocket4Net | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | Optional
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | Optional
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | Optional


## Office/SharePoint development

**ID:** Microsoft.VisualStudio.Workload.Office

**Description:** Create Office and SharePoint add-ins, SharePoint solutions, and VSTO add-ins using C#, VB, and JavaScript.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Component.WebSocket | WebSocket4Net | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | Required
Microsoft.Component.MSBuild | MSBuild | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | Required
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | Required
Microsoft.VisualStudio.Component.Debugger.JustInTime | Just-In-Time debugger | Required
Microsoft.VisualStudio.Component.IISExpress | IIS Express  | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Core | Managed Desktop Workload Core | Required
Microsoft.VisualStudio.Component.ManagedDesktop.Prerequisites | .NET desktop development tools | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | Required
Microsoft.VisualStudio.Component.Sharepoint.Tools | Office Developer Tools for Visual Studio | Required
Microsoft.VisualStudio.Component.SQL.ADAL | SQL ADAL runtime | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | Required
Microsoft.VisualStudio.Component.SQL.CMDUtils | SQL Server Command Line Utilities | Required
Microsoft.VisualStudio.Component.SQL.DataSources | Data sources for SQL Server support | Required
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | Required
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | Required
Microsoft.VisualStudio.Component.SQL.SSDT | SQL Server Data Tools | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Required
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | Required
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | Required
Microsoft.VisualStudio.Component.Wcf.Tooling | Windows Communication Foundation | Required
Microsoft.VisualStudio.Component.Web | ASP.NET and web development tools | Required
Microsoft.VisualStudio.Component.WebDeploy | Web Deploy | Required
Microsoft.VisualStudio.Component.Workflow | Windows Workflow Foundation | Required
Microsoft.VisualStudio.Component.TeamOffice | Visual Studio Tools for Office (VSTO) | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | Optional


## Universal Windows Platform development

**ID:** Microsoft.VisualStudio.Workload.Universal

**Description:** Create applications for the Universal Windows Platform with C#, VB, JavaScript, or optionally C﻿++.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Component.WebSocket | WebSocket4Net | Required
Microsoft.Component.ClickOnce | ClickOnce Publishing | Required
Microsoft.Component.NetFX.Native | .NET Native | Required
Microsoft.ComponentGroup.Blend | Blend for Visual Studio | Required
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | Required
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | Required
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Required
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | Required
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Required
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | Required
Microsoft.VisualStudio.Component.UWP.Support | Universal Windows Platform tools (2.0) | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | Required
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | Required
Microsoft.VisualStudio.ComponentGroup.UWP.Cordova | Universal Windows Platform tools for Cordova (2.0) | Required
Microsoft.VisualStudio.ComponentGroup.UWP.Xamarin | Universal Windows Platform tools for Xamarin (2.0) | Required
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | Recommended
Microsoft.Component.VC.Runtime.OSSupport | Visual C++ runtime for UWP | Optional
Microsoft.VisualStudio.Component.CodeClone | Code Clone | Optional
Microsoft.VisualStudio.Component.CodeMap | Code Map | Optional
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | Optional
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | Optional
Microsoft.VisualStudio.Component.Graphics.Tools | Graphics debugger and GPU profiler for DirectX | Optional
Microsoft.VisualStudio.Component.Graphics.Win81 | Graphics Tools Windows 8.1 SDK | Optional
Microsoft.VisualStudio.Component.Phone.Emulator | Windows 10 Mobile Emulator (Anniversary Edition) | Optional
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | Optional
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM | Visual C++ compilers and libraries for ARM | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | Optional
Microsoft.VisualStudio.ComponentGroup.ArchitectureTools.Managed | Architecture and analysis tools | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.VC | C++ Universal Windows Platform tools | Optional


## Visual Studio extension development

**ID:** Microsoft.VisualStudio.Workload.VisualStudioExtension

**Description:** Create add-ons and extensions for Visual Studio, including new commands, code analyzers and tool windows.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.Component.ClickOnce | ClickOnce Publishing | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | Required
Microsoft.VisualStudio.Component.PortableLibrary | .NET Portable Library targeting pack | Required
Microsoft.VisualStudio.ComponentGroup.VisualStudioExtension.Prerequisites | Visual Studio extension development prerequisites | Required
Microsoft.VisualStudio.Component.CodeClone | Code Clone | Recommended
Microsoft.VisualStudio.Component.CodeMap | Code Map | Recommended
Microsoft.VisualStudio.Component.DependencyValidation.Enterprise | Live Dependency Validation | Recommended
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | Recommended
Microsoft.VisualStudio.Component.GraphDocument | DGML editor | Recommended
Microsoft.VisualStudio.Component.IntelliTrace.FrontEnd | IntelliTrace | Recommended
Microsoft.VisualStudio.Component.SQL.LocalDB.Runtime | SQL Server Express 2016 LocalDB | Recommended
Microsoft.VisualStudio.Component.SQL.NCLI | SQL Server Native Client | Recommended
Microsoft.VisualStudio.ComponentGroup.ArchitectureTools.Managed | Architecture and analysis tools | Recommended
Component.Dotfuscator | PreEmptive Protection - Dotfuscator | Optional
Microsoft.Component.MSBuild | MSBuild | Optional
Microsoft.Component.VC.Runtime.OSSupport | Visual C++ runtime for UWP | Optional
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | Optional
Microsoft.VisualStudio.Component.ClassDesigner | Class Designer | Optional
Microsoft.VisualStudio.Component.DslTools | Modeling SDK | Optional
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Optional
Microsoft.VisualStudio.Component.Roslyn.LanguageServices | C# and Visual Basic | Optional
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Optional
Microsoft.VisualStudio.Component.TextTemplating | Text Template Transformation | Optional
Microsoft.VisualStudio.Component.VC.ATL | Visual C++ ATL support | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | MFC and ATL support (x86 and x64) | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | Optional
Microsoft.VisualStudio.Component.VSSDK | Visual Studio SDK | Optional


## Mobile development with JavaScript

**ID:** Microsoft.VisualStudio.Workload.WebCrossPlat

**Description:** Build Android, iOS and UWP apps using Tools for Apache Cordova.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Component.CordovaToolset.6.3.1 | Cordova 6.3.1 toolset | Required
Component.WebSocket | WebSocket4Net | Required
Microsoft.VisualStudio.Component.Cordova | Mobile development with JavaScript core features | Required
Microsoft.VisualStudio.Component.JavaScript.Diagnostics | JavaScript diagnostics | Required
Microsoft.VisualStudio.Component.JavaScript.TypeScript | JavaScript and TypeScript language support | Required
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | Required
Component.Android.SDK23 | Android SDK setup (API level 23) | Optional
Component.Google.Android.Emulator.API23.V2 | Google Android Emulator (API Level 23) | Optional
Component.HAXM | Intel Hardware Accelerated Execution Manager (HAXM) | Optional
Component.JavaJDK | Java SE Development Kit (8.0.920.14) | Optional
Microsoft.Component.ClickOnce | ClickOnce Publishing | Optional
Microsoft.Component.NetFX.Native | .NET Native | Optional
Microsoft.VisualStudio.Component.AppInsights.Tools | Developer Analytics tools | Optional
Microsoft.VisualStudio.Component.DiagnosticTools | Profiling tools | Optional
Microsoft.VisualStudio.Component.Git | Git for Windows | Optional
Microsoft.VisualStudio.Component.Graphics | Image and 3D model editors | Optional
Microsoft.VisualStudio.Component.Phone.Emulator | Windows 10 Mobile Emulator (Anniversary Edition) | Optional
Microsoft.VisualStudio.Component.SQL.CLR | CLR data types for SQL Server | Optional
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | Optional
Microsoft.VisualStudio.ComponentGroup.UWP.Cordova | Universal Windows Platform tools for Cordova (2.0) | Optional

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name
--- | ---
Component.GitHub.VisualStudio | GitHub extension for Visual Studio
Microsoft.Component.Blend.SDK.WPF | Blend for Visual Studio SDK for .NET
Microsoft.Component.HelpViewer | Help Viewer
Microsoft.Net.Component.3.5.DeveloperTools | .NET Framework 3.5 development tools
Microsoft.VisualStudio.Component.DependencyValidation.Community | Dependency Validation
Microsoft.VisualStudio.Component.LinqToSql | LINQ to SQL tools
Microsoft.VisualStudio.Component.TestTools.Core | Testing tools core features
Microsoft.VisualStudio.Component.TypeScript.2.0 | TypeScript 2.0 SDK

## See also

* [Visual Studio workload and component IDs](workload-and-component-ids.md)
* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)
