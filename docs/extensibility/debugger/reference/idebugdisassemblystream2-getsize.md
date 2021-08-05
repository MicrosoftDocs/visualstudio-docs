---
description: "Gets the size in instructions of this disassembly stream."
title: IDebugDisassemblyStream2::GetSize | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDisassemblyStream2::GetSize
helpviewer_keywords:
- IDebugDisassemblyStream2::GetSize
ms.assetid: 8f512704-12d0-46d2-959a-4f8dffe117b5
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugDisassemblyStream2::GetSize
Gets the size in instructions of this disassembly stream.

## Syntax

```cpp
HRESULT GetSize( 
   UINT64* pnSize
);
```

```csharp
int GetSize( 
   out ulong pnSize
);
```

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
