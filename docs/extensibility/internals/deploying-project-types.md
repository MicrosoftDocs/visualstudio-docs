---
title: Deploying Project Types | Microsoft Docs
description: Learn how to deploy managed-code project types by using a new project-type aggregator and Windows Installer package for redistribution, in the Visual Studio SDK. 
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- projects [Visual Studio SDK], managed-code
- projects [Visual Studio SDK], aggregator
ms.assetid: 7f132f67-8589-464c-90dc-0d57ae02aa8f
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Deploy project types
[!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] installs a new project-type aggregator (*ProjectAggregator2.dll*) and also a Windows Installer package for redistribution (*ProjectAggregator2.msi*). You must use the new aggregator for managed-code project types. ProjectAggregator2 works around limitations in the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] project aggregator that prevents managed-code project types from working correctly. The following steps describe how to change your VSPackage to use the new aggregator.

1. Remove the NativeHierarchyWrapper project from your solution.

2. Remove any NativeHierarchyWrapper binaries from your setup.

3. Add *ProjectAggregator2.msi* to your setup.
