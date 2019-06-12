---
title: "IEnumDebugAddresses::Reset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugAddresses::Reset"
helpviewer_keywords:
  - "IEnumDebugAddresses::Reset method"
ms.assetid: 3a9d7f20-5bc6-4e13-8e91-5af4092e092f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugAddresses::Reset
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
 After this method is called, the next call to [Next](../../../extensibility/debugger/reference/ienumdebugaddresses-next.md) returns the first element of the enumeration.

## See also
- [IEnumDebugAddresses](../../../extensibility/debugger/reference/ienumdebugaddresses.md)
- [Next](../../../extensibility/debugger/reference/ienumdebugaddresses-next.md)