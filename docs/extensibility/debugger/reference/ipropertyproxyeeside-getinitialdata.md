---
description: "Returns the initial data for this object."
title: IPropertyProxyEESide::GetInitialData
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IPropertyProxyEESide::GetInitialData
helpviewer_keywords:
- IPropertyProxyEESide::GetInitialData
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IPropertyProxyEESide::GetInitialData

Returns the initial data for this object.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetInitialData(
   out IEEDataStorage dataOut
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetInitialData(
   IEEDataStorage** dataOut
);
```
---

## Parameters
`dataOut`\
[out] Returns an [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) object containing the initial data of this object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)
- [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)
