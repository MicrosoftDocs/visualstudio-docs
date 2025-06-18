---
description: Enumerates the various source link blobs contained in the data source.
title: IDiaEnumSourceLink
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSourceLink interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaEnumSourceLink

Enumerates the various source link blobs contained in the data source.

## Syntax

`IDiaEnumSourceLink : IUnknown`

## Methods in Vtable Order

The following table shows the methods of `IDiaEnumSourceLink`.

|Method|Description|
|------------|-----------------|
|[`IDiaEnumSourceLink::Count`](../../debugger/debug-interface-access/idiaenumsourcelink-count.md)|Retrieves the number of source link blobs.|
|[`IDiaEnumSourceLink::SizeOfNext`](../../debugger/debug-interface-access/idiaenumsourcelink-sizeofnext.md)|Retrieves the size of the next source link blob, without advancing the enumeration.|
|[`IDiaEnumSourceLink::Next`](../../debugger/debug-interface-access/idiaenumsourcelink-next.md)|Retrieves the next source link blob and advances the enumeration.|
|[`IDiaEnumSourceLink::Skip`](../../debugger/debug-interface-access/idiaenumsourcelink-skip.md)|Skips a specified number of source link blobs in an enumeration sequence.|
|[`IDiaEnumSourceLink::Reset`](../../debugger/debug-interface-access/idiaenumsourcelink-reset.md)|Resets an enumeration sequence to the beginning.|
|[`IDiaEnumSourceLink::Clone`](../../debugger/debug-interface-access/idiaenumsourcelink-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|

## Remarks

Although [Source Link](https://github.com/dotnet/designs/blob/main/accepted/2020/diagnostics/source-link.md) is a well defined standard, the PDB and Debug Interface Access (DIA) SDK only have limited support for it. Specifically the DIA SDK treats the source link as a simple blob of bytes. It is the responsibility of the caller to interpret those bytes as the correct character encoding (UTF-8, ASCII, and so on), parse as a JSON file, enforce a particular schema, or use that information to map and download individual source files.

## Notes for Callers

Obtain this interface by calling the [`IDiaSessionEx::getSourceLinkInfo`](../../debugger/debug-interface-access/idiasessionex-getsourcelinkinfo.md) method.

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [`IDiaSessionEx::getSourceLinkInfo`](../../debugger/debug-interface-access/idiasessionex-getsourcelinkinfo.md)
- [Source Link](https://github.com/dotnet/designs/blob/main/accepted/2020/diagnostics/source-link.md)
- [Using Source Link](https://github.com/dotnet/sourcelink#using-source-link-in-c-projects)
- [/SOURCELINK (Include Source Link file in PDB)](/cpp/build/reference/sourcelink)
- [`IDiaEnumSourceLink2`](../../debugger/debug-interface-access/idiaenumsourcelink2.md)
