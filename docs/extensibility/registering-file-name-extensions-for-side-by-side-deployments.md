---
title: "Registering File Name Extensions for Side-By-Side Deployments | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "file extensions, registering for side-by-side"
ms.assetid: 9ab046a2-147d-4167-aa14-7d661b1eaaa5
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Register file name extensions for side-by-side deployments
For VSPackages deployed in a side-by-side environment, you must register file name extensions to associate the files with the correct version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. Unless you use a version-specific file name extension, registration enables users to open your project and project item files in the appropriate version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].

## In this section
- [About file name extensions](../extensibility/about-file-name-extensions.md)
 Discusses how file name extensions are registered.

- [Specify file handlers for file name extensions](../extensibility/specifying-file-handlers-for-file-name-extensions.md)
 Provides information about how to register the applications that can open, edit, and so on, a particular file name extension.

- [Register verbs for file name extensions](../extensibility/registering-verbs-for-file-name-extensions.md)
 Discusses how to register verbs.

- [Manage side-by-side file associations](../extensibility/managing-side-by-side-file-associations.md)
 Discusses how to handle side-by-side installations in which a particular version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] should be invoked to open a file.

## Related sections
- [Support multiple versions of Visual Studio](../extensibility/supporting-multiple-versions-of-visual-studio.md)
 Describes issues related to multiple versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and your VSPackage during development and deployment to end users.