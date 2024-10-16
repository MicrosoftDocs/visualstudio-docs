---
description: Retrieves a frame data element by means of an index.
title: "IDiaEnumFrameData::Item"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumFrameData::Item method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumFrameData::Item

Retrieves a frame data element by means of an index.

## Syntax

```c++
HRESULT Item ( 
   DWORD           index,
   IDiaFrameData** section
);
```

#### Parameters

index

[in] Index of the [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumFrameData::get_Count](../../debugger/debug-interface-access/idiaenumframedata-get-count.md) method.

section

[out] Returns an [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) object representing the desired frame data element.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumFrameData](../../debugger/debug-interface-access/idiaenumframedata.md)
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
