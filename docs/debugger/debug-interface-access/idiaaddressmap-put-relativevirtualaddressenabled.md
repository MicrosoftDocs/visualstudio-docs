---
description: "Allows the client to enable or disable the calculation and use of relative virtual addresses (RVA)."
title: "IDiaAddressMap::put_relativeVirtualAddressEnabled | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaAddressMap::put_relativeVirtualAddressEnabled method"
ms.assetid: 767c078e-8ad7-4940-9e00-cae7704aadee
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaAddressMap::put_relativeVirtualAddressEnabled
Allows the client to enable or disable the calculation and use of relative virtual addresses (RVA).

## Syntax

```C++
HRESULT put_relativeVirtualAddressEnabled ( 
   BOOL NewVal
);
```

#### Parameters
 NewVal

[in] Set to `TRUE` to enable, or `FALSE` to disable.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Addresses for debug objects described by DIA interfaces, and relative to the executable's image base, can be retrieved as relative virtual addresses.

 The use of RVAs is enabled when segments are initially loaded from a PDB file. To get the current state of the use of RVAs, call the [IDiaAddressMap::get_relativeVirtualAddressEnabled](../../debugger/debug-interface-access/idiaaddressmap-get-relativevirtualaddressenabled.md) method.

 The `put_relativeVirtualAddress` method must be called to enable RVAs after a successful call to the [IDiaAddressMap::set_imageHeaders](../../debugger/debug-interface-access/idiaaddressmap-set-imageheaders.md) method has established new image headers.

## See also
- [IDiaAddressMap](../../debugger/debug-interface-access/idiaaddressmap.md)
- [IDiaAddressMap::get_relativeVirtualAddressEnabled](../../debugger/debug-interface-access/idiaaddressmap-get-relativevirtualaddressenabled.md)
- [IDiaAddressMap::set_imageHeaders](../../debugger/debug-interface-access/idiaaddressmap-set-imageheaders.md)
