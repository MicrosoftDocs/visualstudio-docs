---
title: CreateExpInstance Utility
description: Learn about the CreateExpInstance utility that allows you to create, reset, or delete an experimental instance of Visual Studio.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- experimental builds
- experimental hive
- experimental instance
- createexpinstance
- createexpinst
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# CreateExpInstance utility

Use the **CreateExpInstance** utility to create, reset, or delete an experimental instance of Visual Studio. You can use the experimental instance to debug and test Visual Studio extensions without changing the underlying product.

## Syntax

```
CreateExpInstance.exe [/Create | /Reset | /Clean] /VSInstance=VsInstance /RootSuffix=Suffix
```

## Parameters
 **/Create**
 Creates the experimental instance.

 **/Reset**
 Deletes the experimental instance, and then creates a new one.

 **/Clean**
 Deletes the experimental instance.

 **/VSInstance**
 The name of the directory that contains the base Visual Studio instance to copy.

 **/RootSuffix**
 The suffix to append to the name of the experimental instance directory.

## Remarks
 When you are working on a Visual Studio extension, you can press F5 to open the default experimental instance and install the current extension. If no experimental instance is available, Visual Studio creates one that has the default settings.

 The default location of the experimental instance depends on the Visual Studio version number. For example, for Visual Studio 2015, the location is *%localappdata%\Microsoft\VisualStudio\14.0Exp\\*. All the files in the directory location are considered part of that instance. Any additional experimental instances will not be loaded by Visual Studio unless the directory name is changed to the default location.

 Visual Studio does not access the system registry when it opens the experimental instance. This differs from earlier versions of Visual Studio, which used an experimental version of the registry hive.

 The **CreateExpInstance** utility replaces the **VsRegEx** utility.

 The following example resets the default experimental instance of Visual Studio:

 **CreateExpInstance.exe /Reset /VSInstance=14.0 /RootSuffix=Exp**

## See also
- [VSPackages](../../extensibility/internals/vspackages.md)
