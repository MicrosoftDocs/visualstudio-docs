---
title: "IDebugFirewallConfigurationCallback2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugFirewallConfigurationCallback2 interface"
ms.assetid: 0827361c-b97c-4851-9898-ab6d88c81811
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugFirewallConfigurationCallback2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Enables a debug engine that uses DCOM to ask the [!INCLUDE[vsprvs](../../../includes/vsprvs-md.md)] UI to make sure that the firewall will not block remote debugging.  
  
## Syntax  
  
```  
IDebugFirewallConfigurationCallback2 : IUnknown  
```  
  
## Notes for Implementers  
 Implemented by the port object of the session debug manager.  
  
## Methods  
 The following table shows the methods of `IDebugFirewallConfigurationCallback2`.  
  
|Method|Description|  
|------------|-----------------|  
|[EnsureDCOMUnblocked](../../../extensibility/debugger/reference/idebugfirewallconfigurationcallback2-ensuredcomunblocked.md)|Requests that the firewall not block remote debugging.|  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
