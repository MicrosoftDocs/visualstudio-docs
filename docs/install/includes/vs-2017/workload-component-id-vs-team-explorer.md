---
title: Visual Studio Team Explorer 2017 workload and component IDs
titleSuffix: ""
description: "Use Visual Studio workload and component IDs to provide integrated testing tools for generalist testers"
keywords:
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.date: 11/13/2018
ms.prod: visual-studio-windows
ms.technology: vs-installation
ms.topic: include
---

When you set dependencies in your VSIX manifest, you must specify Component IDs only. Use the tables on this page to determine the minimum component dependencies. In some scenarios, this might mean that you specify only one component from a workload. In other scenarios, it might mean that you specify multiple components from a single workload or multiple components from multiple workloads. For more information, see the [How to: Migrate extensibility projects to Visual Studio 2017](../../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md) page.

For more information about how to use these IDs, see [Use command-line parameters to install Visual Studio 2017](../use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio 2017 workload and component IDs](../workload-and-component-ids.md?view=vs-2017) page.

## Visual Studio core editor (included with Visual Studio Team Explorer 2017)

**ID:** Microsoft.VisualStudio.Workload.CoreEditor

**Description:** The Visual Studio core shell experience, including syntax-aware code editing, source code control and work item management.

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.Component.CoreEditor | Visual Studio core editor | 15.8.27729.1 | Required
Microsoft.VisualStudio.Component.StartPageExperiment.Cpp | Visual Studio Start Page for C++ Users | 15.0.27128.1 | Optional

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name | Version
--- | --- | ---
n/a | n/a | n/a
