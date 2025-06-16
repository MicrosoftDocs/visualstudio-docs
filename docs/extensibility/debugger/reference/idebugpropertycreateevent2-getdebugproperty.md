---
description: "Gets the new property."
title: IDebugPropertyCreateEvent2::GetDebugProperty
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPropertyCreateEvent2::GetDebugProperty
helpviewer_keywords:
- IDebugPropertyCreateEvent2::GetDebugProperty
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPropertyCreateEvent2::GetDebugProperty

Gets the new property.

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
[out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the new property.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPropertyCreateEvent2](../../../extensibility/debugger/reference/idebugpropertycreateevent2.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
