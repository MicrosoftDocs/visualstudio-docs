---
description: "Specifies the process ID, which may be either a system ID or a GUID."
title: AD_PROCESS_ID
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- AD_PROCESS_ID
helpviewer_keywords:
- AD_PROCESS_ID union
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# AD_PROCESS_ID

Specifies the process ID, which may be either a system ID or a GUID.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct AD_PROCESS_ID {
    AD_PROCESS_ID_TYPE ProcessIdType;
    DWORD              dwProcessId; 
    GUID               guidProcessId; 
    DWORD              dwUnused; 
};
```
### [C++](#tab/cpp)
```cpp
typedef struct _AD_PROCESS_ID {
    AD_PROCESS_ID_TYPE ProcessIdType;
    union {
        DWORD dwProcessId; 
        GUID  guidProcessId; 
        DWORD dwUnused; 
    } ProcessId;
} AD_PROCESS_ID;
```
---

## Members
`ProcessIdType`\
A value from the [AD_PROCESS_ID_TYPE](../../../extensibility/debugger/reference/ad-process-id-type.md) enumeration specifying how to interpret the `ProcessId` union (or, for managed code, which member of the structure to access).

`dwProcessId`\
The process ID as a value from the system.

`guidProcessId`\
The process ID as a GUID.

`dwUnused`\
Padding.

## Remarks
This structure is passed to the following methods:

- [GetProviderProgramNode](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprogramnode.md)

- [WatchForProviderEvents](../../../extensibility/debugger/reference/idebugprogramprovider2-watchforproviderevents.md)

- [GetProviderProcessData](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprocessdata.md)

- [GetProcess](../../../extensibility/debugger/reference/idebugport2-getprocess.md)

And is returned from the following methods:

- [GetPhysicalProcessId](../../../extensibility/debugger/reference/idebugprocess2-getphysicalprocessid.md)

- [GetHostId](../../../extensibility/debugger/reference/idebugprogramhost2-gethostid.md)

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [GetProcess](../../../extensibility/debugger/reference/idebugport2-getprocess.md)
- [PROCESS_INFO](../../../extensibility/debugger/reference/process-info.md)
- [AD_PROCESS_ID_TYPE](../../../extensibility/debugger/reference/ad-process-id-type.md)
- [GetPhysicalProcessId](../../../extensibility/debugger/reference/idebugprocess2-getphysicalprocessid.md)
- [GetHostId](../../../extensibility/debugger/reference/idebugprogramhost2-gethostid.md)
- [GetProviderProgramNode](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprogramnode.md)
- [WatchForProviderEvents](../../../extensibility/debugger/reference/idebugprogramprovider2-watchforproviderevents.md)
- [GetProviderProcessData](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprocessdata.md)
