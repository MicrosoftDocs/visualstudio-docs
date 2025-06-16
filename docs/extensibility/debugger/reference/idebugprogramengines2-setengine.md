---
description: "Tells the program or program node which debug engine (DE) to use to debug this program."
title: IDebugProgramEngines2::SetEngine
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramEngines2::SetEngine
helpviewer_keywords:
- IDebugProgramEngines2::SetEngine
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramEngines2::SetEngine

Tells the program or program node which debug engine (DE) to use to debug this program.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetEngine( 
   ref Guid guidEngine
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetEngine( 
   REFGUID guidEngine
);
```
---

## Parameters
`guidEngine`\
[in] The GUID of the DE.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramEngines2](../../../extensibility/debugger/reference/idebugprogramengines2.md)
