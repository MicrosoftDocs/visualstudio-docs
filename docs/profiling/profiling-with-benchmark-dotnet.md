---
title: "Analyze BenchmarkDotNet data in Visual Studio"
description: Learn how to profile console apps using BenchmarkDotNet.
ms.date: 11/24/2025
ms.topic: how-to
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "BenchmarkDotNet"
  - "profiling, BenchmarkDotNet"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
monikerRange: '>= vs-2022'
---

# Analyze BenchmarkDotNet data in Visual Studio

You can use the profiling tools to collect and view [BenchmarkDotNet](https://benchmarkdotnet.org/articles/overview.html) data in Visual Studio. BenchmarkDotNet is an open-source .NET library designed for performance benchmarking. It automates the process of measuring and comparing the execution time, memory usage, and other performance metrics of your .NET code in a reliable and repeatable way.

You use BenchmarkDotNet by installing required NuGet packages in your project and then adding attributes to your code that match the type of performance information you are interested in.

## Prerequisites

- Visual Studio 2022 version 17.9 or later

- Your benchmark project must include the following two NuGet packages:

  - [BenchmarkDotNET](https://www.nuget.org/packages/BenchmarkDotNet/)
  - [Microsoft.VisualStudio.DiagnosticsHub.BenchmarkDotNetDiagnosers](https://www.nuget.org/packages/Microsoft.VisualStudio.DiagnosticsHub.BenchmarkDotNetDiagnosers)

  ::: moniker range=">=visualstudio"
  If you use the Benchmark project template, these NuGet packages are present when you create the project.
  ::: moniker-end

## Set upyour project

::: moniker range=">=visualstudio"
The benchmark attributes must be added to a .NET console application. The attributes can be added to wrapper functions that reference other project types.

To prepare your project for BenchmarkDotNet support, use one of the following methods:

- Open an existing console project or create a new console project. In this scenario, you will manually add add BenchmarkDotNet support.
- Use the **Benchmark Project** template. Some of the steps described in this article are required only when you manually add BenchmarkDotNet support.

  The **Benchmark Project** template generates a fully integrated BenchmarkDotNet project with built-in support for CPU Usage profiling and Copilot insights. To use the template, select **Profiling** from the project types list when you create a new project, and then choose **Benchmark Project**. For information about attributes, see [Attribute your code](#attribute-your-code).

![Screenshot of BenchmarkDotNet template in Visual Studio.](../profiling/media/visualstudio/benchmark-dotnet-template.png) 
::: moniker-end
::: moniker range="vs-2022"
Create a console project or use an existing console project.

The benchmark attributes must be added to a .NET console application. The attributes can be added to wrapper functions that reference other project types.
::: moniker-end

## Attribute your code

When you add a BenchmarkDotNet diagnoser to your benchmark classes as an attribute, you configure the app to generate a *.diagsession* file after the benchmarks run. You can then open the *.diagsession* file in Visual Studio and view profiling data for the benchmarks. 

The following diagnosers are supported:

- CPUUsageDiagnoser
- DatabaseDiagnoser
- DotNetCountersDiagnoser
- EventsDiagnoser
- FileIODiagnoser

Each diagnoser generates performance data related to that diagnoser. For example, the CPUUsageDiagnoser generates a *.diagsession* file with CPU data in it, and the DatabaseDiagnoser generates a *.diagsession* file with data on database operations. Limitations correspond to the associated profiling tool. For example, the profiler's Database tool works on [ADO.NET](/dotnet/framework/data/adonet/ado-net-overview) or [Entity Framework Core](/ef/core/).

1. Attribute your code for diagnosers and benchmarks.

   Add the diagnoser name as an attribute to the class that contains the benchmarks for which you want to generate data.

   For example, you can use the following code for the CPUUsageDiagnoser.

   ::: moniker range=">=visualstudio"
   If you're using the **Benchmark Project** template, sample code is already provided in the template. If you're manually adding BenchmarkDotNet support, you can use the following example code.
   ::: moniker-end

    ```csharp
    using System;
    using System.Security.Cryptography;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Running;
    using Microsoft.VSDiagnostics;
    
    namespace MyBenchmarks
    {
        [CPUUsageDiagnoser]
        public class Md5VsSha256
        {
            private const int N = 10000;
            private readonly byte[] data;
    
            private readonly SHA256 sha256 = SHA256.Create();
            private readonly MD5 md5 = MD5.Create();
    
            public Md5VsSha256()
            {
                data = new byte[N];
                new Random(42).NextBytes(data);
            }
    
            [Benchmark]
            public byte[] Sha256() => sha256.ComputeHash(data);
    
            [Benchmark]
            public byte[] Md5() => md5.ComputeHash(data);
        }
        // Placeholder for the benchmark runner.
    }
    ```

1. Replace the placeholder code in the previous sample with the following code to run the benchmarks (`BenchmarkRunner.Run`).

    ```csharp
        public class Program
        {
            public static void Main(string[] args)
            {
                var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
            }
        }
    ```

## Collect and view Benchmark.NET data

1. Set your build to a **Release** build instead of a Debug build.

1. Run the application to generate the *.diagsession* file.

   Check the console output to get the location of the file. For example:  

   ```cmd
   // * Diagnostic Output - VSDiagnosticsDiagnoser * 
   Collection result moved to 'BenchmarkDotNet_Md5VsSha256_20231218_123326.diagsession'.
   Session : {7f38bcc2-c692-4266-aa24-b12bc5325ea4}
     Stopped
   Exported diagsession file: *.diagsession
   ```

1. In Visual Studio, select **File > Open > File** and navigate to the location of the *.diagsession* file, and then select and open the file.

1. Select the **Benchmarks** tab to view data for the BenchmarkDotNet benchmarks.

   ![Screenshot of BenchmarkDotNet data in Visual Studio.](../profiling/media/vs-2022/benchmark-dotnet-diagsession.png)

   For more information about the results in the **Benchmarks** tab, see [BenchmarkDotNet](https://benchmarkdotnet.org/articles/overview.html) documentation.

1. Right-click a row in the results and choose **Select time range** to sync the timeline graph with the benchmark.

1. Select one of the available tabs such as **CPU Usage** or **Allocations**.

   Depending on the diagnoser you used to collect data, you can gain insights related to memory allocation, CPU usage, counters, and other performance data. To analyze memory allocations, use the built-in [MemoryDiagnoser](https://benchmarkdotnet.org/articles/overview.html#diagnostics) by adding the \[MemoryDiagnoser\] attribute. For more information, see [Diagnosers](https://benchmarkdotnet.org/articles/configs/diagnosers.html).

   > [!NOTE]
   > The profiler supports only the \[MemoryDiagnoser\] and the diagnosers listed previously in this article.

   For an example of using the profiler to analyze memory allocations, see the blog post [Benchmarking with Visual Studio Profiler](https://devblogs.microsoft.com/visualstudio/benchmarking-with-visual-studio-profiler/).

   To analyze data related to other tabs such as **CPU Usage**, see the corresponding articles in the profiling documentation.

::: moniker range=">=visualstudio"
## Optimize with Copilot

You can trigger CPU and memory allocation optimizations for your BenchmarkDotNet benchmarks directly from the editor using CodeLens. This makes performance tuning more accessible and seamless, helping you find and fix CPU and memory allocation issues right where you code.

Select the CodeLens indicator above your benchmark and then select the option **Optimize Allocations with Copilot**.

![Screenshot of optimizing with Copilot.](../profiling/media/visualstudio/benchmark-dotnet-codelens-optimize-memory-allocations.png)

::: moniker-end

## Related content

- [First look at profiling](../profiling/choose-performance-tool.md)
- [Which tool should I use?](../profiling/choose-performance-tool.md)
