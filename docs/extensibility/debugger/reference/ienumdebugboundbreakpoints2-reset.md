---
title: "IEnumDebugBoundBreakpoints2::Reset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugBoundBreakpoints2::Reset"
helpviewer_keywords:
  - "IEnumDebugBoundBreakpoints2::Reset"
ms.assetid: 0f0522a5-6a97-4c4e-859b-cc4476e6c527
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugBoundBreakpoints2::Reset
Resets the enumeration to the first element.

## Syntax

```cpp
HRESULT Reset(
   void
);
```

```csharp
int Reset();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2-next.md) method returns the first element of the enumeration.

## See also
- [IEnumDebugBoundBreakpoints2](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2.md)