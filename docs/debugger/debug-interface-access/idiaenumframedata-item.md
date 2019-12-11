---
title: "IDiaEnumFrameData::Item | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumFrameData::Item method"
ms.assetid: 2761a72d-1868-4f5b-a32e-c2a1d9358c91
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumFrameData::Item
Retrieves a frame data element by means of an index.

## Syntax

```C++
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