---
title: "IEnumDebugProcesses2"
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
  - "IEnumDebugProcesses2"
helpviewer_keywords: 
  - "IEnumDebugProcesses2"
ms.assetid: 06a1368f-10f0-44eb-af61-e388c2327111
caps.latest.revision: 13
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
# IEnumDebugProcesses2
This interface enumerates the processes running on a debug port.  
  
## Syntax  
  
```  
IEnumDebugProcesses : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface to provide a list of processes running on a port.  
  
## Notes for Callers  
 Visual Studio calls [EnumProcesses](../extensibility/idebugport2--enumprocesses.md) to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugProcesses2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../extensibility/ienumdebugprocesses2--next.md)|Retrieves a specified number of processes in an enumeration sequence.|  
|[Skip](../extensibility/ienumdebugprocesses2--skip.md)|Skips a specified number of processes in an enumeration sequence.|  
|[Reset](../extensibility/ienumdebugprocesses2--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../extensibility/ienumdebugprocesses2--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../extensibility/ienumdebugprocesses2--getcount.md)|Gets the number of processes in an enumerator.|  
  
## Remarks  
 Visual Studio uses this interface to populate the **Processes** window.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [EnumProcesses](../extensibility/idebugport2--enumprocesses.md)