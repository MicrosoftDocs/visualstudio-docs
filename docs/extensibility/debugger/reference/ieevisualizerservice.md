---
description: "This interface implements key methods that supply functionality to the IDebugProperty3 and IPropertyProxyEESide interfaces."
title: IEEVisualizerService
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerService
helpviewer_keywords:
- IEEVisualizerService interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEEVisualizerService

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 This interface implements key methods that supply functionality to the [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) and [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md) interfaces.

## Syntax

```
IEEVisualizerService : IUnknown
```

## Notes for Implementers
 Visual Studio implements this interface to allow an expression evaluator (EE) to support type visualizers.

## Notes for Callers
 The EE calls [CreateVisualizerService](../../../extensibility/debugger/reference/ieevisualizerserviceprovider-createvisualizerservice.md) to obtain this interface as part of its support for type visualizers.

## Methods in Vtable order

|Method|Description|
|------------|-----------------|
|[GetCustomViewerCount](../../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewercount.md)|Retrieves the number of custom viewers about which this service knows.|
|[GetCustomViewerList](../../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewerlist.md)|Retrieves the list of custom viewers.|
|[GetPropertyProxy](../../../extensibility/debugger/reference/ieevisualizerservice-getpropertyproxy.md)|Returns a proxy object for a property.|
|[GetValueDisplayStringCount](../../../extensibility/debugger/reference/ieevisualizerservice-getvaluedisplaystringcount.md)|Retrieves the number of value strings to display for the specified property or field.|

## Remarks
 The IDE uses the [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) interface to determine if there are any custom viewers or type visualizers for the property. By creating a visualizer service (with [CreateVisualizerService](../../../extensibility/debugger/reference/ieevisualizerserviceprovider-createvisualizerservice.md)), the EE can supply the functionality to the `IDebugProperty3` and [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md) (which supports viewing and changing a property's value) interfaces and thereby support type visualizers.

 If an EE has custom viewers that itself implements, the EE can append the `CLSID`s of those custom viewers to the end of the list returned by [GetCustomViewerList](../../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewerlist.md). This allows an EE to support both type visualizers and its own custom viewers. Just be sure that [GetCustomViewerCount](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewercount.md) reflects the addition of any custom viewers.

 See [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md) for a discussion of the difference between visualizers and viewers.

## Requirements
 Header: ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Expression Evaluation Interfaces](../../../extensibility/debugger/reference/expression-evaluation-interfaces.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)
- [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)
- [CreateVisualizerService](../../../extensibility/debugger/reference/ieevisualizerserviceprovider-createvisualizerservice.md)
- [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md)
