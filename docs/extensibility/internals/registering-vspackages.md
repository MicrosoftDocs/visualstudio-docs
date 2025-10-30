---
title: Registering VSPackages
description: A .pkgdef file has information that would otherwise be added to the system registry. Learn how Visual Studio uses .pkgdef files to describe/locate a VSPackage.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- managed VSPackages, registering
- registration, managed VSPackages
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Registering VSPackages

Visual Studio relies on .pkgdef files to describe and locate a VSPackage. A .pkgdef file contains all the registration information that would otherwise be added to the system registry. Managed VSPackages are registered by adding attributes to the source code and then running the [CreatePkgDef Utility](../../extensibility/internals/createpkgdef-utility.md) on the resulting assembly to generate a .pkgdef file.

## In This Section
- [Specifying VSPackage File Location to the VS Shell](../../extensibility/internals/specifying-vspackage-file-location-to-the-vs-shell.md)

 Describes the loading path for VSPackages.

- [Registering and Unregistering VSPackages](../../extensibility/registering-and-unregistering-vspackages.md)

 Explains how to register a VSPackage.
