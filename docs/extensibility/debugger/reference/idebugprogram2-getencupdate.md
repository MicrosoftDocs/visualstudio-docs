---
description: "This method gets the Edit and Continue (ENC) update for this program."
title: IDebugProgram2::GetENCUpdate
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::GetENCUpdate
helpviewer_keywords:
- IDebugProgram2::GetENCUpdate
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::GetENCUpdate

This method gets the Edit and Continue (ENC) update for this program. A custom debug engine always returns `E_NOTIMPL`.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetENCUpdate(
   out object ppUpdate
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetENCUpdate( 
   IUnknown** ppUpdate
);
```
---

## Parameters
`ppUpdate`\
[out] Returns an internal interface that can be used to update this program.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

> [!NOTE]
> A custom debug engine should always return `E_NOTIMPL`.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
