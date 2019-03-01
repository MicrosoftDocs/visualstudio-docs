---
title: Visual Studio Test Controller 2017 workload and component IDs
titleSuffix: ""
description: "Use Visual Studio workload and component IDs to distribute automated tests to multiple machines"
keywords:
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.date: 11/13/2018
ms.prod: visual-studio-windows
ms.technology: vs-installation
ms.topic: include
---

When you set dependencies in your VSIX manifest, you must specify Component IDs only. Use the tables on this page to determine our minimum component dependencies. In some scenarios, this might mean that you specify only one component from a workload. In other scenarios, it might mean that you specify multiple components from a single workload or multiple components from multiple workloads. For more information, see the [How to: Migrate Extensibility Projects to Visual Studio 2017](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2017.md) page.

For more information about how to use these IDs, see [Use Command-Line Parameters to Install Visual Studio 2017](use-command-line-parameters-to-install-visual-studio.md) page. And, for a list of workload and component IDs for other products, see [Visual Studio 2017 Workload and Component IDs](workload-and-component-ids.md) page.

## Test Controller

**ID:** Microsoft.VisualStudio.Workload.TestController

**Description:** Distribute automated tests to multiple machines

### Components included by this workload

Component ID | Name | Version | Dependency type
--- | --- | --- | ---
Microsoft.VisualStudio.ComponentGroup.TestTools.TestController | Test Controller core features | 15.6.27309.0 | Required

## Unaffiliated components

These are components that are not included with any workload, but may be selected as an individual component.

Component ID | Name | Version
--- | --- | ---
n/a | n/a | n/a
