---
title: "IRemoteDebugApplication110 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IRemoteDebugApplication110 Interface"
ms.assetid: 785ab46a-8827-41cb-806a-132e6b2c8f47
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplication110 Interface
Used to provide new capabilities that can be called by script debuggers and in-process callers.  
  
> [!IMPORTANT]
> This interface is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Methods  
 The `IRemoteDebugApplication110` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IRemoteDebugApplication110::SetDebuggerOptions](../../winscript/reference/iremotedebugapplication110-setdebuggeroptions.md)|Called to update debugger options. The options default to 0 (SDO_NONE).|  
|[IRemoteDebugApplication110::GetCurrentDebuggerOptions](../../winscript/reference/iremotedebugapplication110-getcurrentdebuggeroptions.md)|Returns the current set of options that are enabled.|  
|[IRemoteDebugApplication110::GetMainThread](../../winscript/reference/iremotedebugapplication110-getmainthread.md)|Returns the main thread for hosts that call SetSite.|