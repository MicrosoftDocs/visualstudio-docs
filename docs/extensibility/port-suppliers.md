---
title: "Port Suppliers"
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
  - "port suppliers"
  - "debugging [Debugging SDK], port suppliers"
ms.assetid: a8f3db96-1a13-4e93-9ef6-0861880369e0
caps.latest.revision: 15
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
# Port Suppliers
In terms of the debugger architecture, a **port supplier**:  
  
-   Is contained by a server and provides ports on request to that server.  
  
-   Can add and remove ports from the containing server.  
  
-   Can enumerate all the ports it has supplied to the server.  
  
-   Is represented by an [IDebugPortSupplier2](../extensibility/idebugportsupplier2.md) interface, which is registered with Visual Studio through the registry. This interface can be obtained by calling [GetPortSupplier](../extensibility/idebugcoreserver2--getportsupplier.md).  
  
 [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] provides a default port supplier and a default port. If a custom port needs to be implemented, a custom port supplier also needs to be implemented to supply those custom ports.  
  
## See Also  
 [Servers](../extensibility/servers--visual-studio-sdk-.md)   
 [Ports](../extensibility/ports.md)   
 [Debugger Concepts](../extensibility/debugger-concepts.md)   
 [IDebugPortSupplier2](../extensibility/idebugportsupplier2.md)   
 [GetPortSupplier](../extensibility/idebugcoreserver2--getportsupplier.md)