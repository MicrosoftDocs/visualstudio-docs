---
description: "Returns a list of all the processes running on a port."
title: IDebugPort2::EnumProcesses
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPort2::EnumProcesses
helpviewer_keywords:
- IDebugPort2::EnumProcesses
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPort2::EnumProcesses

Returns a list of all the processes running on a port.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumProcesses( 
   out IEnumDebugProcesses2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumProcesses( 
   IEnumDebugProcesses2** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugProcesses2](../../../extensibility/debugger/reference/ienumdebugprocesses2.md) object that contains a list of all the processes running on a port.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
- [IEnumDebugProcesses2](../../../extensibility/debugger/reference/ienumdebugprocesses2.md)
