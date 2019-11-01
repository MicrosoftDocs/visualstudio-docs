---
title: "IDebugPort2::GetProcess | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugPort2::GetPortSupplier"
helpviewer_keywords:
  - "IDebugPort2::GetPortSupplier"
ms.assetid: 3e2431b0-0e19-450d-8e1d-d7c314c8f872
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugPort2::GetProcess
Gets the specified process running on a port.

## Syntax

```cpp
HRESULT GetProcess( 
   AD_PROCESS_ID    ProcessId,
   IDebugProcess2** ppProcess
);
```

```csharp
int GetProcess( 
   AD_PROCESS_ID      ProcessId,
   out IDebugProcess2 ppProcess
);
```

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