---
description: "Gets the property to be destroyed."
title: IDebugPropertyDestroyEvent2::GetDebugProperty
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPropertyDestroyEvent2::GetDebugProperty
helpviewer_keywords:
- IDebugPropertyDestroyEvent2::GetDebugProperty
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPropertyDestroyEvent2::GetDebugProperty

Gets the property to be destroyed.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetDebugProperty ( 
   out IDebugProperty2 ppProperty
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDebugProperty ( 
   IDebugProperty2** ppProperty
);
```
---

## Parameters
`ppProperty`\
[out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the property to be destroyed.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPropertyDestroyEvent2](../../../extensibility/debugger/reference/idebugpropertydestroyevent2.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
