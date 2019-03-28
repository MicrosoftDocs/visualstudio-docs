---
title: "IEnumDebugCustomAttributes::Reset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumCustomAttributes::Reset"
helpviewer_keywords:
  - "IEnumDebugCustomAttributes::Reset"
ms.assetid: e0db6518-5a71-4adb-a407-4d2ac7a3e369
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# IEnumDebugCustomAttributes::Reset
Resets the enumeration sequence to the beginning.

## Syntax

```cpp
HRESULT Reset(void);
```

```csharp
int Reset();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugcustomattributes-next.md) method returns the first element of the enumeration.

## See Also
- [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md)
- [Next](../../../extensibility/debugger/reference/ienumdebugcustomattributes-next.md)