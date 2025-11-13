---
title: "Evaluating the function &apos;function&apos; timed out and needed to be aborted in an unsafe way"
description: "Full message text: Evaluating the function 'function' timed out and needed to be aborted in an unsafe way."
ms.date: "10/28/2025"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.error.unsafe_func_eval_abort"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Error: Evaluating the function &#39;function&#39; timed out and needed to be aborted in an unsafe way

Full message text: Evaluating the function 'function' timed out and needed to be aborted in an unsafe way. The issue might cause corruption of the target process.

To make it easier to inspect the state of .NET objects, the debugger will automatically force the debugged process to run other code (typically property getter methods and ToString functions). In most all scenarios, these functions complete quickly and make debugging easier. However, the debugger doesn't run the application in a sandbox. As a result, a property getter or ToString method that calls into a native function that stops responding can lead to long timeouts that might not be recoverable. If you encounter this error message, this has occurred.

One common reason for this problem is that when the debugger evaluates a property, it only allows the thread being inspected to execute. So if the property is waiting on other threads to run inside the debugged application, and if it's waiting in a way that the .NET Runtime isn't able to interrupt, this problem happens.

## To correct this error

See the following sections for several possible solutions to this issue.

## Solution #1: Prevent the debugger from calling the getter property or ToString method

The error message tells you the name of the function the debugger tried to call. If you can modify this function, you can prevent the debugger from calling the property getter or ToString method. Try one of the following:

* Change the method to some other type of code besides a property getter or ToString method and the problem will go away.

    -or-

* (For ToString) Define a [DebuggerDisplay](../debugger/using-the-debuggerdisplay-attribute.md) attribute on the type and you can have the debugger evaluate something other than ToString.

    -or-

* (For a property getter) Put the [System.Diagnostics.DebuggerBrowsable(DebuggerBrowsableState.Never)](/dotnet/api/system.diagnostics.debuggerbrowsableattribute) attribute on the property. This can be useful if you have a method that needs to stay a property for API compatibility reasons, but it should really be a method.

## Solution #2: Have the target code ask the debugger to abort the evaluation

The error message tells you the name of the function the debugger tried to call. If the property getter or ToString method sometimes fails to run correctly, especially in situations where the issue is that code needs another thread to run code, then the implementation function can call [System.Diagnostics.Debugger.NotifyOfCrossThreadDependency](/dotnet/api/system.diagnostics.debugger.notifyofcrossthreaddependency) to ask the debugger to abort the function evaluation. With this solution, it's still possible to explicitly evaluate these functions, but the default behavior is that execution stops when the NotifyOfCrossThreadDependency call occurs.

## Solution #3: Disable all implicit evaluation

If the previous solutions don't fix the issue, you can disable the **Enable property evaluation and other implicit function calls** option. This configuration disables most implicit function evaluations and should resolve the issue.

:::moniker range="visualstudio"

In the **Tools** > **Options** pane, expand the **All Settings** > **Debugging** > **General** section, and clear the **Enable property evaluation and other implicit function calls** checkbox.

:::moniker-end
:::moniker range="<=vs-2022"
      
In the **Tools** > **Options** dialog, expand the **Debugging** > **General** section, and clear the **Enable property evaluation and other implicit function calls** checkbox.

:::moniker-end

## Solution #4: Check compatibility with third-party developer tools

If you're using Resharper, see this [issue](https://youtrack.jetbrains.com/issue/RSRP-476824) for suggestions.

::: moniker range="vs-2019"

## Solution #5: Enable managed compatibility mode

If you switch to the legacy debugging engine, you might be able to eliminate this error. Go to **Tools** > **Options**, and select the setting **Debugging** > **General** > **Use managed compatibility mode**. For more information, see [General debugging options](../debugger/general-debugging-options-dialog-box.md).
::: moniker-end
