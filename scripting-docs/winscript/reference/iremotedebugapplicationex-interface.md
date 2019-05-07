---
title: "IRemoteDebugApplicationEx Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IRemoteDebugApplicationEx Interface"
ms.assetid: 8e16164d-dbb2-4488-9507-25ae34f343dc
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationEx Interface
Represents a running application. It does not need to correspond to an operating system process. Typically, a debugger targets an application for debugging. The Process Debug Manager typically implements the application object.  
  
 In addition to the methods inherited from `IUnknown`, the `IRemoteDebugApplicationEx` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IRemoteDebugApplicationEx:GetHostPid](../../winscript/reference/iremotedebugapplicationex-gethostpid.md)|Returns the process ID for the host application.|  
|GetHostMachineName|Returns the name of the computer that the host application is running on.|  
|[IRemoteDebugApplicationEx:SetLocale](../../winscript/reference/iremotedebugapplicationex-setlocale.md)|Sets the language for the debugger localization.|  
|[IRemoteDebugApplicationEx:ForceStepMode](../../winscript/reference/iremotedebugapplicationex-forcestepmode.md)|Forces the debugger into single-step mode.|  
|[IRemoteDebugApplicationEx:RevokeBreak](../../winscript/reference/iremotedebugapplicationex-revokebreak.md)|Revokes a break command.|  
|SetProxyBlanketAndAddRef|Updates COM security information on a proxy for a debugger object to ensure compatibility with remote debugging from Windows 95-based operating systems.|  
|ReleaseFromSetProxyBlanket|Releases AddRef from SetProxyBlanketAndAddRef.|