---
title: "Instrument your .NET application"
description: Learn about instrumenting your .NET applications.
ms.date: "11/11/2022"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: '>= vs-2022'
ms.workload:
  - "multiple"
---

# Instrument your .NET applications in Visual Studio (C#, Visual Basic, F#)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

With the release of Visual Studio 2022 version 17.4, you can use the new dynamic instrumentation tool. This tool shows the exact number of times your functions are called and is faster than the previous version of the tool. This tool supports .NET Core instrumentation without needing PDBs.

You can access the instrumentation tool by launching the Performance Profiler for a .NET Project in Visual Studio (**Debug > Performance Profiler** or **Alt + F2**). Once you are on the summary page, select the **.NET Instrumentation** checkbox.

## Instrument your application

1. Select **Alt+F2** to open the performance profiler in Visual Studio.

1. Select the **.NET Instrumentation** check box.

   ![Screenshot showing .NET Instrumentation tool selected.](./media/vs-2022/instrumentation-tool-launch.png ".NET Instrumentation tool selected")

   > [!NOTE]
   > If the tool isn't available for selection, clear every other tool's check box because some tools need to run alone. To learn more about running tools together, see [Screenshot showing how to use profiling tools from the command line.](../profiling/using-the-profiling-tools-from-the-command-line.md).
   >
   > If the tool still isn't available, check that your project meets the preceding requirements. Make sure your project is in Release mode to capture the most accurate data.

1. Select the **Start** button to run the tool.

1. Select the items in your program to instrument.

   ![Screenshot showing Select items to instrument dialog.](./media/vs-2022/instrumentation-select-items-to-instrument.png "Screenshot showing Select items to instrument dialog.")

1. Select **OK**.

1. After the tool starts running, go through the scenario you want to profile in your app. Then select **Stop collection** or close the app to see your data.

## Analyze the Instrumentation report

Your profiling data appears in Visual Studio.

![Screenshot showing .NET Instrumentation data.](./media/vs-2022/instrumentation-data.png "Instrumentation data")

## See Also

[First look at profiling tools](../profiling/profiling-feature-tour.md)
