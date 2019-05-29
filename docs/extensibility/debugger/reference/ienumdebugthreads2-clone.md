---
title: "IEnumDebugThreads2::Clone | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugThreads2::Clone"
helpviewer_keywords:
  - "IEnumDebugThreads2::Clone"
ms.assetid: d774322c-e72d-4df3-b317-928da39dadc5
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugThreads2::Clone
Returns a copy of the current enumeration as a separate object.

## Syntax

```cpp
HRESULT Clone(
   IEnumDebugThreads2** ppEnum
);
```

```csharp
int Clone(
   out IEnumDebugThreads2 ppEnum
);
```

## Parameters
`ppEnum`\
[out] Returns a copy of this enumeration as a separate object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The copy of the enumeration has the same state as the original at the time this method is called. However, the copy's and the original's states are separate and can be changed individually.

## See also
- [IEnumDebugThreads2](../../../extensibility/debugger/reference/ienumdebugthreads2.md)