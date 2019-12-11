---
title: "IActiveScript | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScript interface"
ms.assetid: d8acee11-7f0d-4999-b97a-66774af16f71
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScript
Provides the methods necessary to initialize the scripting engine. The scripting engine must implement the `IActiveScript` interface.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScript::SetScriptSite](../../winscript/reference/iactivescript-setscriptsite.md)|Informs the scripting engine of the [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md) site provided by the host.|  
|[IActiveScript::GetScriptSite](../../winscript/reference/iactivescript-getscriptsite.md)|Retrieves the site object associated with the Windows Script engine.|  
|[IActiveScript::SetScriptState](../../winscript/reference/iactivescript-setscriptstate.md)|Places the scripting engine into the specified state.|  
|[IActiveScript::GetScriptState](../../winscript/reference/iactivescript-getscriptstate.md)|Retrieves the current state of the scripting engine.|  
|[IActiveScript::Close](../../winscript/reference/iactivescript-close.md)|Causes the scripting engine to abandon any currently loaded script, lose its state, and release any interface pointers it has to other objects, thus entering a closed state.|  
|[IActiveScript::AddNamedItem](../../winscript/reference/iactivescript-addnameditem.md)|Adds the name of a root-level item to the scripting engine's namespace.|  
|[IActiveScript::AddTypeLib](../../winscript/reference/iactivescript-addtypelib.md)|Adds a type library to the namespace for the script.|  
|[IActiveScript::GetScriptDispatch](../../winscript/reference/iactivescript-getscriptdispatch.md)|Retrieves the `IDispatch` interface for the running script.|  
|[IActiveScript::GetCurrentScriptThreadID](../../winscript/reference/iactivescript-getcurrentscriptthreadid.md)|Retrieves a scripting-engine-defined identifier for the currently executing thread.|  
|[IActiveScript::GetScriptThreadID](../../winscript/reference/iactivescript-getscriptthreadid.md)|Retrieves a scripting-engine-defined identifier for the thread associated with the given Microsoft Win32 thread.|  
|[IActiveScript::GetScriptThreadState](../../winscript/reference/iactivescript-getscriptthreadstate.md)|Retrieves the current state of a script thread.|  
|[IActiveScript::InterruptScriptThread](../../winscript/reference/iactivescript-interruptscriptthread.md)|Interrupts the execution of a running script thread.|  
|[IActiveScript::Clone](../../winscript/reference/iactivescript-clone.md)|Clones the current scripting engine (minus any current execution state), returning a loaded scripting engine that has no site in the current thread.|  
  
## See also  
 [Windows Script Interfaces Reference](../../winscript/reference/windows-script-interfaces-reference.md)