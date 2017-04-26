---
title: "Get started debugging multithreaded applications | Microsoft Docs"
ms.custom: ""
ms.date: "04/18/2017"
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
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Get started debugging a multithreaded application in Visual Studio
Visual Studio provides a many tools and other user interface elements to help you debug multithreaded applications. This tutorial shows how to use conditional breakpoints, the **Parallel Stacks** window, and **Parallel Watch** window. This tutorial takes only a few minutes, but completing it will familiarize you with the features for debugging multithreaded applications.

Other topics provide additional information on using other multithreaded debugging tools:

- For a similar topic with a sample that uses <xref:System.Threading.Tasks.Task> or the concurrency runtime, see [Walkthrough: Debugging a Parallel Application](../debugger/walkthrough-debugging-a-parallel-application.md). Many of the concepts and tips in this topic will also apply to debugging parallel applications.

- To learn how to use the **Debug Location** toolbar and the **Threads** window, see [Walkthrough: Debug a Multithreaded Application](../debugger/how-to-use-the-threads-window.md).
  
To begin this tutorial, you need a multithreaded application project. Follow the steps listed here to create that project.  
  
#### To create the multithreaded app project  
  
1.  On the **File** menu, choose **New** and then click **Project**.  
  
     The **New Project** dialog box appears.  
  
2.  In the **Project Type**s box, click the language of your choice: **Visual C#** or **Visual C++**.  
  
3.  In the **Templates** box, choose **Console App**.  
  
4.  In the **Name** box, type the name MyThreadWalkthroughApp.  
  
5.  Click **OK**.  
  
     A new console project appears. When the project has been created, a source file appears. Depending on the language you have chosen, the source file might be called Program.cs, or MyThreadWalkthroughApp.cpp  
  
6.  Delete the code that appears in the source file and replace it with the example code shown here (this is modified code from the "Creating a Thread" section of the topic [Creating Threads and Passing Data at Start Time](/dotnet/articles/standard/threading/creating-threads-and-passing-data-at-start-time).

    ```C#
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
    using namespace System;
    using namespace System::Threading;

    public ref class ServerClass
    {
    public:

      static int count = 0;

      // The method that will be called when the thread is started.
      void InstanceMethod()
      {
        Console::WriteLine(
          "ServerClass.InstanceMethod is running on another thread.");

        int data = count++;
        // Pause for a moment to provide a delay to make
        // threads more apparent.
        Thread::Sleep(3000);
        Console::WriteLine(
          "The instance method called by the worker thread has ended.");
      }
    };

    public ref class Simple
    {
    public:
      static void Main()
      {
        for (size_t i = 0; i < 10; i++)
        {
          CreateThreads();
        }
      }

      static void CreateThreads()
      {
        ServerClass^ serverObject = gcnew ServerClass();

        // Create the thread object, passing in the
        // serverObject.InstanceMethod method using a
        // ThreadStart delegate.
        Thread^ InstanceCaller = gcnew Thread(
          gcnew ThreadStart(serverObject, &ServerClass::InstanceMethod));

        // Start the thread.
        InstanceCaller->Start();

        Console::WriteLine("The Main() thread calls this after "
          + "starting the new InstanceCaller thread.");
      }
    };

    int main()
    {
      Simple::Main();
    }  
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
  
#### To start debugging  
  
1.  Click in the left gutter of the `Thread.Sleep` or `Thread::Sleep` statement to insert a new breakpoint.  
  
     In the gutter on the left side of the source code editor, a red ball appears. This indicates that a breakpoint is now set at this location.

2. (C++ Console app) Build the solution (**Build / Build Solution**). 
  
3.  On the **Debug** menu, click **Start Debugging** (**F5**).  
  
     Debugging starts, your console application starts to run, and then stops at the breakpoint.  
  
4.  If the console application window has focus at this point, click in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] window to return focus to [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
5.  In the source code editor, locate the line that contains the following code:  
  
    ```CSharp  
    Thread.Sleep(3000);  
    ```  
  
    ```C++  
    Thread::Sleep(3000);  
    ```
  
#### To discover the thread marker  

1.  In the Debug Toolbar, click the **Show Threads in Source** button ![Show Threads in Source](../debugger/media/dbg-multithreaded-show-threads.png "ThreadMarker").

2. Press **F11** once to advance the debugger one line of code.
  
3.  Look at the gutter on the left side of the window. On this line, you will see a *thread marker* icon  ![Thread Marker](../debugger/media/dbg-thread-marker.png "ThreadMarker") that resembles two cloth threads. The thread marker indicates that a thread is stopped at this location.

    Notice that some thread markers will be partly concealed by the breakpoint (which you can remove, if needed). 
  
4.  Hover the pointer over the thread marker. A DataTip appears. The DataTip tells you the name and thread ID number for each stopped thread. In this case, the name is probably `<noname>`. 
  
5.  Right-click the thread marker to see the available options on the shortcut menu.
    
## View the Location of Threads

In the **Parallel Stacks** window, you can switch between a Threads view and (for task-based programming) Tasks view.

1. Open the **Parallel Stacks** window by choosing **Debug / Windows / Parallel Stacks**. You should see something similar to this (the exact information will be different depending on the current location of each thread and your programming language).

    ![Parallel Stacks Window](../debugger/media/dbg-multithreaded-parallel-stacks.png "ParallelStacksWindow")

    In this illustration, we see that two threads have entered the `ServerClass.InstanceMethod`, one of which is the active thread (yellow marker). The other thread has stopped in `Thread.Sleep` (indicated by the thread marker icon ![Thread Marker](../debugger/media/dbg-thread-marker.png "ThreadMarker")). In addition, the Main thread (on the left) has stopped on `Thread.Start`, and a new thread (on the right) is also starting (stopped on `ThreadHelper.ThreadStart`).

2.  Right-click entries in the **Parallel Stacks** window to see the available options on the shortcut menu.

    > [!NOTE]
    > If you are more interested in seeing detailed information on each thread such as the type and name of each thread, use the **Threads** window instead. See [Walkthrough: Debug a Multithreaded Application](../debugger/how-to-use-the-threads-window.md).

## Set a Watch on a Variable

1. Open the **Parallel Watch** window by choosing **Debug / Windows / Parallel Watch / Parallel Watch 1**.

2. Click in the 4th column header cell, type `data`, and press Enter.

    The values for the data variable for each thread appear in the window.

3. Click in the 5th column header call, type `count`, and press Enter.

    The values for the count variable for each thread appear in the window.

    ![Parallel Watch Window](../debugger/media/dbg-multithreaded-parallel-watch.png "ParallelWatchWindow")

    If you don't see this much information yet, try pressing F11 again to advance the execution of the threads in the debugger.

4. Right-click one of the rows in the window to see available options.

## Flagging and Unflagging Threads  
You can flag threads that you want to give special attention. Flagging threads is a good way to keep track of important threads and to ignore threads that you do not care about.  
  
#### To flag threads  
  
1. In the code editor, press F11 a few more times until more threads appear in the **Parallel Watch** window.

2. In the **Parallel Watch** window, hold down the SHIFT key and select multiple rows.

3. Right-click and choose **Flag**.

    Now, all the selected threads are flagged.

    > [!TIP]
    > When you have flagged some threads, you can right-click a line of code in the code editor and choose **Run Flagged Threads to Cursor** (make sure that you choose code that all flagged threads will reach). This will pause threads on the selected line of code, making it easier control the order of execution by [freezing and thawing threads](#bkmk_freeze).  
  
4.  In the **Parallel Watch** window, find the **Show Only Flagged Threads** icon ![Show Flagged Threads](../debugger/media/dbg-threads-show-flagged.png "ThreadMarker") to the right of the **Show Stacks** list.  
  
    The flags icon on the button was dimmed before. Now, it is an active button.  
  
7.  Click the **Show Only Flagged Threads** icon.  
  
    Only the flagged thread appears in the list now.
    
#### To unflag threads

You can click the single flag button to toggle back to **Show All Threads** mode. (You can also right-click in the **Parallel Watch** window and choose **Unflag**.)

Flag all the threads again before continuing the next task (in which you will freeze thread execution).

## <a name="bkmk_freeze"></a> Freezing and thawing thread execution 

> [!TIP]
> You can freeze and thaw (suspend and resume) threads to control the order in which threads perform work. This can help you resolve concurrency issues such as deadlocks and race conditions.
  
#### To freeze and unfreeze threads  
  
1.  In the **Parallel Watch** window, with all the rows selected, right-click and select **Freeze**.

    In the second column, a pair of vertical bars now appear for each row. Those two blue bars indicate that the thread is frozen.

2.  Deselect the rows by clicking one row only.

3.  Right-click a row and select **Thaw**.

    The vertical bars go away on this row, indicating that the thread is no longer frozen.

4.  Switch to the code editor and click **F11**. Only the unfrozen thread runs.

    The app may also instantiate some new threads. Notice that any new threads are unflagged and are not frozen.

## Follow a Single Thread by using Conditional Breakpoints

Sometimes, it can be helpful to follow the execution of a single thread in the debugger. One way you can do that is by freezing threads that you are not interested in, but in some scenarios you may wish to follow a single thread without freezing other threads (due to the nature of a bug, for example). To follow a thread without freezing other threads you must avoid breaking into code except on the thread that you are interested in. You can do this by setting a conditional breakpoint.

You can set breakpoints on different conditions, such as the thread name or (if you know it) the thread ID. Another method that may be helpful is to set the condition on data that you know will be unique to each thread. This is a common debugging scenario, in which you are more interested in some particular data value than in any particular thread.

#### To follow a single thread

1. Right-click the breakpoint you previously created and choose **Conditions**.

2. In the **Breakpoint Settings** window, type `data == 5` for the conditional expression.

    ![Conditional Breakpoint](../debugger/media/dbg-multithreaded-conditional-breakpoint.png "ConditionalBreakpoint")

3. Close the **Breakpoint Settings** window.

4. Click the Restart ![Restart App](../debugger/media/dbg-tour-restart.png "RestartApp") button to restart your debugging session.

    You will break into code on the thread for which the data variable is 5. Check the active thread (yellow arrow) in the **Parallel Watch** window to verify that.

5. Now, you can step over code (F10) and step into code (F11) and follow the execution of the single thread.

    As long as the breakpoint condition is unique to the thread, and the debugger doesn't hit any other breakpoints on other threads, you can step over code and step into code without switching to other threads.

    > [!NOTE]
    > If you are more interested in a specific thread, then use a thread name or thread ID for the condition.
  
## More about the multithreaded debugging windows 

#### To switch the active thread 

- See [How to: Switch to Another Thread While Debugging](../debugger/how-to-switch-to-another-thread-while-debugging.md) 
  
#### To learn more about the Parallel Stack and Parallel Watch windows  
  
- See [How to: Use the Parallel Stack Window](../debugger/using-the-parallel-stacks-window.md) 

- See [How to: Use the Parallel Watch Window](../debugger/how-to-use-the-parallel-watch-window.md) 
  
## See Also  
 [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)   
 [How to: Switch to Another Thread While Debugging](../debugger/how-to-switch-to-another-thread-while-debugging.md)