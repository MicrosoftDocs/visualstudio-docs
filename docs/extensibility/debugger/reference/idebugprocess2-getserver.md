---
title: "IDebugProcess2::GetServer | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProcess2::GetServer"
helpviewer_keywords:
  - "IDebugProcess2::GetServer"
ms.assetid: 8f73c530-cceb-4f1f-8c63-1cc0ccd4a310
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProcess2::GetServer
Gets the server that this process is running on.

## Syntax

```cpp
HRESULT GetServer( 
   IDebugCoreServer2** ppServer
);
```

```csharp
int GetServer( 
   out IDebugCoreServer2 ppServer
);
```

## Parameters
`ppServer`\
[out] Returns an [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md) object that represents the server on which this process is running.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 More than one server can be running on a single machine.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)