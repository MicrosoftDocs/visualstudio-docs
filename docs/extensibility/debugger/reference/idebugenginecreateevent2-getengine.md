---
description: "Retrieves the object that represents the newly created debug engine (DE)."
title: IDebugEngineCreateEvent2::GetEngine | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngineCreateEvent2::GetEngine
helpviewer_keywords:
- IDebugEngineCreateEvent2::GetEngine
ms.assetid: 187d24ed-9f9a-4418-a0ef-b8a19f54652c
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugEngineCreateEvent2::GetEngine

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Retrieves the object that represents the newly created debug engine (DE).

## Syntax

### [C#](#tab/csharp)
```csharp
int GetEngine( 
   out IDebugEngine2 pEngine
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetEngine( 
   IDebugEngine2** pEngine
);
```
---

## Parameters
`pEngine`\
[out] Returns an [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md) object that represents the newly created DE.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugEngineCreateEvent2](../../../extensibility/debugger/reference/idebugenginecreateevent2.md)
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
