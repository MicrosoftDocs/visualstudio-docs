---
title: Debug Managed Code in the Visual Studio Debugger
description: Explore how to debug C# or Visual Basic code by using the Visual Studio debugger, start the debugger, step through code, and inspect variables.
ms.date: 05/28/2026
ms.topic: quickstart
helpviewer_keywords:
  - "debugger"
author: mikejo5000
ms.author: mikejo

ms.subservice: debug-diagnostics
# customer intent: As a developer, I want to debug C# or Visual Basic apps in the Visual Studio debugger, so I can work with features that help me debug my code.
---

# Quickstart: Debug with C# or Visual Basic using the Visual Studio debugger

In this Quickstart, you explore how to use the Visual Studio debugger to you debug your C# or Visual Basic apps. This article provides a quick way to learn some of the basic features for working in the debugger.

If you don't have Visual Studio, you can install the [free trial version](https://visualstudio.microsoft.com/downloads/) from the Visual Studio Downloads page.

## Create a new project

Start by creating a new project, so you have some code to check in the debugger. This example creates a C# project for .NET.

1. Open Visual Studio and create a new project.

   - If the **Start Window** isn't open, select **File** > **Start Window**.
   
   - In the Start Window, select **Create a new project**.

1. In the **Create a new project** window, set the filters and search for a project template.

   <a name="select-console-app-template"></a>

   - In the **Search for templates** box, enter **console**.

   - Expand the **Language** dropdown and select **C#**.
   
   - Expand the **Platform** dropdown list and select **Windows**.

1. In the list of results, select the **Console App** template, and then select **Next**.

   If you don't see the **Console App** project template, select the **Continue without code** option.
   
   1. Select **Tools** > **Get Tools and Features...**, which opens the Visual Studio Installer.
   
   1. In the Installer window, select the checkbox for the **.NET desktop development** workload, and then select **Modify**.

       Your Visual Studio installation updates to include the selected .NET workload.
   
   1. After the update completes, select **File** > **Start Window**, and follow [the previous instructions](#select-console-app-template) to select the required template.

1. Configure the new project:

   1. Enter a **Project name** and **Solution name**, or use the default values.

   1. Use the default **Location** or select browse (**...**) to create the project in a different folder.

   1. Select **Next**.

   1. Use the recommended target **Framework** (the default is **.NET 10.0 Long Term Support**).

   1. Select **Create**.

   Visual Studio creates your new project and adds the project files in the specified folder.

### Update the project code

Update some of the code supplied by the project template so you have more statements to test in the debugger.

1. In the **Solution Explorer** pane, select the *Program.cs* item.

   The *Program.cs* file opens in the code editor. (If you're working in Visual Basic, select the *Module1.vb* item.) 

1. Replace the file contents with the following code.

   ### [C#](#tab/csharp)

   ```csharp
    internal class Program
    {
        private static void doWork()
        {
            LinkedList<int> c1 = new LinkedList<int>();

            c1.AddLast(10);
            c1.AddLast(20);

            LinkedList<int> c2 = new LinkedList<int>(c1);
            int i = c2.First.Value;
            int j = c2.First.Value;
            Console.Write("The first element is ");
            Console.Write(i);
            Console.Write("\n");
            Console.Write("The second element is ");
            Console.Write(j);
            Console.Write("\n");

        }

        static int Main()
        {
            // using namespace std;
            doWork();
            return 0;

        }
    }
   ```

   Save your changes with the **Ctrl**+**S** keyboard shortcut.

   ### [Visual Basic](#tab/vb)

   ```vb
    Imports System.Collections.Generic

    Namespace MyDbgApp
        Class Program
            Private Shared Sub doWork()
                Dim c1 As New LinkedList(Of Integer)()

                c1.AddLast(10)
                c1.AddLast(20)

                Dim c2 As New LinkedList(Of Integer)(c1)
                Dim i As Integer = c2.First.Value
                Dim j As Integer = c2.First.Value
                Console.Write("The first element is ")
                Console.Write(i)
                Console.Write(vbLf)
                Console.Write("The second element is ")
                Console.Write(j)
                Console.Write(vbLf)

            End Sub

            Public Shared Function Main() As Integer
                ' using namespace std;
                doWork()
                Return 0

            End Function
        End Class
    End Namespace
   ```

   Save your changes with the **Ctrl**+**S** keyboard shortcut.

   Make sure the startup object for the project is set to use the `Main` definition:
    
   1. Select **Project** > **_\<project name>_ Properties**.
    
   1. In the **Properties** pane, select the **Application** tab.
    
   1. Set the **Startup object** option to **Sub Main**.

   ---

## Set a breakpoint

A *breakpoint* is a marker that indicates where Visual Studio should suspend your running code. When a breakpoint is set, you can take a look at the current values of variables, examine the behavior of memory, and check if a specific branch of code is running. Breakpoints are the most basic feature in debugging.

1. To set a breakpoint, locate the call to the `doWork()` function in the code, and then select in the left gutter on the same line.

   When the breakpoint is set, a red dot displays in the left gutter on the corresponding line in the code.

   ::: moniker range="visualstudio"

   :::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-set-breakpoint-csharp.png" border="false" alt-text="Screenshot that shows how to set a breakpoint in the Visual Studio debugger.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../debugger/media/dbg-qs-set-breakpoint-csharp.png" alt-text="Screenshot that shows how to set a breakpoint in the Visual Studio 2022 debugger.":::

   ::: moniker-end

1. Start debugging by using the **F5** keyboard shortcut (or select **Debug** > **Start Debugging**).

   ::: moniker range="visualstudio"

   :::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-hit-breakpoint-csharp.png" border="false" alt-text="Screenshot that shows the debugger paused on a set breakpoint in Visual Studio.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../debugger/media/dbg-qs-hit-breakpoint-csharp.png" alt-text="Screenshot that shows the debugger paused on a set breakpoint in Visual Studio 2022.":::

   ::: moniker-end

   Code execution pauses immediately before the call to the `doWork()` function.
   
   The debugger pauses where you set the breakpoint. A yellow arrow identifies the statement where the debugger pauses app execution. 

### Set conditional breakpoints

If you set a breakpoint in a loop or recursion, or if you have many breakpoints that you frequently step through, use a [conditional breakpoint](../debugger/using-breakpoints.md#BKMK_Specify_a_breakpoint_condition_using_a_code_expression).

This approach helps ensure your code is suspended **only** when specific conditions are met. A conditional breakpoint can save time and also make it easier to debug issues that are hard to reproduce.

## Walk through your code

Visual Studio provides several different ways for instructing the debugger to continue with app execution. The following example shows a useful command for walking through your code.

::: moniker range="visualstudio"

While the code is paused at the breakpoint, hover over the statement `c1.AddLast(20)` until you see the green **Run to click** (_Run execution to here_) :::image type="icon" source="../debugger/media/visualstudio/debugger-run-to-click.png"::: icon. Select the icon.

:::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-run-to-click-csharp.png" border="false" alt-text="Screenshot that shows how to work with the Run to click action in the Visual Studio debugger.":::

::: moniker-end
::: moniker range="<=vs-2022"

While the code is paused at the breakpoint, hover over the statement `c1.AddLast(20)` until you see the green **Run to click** (_Run execution to here_) :::image type="icon" source="../debugger/media/dbg-tour-run-to-click.png"::: icon. Select the icon.

:::image type="content" source="../debugger/media/dbg-qs-run-to-click-csharp.png" alt-text="Screenshot that shows how to work with the Run to click action in the Visual Studio 2022 debugger.":::

::: moniker-end

The app continues execution, calling `doWork`, and pauses on the line of code where you selected **Run to click**.

Common keyboard commands used to step through code include **F10** and **F11**. For more in-depth instructions, see [Overview of the Visual Studio debugger](../debugger/debugger-feature-tour.md).

## Inspect variables in a data tip

You can inspect the state of your variables by using the **data tip** feature.

1. In the current line of code (marked by the yellow execution pointer), hover over the `c1` object to see the data tip.

   ::: moniker range="visualstudio"

   :::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-data-tip-csharp.png" border="false" alt-text="Screenshot that shows how to view data tips for code variables in the Visual Studio debugger.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../debugger/media/dbg-qs-data-tip-csharp.png" alt-text="Screenshot that shows how to view data tips for code variables in the Visual Studio 2022 debugger.":::

   ::: moniker-end

   The data tip shows you the current value of the `c1` variable and allows you to inspect its properties.
   
   When you're debugging, if you see an unexpected value for a variable, you probably have a bug. The bug could be in the code that makes the call to the variable or in the previous line.

1. Expand the data tip to look at the current property values of the `c1` object.

1. To continue checking the value of `c1` as the code executes, select the **pin** :::image type="icon" source="../debugger/media/debugger-pin-data-tip.png"::: icon on the data tip.

   The **pin** action keeps the data tip open. As the code executes, the value in the pinned tip changes to show the current state of the watched object.

   You can move the pinned tip to any location in the IDE, so it doesn't prevent you watching other items while debugging.

::: moniker range="visualstudio"

## Enable hot reload while debugging

While you're debugging, if you see a change that you want to test in your code, you can use the **Hot Reload** feature (previously called _Edit and Continue_).

1. Select the second instance of the `c2.First.Value` statement, and change the code to `c2.Last.Value`.

1. Select **F10** a few times (or select **Debug** > **Step Over** a few times) to advance the debugger and execute the edited code.

   :::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-hot-reload-csharp.gif" border="false" alt-text="Animation that shows how to edit and continue with the 'Hot Reload' feature in the Visual Studio debugger.":::

   **F10** advances the debugger one statement at a time, but steps over functions instead of stepping into them (the code that you skip still executes).

For more information about the feature and limitations, see [Configure Hot Reload](/visualstudio/debugger/how-to-enable-and-disable-edit-and-continue).

::: moniker-end
::: moniker range="<=vs-2022"

## Edit code and continue debugging

While you're debugging, if you see a change that you want to test in your code, you can use the **Edit and Continue** feature.

1. Select the second instance of the `c2.First.Value` statement, and change the code to `c2.Last.Value`.

1. Select **F10** a few times (or select **Debug** > **Step Over** a few times) to advance the debugger and execute the edited code.

   :::image type="content" source="../debugger/media/dbg-qs-edit-and-continue-csharp.gif" alt-text="Animation that shows how to edit and continue in the Visual Studio 2022 debugger.":::

   **F10** advances the debugger one statement at a time, but steps over functions instead of stepping into them (the code that you skip still executes).

For more information on using edit-and-continue and feature limitations, see [Edit and Continue (Hot Reload)](/visualstudio/debugger/how-to-enable-and-disable-edit-and-continue).

::: moniker-end

## Next step

> [!div class="nextstepaction"]
> [Overview of the Visual Studio debugger](../debugger/debugger-feature-tour.md)
