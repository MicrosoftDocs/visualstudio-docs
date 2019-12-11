---
title: "Error: Evaluating the function &#39;function&#39; timed out and needed to be aborted in an unsafe way | Microsoft Docs"
ms.date: 11/15/2016
ms.topic: reference
f1_keywords: 
  - "vs.debug.error.unsafe_func_eval_abort"
ms.assetid: 0a9f70ed-21ad-4a10-8535-b9c5885ad8f4
caps.latest.revision: 9
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Error: Evaluating the function &#39;function&#39; timed out and needed to be aborted in an unsafe way
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Full message text: Evaluating the function 'function' timed out and needed to be aborted in an unsafe way. This may have corrupted the target process. 

To make it easier to inspect the state of .NET objects, the debugger will automatically force the debugged process to run additional code (typically property getter methods and ToString functions). In most all scenarios, these functions complete quickly and make debugging much easier. However, the debugger doesn’t run the application in a sandbox. As a result, a property getter or ToString method that calls into a native function that hangs can lead to long timeouts that may not be recoverable. If you encounter this error message, this has occurred.
 
One common reason for this problem is that when the debugger evaluates a property, it only allows the thread being inspected to execute. So if the property is waiting on other threads to run inside the debugged application, and if it is waiting in a way that the .NET Runtime isn’t able to interrupt, this problem will happen.
 
## To correct this error
 
There are three possible solutions to this issue.
 
### Solution #1: Prevent the debugger from calling the getter property or ToString method
 
The error message will tell you the name of the function the debugger tried to call. If you can modify this function, you can prevent the debugger from calling the property getter or ToString method. Try one of the following:
 
* Change the method to some other type of code besides a property getter or ToString method and the problem will go away.
    -or-
* (For ToString) Define a DebuggerDisplay attribute on the type and you can have the debugger evaluate something other than ToString.
    -or-
* (For a property getter) Put the `[System.Diagnostics.DebuggerBrowsable(DebuggerBrowsableState.Never)]` attribute on the property. This can be useful if you have a method that needs to stay a property for API compatibility reasons, but it should really be a method.
 
### Solution #2: Have the target code ask the debugger to abort the evaluation
 
The error message will tell you the name of the function the debugger tried to call. If the property getter or ToString method sometimes fails to run correctly, especially in situations where the issue is that code needs another thread to run code, then the implementation function can call `System.Diagnostics.Debugger.NotifyOfCrossThreadDependency` to ask the debugger to abort the function evaluation. With this solution, it is still possible to explicitly evaluate these functions, but the default behavior is that execution stops when the NotifyOfCrossThreadDependency call occurs.
 
### Solution #3: Disable all implicit evaluation
 
If the previous solutions don't fix the issue, go to *Tools* / *Options*, and uncheck the setting *Debugging* / *General* / *Enable property evaluation and other implicit function calls*. This will disable most implicit function evaluations and should resolve the issue.
