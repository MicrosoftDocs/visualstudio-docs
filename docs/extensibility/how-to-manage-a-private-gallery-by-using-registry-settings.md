---
title: Manage a private gallery by using registry settings
description: Learn how to control access to the controls, templates, and tools in the Visual Studio Gallery, the Samples Gallery, or private galleries.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- VSIX private galleries, managing
- managing VSIX private galleries
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Manage a private gallery by using registry settings

If you are an administrator or the developer of a Visual Studio extension, you can control access to the controls, templates, and tools in the Visual Studio Gallery, the Samples Gallery, or private galleries. To make a gallery available or unavailable, create a *.pkgdef* file that describes the modified registry keys and their values.

## Manage private galleries
 You can create a *.pkgdef* file to control access to galleries on multiple computers. This file must have the following format.

```
[$RootKey$\ExtensionManager\Repositories\{UniqueGUID}]
@={URI}  (REG_SZ)
Disabled=0 | 1 (DWORD)
Priority=0 (highest priority) ... MaxInt (lowest priority) (DWORD) (uint)
Protocol=Atom Feed|Sharepoint (REG_SZ)
DisplayName={DisplayName} (REG_SZ)
DisplayNameResourceID={ID} (REG_SZ)
DisplayNamePackageGuid={GUID} (REG_SZ)

```

 The `Repositories` key refers to the gallery to be enabled or disabled. The Visual Studio Gallery and the Samples Gallery use the following repository GUIDs:

- Visual Studio Gallery : 0F45E408-7995-4375-9485-86B8DB553DC9

- Samples Gallery : AEB9CB40-D8E6-4615-B52C-27E307F8506C

  The `Disabled` value is optional. By default, a gallery is enabled.

  The `Priority` value determines the order in which the galleries are listed in the **Options** dialog box. Visual Studio Gallery has priority 10 and the Samples Gallery has priority 20. Private galleries start at priority 100. If several galleries have the same priority value, the order in which they appear is determined by the values of their localized `DisplayName` attributes.

  The `Protocol` value is required for Atom-based or SharePoint-based galleries.

  Either `DisplayName`, or both `DisplayNameResourceID` and `DisplayNamePackageGuid`, must be specified. If all are specified, then the `DisplayNameResourceID` and `DisplayNamePackageGuid` pair is used.

## Disable the Visual Studio Gallery using a .pkgdef file
 You can disable a gallery in a *.pkgdef* file. The following entry disables the Visual Studio Gallery:

```
[$RootKey$\ExtensionManager\Repositories\{0F45E408-7995-4375-9485-86B8DB553DC9}]
"Disabled"=dword:00000001

```

 The following entry disables the Samples Gallery:

```
[$RootKey$\ExtensionManager\Repositories\{AEB9CB40-D8E6-4615-B52C-27E307F8506C}]
"Disabled"=dword:00000001

```

## Related content
- [Private galleries](../extensibility/private-galleries.md)
