---
title: "Calling Debugger Events"
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
  - "debugging [Debugging SDK], events"
ms.assetid: b3440ac3-80af-40c6-bef4-cbf00fa67885
caps.latest.revision: 7
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
# Calling Debugger Events
Events in debugging sessions occur in a specific order.  
  
## Discussion  
 To understand the pattern of calls between the debug engine (DE) and the session debug manager (SDM), the following represents the calling order of the events that occur in a typical debugging session:  
  
1.  [Attaching and detaching to a program](../extensibility/attaching-and-detaching-to-a-program.md)  
  
2.  [Launching the debugger](../extensibility/launching-the-debugger.md)  
  
3.  [Terminating a program](../extensibility/terminating-a-program.md)  
  
4.  [Creating a breakpoint](../extensibility/creating-a-breakpoint.md)  
  
5.  [When a breakpoint binds or becoming unbound](../extensibility/when-a-breakpoint-binds-or-becomes-unbound.md)  
  
6.  [Breakpoint errors](../extensibility/breakpoint-errors.md)  
  
7.  [Hitting a breakpoint](../extensibility/hitting-a-breakpoint.md)  
  
8.  [Deleting a breakpoint](../extensibility/deleting-a-breakpoint.md)  
  
9. [Entering break mode](../extensibility/entering-break-mode.md)  
  
10. [Stepping in break mode](../extensibility/stepping-in-break-mode.md)  
  
11. [Expression evaluation in break mode](../extensibility/expression-evaluation-in-break-mode.md)  
  
12. [Exception handling](../extensibility/exception-handling--visual-studio-sdk-.md)  
  
## See Also  
 [Creating a Custom Debug Engine](../extensibility/creating-a-custom-debug-engine.md)