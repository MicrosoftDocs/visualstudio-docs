---
title: "Debug Package"
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
  - "debugging [Debugging SDK], packages"
ms.assetid: 99947fd4-fb87-4c69-b26c-65634e17d285
caps.latest.revision: 9
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
# Debug Package
The debug package runs in the Visual Studio shell and handles all of the UI. It consumes the Visual Studio debugging interfaces and communicates with the session debug manager (SDM).  
  
 Break events sent through the SDM switch the debugger from run mode to break mode and change the focus to the program where the break occurred. The debug package tracks the stack frame and thread from the information sent to it by the events.  
  
 The debug package has no language or run-time environment dependencies. It is not necessary to implement or modify the debug package.  
  
 The debug package is implemented by vsdebug.dll.  
  
## See Also  
 [Session Debug Manager](../extensibility/session-debug-manager.md)   
 [Stack Frames](../extensibility/stack-frames.md)   
 [Threads](../extensibility/threads.md)   
 [Debugger Components](../extensibility/debugger-components.md)