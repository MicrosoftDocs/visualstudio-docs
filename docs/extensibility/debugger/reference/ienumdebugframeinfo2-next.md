---
title: "IEnumDebugFrameInfo2::Next | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugFrameInfo2::Next"
helpviewer_keywords:
  - "IEnumDebugFrameInfo2::Next"
ms.assetid: 64a64eeb-5dea-4119-8a22-03771015d1e5
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugFrameInfo2::Next
Returns the next set of elements from the enumeration.

## Syntax

```cpp
HRESULT Next(
   ULONG       celt,
   FRAMEINFO** rgelt,
   ULONG*      pceltFetched
);
```

```csharp
int Next(
   uint        celt,
   FRAMEINFO[] rgelt,
   ref uint    pceltFetched
);
```

## Parameters
`celt`\
[in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.

`rgelt`\
[in, out] Array of [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) elements to be filled in.

`pceltFetched`\
[out] Returns the number of elements actually returned in `rgelt`.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.

## See also
- [IEnumDebugFrameInfo2](../../../extensibility/debugger/reference/ienumdebugframeinfo2.md)
- [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md)