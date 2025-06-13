---
title: Deploying Project Types
description: Learn how to deploy managed-code project types by using a new project-type aggregator and Windows Installer package for redistribution, in the Visual Studio SDK. 
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- projects [Visual Studio SDK], managed-code
- projects [Visual Studio SDK], aggregator
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Deploy project types

Visual Studio SDK installs a new project-type aggregator (*ProjectAggregator2.dll*) and also a Windows Installer package for redistribution (*ProjectAggregator2.msi*). You must use the new aggregator for managed-code project types. ProjectAggregator2 works around limitations in the Visual Studio project aggregator that prevents managed-code project types from working correctly. The following steps describe how to change your VSPackage to use the new aggregator.

1. Remove the NativeHierarchyWrapper project from your solution.

2. Remove any NativeHierarchyWrapper binaries from your setup.

3. Add *ProjectAggregator2.msi* to your setup.
