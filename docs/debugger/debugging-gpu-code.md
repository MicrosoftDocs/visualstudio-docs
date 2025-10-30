---
title: "Debugging GPU Code"
description: Learn about debugging C++ code that's running on the graphics processing unit (GPU) in Visual Studio.
ms.date: "02/22/2022"
ms.topic: how-to
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debugging GPU Code

You can debug C++ code that is running on the graphics processing unit (GPU). GPU debugging support in Visual Studio includes race detection, launching processes and attaching to them, and integration into the debugging windows.

## Supported Platforms
 Debugging is supported on Windows 7, Windows 8, Windows 10, Windows 11, Windows Server 2008 R2, Windows Server 2012 and Windows Server 2016. For debugging on the software emulator, Windows 8, Windows 10, Windows 11, or Windows Server 2012, Windows Server 2016 is required. For debugging on the hardware, you must install the drivers for your graphics card. Not all hardware vendors implement all debugger features. See the vendor documentation for limitations.

> [!NOTE]
> Independent hardware vendors who want to support GPU debugging in Visual Studio must create a DLL that implements the VSD3DDebug interface and targets their own drivers.

## Configuring GPU Debugging
 The debugger can't break on both CPU code and GPU code in the same app execution. By default, the debugger breaks on CPU code. To debug GPU code, use one of these two steps:

- In the **Debug Type** list on the **Standard** toolbar, choose **GPU Only**.

- In **Solution Explorer**, on the shortcut menu for the project, choose **Properties**. In the **Property Pages** dialog box, select **Debugging**, and then select **GPU Only** in the **Debugger Type** list.

## Launching and Attaching to Applications
 You can use the Visual Studio debugging commands to start and stop GPU debugging. For more information, see [Navigating through Code with the Debugger](../debugger/navigating-through-code-with-the-debugger.md). You can also attach the GPU debugger to a running process, but only if that process executes GPU code. For more information, see [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).

## Run Current Tile to Cursor and Run to Cursor
 When you're debugging on the GPU, you have two options for running to the cursor location. The commands for both options are available on the shortcut menu of the code editor.

1. The **Run to Cursor** command runs your app until it reaches the cursor location and then breaks. This doesn't imply that the current thread runs to the cursor; rather, it means that the first thread that reaches the cursor point triggers the break. See [Navigating through Code with the Debugger](../debugger/navigating-through-code-with-the-debugger.md)

2. The **Run Current Tile to Cursor** command runs your app until all of the threads in the current tile reach the cursor and then breaks.

## Debugging Windows
 By using certain debugging windows, you can examine, flag, and freeze GPU threads. For more information, see:

- [Using the Parallel Stacks Window](../debugger/using-the-parallel-stacks-window.md)

- [Using the Tasks Window](../debugger/using-the-tasks-window.md)

- [How to: Use the Parallel Watch Window](../debugger/how-to-use-the-parallel-watch-window.md)

- [Debug multithreaded applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)

- [How to: Use the GPU Threads Window](../debugger/how-to-use-the-gpu-threads-window.md)

## Data Synchronization Exceptions
 The debugger can identify several data synchronization conditions during execution. When a condition is detected, the debugger enters the break state. You have two options—**Break** or **Continue**. By using the **Exceptions** dialog box, you can configure whether the debugger detects these conditions and also which conditions it will break for. For more information, see [Managing Exceptions with the Debugger](../debugger/managing-exceptions-with-the-debugger.md). You can also use the **Options** dialog box to specify that the debugger should ignore exceptions if the data that's written doesn't change the value of the data. For more information, see [General, Debugging, Options Dialog Box](../debugger/general-debugging-options-dialog-box.md).

## Troubleshooting

### Specifying an accelerator
 Breakpoints in GPU code are only hit if the code is running on the [accelerator::direct3d_ref](/cpp/parallel/amp/reference/accelerator-class#direct3d_ref) (REF) accelerator. If you don't specify an accelerator in your code, the REF accelerator is automatically selected as the **Debugging Accelerator Type** in the project properties. If your code explicitly selects an accelerator, then the REF accelerator won't be used during debugging and the breakpoints won't be hit unless your GPU hardware has debugging support. You can remedy this by writing your code so that it uses the REF accelerator during debugging. For more information, see project properties and [Using accelerator and accelerator_view Objects](/cpp/parallel/amp/using-accelerator-and-accelerator-view-objects) and [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md).

### Conditional Breakpoints
 Conditional breakpoints in GPU code are supported, but not every expression can be evaluated on the device. When an expression can't be evaluated on the device, it's evaluated on the debugger. The debugger is likely to run more slowly than the device.

### Error: There is a configuration issue with the selected Debugging Accelerator Type.
 This error happens when there's an inconsistency between the project settings and the configuration of the PC that you're debugging on. For more information, see [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md).

### Error: The debug driver for the selected Debugging Accelerator Type is not installed on the target machine.
 This error happens if you're debugging on a remote PC. The debugger can't determine until run time whether the drivers are installed on the remote PC. The drivers are available from the manufacturer of the graphics card.

### Error: Timeout Detection and Recovery (TDR) must be disabled at the remote site.
 It's possible for C++ AMP computations to exceed the default time interval that's set by the Windows timeout detection and recovery process (TDR). When that happens, the computation is canceled and the data is lost. For more information, see [Handling TDRs in C++ AMP](/archive/blogs/nativeconcurrency/handling-tdrs-in-c-amp).

## Related content
- [Walkthrough: Debugging a C++ AMP Application](/cpp/parallel/amp/walkthrough-debugging-a-cpp-amp-application)
- [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)
- [Start GPU Debugging in Visual Studio](/archive/blogs/nativeconcurrency/start-gpu-debugging-in-visual-studio-2012)
