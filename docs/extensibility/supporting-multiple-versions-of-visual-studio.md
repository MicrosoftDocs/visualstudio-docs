---
title: Supporting Multiple Versions of Visual Studio
description: Support multiple versions of Visual Studio simultaneously by using VSPackages, which can install and maintain several versions of a product on the same computer. 
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- Visual Studio, supporting multiple versions
- VSPackages, side-by-side compatibility
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Supporting Multiple Versions of Visual Studio

The term *side-by-side* means that you can install and maintain multiple versions of a product on the same computer. For VSPackages, that means a user can have several Visual Studio versions installed on the same computer. However, you cannot have side-by-side versions of your VSPackages loaded into a single version of Visual Studio.

 Before you make your VSPackage able to be loaded into side-by-side versions of Visual Studio, consider the following:

- You must determine which side-by-side implementation strategy you want to follow.

   For more information, see [Choosing Between Shared and Versioned VSPackages](../extensibility/choosing-between-shared-and-versioned-vspackages.md).

- Your solution and project file formats must fit your implementation strategy.

   For more information, see [Upgrading Custom Projects](../extensibility/internals/upgrading-projects.md#upgrading-custom-projects) and [Registering File Name Extensions for Side-By-Side Deployments](../extensibility/registering-file-name-extensions-for-side-by-side-deployments.md).

- Your installer must handle your implementation strategy so that versioned components, and also components shared across all versions, are correctly installed and registered.

   For more information, see [Installing VSPackages With Windows Installer](../extensibility/internals/installing-vspackages-with-windows-installer.md) and also [Component Management](../extensibility/internals/component-management.md).

  > [!NOTE]
  > Installing a version of Visual Studio also installs a corresponding version of the .NET Framework. For example, installing Visual Studio 2010 and Visual Studio 2012 on the same computer also installs versions 4.0 and 4.5 of the .NET Framework, respectively.

## In this section

- [Choosing Between Shared and Versioned VSPackages](../extensibility/choosing-between-shared-and-versioned-vspackages.md) explains how to resolve side-by-side issues in your VSPackage.

- [Registering File Name Extensions for Side-By-Side Deployments](../extensibility/registering-file-name-extensions-for-side-by-side-deployments.md) describes how your VSPackage can register file associations in a side-by-side scenario.

## Related sections

- [Installing VSPackages With Windows Installer](../extensibility/internals/installing-vspackages-with-windows-installer.md)
