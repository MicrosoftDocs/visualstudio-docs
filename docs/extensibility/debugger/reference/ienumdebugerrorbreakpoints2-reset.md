---
title: "IEnumDebugErrorBreakpoints2::Reset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugErrorBreakpoints2::Reset"
helpviewer_keywords:
  - "IEnumDebugErrorBreakpoints2::Reset"
ms.assetid: d5b04bba-a8b9-4141-94fb-250c77f0534c
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugErrorBreakpoints2::Reset
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
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2-next.md) method returns the first element of the enumeration.

## See also
- [IEnumDebugErrorBreakpoints2](../../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2.md)