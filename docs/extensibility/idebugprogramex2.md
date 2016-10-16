---
title: "IDebugProgramEx2"
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
  - "IDebugProgramEx2"
helpviewer_keywords: 
  - "IDebugProgramEx2 interface"
ms.assetid: 663359ed-635a-4539-addb-0cc52f19d1bd
caps.latest.revision: 18
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
# IDebugProgramEx2
This interface lets the session debug manager (SDM) attach to a program and get the program node associated with a program.  
  
## Syntax  
  
```  
IDebugProgramEx2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface on the same object as the [IDebugProgram2](../extensibility/idebugprogram2.md) interface in order to let the SDM attach to a program while at the same time allowing the port supplier to track all sessions attached to the program. The custom port supplier can implement this interface if it chooses.  
  
## Notes for Callers  
 The SDM calls [QueryInterface](../Topic/QueryInterface.md) on an `IDebugProgram2` interface to obtain this interface to track sessions that have attached to programs.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProgramEx2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Attach](../extensibility/idebugprogramex2--attach.md)|Attaches a program to a session.|  
|[GetProgramNode](../extensibility/idebugprogramex2--getprogramnode.md)|Gets the program node associated with a program.|  
  
## Remarks  
 This interface is private between the SDM and the program.  
  
## Requirements  
 Header: Portpriv.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [IDebugProgram2](../extensibility/idebugprogram2.md)