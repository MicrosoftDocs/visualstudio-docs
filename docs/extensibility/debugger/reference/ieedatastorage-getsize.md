---
description: "Returns the number of bytes contained in this object."
title: IEEDataStorage::GetSize | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEDataStorage::GetSize
helpviewer_keywords:
- IEEDataStorage::GetSize
ms.assetid: 33d232c4-1239-4abc-922b-e1bc5b908169
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IEEDataStorage::GetSize

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Returns the number of bytes contained in this object.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetSize(
   out uint size
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetSize(
   ULONG* size
);
```
---

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
