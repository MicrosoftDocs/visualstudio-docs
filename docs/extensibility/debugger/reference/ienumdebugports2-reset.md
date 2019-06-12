---
title: "IEnumDebugPorts2::Reset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugPorts2::Reset"
helpviewer_keywords:
  - "IEnumDebugPorts2::Reset"
ms.assetid: 67da406c-eadb-421e-ae12-e26e9866f262
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugPorts2::Reset
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
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugports2-next.md) method returns the first element of the enumeration.

## See also
- [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md)