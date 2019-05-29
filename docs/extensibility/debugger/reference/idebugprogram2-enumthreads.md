---
title: "IDebugProgram2::EnumThreads | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProgram2::EnumThreads"
helpviewer_keywords:
  - "IDebugProgram2::EnumThreads"
ms.assetid: 0f2a8c51-1315-4c96-8aa1-6a937dc2a769
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProgram2::EnumThreads
Retrieves a list of the threads that are running in the program.

## Syntax

```cpp
HRESULT EnumThreads( 
   IEnumDebugThreads2** ppEnum
);
```

```csharp
int EnumThreads( 
   out IEnumDebugThreads2 ppEnum
);
```

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugThreads2](../../../extensibility/debugger/reference/ienumdebugthreads2.md) object that contains a list of the threads.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IEnumDebugThreads2](../../../extensibility/debugger/reference/ienumdebugthreads2.md)
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)