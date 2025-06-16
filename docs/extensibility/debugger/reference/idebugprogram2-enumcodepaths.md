---
description: "Retrieves a list of the code paths for a given position in a source file."
title: IDebugProgram2::EnumCodePaths
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::EnumCodePaths
helpviewer_keywords:
- IDebugProgram2::EnumCodePaths
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::EnumCodePaths

Retrieves a list of the code paths for a given position in a source file.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumCodePaths( 
   string                 pszHint,
   IDebugCodeContext2     pStart,
   IDebugStackFrame2      pFrame,
   Int                    fSource,
   out IEnumCodePaths2    ppEnum,
   out IDebugCodeContext2 ppSafety
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumCodePaths( 
   LPCOLESTR            pszHint,
   IDebugCodeContext2*  pStart,
   IDebugStackFrame2*   pFrame,
   BOOL                 fSource,
   IEnumCodePaths2**    ppEnum,
   IDebugCodeContext2** ppSafety
);
```
---

## Parameters
`pszHint`\
[in] The word under the cursor in the **Source** or **Disassembly** view in the IDE.

`pStart`\
[in] An [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object representing the current code context.

`pFrame`\
[in] An [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md) object representing the stack frame associated with the current breakpoint.

`fSource`\
[in] Nonzero (`TRUE`) if in the **Source** view, or zero (`FALSE`) if in the **Disassembly** view.

`ppEnum`\
[out] Returns an [IEnumCodePaths2](../../../extensibility/debugger/reference/ienumcodepaths2.md) object containing a list of the code paths.

`ppSafety`\
[out] Returns an [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object representing an additional code context to be set as a breakpoint in case the chosen code path is skipped. This can happen in the case of a short-circuited Boolean expression, for example.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A code path describes the name of a method or function that was called to get to the current point in the execution of the program. A list of code paths represents the call stack.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IEnumCodePaths2](../../../extensibility/debugger/reference/ienumcodepaths2.md)
- [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
