---
title: CreatePkgDef Utility | Microsoft Docs
description: Learn about the CreatePkgDef utility that takes a .dll file for a Visual Studio extension as a parameter and creates a .pkgdef file to accompany the .dll file. 
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- package definition
- create pkgdef
- pkgdef
- createpkgdef
ms.assetid: c745cb76-47a6-49ff-9eed-16af0f748e35
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# CreatePkgDef utility
Takes a .dll file for a Visual Studio extension as a parameter and creates a *.pkgdef* file to accompany the *.dll* file. The *.pkgdef* file contains all the information that would otherwise be written to the system registry when the extension is installed.

> [!NOTE]
> Most of the project templates that are included in the Visual Studio SDK automatically create *.pkgdef* files as part of the build process. This document is intended for those who want to create packages manually, or convert existing packages to use *.pkgdef*  deployment.

## Syntax

```
CreatePkgDef /out=<FileName> [/codebase] [/assembly] <AssemblyPath>
```

## Arguments
**/out=&lt;FileName&gt;**\
Required. Sets the name of the *.pkgdef* output file to &lt;FileName&gt;.

**/codebase**\
Optional. Forces registration with the **CodeBase** utility.

**/assembly**\
Forces registration with the **Assembly** utility.

**&lt;AssemblyPath&gt;**\
The path of the *.dll* file from which you want to generate the *.pkgdef*.

## Remarks
Extension deployment by using *.pkgdef* files replaces the registry requirements of earlier versions of Visual Studio.

::: moniker range=">=vs-2019"

The *.pkgdef* files must be installed in one of the following locations:

- *%localappdata%\Microsoft\Visual Studio\16.0\Extensions\\*

- *%vsinstalldir%\Common7\IDE\Extensions\\*

If the installation folder is *%localappdata%\Microsoft\Visual Studio\16.0\Extensions\\*, the extension is recognized by Visual Studio but is disabled by default. The user can enable the extension by using **Manage Extensions**.

If the installation folder is *%vsinstalldir%\Common7\IDE\Extensions\\*, the extension is enabled by default.

> [!NOTE]
> The **Manage Extensions** tool cannot be used to access an extension unless it is installed as part of a VSIX package.

::: moniker-end

::: moniker range="vs-2017"

The *.pkgdef* files must be installed in one of the following locations:

- *%localappdata%\Microsoft\Visual Studio\15.0\Extensions\\*

- *%vsinstalldir%\Common7\IDE\Extensions\\*

If the installation folder is *%localappdata%\Microsoft\Visual Studio\15.0\Extensions\\*, the extension is recognized by Visual Studio but is disabled by default. The user can enable the extension by using **Extensions and Updates**.

If the installation folder is *%vsinstalldir%\Common7\IDE\Extensions\\*, the extension is enabled by default.

> [!NOTE]
> The **Extensions and Updates** tool cannot be used to access an extension unless it is installed as part of a VSIX package.

::: moniker-end

## See also
- [CreateExpInstance utility](../../extensibility/internals/createexpinstance-utility.md)
