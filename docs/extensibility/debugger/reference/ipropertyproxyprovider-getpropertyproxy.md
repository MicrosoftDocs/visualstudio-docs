---
description: "Retrieves the property proxy interface for the specified proxy ID."
title: IPropertyProxyProvider::GetPropertyProxy
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IPropertyProxyProvider::GetPropertyProxy
helpviewer_keywords:
- IPropertyProxyProvider::GetPropertyProxy
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IPropertyProxyProvider::GetPropertyProxy

Retrieves the property proxy interface for the specified proxy ID.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPropertyProxy(
   uint                     dwID,
   out IPropertyProxyEESide proxy
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPropertyProxy(
   DWORD                  dwID,
   IPropertyProxyEESide** proxy
);
```
---

## Parameters
`dwID`\
[in] ID of the desired property proxy.

`proxy`\
[out] Returns an [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md) object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 To support external type visualizers, this method typically forwards the call to the [GetPropertyProxy](../../../extensibility/debugger/reference/ieevisualizerservice-getpropertyproxy.md) method. See [Visualizing and Viewing Data](../../../extensibility/debugger/visualizing-and-viewing-data.md) for details on how the IEEVisualizerService is obtained.

## See also
- [IPropertyProxyProvider](../../../extensibility/debugger/reference/ipropertyproxyprovider.md)
- [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)
- [GetPropertyProxy](../../../extensibility/debugger/reference/ieevisualizerservice-getpropertyproxy.md)
- [Visualizing and Viewing Data](../../../extensibility/debugger/visualizing-and-viewing-data.md)
