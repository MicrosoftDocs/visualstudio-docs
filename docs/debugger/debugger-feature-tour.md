---
title: "Debugger Feature Tour | Microsoft Docs"
ms.custom: ""
ms.date: "03/04/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
helpviewer_keywords: 
  - "debugger"
ms.assetid: c763d706-3213-494f-b4d2-990b6e1ec456
caps.latest.revision: 1
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Debugger feature tour

This topic introduces the features of the Visual Studio debugger. If you want to follow along by opening your own app in Visual Studio, you can do that, or you can follow along with a sample app using the [step-by-step Beginner's Guide](../debugger/getting-started-with-the-debugger.md).

The features described here are applicable to C#, C++, Visual Basic, JavaScript, and other languages supported by Visual Studio (except where noted).

## Set a breakpoint and start the debugger

To debug, you need to start your app with the debugger attached to the app process. F5 (**Debug / Start Debugging**) is the most common way to do that, but right now you may not have set any breakpoints to examine your app code, so we'll do that first and then start debugging.

With a project open in Solution Explorer and a file open in the code editor, set a breakpoint by clicking in the margin to the left of a line of code.

![Set a Breakpoint](../debugger/media/dbg-tour-set-a-breakpoint.gif "SetABreakPoint")

Press F5 (**Debug / Start Debugging**) and the debugger runs to the first breakpoint that it encounters. If the app is not yet running, F5 starts the debugger and stops at the first breakpoint.

Breakpoints are a really useful feature when you know the line of code or the section of code that you want to examine in detail.

## Navigate code in the debugger using step commands

We are showing the keyboard shortcuts for most commands because they make navigation of your app code quicker (equivalent commands such as menu commands are shown in parentheses).

Press F11 (**Debug / Step Into**) to start your app with the debugger attached. F11 is the **Step Into** command and advances the app execution one statement at a time. When you start the app with F11, the debugger breaks on the first statement that gets executed.

![F11 Step Into](../debugger/media/dbg-tour-f11.png "F11 Step Into")

The yellow arrow represents the statement on which the debugger paused, which also suspends app execution at the same point (this statement has not yet executed).

F11 is a good way to examine the execution flow in the most detail. (To move faster through code, we will show you some other options as well.) By default, the debugger skips over non-user code (if you want more details, see [Just My Code](../debugger/just-my-code.md)).

>[!NOTE]
> In managed code, you will see a dialog box asking if you want to be notified when you automatically step over properties and operators (default behavior). If you want to change the setting later, disable **Step over properties and operators** setting in the **Tools / Options** menu under **Debugging**.

## Step over code to skip functions

When you are on a line of code that is a function or method call, you can press F10 (**Debug / Step Over**) instead of F11.

F10 advances the debugger without stepping into functions or methods in your app code (the code still executes). By pressing F10, you can skip over code that you're not interested in, so you can quickly get to code that you are more interested in.

## Step into a property

As mentioned earlier, by default the debugger skips over managed properties and fields, but the **Step Into Specific** command allows you to override this behavior.

Right-click on a property or field and choose **Step Into Specific**, then choose one of the available options.

![Step into Specific](../debugger/media/dbg-tour-step-into-specific.png "Step Into Specific")

In this example, **Step Into Specific** gets us to the code for `Path.set`.

![Step into Specific](../debugger/media/dbg-tour-step-into-specific-2.png "Step Into Specific")

## Run to a point in your code quickly using the mouse

While in the debugger, hover over a line of code until the **Run execution to here** button ![Run to Click](../debugger/media/dbg-tour-run-to-click.png "RunToClick") appears on the left.

![Run to Click](../debugger/media/dbg-tour-run-to-click-2.png "Run to Click")

>  [!NOTE] 
> The **Run execution to here** button is new in [!include[vs_dev15](../misc/includes/vs_dev15_md.md)].

Click the **Run execution to here** button. The debugger advances to the line of code where you clicked.

Using this button is similar to setting a temporary breakpoint, which is also handy for getting around quickly within a visible region of app code (you can click in any open file).

## Advance the debugger out of the current function

Sometime, you might want to continue your debugging session but advance the debugger all the way through the current function.

Press Shift + F11 (or **Debug / Step Out**).

This resumes app execution (and advances the debugger) until the current function returns.

## Run to cursor

Stop the debugger by pressing the **Stop Debugging** red button ![Stop Debugging](../debugger/media/dbg-tour-stop-debugging.png "Stop Debugging") or Shift + F5.

Right-click a line of code in your app and choose **Run to Cursor**. This command starts debugging and sets a temporary breakpoint on the current line of code.

![Run to Cursor](../debugger/media/dbg-tour-run-to-cursor.png "Run to Cursor")

If you have set breakpoints, the debugger will pause on the first breakpoint that it hits.

Press F5 until you reach the line of code where you selected **Run to Cursor**.

This command is useful when you are editing code and want to quickly set a temporary breakpoint and start the debugger.

## Restart your app quickly

Click the **Restart** ![Restart App](../debugger/media/dbg-tour-restart.png "RestartApp") button in the Debug Toolbar (Ctrl + Shift +F5).

When you press **Restart**, it saves time versus stopping the app and restarting the debugger. The debugger pauses at the first breakpoint that is hit by executing code, similar to pressing F5 (if the code isn't executed, you won't hit the breakpoint).

If you do want to stop the debugger and get back into the code editor, you can press the red stop ![Stop Debugging](../debugger/media/dbg-tour-stop-debugging.png "Stop Debugging") button instead of **Restart**.

## Inspect variables with data tips

Now that you know your way around a little, you have a good opportunity to start inspecting your app state (variables) with the debugger. Features that allow you to inspect variables are some of the most useful features of the debugger, and there are different ways to do it. Often, when trying to debug an issue, you will be attempting to find out whether variables are storing the values that you expect them to have at a particular point of execution.

While paused in the debugger, hover over an object with the mouse and you will see its default property value (in this example, the file name `market 031.jpg` is the default property value).

![View a Data Tip](../debugger/media/dbg-tour-data-tips.gif "View a Data Tip")

Expland the object to see all its properties (such as the `FullPath` property in this example).

Often, when debugging, you will want a quick way to check property values on objects, and the data tips are a good way to do it.

> [!TIP]
> In most supported languages, you can edit code in the middle of a debugging session if you find something you want to change. For more info, see [Edit and Continue](../debugger/edit-and-continue.md).

## Inspect variables with the Autos and Locals windows

While debugging, take a look at the **Autos** window at the bottom of the code editor.

![Autos Window](../debugger/media/dbg-tour-autos-window.png "Autos Window")

In the **Autos** window, you see variables along with their current value and their type. The **Autos** window shows all variables used on the current line or the preceding line (In C++, the window shows variables in the preceding three lines of code. Check documentation for language-specific behavior).

> [!NOTE]
> In JavaScript, the **Locals** window is supported but not the **Autos** window.

Next, take a look at the **Locals** window. The **Locals** window shows you the variables that are currently in scope.

![Locals Window](../debugger/media/dbg-tour-locals-window.png "Locals Window")

In this example, the `this` object and the object `f` are in scope. For more info, see [Inspect Variables in the Autos and Locals Windows](../debugger/autos-and-locals-windows.md).

## Set a watch

You can use a **Watch** window to specify a variable (or an expression) that you want to keep an eye on.

While debugging, right-click an object and choose **Add Watch**.

![Watch Window](../debugger/media/dbg-tour-watch-window.png "Watch Window")

In this example, you have a watch set on the `File` object, and you can see it's value change as you move through the debugger. Unlike the other variable windows, the **Watch** windows always show the variables that you are watching (they're grayed out when out of scope).
    
> [!TIP]
> If you need to track the value of the variable even when it's out of scope, in C# you can right-click in the **Watch** windows and choose [Create an Object ID](https://docs.microsoft.com/en-us/visualstudio/debugger/watch-and-quickwatch-windows#bkmk_objectIds).

For more info, see [Set a Watch using the Watch and QuickWatch Windows](../debugger/watch-and-quickwatch-windows.md)

## Examine the call stack

Click the **Call Stack** window while you are debugging, which is by default open in the lower right pane.

![Examine the Call Stack](../debugger/media/dbg-tour-call-stack.png "ExamineCallStack")

The **Call Stack** window shows the order in which methods and functions are getting called. The top line shows the current function (the `Update` method in the this example). The second line shows that `Update` was called from the `Path.set` property, and so on. The call stack is a good way to examine and understand the execution flow of an app.

>  [!NOTE]
> The **Call Stack** window is similar to the Debug perspective in some IDEs like Eclipse.

You can double-click a line of code to go look at that source code (without advancing the debugger) and that also changes the current scope being inspected by the debugger.

You can also use right-click menus from the **Call Stack** window to do things like insert breakpoints into specified functions, restart your app using **Run to Cursor**, and to go examine source code. See [How to: Examine the Call Stack](../debugger/how-to-use-the-call-stack-window.md)

## Change the execution flow

With the debugger paused on a line of code, use the mouse to grab the yellow arrow pointer on the left and move the yellow arrow pointer to a different point in the code execution path. Then you use F5 or a step command to continue running the app.

![Move the Execution Pointer](../debugger/media/dbg-tour-move-the-execution-pointer.gif "Move the Execution Pointer")

By changing the execution flow, you can do things like test different code execution paths or simply re-run code without restarting the debugger.

> [!WARNING]
> Often you need to be careful with this feature, and you see a warning in the tooltip. You may see other warnings, too. Moving the pointer does not undo any changes to the state of your application.

## Examine an exception

When your app throws an exception, the debugger takes you to the line of code that threw the exception.
     
![Exception Helper](../debugger/media/dbg-tour-exception-helper.png "Exception Helper")

In this example, the **Exception Helper** shows you a `System.Argument` exception and an error message that says that the path is not a legal form. So, we know the error occurred on a method or function argument.

In this example, the `DirectoryInfo` call gave the error on the empty string stored in the `value` variable.

The Exception Helper is a great feature that can help you debug errors. You can also do things like view error details and add a watch from the Exception Helper. Or, if needed, you can change conditions for throwing the particular exception.

>  [!NOTE] 
> The Exception Helper replaces the Exception Assistant in [!include[vs_dev15](../misc/includes/vs_dev15_md.md)].

Expand the **Exception Settings** node to see more options on how to handle this exception type, but you don't need to change anything for this tour!

## More features to look at

-   [Edit and Continue](../debugger/edit-and-continue.md) For a subset of languages (C#, C++, Visual Basic), the Edit and Continue feature allows you to edit code in the middle of a debugging session if you find something you want to change.

-   [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md) Describes how to debug multithreaded applications. 

-   [Remote Debugging](../debugger/remote-debugging.md) Describes how to debug apps running on other machines or devices. 
  
-   [IntelliTrace](../debugger/intellitrace.md) Describes the IntelliTrace feature in Visual Studio Enterprise. You can use it to record and trace your code's execution history.

-   [Network Usage](../profiling/network-usage.md) Describes a profiling tool that you can use to debug web services and other network resources in Universal Windows Apps (UWP). Use the tool to examine payloads.

-   [Debug Interface Access SDK](../debugger/debug-interface-access/debug-interface-access-sdk.md) Describes the Microsoft Debug Interface Access Software Development Kit (DIA SDK). The DIA SDK provides access to debug information stored in program database (.pdb) files generated by Microsoft postcompiler tools.  

## See Also  
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)