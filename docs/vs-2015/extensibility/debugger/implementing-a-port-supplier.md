---
title: "Implementing a Port Supplier | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], implementing port suppliers"
  - "port suppliers, implementing"
ms.assetid: 6b8579df-58df-4c7f-8112-6015993e8765
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
---
# Implementing a Port Supplier
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [Implementing a Port Supplier](https://docs.microsoft.com/visualstudio/extensibility/debugger/implementing-a-port-supplier).  
  
A port supplier supplies ports on request to the session debug manager (SDM). A port supplier needs to be implemented when debugging to a non-DCOM machine or when a new device needs to be supported. For example, to provide debugging to a cell phone, you might implement a port supplier that provides ports that connect to the cell phone (perhaps by means of IR or a cell connection) and enumerates the processes and programs running on the phone.  
  
 For debugging programs on Windows-based machines (including remote debugging), Visual Studio provides port suppliers for native and Common Language Runtime (CLR) processes, so there is no need to implement your own port supplier in those cases.  
  
## In This Section  
 [Implementing and Registering a Port Supplier](../../extensibility/debugger/implementing-and-registering-a-port-supplier.md)  
 Discusses how the SDM interacts with the port supplier and its ports.  
  
 [Required Port Supplier Interfaces](../../extensibility/debugger/required-port-supplier-interfaces.md)  
 Documents the interfaces that must be implemented to obtain a port supplier.  
  
## Related Sections  
 [Debugger Concepts](../../extensibility/debugger/debugger-concepts.md)  
 Describes the main debugging architectural concepts.  
  
## See Also  
 [Visual Studio Debugger Extensibility](../../extensibility/debugger/visual-studio-debugger-extensibility.md)

