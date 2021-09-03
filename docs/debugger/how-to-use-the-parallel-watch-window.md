---
title: Set a Watch on Variables in Parallel Threads | Microsoft Docs
description: Set a watch on variables in parallel threads in Visual Studio. Simultaneously display the values that one expression holds on multiple threads.
ms.custom: SEO-VS-2020
ms.date: 04/25/2017
ms.topic: how-to
f1_keywords: 
  - vs.debug.parallelwatch
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - debugger, parallel watch window
ms.assetid: 28004d9b-420c-48f7-b80e-ab1519802558
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# Set a Watch on Variables in Parallel Threads in Visual Studio (C#, Visual Basic, C++)
In the Parallel Watch window, you can simultaneously display the values that one expression holds on multiple threads. Each row represents a thread that is running in an application, but a thread might be represented in multiple rows. More specifically, each row represents a function call whose function signature matches the function on the current stack frame. You can sort, reorder, remove, and group the items that are in the columns. You can flag, unflag, freeze (suspend), and thaw (resume) threads. The following columns are displayed in the **Parallel Watch** window:

- The flag column, in which you can mark a thread that you want to pay special attention to.

- The current thread column, in which a yellow arrow indicates the current thread (a green arrow with a curly tail indicates that a non-current thread has the current debugger context).

- A configurable column that can display the machine, process, tile, task, and thread.

  > [!TIP]
  > To display task information in the **Parallel Watch** window, you must first open the **Task** window.

- The blank *add watch* columns, in which you can enter expressions to watch.

  [!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

### To display the Parallel Watch window

1. Set a breakpoint in the code.

2. On the menu bar, choose **Debug**, **Start Debugging**. Wait for the application to reach the breakpoint.

3. On the menu bar, choose **Debug**, **Windows**, **Parallel Watch**, and then choose a watch window. You can open as many as four windows.

### To add a watch expression

- Select one of the blank *add watch* columns and then enter a watch expression.

### To flag or unflag a thread

- Select the flag column for the row (first column), or open the shortcut menu for the thread and choose **Flag** or **Unflag**.

### To display only flagged threads

- Choose the **Show Only Flagged** button in the upper-left corner of the **Parallel Watch** window.

### To switch to another thread

- Double-click the current thread column (second column). (Keyboard: Select the row and press Enter.)

### To sort a column

- Select the column heading.

### To group threads

- Open the shortcut menu for the Parallel Watch window, choose **Group By**, and then choose the appropriate submenu item.

### To freeze or thaw threads

- Open the shortcut menu for the row and choose **Freeze** or **Thaw**.

### To export the data in the Parallel Watch window

- Choose the **Open in Excel** button and then choose **Open in Excel** or **Export to CSV**.

### To filter by a Boolean expression

- Enter a Boolean expression in the **Filter by Boolean Expression** box. The debugger evaluates the expression for each thread context. Only rows where the value is `true` are displayed.

## See also
- [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)
- [How to: Use the GPU Threads Window](../debugger/how-to-use-the-gpu-threads-window.md)
- [Walkthrough: Debugging a C++ AMP Application](/cpp/parallel/amp/walkthrough-debugging-a-cpp-amp-application)