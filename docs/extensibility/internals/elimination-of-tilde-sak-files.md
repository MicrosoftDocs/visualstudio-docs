---
title: "Elimination of ~SAK Files | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "temporary files"
  - "~sak files"
  - "source control plug-ins, ~SAK files"
ms.assetid: 5277b5fa-073b-4bd1-8ba1-9dc913aa3c50
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Elimination of ~SAK files
In Source Control Plug-in API 1.2, the *~SAK* files have been replaced by capability flags and new functions that detect whether a source control plug-in supports the *MSSCCPRJ* file and shared checkouts.

## ~SAK files
Visual Studio .NET 2003 created temporary files prefixed with *~SAK*. These files are used to determine if a source control plug-in supports:

- The *MSSCCPRJ.SCC* file.

- Multiple (shared) checkouts.

For plug-ins that support advanced functions provided in the Source Control Plug-in API 1.2, the IDE can detect these capabilities without creating the temporary files through the use of new capabilities, flags, and functions, detailed in the following sections.

## New capability flags
 `SCC_CAP_SCCFILE`

 `SCC_CAP_MULTICHECKOUT`

## New functions
- [SccWillCreateSccFile](../../extensibility/sccwillcreatesccfile-function.md)

- [SccIsMultiCheckoutEnabled](../../extensibility/sccismulticheckoutenabled-function.md)

 If a source control plug-in supports multiple (shared) checkouts, then it declares the `SCC_CAP_MULTICHECKOUT` capability and implements the `SccIsMultiCheckOutEnabled` function. This function is called whenever a checkout operation occurs on any of the source-controlled projects.

 If a source control plug-in supports the creation and use of an *MSSCCPRJ.SCC* file, then it declares the `SCC_CAP_SCCFILE` capability and implements the [SccWillCreateSccFile](../../extensibility/sccwillcreatesccfile-function.md). This function is called with a list of files. The function returns `TRUE' or 'FALSE` for each file to indicate whether Visual Studio should use an *MSSCCPRJ.SCC* file for it. If the source control plug-in chooses not to support these new capabilities and functions, it can use the following registry key to disable the creation of these files:

 **[HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl]DoNotCreateTemporaryFilesInSourceControl** = *dword:00000001*

> [!NOTE]
> If this registry key is set to *dword:00000000*, it is equivalent to the key being nonexistent, and Visual Studio still attempts to create the temporary files. However, if the registry key is set to *dword:00000001*, Visual Studio does not attempt to create the temporary files. Instead it assumes that the source control plug-in does not support the *MSSCCPRJ.SCC* file and does not support shared checkouts.

## See also
- [What's new in the Source Control Plug-in API Version 1.2](../../extensibility/internals/what-s-new-in-the-source-control-plug-in-api-version-1-2.md)