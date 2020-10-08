---
title: "IDebugBreakpointUnboundEvent2::GetReason | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugBreakpointUnboundEvent2::GetReason"
helpviewer_keywords: 
  - "IDebugBreakpointUnboundEvent2::GetReason"
ms.assetid: 0f8a4fec-d3eb-417d-8516-4f7b51904033
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# IDebugBreakpointUnboundEvent2::GetReason
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the reason the breakpoint was unbound.  
  
## Syntax  
  
```cpp#  
HRESULT GetReason(   
   BP_UNBOUND_REASON* pdwUnboundReason  
);  
```  
  
```csharp  
int GetReason(   
   out enum_ BP_UNBOUND_REASON pdwUnboundReason  
);  
```  
  
#### Parameters  
 `pdwUnboundReason`  
 [out] Returns a value from the [BP_UNBOUND_REASON](../../../extensibility/debugger/reference/bp-unbound-reason.md) enumeration specifying the reason the breakpoint was unbound.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Reasons include a breakpoint being rebound to a different location after an edit-and-continue operation, or a determination that a breakpoint was bound in error.  
  
## Example  
 The following example shows how to implement this method for a **CBreakpointUnboundDebugEventBase** object that exposes the [IDebugBreakpointUnboundEvent2](../../../extensibility/debugger/reference/idebugbreakpointunboundevent2.md) interface.  
  
```cpp#  
STDMETHODIMP CBreakpointUnboundDebugEventBase::GetReason(  
    BP_UNBOUND_REASON* pdwUnboundReason)  
{  
    HRESULT hRes = E_FAIL;  
  
    if ( EVAL(pdwUnboundReason) )  
    {  
        *pdwUnboundReason = m_dwReason;  
  
        hRes = S_OK;  
    }  
    else  
        hRes = E_INVALIDARG;  
  
    return ( hRes );  
}  
```  
  
## See Also  
 [IDebugBreakpointUnboundEvent2](../../../extensibility/debugger/reference/idebugbreakpointunboundevent2.md)
