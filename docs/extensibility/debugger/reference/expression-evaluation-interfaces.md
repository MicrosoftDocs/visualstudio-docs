---
description: "The following are the Expression Evaluation Interfaces for the Visual Studio Debugging SDK."
title: Expression Evaluation Interfaces
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- expression evaluation, interfaces
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Expression Evaluation Interfaces

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 The following are the Expression Evaluation Interfaces for the Visual Studio Debugging SDK.

## Discussion
 These interfaces are used to evaluate expressions in a call stack during break mode. They are implemented only for common language run-time expression evaluators (EE).

 Each interface in the table shows the component that can implement it from the following list:

- Debug Engine (DE)

- Expression Evaluator (EE)

- Visual Studio (VS)

|Interface|Implemented by|Description|
|---------------|--------------------|-----------------|
|[IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)|EE|Represents a numeric alias for a variable.|
|[IDebugAlias2](../../../extensibility/debugger/reference/idebugalias2.md)|EE|Represents a numeric alias for a variable, and enables an expression evaluator (EE) to obtain the application domain for the alias.|
|[IDebugArrayObject](../../../extensibility/debugger/reference/idebugarrayobject.md)|EE|Represents an array object.|
|[IDebugArrayObject2](../../../extensibility/debugger/reference/idebugarrayobject2.md)|EE|Represents a managed array object, and allows an expression evaluator (EE) to determine the base index (lower bounds) for the array.|
|[IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)|DE|Represents a binder that binds debug symbols to actual addresses in memory.|
|[IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)|DE|Same as the [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md) interface but provides access to types, aliases, and custom visualizers.|
|[IDebugExpressionEvaluator](../../../extensibility/debugger/reference/idebugexpressionevaluator.md)|EE|Represents the expression evaluator.|
|[IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md)|EE|Represents an enhanced version of an expression evaluator (EE).|
|[IDebugExpressionEvaluator3](../../../extensibility/debugger/reference/idebugexpressionevaluator3.md)|EE|Represents an expression evaluator (EE) with an enhanced parser tree.|
|[IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md)|EE|Represents a function.|
|[IDebugFunctionObject2](../../../extensibility/debugger/reference/idebugfunctionobject2.md)|EE|Represents a function and enhances the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) interface.|
|[IDebugIDECallback](../../../extensibility/debugger/reference/idebugidecallback.md)|DE|Enables an expression evaluator (EE) to display a message in the debugger's output window.|
|[IDebugManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject.md)|EE|Represents a managed code object.|
|[IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)|EE|Base interface that represents any symbol bound to a memory address.|
|[IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)|EE|Same as the [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) interface but provides access to additional information.|
|[IDebugParsedExpression](../../../extensibility/debugger/reference/idebugparsedexpression.md)|EE|Represents a parsed expression ready to be evaluated.|
|[IDebugPointerObject](../../../extensibility/debugger/reference/idebugpointerobject.md)|EE|Represents a pointer.|
|[IDebugPointerObject3](../../../extensibility/debugger/reference/idebugpointerobject3.md)|EE|Represents a pointer in a parse tree, and extends the **IDebugPointerObject** interface.|
|[IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md)|EE|Provides the ability to modify a type's value through a type visualizer.|
|[IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md)|VS|Provides access to custom viewers and type visualizers.|
|[IEEVisualizerServiceProvider](../../../extensibility/debugger/reference/ieevisualizerserviceprovider.md)|VS|Provides the ability to create an [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md) object.|
|[IEnumDebugObjects](../../../extensibility/debugger/reference/ienumdebugobjects.md)|EE|Represents a collection of [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) objects.|

## See also
- [API Reference](../../../extensibility/debugger/reference/api-reference-visual-studio-debugging.md)
- [Writing a CLR Expression Evaluator](../../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
- [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md)
