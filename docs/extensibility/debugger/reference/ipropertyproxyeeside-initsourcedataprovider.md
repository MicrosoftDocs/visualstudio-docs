---
description: "Initializes the source data for this object and returns an object containing the initial data."
title: IPropertyProxyEESide::InitSourceDataProvider
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IPropertyProxyEESide::InitSourceDataProvider
helpviewer_keywords:
- IPropertyProxyEESide::InitSourceDataProvider
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IPropertyProxyEESide::InitSourceDataProvider

Initializes the source data for this object and returns an object containing the initial data.

## Syntax

### [C#](#tab/csharp)
```csharp
int InitSourceDataProvider(
   out IEEDataStorage dataOut
);
```
### [C++](#tab/cpp)
```cpp
HRESULT InitSourceDataProvider(
   IEEDataStorage** dataOut
);
```
---

## Parameters
`dataOut`\
[out] Returns an [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) object

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method does whatever is necessary to initialize an object so it can return an [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) interface on the object's data. This allows the object's data to be viewed and, if allowed, changed by a type visualizer.

## See also
- [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)
- [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)
