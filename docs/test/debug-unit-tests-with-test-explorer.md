---
title: Debug unit tests with Test Explorer
description: Debug and analyze unit tests with Test Explorer in Visual Studio by setting breakpoints to diagnose test method performance issues.
ms.date: 02/13/2024
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
---
# Debug and analyze unit tests with Test Explorer

You can use Test Explorer to start a debugging session for your tests. Stepping through your code with the Visual Studio debugger seamlessly takes you back and forth between the unit tests and the project under test. To start debugging:

1. In the Visual Studio editor, set a breakpoint in one or more test methods that you want to debug.

    > [!NOTE]
    > Because test methods can run in any order, set breakpoints in all the test methods that you want to debug.

2. In Test Explorer, select the test method(s) and then choose **Debug** on the right-click menu.

   ::: moniker range=">=vs-2022"
   ![Test execution details](../test/media/vs-2022/test-explorer-debug.png)
   ::: moniker-end
   ::: moniker range="vs-2019"
   ![Test execution details](../test/media/vs-2019/test-explorer-debug.png)
   ::: moniker-end

   For more information, about the debugger, see [Debug in Visual Studio](../debugger/debugger-feature-tour.md).

## Diagnose test method performance issues

::: moniker range=">=vs-2022"
Starting in Visual Studio 2022 version 17.8, you can use any applicable tool in the Performance Profiler to help improve your code, and not just the Instrumentation tool. You can profile small units of work in isolation, make changes, and then remeasure and validate the impact of the change.

To diagnose why a test method is taking more time than you'd like, or using more memory than you'd like, select the method in Test Explorer and then choose **Profile** on the right-click menu. The **Performance Profiler** opens and you can select a profiling tool to test your code. For more information, see this [blog post](https://devblogs.microsoft.com/visualstudio/a-unit-of-profiling-makes-the-allocations-go-away/) or see [Collect profiling data without debugging](../profiling/running-profiling-tools-with-or-without-the-debugger.md#collect-profiling-data-without-debugging).
::: moniker-end

::: moniker range="vs-2019"
To diagnose why a test method is taking too much time, select the method in Test Explorer and then choose **Profile** on the right-click menu. See [Instrumentation profiling report](../profiling/understanding-instrumentation-data-values.md?view=vs-2017&preserve-view=true).

> [!NOTE]
> This feature is not currently supported for .NET Core.
::: moniker-end

## Related content

- [Unit test your code](../test/unit-test-your-code.md)
- [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md)
- [Test Explorer FAQ](test-explorer-faq.md)
