---
description: "Specifies the scope of the disassembly stream."
title: DISASSEMBLY_STREAM_SCOPE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DISASSEMBLY_STREAM_SCOPE
helpviewer_keywords:
- DISASSEMBLY_STREAM_SCOPE enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# DISASSEMBLY_STREAM_SCOPE

Specifies the scope of the disassembly stream.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_DISASSEMBLY_STREAM_SCOPE {
    DSS_HUGE     = 0x10000000,
    DSS_FUNCTION = 0x0001,
    DSS_MODULE   = (DSS_HUGE) | 0x0002,
    DSS_ALL      = (DSS_HUGE) | 0x0003
};
```
### [C++](#tab/cpp)
```cpp
enum enum_DISASSEMBLY_STREAM_SCOPE {
    DSS_HUGE     = 0x10000000,
    DSS_FUNCTION = 0x0001,
    DSS_MODULE   = (DSS_HUGE) | 0x0002,
    DSS_ALL      = (DSS_HUGE) | 0x0003
};
typedef DWORD DISASSEMBLY_STREAM_SCOPE;
```
---

## Fields
`DSS_HUGE`\
Specifies that disassembling the code context would generate more output than a client would typically want to retrieve in a single call.

`DSS_FUNCTION`\
Specifies that the function contained by the code context should be disassembled. Specifies that the disassembly stream represents a function, when returned by the [GetScope](../../../extensibility/debugger/reference/idebugdisassemblystream2-getscope.md) method.

`DSS_MODULE`\
When returned by the `IDebugDisassemblyStream2::GetScope` method, specifies that the disassembly stream represents a module.

`DSS_ALL`\
Specifies disassembly for the entire address space.

## Remarks
Passed as an argument to the [GetDisassemblyStream](../../../extensibility/debugger/reference/idebugprogram2-getdisassemblystream.md) method and returned by the [GetScope](../../../extensibility/debugger/reference/idebugdisassemblystream2-getscope.md) method.

These values may be combined with a bitwise `OR`.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetDisassemblyStream](../../../extensibility/debugger/reference/idebugprogram2-getdisassemblystream.md)
- [GetScope](../../../extensibility/debugger/reference/idebugdisassemblystream2-getscope.md)
