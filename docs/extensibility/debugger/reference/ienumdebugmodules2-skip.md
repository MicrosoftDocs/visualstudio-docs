---
title: "IEnumDebugModules2::Skip | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugModules2::Skip"
helpviewer_keywords:
  - "IEnumDebugModules2::Skip"
ms.assetid: 61dc42f4-8544-45bb-8da0-fb22cccec7da
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugModules2::Skip
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
- [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md)