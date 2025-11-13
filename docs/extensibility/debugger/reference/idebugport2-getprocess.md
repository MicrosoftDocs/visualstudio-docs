---
description: "Gets the specified process running on a port."
title: IDebugPort2::GetProcess
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPort2::GetPortSupplier
helpviewer_keywords:
- IDebugPort2::GetPortSupplier
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPort2::GetProcess

Gets the specified process running on a port.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetProcess( 
   AD_PROCESS_ID      ProcessId,
   out IDebugProcess2 ppProcess
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetProcess( 
   AD_PROCESS_ID    ProcessId,
   IDebugProcess2** ppProcess
);
```
---

## Parameters
`ProcessId`\
[in] An [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure that specifies the process identifier.

`ppProcess`\
[out] Returns an [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object representing the process.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md)
