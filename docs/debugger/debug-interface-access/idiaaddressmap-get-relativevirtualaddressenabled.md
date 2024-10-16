---
description: Indicates whether the calculation and use of relative virtual addresses (RVA) is enabled.
title: "IDiaAddressMap::get_relativeVirtualAddressEnabled"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaAddressMap::get_relativeVirtualAddressEnabled method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaAddressMap::get_relativeVirtualAddressEnabled

Indicates whether the calculation and use of relative virtual addresses (RVA) is enabled.

## Syntax

```c++
HRESULT get_relativeVirtualAddressEnabled ( 
   BOOL* pRetVal
);
```

#### Parameters

pRetVal

[out] Returns `TRUE` if the calculation of RVAs is enabled.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks

RVAs are enabled if the segments have been initially loaded from a PDB file. The use of RVAs can be temporarily disabled by calling the [IDiaAddressMap::put_relativeVirtualAddressEnabled](../../debugger/debug-interface-access/idiaaddressmap-put-relativevirtualaddressenabled.md) method.

Also, new image headers can be established by calling the [IDiaAddressMap::set_imageHeaders](../../debugger/debug-interface-access/idiaaddressmap-set-imageheaders.md) method followed by a call to the `put_relativeVirtualAddressEnabled` method to enable use of the RVAs using the new image headers.

## See also

- [IDiaAddressMap](../../debugger/debug-interface-access/idiaaddressmap.md)
- [IDiaAddressMap::set_imageHeaders](../../debugger/debug-interface-access/idiaaddressmap-set-imageheaders.md)
- [IDiaAddressMap::put_relativeVirtualAddressEnabled](../../debugger/debug-interface-access/idiaaddressmap-put-relativevirtualaddressenabled.md)
