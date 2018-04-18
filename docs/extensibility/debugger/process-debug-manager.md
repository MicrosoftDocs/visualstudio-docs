---
title: "Process Debug Manager | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: 
  - "vs-ide-sdk"
ms.topic: "conceptual"
helpviewer_keywords: 
  - "machine debug manager"
  - "debugging [Debugging SDK], Machine Debug Manager"
ms.assetid: d0861e0c-b819-490c-9604-5e6d08ac291a
author: "gregvanl"
ms.author: "gregvanl"
manager: douge
ms.workload: 
  - "vssdk"
---
# Process Debug Manager
The process debug manager (PDM) is a component of Visual Studio that manages programs and processes, making them available to the session debug manager and the debug engines.  
  
 The PDM manages all the processes that can be debugged. To be debugged, a program must be registered with the PDM. This is done at the time the program is launched, either by a port or a debug engine.  
  
## See Also  
 [Processes](../../extensibility/debugger/processes.md)   
 [Debug Engine](../../extensibility/debugger/debug-engine.md)   
 [Ports](../../extensibility/debugger/ports.md)   
 [Programs](../../extensibility/debugger/programs.md)   
 [Debugger Components](../../extensibility/debugger/debugger-components.md)