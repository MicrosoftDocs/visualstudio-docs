---
title: "Debug a parallel application | Microsoft Docs"
description: Debug using the Parallel Tasks and Parallel Stacks windows in Visual Studio
ms.date: "03/22/2018"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugger, parallel tasks walkthrough"
  - "parallel stacks toolwindow"
  - "parallel tasks toolwindow"
  - "parallel applications, debugging [C++]"
  - "debugging, parallel applications"
  - "parallel applications, debugging [Visual Basic]"
  - "parallel applications, debugging [C#]"
ms.assetid: 2820ac4c-c893-4d87-8c62-83981d561493
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Walkthrough: Debugging a Parallel Application in Visual Studio (C#, Visual Basic, C++)

This walkthrough shows how to use the **Parallel Tasks** and **Parallel Stacks** windows to debug a parallel application. These windows help you understand and verify the run-time behavior of code that uses the [Task Parallel Library (TPL)](/dotnet/standard/parallel-programming/task-parallel-library-tpl) or the [Concurrency Runtime](/cpp/parallel/concrt/concurrency-runtime). This walkthrough provides sample code that has built-in breakpoints. After the code breaks, the walkthrough shows how to use the **Parallel Tasks** and **Parallel Stacks** windows to examine it.

 This walkthrough teaches these tasks:

- How to view the call stacks of all threads in one view.

- How to view the list of `System.Threading.Tasks.Task` instances that are created in your application.

- How to view the real call stacks of tasks instead of threads.

- How to navigate to code from the **Parallel Tasks** and **Parallel Stacks** windows.

- How the windows cope with scale through grouping, zooming, and other related features.

## Prerequisites
 This walkthrough assumes that **Just My Code** is enabled (it is enabled by default in more recent versions of Visual Studio). On the **Tools** menu, click **Options**, expand the **Debugging** node, select **General**, and then select **Enable Just My Code (Managed only)**. If you do not set this feature, you can still use this walkthrough, but your results may differ from the illustrations.

## C# Sample
 If you use the C# sample, this walkthrough also assumes that External Code is hidden. To toggle whether external code is displayed, right-click the **Name** table header of the **Call Stack** window, and then select or clear **Show External Code**. If you do not set this feature, you can still use this walkthrough, but your results may differ from the illustrations.

## C++ Sample
 If you use the C++ sample, you can ignore references to External Code in this topic. External Code only applies to the C# sample.

## Illustrations
 The illustrations in this topic recorded on a quad core computer running the C# sample. Although you can use other configurations to complete this walkthrough, the illustrations may differ from what is displayed on your computer.

## Creating the Sample Project
 The sample code in this walkthrough is for an application that does nothing. The goal is just to understand how to use the tool windows to debug a parallel application.

#### To create the sample project

1. Open Visual Studio and create a new project.

    ::: moniker range=">=vs-2019"
    Press **Esc** to close the start window. Type **Ctrl + Q** to open the search box, type **console** (or **c++**), choose **Templates**, and then:

    - For C# or Visual Basic, choose **Create new Console App (.NET Framework) project** for either C# or Visual Basic. In the dialog box that appears, choose **Create**.
    - For C++, choose **Create new Console App project** for C++. In the dialog box that appears, choose **Create**.

    Then, type a name or use the default name and click **Create**.
    ::: moniker-end
    ::: moniker range="vs-2017"
    From the top menu bar, choose **File** > **New** > **Project**. In the left pane of the **New project** dialog box, choose the following:

    - For a C# app, under **Visual C#**, choose **Windows Desktop**, and then in the middle pane choose **Console App (.NET Framework)**.
    - For a Visual Basic app, under **Visual Basic**, choose **Windows Desktop**, and then in the middle pane choose **Console App (.NET Framework)**.
    - For a C++ app, under **Visual C++**, choose **Windows Desktop**,, and then choose **Windows Console Application**.

    Then, type a name or use the default name and click **OK**.
    ::: moniker-end

    If you don't see the **Console App** project template, go to **Tools** > **Get Tools and Features...**, which opens the Visual Studio Installer. Choose the **.NET desktop development** or **Desktop development with C++** workload, then choose **Modify**.

1. Open the .cpp, .cs, or .vb code file in the project. Delete its contents to create an empty code file.

1. Paste the following code for your chosen language into the empty code file.

   [!code-csharp[Debugger#1](../debugger/codesnippet/CSharp/walkthrough-debugging-a-parallel-application_1.cs)]
   [!code-cpp[Debugger#1](../debugger/codesnippet/CPP/walkthrough-debugging-a-parallel-application_1.cpp)]
   [!code-vb[Debugger#1](../debugger/codesnippet/VisualBasic/walkthrough-debugging-a-parallel-application_1.vb)]

1. On the **File** menu, click **Save All**.

1. On the **Build** menu, click **Rebuild Solution**.

    Notice that there are four calls to `Debugger.Break` (`DebugBreak` in the C++ sample) Therefore, you do not have to insert breakpoints; just running the application will cause it to break in the debugger up to four times.

## Using the Parallel Stacks Window: Threads View
 On the **Debug** menu, click **Start Debugging**. Wait for the first breakpoint to be hit.

#### To view the call stack of a single thread

1. On the **Debug** menu, point to **Windows** and then click **Threads**. Dock the **Threads** window at the bottom of Visual Studio.

2. On the **Debug** menu, point to **Windows** and then click **Call Stack**. Dock the **Call Stack** window at the bottom Visual Studio.

3. Double-click a thread in the **Threads** window to make it current. Current threads have a yellow arrow. When you change the current thread, its call stack is displayed in the **Call Stack** window.

#### To examine the Parallel Stacks window

1. On the **Debug** menu, point to **Windows** and then click **Parallel Stacks**. Make sure that **Threads** is selected in the box at the upper-left corner.

     By using the **Parallel Stacks** window, you can view multiple call stacks at the same time in one view. The following illustration shows the **Parallel Stacks** window above the **Call Stack** window.

     ![Threads view in Parallel Stacks window](../debugger/media/pdb_walkthrough_1.png "PDB_Walkthrough_1")

     The call stack of the Main thread appears in one box and the call stacks for the other four threads are grouped in another box. Four threads are grouped together because their stack frames share the same method contexts; that is, they are in the same methods: `A`, `B`, and `C`. To view the thread IDs and names of the threads that share the same box, hover over the box with the header (**4 Threads**). The current thread is displayed in bold.

     ![Tooltip that shows thread IDs and names](../debugger/media/pdb_walkthrough_1a.png "PDB_Walkthrough_1A")

     The yellow arrow indicates the active stack frame of the current thread.

     You can set how much detail to show for the stack frames (**Module Names**, **Parameter Types**, **Parameter Names**, **Parameter Values**, **Line Numbers** and **Byte Offsets**) by right-clicking in the **Call Stack** window.

     A blue highlight around a box indicates that the current thread is part of that box. The current thread is also indicated by the bold stack frame in the tooltip. If you double-click the Main thread in the Threads window, you can observe that the blue highlight in the **Parallel Stacks** window moves accordingly.

     ![Highlighted main thread in Parallel Stacks window](../debugger/media/pdb_walkthrough_1c.png "PDB_Walkthrough_1C")

#### To resume execution until the second breakpoint

1. To resume execution until the second breakpoint is hit, on the **Debug** menu, click **Continue**. The following illustration shows the thread tree at the second breakpoint.

     ![Parallel Stacks window that shows many branches](../debugger/media/pdb_walkthrough_2.png "PDB_Walkthrough_2")

     At the first breakpoint, four threads all went from S.A to S.B to S.C methods. That information is still visible in the **Parallel Stacks** window, but the four threads have progressed further. One of them continued to S.D and then S.E. Another continued to S.F, S.G, and S.H. Two others continued to S.I and S.J, and from there one of them went to S.K and the other continued to non-user External Code.

     You can hover over the box header, for example, **1 Thread** or **2 Threads**, to see the thread IDs of the threads. You can hover over stack frames to see thread IDs plus other frame details. The blue highlight indicates the current thread and the yellow arrow indicates the active stack frame of the current thread.

     The cloth-threads icon (interweaved lines) indicate the active stack frames of the noncurrent threads. In the **Call Stack** window, double-click S.B to switch frames. The **Parallel Stacks** window indicates the current stack frame of the current thread by using a green curved arrow icon.

     In the **Threads** window, switch between threads and observe that the view in the **Parallel Stacks** window is updated.

     You can switch to another thread, or to another frame of another thread, by using the shortcut menu in the **Parallel Stacks** window. For example, right-click S.J, point to **Switch To Frame**, and then click a command.

     ![Parallel Stacks Path of Execution](../debugger/media/pdb_walkthrough_2b.png "PDB_Walkthrough_2B")

     Right-click S.C and point to **Switch To Frame**. One of the commands has a check mark that indicates the stack frame of the current thread. You can switch to that frame of the same thread (just the green arrow will move) or you can switch to the other thread (the blue highlight will also move). The following illustration shows the submenu.

     ![Stacks menu with 2 options on C while J is current](../debugger/media/pdb_walkthrough_3.png "PDB_Walkthrough_3")

     When a method context is associated with just one stack frame, the box header displays **1 Thread** and you can switch to it by double-clicking. If you double-click a method context that has more than 1 frame associated with it, then the menu automatically pops up. As you hover over the method contexts, notice the black triangle at the right. Clicking that triangle also displays the shortcut menu.

     For large applications that have many threads, you may want to focus on just a subset of threads. The **Parallel Stacks** window can display call stacks only for flagged threads. To flag threads, use the shortcut menu or the first cell of a thread.

     On the toolbar, click the **Show Only Flagged** button next to the list box.

     ![Parallel Stacks window and tooltip](../debugger/media/pdb_walkthrough_3a.png "PDB_Walkthrough_3A")

     Now, only the flagged thread shows up in the **Parallel Stacks** window.

#### To resume execution until the third breakpoint

1. To resume execution until the third breakpoint is hit, on the **Debug** menu, click **Continue**.

     When multiple threads are in the same method but the method was not at the beginning of the call stack, the method appears in different boxes. An example at the current breakpoint is S.L, which has three threads in it and appears in three boxes. Double-click S.L.

     ![Execution path in Parallel Stacks window](../debugger/media/pdb_walkthrough_3b.png "PDB_Walkthrough_3B")

     Notice that S.L is bold in the other two boxes so that you can see where else it appears. If you want to see which frames call into S.L and which frames it calls, click the **Toggle Method View** button on the toolbar. The following illustration shows the method view of The **Parallel Stacks** window.

     ![Method view in Parallel Stacks window](../debugger/media/pdb_walkthrough_4.png "PDW_Walkthrough_4")

     Notice how the diagram pivoted on the selected method and positioned it in its own box in the middle of the view. The callees and callers appear on the top and bottom. Click the **Toggle Method View** button again to leave this mode.

     The shortcut menu of the **Parallel Stacks** window also has the following other items.

    - **Hexadecimal Display** toggles the numbers in the tooltips between decimal and hexadecimal.

    - **Symbol Settings** open the respective dialog boxes.

    - **Show Threads in Source** toggles the display of thread markers in your source code, which shows the location of threads in your source code.

    - **Show External Code** displays all the frames even if they are not in user code. Try it to see the diagram expand to accommodate the additional frames (which may be dimmed because you do not have symbols for them).

2. In the **Parallel Stacks** window, make sure that the **Auto Scroll to Current Stack Frame** button on the toolbar is on.

     When you have large diagrams and you step to the next breakpoint, you may want the view to auto scroll to the active stack frame of the current thread; that is, the thread that hit the breakpoint first.

3. Before you continue, in the **Parallel Stacks** window, scroll all the way to the left and all the way down.

#### To resume execution until the fourth breakpoint

1. To resume execution until the fourth breakpoint is hit, on the **Debug** menu, click **Continue**.

     Notice how the view autoscrolled into place. Switch threads in the **Threads** window or switch stack frames in the **Call Stack** window and notice how the view always autoscrolls to the correct frame. Turn off **Auto Scroll to Current Tool Frame** option and view the difference.

     The **Bird's Eye View** also helps with large diagrams in the **Parallel Stacks** window. By default, the **Bird's Eye View** is on. But you can toggle it by clicking the button between the scroll bars on the lower-right corner of the window, as shown in the following illustration.

     ![Bird's&#45;eye view in Parallel Stacks window](../debugger/media/pdb_walkthrough_5.png "PDB_Walkthrough_5")

     In bird's eye view, you can move the rectangle to quickly pan around the diagram.

     Another way to move the diagram in any direction is to click a blank area of the diagram and drag it where you want it.

     To zoom in and out of the diagram, press and hold CTRL while you move the mouse wheel. Alternatively, click the Zoom button on the toolbar and then use the Zoom tool.

     You can also view the stacks in a top-down direction instead of bottom-up, by clicking the **Tools** menu, clicking **Options**, and then select or clear the option under the **Debugging** node.

2. Before you continue, on the **Debug** menu, click **Stop Debugging** to end execution.

## Using the Parallel Tasks Window and the Tasks View of the Parallel Stacks window
 We recommended that you complete the earlier procedures before you continue.

#### To restart the application until the first breakpoint is hit

1. On the **Debug** menu, click **Start Debugging** and wait for the first breakpoint to be hit.

2. On the **Debug** menu, point to **Windows** and then click **Threads**. Dock the **Threads** window at the bottom of Visual Studio.

3. On the **Debug** menu, point to **Windows** and click **Call Stack**. Dock the **Call Stack** window at the bottom Visual Studio.

4. Double-click a thread in the **Threads** window to makes it current. Current threads have the yellow arrow. When you change the current thread, the other windows are updated. Next, we will examine tasks.

5. On the **Debug** menu, point to **Windows**, and then click **Tasks**. The following illustration shows the **Tasks** window.

     ![Four running tasks in Tasks window](../debugger/media/pdb_walkthrough_6.png "PDW_Walkthrough_6")

     For each running Task, you can read its ID, which is returned by the same-named property, the ID and name of the thread that runs it, its location (hovering over that displays a tooltip that has the whole call stack). Also, under the **Task** column, you can see the method that was passed into the task; in other words, the starting point.

     You can sort any column. Notice the sort glyph that indicates the sort column and direction. You can also reorder the columns by dragging them left or right.

     The yellow arrow indicates the current task. You can switch tasks by double-clicking a task or by using the shortcut menu. When you switch tasks, the underlying thread becomes current and the other windows are updated.

     When you manually switch from one task to another, the yellow arrow moves, but a white arrow still shows the task that caused the debugger to break.

#### To resume execution until the second breakpoint

1. To resume execution until the second breakpoint is hit, on the **Debug** menu, click **Continue**.

     Previously, the **Status** column showed all tasks as Active, but now two of the tasks are Blocked. Tasks can be blocked for many different reasons. In the **Status** column, hover over a waiting task to learn why it is blocked. For example, in the following illustration, task 3 is waiting on task 4.

     ![Two waiting tasks in Tasks window](../debugger/media/pdb_walkthrough_7.png "PDB_Walkthrough_7")

     Task 4, in turn, is waiting on a monitor owned by the thread assigned to task 2. (Right-click the header row and choose **Columns** > **Thread Assignment** to view the thread assignment value for task 2).

     ![Waiting task and tooltip in Tasks window](../debugger/media/pdb_walkthrough_7a.png "PDB_Walkthrough_7A")

     You can flag a task by clicking the flag in the first column of the **Tasks** window.

     You can use flagging to track tasks between different breakpoints in the same debugging session or to filter for tasks whose call stacks are shown in the **Parallel Stacks** window.

     When you used the **Parallel Stacks** window earlier, you viewed the application threads. View the **Parallel Stacks** window again, but this time view the application tasks. Do this by selecting **Tasks** in the box on the upper left. The following illustration shows the Tasks View.

     ![Tasks view in Parallel Stacks window](../debugger/media/pdb_walkthrough_8.png "PDB_Walkthrough_8")

     Threads that are not currently executing tasks are not shown in the Tasks View of the **Parallel Stacks** window. Also, for threads that execute tasks, some of the stack frames that are not relevant to tasks are filtered from the top and bottom of the stack.

     View the **Tasks** window again. Right-click any column header to see a shortcut menu for the column.

     You can use the shortcut menu to add or remove columns. For example, the AppDomain column is not selected; therefore, it is not displayed in the list. Click **Parent**. The **Parent** column appears without values for any of the four tasks.

#### To resume execution until the third breakpoint

1. To resume execution until the third breakpoint is hit, on the **Debug** menu, click **Continue**.

     A new task, task 5, is now running and task 4 is now waiting. You can see why by hovering over the waiting task in the **Status** window. In the **Parent** column, notice that task 4 is the parent of task 5.

     To better visualize the parent-child relationship, right-click the column header row and then click **Parent Child View**. You should see the following illustration.

     ![Parent&#45;child view in Tasks window](../debugger/media/pdb_walkthrough_9.png "PDB_Walkthrough_9")

     Notice that task 4 and task 5 are running on the same thread (show the **Thread Assignment** column if it is hidden). This information is not displayed in the **Threads** window; seeing it here is another benefit of the **Tasks** window. To confirm this, view the **Parallel Stacks** window. Make sure that you are viewing **Tasks**. Locate tasks 4 and 5 by double-clicking them in the **Tasks** window. When you do, the blue highlight in the **Parallel Stacks** window is updated. You can also locate tasks 4 and 5 by scanning the tooltips on the **Parallel Stacks** window.

     ![Task view in Parallel Stacks window](../debugger/media/pdb_walkthrough_9a.png "PDB_Walkthrough_9A")

     In the **Parallel Stacks** window, right-click S.P, and then click **Go To Thread**. The window switches to Threads View and the corresponding frame is in view. You can see both tasks on the same thread.

     ![Highlighted thread in threads view](../debugger/media/pdb_walkthrough_9b.png "PDB_Walkthrough_9B")

     This is another benefit of the Tasks View in the **Parallel Stacks** window, compared to the **Threads** window.

#### To resume execution until the fourth breakpoint

1. To resume execution until the third breakpoint is hit, on the **Debug** menu, click **Continue**. Click the **ID** column header to sort by ID. You should see the following illustration.

     ![Four task states in Parallel Stacks window](../debugger/media/pdb_walkthrough_10.png "PDB_Walkthrough_10")

     Because task 5 has completed, it is no longer displayed. If that is not the case on your computer and the deadlock is not shown, step one time by pressing **F11**.

     Task 3 and task 4 are now waiting on each other and are blocked. There are also 5 new tasks that are children of task 2 and are now scheduled. Scheduled tasks are tasks that have been started in code but have not run yet. Therefore, their **Location** and **Thread Assignment** columns are empty.

     View the **Parallel Stacks** window again. The header of each box has a tooltip that shows the thread IDs and names. Switch to Tasks View in the **Parallel Stacks** window. Hover over a header to see the task ID and name, and the status of the task, as shown in the following illustration.

     ![Header tooltip in Parallel Stacks window](../debugger/media/pdb_walkthrough_11.png "PDB_Walkthrough_11")

     You can group the tasks by column. In the **Tasks** window, right-click the **Status** column header and then click **Group by Status**. The following illustration shows the **Tasks** window grouped by status.

     ![Grouped tasks in Tasks window](../debugger/media/pdb_walkthrough_12.png "PDB_Walkthrough_12")

     You can also group by any other column. By grouping tasks, you can focus on a subset of tasks. Each collapsible group has a count of the items that are grouped together.

     The last feature of the **Tasks** window to examine is the shortcut menu that is displayed when you right-click a task.

     The shortcut menu displays different commands, depending on the status of the task. The commands may include **Copy**, **Select All**, **Hexadecimal Display**, **Switch to Task**, **Freeze Assigned Thread**, **Freeze All Threads But This**, and **Thaw Assigned Thread**, and **Flag**.

     You can freeze the underlying thread of a task, or tasks, or you can freeze all threads except the assigned one. A frozen thread is represented in the **Tasks** window as it is in the **Threads** window, by a blue *pause* icon.

## Summary
 This walkthrough demonstrated the **Parallel Tasks** and **Parallel Stacks** debugger windows. Use these windows on real projects that use multithreaded code. You can examine parallel code written in C++, C#, or Visual Basic.

## See also
- [Debugging Multithreaded Applications](../debugger/walkthrough-debugging-a-parallel-application.md)
- [First look at the debugger](../debugger/debugger-feature-tour.md)
- [Debugging Managed Code](../debugger/debugging-managed-code.md)
- [Parallel Programming](/dotnet/standard/parallel-programming/index)
- [Concurrency Runtime](/cpp/parallel/concrt/concurrency-runtime)
- [Using the Parallel Stacks Window](../debugger/using-the-parallel-stacks-window.md)
- [Using the Tasks Window](../debugger/using-the-tasks-window.md)