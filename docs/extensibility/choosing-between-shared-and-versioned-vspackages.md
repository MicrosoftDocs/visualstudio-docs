---
title: Choosing Between Shared and Versioned VSPackages | Microsoft Docs
description: Learn about side-by-side installations of VSPackages through shared or versioned strategies, with multiple versions of Visual Studio and of the .NET Framework.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- SxS
- side-by-side installation
- installation [Visual Studio SDK], side-by-side
ms.assetid: e3128ac3-2e92-48e9-87ab-3b6c9d80e8c9
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Choose between shared and versioned VSPackages
Different versions of Visual Studio can coexist on the same computer. VSPackages can support any mix of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] versions.

 You can enable side-by-side installations of VSPackages through either of two strategies, the shared strategy or the versioned strategy. Both accommodate the presence of multiple versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and associated versions of the .NET Framework.

 In the shared strategy, one VSPackage is registered for use in multiple versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. In the versioned strategy, multiple VSPackage DLLs are installed, one for each version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] that you support.

## Shared VSPackages
 Using a shared VSPackage is appropriate when you use the same VSPackage in multiple versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. To implement a shared VSPackage, you must take the following steps:

- Make your VSPackage compatible with multiple versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. Two ways of doing so are available:

  - Limit your VSPackage to using only the features of the earliest version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] that you support.

  - Program your VSPackage to adapt to the version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] in which it is running. Then, if queries for newer services fail, your VSPackage can offer other services that are supported in older versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].

- Register your VSPackage appropriately. For more information, see [VSPackage registration](../extensibility/internals/vspackage-registration.md) and [Managed VSPackage registration](/previous-versions/bb166783(v=vs.100)).

- Register file extensions appropriately. For more information, see [Registering file name extensions for side-by-side deployments](../extensibility/registering-file-name-extensions-for-side-by-side-deployments.md).

- Create an installer that deploys your VSPackage for the appropriate versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. For more information, see [Installing VSPackages with Windows Installer](../extensibility/internals/installing-vspackages-with-windows-installer.md) and [Component management](../extensibility/internals/component-management.md).

- Address the issue of registration collisions. For more information, see [VSPackage registration](../extensibility/internals/vspackage-registration.md).

- Ensure that both shared and versioned files respect reference counting to allow safe installation and removal of multiple versions. For more information, see [Component management](../extensibility/internals/component-management.md).

## Versioned VSPackages
 Under the versioned VSPackage strategy, you create one VSPackage for each version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] that you support. Doing this is appropriate when you expect to take advantage of services provided by later versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], because each VSPackage can evolve without affecting the others. Nevertheless, the versioned strategy of creating multiple binaries, either from a single code base or from multiple independent code bases, might entail more initial development than the shared strategy. Also, additional setup work might be required because you must create either a separate setup for each version or a single setup that detects the versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] that are installed and that your VSPackage supports.

## Binary compatibility
 Generally, binary compatibility enables native-code VSPackages developed with earlier versions of Visual Studio to run in later versions of Visual Studio. However, there are three important exceptions:

- If your VSPackage relies on a particular version of the common language runtime, then it must determine in which version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] it is running.

- A VSPackage might have a dependency on a specific feature of another VSPackage or another product. Consequently, the VSPackage can run only where the dependency is satisfied.

- A VSPackage might be affected by a security fix in a [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] service pack or a later version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. In those cases, a VSPackage developed with an earlier version of the [!INCLUDE[vsipsdk](../extensibility/includes/vsipsdk_md.md)] might not run in versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] after the security fix was applied. However, you can rebuild your package with the later version and have it also run in earlier versions.

  Managed VSPackages must be built using a version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and the [!INCLUDE[vsipsdk](../extensibility/includes/vsipsdk_md.md)] that match the target version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].

  In addition to planning for binary compatibility for your VSPackage binaries, you also should consider solution and project file formats. If your VSPackage creates a new project type, you must decide whether it can run in just one version or in multiple versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. For more information, see [Upgrading custom projects](../extensibility/internals/upgrading-projects.md#upgrading-custom-projects).

## See also
- [Installing VSPackages with Windows Installer](../extensibility/internals/installing-vspackages-with-windows-installer.md)
- [Component management](../extensibility/internals/component-management.md)