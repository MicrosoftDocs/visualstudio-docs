---
title: Registering VSPackages | Microsoft Docs
description: A .pkgdef file has information that would otherwise be added to the system registry. Learn how Visual Studio uses .pkgdef files to describe/locate a VSPackage.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- managed VSPackages, registering
- registration, managed VSPackages
ms.assetid: 79b9424e-7e9b-4fc8-9b9f-00212674573c
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Registering VSPackages
[!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] relies on .pkgdef files to describe and locate a VSPackage. A .pkgdef file contains all the registration information that would otherwise be added to the system registry. Managed VSPackages are registered by adding attributes to the source code and then running the [CreatePkgDef Utility](../../extensibility/internals/createpkgdef-utility.md) on the resulting assembly to generate a .pkgdef file.

## In This Section
- [Specifying VSPackage File Location to the VS Shell](../../extensibility/internals/specifying-vspackage-file-location-to-the-vs-shell.md)

 Describes the loading path for VSPackages.

- [Registering and Unregistering VSPackages](../../extensibility/registering-and-unregistering-vspackages.md)

 Explains how to register a VSPackage.
