---
description: "Retrieves information about the viewer for this property type in order to instantiate that viewer."
title: IPropertyProxyEESide::GetManagedViewerCreationData
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IPropertyProxyEESide::GetManagedViewerCreationData
helpviewer_keywords:
- IPropertyProxyEESide::GetManagedViewerCreationData
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IPropertyProxyEESide::GetManagedViewerCreationData

Retrieves information about the viewer for this property type in order to instantiate that viewer.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetManagedViewerCreationData(
   out string                     assemName,
   out IEEDataStorage             assemBytes,
   out IEEDataStorage             assemPdb,
   out string                     className,
   out enum_ASSEMBLYLOCRESOLUTION alr,
   out int                        replacementOk
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetManagedViewerCreationData(
   BSTR*                  assemName,
   IEEDataStorage**       assemBytes,
   IEEDataStorage**       assemPdb,
   BSTR*                  className,
   ASSEMBLYLOCRESOLUTION* alr,
   BOOL*                  replacementOk
);
```
---

## Parameters
`assemName`\
[out] Returns the name of the assembly holding this object.

`assemBytes`\
[out] Returns an [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) object containing the assembly bytes of this object (this is a null value if no bytes are available).

`assemPdb`\
[out] Returns an `IEEDataStorage` object containing the symbol store information for this object (this is a null value if no symbol store is available).

`className`\
[out] Returns the class name containing this object.

`alr`\
[out] Returns a value from the [ASSEMBLYLOCRESOLUTION](../../../extensibility/debugger/reference/assemblylocresolution.md) enumeration indicating the location of the assembly.

`replacementOk`\
[out] Returns nonzero (`TRUE`) if this object's value can be changed; zero (`FALSE`) if the object is read-only.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is used by type visualizers to instantiate a managed viewer.

## See also
- [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)
- [ASSEMBLYLOCRESOLUTION](../../../extensibility/debugger/reference/assemblylocresolution.md)
- [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)
