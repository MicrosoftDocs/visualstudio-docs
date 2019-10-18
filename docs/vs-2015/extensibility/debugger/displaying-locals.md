---
title: "Displaying Locals | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluation, displaying locals"
ms.assetid: 62264cec-845b-4233-aed7-0b038fa79250
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# Displaying Locals
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Execution always takes place within the context of a method, also known as the containing method or current method. When execution pauses, Visual Studio calls the debug engine (DE) to get a list of local variables and arguments, collectively called the locals of the method. Visual Studio displays these locals and their values in the **Locals** window.  
  
 To display locals, the DE calls the [GetMethodProperty](../../extensibility/debugger/reference/idebugexpressionevaluator-getmethodproperty.md) method belonging to the EE and gives it an evaluation context, that is, a symbol provider (SP), the current execution address, and a binder object. For more information, see [Evaluation Context](../../extensibility/debugger/evaluation-context.md). If the call succeeds, the `IDebugExpressionEvaluator::GetMethodProperty` method returns an [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) object, which represents the method that contains the current execution address.  
  
 The DE calls [EnumChildren](../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) to get an [IEnumDebugPropertyInfo2](../../extensibility/debugger/reference/ienumdebugpropertyinfo2.md) object, which is filtered to return only locals and enumerated to produce a list of [DEBUG_PROPERTY_INFO](../../extensibility/debugger/reference/debug-property-info.md) structures. Each structure contains the name, type, and value of a local. The type and value are stored as formatted strings, suitable for display. The name, type, and value are typically displayed together in one line of the **Locals** window.  
  
> [!NOTE]
> The **QuickWatch** and **Watch** windows also display variables with the same format of name, value, and type. However, those values are obtained by calling [GetPropertyInfo](../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) instead of `IDebugProperty2::EnumChildren`.  
  
## In This Section  
 [Sample Implementation of Locals](../../extensibility/debugger/sample-implementation-of-locals.md)  
 Uses examples to step through the process of implementing locals.  
  
## Related Sections  
 [Evaluation Context](../../extensibility/debugger/evaluation-context.md)  
 Explains that when the debug engine (DE) calls the expression evaluator (EE), it passes three arguments.  
  
## See also  
 [Writing a CLR Expression Evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
