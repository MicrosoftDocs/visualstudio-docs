---
title: "IDebugBoundBreakpoint2::GetPendingBreakpoint | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugBoundBreakpoint2::GetPendingBreakpoint"
helpviewer_keywords: 
  - "IDebugBoundBreakpoint2::GetPendingBreakpoint method"
  - "GetPendingBreakpoint method"
ms.assetid: 22f94f81-f8d9-46de-96e9-fae6f3c24903
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugBoundBreakpoint2::GetPendingBreakpoint
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the pending breakpoint from which the specified bound breakpoint was created.  
  
## Syntax  
  
```cpp#  
HRESULT GetPendingBreakpoint(   
   IDebugPendingBreakpoint2** ppPendingBreakpoint  
);  
```  
  
```csharp  
int GetPendingBreakpoint(   
   out IDebugPendingBreakpoint2 ppPendingBreakpoint  
);  
```  
  
#### Parameters  
 `ppPendingBreakpoint`  
 [out] Returns the [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md) object that represents the pending breakpoint that was used to create this bound breakpoint.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A pending breakpoint can be thought of as a collection of all the necessary information needed to bind a breakpoint to code that can be applied to one or many programs.  
  
## Example  
 The following example shows how to implement this method for a simple `CBoundBreakpoint` object that exposes the [IDebugBoundBreakpoint2](../../../extensibility/debugger/reference/idebugboundbreakpoint2.md) interface.  
  
```  
HRESULT CBoundBreakpoint::GetPendingBreakpoint(  
    IDebugPendingBreakpoint2** ppPendingBreakpoint)  
{    
   HRESULT hr;    
  
   // Check for valid IDebugPendingBreakpoint2 interface pointer.    
   if (ppPendingBreakpoint)    
   {    
      // Be sure that the bound breakpoint has not been deleted. If  
      // deleted, then return hr = E_BP_DELETED.    
      if (m_state != BPS_DELETED)    
      {    
         // Query for the IDebugPendingBreakpoint2 interface.    
         hr = m_pPendingBP->QueryInterface(IID_IDebugPendingBreakpoint2,  
                                           (void**)ppPendingBreakpoint);    
      }    
      else    
      {    
         hr = E_BP_DELETED;    
      }    
   }    
   else    
   {    
      hr = E_INVALIDARG;    
   }    
  
   return hr;    
}    
```  
  
## See Also  
 [IDebugBoundBreakpoint2](../../../extensibility/debugger/reference/idebugboundbreakpoint2.md)   
 [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)
