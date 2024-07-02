---
description: Retrieves the size, in bytes, of the named stream.
title: "IDiaDataSourceEx::getStreamSize"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSourceEx::getStreamSize method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSource::getStreamSize

Retrieves the size, in bytes, of the named stream.

## Syntax

```c++
HRESULT getStreamSize (
   LPCOLESTR  stream,
   ULONGLONG* pcb
);
```

#### Parameters

`stream`

[in] The name of the stream within the debug information.

`pcb`

[out] The size in bytes of the named stream.

## Return Value

If successful, returns `S_OK`. If the named stream does not exist within the PDB, the API might fail, or it i might return a length of 0.

## Remarks

Program Databases are made up of multiple streams of data. Some of those streams are named. You can use this method to gather information about these named streams.

To get the data of the stream, use the [`IDiaDataSourceEx::getStreamRawData`](../../debugger/debug-interface-access/idiadatasourceex-getstreamrawdata.md) method.

## Example

```c++
ULONGLONG countBytes = 0;
HRESULT hr = pSource->getStreamSize( L"/names", &countBytes );
```

## See also

- [`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceex.md)
- [`IDiaDataSourceEx::getStreamRawData`](../../debugger/debug-interface-access/idiadatasourceex-getstreamrawdata.md)
