---
title: Visual Studio Build Tools 2017 workload and component IDs
description: "Use Visual Studio workload and component IDs to build classic Windows-based applications"
keywords:
author: TerryGLee
ms.author: tglee
manager: douge
ms.date: 03/05/2018
ms.topic: reference
helpviewer_keywords:
  - "workload ID, Visual Studio"
  - "component ID, Visual Studio"
  - "install Visual Studio, administrator guide"
ms.service:
ms.technology: vs-acquisition
ms.prod: visual-studio-dev15
ms.assetid: b99298df-0280-47fc-af73-44cd7a8ac553
ms.workload:
  - "multiple"
---
# Visual Studio Build Tools 2017 component directory

The tables on this page list the IDs that you can use to install Visual Studio by using the command line or that you can specify as a dependency in a VSIX manifest. Note that we will add additional components as we release updates to Visual Studio.

Also note the following about the page:

* Each workload has its own section, followed by the workload ID and a table of the components that are available for the workload.
* By default, the **Required** components will be installed when you install the workload.
* If you choose to, you can also install the **Recommended** and **Optional** components.
* We've also added a section that lists the additional components that are not affiliated with any workload.

When you set dependencies in your VSIX manifest, you must specify Component IDs only. Use the tables on this page to determine our minimum component dependencies. In some scenarios, this might mean that you specify only one component from a workload. In other scenarios, it might mean that you specify multiple components from a single workload or multiple components from multiple workloads. For more information, see the [How to: Migrate Extensibility Projects to Visual Studio 2017](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md) page.

For more information about how to use these IDs, see [Use Command-Line Parameters to Install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) page.

## Azure development build tools

**ID:** Microsoft.VisualStudio.Workload.AzureBuildTools

**Description:** MSBuild tasks and targets for building Azure applications.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.7.27520.0 | Required
Microsoft.VisualStudio.Component.Azure.AuthoringTools | Azure Authoring Tools | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.Azure.ClientLibs | Azure libraries for .NET | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Azure.Waverton.BuildTools | Azure Cloud Services build tools | 15.7.27617.1 | Required
Microsoft.VisualStudio.Component.DockerTools.BuildTools | Container development tools - Build Tools | 15.7.27617.1 | Required
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 15.0.26919.1 | Required
Microsoft.VisualStudio.Wcf.BuildTools.ComponentGroup | WCF development build tools | 15.6.27309.0 | Required
Microsoft.VisualStudio.Web.BuildTools.ComponentGroup | Web development build tools | 15.7.27604.0 | Required
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.6.27406.0 | Recommended
Microsoft.Net.Core.Component.SDK | .NET Core 2.0 development tools | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.AspNet45 | Advanced ASP.NET features | 15.7.27625.0 | Recommended
Microsoft.VisualStudio.Component.TypeScript.2.8 | TypeScript 2.8 SDK | 15.0.27617.1 | Recommended
Microsoft.Net.Component.3.5.DeveloperTools | .NET Framework 3.5 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.6.27406.0 | Optional

## .NET desktop build tools

**ID:** Microsoft.VisualStudio.Workload.ManagedDesktopBuildTools

**Description:** Tools for building WPF, Windows Forms, and console applications using C#, Visual Basic, and F#.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 15.0.26919.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.Component.ClickOnce.MSBuild | ClickOnce Build Tools | 15.7.27617.1 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.6.27406.0 | Recommended
Microsoft.Net.Core.Component.SDK | .NET Core 2.0 development tools | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.TestTools.BuildTools | Testing tools core features - Build Tools | 15.7.27625.0 | Recommended
Microsoft.VisualStudio.Wcf.BuildTools.ComponentGroup | WCF development build tools | 15.6.27309.0 | Recommended
Microsoft.Net.Component.3.5.DeveloperTools | .NET Framework 3.5 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.FSharp.MSBuild | F# compiler | 15.7.27604.0 | Optional

## MSBuild Tools

**ID:** Microsoft.VisualStudio.Workload.MSBuildTools

**Description:** Provides the tools required to build MSBuild-based applications.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.VisualStudio.Component.CoreBuildTools | Visual Studio Build Tools Core | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required

## .NET Core build tools

**ID:** Microsoft.VisualStudio.Workload.NetCoreBuildTools

**Description:** Tools for building applications using .NET Core, ASP.NET Core, HTML/JavaScript, and Containers.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Net.Core.Component.SDK | .NET Core 2.0 development tools | 15.6.27406.0 | Required
Microsoft.NetCore.BuildTools.ComponentGroup | .NET Core build tools | 15.7.27617.1 | Required
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 15.0.26919.1 | Required
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools | 15.6.27406.0 | Optional

## Node.js build tools

**ID:** Microsoft.VisualStudio.Workload.NodeBuildTools

**Description:** Build scalable network applications using Node.js, an asynchronous event-driven JavaScript runtime. 

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.Node.Build | Node.js support | 15.6.27406.0 | Required

## Office/SharePoint build tools

**ID:** Microsoft.VisualStudio.Workload.OfficeBuildTools

**Description:** Build Office and SharePoint add-ins, and VSTO add-ins.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.ClickOnce.MSBuild | ClickOnce Build Tools | 15.7.27617.1 | Required
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.7.27520.0 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 15.0.26919.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Sharepoint.BuildTools | Office/SharePoint development build tools | 15.7.27617.1 | Required
Microsoft.VisualStudio.Wcf.BuildTools.ComponentGroup | WCF development build tools | 15.6.27309.0 | Required
Microsoft.VisualStudio.Web.BuildTools.ComponentGroup | Web development build tools | 15.7.27604.0 | Required
Microsoft.VisualStudio.Component.TeamOffice.BuildTools | Visual Studio Tools for Office (VSTO) build tools | 15.7.27617.1 | Recommended
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.6.27406.0 | Optional

## Universal Windows Platform build tools

**ID:** Microsoft.VisualStudio.Workload.UniversalBuildTools

**Description:** Provides the tools required to build Universal Windows Platform applications.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.Component.NetFX.Native | .NET Native | 15.0.26208.0 | Required
Microsoft.Component.VC.Runtime.OSSupport | Visual C++ runtime for UWP | 15.6.27406.0 | Required
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 15.0.26919.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.VC.Tools.ARM | Visual C++ compilers and libraries for ARM | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 version 15.7 v14.14 latest v141 tools | 15.7.27625.0 | Required
Microsoft.VisualStudio.ComponentGroup.UWP.BuildTools | Universal Windows Platform build prerequisites | 15.7.27703.1 | Required
Microsoft.VisualStudio.Component.Windows10SDK.17134 | Windows 10 SDK (10.0.17134.0) | 15.7.27703.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP | Windows 10 SDK (10.0.15063.0) for UWP: C#, VB, JS | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.6.27406.0 | Optional

## Visual C++ build tools

**ID:** Microsoft.VisualStudio.Workload.VCTools

**Description:** Build Windows desktop applications using the Microsoft C++ toolset, ATL, or MFC.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.VC.CoreBuildTools | Visual C++ Build Tools core features | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.VC.Redist.14.Latest | Visual C++ 2017 Redistributable Update | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 version 15.7 v14.14 latest v141 tools | 15.7.27625.0 | Required
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.TestTools.BuildTools | Testing tools core features - Build Tools | 15.7.27625.0 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.17134 | Windows 10 SDK (10.0.17134.0) | 15.7.27703.1 | Recommended
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.6.27309.0 | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.VC.140 | VC++ 2015.3 v14.00 (v140) toolset for desktop | 15.7.27617.1 | Optional
Microsoft.VisualStudio.Component.VC.ATL | Visual C++ ATL for x86 and x64 | 15.7.27625.0 | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | Visual C++ MFC for x86 and x64 | 15.7.27625.0 | Optional
Microsoft.VisualStudio.Component.VC.CLI.Support | C++/CLI support | 15.6.27309.0 | Optional
Microsoft.VisualStudio.Component.VC.Modules.x86.x64 | Modules for Standard Library (experimental) | 15.6.27309.0 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM | Visual C++ compilers and libraries for ARM | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM64 | Visual C++ compilers and libraries for ARM64 | 15.6.27309.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.Desktop | Windows 10 SDK (10.0.15063.0) for Desktop C++ [x86 and x64] | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP | Windows 10 SDK (10.0.15063.0) for UWP: C#, VB, JS | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP.Native | Windows 10 SDK (10.0.15063.0) for UWP: C++ | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop | Windows 10 SDK (10.0.16299.0) for Desktop C++ [x86 and x64] | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.6.27406.0 | Optional
Microsoft.VisualStudio.Component.WinXP | Windows XP support for C++ | 15.7.27703.1 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Win81 | Windows 8.1 SDK and UCRT SDK | 15.6.27406.0 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.WinXP | Windows XP support for C++ | 15.7.27703.1 | Optional

## Web development build tools

**ID:** Microsoft.VisualStudio.Workload.WebBuildTools

**Description:** MSBuild tasks and targets for building web applications.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.7.27520.0 | Required
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 15.0.26919.1 | Required
Microsoft.VisualStudio.Web.BuildTools.ComponentGroup | Web development build tools | 15.7.27604.0 | Required
Microsoft.Component.ClickOnce.MSBuild | ClickOnce Build Tools | 15.7.27617.1 | Recommended
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.6.27406.0 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.6.27406.0 | Recommended
Microsoft.Net.Core.Component.SDK | .NET Core 2.0 development tools | 15.6.27406.0 | Recommended
Microsoft.VisualStudio.Component.AspNet45 | Advanced ASP.NET features | 15.7.27625.0 | Recommended
Microsoft.VisualStudio.Component.DockerTools.BuildTools | Container development tools - Build Tools | 15.7.27617.1 | Recommended
Microsoft.VisualStudio.Component.TestTools.BuildTools | Testing tools core features - Build Tools | 15.7.27625.0 | Recommended
Microsoft.VisualStudio.Component.TypeScript.2.8 | TypeScript 2.8 SDK | 15.0.27617.1 | Recommended
Microsoft.VisualStudio.Wcf.BuildTools.ComponentGroup | WCF development build tools | 15.6.27309.0 | Recommended
Microsoft.Net.Component.3.5.DeveloperTools | .NET Framework 3.5 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.6.27406.0 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.6.27406.0 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.6.27406.0 | Optional
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools | 15.6.27406.0 | Optional

## Mobile Development with .NET

**ID:** Microsoft.VisualStudio.Workload.XamarinBuildTools

**Description:** Tools for building cross-platform applications for iOS, Android and Windows using C# and F#.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 15.7.27520.0 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.6.27406.0 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.6.27406.0 | Required
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 15.0.26919.1 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.6.27309.0 | Required
Component.JavaJDK | Java SE Development Kit (8.0.1120.15) | 15.6.27406.0 | Recommended
Component.Android.SDK25 | Android SDK setup (API level 25) | 15.6.27413.0 | Optional

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name | Version
--- | --- | ---
Microsoft.VisualStudio.Component.TypeScript.2.0 | TypeScript 2.0 SDK | 15.6.27406.0
Microsoft.VisualStudio.Component.TypeScript.2.1 | TypeScript 2.1 SDK | 15.6.27406.0
Microsoft.VisualStudio.Component.TypeScript.2.2 | TypeScript 2.2 SDK | 15.6.27406.0
Microsoft.VisualStudio.Component.TypeScript.2.3 | TypeScript 2.3 SDK | 15.6.27406.0
Microsoft.VisualStudio.Component.TypeScript.2.5 | TypeScript 2.5 SDK | 15.6.27406.0
Microsoft.VisualStudio.Component.TypeScript.2.6 | TypeScript 2.6 SDK | 15.0.27520.0
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
Microsoft.VisualStudio.Component.VC.Runtimes.ARM.Spectre | VC++ 2017 version 15.7 v14.14 Libs for Spectre (ARM) | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.Runtimes.ARM64.Spectre | VC++ 2017 version 15.7 v14.14 Libs for Spectre (ARM64) | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.Runtimes.x86.x64.Spectre | VC++ 2017 version 15.7 v14.14 Libs for Spectre (x86 and x64) | 15.7.27625.0
Microsoft.VisualStudio.Component.VC.Tools.14.11 | VC++ 2017 version 15.4 v14.11 toolset | 15.0.27406.0
Microsoft.VisualStudio.Component.VC.Tools.14.12 | VC++ 2017 version 15.5 v14.12 toolset | 15.0.27406.0
Microsoft.VisualStudio.Component.VC.Tools.14.13 | VC++ 2017 version 15.6 v14.13 toolset | 15.0.27625.0

## Get support

Sometimes, things can go wrong. If your Visual Studio installation fails, see the [Troubleshooting Visual Studio 2017 installation and upgrade issues](troubleshooting-installation-issues.md) page. If none of the troubleshooting steps help, you can contact us by live chat for installation assistance (English only). For details, see the [Visual Studio support page](https://www.visualstudio.com/vs/support/#talktous).

Here are a few more support options:

* You can report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio-2017.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* You can share a product suggestion with us on [UserVoice](https://visualstudio.uservoice.com/forums/121579).
* You can track product issues and find answers in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/).
* You can also engage with us and other Visual Studio developers through the [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio). (This option requires a [GitHub](https://github.com/) account.)

## See also

* [Visual Studio workload and component IDs](workload-and-component-ids.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
  * [Command-line parameter examples](command-line-parameter-examples.md)
* [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)
