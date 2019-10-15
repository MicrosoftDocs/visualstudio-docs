---
title: "IEEVisualizerService::GetPropertyProxy | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEEVisualizerService::GetPropertyProxy"
helpviewer_keywords:
  - "IEEVisualizerService::GetPropertyProxy method"
ms.assetid: 748750f4-76e7-4580-9da2-afba07681b37
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEEVisualizerService::GetPropertyProxy
This method returns a proxy for a property object.

## Syntax

```cpp
HRESULT GetPropertyProxy(
   DWORD                  dwID,
   IPropertyProxyEESide** proxy
);
```

```csharp
int GetPropertyProxy(
   uint                     dwID,
   out IPropertyProxyEESide proxy
);
```

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