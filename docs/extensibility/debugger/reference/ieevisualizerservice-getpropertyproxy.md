---
description: "This method returns a proxy for a property object."
title: IEEVisualizerService::GetPropertyProxy
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerService::GetPropertyProxy
helpviewer_keywords:
- IEEVisualizerService::GetPropertyProxy method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEEVisualizerService::GetPropertyProxy

This method returns a proxy for a property object.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPropertyProxy(
   uint                     dwID,
   out IPropertyProxyEESide proxy
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPropertyProxy(
   DWORD                  dwID,
   IPropertyProxyEESide** proxy
);
```
---

## Parameters
`dwID`\
[in] ID of property proxy to retrieve.

`proxy`\
[out] Desired proxy implemented in an [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md) interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
- [GetPropertyProxy](../../../extensibility/debugger/reference/ipropertyproxyprovider-getpropertyproxy.md) passes the request to this method as part of its support for type visualizers.

## See also
- [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md)
- [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)
- [GetPropertyProxy](../../../extensibility/debugger/reference/ipropertyproxyprovider-getpropertyproxy.md)
