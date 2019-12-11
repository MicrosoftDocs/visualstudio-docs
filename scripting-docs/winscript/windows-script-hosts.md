---
title: "Windows Script Hosts | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Windows Script Host, implementing hosts"
ms.assetid: 9d5f6471-b318-40f3-be01-d9cd0b1cdd47
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Windows Script Hosts
When implementing Microsoft Windows Script host, you can safely assume that a scripting engine only calls the [IActiveScriptSite](../winscript/reference/iactivescriptsite.md) interface in the context of the base thread as long as the host does the following:  
  
- Chooses a base thread (generally the thread that contains the message loop).  
  
- Instantiates the scripting engine in the base thread.  
  
- Calls scripting engine methods only from the base thread, except where specifically allowed, as in the cases of [IActiveScript::InterruptScriptThread](../winscript/reference/iactivescript-interruptscriptthread.md) and [IActiveScript::Clone](../winscript/reference/iactivescript-clone.md).  
  
- Calls the scripting engine's dispatch object only from the base thread.  
  
- Ensures that the message loop runs in the base thread if a window handle is provided.  
  
- Ensures that objects in the host's object model only source events in the base thread.  
  
  These rules are automatically followed by all single-threaded hosts. The restricted model described above is intentionally loose enough to allow a host to abort a stuck script by calling [IActiveScript::InterruptScriptThread](../winscript/reference/iactivescript-interruptscriptthread.md) from another thread (initiated by a CTRL+BREAK handler or the like), or to duplicate a script in a new thread using [IActiveScript::Clone](../winscript/reference/iactivescript-clone.md).  
  
## Remarks  
 None of these restrictions apply to a host that chooses to implement a free-threaded [IActiveScriptSite](../winscript/reference/iactivescriptsite.md) interface and a free-threaded object model. Such a host can use the [IActiveScript](../winscript/reference/iactivescript.md) interface from any thread, without restriction.  
  
## See also  
 [Windows Script Interfaces](../winscript/windows-script-interfaces.md)