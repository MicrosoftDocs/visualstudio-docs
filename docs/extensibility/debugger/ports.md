---
title: "Ports | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "ports"
  - "debugging [Debugging SDK], ports"
ms.assetid: 1d7f3aa7-7eff-4cab-bc53-0a566b1a9363
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
# Ports
In terms of the debugger architecture, a **port**:  
  
-   Is a container for a set of processes running on a server. For example, a port might represent a connection to a Windows CE-based device by a serial cable, or to a networked non-DCOM machine. One special port, called the local port, contains all the processes running on the local machine.  
  
-   Can identify itself by name or identifier.  
  
-   Can enumerate all processes running on the port and launch and terminate these processes.  
  
-   Is represented by an [IDebugPort2](../../extensibility/debugger/reference/idebugport2.md) interface, which is created by passing an [IDebugPortRequest2](../../extensibility/debugger/reference/idebugportrequest2.md) argument to [AddPort](../../extensibility/debugger/reference/idebugportsupplier2-addport.md).  
  
 [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] supplies a default port that handles all Windows-based processes, native and managed. A custom port must be implemented for connections with external devices that are not Windows-based. To supply such custom ports, a custom port supplier also needs to be implemented.  
  
## See Also  
 [Servers](../../extensibility/debugger/servers-visual-studio-sdk.md)   
 [Processes](../../extensibility/debugger/processes.md)   
 [Debugger Concepts](../../extensibility/debugger/debugger-concepts.md)   
 [IDebugPort2](../../extensibility/debugger/reference/idebugport2.md)   
 [IDebugPortRequest2](../../extensibility/debugger/reference/idebugportrequest2.md)   
 [AddPort](../../extensibility/debugger/reference/idebugportsupplier2-addport.md)