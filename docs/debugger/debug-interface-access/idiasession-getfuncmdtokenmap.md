---
description: Retrieves the contents of the .NET Native metadata function token map.
title: "IDiaSession::getFuncMDTokenMap"
ms.date: "07/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::getFuncMDTokenMap method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::getFuncMDTokenMap

Retrieves the contents of the .NET Native metadata function token map.

## Syntax

```C++
HRESULT getFuncMDTokenMap(
    DWORD cb,
    DWORD *pcb,
    BYTE *pb
);
```

#### Parameters

 `cb`

[in] The size in bytes of the buffer pointed to by `pb` for receiving the .NET Native metadata function token map.

 `pcb`

[out] Returns the size in bytes of the .NET Native metadata function token map (that is, the number of bytes written into `pb`).

 `pb`

[out] Buffer to receive the contents of the .NET Native metadata function token map. This must be at least `cb` bytes in size.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

 ## Example

 This shows how to retrieve the size of the map and then retrieve the full token map.

 ```C++
DWORD size = 0;
HRESULT hr = pDiaSession->getFuncMDTokenMapSize(&size);
if (FAILED(hr)) {
    return hr;
}
if (size == 0) {
    return S_FALSE;
}

BYTE * map = new (std::nothrow) BYTE[size];
if (map == nullptr) {
    return E_OUTOFMEMORY;
}

hr = pDiaSession->getFuncMDTokenMap(size, &size, map);
if (FAILED(hr)) {
    delete [] map;
    return hr;
}
```

## See also

- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaSession::getFuncMDTokenMapSize`](../../debugger/debug-interface-access/idiasession-getfuncmdtokenmapsize.md)
