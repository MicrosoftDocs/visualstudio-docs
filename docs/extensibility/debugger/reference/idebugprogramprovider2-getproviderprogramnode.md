---
description: "Retrieves the program node for a specific program."
title: IDebugProgramProvider2::GetProviderProgramNode
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramProvider2::GetProviderProgramNode
helpviewer_keywords:
- IDebugProgramProvider2::GetProviderProgramNode
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramProvider2::GetProviderProgramNode

Retrieves the program node for a specific program.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetProviderProgramNode(
   enum_PROVIDER_FLAGS    Flags,
   IDebugDefaultPort2     pPort,
   AD_PROCESS_ID          ProcessId,
   ref Guid               guidEngine,
   ulong                  programId,
   out IDebugProgramNode2 ppProgramNode
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetProviderProgramNode(
   PROVIDER_FLAGS       Flags,
   IDebugDefaultPort2*  pPort,
   AD_PROCESS_ID        processId,
   REFGUID              guidEngine,
   UINT64               programId,
   IDebugProgramNode2** ppProgramNode
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

`pPort`\
[in] The port the calling process is running on.

`processId`\
[in] An [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure holding the ID of the process that contains the program in question.

`guidEngine`\
[in] GUID of the debug engine that the program is attached to (if any).

`programId`\
[in] ID of the program for which to get the program node.

`ppProgramNode`\
[out] An [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) object representing the requested program node.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md)
- [PROVIDER_FLAGS](../../../extensibility/debugger/reference/provider-flags.md)
- [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md)
- [IDebugDefaultPort2](../../../extensibility/debugger/reference/idebugdefaultport2.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
