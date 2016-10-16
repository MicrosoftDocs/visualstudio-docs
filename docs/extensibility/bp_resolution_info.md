---
title: "BP_RESOLUTION_INFO"
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
  - "BP_RESOLUTION_INFO"
helpviewer_keywords: 
  - "BP_RESOLUTION_INFO structure"
ms.assetid: ba0c162a-61e8-4a0b-811f-4c1d8a5d82f0
caps.latest.revision: 9
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
# BP_RESOLUTION_INFO
Describes the bound breakpoint information for either a code breakpoint or a data breakpoint.  
  
## Syntax  
  
```cpp#  
typedef struct _BP_RESOLUTION_INFO {   
   BPRESI_FIELDS          dwFields;  
   BP_RESOLUTION_LOCATION bpResLocation;  
   IDebugProgram2*        pProgram;  
   IDebugThread2*         pThread;  
} BP_RESOLUTION_INFO;  
```  
  
```c#  
public struct BP_RESOLUTION_INFO {   
   public uint                   dwFields;  
   public BP_RESOLUTION_LOCATION bpResLocation;  
   public IDebugProgram2         pProgram;  
   public IDebugThread2          pThread;  
};  
```  
  
## Members  
 `dwFields`  
 A collection of flags from the [BPRESI_FIELDS](../extensibility/bpresi_fields.md) enumerations that specifies which fields are filled out.  
  
 `bpResLocation`  
 The [BP_RESOLUTION_LOCATION](../extensibility/bp_resolution_location.md) structure that specifies the location of the breakpoint in code or data.  
  
 `pProgram`  
 The [IDebugProgram2](../extensibility/idebugprogram2.md) object that represents the application in which the breakpoint error occurred.  
  
 `pThread`  
 The [IDebugThread2](../extensibility/idebugthread2.md) object that represents the thread in which the application that contains the breakpoint error is running.  
  
## Remarks  
 This structure is returned by [GetResolutionInfo](../extensibility/idebugbreakpointresolution2--getresolutioninfo.md).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [GetResolutionInfo](../extensibility/idebugbreakpointresolution2--getresolutioninfo.md)   
 [BPRESI_FIELDS](../extensibility/bpresi_fields.md)   
 [BP_RESOLUTION_LOCATION](../extensibility/bp_resolution_location.md)   
 [IDebugProgram2](../extensibility/idebugprogram2.md)   
 [IDebugThread2](../extensibility/idebugthread2.md)