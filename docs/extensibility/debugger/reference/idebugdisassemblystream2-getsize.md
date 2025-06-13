---
description: "Gets the size in instructions of this disassembly stream."
title: IDebugDisassemblyStream2::GetSize
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDisassemblyStream2::GetSize
helpviewer_keywords:
- IDebugDisassemblyStream2::GetSize
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDisassemblyStream2::GetSize

Gets the size in instructions of this disassembly stream.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetSize( 
   out ulong pnSize
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetSize( 
   UINT64* pnSize
);
```
---

## Parameters
`pnSize`\
[out] Returns the size, in instructions.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The value returned from this method can be used to allocate an array of [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md) structures which is then passed to the [Read](../../../extensibility/debugger/reference/idebugdisassemblystream2-read.md) method.

## See also
- [IDebugDisassemblyStream2](../../../extensibility/debugger/reference/idebugdisassemblystream2.md)
- [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md)
- [Read](../../../extensibility/debugger/reference/idebugdisassemblystream2-read.md)
