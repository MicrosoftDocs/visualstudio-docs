---
title: "IDebugProgramEngines2"
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
  - "IDebugProgramEngines2"
helpviewer_keywords: 
  - "IDebugProgramEngines2 interface"
ms.assetid: 53d648f0-6c11-4337-badd-c43f3872b62c
caps.latest.revision: 11
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
# IDebugProgramEngines2
This interface is used by program nodes to specify all the possible debug engines (DE) that can debug this program.  
  
## Syntax  
  
```  
IDebugProgramEngines2 : IUnknown  
```  
  
## Notes for Implementers  
 A DE or a custom port supplier implements this interface on the same object that implements [IDebugProgramNode2](../extensibility/idebugprogramnode2.md) to support establishing a specific DE to use for a particular program.  
  
## Notes for Callers  
 Call [QueryInterface](../Topic/QueryInterface.md) on an `IDebugProgramNode2` interface to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProgramEngines2`.  
  
|Method|Description|  
|------------|-----------------|  
|[EnumPossibleEngines](../extensibility/idebugprogramengines2--enumpossibleengines.md)|Indicates all the possible DEs that can debug this program.|  
|[SetEngine](../extensibility/idebugprogramengines2--setengine.md)|Selects the DE to use for debugging this program.|  
  
## Remarks  
 Once a DE is chosen by the user, that choice is registered with the program node by calling [SetEngine](../extensibility/idebugprogramengines2--setengine.md). The selected engine becomes the engine returned by [GetEngineInfo](../extensibility/idebugprogramnode2--getengineinfo.md).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [IDebugProgramNode2](../extensibility/idebugprogramnode2.md)   
 [GetEngineInfo](../extensibility/idebugprogramnode2--getengineinfo.md)