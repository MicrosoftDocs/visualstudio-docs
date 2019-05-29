---
title: "IDebugStackFrame3::GetUnwindCodeContext | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugStackFrame3::GetUnwindCodeContext"
helpviewer_keywords:
  - "IDebugStackFrame3::GetUnwindCodeContext method"
ms.assetid: b25f7e7d-2b24-48e4-93b3-829e61d73ebf
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugStackFrame3::GetUnwindCodeContext
Returns the code context representing a location if a stack unwind operation occurred.

## Syntax

```cpp
HRESULT GetUnwindCodeContext(
   IDebugCodeContext2 **ppCodeContext
);
```

```csharp
int GetUnwindCodeContext(
   out IDebugCodeContext2 ppCodeContext
);
```

## Parameters
`ppCodeContext`\
[out] Returns an [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object that represents the code context location if a stack unwind occurred.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Even though this method might return a code context for the location after a stack unwind, it does not necessarily mean the stack unwind can actually occur in the current stack frame.

## See also
- [IDebugStackFrame3](../../../extensibility/debugger/reference/idebugstackframe3.md)
- [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)