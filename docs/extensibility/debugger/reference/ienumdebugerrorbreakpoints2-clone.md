---
title: "IEnumDebugErrorBreakpoints2::Clone | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugErrorBreakpoints2::Clone"
helpviewer_keywords:
  - "IEnumDebugErrorBreakpoints2::Clone"
ms.assetid: f6fb4985-8dd6-4a9b-98e0-15dbc64cc9ec
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugErrorBreakpoints2::Clone
Returns a copy of the current enumeration as a separate object.

## Syntax

```cpp
HRESULT Clone(
   IEnumDebugErrorBreakpoints2** ppEnum
);
```

```csharp
int Clone(
   out IEnumDebugErrorBreakpoints2 ppEnum
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
- [IEnumDebugErrorBreakpoints2](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2.md)