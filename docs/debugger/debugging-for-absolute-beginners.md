---
title: "Debugging tips for Absolute Beginners"
description: "Learn a few tips to help you debug applications"
ms.custom: ""
ms.date: "03/27/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugger"
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload:
  - "multiple"
---
# Debugging for Absolute Beginners

If you are using Visual Studio and this is the first time that you've tried to debug an application, then you're in the right place. When you use a debugger for the first time, it's normal to hope (and expect) that whatever debugging tool you're using will magically show you all the bugs in your code. Unfortunately, it's not that easy. Debugging is a learned skill, and it takes time and practice to learn how to debug effectively. So before we teach you how to use the Visual Studio debugger, here are a couple of tips and principles.

## Clarify the problem by asking the yourself questions

It helps to clarify the problem that you ran into before you try to fix it. We expect that you already ran into a problem in your code, otherwise you wouldn't be here trying to figure out how to debug it! So, before you start debugging, ask yourself a few questions.

1. What did you expect your code to do?

1. What happened instead?

    If you ran into an error (exception), that can be a good thing! The [Exception Helper](../debugger/debugger-feature-tour.md#exception) in Visual Studio takes you to the exact place in your code where the exception occurred and gives you an error message to help you investigate possible fixes. (But before you investigate, finish reading this article.)

    If something else happened, what is the symptom of the problem? Do you already suspect where this problem occurred in your code? For example, if your code displays some text, but the text is incorrect, you know the code that set the display text has some kind of bug. To fix a problem like this, you most likely need to start your application with the Visual Studio debugger attached. (But first, continue reading this article.)

## Examine your assumptions

Before you investigate a bug or an error, think of the assumptions that made you expect a good result. This may be a long list, so here are a couple of examples.

* You are using the right API. An API that you're using might not do what you think it does. (After you examine the API call in the debugger, fixing it may require a trip to the documentation for the API.)

* You are using an API correctly. Maybe you used the right API, but didn't use it in the right way.

* Your code doesn't have any typos.

* You made a change to your code and assumed it is unrelated to the problem that you're seeing.

* You experienced a change in your environment (such as a tool or library update) and assumed it is unrelated to the problem that you're seeing.

* You expected an object or variable to store a certain value (or a certain type of value), but it doesn't.

* I understand this code well enough to debug it. It is often more difficult to debug someone else's code. You might need to spend time learning what the code does before you can debug it.

## If you didn't get an exception, step through your code to find where the problem occurred

You want to use the debugger to find the exact place where the problem occurred. Before you start, do your best to try to identify the specific region of code where the problem is occurring, then set a [breakpoint](../debugger/using-breakpoints.md) where that code begins. Then, start the debugger, use [step commands](../debugger/navigating-code-in-the-debugger.md) such as **F5**, **F10**, and **F11** to advance the debugger and run your code. While running your app in the debugger, look for the specific symptom that indicates a problem occurred.

> [!NOTE]
> If it is difficult to identify the region of code where you have a bug (that is, where the symptom occurs), set a breakpoint in code that runs before the symptom occurs, and then [step through code](../debugger/navigating-code-in-the-debugger.md) in the debugger until you see the symptom manifest. You can use [tracepoints](../debugger/using-breakpoints.md#BKMK_Print_to_the_Output_window_with_tracepoints) to log messages to the **Output** window. By looking at logged messages (and which messages were not logged!), you can often isolate the problem code. You may have to repeat this process multiple times to find the region of code with the bug. 

To find the cause of a bug while running your app in the debugger:

* Inspect variables and check whether they contain the type of values that they should contain. If you find a bad value, find out where the bad value was set (you might need to restart the debugger).

* Check whether your application is executing the code that you expect. (For example, maybe the code that you're using handles (hides) an exception, and you didn't realize that an exception occurred until you see the exception handler code get invoked.)

## Next steps

In this tutorial, you've learned a few general debugging concepts. Now, you can start learning how to debug with Visual Studio.

> [!div class="nextstepaction"]
> [Debugger feature tour](../debugger/debugger-feature-tour.md)
