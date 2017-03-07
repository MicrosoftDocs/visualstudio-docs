---
title: [Visual Studio Build Tools 2017 workload and component IDs | Microsoft Docs]
description: "Use Visual Studio workload and component IDs to build classic Windows-based applications"
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
ms.assetid: b99298df-0280-47fc-af73-44cd7a8ac553
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

# Visual Studio Build Tools 2017 component directory

The tables on this page list the IDs that you can use to install Visual Studio by using the command line. Note that we will add additional components as we release updates to Visual Studio.

Also note the following about this page:

* Each workload has its own section, followed by the workload ID and a table of the components that are available for the workload.
* By default, the **Required** components will be installed when you install the workload. If you choose to, you can also install the **Recommended** and **Optional** components.
* We’ve also added a section that lists the additional components that are not affiliated with any workload.

For more information about how to use these IDs, see [Use Command-Line Parameters to Install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) page.

## MSBuild Tools

**ID:** Microsoft.VisualStudio.Workload.MSBuildTools

**Description:** Provides the tools required to build MSBuild-based applications.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.Component.MSBuild | MSBuild | Required
Microsoft.VisualStudio.Component.CoreBuildTools | Visual Studio Build Tools Core | Required
Microsoft.VisualStudio.Component.Roslyn.Compiler | C# and Visual Basic Roslyn compilers | Required


## Visual C++ build tools

**ID:** Microsoft.VisualStudio.Workload.VCTools

**Description:** Build classic Windows-based applications using the power of the Visual C++ toolset, ATL, and optional features like MFC and C++/CLI.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.VisualStudio.Component.VC.CoreBuildTools | Visual C++ Build Tools core features | Required
Microsoft.VisualStudio.Component.Windows10SDK | Windows Universal C Runtime | Required
Microsoft.VisualStudio.Component.VC.CMake.Project | Visual C++ tools for CMake | Recommended
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | Recommended
Microsoft.Component.VC.Runtime.UCRTSDK | Windows Universal CRT SDK | Optional
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | Optional
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | Optional
Microsoft.VisualStudio.Component.Static.Analysis.Tools | Static analysis tools | Optional
Microsoft.VisualStudio.Component.VC.ATL | Visual C++ ATL support | Optional
Microsoft.VisualStudio.Component.VC.ATLMFC | MFC and ATL support (x86 and x64) | Optional
Microsoft.VisualStudio.Component.VC.ClangC2 | Clang/C2 (experimental) | Optional
Microsoft.VisualStudio.Component.VC.CLI.Support | C++/CLI support | Optional
Microsoft.VisualStudio.Component.VC.CoreIde | Visual Studio C++ core features | Optional
Microsoft.VisualStudio.Component.VC.Modules.x86.x64 | Standard Library Modules | Optional
Microsoft.VisualStudio.Component.VC.Tools.x86.x64 | VC++ 2017 v141 toolset (x86,x64) | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10240 | Windows 10 SDK (10.0.10240.0) | Optional
Microsoft.VisualStudio.Component.Windows10SDK.10586 | Windows 10 SDK (10.0.10586.0) | Optional
Microsoft.VisualStudio.Component.Windows81SDK | Windows 8.1 SDK | Optional
Microsoft.VisualStudio.ComponentGroup.NativeDesktop.Win81 | Windows 8.1 SDK and UCRT SDK | Optional


## Web development build tools

**ID:** Microsoft.VisualStudio.Workload.WebBuildTools

**Description:** MSBuild tasks and targets for building web applications.

### Components included by this workload

Component ID | Name | Dependency type
--- | --- | ---
Microsoft.VisualStudio.Web.BuildTools.ComponentGroup | Web development build tools | Required
## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name
--- | ---
n/a | n/a


## See also

* [Visual Studio workload and component IDs](workload-and-component-ids.md)
* [Visual Studio Administrator Guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)
