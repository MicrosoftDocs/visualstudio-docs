---
description: "Skips over the specified number of elements in the bound breakpoints enumeration."
title: IEnumDebugBoundBreakpoints2::Skip | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugBoundBreakpoints2::Skip
helpviewer_keywords:
- IEnumDebugBoundBreakpoints2::Skip
ms.assetid: 95659709-6d7c-44ca-b598-629eb688429f
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
# IEnumDebugBoundBreakpoints2::Skip

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Skips over the specified number of elements.

## Syntax

### [C#](#tab/csharp)
```csharp
int Skip(
   uint celt
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Skip(
   ULONG celt
);
```
---

## Parameters
`celt`\
[in] Number of elements to skip.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if `celt` is greater than the number of remaining elements; otherwise, returns an error code.

## Remarks
 If `celt` specifies a value greater than the number of remaining elements, the enumeration is set to the end and `S_FALSE` is returned.

## See also
- [IEnumDebugBoundBreakpoints2](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2.md)
