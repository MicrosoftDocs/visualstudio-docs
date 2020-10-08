---
title: "Modules | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "modules"
  - "debugging [Debugging SDK], modules"
ms.assetid: c4cf2809-dbdb-4e75-9273-b3d3d77b67d0
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# Modules
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

In terms of the debugger architecture, a **module**:  
  
- Is a physical container of code, such as an executable file or a DLL.  
  
- Can reload its symbols and describe itself. Module descriptions are displayed in the Modules window of the IDE.  
  
- Is represented by an [IDebugModule2](../../extensibility/debugger/reference/idebugmodule2.md) interface, created by a debug engine to describe the module.  
  
## See Also  
 [Debugger Concepts](../../extensibility/debugger/debugger-concepts.md)   
 [IDebugModule2](../../extensibility/debugger/reference/idebugmodule2.md)
