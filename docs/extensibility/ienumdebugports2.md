---
title: "IEnumDebugPorts2"
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
  - "IEnumDebugPorts2"
helpviewer_keywords: 
  - "IEnumDebugPorts2"
ms.assetid: 1754eef3-cf62-42e0-b218-1911acba77d4
caps.latest.revision: 12
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
# IEnumDebugPorts2
This interface enumerates the ports of a machine or port supplier.  
  
## Syntax  
  
```  
IEnumDebugPorts2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface to represent a list of ports created by the supplier. Visual Studio implements this interface in support of its own port supplier.  
  
## Notes for Callers  
 Call [EnumPorts](../extensibility/idebugportsupplier2--enumports.md) to obtain this interface representing a list of ports created by the port supplier. Call [EnumPersistedPorts](../extensibility/idebugportsupplier3--enumpersistedports.md) to obtain this interface representing a list of ports that were saved to disk.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugPorts2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../extensibility/ienumdebugports2--next.md)|Retrieves a specified number of ports in an enumeration sequence.|  
|[Skip](../extensibility/ienumdebugports2--skip.md)|Skips a specified number of ports in an enumeration sequence.|  
|[Reset](../extensibility/ienumdebugports2--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../extensibility/ienumdebugports2--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../extensibility/ienumdebugports2--getcount.md)|Gets the number of ports in an enumerator.|  
  
## Remarks  
 Visual Studio uses this interface to help populate a list of ports used for attaching to processes.  
  
 A debug engine typically does not use this interface.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [EnumPorts](../extensibility/idebugcoreserver2--enumports.md)   
 [EnumPorts](../extensibility/idebugportsupplier2--enumports.md)