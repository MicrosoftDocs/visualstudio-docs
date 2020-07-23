---
title: Troubleshooting RegPkg Package Registration | Microsoft Docs
ms.date: 11/04/2016
ms.topic: troubleshooting
helpviewer_keywords:
- RegPkg
ms.assetid: f33f822f-697a-4bad-9c10-554b4c8f6246
author: acangialosi
ms.author: anthc
manager: jillfra
ms.workload:
- vssdk
---
# Troubleshooting RegPkg Package Registration
> [!NOTE]
> The preferred way to register packages in Visual Studio is by using .pkgdef files. This allows for extension deployment without having to access the system registry. Pkgdef files are created by using the [CreatePkgDef Utility](../../extensibility/internals/createpkgdef-utility.md).

 To register a package by using RegPkg in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], you must use the version of RegPkg that is appropriate for your package.

## RegPkg Versions Related to Package Versions
 There are two versions of RegPkg. One version is included in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. Use this version to register packages that have been built by using one of the following assemblies:

1. Microsoft.VisualStudioShell.9.0.dll

2. Microsoft.VisualStudioShell.10.0.dll

3. Microsoft.VisualStudioShell.11.0.dll

   It cannot register packages that have been built by using the earlier Microsoft.VisualStudio.Shell.dll assembly.

   The earlier version of RegPkg can register packages that have been built by using the Microsoft.VisualStudio.Shell.dll assembly. However, it cannot register packages built by using later versions of that assembly.

## See also
- [VSPackages](../../extensibility/internals/vspackages.md)
