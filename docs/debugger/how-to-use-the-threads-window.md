---
title: "Debug a multithreaded app"
description: Debug using the Threads window and the Debug Location toolbar in Visual Studio
ms.custom: ""
ms.date: "11/21/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "multithreaded debugging, tutorial"
  - "tutorials, multithreaded debugging"
ms.assetid: adfbe002-3d7b-42a9-b42a-5ac0903dfc25
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# Walkthrough: Debug a multithreaded app 

Several Visual Studio user interface elements help you debug multithreaded apps. This tutorial introduces the **Debug** and **Debug Location** toolbars and the **Threads** window. For information about other tools, see  [Get started debugging multithreaded apps](../debugger/get-started-debugging-multithreaded-apps.md). 
  
Completing this tutorial takes only a few minutes, and familiarizes you with the features for debugging multithreaded apps.

## Create a multithreaded app project  

To use this tutorial, you need a multithreaded app project. 
  
To create a C# multithreaded app project:**

1. In Visual Studio, select **File** > **New** > **Project**.  
   
1. In the **New Project** dialog box, select ****Visual C#**  > **Console App (.NET Framework)**.  
   
1. Name the app MyThreadWalkthroughApp, and then select **OK**.  
   
   The new project appears in **Solution Explorer**, and a source file called *Program.cs* opens in the source code window.  
   
1. Replace the code in the source file with the example code from [Create threads and pass data at start time](/dotnet/standard/threading/creating-threads-and-passing-data-at-start-time).  
   
1. Select **File** > **Save All**.  
  
## Start debugging 

1. Find the following lines in the source code:  
   
   ```csharp  
   Thread.Sleep(3000);  
   Console.WriteLine();  
   ```  
   
   Set a breakpoint on the `Console.WriteLine` statement by clicking in the left gutter next to the line, or selecting the line and pressing **F9**.  
   
   The breakpoint appears as a red circle in the left gutter next to the code line.  
   
1. Select **Debug** > **Start Debugging**, or press **F5**.  
   
   The app starts in debug mode, and pauses at the breakpoint.  
   
1. While in break mode, open the **Threads** window by selecting **Debug > **Windows** > **Threads**. You must be in a debugging session to open or see the **Threads** and other debugging windows. 
   
## Examine thread markers

1. Open the **Debug** toolbar by selecting **View** > **Toolbars** > **Debug**. You can also right-click in the toolbar area and select **Debug**. 
   
1. In the source code editor, locate the following line:  
   
   ```csharp  
   Thread.Sleep(3000);  
   ```  
   
1. On the **Debug** toolbar, select the **Show Threads in Source** button ![Show Threads in Source](../debugger/media/dbg-multithreaded-show-threads.png "ThreadMarker"). 
   
   The source code line now shows a *thread marker* icon  ![Thread Marker](../debugger/media/dbg-thread-marker.png "ThreadMarker") that indicates a thread is stopped at this location.  
   
1. Hover the pointer over the thread marker. A DataTip appears, showing the name and thread ID number for the stopped thread. The thread name is probably `<No Name>`.  

   >[!TIP]
   >To help identify nameless threads, you can rename them in the **Threads** window. Right-click the thread and select **Rename**.
  
1. Right-click the thread marker in the source code to see the available options on the shortcut menu. 

## Flag and unflag threads 

Flag threads to keep track of threads you want to pay special attention to. 

You can flag and unflag threads from the source code editor or from the **Threads** window. You can choose whether to display only flagged threads, or all threads, from the **Debug Location** or **Threads** window toolbars. Selections made from any location affect all locations. 

### To flag and unflag threads in source code 

1. Open the **Debug Location** toolbar by selecting **View** > **Toolbars** > **Debug Location**. You can also right-click in the toolbar area and select **Debug Location**. 
   
1. The **Debug Location** toolbar has three fields: **Process**, **Thread**, and **Stack Frame**. Drop down the **Threads** list, and note how many threads there are. In the **Threads** list, the currently executing thread is marked by a **>** symbol. 
   
1. In the source code, right-click the thread marker ![Thread Marker](../debugger/media/dbg-thread-marker.png "Thread Marker") icon, point to **Flag**, and then select one of the threads.  
   
1. On the **Debugging Location** toolbar, select the **Show Only Flagged Threads** icon ![Show Flagged Threads](../debugger/media/dbg-threads-show-flagged.png "Show Flagged Threads"), to the right of the **Thread** field. The icon is grayed out unless one or more threads are flagged.  
   
   Only the flagged thread now appears in the **Threads** dropdown in the toolbar. To toggle between showing flagged threads and all threads, select the single flag **Toggle Current Thread Flagged State** toolbar button. 
   
   >[!TIP]
   >After you have flagged some threads, you can place your cursor in the code editor, right-click, and select **Run Flagged Threads to Cursor**. Make sure to choose code that all flagged threads will reach. This will pause threads on the selected line of code, making it easier to control the order of execution by [freezing and thawing threads](#bkmk_freeze).
   
1. To unflag a thread, right-click the thread marker in the source code, and select **Unflag**.  

### To flag and unflag threads in the Threads window 

In the **Threads** window, flagged threads have red flag icons next to them, while unflagged threads, if shown, have empty icons.

![Threads Window](../debugger/media/dbg-threads-window.png "ThreadsWindow")  
  
Select any flag icon to change the thread state to flagged or unflagged, depending on its current state. 

You can also right-click the line and select **Flag**, **Unflag**, or **Unflag All Threads** from the shortcut menu. 

The **Threads** window toolbar also has a **Show Flagged Threads Only** button. It works the same as the button on the **Debug Location** toolbar, and either button controls both locations. 

### Other Threads window features

In the **Threads** window, select the header of any column to sort the threads by that column. Select again to reverse the sort order. Selecting the flag icon column sorts the threads by flagged or unflagged status. 

The second column of the **Threads** window (with no header) is the **Current Thread** column. A yellow arrow in this column marks the current execution point. 

Select the expand arrow next to the **Location** entry for any thread in the list, or hover over the entry, to show a partial call stack for the thread. 

>[!TIP]
>For a graphical view of the call stacks for threads, open the [Parallel Stacks](../debugger/using-the-parallel-stacks-window.md) window. While debugging, select **Debug**> **Windows** > **Parallel Stacks**.  
  
In addition to **Flag**, **Unflag**, and **Unflag All Threads**, the right-click context menu for **Thread** window items has:

- A **Show Threads in Source** button like the one on the **Debug** toolbar.
- **Hexadecimal display**, which changes the **Thread ID**s in the **Threads** window from decimal to hexadecimal format. 
- [Freeze and Thaw](#bkmk_freeze) commands.
- [Switch To Thread](#switch-to-another-thread), which immediately switches execution to that thread. 

## <a name="bkmk_freeze"></a> Freeze and thaw thread execution 

You can freeze and thaw, or suspend and resume, threads to control the order in which the threads perform work. Freezing and thawing threads can help you resolve concurrency issues, such as deadlocks and race conditions.

> [!TIP]
> To follow a single thread without freezing other threads (also a common debugging scenario), see [Get started debugging multithreaded applications](../debugger/get-started-debugging-multithreaded-apps.md#bkmk_follow_a_thread).
  
**To freeze and unfreeze threads:**  
  
1. In the **Threads** window, right-click any thread and then select **Freeze**. A **Pause** icon in the **Current Thread** column indicates that the thread is frozen.  
   
1. Under **Columns** in the **Threads** window toolbar, select **Suspended Count**. 
   
   The **Suspended Count** column appears in the window, and the value for the frozen thread is **1**.  
   
1.  Right-click the frozen thread and select **Thaw**.  
  
    The **Pause** icon disappears, and the **Suspended Count** column changes to **0**. 
  
## Switch to another thread 

You may see a **The application is in break mode** window when you try to switch to another thread. This window tells you that the debugger is not currently executing any code that it can display, and offers troubleshooting options. 
  
**To switch to another thread:**

1. In the **Threads** window, make a note of the thread ID number for the current thread, which is the thread with a yellow arrow in the **Current Thread** column. You will need to switch back to this thread to continue your app. 
   
1. Right-click another thread and select **Switch To Thread**.  
   
1. Observe that the yellow arrow location has changed in the **Threads** window. Look at the tooltip on the thread marker in the code source editor, and the list in the **Threads** dropdown on the **Debug Location** toolbar. Observe that the current thread has also changed there. 

1. On the **Debug Location** toolbar, select a different thread from the **Thread** list. Note that the current thread changes in the other two locations also. 
   
1. In the source code editor, right-click a thread marker, point to **Switch To Thread**, and select another thread from the list. Observe that the current thread changes in all three locations.  

With the thread marker, you can switch only to threads that are stopped at that particular location. By using the **Threads** window and **Debug Location** toolbar, you can switch to any thread.   
  
## See also  
 [Debug multithreaded applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)   
 [How to: Switch to another thread while debugging](../debugger/how-to-switch-to-another-thread-while-debugging.md)
