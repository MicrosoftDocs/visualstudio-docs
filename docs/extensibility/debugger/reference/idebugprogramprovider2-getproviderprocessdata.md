---
description: "Retrieves a list of running programs from a specified process."
title: IDebugProgramProvider2::GetProviderProcessData
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramProvider2::GetProviderProcessData
helpviewer_keywords:
- IDebugProgramProvider2::GetProviderProcessData
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramProvider2::GetProviderProcessData

Retrieves a list of running programs from a specified process.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetProviderProcessData(
   enum_PROVIDER_FLAGS     Flags,
   IDebugDefaultPort2      pPort,
   AD_PROCESS_ID           ProcessId,
   CONST_GUID_ARRAY        EngineFilter,
   PROVIDER_PROCESS_DATA[] pProcess
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetProviderProcessData(
   PROVIDER_FLAGS         Flags,
   IDebugDefaultPort2*    pPort,
   AD_PROCESS_ID          processId,
   CONST_GUID_ARRAY       EngineFilter,
   PROVIDER_PROCESS_DATA* pProcess
);
```
---

## Parameters
`Flags`\
[in] A combination of flags from the [PROVIDER_FLAGS](../../../extensibility/debugger/reference/provider-flags.md) enumeration. The following flags are typical for this call:

|Flag|Description|
|----------|-----------------|
|`PFLAG_REMOTE_PORT`|Caller is running on remote machine.|
|`PFLAG_DEBUGGEE`|Caller is currently being debugged (additional information about marshalling will be returned for each node).|
|`PFLAG_ATTACHED_TO_DEBUGGEE`|Caller was attached to but not launched by the debugger.|
|`PFLAG_GET_PROGRAM_NODES`|Caller is asking for a list of program nodes to be returned.|

`pPort`\
[in] The port the calling process is running on.

`processId`\
[in] An [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure holding the ID of the process that contains the program in question.

`EngineFilter`\
[in] An array of GUIDs for debug engines assigned to debug this process (these will be used to filter the programs that are actually returned based on what the supplied engines support; if no engines are specified, then all programs will be returned).

`pProcess`\
[out] A [PROVIDER_PROCESS_DATA](../../../extensibility/debugger/reference/provider-process-data.md) structure that is filled in with the requested information.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is normally called by a process to obtain a list of programs running in that process. The returned information is a list of [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) objects.

## See also
- [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md)
- [IDebugDefaultPort2](../../../extensibility/debugger/reference/idebugdefaultport2.md)
- [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md)
- [CONST_GUID_ARRAY](../../../extensibility/debugger/reference/const-guid-array.md)
- [PROVIDER_FLAGS](../../../extensibility/debugger/reference/provider-flags.md)
- [PROVIDER_PROCESS_DATA](../../../extensibility/debugger/reference/provider-process-data.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
