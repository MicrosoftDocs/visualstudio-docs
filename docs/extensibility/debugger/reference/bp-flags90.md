---
description: "Enumerates valid values for optional flags."
title: BP_FLAGS90
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- BP_FLAGS90 enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BP_FLAGS90

Enumerates valid values for optional flags. The optional flags may be used to specify additional information when you set a breakpoint. This enumeration extends the [BP_FLAGS](../../../extensibility/debugger/reference/bp-flags.md) enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_BP_FLAGS90
{
    // VS 8.0 values
    BP90_FLAG_NONE                = 0x0000,
    BP90_FLAG_MAP_DOCPOSITION     = 0x0001,
    BP90_FLAG_DONT_STOP           = 0x0002,

    // Values added in VS 9.0
    BP90_FLAG_TRACEPOINT_CONTINUE = 0x0004,
};
```
### [C++](#tab/cpp)
```cpp
enum enum_BP_FLAGS90
{
    // VS 8.0 values
    BP90_FLAG_NONE               = 0x0000,
    BP90_FLAG_MAP_DOCPOSITION    = 0x0001,
    BP90_FLAG_DONT_STOP          = 0x0002,

    // Values added in VS 9.0
    BP90_FLAG_TRACEPOINT_CONTINUE = 0x0004,
};
typedef DWORD BP_FLAGS90;
```
---

## Fields
`BP90_FLAG_NONE`\
Specifies no breakpoint flag.

`BP90_FLAG_MAP_DOCPOSITION`\
Specifies that the debug engine (DE) should map the breakpoint by using the document position. This is applicable only to breakpoints set in script-oriented source files such as Active Server Pages (ASP).

`BP90_FLAG_DONT_STOP`\
Specifies that the breakpoint should be processed by the debug engine, but that the debug engine ultimately should not stop there; that is, an [IDebugBreakpointEvent2](../../../extensibility/debugger/reference/idebugbreakpointevent2.md) event object should not be sent. This flag is designed to be used primarily with trace points.

`BP90_FLAG_TRACEPOINT_CONTINUE`\
Used by the native debug engine to determine whether the stepping state should be cleared. It differs from BP90_FLAG_DONT_STOP because BP90_FLAG_DONT_STOP is not set if the trace point executes a macro.

## Requirements
Header: Msdbg90.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
