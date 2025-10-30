---
title: What is debugging and a debugger?
description: Explore the process of debugging an application, what is a debugger, and the differences between debugging and running your app.
ms.date: "10/17/2018"
ms.topic: concept-article
helpviewer_keywords:
  - "debugger"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# What is debugging?

The Visual Studio debugger is a powerful tool. Before we show how to use it, we want to talk about some terms such as *debugger*, *debugging*, and *debug mode*. This way, when we talk later about finding and fixing bugs, we'll be talking about the same thing.

## Debugger vs. debugging

The term *debugging* can mean a lot of different things, but most literally, it means removing bugs from your code. Now, there are a lot of ways to do this. For example, you might debug by scanning your code looking for typos, or by using a code analyzer. You might debug code by using a performance profiler. Or, you might debug by using a *debugger*.

A debugger is a very specialized developer tool that attaches to your running app and allows you to inspect your code. In the debugging documentation for Visual Studio, this is typically what we mean when we say "debugging".

## Debug mode vs. running your app

When you run your app in Visual Studio for the first time, you may start it by pressing the green arrow button ![Start Debugging](../debugger/media/dbg-tour-start-debugging.png "Start Debugging") in the toolbar (or **F5**). By default, the **Debug** value appears in the drop-down to the left. If you are new to Visual Studio, this can leave the impression that debugging your app has something to do with running your app--which it does--but these are fundamentally two very different tasks.

![Select a Debug build](../debugger/media/what-is-debugging-debug-build.png)

A **Debug** value indicates a debug configuration. When you start the app (press the green arrow or **F5**) in a debug configuration, you start the app in *debug mode*, which means you are running your app with a debugger attached. This enables a full set of debugging features that you can use to help find bugs in your app.

If you have a project open, choose the drop-down selector where it says **Debug** and choose **Release** instead.

![Select a Release build](../debugger/media/what-is-debugging-release-build.png)

When you switch this setting, you change your project from a debug configuration to a release configuration. Visual Studio projects have separate release and debug configurations for your program. You build the debug version for debugging and the release version for the final release distribution. A release build is optimized for performance, but a debug build is better for debugging.

## When to use a debugger

The debugger is an essential tool to find and fix bugs in your apps. However, context is king, and it is important to leverage all the tools at your disposable to help you quickly eliminate bugs or errors. Sometimes, the right "tool" might be a better coding practice. By learning when to use the debugger vs. some other tool, you will also learn how to use the debugger more effectively.

## Related content

In this article, you've learned a few general debugging concepts. Next, you can start learning how to debug with Visual Studio and how to write code with less bugs. The following articles show C# code examples, but the concepts apply to all languages supported by Visual Studio.

> [!div class="nextstepaction"]
> [Debugging for absolute beginners](../debugger/debugging-absolute-beginners.md)

> [!div class="nextstepaction"]
> [Debugging techniques and tools](../debugger/write-better-code-with-visual-studio.md)
