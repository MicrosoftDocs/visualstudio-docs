---
title: "IEnumDebugObjects::Reset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugObjects::Reset"
helpviewer_keywords:
  - "IEnumDebugObjects::Reset method"
ms.assetid: 4a245e47-cc39-4177-b83d-083ea0e3190f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugObjects::Reset
This method resets the enumeration to the first element.

## Syntax

```cpp
HRESULT Reset(void);
```

```csharp
int Reset();
```

## Parameters
 None

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 After this method is called, the next call to [Next](../../../extensibility/debugger/reference/ienumdebugobjects-next.md) returns the first element of the enumeration.

## See also
- [IEnumDebugObjects](../../../extensibility/debugger/reference/ienumdebugobjects.md)
- [Next](../../../extensibility/debugger/reference/ienumdebugobjects-next.md)