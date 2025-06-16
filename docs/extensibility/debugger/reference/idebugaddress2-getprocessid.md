---
description: "Retrieves the ID of the process that owns the object represented by this IDebugAddress2 interface."
title: IDebugAddress2::GetProcessID
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugAddress2::GetProcessID
helpviewer_keywords:
- IDebugAddress2::GetProcessID method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugAddress2::GetProcessID

Retrieves the ID of the process that owns the object represented by this [IDebugAddress2](../../../extensibility/debugger/reference/idebugaddress2.md) interface.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetProcessID (
   out uint pProcID
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetProcessID (
   DWORD* pProcID
);
```
---

## Parameters
`pProcID`\
[out] The process ID.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## See also
- [IDebugAddress2](../../../extensibility/debugger/reference/idebugaddress2.md)
