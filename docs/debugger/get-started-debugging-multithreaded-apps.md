---
title: "Get started debugging multithreaded applications | Microsoft Docs"
ms.custom: "H1HackMay2017"
ms.date: "06/02/2017"
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
ms.assetid: 62df746b-b0f6-4df4-83cf-b1d9d2e72833
caps.latest.revision: 38
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Get started debugging a multithreaded application in Visual Studio
Visual Studio provides several tools and user interface elements to help you debug multithreaded applications. This tutorial shows how to use thread markers, the **Parallel Stacks** window, the **Parallel Watch** window, conditional breakpoints, and filter breakpoints . This tutorial takes only a few minutes, but completing it will familiarize you with the features for debugging multithreaded applications.

|         |         |
|---------|---------|
|  ![movie camera icon for video](../install/media/video-icon.png "Watch a video")  |    [Watch a video](https://mva.microsoft.com/en-US/training-courses-embed/getting-started-with-visual-studio-2017-17798/Debugging-Multi-threaded-Apps-in-Visual-Studio-2017-MoZPKMD6D_111787171) on multithreaded debugging that shows similar steps. |

Other topics provide additional information on using other multithreaded debugging tools:

- For a similar topic that shows how to use the **Debug Location** toolbar and the **Threads** window, see [Walkthrough: Debug a Multithreaded Application](../debugger/how-to-use-the-threads-window.md).

- For a similar topic with a sample that uses <xref:System.Threading.Tasks.Task> (managed code) and the concurrency runtime (C++), see [Walkthrough: Debugging a Parallel Application](../debugger/walkthrough-debugging-a-parallel-application.md). For general debugging tips that apply to most multithreaded application types, read both this topic and the linked topic.
  
To begin this tutorial, you need a multithreaded application project. Follow the steps listed here to create that project.  
  
#### To create the multithreaded app project  
  
1.  On the **File** menu, choose **New** and then click **Project**.  
  
     The **New Project** dialog box appears.  
  
2.  In the **Project Type**s box, click the language of your choice: **Visual C#**, **Visual C++**, or **Visual Basic**.  
  
3.  In the **Templates** box, choose **Console App**.  
  
4.  In the **Name** box, type the name MyThreadWalkthroughApp.  
  
5.  Click **OK**.  
  
     A new console project appears. When the project has been created, a source file appears. Depending on the language you have chosen, the source file might be called Program.cs, MyThreadWalkthroughApp.cpp, or Module1.vb.  
  
6.  Delete the code that appears in the source file and replace it with the example code shown here.

    ```csharp
    using System;
    using System.Threading;

    public class ServerClass
    {

        static int count = 0;
        // The method that will be called when the thread is started.
        public void InstanceMethod()
        {
            Console.WriteLine(
                "ServerClass.InstanceMethod is running on another thread.");

            int data = count++;
            // Pause for a moment to provide a delay to make
            // threads more apparent.
            Thread.Sleep(3000);
            Console.WriteLine(
                "The instance method called by the worker thread has ended.");
        }
    }

    public class Simple
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                CreateThreads();
            }
        }
        public static void CreateThreads()
        {
            ServerClass serverObject = new ServerClass();

            Thread InstanceCaller = new Thread(new ThreadStart(serverObject.InstanceMethod));
            // Start the thread.
            InstanceCaller.Start();

            Console.WriteLine("The Main() thread calls this after "
                + "starting the new InstanceCaller thread.");

        }
    }
    ```

    ```C++
    #include "stdafx.h"
    #include <thread>
    #include <iostream>
    #include <vector>

    int count = 0;

    void doSomeWork() {

        std::cout << "The doSomeWork function is running on another thread." << std::endl;
        int data = count++;
        // Pause for a moment to provide a delay to make
        // threads more apparent.
        std::this_thread::sleep_for(std::chrono::seconds(3));
        std::cout << "The function called by the worker thread has ended." << std::endl;
    }

    int main() {
        std::vector<std::thread> threads;

        for (int i = 0; i < 10; ++i) {

            threads.push_back(std::thread(doSomeWork));
            std::cout << "The Main() thread calls this after starting the new thread" << std::endl;
        }

        for (auto& thread : threads) {
            thread.join();
        }

        return 0;
    }
    ```

    ```VB
    Imports System.Threading

    Public Class ServerClass
        ' The method that will be called when the thread is started.
        Public count = 0
        Public Sub InstanceMethod()
            Console.WriteLine(
                    "ServerClass.InstanceMethod is running on another thread.")

            Dim data = count + 1
            ' Pause for a moment to provide a delay to make
            ' threads more apparent.
            Thread.Sleep(3000)
            Console.WriteLine(
                    "The instance method called by the worker thread has ended.")
        End Sub

    End Class

    Public Class Simple

        Public Shared Sub Main()

            Dim ts As New ThreadStarter
            For index = 1 To 10
                ts.CreateThreads()
            Next

        End Sub

    End Class
    Public Class ThreadStarter
        Public Sub CreateThreads()
            Dim serverObject As New ServerClass()

            ' Create the thread object, passing in the
            ' serverObject.InstanceMethod method using a
            ' ThreadStart delegate.
            Dim InstanceCaller As New Thread(AddressOf serverObject.InstanceMethod)

            ' Start the thread.
            InstanceCaller.Start()

            Console.WriteLine("The Main() thread calls this after " _
                        + "starting the new InstanceCaller thread.")

        End Sub
    End Class
    ```
  
7.  On the **File** menu, click **Save All**.  
  
#### To begin the tutorial  
  
-   In the source code editor, look for the following code: 
  
    ```CSharp  
    Thread.Sleep(3000);  
    Console.WriteLine();  
    ```  
  
    ```C++  
    Thread::Sleep(3000);  
    Console.WriteLine();  
    ```  
    ```VB
    Thread.Sleep(3000)
    Console.WriteLine()
    ```
  
#### To start debugging  
  
1.  Click in the left gutter of the `Thread.Sleep` or `Thread::Sleep` statement to insert a new breakpoint.  
  
     In the gutter on the left side of the source code editor, a red circle appears. This indicates that a breakpoint is now set at this location. 
  
2.  On the **Debug** menu, click **Start Debugging** (**F5**).  
  
     Visual Studio builds the solution, the app starts to run with the debugger attached, and then the app stops at the breakpoint.  
  
    > [!NOTE]
    > If you switch focus to the console window, click in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] window to return focus to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
4.  In the source code editor, locate the line that contains the breakpoint:  
  
    ```CSharp  
    Thread.Sleep(3000);  
    ```  
  
    ```C++  
    Thread::Sleep(3000);  
    ```

    ```VB
    Thread.Sleep(3000)
    ```    
  
#### <a name="ShowThreadsInSource"></a>To discover the thread marker  

1.  In the Debug Toolbar, click the **Show Threads in Source** button ![Show Threads in Source](../debugger/media/dbg-multithreaded-show-threads.png "ThreadMarker").

2. Press **F11** once to advance the debugger one line of code.
  
3.  Look at the gutter on the left side of the window. On this line, you will see a *thread marker* icon  ![Thread Marker](../debugger/media/dbg-thread-marker.png "ThreadMarker") that resembles two cloth threads. The thread marker indicates that a thread is stopped at this location.

    Notice that a thread marker may be partially concealed by a breakpoint. 
  
4.  Hover the pointer over the thread marker. A DataTip appears. The DataTip tells you the name and thread ID number for each stopped thread. In this case, the name is probably `<noname>`. 
  
5.  Right-click the thread marker to see the available options on the shortcut menu.
    
## <a name="ParallelStacks"></a>View the Location of Threads

In the **Parallel Stacks** window, you can switch between a Threads view and (for task-based programming) Tasks view, and you can view call stack information for each thread. In this app, we can use the Threads view.

1. Open the **Parallel Stacks** window by choosing **Debug > Windows > Parallel Stacks**. You should see something similar to this (the exact information will be different depending on the current location of each thread, your hardware, and your programming language).

    ![Parallel Stacks Window](../debugger/media/dbg-multithreaded-parallel-stacks.png "ParallelStacksWindow")

    In this example, from left to right we get this information:
    
    - The Main thread (left side) has stopped on `Thread.Start` (the stop point is indicated by the thread marker icon ![Thread Marker](../debugger/media/dbg-thread-marker.png "ThreadMarker")).
    - Two threads have entered the `ServerClass.InstanceMethod`, one of which is the current thread (yellow arrow), while the other thread has stopped in `Thread.Sleep`.
    - A new thread (on the right) is also starting (stopped on `ThreadHelper.ThreadStart`).

2.  Right-click entries in the **Parallel Stacks** window to see the available options on the shortcut menu.

    You can take various actions from these right-click menus, but for this tutorial we will show more of these details in the **Parallel Watch** window (next sections).

    > [!NOTE]
    > If you are more interested in seeing a list view with information on each thread, use the **Threads** window instead. See [Walkthrough: Debug a Multithreaded Application](../debugger/how-to-use-the-threads-window.md).

## Set a Watch on a Variable

1. Open the **Parallel Watch** window by choosing **Debug > Windows > Parallel Watch > Parallel Watch 1**.

2. Click in the cell where you see the `<Add Watch>` text (or the empty header cell in the 4th column), type `data`, and press Enter.

    The values for the data variable for each thread appear in the window.

3. Click again in the cell where you see the `<Add Watch>` text (or the empty header cell in the 5th column), type `count`, and press Enter.

    The values for the count variable for each thread appear in the window. (If you don't see this much information yet, try pressing F11 a few more times to advance the execution of the threads in the debugger.)

    ![Parallel Watch Window](../debugger/media/dbg-multithreaded-parallel-watch.png "ParallelWatchWindow")

4. Right-click one of the rows in the window to see available options.

## Flagging and Unflagging Threads  
You can flag threads that you want to give special attention. Flagging threads is a good way to keep track of important threads and to ignore threads that you do not care about.  
  
#### To flag threads  

1. In the **Parallel Watch** window, hold down the SHIFT key and select multiple rows.

2. Right-click and choose **Flag**.

    Now, all the selected threads are flagged. Now, you can filter to show only flagged threads.
  
3.  In the **Parallel Watch** window, find the **Show Only Flagged Threads** button ![Show Flagged Threads](../debugger/media/dbg-threads-show-flagged.png "ThreadMarker").  
  
4.  Click the **Show Only Flagged Threads** button.  
  
    Only the flagged thread appears in the list now.

    > [!TIP]
    > When you have flagged some threads, you can right-click a line of code in the code editor and choose **Run Flagged Threads to Cursor** (make sure that you choose code that all flagged threads will reach). This will pause threads on the selected line of code, making it easier to control the order of execution by [freezing and thawing threads](#bkmk_freeze).

5.  Click the **Show Only Flagged Threads** button to toggle back to **Show All Threads** mode.
    
#### To unflag threads

To unflag threads, you can right-click one or more flagged threads in the **Parallel Watch** window and choose **Unflag**.

## <a name="bkmk_freeze"></a> Freezing and thawing thread execution 

> [!TIP]
> You can freeze and thaw (suspend and resume) threads to control the order in which threads perform work. This can help you resolve concurrency issues such as deadlocks and race conditions.
  
#### To freeze and unfreeze threads  
  
1.  In the **Parallel Watch** window, with all the rows selected, right-click and select **Freeze**.

    In the second column, a pause icon now appears for each row. The pause icon indicates that the thread is frozen.

2.  Deselect the rows by clicking one row only.

3.  Right-click a row and select **Thaw**.

    The pause icon goes away on this row, indicating that the thread is no longer frozen.

4.  Switch to the code editor and click **F11**. Only the unfrozen thread runs.

    The app may also instantiate some new threads. Notice that any new threads are unflagged and are not frozen.

## <a name="bkmk_follow_a_thread"></a> Follow a Single Thread by using Conditional Breakpoints

Sometimes, it can be helpful to follow the execution of a single thread in the debugger. One way you can do that is by freezing threads that you are not interested in, but in some scenarios you may wish to follow a single thread without freezing other threads (to repro a particular bug, for example). To follow a thread without freezing other threads, you must avoid breaking into code except on the thread that you are interested in. You can do this by setting a [conditional breakpoint](../debugger/using-breakpoints.md#BKMK_Specify_a_breakpoint_condition_using_a_code_expression).

You can set breakpoints on different conditions, such as the thread name or the thread ID. Another method that may be helpful is to set the condition on data that you know will be unique to each thread. This is a common debugging scenario, in which you are more interested in some particular data value than in any particular thread.

#### To follow a single thread

1. Right-click the breakpoint you previously created and choose **Conditions**.

2. In the **Breakpoint Settings** window, type `data == 5` for the conditional expression.

    ![Conditional Breakpoint](../debugger/media/dbg-multithreaded-conditional-breakpoint.png "ConditionalBreakpoint")

    > [!TIP]
    > If you are more interested in a specific thread, then use a thread name or thread ID for the condition. To do this in the **Breakpoint Settings** window, select **Filter** instead of **Conditional expression**, and follow the filter tips. You may want to name your threads in your app code (since threads IDs change when you restart the debugger).

3. Close the **Breakpoint Settings** window.

4. Click the Restart ![Restart App](../debugger/media/dbg-tour-restart.png "RestartApp") button to restart your debugging session.

    You will break into code on the thread for which the data variable is 5. Look for the yellow arrow (current debugger context) in the **Parallel Watch** window to verify that.

5. Now, you can step over code (F10) and step into code (F11) and follow the execution of the single thread.

    As long as the breakpoint condition is unique to the thread, and the debugger doesn't hit any other breakpoints on other threads (you may need to disable them), you can step over code and step into code without switching to other threads.

    > [!NOTE]
    > When you advance the debugger, all threads will run. However, the debugger won't break into code on other threads unless one of the other threads hits a breakpoint. 
  
## More about the multithreaded debugging windows 

#### To switch to another thread 

- To switch to another thread, see [How to: Switch to Another Thread While Debugging](../debugger/how-to-switch-to-another-thread-while-debugging.md) 

#### To learn more about the Parallel Stack and Parallel Watch windows  
  
- See [How to: Use the Parallel Stack Window](../debugger/using-the-parallel-stacks-window.md) 

- See [How to: Use the Parallel Watch Window](../debugger/how-to-use-the-parallel-watch-window.md) 
  
## See Also  
 [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)   
 [How to: Switch to Another Thread While Debugging](../debugger/how-to-switch-to-another-thread-while-debugging.md)
