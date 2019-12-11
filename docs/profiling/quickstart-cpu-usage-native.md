---
title: "Analyze CPU usage data (C++)"
description: "Measure app performance in C++ using the CPU Usage diagnostics tool"
ms.date: 08/06/2018
ms.topic: quickstart
f1_keywords:
  - ""
helpviewer_keywords:
  - "Profiling Tools, quick start"
  - "Diagnostics Tools, CPU Usage"
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "cplusplus"
---
# Quickstart: Analyze CPU usage data in Visual Studio (C++)

The Visual Studio provides many powerful features to help you analyze performance issues in your application. This topic provides a quick way to learn some of the basic features. Here, we look at the tool to identify performance bottlenecks due to high CPU usage. The Diagnostics Tools are supported for .NET development in Visual Studio, including ASP.NET, and for native/C++ development.

The Diagnostic hub offers you a lot of other options to run and manage your diagnostics session. If the **CPU Usage** tool described here does not give you the data that you need, the [other profiling tools](../profiling/profiling-feature-tour.md) provide different kinds of information that might be helpful to you. In many cases, the performance bottleneck of your application may be caused by something other than your CPU, such as memory, rendering UI, or network request time. The Diagnostics hub offers you a lot of other options to record and analyze this kind of data.

Windows 8 and later is required to run profiling tools with the debugger (**Diagnostic Tools** window). On Windows 7 and later, you can use the post-mortem tool, the [Performance Profiler](../profiling/profiling-feature-tour.md).

## Create a project

1. In Visual Studio, choose **File** > **New Project**.

2. Under **Visual C++**, choose **Windows Desktop**, and then in the middle pane choose **Windows Console Application**.

    If you don't see the **Windows Console Application** project template, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box. The Visual Studio Installer launches. Choose the **Desktop development with C++** workload, then choose **Modify**.

3. Type a name like **Diagnostics_Get_Started_Native** and click **OK**.

    Visual Studio creates the project.

4. In *MyDbgApp.cpp*, replace the following code

    ```c++
    int main()
    {
        return 0;
    }
    ```

    with this code (do not remove `#include "stdafx.h"`):

    ```c++
    #include <iostream>
    #include <limits>
    #include <mutex>
    #include <random>
    #include <functional>

    //.cpp file code:

    static constexpr int MIN_ITERATIONS = std::numeric_limits<int>::max() / 1000;
    static constexpr int MAX_ITERATIONS = MIN_ITERATIONS + 10000;

    long long m_totalIterations = 0;
    std::mutex m_totalItersLock;

    int getNumber()
    {

        std::uniform_int_distribution<int> num_distribution(MIN_ITERATIONS, MAX_ITERATIONS);
        std::mt19937 random_number_engine; // pseudorandom number generator
        auto get_num = std::bind(num_distribution, random_number_engine);
        int random_num = get_num();

        auto result = 0;
        {
            std::lock_guard<std::mutex> lock(m_totalItersLock);
            m_totalIterations += random_num;
        }
        // we're just spinning here
        // to increase CPU usage
        for (int i = 0; i < random_num; i++)
        {
            result = get_num();
        }
        return result;
    }

    void doWork()
    {
        std::wcout << L"The doWork function is running on another thread." << std::endl;

        auto x = getNumber();
    }

    int main()
    {
        std::vector<std::thread> threads;

        for (int i = 0; i < 10; ++i) {

            threads.push_back(std::thread(doWork));
            std::cout << "The Main() thread calls this after starting the new thread" << std::endl;
        }

        for (auto& thread : threads) {
            thread.join();
        }

        return 0;
    }
    ```

## Step 1: Collect profiling data

1. First, set a breakpoint in your app on this line of code in the `main` function:

    `for (int i = 0; i < 10; ++i) {`

    Set a breakpoint by clicking in the gutter to the left of the line of code.

2. Next, set a second breakpoint on the closing brace at the end of the `main` function:

     ![Set breakpoints for profiling](../profiling/media/quickstart-cpu-usage-breakpoints-cplusplus.png "Set breakpoints for profiling")

    > [!TIP]
    > By setting two breakpoints, you can limit data collection to the parts of code that you want to analyze.

3. The **Diagnostic Tools** window is already visible unless you have turned it off. To bring up the window again, click **Debug** > **Windows** > **Show Diagnostic Tools**.

4. Click **Debug** > **Start Debugging** (or **Start** on the toolbar, or **F5**).

     When the app finishes loading, the **Summary** view of the Diagnostics Tools appears.

5. While the debugger is paused, enable the collection of the CPU Usage data by choosing **Record CPU Profile**, and then open the **CPU Usage** tab.

     ![Diagnostics Tools Enable CPU Profiling](../profiling/media/quickstart-cpu-usage-summary.png "Diagnostics Tools Enable CPU Profiling")

     When data collection is enabled, the record button displays a red circle.

     When you choose **Record CPU Profile**, Visual Studio will begin recording your functions and how much time they take to execute, and also provides a timeline graph you can use to focus on specific segments of the sampling session.You can only view this collected data when your application is halted at a breakpoint.

6. Hit F5 to run the app to your second breakpoint.

     Now, you now have performance data for your application specifically for the region of code that runs between the two breakpoints.

     The profiler begins preparing thread data. Wait for it to finish.

     The CPU Usage tool displays the report in the **CPU Usage** tab.

     At this point, you can begin to analyze the data.

## Step 2: Analyze CPU usage data

We recommend that you begin analyzing your data by examining the list of functions under CPU Usage, identifying the functions that are doing the most work, and then taking a closer look at each one.

1. In the function list, examine the functions that are doing the most work.

     ![Diagnostics Tools CPU Usage Tab](../profiling/media/quickstart-cpu-usage-cpu-cplusplus.png "DiagToolsCPUUsageTab")

    > [!TIP]
    > Functions are listed in order starting with those doing the most work (they're not in call order). This helps you quickly identify the longest running functions.

2. In the function list, double-click the `getNumber` function.

    When you double-click the function, the **Caller/Callee** view opens in the left pane.

    ![Diagnostics Tools Caller Callee View](../profiling/media/quickstart-cpu-usage-caller-callee-cplusplus.png "DiagToolsCallerCallee")

    In this view, the selected function shows up in the heading and in the **Current Function** box (`getNumber`, in this example). The function that called the current function is shown on the left under **Calling Function**, and any functions called by the current function are shown in **Called Functions** box on the right. (You can select either box to change the current function.)

    This view shows you the total time (ms) and the percentage of the overall app running time that the function has taken to complete.

    **Function Body** also shows you the total amount of time (and the percentage of time) spent in the function body excluding time spent in calling and called functions. (In this illustration, 119 out of 43602 ms were spent in the function body, and the remaining time was spent in other code called by this function). Actual values will be very different depending on your environment.

    > [!TIP]
    > High values in **Function Body** may indicate a performance bottleneck within the function itself.

## Next steps

- [Analyze memory usage](../profiling/memory-usage.md)to identify performance bottlenecks.
- [Analyze CPU usage](../profiling/cpu-usage.md) for more in-depth information on the CPU usage tool.
- Analyze CPU usage without a debugger attached or by targeting a running app - for more information see [Collect profiling data without debugging](../profiling/running-profiling-tools-with-or-without-the-debugger.md#collect-profiling-data-without-debugging) in [Run profiling tools with or without the debugger](../profiling/running-profiling-tools-with-or-without-the-debugger.md).

## See also

- [Profiling in Visual Studio](../profiling/index.yml)
- [First look at profiling tools](../profiling/profiling-feature-tour.md)
