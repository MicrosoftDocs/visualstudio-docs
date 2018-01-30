---
title: "IDebugSourceServerModule | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugSourceServerModule interface"
ms.assetid: 38213060-451d-46e6-8b4a-efc123e01a2c
caps.latest.revision: 8
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugSourceServerModule
Represents the source server information that is contained in a PDB file.  
  
## Syntax  
  
```  
IDebugSourceServerModule : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by debugger engines and consumed by the debugger UI.  
  
## Methods  
 The following table shows the methods of `IDebugSourceServerModule`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetSourceServerData](../../../extensibility/debugger/reference/idebugsourceservermodule-getsourceserverdata.md)|Retrieves an array of source server information.|  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll