---
title: "IDebugEngine3::SetEngineGuid | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugEngine3::SetEngineGuid"
helpviewer_keywords:
  - "IDebugEngine3::SetEngineGuid"
ms.assetid: 8bdfa05d-feb7-4d98-abac-77825a04c50f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugEngine3::SetEngineGuid
This method sets the debug engine's (DE) `GUID`.

## Syntax

```cpp
HRESULT SetEngineGuid(
   GUID* guidEngine
);
```

```csharp
int SetEngineGuid(
   ref Guid guidEngine
);
```

## Parameters
`guidEngine`\
[in] `GUID` of the engine.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## See also
- [IDebugEngine3](../../../extensibility/debugger/reference/idebugengine3.md)