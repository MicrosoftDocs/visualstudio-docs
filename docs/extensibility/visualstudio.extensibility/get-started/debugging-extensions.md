---
title: 'Debug an extension created with VisualStudio.Extensibility'
description: learn how to for debug an out-of-process extension in the Visual Studio Experimental instance.
ms.topic: how-to
ms.date: 5/30/2023
ms.author: ghogen
monikerRange: ">=vs-2022"
author: ghogen
manager: jmartens
ms.technology: vs-ide-sdk
---

# Debug a Visual Studio extension

When you debug a Visual Studio extension, a special instance of Visual Studio called the Experimental Instance is used to host your extension while you run the debugger in main Visual Studio IDE. The two instances run independently side by side. This article describes how to debug extensions created with the VisualStudio.Extensibility SDK when they're running in the experimental instance of the VS IDE.

## Extension processes

Your extension is either an in-process or out-of-process extension. With an out-of-process extension, an additional component known as the ServiceHub host process actually hosts and loads your out-of-process extension's assembly and brokers all the communication between Visual Studio's IDE process and your extension's process. The VSIX project file contains information that lets Visual Studio know to launch the Visual Studio Experimental Instance and start the ServiceHub host process. You usually don't need to be concerned about the exact process, because when you launch the debugger from an extension project by pressing `F5` in the Visual Studio IDE, Visual Studio uses ServiceHub to locate the right process to connect the debugger to.

While the ServiceHub host process is started, and the debugger attaches to it, your extension assembly and its symbols are not immediately loaded. You extension's assembly won't load until it's activated in the IDE. So, when debugging, you would normally execute the user actions in the IDE to activate your extension and at that point, your extension assembly is loaded, the initialization code is executed, and you can hit breakpoints and step through code. The first code to run in your extension is the `InitializeAsync` method on the `Extension` class.

## Visual Studio code and extension code

Before your extension loads, Visual Studio keeps track of the places where the extension could be activated. This is managed in an internal instance of `VisualStudioContribution`. Even before your extension loads, Visual Studio has information about where it might be activated, such as when the user chooses a particular menu item, presses a toolbar button, or loads a file of a certain type into the editor. You won't see this in the debug session, because at that point, the extension assembly is loaded.

If your extension is in-process, the call stack includes Visual Studio stack frames as well as your extension's stack frames. Symbols are normally not available for Visual Studio, but you can see the calls where Visual Studio calls your extension.

With an out-of-process extension, you only see your extension's call stack; Visual Studio stack frames are in a separate process. Visual Studio calls into your extension through an RPC call on `IClientContext`, the ServiceHub host routes the call, and then execution in your process begins in the callback. Control returns to Visual Studio when your callback returns.

State is passed to your extension through the callback, but it is important to consider that it is a snapshot of the state, which could change between the time of the snapshot and the time when you're reading it from extension code or viewing it in the debugger.

There is some internal code in the ServiceHub host process that handles the RPC brokering. If a failure occurs in this layer, it is not visible to you. Such errors should be reported as product issues.

## Debug the extension in the experimental instance of Visual Studio

1. Open the extension project.
1. Set up a breakpoint, for example, in your extension's `InitializeAsync` method on the main class derived from `Extension`. To set a breakpoint on a line of code, click on the line, and press `F9`.
1. From the main menu, choose **Debug > Start Debugging** or press `F5`. Visual Studio Experimental Instance is launched; at the same time, the ServiceHub host process starts.
1. Execute the steps in the experimental instance of Visual Studio that cause your extension to activate or to reproduce the scenario you're intending to debug.
1. Visual Studio stops at a breakpoint.

> [!TIP]  It can be convenient to have multiple monitors, so you can see both the debugger and the experimental instance at the same time on two different monitors. You might want to change the Theme in the Experimental Instance to make it more obvious which IDE you're working with at any given time. See []().

## Attach to an extension process

You might occasionally need to attach to an extension process that's already running in the experimental instance of Visual Studio. You can do this if you have more than one extension that you're debugging in the same debug session. If you're already debugging one extension, you could attach to another extension. The Visual Studio debugger remains attached to the other processes it was already connected to when it attaches to a different extension process.

To connect manually using **Debug > Attach to Process**, the process to look for is `Microsoft.ServiceHub.Host.Extensibility`. There are usually multiple instances of this process running during a debug session; the appropriate one can be determined by looking at the command line and finding the one that references the experimental instance.

1. Choose **Debug > Attach to Process** from the main menu.
1. Locate and select the `Microsoft.ServiceHub.Host.Extensibility` process, and find the one with the experimental instance in the command line.
1. Choose **Attach**. The debugger should attach to the extension process.

## Next steps

Learn more about debugging -

Learn more about extensions -
