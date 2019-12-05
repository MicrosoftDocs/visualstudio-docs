---
title: "Walkthrough: Using Profiler APIs | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling tools, walkthroughs"
  - "performance tools, walkthroughs"
ms.assetid: c2ae0b3e-a0ca-4967-b4df-e319008f520e
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Walkthrough: Using profiler APIs

The walkthrough uses a C# application to demonstrate how to use the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools APIs. You will use the profiler APIs to limit the amount of data that is collected during instrumentation profiling.

 The steps in this walkthrough generally apply to a C/C++ application. For each language, you will have to configure your build environment appropriately.

 Typically, you will start to analyze application performance by using sample profiling. If sample profiling does not provide information that pinpoints a bottleneck, instrumentation profiling can provide a greater level of detail. Instrumentation profiling is very useful for investigating thread interaction.

 However, a greater level of detail means that more data is collected. You might find that instrumentation profiling creates large data files. Also, instrumentation is more likely to impact the performance of the application. For more information, see [Understand instrumentation data values](../profiling/understanding-instrumentation-data-values.md) and [Understand sampling data values](../profiling/understanding-sampling-data-values.md)

 The Visual Studio profiler allows you to limit the collection of data. This walkthrough offers an example of how to limit the collection of data by using the profiler APIs. The Visual Studio profiler provides an API for controlling data collection from within an application.

 ::: moniker range="vs-2017"
 For native code, the Visual Studio profiler APIs are in *VSPerf.dll*. The header file, *VSPerf.h*, and the import library, *VSPerf.lib*, are located in the *Microsoft Visual Studio\2017\Team Tools\Performance Tools\PerfSDK* directory.  For 64-bit apps, the folder is *Microsoft Visual Studio\2017\Team Tools\Performance Tools\x64\PerfSDK*
 ::: moniker-end

 For managed code, the profiler APIs are in the *Microsoft.VisualStudio.Profiler.dll*. This DLL is found in the *Microsoft Visual Studio\Shared\Common\VSPerfCollectionTools* directory. For 64-bit apps, the folder is *Microsoft Visual Studio\Shared\Common\VSPerfCollectionTools\x64*. For more information, see [Profiler](/previous-versions/ms242704(v=vs.140)).

## Prerequisites
 This walkthrough assumes your choice of development environment is configured to support debugging and sampling. The following topics provide an overview of these prerequisites:

- [How to: Choose collection methods](../profiling/how-to-choose-collection-methods.md)

- [How to: Reference Windows symbol information](../profiling/how-to-reference-windows-symbol-information.md)

 By default, when the profiler is started, the profiler collects data at the global level. The following code at the start of the program turns global profiling off.

```csharp
DataCollection.StopProfile(
ProfileLevel.Global,
DataCollection.CurrentId);
```

 You can turn off data collection at the command line without using an API call. The following steps assume your command line build environment is configured to run the profiling tools and as your development tools. This includes the settings necessary for VSInstr and VSPerfCmd. See [Command-line profiling tools](../profiling/using-the-profiling-tools-from-the-command-line.md).

## Limit data collection using profiler APIs

#### To create the code to profile

1. Create a new C# project in Visual Studio, or use a command line build, depending on your preference.

    > [!NOTE]
    > Your build must reference the *Microsoft.VisualStudio.Profiler.dll* library, located in the *Microsoft Visual Studio\Shared\Common\VSPerfCollectionTools* directory.

2. Copy and paste the following code into your project:

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.Profiler;

    namespace ConsoleApplication1
    {
        class Program
        {
            public class A
            {
                private int _x;

                public A(int x)
                {
                    _x = x;
                }

                public int DoNotProfileThis()
                {
                    return _x * _x;
                }

                public int OnlyProfileThis()
                {
                    return _x + _x;
                }

                public static void Main()
                {
                    DataCollection.StopProfile(
                    ProfileLevel.Global,
                    DataCollection.CurrentId);

                    A a = new A(2);
                    Console.WriteLine("2 square is {0}", a.DoNotProfileThis());

                    DataCollection.StartProfile(
                    ProfileLevel.Global,
                    DataCollection.CurrentId);

                    int x;
                    x = a.OnlyProfileThis();

                    DataCollection.StopProfile(
                    ProfileLevel.Global,
                    DataCollection.CurrentId);

                    Console.WriteLine("2 doubled is {0}", x);
                }
            }

        }
    }
    ```

#### To collect and view data in the Visual Studio IDE

1. Open the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE. On to the **Analyze** menu, point to **Profiler**, and then select **New Performance Session**.

2. Add your compiled binary to the **Targets** list in the **Performance Explorer** window. Right-click **Targets**, and then select **Add Target Binary**. Locate the binary in the **Add Target Binary** dialog box, and then click **Open**.

3. Select **Instrumentation** from the **Method** list on the **Performance Explorer** toolbar.

4. Click **Launch with Profiling**.

    The profiler will instrument and execute the binary and create a performance report file. The performance report file will appear in the **Reports** node of the **Performance Explorer**.

5. Open the resulting performance report file.

   By default, when the profiler is started, the profiler will collect data at the global level. The following code at the start of the program turns global profiling off.

```csharp
DataCollection.StopProfile(
ProfileLevel.Global,
DataCollection.CurrentId);
```

#### To collect and view data at the command line

1. Compile a debug version of the sample code you created in the "Creating Code to Profile" procedure, earlier in this walkthrough.

2. To profile a managed application, type the following command to set the appropriate environment variables:

     **VsPerfCLREnv /traceon**

3. Type the following command: **VSInstr \<filename>.exe**

4. Type the following command: **VSPerfCmd /start:trace /output:\<filename>.vsp**

5. Type the following command: **VSPerfCmd /globaloff**

6. Execute your program.

7. Type the following command: **VSPerfCmd /shutdown**

8. Type the following command: **VSPerfReport /calltrace:\<filename>.vsp**

     A .*csv* file is created in the current directory with the resulting performance data.

## See also

- [Profiler](/previous-versions/ms242704(v=vs.140))
- [Visual Studio profiler API reference (native)](../profiling/visual-studio-profiler-api-reference-native.md)
- [Getting started](../profiling/getting-started-with-performance-tools.md)
- [Profile from the command-line](../profiling/using-the-profiling-tools-from-the-command-line.md)
