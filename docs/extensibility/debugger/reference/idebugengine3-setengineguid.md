---
description: "This method sets the debug engine's (DE) GUID`."
title: IDebugEngine3::SetEngineGuid | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine3::SetEngineGuid
helpviewer_keywords:
- IDebugEngine3::SetEngineGuid
ms.assetid: 8bdfa05d-feb7-4d98-abac-77825a04c50f
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugEngine3::SetEngineGuid

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
