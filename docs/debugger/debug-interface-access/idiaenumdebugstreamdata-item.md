---
description: Retrieves the specified record.
title: "IDiaEnumDebugStreamData::Item"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreamData::Item method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumDebugStreamData::Item

Retrieves the specified record.

## Syntax

```c++
HRESULT Item ( 
   DWORD  index,
   DWORD  cbData,
   DWORD* pcbData,
   BYTE   data[]
);
```

#### Parameters

index

[in] Index of the record to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by [IDiaEnumDebugStreamData::get_Count](../../debugger/debug-interface-access/idiaenumdebugstreamdata-get-count.md).

cbData

[in] Size of the data buffer, in bytes.

pcbData

[out] Returns the number of bytes returned. If `data` is `NULL`, then `pcbData` contains the total number of bytes of data available in the specified record.

data[]

[out] A buffer that is filled in with the debug stream record data.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_INVALIDARG` for invalid parameters and if the `index` parameter is out of bounds.

## See also

- [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md)
- [IDiaEnumDebugStreamData::Next](../../debugger/debug-interface-access/idiaenumdebugstreamdata-next.md)
- [IDiaEnumDebugStreams::Item](../../debugger/debug-interface-access/idiaenumdebugstreams-item.md)
- [IDiaEnumDebugStreamData::get_Count](../../debugger/debug-interface-access/idiaenumdebugstreamdata-get-count.md)
- [IDiaEnumDebugStreamData::Skip](../../debugger/debug-interface-access/idiaenumdebugstreamdata-skip.md)
