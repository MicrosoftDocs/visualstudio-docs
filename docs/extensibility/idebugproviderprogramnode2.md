---
title: "IDebugProviderProgramNode2"
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
  - "IDebugProviderProgramNode2"
helpviewer_keywords: 
  - "IDebugProviderProgramNode2"
ms.assetid: f0bca1cc-afbe-44cf-b5aa-d078aa685d24
caps.latest.revision: 8
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
# IDebugProviderProgramNode2
This interface marshals program-related interfaces across process boundaries.  
  
## Syntax  
  
```  
IDebugProviderProgramNode2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface on the same object that implements [IDebugProgramNode2](../extensibility/idebugprogramnode2.md) to support marshaling interfaces across process boundaries.  
  
## Notes for Callers  
 Call [QueryInterface](../Topic/QueryInterface.md) on an `IDebugProgramNode2` interface to obtain this interface. If this interface cannot be obtained, the DE does not support marshaling of interfaces.  
  
## Methods in Vtable order  
 This interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[UnmarshalDebuggeeInterface](../extensibility/idebugproviderprogramnode2--unmarshaldebuggeeinterface.md)|Gets a specified interface across process boundaries.|  
  
## Remarks  
 This interface is implemented when the DE runs in a separate process space from the program being debugged: for example, when the DE is running in the Visual Studio process space instead of the process space of the program being debugged.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [IDebugProgramNode2](../extensibility/idebugprogramnode2.md)