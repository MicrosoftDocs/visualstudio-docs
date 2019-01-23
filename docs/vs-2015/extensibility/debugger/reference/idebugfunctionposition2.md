---
title: "IDebugFunctionPosition2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugFunctionPosition2"
helpviewer_keywords: 
  - "IDebugFunctionPosition2 interface"
ms.assetid: a835f65b-91b0-48ad-8485-04534c814b1b
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugFunctionPosition2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface represents an abstract position of a function in a source document.  
  
## Syntax  
  
```  
IDebugFunctionPosition2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent the position of a function within a source document.  
  
## Notes for Callers  
 This interface is supplied as part of a [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md) union (specifically, a [BP_LOCATION_CODE_FUNC_OFFSET](../../../extensibility/debugger/reference/bp-location-code-func-offset.md) structure) that is in turn part of the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) structure, used in creating a pending breakpoint.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugFunctionPosition2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetFunctionName](../../../extensibility/debugger/reference/idebugfunctionposition2-getfunctionname.md)|Gets the name of the function that this position is relative to.|  
|[GetOffset](../../../extensibility/debugger/reference/idebugfunctionposition2-getoffset.md)|Gets the offset from the beginning of the function.|  
  
## Remarks  
 The position represented by this interface is text-based, specifically, a [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [BP_LOCATION_CODE_FUNC_OFFSET](../../../extensibility/debugger/reference/bp-location-code-func-offset.md)   
 [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md)   
 [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)
