---
title: "IEnumDebugCodeContexts2::Reset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugCodeContexts2::Reset"
helpviewer_keywords:
  - "IEnumDebugCodeContexts2::Reset"
ms.assetid: df6cf1e3-2ef8-4d38-81a0-8e9adf151884
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugCodeContexts2::Reset
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
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugcodecontexts2-next.md) method returns the first element of the enumeration.

## See also
- [IEnumDebugCodeContexts2](../../../extensibility/debugger/reference/ienumdebugcodecontexts2.md)