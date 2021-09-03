---
title: Viewing GPU Threads in the Debugger | Microsoft Docs
description: Use the GPU Threads window to examine and work with threads that are running on the GPU in the application that you are debugging in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.debug.gputthreads
  - vs.debug.gputhreads
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - debugger, GPU threads window
ms.assetid: c647c502-a9f0-48e0-a430-976744a5fa51
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How to: Use the GPU Threads Window (C++)
In the GPU Threads window, you can examine and work with threads that are running on the GPU in the application that you are debugging. For more information about applications that run on the GPU, see [C++ AMP Overview](/cpp/parallel/amp/cpp-amp-overview).

 The GPU Threads window contains a table in which each row represents a set of GPU threads that have the same values in all of the columns. You can sort, reorder, remove, and group items that are in the columns. You can flag, unflag, freeze (suspend), and thaw (resume) threads from the GPU Threads window. The following columns are displayed in the GPU Threads window:

- The flag column, in which you can mark a thread that you want to pay special attention to.

- The current thread column, in which a yellow arrow indicates the current thread.

- The **Thread Count** column, which displays the number of threads at the same location.

- The **Line** column, which displays the line of code where each group of threads is located.

- The **Address** column, which displays the instruction address where each group of threads is located. By default, this column is hidden.

- The **Location** column, which is the location in the source code.

- The **Status** column, which shows whether the thread is active, blocked, not started, or complete.

- The **Tile** column, which shows the tile index for the threads in the row.

  The header of the table shows the tile and thread being displayed.

  [!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

### To display the GPU Threads window

1. In **Solution Explorer**, open the shortcut menu for the project and then choose **Properties**.

2. In the **Property Pages** window for the project, under **Configuration Properties**, choose **Debugging**.

3. In the **Debugger to launch** list, select **Local Windows Debugger**. In the **Debugger Type** list, select **GPU Only**. You must choose this debugger to break at breakpoints in code that runs on the GPU.

4. Choose the **OK** button.

5. Set a breakpoint in the GPU code.

6. On the menu bar, choose **Debug**, **Start Debugging**. Wait for the application to reach the breakpoint.

7. One the menu bar, choose **Debug**, **Windows**, **GPU Threads**.

### To switch to a different thread

- Double-click the column. (Keyboard: Select the row and choose Enter.)

### To display a particular tile and thread

1. Choose the **Expand Thread Switcher** button in the GPU Threads window.

2. Enter the tile and thread values in the text boxes.

3. Choose the button that has the arrow on it.

### To display or hide a column

- Open the shortcut menu for the GPU Threads window, choose **Columns**, and then choose the column that you want to display or hide.

### To sort by a column

- Select the column heading.

### To group threads

- Open the shortcut menu for the GPU Threads window, choose **Group By**, and then choose one of the column names displayed. Choose **None** to ungroup the threads.

### To freeze or thaw a row of threads

- Open the shortcut menu for the row and choose **Freeze** or **Thaw**.

### To flag or unflag a row of threads

- Select the flag column for the thread, or open the shortcut menu for the thread and choose **Flag** or **Unflag**.

### To display only flagged threads

- Choose the flag button in the GPU Threads window.

## See also
- [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)
- [How to: Use the Parallel Watch Window](../debugger/how-to-use-the-parallel-watch-window.md)
- [Walkthrough: Debugging a C++ AMP Application](/cpp/parallel/amp/walkthrough-debugging-a-cpp-amp-application)