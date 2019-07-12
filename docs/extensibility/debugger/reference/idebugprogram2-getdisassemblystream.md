---
title: "IDebugProgram2::GetDisassemblyStream | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProgram2::GetDisassemblyStream"
helpviewer_keywords:
  - "IDebugProgram2::GetDisassemblyStream"
ms.assetid: beda0da5-267e-4bf3-96c4-b659d29e2254
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProgram2::GetDisassemblyStream
Gets the disassembly stream for this program or a part of this program.

## Syntax

```cpp
HRESULT GetDisassemblyStream( 
   DISASSEMBLY_STREAM_SCOPE   dwScope,
   IDebugCodeContext2*        pCodeContext,
   IDebugDisassemblyStream2** ppDisassemblyStream
);
```

```csharp
int GetDisassemblyStream( 
   enum_DISASSEMBLY_STREAM_SCOPE  dwScope,
   IDebugCodeContext2             pCodeContext,
   out IDebugDisassemblyStream2   ppDisassemblyStream
);
```

## Parameters
`dwScope`\
[in] Specifies a value from the [DISASSEMBLY_STREAM_SCOPE](../../../extensibility/debugger/reference/disassembly-stream-scope.md) enumeration that defines the scope of the disassembly stream.

`pCodeContext`\
[in] An [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object that represents the position of where to start the disassembly stream.

`ppDisassemblyStream`\
[out] Returns an [IDebugDisassemblyStream2](../../../extensibility/debugger/reference/idebugdisassemblystream2.md) object that represents the disassembly stream.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_DISASM_NOTSUPPORTED` if disassembly is not supported for this particular architecture.

## Remarks
 If the `dwScopes` parameter has the `DSS_HUGE` flag of the [DISASSEMBLY_STREAM_SCOPE](../../../extensibility/debugger/reference/disassembly-stream-scope.md) enumeration set, then the disassembly is expected to return a large number of disassembly instructions, for example, for an entire file or module. If the `DSS_HUGE` flag is not set, then the disassembly is expected to be confined to a small region, typically that of a single function.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [DISASSEMBLY_STREAM_SCOPE](../../../extensibility/debugger/reference/disassembly-stream-scope.md)
- [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)
- [IDebugDisassemblyStream2](../../../extensibility/debugger/reference/idebugdisassemblystream2.md)