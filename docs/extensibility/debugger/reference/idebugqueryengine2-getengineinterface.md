---
description: "Gets a custom debug engine (DE) interface."
title: IDebugQueryEngine2::GetEngineInterface
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugQueryEngine2::GetEngineInterface
helpviewer_keywords:
- IDebugQueryEngine2::GetEngineInterface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugQueryEngine2::GetEngineInterface

Gets a custom debug engine (DE) interface.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetEngineInterface( 
   out object ppUnk
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetEngineInterface( 
   IUnknown** ppUnk
);
```
---

## Parameters
`ppUnk`\
[out] Returns an `IUnknown` object represents the debug engine (DE), and which can be queried for any other valid interface associated with a DE (for example [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md) or [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)).

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The resulting interface should be used with care because calling through interfaces retrieved from this method circumvents the session debug manager's processing and may result in the SDM getting into a bad state or generating errors while debugging.

## See also
- [IDebugQueryEngine2](../../../extensibility/debugger/reference/idebugqueryengine2.md)
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
- [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)
