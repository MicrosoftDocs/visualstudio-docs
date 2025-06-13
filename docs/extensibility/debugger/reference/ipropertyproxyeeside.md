---
description: "This interface provides methods to view data on the associated object."
title: IPropertyProxyEESide
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IPropertyProxyEESide
helpviewer_keywords:
- IPropertyProxyEESide interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IPropertyProxyEESide

This interface provides methods to view data on the associated object. This interface is part of the support for type visualizers.

## Syntax

```
IPropertyProxyEESide : IUnknown
```

## Notes for Implementers
 An expression evaluator implements this interface to support type visualizers.

## Notes for Callers
 Call [GetPropertyProxy](../../../extensibility/debugger/reference/ipropertyproxyprovider-getpropertyproxy.md) to obtain this interface. Call [QueryInterface](/cpp/atl/queryinterface) on an [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) interface to obtain the [IPropertyProxyProvider](../../../extensibility/debugger/reference/ipropertyproxyprovider.md) interface.

## Methods in Vtable order
 The following methods are implemented by this interface:

|Method|Description|
|------------|-----------------|
|[InitSourceDataProvider](../../../extensibility/debugger/reference/ipropertyproxyeeside-initsourcedataprovider.md)|Initializes a data source provider so that the object's data can be accessed.|
|[GetManagedViewerCreationData](../../../extensibility/debugger/reference/ipropertyproxyeeside-getmanagedviewercreationdata.md)|Retrieves information about the object's assembly.|
|[GetInitialData](../../../extensibility/debugger/reference/ipropertyproxyeeside-getinitialdata.md)|Gets the initial data for the object.|
|[CreateReplacementObject](../../../extensibility/debugger/reference/ipropertyproxyeeside-createreplacementobject.md)|Creates a copy of an existing data storage.|
|[InPlaceUpdateObject](../../../extensibility/debugger/reference/ipropertyproxyeeside-inplaceupdateobject.md)|Creates a reference to an existing data storage.|
|[ResolveAssemblyRef](../../../extensibility/debugger/reference/ipropertyproxyeeside-resolveassemblyref.md)|Retrieves information about a specific assembly in context of the assembly containing this object.|

## Remarks
 A type visualizer uses this interface to access the values associated with the object that this interface is part of. The data is accessed through the [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) interface, which provides a read-only view of the data.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md)
- [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
