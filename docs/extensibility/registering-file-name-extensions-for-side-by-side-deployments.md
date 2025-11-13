---
title: Register filename extensions for side-by-side IDEs
description: Learn about registering file name extensions for side-by-side deployments, which allows users to open files in the appropriate version of Visual Studio.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- file extensions, registering for side-by-side
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Register file name extensions for side-by-side deployments

For VSPackages deployed in a side-by-side environment, you must register file name extensions to associate the files with the correct version of Visual Studio. Unless you use a version-specific file name extension, registration enables users to open your project and project item files in the appropriate version of Visual Studio.

## In this section

- [About file name extensions](../extensibility/about-file-name-extensions.md) discusses how file name extensions are registered.

- [Specify file handlers for file name extensions](../extensibility/specifying-file-handlers-for-file-name-extensions.md) provides information about how to register the applications that can open, edit, and so on, a particular file name extension.

- [Register verbs for file name extensions](../extensibility/registering-verbs-for-file-name-extensions.md) discusses how to register verbs.

- [Manage side-by-side file associations](../extensibility/managing-side-by-side-file-associations.md) discusses how to handle side-by-side installations in which a particular version of Visual Studio should be invoked to open a file.

## Related sections

- [Support multiple versions of Visual Studio](../extensibility/supporting-multiple-versions-of-visual-studio.md) describes issues related to multiple versions of Visual Studio and your VSPackage during development and deployment to end users.
