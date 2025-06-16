---
description: "Determines whether a process can be terminated."
title: IDebugPortEx2::CanTerminateProcess
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortEx2::CanTerminateProcess
helpviewer_keywords:
- IDebugPortEx2::CanTerminateProcess
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortEx2::CanTerminateProcess

Determines whether a process can be terminated.

## Syntax

### [C#](#tab/csharp)
```csharp
HRESULT CanTerminateProcess( 
   IDebugProcess2 pPortProcess
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CanTerminateProcess( 
   IDebugProcess2* pPortProcess
);
```
---

## Parameters
`pPortProcess`\
[in] An [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object representing the process to be terminated.

## Return Value
 Returns `S_OK` if the process can be terminated; otherwise, returns `S_FALSE`.

## See also
- [IDebugPortEx2](../../../extensibility/debugger/reference/idebugportex2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
