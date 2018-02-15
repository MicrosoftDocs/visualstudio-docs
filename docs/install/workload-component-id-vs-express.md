---
title: Visual Studio Desktop Express 2017 workload and component IDs | Microsoft Docs
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
ms.assetid: a3c0cc76-e3ce-435c-a1af-a6318b5a4dbe
ms.workload: 
  - "multiple"
---

# Visual Studio Desktop Express 2017 workload and component IDs

The tables on this page list the IDs that you can use to install Visual Studio by using the command line or that you can specify as a dependency in a VSIX manifest. Note that we will add additional components as we release updates to Visual Studio.

Also note the following about the page:

* Each workload has its own section, followed by the workload ID and a table of the components that are available for the workload.
* By default, the **Required** components will be installed when you install the workload. If you choose to, you can also install the **Recommended** and **Optional** components.
* We've also added a section that lists the additional components that are not affiliated with any workload.

When you set dependencies in your VSIX manifest, you must specify Component IDs only. Use the tables on this page to determine our minimum component dependencies. In some scenarios, this might mean that you specify only one component from a workload. In other scenarios, it might mean that you specify multiple components from a single workload or multiple components from multiple workloads. For more information, see the [How to: Migrate Extensibility Projects to Visual Studio 2017](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md) page.

For more information about how to use these IDs, see [Use Command-Line Parameters to Install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) page.

## Express for Windows Desktop

**ID:** Microsoft.VisualStudio.Workload.WDExpress

**Description:** Build Native and Managed applications like WPF, WinForms and Win32 with syntax-aware code editing, source code control, and work item management. Includes support for C#, Visual Basic, and Visual C++.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.Component.ClickOnce | ClickOnce Publishing | 15.0.27019.1 | Required
Microsoft.Component.HelpViewer | Help Viewer | 15.0.27005.2 | Required
Microsoft.Component.MSBuild | MSBuild | 15.0.27019.1 | Required
Microsoft.Component.VC.Runtime.OSSupport | Visual C++ runtime for UWP | 15.0.27019.1 | Required
Microsoft.Net.Component.4.5.1.TargetingPack | .NET Framework 4.5.1 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.5.2.TargetingPack | .NET Framework 4.5.2 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.5.TargetingPack | .NET Framework 4.5 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.SDK | .NET Framework 4.6.1 SDK | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.1.TargetingPack | .NET Framework 4.6.1 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.6.TargetingPack | .NET Framework 4.6 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.Component.4.TargetingPack | .NET Framework 4 targeting pack | 15.0.26621.2 | Required
Microsoft.Net.ComponentGroup.DevelopmentPrerequisites | .NET Framework 4.6.1 development tools | 15.0.27005.2 | Required
Microsoft.Net.ComponentGroup.TargetingPacks.Common | .NET Framework 4 – 4.6 development tools | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.Common.Azure.Tools | Connectivity and publishing tools | 1.10.50912.1 | Required
Microsoft.VisualStudio.Component.CoreEditor | Visual Studio core editor | 15.0.26606.0 | Required
Microsoft.VisualStudio.Component.EntityFramework | Entity Framework 6 tools | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.NuGet | NuGet package manager | 15.0.27128.1 | Required
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
Microsoft.VisualStudio.Component.VC.CLI.Support | C++/CLI support | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.VC.Tools.ARM | Visual C++ compilers and libraries for ARM | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.VC.Tools.ARM64 | Visual C++ compilers and libraries for ARM64 | 15.0.27019.1 | Required
Microsoft.VisualStudio.Component.VisualStudioData | Data sources and service references | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Windows10SDK.14393 | Windows 10 SDK (10.0.14393.0) | 15.0.26208.0 | Required
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop | Windows 10 SDK (10.0.16299.0) for Desktop C++ [x86 and x64] | 15.0.27128.1 | Required
Microsoft.VisualStudio.Component.Windows10SDK.16299.Desktop.arm | Windows 10 SDK (10.0.16299.0) for Desktop C++ [ARM and ARM64] | 15.0.27128.1 | Required
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP | Windows 10 SDK (10.0.16299.0) for UWP: C#, VB, JS | 15.0.27128.1 | Required
Microsoft.VisualStudio.Component.Windows10SDK.16299.UWP.Native | Windows 10 SDK (10.0.16299.0) for UWP: C++ | 15.0.27128.1 | Required

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name | Version
--- | --- | ---
n/a | n/a | n/a

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
