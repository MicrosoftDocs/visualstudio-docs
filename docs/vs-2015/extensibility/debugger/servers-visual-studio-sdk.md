---
title: "Servers (Visual Studio SDK) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "servers, debugging"
  - "debugging [Debugging SDK], servers"
ms.assetid: 62236d64-7956-448c-9ac3-5528f3edac1d
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# Servers (Visual Studio SDK)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

In terms of the debugger architecture, a **server**:  
  
- Is a container of ports and port suppliers and is used to communicate ports and port suppliers to the session debug manager (SDM) and debug engines.  
  
- Can identify itself by name, and enumerate its ports and port suppliers.  
  
- Is represented by an [IDebugCoreServer2](../../extensibility/debugger/reference/idebugcoreserver2.md) interface, which is only implemented by Visual Studio (one instance of a server for each instance of Visual Studio running).  
  
## See Also  
 [Ports](../../extensibility/debugger/ports.md)   
 [Port Suppliers](../../extensibility/debugger/port-suppliers.md)   
 [Debugger Concepts](../../extensibility/debugger/debugger-concepts.md)   
 [IDebugCoreServer2](../../extensibility/debugger/reference/idebugcoreserver2.md)
