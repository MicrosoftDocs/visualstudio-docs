---
description: "Retrieves a description of the machine the core server is running on."
title: IDebugCoreServer2::GetMachineInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer2::GetInfo
helpviewer_keywords:
- IDebugCoreServer2::GetInfo
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCoreServer2::GetMachineInfo

Retrieves a description of the machine the core server is running on.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMachineInfo( 
   enum_ MACHINE_INFO_FIELDS  Fields,
   MACHINE_INFO[]             pMachineInfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMachineInfo( 
   MACHINE_INFO_FIELDS Fields,
   MACHINE_INFO*       pMachineInfo
);
```
---

## Parameters
`Fields`\
[in] A combination of flags from the [MACHINE_INFO_FIELDS](../../../extensibility/debugger/reference/machine-info-fields.md) enumeration that specify which fields of `pMachineInfo` are to be filled out.

 `pMachineInfo`\

 [in, out] A [MACHINE_INFO](../../../extensibility/debugger/reference/machine-info.md) structure that is filled in with a description of the machine.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)
- [MACHINE_INFO_FIELDS](../../../extensibility/debugger/reference/machine-info-fields.md)
- [MACHINE_INFO](../../../extensibility/debugger/reference/machine-info.md)
