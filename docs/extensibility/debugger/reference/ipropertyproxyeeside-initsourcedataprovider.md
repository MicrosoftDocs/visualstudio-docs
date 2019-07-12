---
title: "IPropertyProxyEESide::InitSourceDataProvider | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IPropertyProxyEESide::InitSourceDataProvider"
helpviewer_keywords:
  - "IPropertyProxyEESide::InitSourceDataProvider"
ms.assetid: 5156f593-5052-4e3a-9d02-081916fb342d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IPropertyProxyEESide::InitSourceDataProvider
Initializes the source data for this object and returns an object containing the initial data.

## Syntax

```cpp
HRESULT InitSourceDataProvider(
   IEEDataStorage** dataOut
);
```

```csharp
int InitSourceDataProvider(
   out IEEDataStorage dataOut
);
```

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