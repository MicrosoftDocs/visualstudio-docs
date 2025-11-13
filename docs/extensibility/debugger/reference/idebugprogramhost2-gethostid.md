---
description: "Gets the process identifier of the process hosting this program."
title: IDebugProgramHost2::GetHostId
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramHost2::GetHostId
helpviewer_keywords:
- IDebugProgramHost2::GetHostId
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramHost2::GetHostId

Gets the process identifier of the process hosting this program.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetHostId( 
   AD_PROCESS_ID[] pdwId
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetHostId( 
   AD_PROCESS_ID* pdwId
);
```
---

## Parameters
`pdwId`\
[in, out] An [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure that is filled in with the process identifier information.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramHost2](../../../extensibility/debugger/reference/idebugprogramhost2.md)
- [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md)
