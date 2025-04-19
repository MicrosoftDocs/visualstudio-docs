---
description: Enumerates the various source link blobs contained in the data source. Extends IDiaEnumSourceLink.
title: IDiaEnumSourceLink2
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceLink2 interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaEnumSourceLink2

Enumerates the various source link blobs contained in the data source.

## Syntax

`IDiaEnumSourceLink2 : IDiaEnumSourceLink`

## Methods in Vtable Order

The following table shows the methods of `IDiaEnumSourceLink2`.

|Method|Description|
|------------|-----------------|
|[`IDiaEnumSourceLink2::SizeOfNext2`](../../debugger/debug-interface-access/idiaenumsourcelink2-sizeofnext2.md)|Retrieves the size of the next source link blob, without advancing the enumeration.|
|[`IDiaEnumSourceLink2::Next2`](../../debugger/debug-interface-access/idiaenumsourcelink2-next2.md)|Retrieves the next source link blob and advances the enumeration.|

## Remarks

`IDiaEnumSourceLink2` extends [`IDiaEnumSourceLink`](../../debugger/debug-interface-access/idiaenumsourcelink.md) to support larger source link blobs that might exceed the limits of a `DWORD` (32-bit unsigned integer).

## Notes for Callers

Obtain this interface by calling the [`IDiaSessionEx::getSourceLinkInfo`](../../debugger/debug-interface-access/idiasessionex-getsourcelinkinfo.md) method then calling [`IUnknown::QueryInterface`](/windows/win32/api/unknwn/nf-unknwn-iunknown-queryinterface(refiid_void)) with the `riid` parameter set to `IID_IDiaEnumSourceLink2`.

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [`IDiaSessionEx::getSourceLinkInfo`](../../debugger/debug-interface-access/idiasessionex-getsourcelinkinfo.md)
- [Source Link](https://github.com/dotnet/designs/blob/main/accepted/2020/diagnostics/source-link.md)
- [Using Source Link](https://github.com/dotnet/sourcelink#using-source-link-in-c-projects)
- [/SOURCELINK (Include Source Link file in PDB)](/cpp/build/reference/sourcelink)
- [`IDiaEnumSourceLink`](../../debugger/debug-interface-access/idiaenumsourcelink.md)
