---
description: "Retrieves a specified number of records in the enumerated sequence."
title: "IDiaEnumDebugStreamData::Next | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreamData::Next method"
ms.assetid: 114171dd-38fd-4bd7-a702-8ff887ffc99b
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumDebugStreamData::Next
Retrieves a specified number of records in the enumerated sequence.

## Syntax

```C++
HRESULT Next ( 
   ULONG  celt,
   DWORD  cbData,
   DWORD* pcbData,
   BYTE   data[],
   ULONG* pceltFetched
);
```

#### Parameters
 celt

[in] The number of records to be retrieved.

 cbData

[in] Size of the data buffer, in bytes.

 pcbData

[out] Returns the number of bytes returned. If `data` is NULL, then `pcbData` contains the total number of bytes of data available for all requested records.

 data[]

[out] A buffer that is to be filled with the debug stream record data.

 pceltFetched

[in, out] Returns the number of records in `data`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more records. Otherwise, returns an error code.

## See also
- [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md)
- [IDiaEnumDebugStreams::Next](../../debugger/debug-interface-access/idiaenumdebugstreams-next.md)
