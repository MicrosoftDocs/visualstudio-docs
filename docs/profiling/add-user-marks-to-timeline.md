---
title: Add user marks to the profiling timeline
description: Learn how to include your own user marks in the profiling timeline to track custom events
ms.date: 07/16/2024
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
monikerRange: '>= vs-2022'
---

# Add user marks to the profiling timeline

User Marks enable you to track custom events against Visual Studio's Profiler tools by adding "marks" into your code, which will appear on the swimlane timelines. You can do this to track a single event, or track a range (for instance, a "stop" and "start" event range).

> [!NOTE]
> This feature is currently only available in the Performance Profiler and not while debugging in the Diagnostics Hub.

## Installation and setup

### Add as a NuGet Package

For .NET, download the package, [Microsoft.VisualStudio.DiagnosticsHub.UserMarks](https://www.nuget.org/packages/Microsoft.VisualStudio.DiagnosticsHub.UserMarks).

### Add source files

After installing Visual Studio, navigate to `[VS installation path]\Common7\IDE\CommonExtensions\Platform\DiagnosticsHub`.

For managed C# code, add *UserMarks.cs* and *UserMarksRange.cs* to your project.

For native C++ code, add *UserMarks.h* to your project.

## Add user marks in C#

Add the following preprocessor definition to the project build configuration: `DIAGHUB_ENABLE_TRACE_SYSTEM`.

To add the definition in Visual Studio, right click on the project and then select **Properties > Build > General > add to "Conditional compilation symbols.**

Add the user marks object and emit. Here are some sample code uses:

```csharp
// Create a user mark
var myUserMark = new UserMark("MyMark");

// Emit the usermark
myUserMark.EmitMessage("Event happened!");

// Emit statically
UserMark.Emit("Emitting just a message");

// Emitting a range
using (var myRange = new UserMarksRange("MyMethodRange"))
{
    // Your code here
}
```

### Add user marks in C++ 

To use the native user marks API, add *UserMarks.h* to the project and add the following code:

```cpp
#define DIAGHUB_ENABLE_TRACE_SYSTEM
#include "UserMarks.h"
DIAGHUB_DECLARE_TRACE;

// Start the trace system
DIAGHUB_START_TRACE_SYSTEM();

// Initialize user marks
USERMARKS_INITIALIZE(L"User mark name");

// Initialize user mark range
USERMARKRANGE_INITIALIZE(L"Range name");

// Emit events
USERMARKS_EMIT(L"Message to emit with user mark");
USERMARKRANGE_START(L"Message to emit with range");
USERMARKRANGE_END();

// Stop the trace system
DIAGHUB_STOP_TRACE_SYSTEM();
```

User Marks in IDE
In Visual Studio, run a profiling session with any profiler tool enabled:

Open the Profiler > select a tool > then press the Start button
Run your code, ensuring that the user mark code you added in the step above executes
The user marks will show on the ruler above the swim lanes and in a table with details about the timestamps, related process, and any messages you emitted.
Select "Show user marks" to see details about the user marks.
You can hover over the marks in the ruler to see the exact user mark it corresponds to.
Filter the details view by selecting a time range in the swimlane, or right-clicking a row and selecting start and end times to filter the swimlane. You can also set intervals on ranges or by selecting multiple user marks.

## Related content

- [Analyze performance by using CPU profiling](../profiling/cpu-usage.md)
- [Identify hot paths with Flame Graph](../profiling/flame-graph.md)
- [Troubleshoot Profiler errors](../profiling/troubleshoot-profiler-errors.md)