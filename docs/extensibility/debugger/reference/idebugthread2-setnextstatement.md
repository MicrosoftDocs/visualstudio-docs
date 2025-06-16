---
description: "Sets the current instruction pointer to the given code context."
title: IDebugThread2::SetNextStatement
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugThread2::SetNextStatement
helpviewer_keywords:
- IDebugThread2::SetNextStatement
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugThread2::SetNextStatement

Sets the current instruction pointer to the given code context.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetNextStatement ( 
   IDebugStackFrame2  pStackFrame,
   IDebugCodeContext2 pCodeContext
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetNextStatement ( 
   IDebugStackFrame2*  pStackFrame,
   IDebugCodeContext2* pCodeContext
);
```
---

## Parameters
`pStackFrame`\
Reserved for future use; set to a null value.

`pCodeContext`\
[in] An [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object that describes the code location about to be executed and its context.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. The following table shows other possible values.

|Value|Description|
|-----------|-----------------|
|E_CANNOT_SET_NEXT_STATEMENT_ON_NONLEAF_FRAME|The next statement cannot be in a stack frame deeper on the frame stack.|
|E_CANNOT_SETIP_TO_DIFFERENT_FUNCTION|The next statement is not associated with any frame in the stack.|
|E_CANNOT_SET_NEXT_STATEMENT_ON_EXCEPTION|Some debug engines cannot set the next statement after an exception.|

## Remarks
 The instruction pointer indicates the next instruction or statement to execute. This method is used to retry a line of source code or to force execution to continue in another function, for example.

## See also
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
- [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)
