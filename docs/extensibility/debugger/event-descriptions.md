---
title: Event Descriptions
description: Learn about the types of events and the reasons for their use. Each type of event has a specific purpose.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], events
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Event descriptions

Each type of event has a specific purpose.

## Events and the reasons for their use

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
|Create and destroy events|Sent to announce the creation or destruction of processes, programs, properties, sessions, and threads so the Visual Studio IDE can keep track of the state of the programs being debugged.|
|Step complete events|Sent when a step is complete.|
|Thread name change events|Sent when the user changes the name of a thread.|
|Program name change events|Sent when the user changes the name of a program.|

## See also
- [Sending events](../../extensibility/debugger/sending-events.md)
