---
description: Retrieves the raw bytes of the named stream.
title: "IDiaDataSourceEx::getStreamRawData"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSourceEx::getStreamRawData method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSource::getStreamRawData

Retrieves the raw bytes of the named stream.

## Syntax

```c++
HRESULT getStreamRawData (
   LPCOLESTR  stream,
   ULONGLONG  cbOffset,
   ULONGLONG  cbRead,
   ULONGLONG* pcbRead,
   BYTE*      pbData
);
```

#### Parameters

`stream`

[in] The name of the stream within the debug information.

`cbOffset`

[in] The offset within the stream to begin reading data from.

`cbRead`

[in] The number of bytes to retrieve.

`pcbRead`

[out] The number of bytes actually read from the stream.

`pbData`

[out] The location to store the read data. On input must be at least `cbRead` bytes in size. Upon successful return `*pcbRead` bytes will be valid.

## Return Value

If successful, returns `S_OK`. If the named stream does not exist within the PDB, the API might fail, or it might return a length of 0.

## Remarks

Program Databases are made up of multiple streams of data. Some of those streams are named. You can use this method to gather information about these named streams.

To get the size of the stream, use the [`IDiaDataSourceEx::getStreamSize`](../../debugger/debug-interface-access/idiadatasourceex-getstreamsize.md) method.

## Example

```c++
ULONGLONG countBytes = 0;
LPCOLESTR stream = L"/names";
HRESULT hr = pSource->getStreamSize( stream, &countBytes );
if (SUCCEEDED(hr)) {
  for (ULONGLONG cbOffset = 0, cbRead = 0; cbOffset < countBytes; cbOffset += cbRead) {
    BYTE buffer[100];
    cbRead = 0;
    hr = pSource->getStreamRawBytes( stream, cbOffset, std::min(countBytes - cbOffset, sizeof(buffer)), &cbRead, buffer);
    if (SUCCEEDED(hr)) {
      ...
```

## See also

- [`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceex.md)
- [`IDiaDataSourceEx::getStreamSize`](../../debugger/debug-interface-access/idiadatasourceex-getstreamsize.md)
