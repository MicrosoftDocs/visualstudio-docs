---
title: "BP_CONDITION"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "BP_CONDITION"
helpviewer_keywords: 
  - "BP_CONDITION structure"
ms.assetid: 407f87a3-2878-429b-8c65-b68feb36622a
caps.latest.revision: 10
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
# BP_CONDITION
Describes the conditions under which a breakpoint fires.  
  
## Syntax  
  
```cpp#  
typedef struct _BP_CONDITION {   
   IDebugThread2* pThread;  
   BP_COND_STYLE  styleCondition;  
   BSTR           bstrContext;  
   BSTR           bstrCondition;  
   UINT           nRadix;  
} BP_CONDITION;  
```  
  
```c#  
public struct BP_CONDITION {   
   public IDebugThread2 pThread;  
   public uint          styleCondition;  
   public string        bstrContext;  
   public string        bstrCondition;  
   public uint          nRadix;  
};  
```  
  
## Members  
 `pThread`  
 The [IDebugThread2](../extensibility/idebugthread2.md) object that represents the active thread for the application that contains the breakpoint.  
  
 `styleCondition`  
 A value from the [BP_COND_STYLE](../extensibility/bp_cond_style.md) enumeration describing the style of this breakpoint condition.  
  
 `bstrContext`  
 The location of the breakpoint.  
  
 `bstrCondition`  
 The firing condition of the breakpoint.  
  
 `nRadix`  
 Radix to be used in evaluating any numerical information.  
  
## Remarks  
 This structure is a member of the [BP_REQUEST_INFO](../extensibility/bp_request_info.md) and [BP_REQUEST_INFO2](../extensibility/bp_request_info2.md) structures.  
  
 This structure is also passed as a parameter to the [SetCondition](../extensibility/idebugboundbreakpoint2--setcondition.md) and [SetCondition](../extensibility/idebugpendingbreakpoint2--setcondition.md) methods.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [BP_REQUEST_INFO](../extensibility/bp_request_info.md)   
 [BP_REQUEST_INFO2](../extensibility/bp_request_info2.md)   
 [SetCondition](../extensibility/idebugboundbreakpoint2--setcondition.md)   
 [SetCondition](../extensibility/idebugpendingbreakpoint2--setcondition.md)   
 [IDebugThread2](../extensibility/idebugthread2.md)   
 [BP_COND_STYLE](../extensibility/bp_cond_style.md)