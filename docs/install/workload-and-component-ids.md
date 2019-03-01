---
title: Visual Studio workload and component IDs
titleSuffix: ""
description: "Use workload and component IDs to install Visual Studio by using a command line, or to specify as a dependency in a VSIX manifest"
keywords:
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.date: 03/02/2019
ms.topic: reference
helpviewer_keywords:
  - "workload ID, Visual Studio"
  - "component ID, Visual Studio"
  - "install Visual Studio, administrator guide"
ms.custom: "seodec18"
ms.assetid: 34e19ef1-abfb-44fd-aad2-33c5d7874482
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Visual Studio workload and component IDs

::: moniker range="vs-2017"

When you set dependencies in your VSIX manifest, you must specify Component IDs only. Use the tables on this page to determine our minimum component dependencies. In some scenarios, this might mean that you specify only one component from a workload. In other scenarios, it might mean that you specify multiple components from a single workload or multiple components from multiple workloads. For more information, see the [How to: Migrate extensibility projects to Visual Studio 2017](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md) page.

For more information about how to use these IDs, see [Use command-line parameters to install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio workload and component IDs](workload-and-component-ids.md) page.

Click the edition names in the following table to see the available workload and component IDs you need to install Visual Studio by using a command line, or to specify as a dependency in a VSIX manifest.

**Updated for the [15.9 release](/visualstudio/releasenotes/vs2017-relnotes/)**

| **Edition** | **ID** | **Description** |
| ----------- | ------ | --------------- |
| [Visual&nbsp;Studio Enterprise&nbsp;2017](workload-component-id-vs-enterprise.md) | Microsoft.VisualStudio.Product.Enterprise | Microsoft DevOps solution for productivity and coordination across teams of any size |
| [Visual&nbsp;Studio Professional&nbsp;2017](workload-component-id-vs-professional.md) | Microsoft.VisualStudio.Product.Professional | Professional developer tools and services for small teams |
| [Visual&nbsp;Studio Community&nbsp;2017](workload-component-id-vs-community.md) | Microsoft.VisualStudio.Product.Community | Free, fully featured IDE for students, open-source, and individual developers |
| [Visual&nbsp;Studio Team&nbsp;Explorer&nbsp;2017](workload-component-id-vs-team-explorer.md) | Microsoft.VisualStudio.Product.TeamExplorer | Interact with Team Foundation Server and Azure DevOps Services without a Visual Studio developer toolset |
| [Visual Studio Desktop Express 2017](workload-component-id-vs-express.md) | Microsoft.VisualStudio.Product.WDExpress | Build Native and Managed applications like WPF, WinForms, and Win32 with syntax-aware code editing, source code control, and work item management. Includes support for C#, Visual Basic, and Visual C++. |
| [Visual&nbsp;Studio Build&nbsp;Tools&nbsp;2017](workload-component-id-vs-build-tools.md) | Microsoft.VisualStudio.Product.BuildTools | The Visual Studio Build Tools allows you to build native and managed MSBuild-based applications without requiring the Visual Studio IDE. There are options to install the Visual C++ compilers and libraries, MFC, ATL, and C++/CLI support. |
| [Visual&nbsp;Studio Test&nbsp;Agent&nbsp;2017](workload-component-id-vs-test-agent.md)  | Microsoft.VisualStudio.Product.TestAgent | Supports running automated tests and load tests remotely |
| [Visual&nbsp;Studio Test&nbsp;Controller 2017](workload-component-id-vs-test-controller.md) | Microsoft.VisualStudio.Product.TestController | Distribute automated tests to multiple machines |
| [Visual&nbsp;Studio Test&nbsp;Professional&nbsp;2017](workload-component-id-vs-test-professional.md) | Microsoft.VisualStudio.Product.TestProfessional | Visual Studio Test Professional 2017 |
| [Visual&nbsp;Studio Feedback&nbsp;Client&nbsp;2017](workload-component-id-vs-feedback-client.md) | Microsoft.VisualStudio.Product.FeedbackClient | Visual Studio Feedback Client 2017 |

For more information about how to use these lists, see the [Use command-line parameters to install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page and the [How to: Migrate extensibility projects to Visual Studio 2017](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md) page.

::: moniker-end

::: moniker range="vs-2019"

When you set dependencies in your VSIX manifest, you must specify Component IDs only. Use the tables on this page to determine our minimum component dependencies. In some scenarios, this might mean that you specify only one component from a workload. In other scenarios, it might mean that you specify multiple components from a single workload or multiple components from multiple workloads. For more information, see the [How to: Migrate extensibility projects to Visual Studio 2019](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2019.md) page.

For more information about how to use these IDs, see [Use command-line parameters to install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio workload and component IDs](workload-and-component-ids.md) page.

Click the edition names in the following table to see the available workload and component IDs you need to install Visual Studio by using a command line, or to specify as a dependency in a VSIX manifest.

**Updated for the [Visual Studio 2019 RC](/visualstudio/releases/2019/release-notes/)**

| **Edition** | **ID** | **Description** |
| ----------- | ------ | --------------- |
| [Visual&nbsp;Studio Enterprise&nbsp;2019](includes/vs-2019/workload-component-id-vs-enterprise.md) | Microsoft.VisualStudio.Product.Enterprise | Microsoft DevOps solution for productivity and coordination across teams of any size |
| [Visual&nbsp;Studio Professional&nbsp;2019](includes/vs-2019/workload-component-id-vs-professional.md) | Microsoft.VisualStudio.Product.Professional | Professional developer tools and services for small teams |
| [Visual&nbsp;Studio Community&nbsp;2019](includes/vs-2019/workload-component-id-vs-community.md) | Microsoft.VisualStudio.Product.Community | Free, fully featured IDE for students, open-source, and individual developers |
| [Visual&nbsp;Studio Team&nbsp;Explorer&nbsp;2019](includes/vs-2019/workload-component-id-vs-team-explorer.md) | Microsoft.VisualStudio.Product.TeamExplorer | Interact with Team Foundation Server and Azure DevOps Services without a Visual Studio developer toolset |
| [Visual&nbsp;Studio Build&nbsp;Tools&nbsp;2019](includes/vs-2019/workload-component-id-vs-build-tools.md) | Microsoft.VisualStudio.Product.BuildTools | The Visual Studio Build Tools allows you to build native and managed MSBuild-based applications without requiring the Visual Studio IDE. There are options to install the Visual C++ compilers and libraries, MFC, ATL, and C++/CLI support. |
| [Visual&nbsp;Studio Test&nbsp;Agent&nbsp;2019](includes/vs-2019/workload-component-id-vs-test-agent.md)  | Microsoft.VisualStudio.Product.TestAgent | Supports running automated tests and load tests remotely |
| [Visual&nbsp;Studio Load&nbsp;Test&nbsp;Controller 2019](includes/vs-2019/workload-component-id-vs-test-controller.md) | Microsoft.VisualStudio.Product.TestController | Distribute automated tests to multiple machines |

For more information about how to use these lists, see the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page and the [How to: Migrate extensibility projects to Visual Studio](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2019.md) page.

::: moniker-end

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Visual Studio administrator guide for Visual Studio](visual-studio-administrator-guide.md)
* [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)
* [Command-line parameter examples for Visual Studio installation](command-line-parameter-examples.md)
