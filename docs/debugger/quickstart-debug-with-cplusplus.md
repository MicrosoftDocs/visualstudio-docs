---
title: Debug C++ Code, Set Breakpoints, Inspect Variables
description: Debug native C++ code by using the Visual Studio debugger, create a project, set breakpoints, inspect variables, and edit code while debugging.
ms.date: 05/28/2026
ms.topic: quickstart
helpviewer_keywords:
  - "debugger"
author: mikejo5000
ms.author: mikejo

ms.subservice: debug-diagnostics
# customer intent: As a developer, I want to debug C++ apps in the Visual Studio debugger, so I can work with features that help me debug my code.
---

# Quickstart: Debug with C++ using the Visual Studio debugger

In this Quickstart, you explore how to use the Visual Studio debugger to you debug your native C++ code. This article provides a quick way to learn some of the basic features for working in the debugger.

If you don't have Visual Studio, you can install the [free trial version](https://visualstudio.microsoft.com/downloads/) from the Visual Studio Downloads page.

## Create a new project

Start by creating a new project, so you have some code to check in the debugger.

1. Open Visual Studio and create a new project.

   - If the **Start Window** isn't open, select **File** > **Start Window**.
   
   - In the Start Window, select **Create a new project**.

1. In the **Create a new project** window, set the filters and search for a project template.

   <a name="select-empty-project-template"></a>

   - In the **Search for templates** box, enter **empty**.

   - Expand the **Language** dropdown and select **C++**.

1. In the list of results, select the **Empty Project** template for C++, and then select **Next**.

   If you don't see the **Empty Project** template for C++, select the **Continue without code** option.
   
   1. Select **Tools** > **Get Tools and Features...**, which opens the Visual Studio Installer.
   
   1. In the Installer window, select the checkbox for the **Desktop development with C++** workload, and then select **Modify**.

       Your Visual Studio installation updates to include the selected C++ workload.
   
   1. After the update completes, select **File** > **Start Window**, and follow [the previous instructions](#select-empty-project-template) to select the required template.

1. Configure the new project:

   1. Enter a **Project name** and **Solution name**, or use the default values.

   1. Use the default **Location** or select browse (**...**) to create the project in a different folder.

   1. Select **Create**.

   Visual Studio creates your new project and adds the project files in the specified folder.

### Add a project file

Add a code file so you have content to test in the debugger.

1. In the **Solution Explorer** pane, right-click your *\<project-name>* and select **Add** > **New Item**.

   If you don't see the **Solution Explorer** pane, select **View** > **Solution Explorer**.

1. In the **Add new item** dialog, enter the file name **MyDbgApp.cpp**, and then select **Add**. 

   The file opens in the code editor.

1. Add the following code to the new file.

    ```cpp
    #include <list>
    #include <iostream>

    using namespace std;

    void doWork() {
        list <int> c1;

        c1.push_back(10);
        c1.push_back(20);

        const list <int> c2 = c1;
        const int &i = c2.front();
        const int &j = c2.front();
        cout << "The first element is " << i << endl;
        cout << "The second element is " << j << endl;
    }

    int main() {
        doWork();
    }
    ```

1. Save your file changes with the **Ctrl**+**S** keyboard shortcut.

## Set a breakpoint

A *breakpoint* is a marker that indicates where Visual Studio should suspend your running code. When a breakpoint is set, you can take a look at the current values of variables, examine the behavior of memory, and check if a specific branch of code is running. Breakpoints are the most basic feature in debugging.

1. To set a breakpoint, locate the call to the `doWork()` function in the code, and then select in the left gutter on the same line.

   When the breakpoint is set, a red dot displays in the left gutter on the corresponding line in the code.

   ::: moniker range="visualstudio"

   :::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-set-breakpoint-cpp.png" border="false" alt-text="Screenshot that shows how to set a breakpoint in the Visual Studio debugger.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../debugger/media/dbg-qs-set-breakpoint.png" alt-text="Screenshot that shows how to set a breakpoint in the Visual Studio 2022 debugger.":::

   ::: moniker-end

1. Start debugging by using the **F5** keyboard shortcut (or select **Debug** > **Start Debugging**).

   ::: moniker range="visualstudio"

   :::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-hit-breakpoint-cpp.png" border="false" alt-text="Screenshot that shows the debugger paused on a set breakpoint in Visual Studio.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../debugger/media/dbg-qs-hit-breakpoint.png" alt-text="Screenshot that shows the debugger paused on a set breakpoint in Visual Studio 2022.":::

   ::: moniker-end

   Code execution pauses immediately before the call to the `doWork()` function.
   
   The debugger pauses where you set the breakpoint. A yellow arrow identifies the statement where the debugger pauses app execution. 

   > [!TIP]
   > When you're debugging memory-related failures in your C++ code, you can also use breakpoints to inspect address values (look for `NULL`) and reference counts.

### Set conditional breakpoints

If you set a breakpoint in a loop or recursion, or if you have many breakpoints that you frequently step through, use a [conditional breakpoint](../debugger/using-breakpoints.md#BKMK_Specify_a_breakpoint_condition_using_a_code_expression).

This approach helps ensure your code is suspended **only** when specific conditions are met. A conditional breakpoint can save time and also make it easier to debug issues that are hard to reproduce.

## Walk through your code

Visual Studio provides several different ways for instructing the debugger to continue with app execution. The following example shows a useful command for walking through your code.

::: moniker range="visualstudio"

While the code is paused at the breakpoint, hover over the statement `c1.push_back(20)` until you see the green **Run to click** (_Run execution to here_) :::image type="icon" source="../debugger/media/visualstudio/debugger-run-to-click.png"::: icon. Select the icon.

:::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-run-to-click-cpp.png" border="false" alt-text="Screenshot that shows how to work with the Run to click action in the Visual Studio debugger.":::

::: moniker-end
::: moniker range="<=vs-2022"

While the code is paused at the breakpoint, hover over the statement `c1.AddLast(20)` until you see the green **Run to click** (_Run execution to here_) :::image type="icon" source="../debugger/media/dbg-tour-run-to-click.png"::: icon. Select the icon.

:::image type="content" source="../debugger/media/dbg-qs-run-to-click.png" alt-text="Screenshot that shows how to work with the Run to click action in the Visual Studio 2022 debugger.":::

::: moniker-end

The app continues execution, calling `doWork`, and pauses on the line of code where you selected **Run to click**.

Common keyboard commands used to step through code include **F10** and **F11**. For more in-depth instructions, see [Overview of the Visual Studio debugger](../debugger/debugger-feature-tour.md).

## Inspect variables in a data tip

You can inspect the state of your variables by using the **data tip** feature.

1. In the current line of code (marked by the yellow execution pointer), hover over the `c1` object to see the data tip.

   ::: moniker range="visualstudio"

   :::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-data-tip-cpp.png" border="false" alt-text="Screenshot that shows how to view data tips for code variables in the Visual Studio debugger.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../debugger/media/dbg-qs-data-tip.png" alt-text="Screenshot that shows how to view data tips for code variables in the Visual Studio 2022 debugger.":::

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

1. Select the second instance of the `c2.front()` statement, and change the code to `c2.back()`.

1. Select **F10** a few times (or select **Debug** > **Step Over** a few times) to advance the debugger and execute the edited code.

   :::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-hot-reload-cpp.gif" border="false" alt-text="Animation that shows how to edit and continue with the 'Hot Reload' feature in the Visual Studio debugger.":::

   **F10** advances the debugger one statement at a time, but steps over functions instead of stepping into them (the code that you skip still executes).

For more information about the feature and limitations, see [Configure Hot Reload](/visualstudio/debugger/how-to-enable-and-disable-edit-and-continue).

::: moniker-end
::: moniker range="<=vs-2022"

## Edit code and continue debugging

While you're debugging, if you see a change that you want to test in your code, you can use the **Edit and Continue** feature.

1. Select the second instance of the `c2.front()` statement, and change the code to `c2.back()`.

1. Select **F10** a few times (or select **Debug** > **Step Over** a few times) to advance the debugger and execute the edited code.

   :::image type="content" source="../debugger/media/dbg-qs-edit-and-continue.gif" alt-text="Animation that shows how to edit and continue in the Visual Studio 2022 debugger.":::

   **F10** advances the debugger one statement at a time, but steps over functions instead of stepping into them (the code that you skip still executes).

For more information on using edit-and-continue and feature limitations, see [Edit and Continue (Hot Reload)](/visualstudio/debugger/how-to-enable-and-disable-edit-and-continue).

::: moniker-end

## Next step

> [!div class="nextstepaction"]
> [Overview of the Visual Studio debugger](../debugger/debugger-feature-tour.md)
