---
title: "IDebugCoreServer3::DisableAutoAttach | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugCoreServer3::DisableAutoAttach"
helpviewer_keywords:
  - "IDebugCoreServer3::DisableAutoAttach"
ms.assetid: 9d860a20-c154-4df4-ba15-636e0fcd42bf
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugCoreServer3::DisableAutoAttach
Disables automatic attaching for all debug engines associated with this server.

## Syntax

```cpp
HRESULT DisableAutoAttach(
   void
);
```

```csharp
int DisableAutoAttach();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## See Also
- [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)