---
title: Type Visualizer and Custom Viewer
description: Learn about type visualizer components and the custom viewers, which display data in a specific format, and the differences between them.
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
# Type visualizer and custom viewer

A type visualizer is a component that displays a piece of data in a specific format. The format is entirely up to who implements the visualizer, be it the end user or a third-party supplier of visualizers.

 A custom viewer is the part of a custom expression evaluator that displays a piece of data in a specific format. This format is entirely up to the implementer of the custom viewer, which means that the format is up to the implementer of the expression evaluator (EE).

## Support for type visualizers in an expression evaluator
 An EE supports type visualizers by supporting a set of interfaces accessible to visualizers: interfaces such as [IEEVisualizerService](../../extensibility/debugger/reference/ieevisualizerservice.md) and [IEEVisualizerDataProvider](../../extensibility/debugger/reference/ieevisualizerdataprovider.md). However, the EE is not responsible for implementing the type visualizer itself: the EE merely allows external visualizers access to its type information. Such visualizers might be shipped along with the EE and installed in the appropriate place in Visual Studio, supplied by another third-party vendor or even by the end user.

## Support for custom viewers in an expression evaluator
 An EE can also support custom viewers in which the EE itself supplies the code for viewing the data type. A custom viewer implements the [IDebugCustomViewer](../../extensibility/debugger/reference/idebugcustomviewer.md) interface, which handles all the duties of showing the data in whatever format is desired; the viewer has full control over the display and can even let the data be modified. Any custom viewers supplied by the EE come with the EE when the product is shipped.

## See also
- [Debugger components](../../extensibility/debugger/debugger-components.md)
- [Expression evaluator](../../extensibility/debugger/expression-evaluator.md)
- [Debug engine](../../extensibility/debugger/debug-engine.md)
- [IDebugCustomViewer](../../extensibility/debugger/reference/idebugcustomviewer.md)
- [IEEVisualizerService](../../extensibility/debugger/reference/ieevisualizerservice.md)
- [IEEVisualizerDataProvider](../../extensibility/debugger/reference/ieevisualizerdataprovider.md)
