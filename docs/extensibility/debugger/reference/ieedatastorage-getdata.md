---
title: "IEEDataStorage::GetData | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEEDataStorage::GetData"
helpviewer_keywords:
  - "IEEDataStorage::GetData"
ms.assetid: 4d384039-73d4-40b4-ace6-a2474c546397
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEEDataStorage::GetData
Retrieves the specified number of bytes from the object.

## Syntax

```cpp
HRESULT GetData(
   ULONG  dataSize,
   ULONG* sizeGotten,
   BYTE*  data
);
```

```csharp
int GetData(
   uint     dataSize,
   out uint sizeGotten,
   byte[]   data
);
```

## Parameters
`dataSize`\
[in] The number of bytes to retrieve (the `data` array must hold at least this number of bytes).

`sizeGotten`\
[out] Returns the number of bytes actually retrieved.

`data`\
[in, out] Array to be filled in with the requested data.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The recommended use of this method is to retrieve all the data bytes into a local array, since there is no way to skip over bytes in the retrieval process. In this case, the parameter `dataSize` should be the value returned by the [GetSize](../../../extensibility/debugger/reference/ieedatastorage-getsize.md) method.

## See also
- [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)
- [GetSize](../../../extensibility/debugger/reference/ieedatastorage-getsize.md)