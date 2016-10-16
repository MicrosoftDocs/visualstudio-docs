---
title: "Expression Evaluation Interfaces"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "expression evaluation, interfaces"
ms.assetid: 2d259f60-2cd7-460e-b02d-24a8fb202850
caps.latest.revision: 13
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Expression Evaluation Interfaces
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 The following are the Expression Evaluation Interfaces for the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Debugging SDK.  
  
## Discussion  
 These interfaces are used to evaluate expressions in a call stack during break mode. They are implemented only for common language run-time expression evaluators (EE).  
  
 Each interface in the table shows the component that can implement it from the following list:  
  
-   Debug Engine (DE)  
  
-   Expression Evaluator (EE)  
  
-   Visual Studio (VS)  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugAlias](../extensibility/idebugalias.md)|EE|Represents a numeric alias for a variable.|  
|[IDebugAlias2](../extensibility/idebugalias2.md)|EE|Represents a numeric alias for a variable, and enables an expression evaluator (EE) to obtain the application domain for the alias.|  
|[IDebugArrayObject](../extensibility/idebugarrayobject.md)|EE|Represents an array object.|  
|[IDebugArrayObject2](../extensibility/idebugarrayobject2.md)|EE|Represents a managed array object, and allows an expression evaluator (EE) to determine the base index (lower bounds) for the array.|  
|[IDebugBinder](../extensibility/idebugbinder.md)|DE|Represents a binder that binds debug symbols to actual addresses in memory.|  
|[IDebugBinder3](../extensibility/idebugbinder3.md)|DE|Same as the [IDebugBinder](../extensibility/idebugbinder.md) interface but provides access to types, aliases, and custom visualizers.|  
|[IDebugExpressionEvaluator](../extensibility/idebugexpressionevaluator.md)|EE|Represents the expression evaluator.|  
|[IDebugExpressionEvaluator2](../extensibility/idebugexpressionevaluator2.md)|EE|Represents an enhanced version of an expression evaluator (EE).|  
|[IDebugExpressionEvaluator3](../extensibility/idebugexpressionevaluator3.md)|EE|Represents an expression evaluator (EE) with an enhanced parser tree.|  
|[IDebugFunctionObject](../extensibility/idebugfunctionobject.md)|EE|Represents a function.|  
|[IDebugFunctionObject2](../extensibility/idebugfunctionobject2.md)|EE|Represents a function and enhances the [IDebugFunctionObject](../extensibility/idebugfunctionobject.md) interface.|  
|[IDebugIDECallback](../extensibility/idebugidecallback.md)|DE|Enables an expression evaluator (EE) to display a message in the debugger's output window.|  
|[IDebugManagedObject](../extensibility/idebugmanagedobject.md)|EE|Represents a managed code object.|  
|[IDebugObject](../extensibility/idebugobject.md)|EE|Base interface that represents any symbol bound to a memory address.|  
|[IDebugObject2](../extensibility/idebugobject2.md)|EE|Same as the [IDebugObject](../extensibility/idebugobject.md) interface but provides access to additional information.|  
|[IDebugParsedExpression](../extensibility/idebugparsedexpression.md)|EE|Represents a parsed expression ready to be evaluated.|  
|[IDebugPointerObject](../extensibility/idebugpointerobject.md)|EE|Represents a pointer.|  
|[IDebugPointerObject3](../extensibility/idebugpointerobject3.md)|EE|Represents a pointer in a parse tree, and extends the **IDebugPointerObject** interface.|  
|[IEEVisualizerDataProvider](../extensibility/ieevisualizerdataprovider.md)|EE|Provides the ability to modify a type's value through a type visualizer.|  
|[IEEVisualizerService](../extensibility/ieevisualizerservice.md)|VS|Provides access to custom viewers and type visualizers.|  
|[IEEVisualizerServiceProvider](../extensibility/ieevisualizerserviceprovider.md)|VS|Provides the ability to create an [IEEVisualizerService](../extensibility/ieevisualizerservice.md) object.|  
|[IEnumDebugObjects](../extensibility/ienumdebugobjects.md)|EE|Represents a collection of [IDebugObject](../extensibility/idebugobject.md) objects.|  
  
## See Also  
 [API Reference](../extensibility/api-reference--visual-studio-debugging-.md)   
 [Writing a CLR Expression Evaluator](../extensibility/writing-a-common-language-runtime-expression-evaluator.md)   
 [Type Visualizer and Custom Viewer](../extensibility/type-visualizer-and-custom-viewer.md)