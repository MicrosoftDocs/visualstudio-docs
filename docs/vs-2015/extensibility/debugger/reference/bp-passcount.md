---
title: "BP_PASSCOUNT | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "BP_PASSCOUNT"
helpviewer_keywords: 
  - "BP_PASSCOUNT structure"
ms.assetid: 791ac175-b897-4c70-873e-240da7e0ac89
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# BP_PASSCOUNT
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Describes the count and conditions upon which a conditional breakpoint is fired.  
  
## Syntax  
  
```cpp#  
typedef struct _BP_PASSCOUNT {   
   DWORD              dwPassCount;  
   BP_PASSCOUNT_STYLE stylePassCount;  
} BP_PASSCOUNT;  
```  
  
```csharp  
public struct BP_PASSCOUNT {   
   public uint dwPassCount;  
   public uint stylePassCount;  
};  
```  
  
## Members  
 `dwPassCount`  
 The number of times to pass over the breakpoint before firing it.  
  
 `stylePassCount`  
 A value from the [BP_PASSCOUNT_STYLE](../../../extensibility/debugger/reference/bp-passcount-style.md) enumeration that specifies the style of the breakpoint pass count.  
  
## Remarks  
 This structure is a member of the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) structure.  
  
 This structure is also passed as a parameter to the[SetPassCount](../../../extensibility/debugger/reference/idebugboundbreakpoint2-setpasscount.md) and[SetPassCount](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-setpasscount.md) methods.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md)   
 [SetPassCount](../../../extensibility/debugger/reference/idebugboundbreakpoint2-setpasscount.md)   
 [SetPassCount](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-setpasscount.md)   
 [BP_PASSCOUNT_STYLE](../../../extensibility/debugger/reference/bp-passcount-style.md)
