---
description: "Specifies desired properties to be obtained from a program provider."
title: PROVIDER_FLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- PROVIDER_FLAGS
helpviewer_keywords:
- PROVIDER_FLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# PROVIDER_FLAGS

Specifies desired properties to be obtained from a program provider.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_PROVIDER_FLAGS {
   PFLAG_NONE                    = 0x00,
   PFLAG_REMOTE_PORT             = 0x01,
   PFLAG_DEBUGGEE                = 0x02,
   PFLAG_ATTACHED_TO_DEBUGGEE    = 0x04,
   PFLAG_REASON_WATCH            = 0x08,
   PFLAG_GET_PROGRAM_NODES       = 0x10,
   PFLAG_GET_IS_DEBUGGER_PRESENT = 0x20
};
```
### [C++](#tab/cpp)
```cpp
enum enum_PROVIDER_FLAGS {
   PFLAG_NONE                    = 0x00,
   PFLAG_REMOTE_PORT             = 0x01,
   PFLAG_DEBUGGEE                = 0x02,
   PFLAG_ATTACHED_TO_DEBUGGEE    = 0x04,
   PFLAG_REASON_WATCH            = 0x08,
   PFLAG_GET_PROGRAM_NODES       = 0x10,
   PFLAG_GET_IS_DEBUGGER_PRESENT = 0x20
};
typedef DWORD PROVIDER_FLAGS;
```
---

## Fields
 `PFLAG_NONE`\
 No flags specified.

 `PFLAG_REMOTE_PORT`\
 Caller wants a list of programs on a different machine than Visual Studio.

 `PFLAG_DEBUGGEE`\
 The process is currently being debugged by this instance of Visual Studio.

 `PFLAG_ATTACH_TODEBUGGEE`\
 Visual Studio is attached to the program being debugged but did not launch it.

 `PFLAG_REASON_WATCH`\
 Visual Studio is watching for events.

 `PFLAG_GET_PROGRAM_NODES`\
 Caller wants the `ProgramNodes` field of the [PROVIDER_PROCESS_DATA](../../../extensibility/debugger/reference/provider-process-data.md) structure.

 `PFLAG_GET_IS_DEBUGGER_PRESENT`\
 Caller wants the `fIsTheDebuggerPresent` field of the `PROVIDER_PROCESS_DATA` structure.

## Remarks
 These flags are passed to the following methods:

- [WatchForProviderEvents](../../../extensibility/debugger/reference/idebugprogramprovider2-watchforproviderevents.md)

- [GetProviderProgramNode](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprogramnode.md)

- [GetProviderProcessData](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprocessdata.md)

  These values can be combined with a bitwise `OR`.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [PROVIDER_PROCESS_DATA](../../../extensibility/debugger/reference/provider-process-data.md)
- [WatchForProviderEvents](../../../extensibility/debugger/reference/idebugprogramprovider2-watchforproviderevents.md)
- [GetProviderProgramNode](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprogramnode.md)
- [GetProviderProcessData](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprocessdata.md)
