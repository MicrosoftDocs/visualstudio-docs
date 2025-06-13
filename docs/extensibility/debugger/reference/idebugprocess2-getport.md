---
description: "Gets the port that the process is running on."
title: IDebugProcess2::GetPort
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2::GetPort
helpviewer_keywords:
- IDebugProcess2::GetPort
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess2::GetPort

Gets the port that the process is running on.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPort( 
   out IDebugPort2 ppPort
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPort( 
   IDebugPort2** ppPort
);
```
---

## Parameters
`ppPort`\
[out] Returns an [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) object that represents the port on which the process was launched.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
