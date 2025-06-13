---
description: "This interface provides the ability to change an object's value through a type visualizer."
title: IEEVisualizerDataProvider
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerDataProvider
helpviewer_keywords:
- IEEVisualizerDataProvider interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEEVisualizerDataProvider

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 This interface provides the ability to change an object's value through a type visualizer.

## Syntax

```
IEEVisualizerDataProvider : IUnknown
```

## Notes for Implementers
 The expression evaluator implements this interface to support modifying data on a property object through a type visualizer.

## Notes for Callers
 This interface is used in creating the [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md) object through a call to [CreateVisualizerService](../../../extensibility/debugger/reference/ieevisualizerserviceprovider-createvisualizerservice.md). See [Visualizing and Viewing Data](../../../extensibility/debugger/visualizing-and-viewing-data.md) for more details.

## Methods in Vtable order

|Method|Description|
|------------|-----------------|
|[CanSetObjectForVisualizer](../../../extensibility/debugger/reference/ieevisualizerdataprovider-cansetobjectforvisualizer.md)|Determines if it is possible to update the object (and subsequently, its value) that this visualizer is representing.|
|[GetNewObjectForVisualizer](../../../extensibility/debugger/reference/ieevisualizerdataprovider-getnewobjectforvisualizer.md)|Forces a re-evaluation of the object for this visualizer.|
|[GetObjectForVisualizer](../../../extensibility/debugger/reference/ieevisualizerdataprovider-getobjectforvisualizer.md)|Gets an existing object for this visualizer (no evaluation is done).|
|[SetObjectForVisualizer](../../../extensibility/debugger/reference/ieevisualizerdataprovider-setobjectforvisualizer.md)|Updates the object for this visualizer, thereby changing the value the visualizer presents.|

## Remarks
 The visualizer service (as represented by the [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md) interface and returned by [CreateVisualizerService](../../../extensibility/debugger/reference/ieevisualizerserviceprovider-createvisualizerservice.md)) keeps a reference to the object implementing the `IEEVisualizerDataProvider` interface. As a result, the `IEEVisualizerDataProvider` interface should not be implemented on the same object that implements the [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) if that object maintains a reference to the `IEEVisualizerService` object: a circular reference results and a deadlock occurs when the objects are destroyed. The recommended approach is to implement `IEEVisualizerDataProvider` on a separate object to which the `IDebugProperty2` object delegates without calling `IUnknown::AddRef` on it.

## Requirements
 Header: ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Expression Evaluation Interfaces](../../../extensibility/debugger/reference/expression-evaluation-interfaces.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md)
- [IEEVisualizerServiceProvider](../../../extensibility/debugger/reference/ieevisualizerserviceprovider.md)
- [Visualizing and Viewing Data](../../../extensibility/debugger/visualizing-and-viewing-data.md)
