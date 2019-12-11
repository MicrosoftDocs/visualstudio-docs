---
title: "IActiveScriptSiteDebugEx Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords:
  - "IActiveScriptSiteDebugEx Interface"
ms.assetid: 76869378-1a7b-47bd-8cd0-acc31f91d58d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteDebugEx Interface

Implement this interface along with the `IActiveScriptSiteDebug` interface if you are writing a host that needs to get a notification of a run-time error in an application and optionally attach to the application for debugging. The Process Debug Manager provides notification through `IActiveScriptDebug` if a Just-In-Time script debugger is found on the computer. If no Just-In-Time script debugger is found, the PDM provides notification through `IActiveScriptDebugEx` instead.

To get a notification of a run-time error, your host must handle `ActiveScriptSiteDebug::OnScriptErrorDebug`. Based on a user action, you can then decide whether to attach the internal debugger and return, or to return the starting of the debugger in the OnScriptErrorDebug `pfEnterDebugger` parameter.

## Methods in Vtable Order

|Method|Description|
|------------|-----------------|
|[IActiveScriptSiteDebugEx::OnCanNotJITScriptErrorDebug](../../winscript/reference/iactivescriptsitedebugex-oncannotjitscripterrordebug.md)|Informs the host about a script run-time error when the Process Debug Manager does not find an external Just In Time debugger.|