---
title: "Windows Script Engines | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Windows script engines"
ms.assetid: e576853d-7252-4eb9-81eb-9d5bb7626ab4
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Windows Script Engines
To implement a Microsoft Windows Script engine, create an OLE COM object that supports the following interfaces.  
  
|||  
|-|-|  
|Interface|Description|  
|[IActiveScript](../winscript/reference/iactivescript.md)|Provides the basic scripting ability. Implementation of this interface is required.|  
|[IActiveScriptParse](../winscript/reference/iactivescriptparse.md)|Provides the ability to add script text, evaluate expressions, and so on. Implementation of this interface is optional; however, if it is not implemented, the script engine must implement one of the IPersist* interfaces in order to load a script.|  
|IPersist*|Provides persistence support. Implementation of at least one of the following interfaces is required if [IActiveScriptParse](../winscript/reference/iactivescriptparse.md) is not implemented.<br /><br /> IPersistStorage: Provides support for the DATA={url} attribute in the OBJECT tag.<br /><br /> IPersistStreamInit: Provides support for the same as `IPersistStorage` as well as the DATA="string-encoded byte stream" attribute in the OBJECT tag.<br /><br /> IPersistPropertyBag: Provides support for the PARAM= attribute in the OBJECT tag.|  
  
> [!NOTE]
> It is possible that the scripting engine will never be called upon to save or restore a script state through `IPersist*`. Instead, [IActiveScriptParse](../winscript/reference/iactivescriptparse.md) is used by calling [IActiveScriptParse::InitNew](../winscript/reference/iactivescriptparse-initnew.md) to create a blank script, then scriptlets are added and connected to events with [IActiveScriptParse::AddScriptlet](../winscript/reference/iactivescriptparse-addscriptlet.md) and general code is added with [IActiveScriptParse::ParseScriptText](../winscript/reference/iactivescriptparse-parsescripttext.md). Nonetheless, a scripting engine should fully implement at least one `IPersist*` interface (preferably `IPersistStreamInit`), because other host applications may try to make use of them.  
  
 The following sections describe implementing a Windows Scripting engine in more detail.  
  
 See the [Windows Script Interfaces Reference](../winscript/reference/windows-script-interfaces-reference.md) for more information.  
  
## Registry Standard  
 A Windows Script engine can identify itself using category identifiers. Windows Script currently defines two category identifiers.  
  
|||  
|-|-|  
|Category|Description|  
|CATID_ActiveScript|Indicates that the class identifiers (CLSIDs) are Windows Script engines that support, at a minimum, the [IActiveScript](../winscript/reference/iactivescript.md) interface and a persistence mechanism (the `IPersistStorage`, `IPersistStreamInit`, or IPersistPropertyBag interface).|  
|CATID_ActiveScriptParse|Indicates that the CLSIDs are Windows Script engines that support, at a minimum, the [IActiveScript](../winscript/reference/iactivescript.md) and [IActiveScriptParse](../winscript/reference/iactivescriptparse.md) interfaces.|  
  
 Although [IActiveScriptParse](../winscript/reference/iactivescriptparse.md) is not a true persistence mechanism, it does support the [IActiveScriptParse::InitNew](../winscript/reference/iactivescriptparse-initnew.md) method that is functionally equivalent to `IPersist*::InitNew`.  
  
## Script Engine States  
 At any given time, a Windows Script engine can be in one of several states.  
  
|||  
|-|-|  
|State|Description|  
|uninitialized|The script has not been initialized or loaded using an IPersist* interface, or does not have an [IActiveScriptSite](../winscript/reference/iactivescriptsite.md) interface set. The scripting engine is generally not usable from this state until the script is loaded.|  
|initialized|The script has been initialized with an `IPersist*` interface and has an [IActiveScriptSite](../winscript/reference/iactivescriptsite.md) interface set, but is not connected to host objects and sinking events. Note that this state simply means that the `IPersist*::Load`, `IPersist*::InitNew`, or [IActiveScriptParse::InitNew](../winscript/reference/iactivescriptparse-initnew.md) method has been completed, and that the [IActiveScript::SetScriptSite](../winscript/reference/iactivescript-setscriptsite.md) method has been called. The engine cannot run code in this mode. The engine queues code that the host passes to it through the [IActiveScriptParse::ParseScriptText](../winscript/reference/iactivescriptparse-parsescripttext.md) method, and executes the code after transitioning to the started state.<br /><br /> Because languages can vary widely in semantics, scripting engines are not required to support this state transition. Engines that support the [IActiveScript::Clone](../winscript/reference/iactivescript-clone.md) method must, however, support this state transition. Hosts must prepare for this transition and take the appropriate action: release the current scripting engine, create a new scripting engine, and call `IPersist*::Load`, `IPersist*::InitNew`, or [IActiveScriptParse::InitNew](../winscript/reference/iactivescriptparse-initnew.md) (and possibly also call [IActiveScriptParse::ParseScriptText](../winscript/reference/iactivescriptparse-parsescripttext.md)). Use of this transition should be considered an optimization of the above steps. Note that any information the scripting engine has obtained about the names of Named Items and the type information describing Named Items remains valid.<br /><br /> Because languages vary widely, defining the exact semantics of this transition is difficult. At a minimum, the scripting engine must disconnect from all events, and release all of the SCRIPTINFO_IUNKNOWN pointers obtained by calling the [IActiveScriptSite::GetItemInfo](../winscript/reference/iactivescriptsite-getiteminfo.md) method. The engine must re-obtain these pointers after the script is run again. The scripting engine should also reset the script back to an initial state that is appropriate for the language. VBScript, for example, resets all variables and retains any code added dynamically by calling [IActiveScriptParse::ParseScriptText](../winscript/reference/iactivescriptparse-parsescripttext.md) with the SCRIPTTEXT_ISPERSISTENT flag set. Other languages may need to retain current values (such as Lisp because there is no code/data separation) or reset to a well-known state (this includes languages with statically initialized variables).<br /><br /> Note that the transition to the started state should have the same semantics (that is, it should leave the scripting engine in the same state) as calling `IPersist*::Save` to save the scripting engine, and then calling `IPersist*::Load` to load a new scripting engine; these actions should have the same semantics as [IActiveScript::Clone](../winscript/reference/iactivescript-clone.md). Scripting engines that do not yet support `IActiveScript::Clone` or `IPersist*` should carefully consider how the transition to the started state should behave, so that such a transition would not violate the above conditions if `IActiveScript::Clone` or `IPersist*` support was later added.<br /><br /> During this transition to the started state, the scripting engine will disconnect from event sinks after the appropriate destructors, and so on, are executed in the script. To avoid having these destructors executed, the host can first move the script into the disconnected state before moving into the started state.<br /><br /> Use [IActiveScript::InterruptScriptThread](../winscript/reference/iactivescript-interruptscriptthread.md) to cancel a running script thread without waiting for current events, and so on, to finish running.|  
|started|The transition from the initialized state to the started state causes the engine to execute any code that was queued in the initialized state. The engine can execute code while in the started state, but it is not connected to any events added through the [IActiveScript::AddNamedItem](../winscript/reference/iactivescript-addnameditem.md) method. The engine can execute code by calling the IDispatch interface obtained from the [IActiveScript::GetScriptDispatch](../winscript/reference/iactivescript-getscriptdispatch.md) method, or by calling [IActiveScriptParse::ParseScriptText](../winscript/reference/iactivescriptparse-parsescripttext.md). It is possible that further background initialization (progressive loading) is still ongoing, and that calling the [IActiveScript::SetScriptState](../winscript/reference/iactivescript-setscriptstate.md) method with the SCRIPTSTATE_CONNECTED flag set may cause the script to block until initialization is complete.|  
|connected|The script is loaded and connected for sinking events from host objects. If this is a transition from the initialized state, the scripting engine should transition through the started state, performing the necessary actions, before entering the connected state and connecting to events.|  
|disconnected|The script is loaded and has a run-time state, but is temporarily disconnected from sinking events from host objects. This can be done either logically (ignoring events received) or physically (calling IConnectionPoint::Unadvise on the appropriate connection points). If this is a transition from the initialized state, the scripting engine should transition through the started state, performing the necessary actions, before entering the disconnected state. Event sinks that are in progress are completed before the state changes (use [IActiveScript::InterruptScriptThread](../winscript/reference/iactivescript-interruptscriptthread.md) to cancel a running script thread). This state is distinguished from the initialized state in that the transition to this state does not cause the script to reset, the run-time state of the script is not reset, and a script initialization procedure is not executed.|  
|closed|The script has been closed. The scripting engine no longer works and returns errors for most methods.|  
  
 The following illustration shows the relationships between the various scripting engine states, and shows the methods that cause transitions from one state to another.  
  
 The following illustration shows the actions that the scripting engine performs during the various state transitions.  
  
## Scripting Engine Threading  
 Because a Windows Script engine can be used in many environments, it is important to keep its execution model as flexible as possible. For example, a server-based host may need to preserve a multithreaded design while using Windows Script in an efficient manner. At the same time, a host that does not use threading, such as a typical application, should not be burdened with threading management. Windows Script achieves this balance by restricting the ways a free-threaded scripting engine can call back to the host, freeing hosts from this burden.  
  
 Scripting engines used on servers are typically implemented as free-threading COM objects. This means that methods on the [IActiveScript](../winscript/reference/iactivescript.md) interface and its associated interfaces can be called from any thread in the process, without marshaling. (Unfortunately, this also means that the scripting engine must be implemented as an in-process server, because OLE does not currently support interprocess marshaling of free-threaded objects.) Synchronization is the responsibility of the scripting engine. For scripting engines that are not internally reentrant, or for language models that are not multithreaded, synchronization could be as simple as serializing access to the scripting engine with a mutex. Of course certain methods, such as [IActiveScript::InterruptScriptThread](../winscript/reference/iactivescript-interruptscriptthread.md), should not be serialized in this way so that a stuck script can be terminated from another thread.  
  
 The fact that [IActiveScript](../winscript/reference/iactivescript.md) is typically free-threaded generally implies that the [IActiveScriptSite](../winscript/reference/iactivescriptsite.md) interface and the host's object model should be free-threaded as well. This would make implementation of the host quite difficult, particularly in the common case where the host is a single-threaded Windows-based application with single-threaded or apartment-model ActiveX Controls in its object model. For this reason, the following constraints are placed on the scripting engine's use of [IActiveScriptSite](../winscript/reference/iactivescriptsite.md):  
  
 The script site is always called in the context of a host thread. That is, the scripting engine never calls the script site in the context of a thread that the scripting engine created, but only from within a scripting engine method that was called from the host through [IActiveScript](../winscript/reference/iactivescript.md) and its derivatives, through the exposed scripting engine's dispatch object, through a Windows message, or from an event source in the host's object model.  
  
 The script site is never called from within the context of a simple thread state control method (for example, the [IActiveScript::InterruptScriptThread](../winscript/reference/iactivescript-interruptscriptthread.md) method) or from the [IActiveScript::Clone](../winscript/reference/iactivescript-clone.md) method.  
  
## See also  
 [Windows Script Interfaces](../winscript/windows-script-interfaces.md)
