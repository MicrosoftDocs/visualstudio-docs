---
title: "IDebugCoreServer2::EnumPorts | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugCoreServer2::EnumPorts"
helpviewer_keywords:
  - "IDebugCoreServer2::EnumPorts"
ms.assetid: 3d98dfd0-614f-4d68-90c6-8a9b9cab66f1
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugCoreServer2::EnumPorts
Retrieves a list of all available ports.

## Syntax

```cpp
HRESULT EnumPorts( 
   IEnumDebugPorts2** ppEnum
);
```

```csharp
int EnumPorts( 
   out IEnumDebugPorts2 ppEnum
);
```

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md) object that contains a list of all ports from all port suppliers.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)
- [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md)