---
title: About File Name Extensions
description: Learn how to register file name extensions for VSPackages and associate them with a specific version of Visual Studio.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- file extensions
- file name extensions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# About file name extensions

When you register a file extension of a VSPackage, you associate it with a version of Visual Studio. This is important if more than one version of Visual Studio is installed on a computer.

 File extensions for VSPackages are registered under **HKEY_CLASSES_ROOT** key with a default value that points to the associated programmatic identifier (ProgID).

 The following example shows registration information for the *.vcproj* file extension:

```
HKEY_CLASSES_ROOT\
   .vcproj\
      (default)=" VisualStudio.vcproj.8.0"
```

 Files associated with Visual Studio must have a versioned ProgID, such as `VisualStudio.vcproj.8.0`. A versioned ProgID allows side-by-side installations of the product to maintain file extension associations among product versions. A version-specific ProgID also allows you to use standard verbs, such as open, edit, and so on, without the concern of overwriting or being overwritten by other applications or versions of Visual Studio.

 In certain cases, the ProgID associated with a file extension should not be changed. For example, the ProgID for the *.htm* file extension (progid = htmlfile) is hard-coded in a number of places in the operating system, and is widely known and used in association with *.htm* and *.html* files.

## Related content
- [Register file name extensions for side-by-side deployments](../extensibility/registering-file-name-extensions-for-side-by-side-deployments.md)
- [Specify file handlers for file name extensions](../extensibility/specifying-file-handlers-for-file-name-extensions.md)
