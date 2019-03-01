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

Click the edition names in the following table to see the available workload and component IDs you need to install Visual Studio by using a command line, or to specify as a dependency in a VSIX manifest.

::: moniker range="vs-2017"

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

For more information about how to use these lists, see the [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md) page and the [How to: Migrate extensibility projects to Visual Studio](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md) page.

::: moniker-end

## Get support

Sometimes, things can go wrong. If your Visual Studio installation fails, see [Troubleshooting Visual Studio 2017 installation and upgrade issues](../troubleshooting-installation-issues.md) for step-by-step guidance.

We also offer a [**live chat**](https://visualstudio.microsoft.com/vs/support/#talktous) (English only) support option for installation-related issues.

Here are a few more support options:

* Report product issues to us via the [Report a Problem](../ide/how-to-report-a-problem-with-visual-studio.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
* Suggest a feature, track product issues, and find answers in the [Visual Studio Developer Community](https://developercommunity.visualstudio.com/).
* Use your [GitHub](https://github.com/) account to talk to us and other Visual Studio developers in the [Visual Studio conversation in the Gitter community](https://gitter.im/Microsoft/VisualStudio).

## See also

* [Visual Studio administrator guide for Visual Studio](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
  * [Command-line parameter examples](command-line-parameter-examples.md)
* [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)
