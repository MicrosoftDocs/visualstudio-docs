---
title: "Event Descriptions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debugging [Debugging SDK], events"
ms.assetid: 09f61652-7e16-4bb0-8055-f61a84bf384e
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# Event Descriptions
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Each type of event has a specific purpose.  
  
## Events and the Reasons for Their Use  
  
|Event|Description|  
|-----------|-----------------|  
|Activate document events|Occur when the debug engine (DE) wants the IDE to open or bring a document to the foreground.|  
|Breakpoint bound or breakpoint error events|Sent when a breakpoint is bound or when a breakpoint cannot bind and an error is returned.|  
|Breakpoint unbound events|Occur when a bound breakpoint unbinds from code.|  
|Can stop events|Sent to the IDE to determine whether the user would like to stop at a specified point in code.|  
|Breakpoint events|Occur when a code or data breakpoint is hit.|  
|Document text events|Occur when text in a document is changed. These events are not sent through the `IDebugEventCallBack2::Event` method.|  
|Engine create events|Sent when an engine is first created.|  
|Entry point events|Sent when the program being debugged has run its initialization code and reached its first user entry point.|  
|Exception events|Sent when a running program hits an exception.|  
|Expression evaluation complete events|Sent when asynchronous expression evaluation is complete.|  
|Find Symbol events|Sent whenever the DE needs to ask the user to find symbols for a module.|  
|Load complete events|Sent only when the initial program load is complete and the first code is about to run in the program.|  
|Message events|Sent when messages are sent to users.|  
|Module load events|Sent when a new module is loaded or unloaded.|  
|Output string events|Sent when the program writes debug output.|  
|Create and destroy events|Sent to announce the creation or destruction of processes, programs, properties, sessions and threads so the Visual Studio IDE can keep track of the state of the programs being debugged.|  
|Step complete events|Sent when a step is complete.|  
|Thread name change events|Sent when the user changes the name of a thread.|  
|Program name change events|Sent when the user changes the name of a program.|  
  
## See Also  
 [Sending Events](../../extensibility/debugger/sending-events.md)
