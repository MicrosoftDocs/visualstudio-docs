---
title: Troubleshooting RegPkg Package Registration
description: Use this information to troubleshoot RegPkg package registration in Visual Studio. Use the version of RegPkg that is appropriate for your package.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- RegPkg
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Troubleshooting RegPkg Package Registration

> [!NOTE]
> The preferred way to register packages in Visual Studio is by using .pkgdef files. This allows for extension deployment without having to access the system registry. Pkgdef files are created by using the [CreatePkgDef Utility](../../extensibility/internals/createpkgdef-utility.md).

 To register a package by using RegPkg in Visual Studio, you must use the version of RegPkg that is appropriate for your package.

## RegPkg Versions Related to Package Versions
 There are two versions of RegPkg. One version is included in Visual Studio. Use this version to register packages that have been built by using one of the following assemblies:

1. Microsoft.VisualStudioShell.9.0.dll

2. Microsoft.VisualStudioShell.10.0.dll

3. Microsoft.VisualStudioShell.11.0.dll

   It cannot register packages that have been built by using the earlier Microsoft.VisualStudio.Shell.dll assembly.

   The earlier version of RegPkg can register packages that have been built by using the Microsoft.VisualStudio.Shell.dll assembly. However, it cannot register packages built by using later versions of that assembly.

## Related content
- [VSPackages](../../extensibility/internals/vspackages.md)
- [Visual Studio troubleshooting](/troubleshoot/visualstudio/welcome-visual-studio/)
