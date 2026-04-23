---
title: "Tutorial: Debug C# code and inspect data"
description: Learn features of the Visual Studio debugger and how to start the debugger, step through code, and inspect data in a C# application.
ms.date: 02/11/2026
ms.subservice: debug-diagnostics
ms.topic: tutorial
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "debugger"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.update-cycle: 90-days

#customer intent: As a developer, I want to understand the basics of debugging using Visual Studio.
---
# Tutorial: Learn to debug C# code using Visual Studio

This article introduces the features of the Visual Studio debugger in a step-by-step walkthrough. When you *debug your app*, it usually means that you're running your application with the debugger attached. When you do this task, the debugger provides many ways to see what your code is doing while it runs. You can step through your code and look at the values stored in variables. You can set watches on variables to see when values change. You can examine the execution path of your code to see whether a branch of code is running.

If this article is the first time that you try to debug code, see [Debug for absolute beginners](../../debugger/debugging-absolute-beginners.md). If you want a higher-level view of the debugger features, see [Overview of the Visual Studio debugger](../../debugger/debugger-feature-tour.md).

Although the demo app is C#, most of the features are applicable to C++, Visual Basic, F#, Python, JavaScript, and other languages supported by Visual Studio. F# doesn't support Edit-and-continue. F# and JavaScript don't support the **Autos** window. The screenshots are in C#.

In this tutorial, you will:

> [!div class="checklist"]
> - Start the debugger and hit breakpoints
> - Learn commands to step through code in the debugger
> - Inspect variables in data tips and debugger windows
> - Examine the call stack

## Prerequisites

You must have Visual Studio installed and the **.NET desktop development** workload.

If you need to install Visual Studio, get it for free at [Visual Studio downloads](https://aka.ms/vs/download/?cid=learn-onpage-download-cta).

If you already have Visual Studio but the **.NET desktop development** workload isn't installed, go to **Tools** > **Get Tools and Features...**. In the Visual Studio Installer, choose the **.NET desktop development** workload, then choose **Modify**.

## Create a project

First, create a C#/.NET console app project. The project template includes all the files you need before you add anything.

::: moniker range=">=visualstudio"

1. Open Visual Studio. If the start window isn't open, select **File** > **Start Window**.

1. On the start window, select **Create a new project**.

1. On the **Create a new project** window, enter *console* in the search box. Next, choose **C#** from the Language list, and then choose **Windows** from the Platform list. 

   After you apply the language and platform filters, choose the **Console App** template, and then select **Next**.

   :::image type="content" source="media/visualstudio/csharp-get-started-create-console-project.png" alt-text="Screenshot of the 'Console Application' template in the 'Create a new project' window of Visual Studio.":::

   > [!NOTE]
   > If you don't see the **Console App** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, choose the **Install more tools and features** link. Then, in the Visual Studio Installer, choose the **.NET desktop development** workload.

1. In the **Configure your new project** window, enter *GetStartedDebugging* in the **Project name** box. Then, select **Next**.

1. In the **Additional information** window, ensure **.NET 10.0** is selected in the **Framework** dropdown menu, and then select **Create**.

::: moniker-end

::: moniker range="=vs-2022"

1. Open Visual Studio. If the start window isn't open, select **File** > **Start Window**.

1. On the start window, select **Create a new project**.

1. On the **Create a new project** window, enter *console* in the search box. Next, choose **C#** from the Language list, and then choose **Windows** from the Platform list. 

   After you apply the language and platform filters, choose the **Console App** template, and then select **Next**.

   :::image type="content" source="media/vs-2022/get-started-create-console-project.png" alt-text="Screenshot of the 'Console Application' template in the 'Create a new project' window of Visual Studio 2022.":::

   > [!NOTE]
   > If you don't see the **Console App** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, choose the **Install more tools and features** link. Then, in the Visual Studio Installer, choose the **.NET desktop development** workload.

1. In the **Configure your new project** window, enter *GetStartedDebugging* in the **Project name** box. Then, select **Next**.

1. In the **Additional information** window, ensure **.NET 8.0** is selected in the **Framework** dropdown menu, and then select **Create**.

::: moniker-end

Visual Studio opens your new project.

## Create the application

In *Program.cs*, replace all of the default code with the following code:

```csharp
using System;

class ArrayExample
{
   static void Main()
   {
      char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h'};
      string name = "";
      int[] a = new int[10];
      for (int i = 0; i < letters.Length; i++)
      {
         name += letters[i];
         a[i] = i + 1;
         SendMessage(name, a[i]);
      }
      Console.ReadKey();
   }

   static void SendMessage(string name, int msg)
   {
      Console.WriteLine("Hello, " + name + "! Count to " + msg);
   }
}
```

## Start the debugger!


::: moniker range=">=vs-2022"

Mostly, this article uses keyboard shortcuts. It's a fast way to execute debugger commands. Equivalent commands, such as toolbar or menu commands, are also available.

1. To start the debugger, select **F5**, or choose the **Debug Target** button in the Standard toolbar, or choose the **Start Debugging** button in the Debug toolbar, or choose **Debug** > **Start Debugging** from the menu bar.

   :::image type="content" source="media/vs-2022/dbg-tour-start-debugging.png" alt-text="Screenshot of the Debug Target button in the Standard toolbar of Visual Studio 2022.":::

   **F5** starts the app with the debugger attached to the app process. Since you started debugging, the app runs to completion and you see the console output.

   ```cmd
   Hello, f! Count to 1
   Hello, fr! Count to 2
   Hello, fre! Count to 3
   Hello, fred! Count to 4
   Hello, fred ! Count to 5
   Hello, fred s! Count to 6
   Hello, fred sm! Count to 7
   Hello, fred smi! Count to 8
   Hello, fred smit! Count to 9
   Hello, fred smith! Count to 10
   ```

1. To stop the debugger, select **Shift+F5**, or choose the **Stop Debugging** button in the Debug toolbar, or choose **Debug** > **Stop Debugging** from the menu bar.

   :::image type="content" source="media/vs-2022/dbg-tour-stop-debugging.png" alt-text="Screenshot of the Stop debugging button in the Debug toolbar of Visual Studio 2022.":::

1. In the console window, select any key to close the console window.

::: moniker-end

## Set a breakpoint and start the debugger

::: moniker range=">=vs-2022"

1. In the `for` loop of the `Main` function, set a breakpoint by clicking in the left margin on the following line of code:

   `name += letters[i];`

   A red circle appears where you set the breakpoint.

   :::image type="content" source="media/vs-2022/dbg-tour-breakpoint.png" alt-text="Screenshot of a breakpoint in Visual Studio 2022."::: 

   Breakpoints are an essential feature of reliable debugging. You can set breakpoints where you want Visual Studio to pause your running code. You can look at the values of variables or the behavior of memory or find out whether a branch of code runs.

1. To start debugging, select **F5**, or choose the **Debug Target** button in the Standard toolbar, or choose the **Start Debugging** button in the Debug toolbar, or choose **Debug** > **Start Debugging** from the menu bar. The app starts and the debugger runs to the line of code where you set the breakpoint.

   :::image type="content" source="media/vs-2022/get-started-set-breakpoint.png" alt-text="Screenshot showing a breakpoint in the code editor of Visual Studio 2022, with code execution paused at the breakpoint.":::

   The yellow arrow points to the statement on which the debugger paused. App execution pauses at the same point, with the statement not yet executed.

   When the app isn't running, **F5** starts the debugger, which runs the app until it reaches the first breakpoint. If the app is paused at a breakpoint, then **F5** continues running the app until it reaches the next breakpoint.

   Breakpoints are a useful feature when you know the line or section of code that you want to examine in detail. For more about the different types of breakpoints you can set, such as conditional breakpoints, see [Use the right type of breakpoint](../../debugger/using-breakpoints.md).

::: moniker-end

## Navigate code and inspect data by using data tips

::: moniker range=">=vs-2022"

1. While code execution is paused on the `name += letters[i]` statement, hover over the `letters` variable to see a data tip showing the array size and element type, `char[10]`.

   > [!NOTE]
   > One of the most useful features of the debugger is its ability to inspect a variable. Often, when you're trying to debug an issue, you're attempting to find out whether variables have values that you expect at a particular time. Viewing data tips is a good way to check that.

1. Expand the `letters` variable to view all its array elements and their values.

   :::image type="content" source="media/vs-2022/get-started-view-data-tip.png" alt-text="Screenshot of a debugger data tip in Visual Studio 2022 that shows the element values for the 'letters' array variable.":::

1. Hover over the `name` variable to see its current value, which is an empty string.

1. To advance the debugger to the next statement, select **F10**, or choose the **Step Over** button in the Debug toolbar, or choose **Debug** > **Step Over** from the menu bar. Select **F10** twice more to move past the `SendMessage` method call. 

   **F10** advances the debugger without stepping into function or methods, although their code still executes. In this way, you skipped debugging the code in the `SendMessage` method, which isn't relevant right now.

1. To iterate through the `for` loop a few times, select **F10** repeatedly. During each loop iteration, pause at the breakpoint, and then hover over the `name` variable to check its value in the data tip.

   :::image type="content" source="media/vs-2022/get-started-data-tip.png" alt-text="Screenshot of a debugger data tip in Visual Studio 2022 that shows the string value for the 'name' variable.":::

   The value of the variable changes with each iteration of the `for` loop, showing values of `f`, then `fr`, then `fre`, and so on. To advance the debugger through the loop faster, select **F5** instead, which advances to your breakpoint instead of the next statement.

1. While code execution is paused in the `for` loop of the `Main` method, select **F11**, or choose the **Step Into** button from the Debug toolbar, or choose **Debug** > **Step Into** from the menu bar, until you reach the `SendMessage` method call.

   The debugger should be paused at this line of code:

   `SendMessage(name, a[i]);`

1. To step into the `SendMessage` method, select **F11** again.

   The yellow pointer advances into the `SendMessage` method.

   :::image type="content" source="media/vs-2022/get-started-f11.png" alt-text="Screenshot showing the execution pointer of the debugger within the 'SendMessage' method.":::

   **F11** helps you examine the execution flow of your code in more depth. To step into a method from a method call, select **F11**. By default, the debugger skips stepping into nonuser methods. To learn about debugging nonuser code, see [Just My Code](../../debugger/just-my-code.md).

   After you finish debugging the `SendMessage` method, you're ready to return to the `for` loop of the `main` method.

1. To leave the `SendMessage` method, select **Shift+F11**, or choose the **Step Out** button in the Debug toolbar, or choose **Debug** > **Step Out** from the menu bar.

   **Step Out** resumes app execution and advances the debugger until the current method or function returns.

   You see the yellow pointer back in the `for` loop of the `Main` method, paused at the `SendMessage` method call. For more information on different ways to move through your code, see [Navigate code in the debugger](../../debugger/navigating-through-code-with-the-debugger.md).

::: moniker-end

## Navigate code using Run to Click

::: moniker range=">=vs-2022"

1. Select **F5** to advance to the breakpoint again.

1. In the code editor, hover over the `Console.WriteLine` method call in the `SendMessage` method until the **Run to Click** button appears. The tooltip for the button shows "Run execution to here."

   :::image type="content" source="media/vs-2022/get-started-run-to-click.png" alt-text="Screenshot showing the Run to Click button in Visual Studio 2022.":::

1. Choose the **Run to Click** button. Alternatively, with your cursor at the `Console.WriteLine` statement, select **Ctrl+F10**. Or, right-click the `Console.WriteLine` method call, and choose **Run to Cursor** from the context menu.

   The debugger advances to the `Console.WriteLine` method call.

   Using the **Run to Click** button is similar to setting a temporary breakpoint. This approach is handy for getting around quickly within a visible region of your app code in an open file.

::: moniker-end

## Restart your app quickly


::: moniker range=">=vs-2022"

To rerun your app from the beginning in the debugger, select **Ctrl+Shift+F5**, or choose the **Restart** button in the Debug toolbar, or choose **Debug** > **Restart** from the menu bar.

:::image type="content" source="media/vs-2022/dbg-tour-restart-debugging.png" alt-text="Screenshot of the Restart button in the Debug toolbar of Visual Studio 2022.":::

**Restart** stops the debugger and then restarts it, in one step. When the debugger restarts, it runs to the first breakpoint, which is the breakpoint you previously set inside the `for` loop, and then pause.

::: moniker-end

## Inspect variables with the Autos and Locals windows

::: moniker range=">=vs-2022"

The **Autos** and **Locals** windows show variable values while you're debugging. The windows are only available during a debug session. The **Autos** window shows variables used on the current line that the debugger is at and the preceding line. The **Locals** window shows variables defined in the local scope, which is usually the current function or method.

1. While the debugger is paused, view the **Autos** window at the bottom of the code editor.

   If the **Autos** window is closed, select **Ctrl+D, A**, or choose **Debug** > **Windows** > **Autos** from the menu bar.

1. With the debugger still paused, view the **Locals** window, in a tab next to the **Autos** window.

   If the **Locals** window is closed, select **Ctrl+D, L**, or choose **Debug** > **Windows** > **Locals**.

1. In the **Locals** window, expand the `letters` variable to see its array elements and their values.

   :::image type="content" source="media/vs-2022/get-started-locals-window.png" alt-text="Screenshot of the Locals window in Visual Studio 2022, with the 'letters' array variable expanded.":::

For more about the **Autos** and **Locals** windows, see [Inspect variables and return values](/visualstudio/debugger/autos-and-locals-windows?view=vs-2022&preserve-view=true).

::: moniker-end

## Set a watch

::: moniker range=">=vs-2022"

You can specify a variable, or an expression, that you want to keep an eye on as you step through code by adding it to the **Watch** window.

1. While the debugger is paused, right-click the `name` variable and choose **Add Watch**.

   The **Watch** window opens, by default, at the bottom of the code editor.

1. After you set the watch on the `name` variable, step through your code to see the value of the `name` variable change with each `for` loop iteration. 

   Unlike the other variable windows, the **Watch** window always shows the variables that you're watching. Variables that are out of scope are displayed as unavailable.

For more information about the **Watch** window, see [Watch variables with Watch windows](/visualstudio/debugger/watch-and-quickwatch-windows?view=vs-2022&preserve-view=true).

::: moniker-end

## Examine the call stack

::: moniker range=">=vs-2022"

The **Call Stack** can help you understand the execution flow of your app. It shows the order in which methods and functions are getting called.

1. While the debugger is paused in the `for` loop, view the **Call Stack** window, which opens by default in the lower right pane of the code editor.

   If the **Call Stack** window is closed, select **Ctrl+D, C**, or choose  **Debug** > **Windows** > **Call Stack** from the menu bar.

   In the **Call Stack** window, you see the yellow pointer at the current `Main` method.

1. Select **F11** a few times until you see the debugger pause in the `SendMessage` method.

   The top line of the **Call Stack** window shows the current function, which is the `SendMessage` method. The second line shows that the `SendMessage` method was called from the `Main` method.

   :::image type="content" source="media/vs-2022/get-started-call-stack.png" alt-text="Screenshot of the Call Stack window in Visual Studio 2022.":::

   > [!NOTE]
   > The **Call Stack** window is similar to the Debug perspective in some IDEs, like Eclipse.

   In the **Call Stack** window, you can double-click a line of code to go to that source code, which changes the current scope under inspection by the debugger. This action doesn't advance the debugger.

   You can also use right-click menus from the **Call Stack** window to do other things. For example, you can insert breakpoints into specified functions, advance the debugger by using **Run to Cursor**, or go to source code. 

For more about the **Call Stack**, see [View the call stack](../../debugger/how-to-use-the-call-stack-window.md).

::: moniker-end

## Next step

In this tutorial, you learned how to start the debugger, step through code, and inspect variables. You might want to get a high-level look at debugger features along with links to more information.

> [!div class="nextstepaction"]
> [Overview of the Visual Studio debugger](../../debugger/debugger-feature-tour.md)
