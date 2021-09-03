---
title: About File Name Extensions | Microsoft Docs
description: Learn how to register file name extensions for VSPackages and associate them with a specific version of Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- file extensions
- file name extensions
ms.assetid: 99f4f9ff-fb84-4258-9787-6890f308a57f
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# About file name extensions
When you register a file extension of a VSPackage, you associate it with a version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. This is important if more than one version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] is installed on a computer.

 File extensions for VSPackages are registered under **HKEY_CLASSES_ROOT** key with a default value that points to the associated programmatic identifier (ProgID).

 The following example shows registration information for the *.vcproj* file extension:

```
HKEY_CLASSES_ROOT\
   .vcproj\
      (default)=" VisualStudio.vcproj.8.0"
```

 Files associated with [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] must have a versioned ProgID, such as `VisualStudio.vcproj.8.0`. A versioned ProgID allows side-by-side installations of the product to maintain file extension associations among product versions. A version-specific ProgID also allows you to use standard verbs, such as open, edit, and so on, without the concern of overwriting or being overwritten by other applications or versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].

 In certain cases, the ProgID associated with a file extension should not be changed. For example, the ProgID for the *.htm* file extension (progid = htmlfile) is hard-coded in a number of places in the operating system, and is widely known and used in association with *.htm* and *.html* files.

## See also
- [Register file name extensions for side-by-side deployments](../extensibility/registering-file-name-extensions-for-side-by-side-deployments.md)
- [Specify file handlers for file name extensions](../extensibility/specifying-file-handlers-for-file-name-extensions.md)
