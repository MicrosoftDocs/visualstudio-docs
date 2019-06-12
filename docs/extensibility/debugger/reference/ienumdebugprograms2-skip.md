---
title: "IEnumDebugPrograms2::Skip | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugPrograms2::Skip"
helpviewer_keywords:
  - "IEnumDebugPrograms2::Skip"
ms.assetid: b283858b-b375-4760-bfec-ab37de89958d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugPrograms2::Skip
Skips over the specified number of elements.

## Syntax

```cpp
HRESULT Skip(
   ULONG celt
);
```

```csharp
int Skip(
   uint celt
);
```

## Parameters
`celt`\
[in] Number of elements to skip.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if `celt` is greater than the number of remaining elements; otherwise, returns an error code.

## Remarks
 If `celt` specifies a value greater than the number of remaining elements, the enumeration is set to the end and `S_FALSE` is returned.

## See also
- [IEnumDebugPrograms2](../../../extensibility/debugger/reference/ienumdebugprograms2.md)