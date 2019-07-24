---
title: "IEEDataStorage::GetSize | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEEDataStorage::GetSize"
helpviewer_keywords:
  - "IEEDataStorage::GetSize"
ms.assetid: 33d232c4-1239-4abc-922b-e1bc5b908169
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEEDataStorage::GetSize
Returns the number of bytes contained in this object.

## Syntax

```cpp
HRESULT GetSize(
   ULONG* size
);
```

```csharp
int GetSize(
   out uint size
);
```

## Parameters
`size`\
[out] The number of bytes contained in this object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Use the [GetData](../../../extensibility/debugger/reference/ieedatastorage-getdata.md) method to retrieve the actual data bytes.

## See also
- [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)
- [GetData](../../../extensibility/debugger/reference/ieedatastorage-getdata.md)