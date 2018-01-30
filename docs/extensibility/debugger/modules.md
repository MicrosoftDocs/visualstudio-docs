---
title: "Modules | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "modules"
  - "debugging [Debugging SDK], modules"
ms.assetid: c4cf2809-dbdb-4e75-9273-b3d3d77b67d0
caps.latest.revision: 9
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# Modules
In terms of the debugger architecture, a **module**:  
  
-   Is a physical container of code, such as an executable file or a DLL.  
  
-   Can reload its symbols and describe itself. Module descriptions are displayed in the Modules window of the IDE.  
  
-   Is represented by an [IDebugModule2](../../extensibility/debugger/reference/idebugmodule2.md) interface, created by a debug engine to describe the module.  
  
## See Also  
 [Debugger Concepts](../../extensibility/debugger/debugger-concepts.md)   
 [IDebugModule2](../../extensibility/debugger/reference/idebugmodule2.md)