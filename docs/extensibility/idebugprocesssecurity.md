---
title: "IDebugProcessSecurity"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugProcessSecurity interface"
ms.assetid: 8a52ddca-bd99-49c0-9778-469dce7abd44
caps.latest.revision: 4
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
# IDebugProcessSecurity
`IDebugProcessSecurity` is implemented by a port supplier to warn the user that attaching to the process is unsafe.  
  
## Syntax  
  
```  
IDebugProcessSecurity : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProcessSecurity`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetUserName](../extensibility/idebugprocesssecurity--getusername.md)|Gets the user name from the port supplier.|  
|[QueryCanSafelyAttach](../extensibility/idebugprocesssecurity--querycansafelyattach.md)|Warns a user that attaching to the debugging process is unsafe.|  
  
## Remarks  
 Implement this interface to show a warning and allow the user to cancel if the process to which you are attaching can be considered unsafe.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Ports](../extensibility/ports.md)   
 [Port Suppliers](../extensibility/port-suppliers.md)   
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [IDebugProcess2](../extensibility/idebugprocess2.md)