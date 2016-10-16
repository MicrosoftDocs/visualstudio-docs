---
title: "IDebugPortNotify2"
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
  - "IDebugPortNotify2"
helpviewer_keywords: 
  - "IDebugPortNotify2 interface"
ms.assetid: 43278b79-bf16-4c08-bcf1-6f7f7a17feab
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
# IDebugPortNotify2
This interface registers or unregisters a program that can be debugged with the port it is running on.  
  
## Syntax  
  
```  
IDebugPortNotify2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface to support adding and removing programs from the port. It is typically implemented on the same object that implements the [IDebugPort2](../extensibility/idebugport2.md) interface.  
  
## Notes for Callers  
 A call to [QueryInterface](../Topic/QueryInterface.md) on the `IDebugPort2` interface returns this interface. Also, a call to [GetPortNotify](../extensibility/idebugdefaultport2--getportnotify.md) returns this interface. A debug engine can see this interface as a parameter to [WatchForProviderEvents](../extensibility/idebugprogramprovider2--watchforproviderevents.md).  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugPortNotify2`.  
  
|Method|Description|  
|------------|-----------------|  
|[AddProgramNode](../extensibility/idebugportnotify2--addprogramnode.md)|Registers a program that can be debugged with the port it is running on.|  
|[RemoveProgramNode](../extensibility/idebugportnotify2--removeprogramnode.md)|Unregisters a program that can be debugged from the port it is running on.|  
  
## Remarks  
 Unless a debug port has a way to know when programs are loaded or unloaded, a custom port supplier must implement this interface. All programs that are loaded for debugging through a particular port are tracked using this interface.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [IDebugProgramNode2](../extensibility/idebugprogramnode2.md)