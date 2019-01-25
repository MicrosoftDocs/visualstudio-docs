---
title: Visual Studio Test Agent 2017 workload and component IDs
titleSuffix: ""
description: "Use Visual Studio workload and component IDs to run automated tests and load tests remotely"
keywords:
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.date: 11/13/2018
ms.topic: reference
helpviewer_keywords:
  - "workload ID, Visual Studio"
  - "component ID, Visual Studio"
  - "install Visual Studio, administrator guide"
ms.service:
ms.prod: visual-studio-dev15
ms.assetid: 55aea29b-1066-4e5a-aa99-fc87d4efb6d5
ms.workload:
  - "multiple"
---
# Visual Studio Test Agent 2017 component directory

The tables on this page list the IDs that you can use to install Visual Studio by using the command line or that you can specify as a dependency in a VSIX manifest. Note that we will add additional components as we release updates to Visual Studio.

Also note the following about the page:

* Each workload has its own section, followed by the workload ID and a table of the components that are available for the workload.
* By default, the **Required** components will be installed when you install the workload.
* If you choose to, you can also install the **Recommended** and **Optional** components.
* We've also added a section that lists the additional components that are not affiliated with any workload.

When you set dependencies in your VSIX manifest, you must specify Component IDs only. Use the tables on this page to determine our minimum component dependencies. In some scenarios, this might mean that you specify only one component from a workload. In other scenarios, it might mean that you specify multiple components from a single workload or multiple components from multiple workloads. For more information, see the [How to: Migrate Extensibility Projects to Visual Studio 2017](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md) page.

For more information about how to use these IDs, see [Use Command-Line Parameters to Install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) page.

## Test Agent

**ID:** Microsoft.VisualStudio.Workload.TestAgent

**Description:** Supports running automated tests and load tests remotely

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.ComponentGroup.TestTools.TestAgent | Test Agent core features | 15.0.27019.1 | Required

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name | Version
--- | --- | ---
n/a | n/a | n/a

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Visual Studio workload and component IDs](workload-and-component-ids.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
  * [Command-line parameter examples](command-line-parameter-examples.md)
* [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)
