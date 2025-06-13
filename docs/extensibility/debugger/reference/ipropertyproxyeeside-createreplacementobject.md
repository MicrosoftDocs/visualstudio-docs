---
description: "Creates a copy of a data object specific to the expression evaluator (EE)."
title: IPropertyProxyEESide::CreateReplacementObject
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IPropertyProxyEESide::CreateReplacementObject
helpviewer_keywords:
- IPropertyProxyEESide::CreateReplacementObject
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IPropertyProxyEESide::CreateReplacementObject

Creates a copy of a data object specific to the expression evaluator (EE).

## Syntax

### [C#](#tab/csharp)
```csharp
int CreateReplacementObject(
   IEEDataStorage     dataIn,
   out IEEDataStorage dataOut
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CreateReplacementObject(
   IEEDataStorage*  dataIn,
   IEEDataStorage** dataOut
);
```
---

## Parameters
`dataIn`\
[in] An [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) object holding the data to be copied.

`dataOut`\
[out] Returns a new `IEEDataStorage` object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is given an [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) object representing an array of bytes. This incoming data object is typically not implemented by the EE. However, the object returned by this method is always implemented by the EE, which lets the EE implement the `IEEDataStorage` interface on whatever class is desired.

 Note that the data supplied by the incoming `IEEDataStorage` object must be the same data in the outgoing `IEEDataStorage` object.

## See also
- [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)
- [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)
