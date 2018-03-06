---
title: Visual Studio Build Tools 2017 workload and component IDs | Microsoft Docs
description: "Use Visual Studio workload and component IDs to build classic Windows-based applications"
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
ms.assetid: b99298df-0280-47fc-af73-44cd7a8ac553
ms.workload: 
  - "multiple"
---

# Visual Studio Build Tools 2017 component directory

The tables on this page list the IDs that you can use to install Visual Studio by using the command line. Note that we will add additional components as we release updates to Visual Studio.

Also note the following about this page:

* Each workload has its own section, followed by the workload ID and a table of the components that are available for the workload.
* By default, the **Required** components will be installed when you install the workload. If you choose to, you can also install the **Recommended** and **Optional** components.
* We've also added a section that lists the additional components that are not affiliated with any workload.

For more information about how to use these IDs, see [Use Command-Line Parameters to Install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) page.

## MSBuild Tools

**ID:** Microsoft.VisualStudio.Workload.MSBuildTools

**Description:** Provides the tools required to build MSBuild-based applications.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.CoreBuildTools | Visual Studio Build Tools Core | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.FSharp.MSBuild | F# compiler | 15.0.27019.1 | Optional

## .NET Core build tools

**ID:** Microsoft.VisualStudio.Workload.NetCoreBuildTools

**Description:** Tools for building .NET Core applications.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Net.Core.Component.SDK | .NET Core 1.0 - 1.1 development tools | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 15.0.26919.1 | Required
Microsoft.Net.Core.Component.SDK.1x | .NET Core 1.0 - 1.1 development tools for Desktop | 15.0.26919.1 | Optional

## Visual C++ build tools

**ID:** Microsoft.VisualStudio.Workload.VCTools

**Description:** Build classic Windows-based applications using the power of the Visual C++ toolset, ATL, and optional features like MFC and C++/CLI.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.VC.CoreBuildTools | Visual C++ Build Tools core features | 15.0.27005.2 | Required
Microsoft.VisualStudio.Component.VC.Redist.14.Latest | Visual C++ 2017 Redistributable Update | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | 15.0.26621.2 | Required
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | 15.0.26208.0 | Recommended
Microsoft.VisualStudio.Component.VC.CMake.Project | Visual C++ tools for CMake | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | 15.0.27019.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop | Windows 10 SDK (10.0.16299.0) for Desktop C++ [x86 and x64] | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.0.27128.1 | Recommended
Microsoft.VisualStudio.ComponentGroup.WebToolsExtensions | ASP.NET and web development | 15.0.27005.2 | Recommended
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | 15.0.27019.1 | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Optional
Microsoft.VisualStudio.Component.VC.140 | VC++ 2015.3 v140 toolset for desktop (x86,x64) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.ATL | Visual C++ ATL support | 15.0.26823.1 | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | MFC and ATL support (x86 and x64) | 15.0.27005.2 | Optional
Microsoft.VisualStudio.Component.VC.ClangC2 | Clang/C2 (experimental) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.CLI.Support | C++/CLI support | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.Modules.x86.x64 | Modules for Standard Library (experimental) | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM | Visual C++ compilers and libraries for ARM | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.VC.Tools.ARM64 | Visual C++ compilers and libraries for ARM64 | 15.0.27019.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.0.26208.0 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.Desktop | Windows 10 SDK (10.0.15063.0) for Desktop C++ [x86 and x64] | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP | Windows 10 SDK (10.0.15063.0) for UWP: C#, VB, JS | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.15063.UWP.Native | Windows 10 SDK (10.0.15063.0) for UWP: C++ | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop.arm | Windows 10 SDK (10.0.16299.0) for Desktop C++ [ARM and ARM64] | 15.0.27128.1 | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | 15.0.26208.0 | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Win81 | Windows 8.1 SDK and UCRT SDK | 15.0.27019.1 | Optional

## Web development build tools

**ID:** Microsoft.VisualStudio.Workload.WebBuildTools

**Description:** MSBuild tasks and targets for building web applications.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Required
Microsoft.VisualStudio.Wcf.BuildTools.ComponentGroup | WCF development build tools | 15.0.27019.1 | Required
Microsoft.VisualStudio.Web.BuildTools.ComponentGroup | Web development build tools | 15.0.26323.1 | Required
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26621.2 | Recommended
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.0.26606.0 | Recommended
Microsoft.Net.Core.Component.SDK | .NET Core 1.0 - 1.1 development tools | 15.0.26606.0 | Recommended
Microsoft.VisualStudio.Component.NuGet.BuildTools | NuGet targets and build tasks | 15.0.26919.1 | Recommended
Microsoft.Net.Component.3.5.DeveloperTools | .NET Framework 3.5 development tools | 15.0.26621.2 | Optional
Microsoft.Net.Component.4.6.2.SDK | .NET Framework 4.6.2 SDK | 15.0.26208.0 | Optional
Microsoft.Net.Component.4.6.2.TargetingPack | .NET Framework 4.6.2 targeting pack | 15.0.26208.0 | Optional
Microsoft.Net.Component.4.7.1.SDK | .NET Framework 4.7.1 SDK | 15.0.27128.1 | Optional
Microsoft.Net.Component.4.7.1.TargetingPack | .NET Framework 4.7.1 targeting pack | 15.0.27019.1 | Optional
Microsoft.Net.Component.4.7.SDK | .NET Framework 4.7 SDK | 15.0.26419.1 | Optional
Microsoft.Net.Component.4.7.TargetingPack | .NET Framework 4.7 targeting pack | 15.0.26621.2 | Optional
Microsoft.Net.ComponentGroup.4.6.2.DeveloperTools | .NET Framework 4.6.2 development tools | 15.0.26621.2 | Optional
Microsoft.Net.ComponentGroup.4.7.1.DeveloperTools | .NET Framework 4.7.1 development tools | 15.0.27019.1 | Optional
Microsoft.Net.ComponentGroup.4.7.DeveloperTools | .NET Framework 4.7 development tools | 15.0.27005.2 | Optional

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name | Version
--- | --- | ---
Microsoft.VisualStudio.Component.VC.Tools.14.11 | VC++ 2017 version 15.4 v14.11 toolset | 15.0.27128.1

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
