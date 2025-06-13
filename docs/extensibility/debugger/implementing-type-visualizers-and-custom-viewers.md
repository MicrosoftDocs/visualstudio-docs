---
title: Implementing Type Visualizers and Custom Viewers
description: Learn about implementing type visualizers and custom viewers, which let a user view data in a way that is more meaningful than a dump of numbers.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], custom viewer
- debugging [Debugging SDK], type visualizer
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Implement type visualizers and custom viewers

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 Type visualizers and custom viewers let a user view data of a particular type in a way that is more meaningful than a simple hexadecimal dump of numbers. An expression evaluator (EE) can associate custom viewers with specific types of data or variables. These custom viewers are implemented by the EE. The EE can also support external type visualizers, which might come from another third-party vendor or even the end user.

## Discussion

### Type visualizers
 Visual Studio asks for a list of type visualizers and custom viewers for every object to be displayed in a watch window. An expression evaluator (EE) supplies such a list for every type for which it wants to support type visualizers and custom viewers. Calls to [GetCustomViewerCount](../../extensibility/debugger/reference/idebugproperty3-getcustomviewercount.md) and [GetCustomViewerList](../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md) start the whole process of accessing type visualizers and custom viewers (see [Visualizing and Viewing Data](../../extensibility/debugger/visualizing-and-viewing-data.md) for details on the calling sequence).

### Custom viewers
 Custom viewers are implemented in the EE for a specific data type and are represented by the [IDebugCustomViewer](../../extensibility/debugger/reference/idebugcustomviewer.md) interface. A custom viewer is not as flexible as a type visualizer, since it is available only when the EE that implements that particular custom viewer is executing. Implementing a custom viewer is simpler than implementing support for type visualizers. However, supporting type visualizers gives maximum flexibility to the end user for visualizing their data. The remainder of this discussion concerns only type visualizers.

## Interfaces
 The EE implements the following interfaces to support type visualizers, to be consumed by Visual Studio:

- [IEEVisualizerDataProvider](../../extensibility/debugger/reference/ieevisualizerdataprovider.md)

- [IPropertyProxyEESide](../../extensibility/debugger/reference/ipropertyproxyeeside.md)

- [IPropertyProxyProvider](../../extensibility/debugger/reference/ipropertyproxyprovider.md)

- [IEEDataStorage](../../extensibility/debugger/reference/ieedatastorage.md)

- [IDebugProperty3](../../extensibility/debugger/reference/idebugproperty3.md)

- [IDebugObject](../../extensibility/debugger/reference/idebugobject.md)

  The EE consumes the following interfaces to support type visualizers:

- [IEEVisualizerService](../../extensibility/debugger/reference/ieevisualizerservice.md)

- [IEEVisualizerServiceProvider](../../extensibility/debugger/reference/ieevisualizerserviceprovider.md)

- [IDebugBinder3](../../extensibility/debugger/reference/idebugbinder3.md)

## Related content
- [Writing a CLR expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
- [Visualizing and viewing data](../../extensibility/debugger/visualizing-and-viewing-data.md)
- [IDebugCustomViewer](../../extensibility/debugger/reference/idebugcustomviewer.md)
