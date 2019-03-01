---
title: Visual Studio Team Explorer workload and component IDs
titleSuffix: ""
description: "Use Visual Studio workload and component IDs to provide integrated testing tools for generalist testers"
keywords:
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.date: 02/29/2019
ms.topic: reference
helpviewer_keywords:
  - "workload ID, Visual Studio"
  - "component ID, Visual Studio"
  - "install Visual Studio, administrator guide"
ms.assetid: c6ef9a3b-d13d-49b4-9faa-51fa06b21e1f
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Visual Studio Team Explorer component directory

The tables on this page list the IDs that you can use to install Visual Studio by using the command line or that you can specify as a dependency in a VSIX manifest. Note that we will add additional components as we release updates to Visual Studio.

Also note the following about the page:

* Each workload has its own section, followed by the workload ID and a table of the components that are available for the workload.
* By default, the **Required** components will be installed when you install the workload.
* If you choose to, you can also install the **Recommended** and **Optional** components.
* We've also added a section that lists the additional components that are not affiliated with any workload.

::: moniker range="vs-2017"

[!include[Visual Studio Team Explorer 2017](includes/vs-2017/workload-component-id-vs-team-explorer.md)]

::: moniker-end

::: moniker range=">= vs-2019"

[!include[Visual Studio Team Explorer 2019](includes/vs-2019/workload-component-id-vs-team-explorer.md)]

::: moniker-end

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Visual Studio workload and component IDs](workload-and-component-ids.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
  * [Command-line parameter examples](command-line-parameter-examples.md)
* [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)