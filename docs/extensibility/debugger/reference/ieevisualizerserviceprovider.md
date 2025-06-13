---
description: "This interface gives access to a method that can create a visualizer service, which is used to handle type visualizer tasks for the IDE."
title: IEEVisualizerServiceProvider
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEEVisualizerServiceProvider
helpviewer_keywords:
- IEEVisualizerServiceProvider interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEEVisualizerServiceProvider

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 This interface gives access to a method that can create a visualizer service, which is used to handle type visualizer tasks for the IDE.

## Syntax

```
IEEVisualizerServiceProvider : IUnknown
```

## Notes for Implementers
 Visual Studio implements this interface to create a visualizer service object, which in turn is used to supply class IDs (`CLSID`s) of type visualizers to the Visual Studio IDE.

## Notes for Callers
 The expression evaluator (EE) calls [GetEEService](../../../extensibility/debugger/reference/idebugbinder3-geteeservice.md) to obtain this interface.

## Methods in Vtable order

|Method|Description|
|------------|-----------------|
|[CreateVisualizerService](../../../extensibility/debugger/reference/ieevisualizerserviceprovider-createvisualizerservice.md)|Creates the visualizer service|

## Remarks
 The `IEEVisualizerServiceProvider` interface is obtained during the implementation of [EvaluateSync](../../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md). The visualizer service that this interface creates is used to supply functionality to an [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) interface, which the EE is responsible for implementing. The EE is also responsible for implementing an [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md) interface that allows type visualizers to view and modify a property's value.

 See [Visualizing and Viewing Data](../../../extensibility/debugger/visualizing-and-viewing-data.md) for details on how these interfaces interact.

## Requirements
 Header: ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Expression Evaluation Interfaces](../../../extensibility/debugger/reference/expression-evaluation-interfaces.md)
- [EvaluateSync](../../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md)
- [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md)
- [GetEEService](../../../extensibility/debugger/reference/idebugbinder3-geteeservice.md)
- [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)
- [Visualizing and Viewing Data](../../../extensibility/debugger/visualizing-and-viewing-data.md)
