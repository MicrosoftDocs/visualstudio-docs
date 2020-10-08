---
title: "PENDING_BP_STATE_INFO | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "PENDING_BP_STATE_INFO"
helpviewer_keywords: 
  - "PENDING_BP_STATE_INFO structure"
ms.assetid: 4d73ceff-43f9-4e95-8dba-88e1fab2def3
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# PENDING_BP_STATE_INFO
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Contains information about the state of a breakpoint that is ready to bind to a code location.  
  
## Syntax  
  
```cpp#  
typedef struct _tagPENDING_BP_STATE_INFO {   
   PENDING_BP_STATE       state;  
   PENDING_BP_STATE_FLAGS flags;  
} PENDING_BP_STATE_INFO;  
```  
  
```csharp  
public struct PENDING_BP_STATE_INFO {   
   public uint state;  
   public uint flags;  
};  
```  
  
## Members  
 state  
 A value from the [PENDING_BP_STATE](../../../extensibility/debugger/reference/pending-bp-state.md) enumeration that specifies the state of the pending breakpoint.  
  
 flags  
 A combination of flags from the [PENDING_BP_STATE_FLAGS](../../../extensibility/debugger/reference/pending-bp-state-flags.md) enumeration that specifies whether the breakpoint is virtualized.  
  
## Remarks  
 This structure is passed to the [GetState](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-getstate.md) method where it is filled in.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [GetState](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-getstate.md)   
 [PENDING_BP_STATE](../../../extensibility/debugger/reference/pending-bp-state.md)   
 [PENDING_BP_STATE_FLAGS](../../../extensibility/debugger/reference/pending-bp-state-flags.md)
