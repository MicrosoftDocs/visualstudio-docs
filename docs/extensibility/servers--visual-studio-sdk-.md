---
title: "Servers (Visual Studio SDK)"
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
  - "servers, debugging"
  - "debugging [Debugging SDK], servers"
ms.assetid: 62236d64-7956-448c-9ac3-5528f3edac1d
caps.latest.revision: 17
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
# Servers (Visual Studio SDK)
In terms of the debugger architecture, a **server**:  
  
-   Is a container of ports and port suppliers and is used to communicate ports and port suppliers to the session debug manager (SDM) and debug engines.  
  
-   Can identify itself by name, and enumerate its ports and port suppliers.  
  
-   Is represented by an [IDebugCoreServer2](../extensibility/idebugcoreserver2.md) interface, which is only implemented by Visual Studio (one instance of a server for each instance of Visual Studio running).  
  
## See Also  
 [Ports](../extensibility/ports.md)   
 [Port Suppliers](../extensibility/port-suppliers.md)   
 [Debugger Concepts](../extensibility/debugger-concepts.md)   
 [IDebugCoreServer2](../extensibility/idebugcoreserver2.md)