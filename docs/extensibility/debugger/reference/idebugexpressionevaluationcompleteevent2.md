---
title: "IDebugExpressionEvaluationCompleteEvent2 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugExpressionEvaluationCompleteEvent2"
helpviewer_keywords: 
  - "IDebugExpressionEvaluationCompleteEvent2"
ms.assetid: d538fc19-55bf-4231-9595-eb01e84fd1d8
caps.latest.revision: 11
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
# IDebugExpressionEvaluationCompleteEvent2
This interface is sent by the debug engine (DE) to the session debug manager (SDM) when asynchronous expression evaluation is complete.  
  
## Syntax  
  
```  
IDebugExpressionEvaluationCompleteEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report completion of an expression evaluation started by a call to [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md). The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report the completion of an expression evaluation. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugExpressionEvaluationCompleteEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetExpression](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2-getexpression.md)|Gets the original expression.|  
|[GetResult](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2-getresult.md)|Gets the result of expression evaluation.|  
  
## Remarks  
 The DE must send this event, whether the evaluation was successful or not.  
  
 If the evaluation was not successful, the `DEBUG_PROPINFO_VALUE` and `DEBUG_PROPINFO_ATTRIB` flags will not be set in the [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structure that is returned by [GetPropertyInfo](../../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) (the [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object is created by the DE and returned in the `IDebugExpressionEvaluationCompleteEvent2` event if the evaluation failed).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)   
 [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)   
 [EvaluateAsync](../../../extensibility/debugger/reference/idebugexpression2-evaluateasync.md)   
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)