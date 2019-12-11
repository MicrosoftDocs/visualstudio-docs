---
title: "BP_STATE | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "BP_STATE"
helpviewer_keywords: 
  - "BP_STATE enumeration"
ms.assetid: 08aa6a3f-3e5f-4c83-8eca-7b7b5f8e208d
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# BP_STATE
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Specifies the existence of a bound breakpoint and also specifies if it is enabled.  
  
## Syntax  
  
```cpp#  
enum enum_BP_STATE {   
   BPS_NONE     = 0x0000,  
   BPS_DELETED  = 0x0001,  
   BPS_DISABLED = 0x0002,  
   BPS_ENABLED  = 0x0003  
};  
typedef DWORD BP_STATE;  
```  
  
```csharp  
public enum enum_BP_STATE {   
   BPS_NONE     = 0x0000,  
   BPS_DELETED  = 0x0001,  
   BPS_DISABLED = 0x0002,  
   BPS_ENABLED  = 0x0003  
};  
```  
  
## Members  
 BPS_NONE  
 Specifies that no breakpoint exists.  
  
 BPS_DELETED  
 Specifies that the breakpoint has been deleted.  
  
 BPS_DISABLED  
 Specifies that the breakpoint is disabled.  
  
 BPS_ENABLED  
 Specifies that the breakpoint is enabled.  
  
## Remarks  
 Returned from the [GetState](../../../extensibility/debugger/reference/idebugboundbreakpoint2-getstate.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [GetState](../../../extensibility/debugger/reference/idebugboundbreakpoint2-getstate.md)
