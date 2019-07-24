---
title: "Supporting Multiple Versions of Visual Studio 2015 | Microsoft Docs"
titleSuffix: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio, supporting multiple versions"
  - "VSPackages, side-by-side compatibility"
ms.assetid: 0047aa90-1ed4-40d3-8772-622b2719a4b1
caps.latest.revision: 21
ms.author: gregvanl
manager: jillfra
---
# Supporting Multiple Versions of Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The term *side-by-side* means that you can install and maintain multiple versions of a product on the same computer. For VSPackages, that means a user can have several Visual Studio versions installed on the same computer. However, you cannot have side-by-side versions of your VSPackages loaded into a single version of Visual Studio.

 Before you make your VSPackage able to be loaded into side-by-side versions of Visual Studio, consider the following:

- You must determine which side-by-side implementation strategy you want to follow.

     For more information, see [Choosing Between Shared and Versioned VSPackages](../extensibility/choosing-between-shared-and-versioned-vspackages.md).

- Your solution and project file formats must fit your implementation strategy.

     For more information, see [Upgrading Custom Projects](../misc/upgrading-custom-projects.md) and [Registering File Name Extensions for Side-By-Side Deployments](../extensibility/registering-file-name-extensions-for-side-by-side-deployments.md).

- Your installer must handle your implementation strategy so that versioned components, and also components shared across all versions, are correctly installed and registered.

     For more information, see [Installing VSPackages With Windows Installer](../extensibility/internals/installing-vspackages-with-windows-installer.md) and also [Component Management](../extensibility/internals/component-management.md).

    > [!NOTE]
    > Installing a version of Visual Studio also installs a corresponding version of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)]. For example, installing Visual Studio 2010 and Visual Studio 2012 on the same computer also installs versions 4.0 and 4.5 of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)], respectively.

## In This Section
 [Choosing Between Shared and Versioned VSPackages](../extensibility/choosing-between-shared-and-versioned-vspackages.md)
 Explains how to resolve side-by-side issues in your VSPackage.

 [Registering File Name Extensions for Side-By-Side Deployments](../extensibility/registering-file-name-extensions-for-side-by-side-deployments.md)
 Describes how your VSPackage can register file associations in a side-by-side scenario.

## Related Sections
 [Installing VSPackages](../misc/installing-vspackages.md)
 Discusses how to build and install VSPackages and how to support users who are running multiple versions of Visual Studio at the same time.
