---
description: "Gets the name of the stack frame."
title: IDebugStackFrame2::GetName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStackFrame2::GetName
helpviewer_keywords:
- IDebugStackFrame2::GetName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugStackFrame2::GetName

Gets the name of the stack frame.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetName ( 
   out string pbstrName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetName ( 
   BSTR* pbstrName
);
```
---

## Parameters
`pbstrName`\
[out] Returns the name of the stack frame.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The name of a stack frame is typically the name of the method being executed.

## See also
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
