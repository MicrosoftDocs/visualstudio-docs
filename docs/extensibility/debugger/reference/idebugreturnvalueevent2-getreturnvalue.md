---
description: "Gets the value returned on stepping out of or over a function."
title: IDebugReturnValueEvent2::GetReturnValue
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReturnValueEvent2::GetReturnValue
helpviewer_keywords:
- IDebugReturnValueEvent2::GetReturnValue
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugReturnValueEvent2::GetReturnValue

Gets the value returned on stepping out of or over a function.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetReturnValue ( 
   out IDebugProperty2 ppReturnValue
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetReturnValue ( 
   IDebugProperty2** ppReturnValue
);
```
---

## Parameters
`ppReturnValue`\
[out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the value to be retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugReturnValueEvent2](../../../extensibility/debugger/reference/idebugreturnvalueevent2.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
