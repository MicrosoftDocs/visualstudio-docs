---
title: "IDebugPortEx2::TerminateProcess | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugPortEx2::TerminateProcess"
helpviewer_keywords:
  - "IDebugPortEx2::TerminateProcess"
ms.assetid: bf8fa94c-6d9d-4e4f-ac08-3b44ba5ace68
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugPortEx2::TerminateProcess
Terminates a process.

## Syntax

```cpp
HRESULT TerminateProcess( 
   IDebugProcess2* pPortProcess
);
```

```csharp
int TerminateProcess( 
   IDebugProcess2 pPortProcess
);
```

## Parameters
`pPortProcess`\
[in] An [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object representing the process to be terminated.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortEx2](../../../extensibility/debugger/reference/idebugportex2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)