---
title: "BP_FLAGS | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "BP_FLAGS"
helpviewer_keywords: 
  - "BP_FLAGS enumeration"
ms.assetid: c45dfc74-5e7f-4f1e-a147-ab2a55dccbd0
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# BP_FLAGS
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Provides optional flags that may be used to specify additional information when setting a breakpoint.  
  
## Syntax  
  
```cpp#  
enum enum_BP_FLAGS {   
   BP_FLAG_NONE            = 0x0000,  
   BP_FLAG_MAP_DOCPOSITION = 0x0001,  
   BP_FLAG_DONT_STOP       = 0x0002  
};  
typedef DWORD BP_FLAGS;  
```  
  
```csharp  
public enum enum_BP_FLAGS {   
   BP_FLAG_NONE            = 0x0000,  
   BP_FLAG_MAP_DOCPOSITION = 0x0001,  
   BP_FLAG_DONT_STOP       = 0x0002  
};  
```  
  
## Members  
 BP_FLAG_NONE  
 Specifies no breakpoint flag.  
  
 BP_FLAG_MAP_DOCPOSITION  
 Specifies that the debug engine (DE) should map the breakpoint using the document position. This is applicable only to breakpoints set in script-oriented source files such as Active Server Pages (ASP).  
  
 BP_FLAG_DONT_STOP  
 Specifies that the breakpoint should be processed by the debug engine, but that the debug engine ultimately should not stop there (that is, an [IDebugBreakpointEvent2](../../../extensibility/debugger/reference/idebugbreakpointevent2.md) event object should not be sent). This flag is designed to be used primarily with tracepoints.  
  
## Remarks  
 Used for the `dwFlags` member of the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) and [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md) structures.  
  
 These values may be combined with a bitwise `OR`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md)   
 [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md)   
 [IDebugBreakpointEvent2](../../../extensibility/debugger/reference/idebugbreakpointevent2.md)
