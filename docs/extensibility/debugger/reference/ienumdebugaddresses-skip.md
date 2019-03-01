---
title: "IEnumDebugAddresses::Skip | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugAddresses::Skip"
helpviewer_keywords:
  - "IEnumDebugAddresses::Skip method"
ms.assetid: ed9a8e71-30ef-414b-9da5-c9a2a251b84e
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# IEnumDebugAddresses::Skip
This method skips over the specified number of elements.

## Syntax

```cpp
HRESULT Skip(
   [in] ULONG celt
);
```

```csharp
int Skip(
   uint celt
);
```

#### Parameters
 `celt`

 [in] Number of elements to skip.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if `celt` is greater than the number of remaining elements; otherwise, returns an error code.

## Remarks
 If `celt` specifies a value greater than the number of remaining elements, the enumeration is set to the end and `S_FALSE` is returned.

## See Also
- [IEnumDebugAddresses](../../../extensibility/debugger/reference/ienumdebugaddresses.md)