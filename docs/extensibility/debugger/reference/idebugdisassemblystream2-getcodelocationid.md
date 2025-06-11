---
description: "Returns a code location identifier for a particular code context."
title: IDebugDisassemblyStream2::GetCodeLocationId
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDisassemblyStream2::GetCodeLocationId
helpviewer_keywords:
- IDebugDisassemblyStream2::GetCodeLocationId
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDisassemblyStream2::GetCodeLocationId

Returns a code location identifier for a particular code context.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCodeLocationId( 
   IDebugCodeContext2 pCodeContext,
   out ulong          puCodeLocationId
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCodeLocationId( 
   IDebugCodeContext2* pCodeContext,
   UINT64*             puCodeLocationId
);
```
---

## Parameters
`pCodeContext`\
[in] An [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object to be converted to an identifier.

`puCodeLocationId`
[out] Returns the code location identifier. See Remarks.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_CODE_CONTEXT_OUT_OF_SCOPE` if the code context is valid but outside the scope.

## Remarks
 The code location identifier is specific to the debug engine (DE) supporting the disassembly. This location identifier is used internally by the DE to track positions in the code and is typically an address or offset of some kind. The only requirement is that if the code context of one location is less than the code context of another location, then the corresponding code location identifier of the first code context must also be less than the code location identifier of the second code context.

 To retrieve the code context of a code location identifier, call the [GetCodeContext](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodecontext.md) method.

## See also
- [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
- [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)
- [GetCodeContext](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodecontext.md)
