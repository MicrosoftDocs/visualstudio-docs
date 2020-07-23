---
title: "Error - The target process exited with code &#39;code&#39; while evaluating the function &#39;function&#39; | Microsoft Docs"
ms.date: "4/06/2018"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.error.process_exit_during_func_eval"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Error: The target process exited with code &#39;code&#39; while evaluating the function &#39;function&#39;

Full message text: The target process exited with code 'code' while evaluating the function 'function'.

To make it easier to inspect the state of .NET objects, the debugger will automatically force the debugged process to run additional code (typically property getter methods and `ToString` functions). In most scenarios, these functions complete successfully or throw exceptions that can be caught by the debugger. However, there are some circumstances in which exceptions cannot be caught because they cross kernel boundaries, require user message pumping, or are unrecoverable. As a result, a property getter or ToString method that executes code that either explicitly terminates the process (for example, calls `ExitProcess()`) or throws an unhandled exception that cannot be caught (for example, `StackOverflowException`) will terminate the debugged process and end the debug session. If you encounter this error message, this has occurred.

One common reason for this problem is that when the debugger evaluates a property that calls itself, this may result in a stack overflow exception. The stack overflow exception cannot be recovered and the target process will terminate.

## To correct this error

There are two possible solutions to this issue.

### Solution #1: Prevent the debugger from calling the getter property or ToString method 

The error message will tell you the name of the function that the debugger tried to call. With the name of the function, you can try re-evaluating that function from the **Immediate** window to debug the evaluation. Debugging is possible when evaluating from the **Immediate** window because, unlike implicit evaluations from the **Autos/Locals/Watch** windows, the debugger breaks on unhandled exceptions.

If you can modify this function, you can prevent the debugger from calling the property getter or `ToString` method. Try one of the following:

* Change the method to some other type of code besides a property getter or ToString method and the problem will go away.
    -or-
* (For `ToString`) Define a `DebuggerDisplay` attribute on the type and you can have the debugger evaluate something other than `ToString`.
    -or-
* (For a property getter) Put the `[System.Diagnostics.DebuggerBrowsable(DebuggerBrowsableState.Never)]` attribute on the property. This can be useful if you have a method that needs to remain a property for API compatibility reasons, but it should really be a method.

If you cannot modify this method, you may be able to break the target process at an alternate instruction and retry the evaluation.

### Solution #2: Disable all implicit evaluation

If the previous solutions don't fix the issue, go to **Tools** > **Options**, and uncheck the setting **Debugging** > **General** > **Enable property evaluation and other implicit function calls**. This will disable most implicit function evaluations and should resolve the issue.
