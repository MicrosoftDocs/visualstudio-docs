---
title: "IEnumDebugCodeContexts2::Clone | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugCodeContexts2::Clone"
helpviewer_keywords:
  - "IEnumDebugCodeContexts2::Clone"
ms.assetid: 22c98975-4294-4fbd-a345-16f65fe1200d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugCodeContexts2::Clone
Returns a copy of the current enumeration as a separate object.

## Syntax

```cpp
HRESULT Clone(
   IEnumDebugCodeContexts2** ppEnum
);
```

```csharp
int Clone(
   out IEnumDebugCodeContexts2 ppEnum
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
- [IEnumDebugCodeContexts2](../../../extensibility/debugger/reference/ienumdebugcodecontexts2.md)