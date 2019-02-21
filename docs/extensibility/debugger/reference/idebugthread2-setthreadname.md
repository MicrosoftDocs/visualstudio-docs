---
title: "IDebugThread2::SetThreadName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugThread2::SetThreadName"
helpviewer_keywords:
  - "IDebugThread2::SetThreadName"
ms.assetid: fa934121-3f58-44dc-9c30-d3f752e44c8b
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugThread2::SetThreadName
Sets the name of the thread.

## Syntax

```cpp
HRESULT SetThreadName ( 
   LPCOLESTR pszName
);
```

```csharp
int SetThreadName ( 
   string pszName
);
```

#### Parameters
 `pszName`

 [in] The name of the thread.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 To get the thread name, call the [GetName](../../../extensibility/debugger/reference/idebugthread2-getname.md) method.

## See Also
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [GetName](../../../extensibility/debugger/reference/idebugthread2-getname.md)