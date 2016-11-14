---
title: "Servers (Visual Studio SDK) | Microsoft Docs"
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
  
-   Is represented by an [IDebugCoreServer2](../../extensibility/debugger/reference/idebugcoreserver2.md) interface, which is only implemented by Visual Studio (one instance of a server for each instance of Visual Studio running).  
  
## See Also  
 [Ports](../../extensibility/debugger/ports.md)   
 [Port Suppliers](../../extensibility/debugger/port-suppliers.md)   
 [Debugger Concepts](../../extensibility/debugger/debugger-concepts.md)   
 [IDebugCoreServer2](../../extensibility/debugger/reference/idebugcoreserver2.md)