---
title: "IDebugCoreServer2::GetMachineInfo | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugCoreServer2::GetInfo"
helpviewer_keywords:
  - "IDebugCoreServer2::GetInfo"
ms.assetid: 8fa1a1d3-9fcb-4fb3-bf4e-e7172ac08d77
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugCoreServer2::GetMachineInfo
Retrieves a description of the machine the core server is running on.

## Syntax

```cpp
HRESULT GetMachineInfo( 
   MACHINE_INFO_FIELDS Fields,
   MACHINE_INFO*       pMachineInfo
);
```

```csharp
int GetMachineInfo( 
   enum_ MACHINE_INFO_FIELDS  Fields,
   MACHINE_INFO[]             pMachineInfo
);
```

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
