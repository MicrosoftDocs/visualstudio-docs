---
description: "Returns the next set of elements from the ports enumeration."
title: IEnumDebugPorts2::Next | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugPorts2::Next
helpviewer_keywords:
- IEnumDebugPorts2::Next
ms.assetid: 3f43d18c-6bd1-4ddd-95ef-9550abd2ad09
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
# IEnumDebugPorts2::Next

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Returns the next set of elements from the enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
int Next(
   uint          celt,
   IDebugPort2[] rgelt,
   ref uint      pceltFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Next(
   ULONG         celt,
   IDebugPort2** rgelt,
   ULONG*        pceltFetched
);
```
---

## Parameters
`celt`\
[in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.

`rgelt`\
[in, out] Array of [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) elements to be filled in.

`pceltFetched`\
[out] Returns the number of elements actually returned in `rgelt`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.

## See also
- [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md)
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
