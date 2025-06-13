---
description: "This method sets the debug engine's (DE) GUID`."
title: IDebugEngine3::SetEngineGuid
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine3::SetEngineGuid
helpviewer_keywords:
- IDebugEngine3::SetEngineGuid
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine3::SetEngineGuid

This method sets the debug engine's (DE) `GUID`.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetEngineGuid(
   ref Guid guidEngine
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetEngineGuid(
   GUID* guidEngine
);
```
---

## Parameters
`guidEngine`\
[in] `GUID` of the engine.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## See also
- [IDebugEngine3](../../../extensibility/debugger/reference/idebugengine3.md)
