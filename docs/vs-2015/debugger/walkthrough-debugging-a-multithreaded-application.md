---
title: "Walkthrough: Debugging a Multithreaded Application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "multithreaded debugging, walkthrough"
  - "walkthroughs, multithreaded debugging"
ms.assetid: 590ffd57-0556-43d8-8962-ee27e5b2b7d7
caps.latest.revision: 42
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Walkthrough: Debugging a Multithreaded Application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)] provides an improved **Threads** window and other user interface improvements to make it easier to debug multithreaded applications. This walkthrough takes only a few minutes, but completing it will familiarize you with the new interface features for debugging multithreaded applications.  
  
 To begin this walkthrough, you need a multithreaded application project. Follow the steps listed here to create that project.  
  
#### To create the walkthrough project  
  
1. On the **File** menu, choose **New** and then click **Project**.  
  
     The **New Project** dialog box appears.  
  
2. In the **Project Type**s box, click the language of your choice: **Visual Basic**, **Visual C#**, or **Visual C++**.  
  
3. In the **Templates** box, choose **Console Application** or **CLR Console Application**.  
  
4. In the **Name** box, type the name MyThreadWalkthroughApp.  
  
5. Click **OK**.  
  
     A new console project appears. When the project has been created, a source file appears. Depending on the language you have chosen, the source file might be called Module1.vb, Program.cs, or MyThreadWalkthroughApp.cpp  
  
6. Delete the code that appears in the source file and replace it with the example code that appears in the section "Creating a Thread" of the topic [Creating Threads and Passing Data at Start Time](https://msdn.microsoft.com/library/52b32222-e185-4f42-91a7-eaca65c0ab6d).  
  
7. On the **File** menu, click **Save All**.  
  
#### To begin the walkthrough  
  
- In the source window, look for the following code:  
  
    ```vb  
    Thread.Sleep(3000)   
    Console.WriteLine(  
    ```  
  
```csharp  
Thread.Sleep(3000);  
Console.WriteLine();  
```  
  
```cpp  
Thread::Sleep(3000);  
Console.WriteLine();  
```  
  
#### To start debugging  
  
1. Right-click the `Console.WriteLine` statement, point to **Breakpoint** and then click **Insert Breakpoint**.  
  
     In the gutter on the left side of the source window, a red ball appears. This indicates that a breakpoint is now set at this location.  
  
2. On the **Debug** menu, click **Start Debugging**.  
  
     Debugging starts, your console application starts to run, and then stops at the breakpoint.  
  
3. If the console application window has focus at this point, click in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] window to return focus to [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
4. In the source window, locate the line that contains the following code:  
  
    ```vb  
    Thread.Sleep(5000)   
    ```  
  
```csharp  
Thread.Sleep(3000);  
```  
  
```cpp  
Thread::Sleep(3000);  
```  
  
1. 
  
#### To discover the thread marker  
  
1. Right-click in the **Threads** window, then click **Show Threads in Source**.  
  
2. Look at the gutter on the left side of the window. On this line, you will see an icon that resembles two cloth threads. One thread is red and the other is blue. The thread marker indicates that a thread is stopped at this location. Possibly, thread is stopped at this location.  
  
3. Hover the pointer over the thread marker. A DataTip that appears. The DataTip tells you the name and thread ID number for each stopped thread. In this case, there is only one thread, whose name is probably `<noname>`.  
  
4. Right-click the thread marker. Note the choices on the shortcut menu.  
  
   This icon is a *thread marker*:  
  
   ![Thread Marker](../debugger/media/threadmarker.gif "ThreadMarker")  
  
## Flagging and Unflagging Threads  
 In [!INCLUDE[vs_orcas_long](../includes/vs-orcas-long-md.md)], you can flag threads that you want to give special attention. Flagging threads is a good way to keep track of important threads and ignore threads you do not care about.  
  
#### To flag threads  
  
1. On **View** menu, point to **Toolbars**.  
  
     Make sure that the **Debug Location** toolbar is selected.  
  
2. Go to the **Debugging Location** toolbar and click the **Thread** list.  
  
    > [!NOTE]
    > You can recognize this toolbar by three prominent lists: **Process**, **Thread**, and **Stack Frame**.  
  
3. Notice how many threads appear in the list.  
  
4. Go back to the source window and right-click the **Thread** marker again.  
  
5. On the shortcut menu, point to **Flag**, and then click the thread name and ID number.  
  
6. Go back to **Debugging Location** toolbar and click the **Thread** list again.  
  
     Only the flagged thread appears in the list now. The flag button that is just to the right of the **Thread** list. The flag icon on the button was dimmed before. Now, it is a solid, bright red.  
  
7. Hover the pointer over the flag icon.  
  
     A pop-up appears. This pop-up tells you what mode the **Thread** list is in: **Show Only Flagged Threads**.  
  
8. Click the flag button to toggle back to **Show All Threads** mode.  
  
9. Click the **Thread** list again and verify that you can now see all threads again.  
  
10. Click the flag button to toggle back to **Show Only Flagged Threads**.  
  
11. On the **Debug** menu, point to **Windows** and then click **Threads**.  
  
     The **Threads** window appears. One thread has a prominent flag icon attached to it.  
  
12. In the source window, right-click the thread marker again.  
  
     Notice what choices are now available on the shortcut menu. Instead of **Flag**, you now see **Unflag**. Do not click **Unflag**.  
  
13. Go to the next procedure about how to unflag threads.  
  
#### To unflag threads  
  
1. On the **Threads** window, right-click the line corresponding to the flagged thread.  
  
     A shortcut menu is displayed. It has options to **Unflag** and **Unflag All**.  
  
2. To unflag the thread, click **Unflag**.  
  
3. Click the red flag icon.  
  
4. Look at the **Debugging Location** toolbar again. The flag button is dimmed again. You unflagged the only flagged thread. Because there are no flagged threads, the toolbar has gone back to **Show All Threads** mode. Click the **Thread** list and verify that you can see all threads.  
  
5. Go back to the **Threads** window and examine the information columns.  
  
     At the top of each column, most of the buttons have titles that identify the column. However, The first column on the left has no title. Instead, it has an icon, which is the outline of a flag. You will notice the same outline in each row of the thread list. The outline means that the thread is unflagged.  
  
6. Click the flag outlines for two threads, the second and third from the bottom of the list.  
  
     The flag icons become solid red, instead of hollow outlines.  
  
7. Click the button at the top of the flag column.  
  
     The order of the thread list changed when you clicked the button. The thread list is now sorted with the flagged threads on top.  
  
8. Again, click the button at the top of the flag column.  
  
     The sort order changed again.  
  
## More about the Threads window  
  
#### To learn more about the Threads window  
  
1. In the **Threads** window, examine the third column from the left. The button at the top of this column says **ID**.  
  
2. Click **ID**.  
  
     The thread list is now sorted by thread ID number.  
  
3. Right-click any thread in the list. On the shortcut menu, click **Hexadecimal display**.  
  
     The format of the thread ID numbers is changed.  
  
4. Hover the mouse pointer over any thread in the list.  
  
     After a momentary delay, a DataTip appears. It shows a partial call stack for the thread.  
  
5. Look at the fourth column from the left, which is labeled **Category**. The threads are classified into categories.  
  
     The first thread created in a process is referred to as the main thread. Locate it in the thread list.  
  
6. Right-click the main thread and then click **Switch to Thread**.  
  
     A warning dialog box appears. It tells you that [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] cannot display source code for the main thread.  
  
     Click **OK**.  
  
7. Look at the **Call Stack** window and the **Debug Location** toolbar.  
  
     The contents of the **Call Stack** window have changed.  
  
## Switching the Active Thread  
  
#### To switch threads  
  
1. In the **Threads** window, examine the second column from the left. The button at the top of this column has no text or icon. This column is the **Active Thread** column.  
  
2. Look at the **Active Thread** column and notice that one thread has a yellow arrow. This is the *active thread indicator*.  
  
3. Make a note of the thread ID number where the active thread indicator is located. You will move the active thread indicator to another thread, but you will have to put it back when you have finished.  
  
4. Right-click another thread and then click **Switch to Thread**.  
  
5. Look at the **Call Stack** window in the source window. The contents have changed.  
  
6. Look at the **Debug Location** toolbar. The active thread has changed there, too.  
  
7. Go to the **Debug Location** toolbar. Click the **Thread** box and choose a different thread from the drop-down list.  
  
8. Look at the **Threads** window. The active thread indicator has changed.  
  
9. In the source window, right-click a thread marker. On the shortcut menu, point to **Switch to** and click a thread name/ID number.  
  
     You have now seen three ways of changing the active thread: using the **Threads** window, the **Thread** box in the **Debug Location** toolbar, and the thread indicator in the source window.  
  
     With the thread indicator, you can switch only to threads that are stopped at that particular location. By using the **Threads** window and **Debug Location** toolbar, you can switch to any thread.  
  
## Freezing and thawing thread execution  
  
#### To freeze and unfreeze threads  
  
1. In the **Threads** window, right-click any thread and then click **Freeze**.  
  
2. Look at the active thread column. The pair of vertical bars now appear there. Those two blue bars indicate that the thread is frozen.  
  
3. Look at the **Suspend** column. The suspend count for the thread is now 1.  
  
4. Right-click the frozen thread and then click **Thaw**.  
  
     The active thread column and the **Suspend** column change.  
  
## See Also  
 [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)   
 [How to: Switch to Another Thread While Debugging](../debugger/how-to-switch-to-another-thread-while-debugging.md)
