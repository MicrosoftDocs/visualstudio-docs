---
title: Flag and Unflag Threads
description: Learn to flag or unflag threads in Visual Studio. Flag or unflag a thread, several threads, or all threads. Flag just your code or ones associated with a module.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - treads, switching [debugging]
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Flag and Unflag Threads (C#, Visual Basic, C++)

You can flag a thread that you want to give special attention by marking it with an icon in the **Threads**, **Parallel Stacks** (thread view), **Parallel Watch**, and **GPU Threads** windows. This icon can help you and others distinguish flagged threads from other threads.

Flagged threads also receive special treatment in the **Thread** list on the **Debug Location** toolbar and in the other multithreaded debugging windows. You can show all threads or only flagged threads in the **Thread** list or in the other windows.

### To flag or unflag a thread

- In the **Threads** or **Parallel Watch** window, find the thread you are interested in and click the flag icon to select or clear the flag.
- In the **Parallel Stacks** window, right-click on a thread or group of threads and select **Flag / \<thread>** or **Unflag / \<thread>**.

### To unflag all threads

- In the **Threads** window, right-click any thread and then click **Unflag All Threads**.
- In the **Parallel Watch** window, select all flagged threads, then right-click and select **Unflag**.

### To display only flagged threads

- Choose the **Show Flagged Threads Only** button in one of the multithreaded debugging windows.

### To flag Just My Code

1. On the toolbar at the top of the **Threads** window, click the flag icon.

2. In the drop-down list, click **Flag Just My Code**.

### To flag threads that are associated with selected modules

1. On the toolbar of the **Threads** window, click the flag icon.

2. In the drop-down list, click **Flag Custom Module Selection**.

3. In the **Select Modules** dialog box, select the modules that you want.

4. (Optional) In the **Search** box, type a string to search for specific modules.

5. Click **OK**.

## Related content
- [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)
- [Get started debugging multithreaded applications](../debugger/get-started-debugging-multithreaded-apps.md)
- [Debug a dealock using the Threads view](../debugger/how-to-use-the-threads-window.md)