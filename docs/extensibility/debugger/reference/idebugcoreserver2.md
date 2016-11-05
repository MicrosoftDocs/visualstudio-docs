---
title: "IDebugCoreServer2 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugCoreServer2"
helpviewer_keywords: 
  - "IDebugCoreServer2 interface"
ms.assetid: 9c47d0a6-9eb1-464e-bd44-fa2b552d4d36
caps.latest.revision: 14
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
# IDebugCoreServer2
This interface is used to represent and obtain information from a server on a machine on the network.  
  
## Syntax  
  
```  
IDebugCoreServer2 : IUknown  
```  
  
## Notes for Implementers  
 Visual Studio implements this interface to represent a server. Each instance of Visual Studio creates an instance of this interface.  
  
## Notes for Callers  
 A custom port supplier receives this interface in a call to [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md).  
  
 A debug engine can obtain this interface indirectly through a call to [GetServer](../../../extensibility/debugger/reference/idebugdefaultport2-getserver.md) (which returns [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md), an interface that is derived from `IDebugCoreServer2`).  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugCoreServer2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetMachineInfo](../../../extensibility/debugger/reference/idebugcoreserver2-getmachineinfo.md)|Gets the name and attributes of a machine.|  
|[GetMachineName](../../../extensibility/debugger/reference/idebugcoreserver2-getmachinename.md)|Gets the name of a machine.|  
|[GetPortSupplier](../../../extensibility/debugger/reference/idebugcoreserver2-getportsupplier.md)|Gets a port supplier that exists on a machine.|  
|[GetPort](../../../extensibility/debugger/reference/idebugcoreserver2-getport.md)|Gets a port that already exists on a machine.|  
|[EnumPorts](../../../extensibility/debugger/reference/idebugcoreserver2-enumports.md)|Creates an enumerator for all the ports on a machine.|  
|[EnumPortSuppliers](../../../extensibility/debugger/reference/idebugcoreserver2-enumportsuppliers.md)|Creates an enumerator for all the port suppliers on a machine.|  
|[GetMachineUtilities_V7](../../../extensibility/debugger/reference/idebugcoreserver2-getmachineutilities-v7.md)|Gets the machine utilities for a machine.|  
  
## Remarks  
 This interface is also used by Visual Studio to browse processes running on machines on the network.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)   
 [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md)   
 [GetServer](../../../extensibility/debugger/reference/idebugdefaultport2-getserver.md)   
 [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)