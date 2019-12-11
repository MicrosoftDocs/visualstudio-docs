---
title: "Function Details View | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.view.functiondetails"
helpviewer_keywords:
  - "Function Details view"
  - "Profiling Tools, Function Details view"
ms.assetid: 8806954f-cf28-48d5-81b2-d722ceaf7d27
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Function Details View
The **Function Details View** window displays the following information:

- The **Cost Distribution** bar chart represents the relationships between a function that you select and the calling functions that executed the selected function, and between the selected function and the functions that were called by it.

- The **Function Performance Details** table that shows summary profiling data for the function that you specify.

- The **Function Code View** window, which shows the function code when the code is available.

  The **Function Code View** window is a separate pane. By default, the two panes are split horizontally, and the **Function Code View** window is positioned at the bottom of the frame.

- To split the two panes vertically, click **Split Screen Vertically** on the toolbar.

- To change the relative size of the panes, click the shaded border between the frames and drag the border to a different location.

## Cost Distribution Bar Chart

### Performance Metrics
 In the **Performance metric** drop-down list, you can specify which values appear in the view. The values that are available depend on the profiling method that was used in the profiling data file. Names in parentheses are the names of rows in the **Function Performance Details** table.

### Bar Chart
 **Calling Functions**

 The **Calling Functions** bar shows the functions that called the selected function. The size of the block that contains the calling function is in proportion to the contribution of the calling function to the total value of the performance metric for the selected function.

 You can click the name of a calling function to make it the selected function in the view.

- If there are too many calling functions to list, functions with the smallest contributions are collected in an **Other** block. Click **Other** to display all calling and called functions of the selected function in the **Caller/Callee View** window. For more information, see [Caller/Callee View](../profiling/caller-callee-view.md).

- If there are no calling functions or if the function is the entry function of a thread or process, a **Top of Stack** block appears.

  **Selected Function**

  The selected function bar shows the contributions of called functions and of code in the selected function to the total performance metric of the selected function. The size of the block that contains a called function or the function body is in proportion to the its contribution to the total value of the performance metric for the selected function.

  You can click the name of a called function to make it the selected function in the view.

- The **Total** value is the performance metric for the selected function.

- The **Function Body** block represents the amount of the total value of the performance metric that occurred in the direct execution of code in the body of the function.

- Functions that are called by the selected function are listed in blocks. The size of  selected functions block represent the amount of the total performance metric for the selected function that occurred in the called function.

- If there are too many calling functions to list, functions with the smallest contributions are collected in an **Other** block. Click **Other** to display all calling and called functions of the selected function in the **Caller/Callee View** window. For more information, see [Caller/Callee View](../profiling/caller-callee-view.md).

- If there are no called functions, a **Bottom of Stack** block appears.

## Function Performance Details
 The Function Performance Details table provides summary data for the performance metrics of the selected function. Both the value and the percentage appear. You specify the specify the profiling data that appears in the chart and the details table in the **Performance metric** list.

|Column|Description|
|------------|-----------------|
|**Exclusive**|-   The amount of the performance metric that occurred in execution of the function body.|
|**In Calls**|-   The amount of the performance metric that occurred in functions that the selected function called.|
|**Inclusive Total**|-   The total of the **Exclusive** and **In Calls** values.|

## Function Code View
 The **Function Code View** window displays a list of the source code when it is available. Next to the source code lines that call other functions, a shaded column contains the performance metric values for the called function. To edit the source code, click the link to the source code file.

## Cost Distribution Bar Chart Values

### Sampling
 The following table explains the values in the Performance Metric list for profiling data that was collected by using the sampling method.

|||
|-|-|
|**Inclusive Samples (Collected Samples)**|-   For a calling function, the number of samples that were collected when the selected function was called by this calling function.<br />-   For the Function Body, the number of samples that were collected when the selected function was executing its own code.<br />-   For a called function, the number of samples that were collected when the called function was executing because of a call from the selected function.|

### Instrumentation
 The following table explains the values in the Performance Metric list for profiling data that was collected by using the instrumentation method.

|||
|-|-|
|**Elapsed Inclusive Time (Elapsed Time)**|Elapsed time includes time that was spent in calls to the operating system, such as context switches and input/output operations.<br /><br /> -   For a **Calling Function**, the amount of elapsed time that was spent executing the instances of the selected function that were called by the function. Time spent in functions called by the selected function is included.<br />-   For the **Function Body**, the total amount of elapsed time spent executing the code of the selected function. Time spent in called functions is not included.<br />-   For a called function, the amount time spent executing the instances of the function that were called by the selected function. The total includes time that was spent in functions that the function called. Time spent in functions called by the selected function is included.|
|**Application Inclusive Time (Application Time)**|Application time does not include time that was spent in calls to the operating system, such as context switches and input/output operations.<br /><br /> -   For a **Calling Function**, the amount of application time that was spent executing the instances of the selected function that were called by the function. Time spent in functions called by the selected function is included.<br />-   For the **Function Body**, the total amount of application time spent executing the code of the selected function. Time spent in called functions is not included.<br />-   For a called function, the amount application time spent executing the instances of the function that were called by the selected function. The total includes time that was spent in functions that the function called.|

### .NET Memory
 The following table explains the values in the Performance Metric list for profiling data that was collected by using the .NET memory profiling method.

|||
|-|-|
|**Inclusive Allocations (Allocations)**|-   For a **Calling Function**, the number of objects that were allocated by the instances of the selected function that the function called. The number includes objects that were allocated by functions that the selected function called.<br />-   For the **Function Body**, the number of objects that were allocated by the by the selected function when it was executing its own code. Objects allocated in functions called by the selected function are not included.<br />-   For a called function, the number of objects that were allocated by the instances of the function that were called by the selected function. The number includes objects that were allocated by functions that the function called.|
|**Inclusive Bytes (Bytes)**|-   For a **Calling Function**, the number of bytes that were allocated by the instances of the selected function that the function called. The number includes bytes that were allocated by functions that the selected function called.<br />-   For the **Function Body**, the total number of bytes that were allocated by the selected function when it was executing its own code. Bytes allocated in functions called by the selected function are not included.<br />-   For a called function, the number of bytes that were allocated by the instances of the function that were called by the selected function. The number includes bytes that were allocated by functions that the function called.|

### Concurrency
 The following table explains the values in the Performance Metric list for profiling data that was collected by using the concurrency method.

|||
|-|-|
|**Inclusive Contentions (Contentions)**|-   For a **Calling Function**, the number of resource contention events that occurred in the instances of the selected function that the function called. The number includes contention events in functions that the selected function called.<br />-   For the **Function Body**, the total number of contention events that occurred when the function was executing its own code. Contentions occurring in functions that were called by the selected function are not included.<br />-   For a called function, the number of contention events that occurred in the instances of the function that were called by the selected function. The number includes contention events that occurred in functions that function called.|
|**Inclusive Blocked Time (Blocked Time)**|-   For a calling function, the time that was spent in resource contention events for the instances of the selected function that the function called. The time includes blocked time in functions that selected function called.<br />-   For the **Function Body**, the total time that was spent in contention events that occurred when the function was executing its own code. Contentions occurring in functions that the selected function called are not included.<br />-   For a called function, the time that was spent in resource contention events for the instances of the function that the selected function called. The time includes blocked time that occurred in functions that the function called.|
