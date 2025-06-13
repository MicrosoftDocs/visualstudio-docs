---
description: "Specifies how the debug engine (DE) should handle a given exception."
title: IDebugEngine2::SetException
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2::SetException
helpviewer_keywords:
- IDebugEngine2::SetException
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine2::SetException

Specifies how the debug engine (DE) should handle a given exception.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetException( 
   EXCEPTION_INFO[] pException
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetException( 
   EXCEPTION_INFO* pException
);
```
---

## Parameters
`pException`\
[in] An [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md) structure that describes the exception and how to debug it.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A DE could be instructed to stop the program generating an exception at first chance, second chance, or not at all.

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
- [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md)
