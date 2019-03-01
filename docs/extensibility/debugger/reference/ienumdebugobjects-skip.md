---
title: "IEnumDebugObjects::Skip | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugObjects::Skip"
helpviewer_keywords:
  - "IEnumDebugObjects::Skip method"
ms.assetid: 957cead8-0a9c-4403-b190-b9fbadc49d42
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# IEnumDebugObjects::Skip
This method skips over the specified number of elements.

## Syntax

```cpp
HRESULT Skip(
   [in] ULONG celt
);
```

```csharp
int Skip(
   [In] uint celt
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
- [IEnumDebugObjects](../../../extensibility/debugger/reference/ienumdebugobjects.md)