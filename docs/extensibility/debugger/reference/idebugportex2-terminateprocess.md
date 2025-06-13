---
description: "IDebugPortEx2::TerminateProcess terminates a process."
title: IDebugPortEx2::TerminateProcess
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortEx2::TerminateProcess
helpviewer_keywords:
- IDebugPortEx2::TerminateProcess
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortEx2::TerminateProcess

Terminates a process.

## Syntax

### [C#](#tab/csharp)
```csharp
int TerminateProcess( 
   IDebugProcess2 pPortProcess
);
```
### [C++](#tab/cpp)
```cpp
HRESULT TerminateProcess( 
   IDebugProcess2* pPortProcess
);
```
---

## Parameters
`pPortProcess`\
[in] An [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object representing the process to be terminated.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortEx2](../../../extensibility/debugger/reference/idebugportex2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
