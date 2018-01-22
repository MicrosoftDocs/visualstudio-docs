---
title: "Debug a multithreaded application using the Threads window | Microsoft Docs"
ms.custom: "H1HackMay2017"
ms.date: "05/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "multithreaded debugging, tutorial"
  - "tutorials, multithreaded debugging"
ms.assetid: adfbe002-3d7b-42a9-b42a-5ac0903dfc25
caps.latest.revision: 38
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Walkthrough: Debug a multithreaded application in Visual Studio using the Threads window
Visual Studio provides a **Threads** window and other user interface elements to help you debug multithreaded applications. This tutorial shows how to use the **Threads** window and the **Debug Location** toolbar. For information on the other tools, see  [Get started debugging multithreaded applications](../debugger/get-started-debugging-multithreaded-apps.md). This tutorial takes only a few minutes, but completing it will familiarize you with the features for debugging multithreaded applications.   
  
To begin this tutorial, you need a multithreaded application project. Follow the steps listed here to create that project.  
  
#### To create the multithreaded app project  
  
1.  On the **File** menu, choose **New** and then click **Project**.  
  
     The **New Project** dialog box appears.  
  
2.  In the **Project Type**s box, click the language of your choice: **Visual Basic**, **Visual C#**, or **Visual C++**.  
  
3.  In the **Templates** box, choose **Console App**.  
  
4.  In the **Name** box, type the name MyThreadWalkthroughApp.  
  
5.  Click **OK**.  
  
     A new console project appears. When the project has been created, a source file appears. Depending on the language you have chosen, the source file might be called Module1.vb, Program.cs, or MyThreadWalkthroughApp.cpp  
  
6.  Delete the code that appears in the source file and replace it with the example code that appears in the section "Creating a Thread" of the topic [Creating Threads and Passing Data at Start Time](/dotnet/standard/threading/creating-threads-and-passing-data-at-start-time).  
  
7.  On the **File** menu, click **Save All**.  
  
#### To begin the tutorial  
  
-   In the source code editor, look for the following code:  
  
    ```VB  
    Thread.Sleep(3000)   
    Console.WriteLine()
    ```  
  
    ```CSharp  
    Thread.Sleep(3000);  
    Console.WriteLine();  
    ```  
  
    ```C++  
    Thread::Sleep(3000);  
    Console.WriteLine();  
    ```  
  
#### To start debugging  
  
1.  Click in the left gutter of the `Console.WriteLine` statement to insert a new breakpoint.  
  
     In the gutter on the left side of the source code editor, a red circle appears. This indicates that a breakpoint is now set at this location.  
  
2.  On the **Debug** menu, click **Start Debugging** (**F5**).  
  
     Debugging starts, your console application starts to run, and then stops at the breakpoint.  
  
3.  If the console application window has focus at this point, click in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] window to return focus to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
4.  In the source code editor, locate the line that contains the following code:  
  
    ```VB  
    Thread.Sleep(5000)   
    ```  
  
    ```CSharp  
    Thread.Sleep(3000);  
    ```  
  
    ```C++  
    Thread::Sleep(3000);  
    ```
  
#### To discover the thread marker  

1.  In the Debug Toolbar, click the **Show Threads in Source** button ![Show Threads in Source](../debugger/media/dbg-multithreaded-show-threads.png "ThreadMarker"). 
  
2.  Look at the gutter on the left side of the window. On this line, you will see a *thread marker* icon  ![Thread Marker](../debugger/media/dbg-thread-marker.png "ThreadMarker") that resembles two cloth threads. The thread marker indicates that a thread is stopped at this location.  
  
3.  Hover the pointer over the thread marker. A DataTip appears. The DataTip tells you the name and thread ID number for each stopped thread. In this case, there is only one thread, whose name is probably `<noname>`.  

    > [!TIP]
    > You may find it helpful to identify nameless threads by renaming them. In the Threads window, choose **Rename** after right-clicking on the **Name** column in the thread row.
  
4.  Right-click the thread marker to see the available options on the shortcut menu. 
    
  
## Flagging and Unflagging Threads  
You can flag threads that you want to give special attention. Flagging threads is a good way to keep track of important threads and to ignore threads that you do not care about.  
  
#### To flag threads   

1.  On **View** menu, point to **Toolbars**.  
  
    Make sure that the **Debug Location** toolbar is selected.

2.  Go to the **Debug Location** toolbar and click the **Thread** list.  
  
    > [!NOTE]
    >  You can recognize this toolbar by three prominent lists: **Process**, **Thread**, and **Stack Frame**.  
  
3.  Notice how many threads appear in the list.  
  
4.  Go back to the source code editor and right-click the thread marker ![Thread Marker](../debugger/media/dbg-thread-marker.png "ThreadMarker") again.  
  
5.  On the shortcut menu, point to **Flag**, and then click the thread name and ID number.  
  
6.  Go back to **Debugging Location** toolbar and find the **Show Only Flagged Threads** icon ![Show Flagged Threads](../debugger/media/dbg-threads-show-flagged.png "ThreadMarker") to the right of the **Thread** list.  
  
    The flags icon on the button was dimmed before. Now, it is an active button.  
  
7.  Click the **Show Only Flagged Threads** icon.  
  
    Only the flagged thread appears in the list now. (You can click the single flag button to toggle back to **Show All Threads** mode.)

8. Open the Threads window by choosing **Debug > Windows > Threads**.

    ![Threads Window](../debugger/media/dbg-threads-window.png "ThreadsWindow")  
  
    In the **Threads** window, the flagged thread has a prominent red flag icon attached to it.

    > [!TIP]
    > When you have flagged some threads, you can right-click a line of code in the code editor and choose **Run Flagged Threads to Cursor** (make sure that you choose code that all flagged threads will reach). This will pause threads on the selected line of code, making it easier control the order of execution by [freezing and thawing threads](#bkmk_freeze).
  
11. In the source code editor, right-click the thread marker again.  
  
     Notice what choices are now available on the shortcut menu. Instead of **Flag**, you now see **Unflag**. Do not click **Unflag**.  

     To find out how to unflag threads, go to the next procedure.  
  
#### To unflag threads  
  
1.  In the **Threads** window, right-click the line corresponding to the flagged thread.  
  
     A shortcut menu is displayed. It has options to **Unflag** and **Unflag All Threads**.  
  
2.  To unflag the thread, click **Unflag**.  

    Look at the **Debugging Location** toolbar again. The **Show Only Flagged Threads** button is dimmed again. You unflagged the only flagged thread. Because there are no flagged threads, the toolbar has gone back to **Show All Threads** mode. Click the **Thread** list and verify that you can see all threads.  
  
5.  Go back to the **Threads** window and examine the information columns.  
  
    In the first column, you will notice a flag outline icon in each row of the thread list. (The outline means that the thread is unflagged.)  
  
6.  Click the flag outline icons for two threads, the second and third from the bottom of the list. 

    The flag icons become solid red, instead of hollow outlines.  
  
7.  Click the button at the top of the flag column.  
  
    The order of the thread list changed when you clicked the button. The thread list is now sorted with the flagged threads on top.  
  
8.  Again, click the button at the top of the flag column.  
  
    The sort order changed again.  
  
## More about the Threads window  
  
#### To learn more about the Threads window  
  
1.  In the **Threads** window, examine the third column from the left. The button at the top of this column says **ID**.  
  
2.  Click **ID**.  
  
     The thread list is now sorted by thread ID number.  
  
3.  Right-click any thread in the list. On the shortcut menu, click **Hexadecimal display**.  
  
     The format of the thread ID numbers is changed.  
  
4.  Hover the mouse pointer over the **Location** column for any thread in the list.  
  
     After a momentary delay, a DataTip appears. It shows a partial call stack for the thread.

     > [!TIP]
     > For a graphical view of the call stacks for threads, open the [Parallel Stacks](../debugger/using-the-parallel-stacks-window.md) window (while debugging, choose **Debug / Windows / Parallel Stacks**).  
  
5.  Look at the fourth column from the left, which is labeled **Category**. The threads are classified into categories.  
  
     The first thread created in a process is referred to as the main thread. Locate it in the thread list.  
  
6.  Right-click the main thread and then click **Switch to Thread**.  
  
     A **Break Mode** window appears. It tells you that the debugger is not currently executing any code that it can display (because it is the main thread).   
  
7.  Look at the **Call Stack** window and the **Debug Location** toolbar.  
  
     The contents of the **Call Stack** window have changed. 

## <a name="bkmk_freeze"></a> Freezing and thawing thread execution 

You can freeze and thaw (suspend and resume) threads to control the order in which threads perform work. This can help you resolve concurrency issues such as deadlocks and race conditions.

> [!TIP]
> If you want to follow a single thread without freezing other threads (also a common debugging scenario), see [Get started debugging multithreaded applications](../debugger/get-started-debugging-multithreaded-apps.md#bkmk_follow_a_thread).
  
#### To freeze and unfreeze threads  
  
1.  In the **Threads** window, right-click any thread and then click **Freeze**.  
  
2.  Look at the second column (the current thread column). The pause icon now appears there. Those pause icon indicates that the thread is frozen.  
  
3.  Show the **Suspended Count** column by selecting it in the **Columns** list.

    The suspend count for the thread is now 1.  
  
4.  Right-click the frozen thread and then click **Thaw**.  
  
     The current thread column and the **Suspended Count** column change. 
  
## Switching the to another thread 
  
#### To switch threads  
  
1.  In the **Threads** window, examine the second column from the left (the current thread column). The button at the top of this column has no text or icon.
  
2.  Look at the current thread column and notice that one thread has a yellow arrow. The yellow arrow indicates that this thread is the current thread (this is the current location of the execution pointer).
  
    Make a note of the thread ID number where you see the current thread icon. You will move the current thread icon to another thread, but you will have to put it back when you have finished. 
  
3.  Right-click another thread and then click **Switch to Thread**.  
  
4.  Look at the **Call Stack** window in the source code editor. The contents have changed.  
  
5.  Look at the **Debug Location** toolbar. The current thread icon has changed there, too.  
  
6.  Go to the **Debug Location** toolbar. Select a different thread from the **Thread** list.  
  
7.  Look at the **Threads** window. The current thread icon has changed.  
  
8. In the source code editor, right-click a thread marker. On the shortcut menu, point to **Switch to Thread** and click a thread name/ID number.  
  
     You have now seen three ways of changing the current thread icon to another thread: using the **Threads** window, the **Thread** list in the **Debug Location** toolbar, and the thread marker in the source code editor.  
  
     With the thread marker, you can switch only to threads that are stopped at that particular location. By using the **Threads** window and **Debug Location** toolbar, you can switch to any thread.   
  
## See Also  
 [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)   
 [How to: Switch to Another Thread While Debugging](../debugger/how-to-switch-to-another-thread-while-debugging.md)
