---
title: "Tutorial: Debug C++ code"
description: Follow this tutorial to explore features of the Visual Studio debugger, start the debugger, step through code, and inspect data in a C++ application.
ms.date: 09/08/2025
ms.subservice: debug-diagnostics
ms.topic: tutorial
dev_langs:
  - "C++"
helpviewer_keywords:
  - "debugger"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.update-cycle: 90-days

#customer intent: As a developer, I want to use Visual Studio debugger features like stepping through my application code, viewing the call stack, setting command-line arguments, and inspecting data values.
---

# Tutorial: Debug C++ code with Visual Studio

In this tutorial, you debug a C++ application using the Visual Studio debugger. When you debug an application, you usually run your app with the debugger attached. The debugger provides many ways to examine what your code is doing during program execution. You can step through your code and look at values stored in variables and set watches on variables to see when values change. The debugger helps you examine the execution path of your code and confirm a branch of code is running.

In this tutorial, you:

> [!div class="checklist"]
> * Start the debugger and pause at breakpoints
> * Learn commands to step through code in the debugger
> * Inspect variables in data tips and debugger windows
> * Examine the call stack
> * Set command-line arguments for your application

If you're new to debugging, you might want to read [Debugging for absolute beginners](./debugging-absolute-beginners.md) before you start this tutorial. If you want a higher-level view of the debugger features, see [First look at the debugger](./debugger-feature-tour.md).

## Prerequisites

- Visual Studio 2022 **version 17.12** or later with the **Desktop development with C++** workload installed.

   ::: moniker range=">=vs-2022"

   - To install Visual Studio for free, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) page.

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   - To install Visual Studio for free, go to the [Release and Build History](/visualstudio/releases/2019/history) page to learn more.

   ::: moniker-end

   - If you already have Visual Studio, you can install the workload from within the Interactive Development Environment (IDE):
   
      1. Select **Tools** > **Get Tools and Features**.
      1. In the Visual Studio Installer, select the **Workloads** tab.
      1. Select the **Desktop development with C++** workload, and then select **Modify**.
      1. Follow the prompts and complete the installation.

- This tutorial uses a C++ demo application and the screenshots present C++ syntax. Most of the demonstrated features are also applicable to C#, Visual Basic, F#, Python, JavaScript, and other languages supported by Visual Studio. There are a few limitations to keep in mind:

   - **F#**: The **Edit-and-continue** feature isn't supported.
   - **F#** and **JavaScript**: The **Autos** window isn't supported.

## Create a project

Follow these steps to create a C++ console application project in Visual Studio. The project type provides all the template files you need to get started quickly:

1. In the Visual Studio **Start** window (**File** > **Start Window**), select **Create a new project**:

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Screenshot that shows how to select the Create a new project option in the Visual Studio Start window.":::

1. Set the **Language** filter to **C++** and set the **Platform** filter to **Windows**. 
1. In the **Search** box, enter _console_, and select the **Console App** template in the list of results:

   ::: moniker range=">= vs-2022"

   :::image type="content" source="media/vs-2022/get-started-create-console-project-cpp.png" alt-text="Screenshot that shows how to search for and select the Console App template in the Visual Studio 2022 Start window.":::

   ::: moniker-end
   ::: moniker range="vs-2019"

   :::image type="content" source="media/vs-2019/get-started-create-console-project-cpp.png" alt-text="Screenshot that shows how to search for and select the Console App template in the Visual Studio Start window.":::

   ::: moniker-end

   > [!NOTE]
   > If you don't see the **Console App** template, you can install it from the **Create a new project** window. Locate the **Not finding what you're looking for?** section that follows the search results and select **Install more tools and features**. In the Visual Studio Installer, select the **Desktop development with C++** workload and update your installation. For more information, see the [Prerequisites](#prerequisites) section.

1. Select **Next** to continue to the configuration page.
1. Enter `get-started-debugging` as the **Project name** and **Solution name** for your new app. Choose the default **Location** or browse to a different path in your environment.
1. Select **Create** to create the new Node.js project.

Visual Studio creates your new project and opens your project hierarchy in **Solution Explorer**. The `get-started-debugging.cpp` file is open in the code editor.

## Create the application

Create a new application for your project by editing the `get-started-debugging.cpp` file in the code editor.

Replace the default content provided by the template with the following code:

```cpp
#include <string>
#include <vector>
#include <iostream>

void SendMessage(const std::wstring& name, int msg)
{
   std::wcout << L"Hello, " << name << L"! Count to " << msg << std::endl;
}

int main()
{
   std::vector<wchar_t> letters = { L'f', L'r', L'e', L'd', L' ', L's', L'm', L'i', L't', L'h' };
   std::wstring name = L"";
   std::vector<int> a(10);
   std::wstring key = L"";

   for (int i = 0; i < letters.size(); i++)
   {
      name += letters[i];
      a[i] = i + 1;
      SendMessage(name, a[i]);
   }
   std::wcin >> key;
   return 0;
}
```

## Start the debugger

Now you're ready to start debugging your updated code:

1. Start the debugging session by selecting **F5** or **Debug > Start Debugging**. You can also select **Start Debugging** :::image type="icon" source="./media/dbg-tour-start-debugging.png"::: (solid green arrow icon) in the Debug toolbar.

   The **F5** keyboard shortcut starts the application with the debugger attached to the app process, but you don't yet have anything special to examine in the code. The app simply loads and you see the console output:

   ```console
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

   Later in the tutorial, you look more closely at this app in the debugger and explore other debugging features.

1. Halt the debugger by selecting **Stop** :::image type="icon" source="./media/dbg-tour-stop-debugging.png"::: (red square icon) in the Debug toolbar. You can also use the **Shift** + **F5** keyboard shortcut.
1. In the console window for the running application, select any key and then select **Enter** to close the window.

## Set a breakpoint and start the debugger

Try setting a breakpoint and pausing at the selected point in the debugger:

1. Return to the `get-started-debugging.cpp` file in the code editor, and locate the `for` loop of the `main` function:

   ```cpp
      for (int i = 0; i < letters.size(); i++)
      {
         name += letters[i];
         a[i] = i + 1;
         SendMessage(name, a[i]);
      }
   ```

1. Set a breakpoint on the line that contains the code statement `name += letters[i];` by selecting in the left gutter on the line for the statement. Visual Studio adds a red circle :::image type="icon" source="./media/dbg-breakpoint.png"::: in the gutter to indicate the set breakpoint.

   > [!TIP]
   > You can also place your cursor on a line of code and select **F9** to toggle the breakpoint for that line. 

   Breakpoints are one of the most basic and essential features of reliable debugging. A breakpoint indicates where you want Visual Studio to suspend your running code. When the execution is paused, you can take a look at the values of variables, examine the behavior of memory, or check if a branch of code is getting run.

1. Start your app in the debugger by selecting **F5** or **Start Debugging**.

   Visual Studio starts execution of your app. When the debugger reaches your set breakpoint, the debugging process pauses.
   
   Visual Studio adds a yellow arrow to the red breakpoint circle in the gutter to represent the code statement where the debugger is paused. Program execution is paused and the indicated statement is waiting to be processed.

   :::image type="content" source="./media/get-started-set-breakpoint-cpp.png" border="false" alt-text="Screenshot that shows the debugger paused on the set breakpoint in Visual Studio.":::

   > [!NOTE]
   > The **F5** action is relative to the current execution state of your application. If your app isn't running and you select **F5**, the debugger starts your app and continues execution until it reaches the first set breakpoint. This behavior maps to the **Debug** > **Start Debugging** command. If your app is already running and you select **F5**, app execution continues until the debugger reaches the next breakpoint or end of program. This behavior maps to the **Debug** > **Continue** command. 

Breakpoints are a useful feature when you know the line of code or section of code that you want to examine in detail. For information on the different types of breakpoints you can set, such as conditional breakpoints, see [Use the right type of breakpoint](./using-breakpoints.md).

## Step through your code in the debugger

A convenient way to browse your code in the debugger is to use **step commands**. These commands let you **Step Into**, **Step Over**, and **Step Out** of a section of code, and also **Step Backward** in app execution.

:::image type="content" source="./media/debugger-toolbar-step-commands.png" border="false" alt-text="Screenshot that shows the step commands in the debugger toolbar.":::

The following procedure highlights how to use keyboard shortcuts with step commands to quickly work through your code. (The equivalent menu actions are shown in parenthesis.)

1. Start your app in the debugger by selecting **F5** or **Start Debugging**.
1. While the debugger is paused in the `for` loop in the `main` function, select **F11** (**Debug > Step Into**) _twice_ to advance to the `SendMessage` method call.

   After you select **F11** twice, execution continues to the code statement `SendMessage(name, a[i]);`.

1. Select **F11** again to step into the `SendMessage` method.

   Notice that the yellow pointer advances into the `SendMessage` method:

   :::image type="content" source="./media/get-started-f11-cpp.png" border="false" alt-text="Screenshot that shows the debugger stepped into the SendMessage method and the yellow pointer indicating the pause location.":::

   The **F11** keyboard shortcut initiates the **Step Into** command, which advances app execution one statement at a time. It's a good way to examine the execution flow in the most detail. By default, the debugger skips over nonuser code. For more information, see [Just My Code](./just-my-code.md). Later in the tutorial, you learn ways to move faster through your code. 

1. After you examine the `SendMessage` method, you can continue debugging with the **Step Out** command. Select **Shift** + **F11** (**Debug > Step Out**).

   This command resumes app execution (and advances the debugger) until the current method or function returns.

   When the command completes, the debugger pauses in the `for` loop of the `main` method at the `SendMessage` method call.

1. Select **F11** several times until you return again to the `SendMessage` method call.
1. While the debugger is paused at the method call, select **F10** (**Debug > Step Over**).

   :::image type="content" source="./media/get-started-step-over-cpp.png" border="false" alt-text="Screenshot that shows the debugger stepped over the SendMessage method and the yellow pointer indicating the pause location.":::

   Notice this time that the debugger doesn't step into the `SendMessage` method. The **F10** shortcut advances the debugger without stepping into functions or methods in your app code (the code still executes). When you select **F10** on the `SendMessage` method call (instead of **F11**), you **Step Over** the implementation code for `SendMessage`. This approach is useful to move past code that you don't need to currently inspect. For more information on different ways to move through your code, see [Navigate code in the debugger](./navigating-through-code-with-the-debugger.md).

## Browse your code with Run to Click

Another way to work through your code in the debugger is with the **Run to Click** feature. This action is similar to setting a temporary breakpoint. 

Continue with your debugging session:

1. Select **F5** to advance to the breakpoint in your code.
1. In the code editor, scroll to the `SendMessage` method definition, and hover over the `std::wcout` function.

   Hover until the **Run to Click** :::image type="icon" source="./media/dbg-tour-run-to-click.png"::: (green arrow icon) appears to the left of the code statement. If you hover over the icon, you see the tooltip "Run execution to here":

   :::image type="content" source="./media/get-started-run-to-click-cpp.png" border="false" alt-text="Screenshot that shows the Run to Click feature and the action tooltip in the debugger.":::

1. Select **Run to Click** :::image type="icon" source="./media/dbg-tour-run-to-click.png":::.

   The debugger advances execution to the indicated position. In this example, the debugger reaches the call to the `std::wcout` function.

The **Run to Click** action is handy for getting around quickly within a visible region of app code. You can use the feature in any file open in the code editor.

## Restart your app quickly

Quickly restart your app by selecting **Restart** :::image type="icon" source="./media/dbg-tour-restart.png"::: (circular arrow icon) in the Debug Toolbar. You can also select **Debug > Restart** or use the **Ctrl** + **Shift** + **F5** keyboard shortcut.

The **Restart** feature is more efficient than stopping the app and starting the debugger again.

When you select **Restart**, the debugger pauses at the first breakpoint it encounters during execution. In this example, the debugger stops again at the breakpoint you set inside the `for` loop.

## Inspect variables with data tips

Features that help you inspect variables are one of the most useful benefits of working with the debugger. Often, when you're debugging an issue, you're trying to discover whether variables are storing expected values at particular times. Visual Studio provides several ways to help you complete this task.

Continue with your debugging session:

1. While the debugger is paused on the `name += letters[i]` statement, hover over the `letters` variable. Select the expand/collapse arrow to the left of the variable name and view its properties in the flyout menu.

   The **data tips** feature shows all the elements that the variable contains. Notice the default value, `size={10}`:

   :::image type="content" source="./media/vs-2022/debugger-inspect-letter-variable.gif" border="false" alt-text="Animation that shows how to inspect the properties and values for a variable in the debugger.":::

1. Next, hover over the `name` variable and notice its current value, an empty string (`""`).
1. Select **F5** (**Debug** > **Continue**) a few times to iterate several times through the `for` loop. Each time the debugger pauses at the breakpoint, hover over the `name` variable and check the current value:

   :::image type="content" source="./media/get-started-data-tip-cpp.png" border="false" alt-text="Screenshot that shows how to check the value of a variable by using hover to show the data tip in the debugger.":::

   The value of the variable changes with each iteration of the `for` loop, showing values of `f`, then `fr`, then `fre`, and so on.

## Inspect variables with the Autos and Locals windows

Another approach for inspecting variables and values is by using the **Autos** and **Locals** windows. By default, these windows appear below the code editor in the Visual Studio IDE while you're debugging your app:

:::image type="content" source="./media/vs-2022/debugger-autos-locals-windows.png" border="false" alt-text="Screenshot that shows the Autos and Locals windows below the code editor in the debugger during a debugging session.":::

1. Notice the **Autos** window below the code editor.

   If you don't see the window during your debugging session, select **Debug** > **Windows** > **Autos** to open the window.

   The **Autos** window shows all variables used on the current line or the preceding line along with their current value. Keep in mind that specific programming languages can demonstrate unique behavior for variables and properties. For more information, see the [Visual Studio Language Guidance](/visualstudio/index).

1. Next, take a look at the **Locals** window. By default, this window is aligned next to the **Autos** window.

   If you don't see the window during your debugging session, select **Debug** > **Windows** > **Locals** to open the window

1. In the **Locals** window, expand the `letters` variable to show the elements that it contains.

   ::: moniker range=">= vs-2022"

   :::image type="content" source="./media/vs-2022/get-started-locals-window-cpp.png" border="false" alt-text="Screenshot that shows how to inspect variables and values in the Locals window in Visual Studio 2022.":::

   ::: moniker-end
   ::: moniker range="vs-2019"

   :::image type="content" source="./media/get-started-locals-window-cpp.png" border="false" alt-text="Screenshot that shows how to inspect variables and values in the Locals window in Visual Studio.":::

   ::: moniker-end

   The **Locals** window shows you the variables that are in the current [scope](https://en.cppreference.com/w/cpp/language/scope), that is, the current execution context.

## Watch a variable

If you're interested in watching the behavior of a specific variable, you can set a **watch**:

In the code editor, right-click the `name` variable and select **Add Watch**. The **Watch** window opens below the code editor. You can use a **Watch** window to specify a variable (or an expression) that you want to track.

:::image type="content" source="./media/vs-2022/debugger-watch-window.png" border="false" alt-text="Screenshot that shows the Watch window showing values for the name variable in Visual Studio.":::

As you watch the `name` variable during app execution in the debugger, you can see its value change. Unlike the other variable windows, the **Watch** window always shows the variables that you're watching. When a watched variable isn't in scope, the variable name is dimmed.

## Examine the call stack

The **Call Stack** window in Visual Studio shows the order in which methods and functions are called. This window is similar to the Debug perspective in some IDEs like Eclipse. By default, the call stack is visible in the lower right pane during the debugging session below the code editor.

1. While the debugger is paused in the `for` loop, select the **Call Stack** window to see the current calling structure.

   If you don't see the window during your debugging session, select **Debug** > **Windows** > **Call Stack** to open the window.

1. Select **F11** (**Debug** > **Step Into**) a few times until you see the debugger pause in the `SendMessage` method.
1. Look at the **Call Stack** window again:

   ::: moniker range=">= vs-2022"

   :::image type="content" source="./media/vs-2022/get-started-call-stack-cpp.png" border="false" alt-text="Screenshot that shows how to examine the call stack in Visual Studio 2022.":::

   ::: moniker-end
   ::: moniker range="vs-2019"

   :::image type="content" source="./media/get-started-call-stack-cpp.png" border="false" alt-text="Screenshot that shows how to examine the call stack in Visual Studio.":::

   ::: moniker-end

   In the **Call Stack** window, the top line shows the current function (the `SendMessage` method in this app). The second line shows that the `SendMessage` method was called from the `main` method, and so on.

The call stack is a good way to examine and understand the execution flow of an app:

- Double-click a line of code to browse to the source code. This action also changes the current scope under inspection by the debugger, but it doesn't advance the debugger.
- Access right-click menus for programming elements in the **Call Stack** window. For example, you can insert breakpoints into specified functions, advance the debugger by using **Run to Cursor**, and browse to source code. For more information, see [View the call stack and use the Call Stack window in the debugger](./how-to-use-the-call-stack-window.md).

## Change the execution flow

Another powerful debugger feature is the ability to modify the execution flow during debugging:

1. Select **F11** (**Debug** > **Step Into**) twice to run the `std::wcout` function.
1. While the debugger is paused in the `SendMessage` method call, select and drag the yellow arrow (the execution pointer) to the left of the variable and move the arrow to the previous code statement, `std::wcout`.
1. Select **F11** again.

   The debugger reruns the `std::wcout` function. You can track the process in the terminal output.

   By changing the execution flow, you can do things like test different code execution paths or rerun code without restarting the debugger.

   > [!CAUTION]
   > Pay careful attention when working with this feature. When you select the yellow arrow, Visual Studio displays a warning in the tooltip indicating that the execution change can have unintended consequences. You might see other warnings as well, depending on your scenario. Keep in mind that moving the pointer can't revert your application to an earlier app state.

1. Select **F5** to complete app execution.

::: moniker range=">=visualstudio"

## Pass command-line arguments

Set command-line arguments for your application in project properties. This is useful when you want to test how your app behaves with different command-line arguments. 

Starting in Visual Studio 2026, you can set command-line arguments for your application in the command-line arguments toolbar drop-down list. This feature is available for Visual Studio C++ projects, Unreal Engine `.uproject` projects, and CMake projects. It's currently in preview and is subject to change before final release.

Modify the application to accept command-line arguments by replacing the code in the `get-started-debugging.cpp` file with the following:

```cpp
#include <string>
#include <vector>
#include <iostream>
#include <algorithm>

void SendMessage(const std::wstring& name, int msg)
{
    std::wcout << L"Hello, " << name << L"! Count to " << msg << std::endl;
}

int main(int argc, char* argv[])
{
    // Detect if the /u command-line argument was passed to the application.
    bool uppercase = false;
    for (int i = 1; i < argc; ++i)
    {
        if (std::string(argv[i]) == "/u")
        {
            uppercase = true;
            break;
        }
    }

    std::vector<wchar_t> letters = { L'f', L'r', L'e', L'd', L' ', L's', L'm', L'i', L't', L'h' };
    std::wstring name = L"";
    std::vector<int> a(10);
    std::wstring key = L"";

    for (int i = 0; i < letters.size(); i++)
    {
        name += letters[i];
        a[i] = i + 1;
        std::wstring nameToSend = name;
        
        if (uppercase) // Convert the name to uppercase if the /u argument was passed.
        {
            std::transform(nameToSend.begin(), nameToSend.end(), nameToSend.begin(), ::towupper);
        }
        SendMessage(nameToSend, a[i]);
    }
    return 0;
}
```

This updated version of the application accepts a command-line argument `/u` that converts the name to uppercase before outputting it.

To pass the `/u` command-line argument to the application when you start debugging it, follow these steps:

1. In the **Standard** toolbar, **Command-line arguments** text box, type `/u`:

    :::image type="content" source="./media/vs-2026/command-line-arguments.png" border="false" alt-text="Screenshot of the command-line arguments drop-down list in the Standard toolbar.":::

1. Place a breakpoint on line 19, `uppercase = true;`, by clicking the left gutter on that line.

    :::image type="content" source="./media/vs-2026/breakpoint.png" border="false" alt-text="Screenshot of a breakpoint set on line 18, uppercase = true.":::

1. Start debugging your application by selecting the **Start Debugging** button or pressing **F5**.
1. The debugger hits the breakpoint because `/u` was passed as a command-line argument:

    :::image type="content" source="./media/vs-2026/breakpoint-hit.png" border="false" alt-text="Screenshot of the debugger stopped on line 18, uppercase = true.":::

1. Select **F5** to continue running the application. The output in the console window shows the names in uppercase now:

```output
Hello, F! Count to 1
Hello, FR! Count to 2
Hello, FRE! Count to 3
Hello, FRED! Count to 4
Hello, FRED ! Count to 5
Hello, FRED S! Count to 6
Hello, FRED SM! Count to 7
Hello, FRED SMI! Count to 8
Hello, FRED SMIT! Count to 9
Hello, FRED SMITH! Count to 10
```

Command-line arguments are saved in the drop-down list in the order that you enter them and appear in the drop-down list for future use. There's a limit of five command lines that you can add before the oldest one is removed to make room for the new one.

You can select the drop-down list arrow to see a list of previously used command-line arguments.

## Pass command-line arguments in different project types

The command-line arguments drop-down list contains a project type specific option to open the classic way of setting the arguments that the debugger passes to your program. For `.vcxproj` projects, it's via the project settings property page. For CMake projects, it's by editing the `vs.launch.json` file. For Unreal Engine projects it's by editing the `.uproject` file.

### Visual Studio project type (`.vcxproj`)

In a Visual Studio project (`.vcxproj`), an option appears in the command-line arguments drop-down list to **Edit in Property Pages**:

:::image type="content" source="./media/vs-2026/command-line-arguments-dropdown.png" border="false" alt-text="Screenshot of the command-line argument drop-down list. It shows /u and /d from a previous run. The option to edit in property pages is highlighted.":::

Select **Edit in Property Pages** to open the project properties window to the **Debugging** property page where you set command-line arguments to pass when debugging your application:

:::image type="content" source="./media/vs-2026/debugging-property-page.png" border="false" alt-text="Screenshot of the Debugging page in the project properties. The command-line arguments text box contains /u.":::

Changes to the **Command Arguments** are reflected in the command-line arguments drop-down list for future debugging sessions.

### CMake project type

For CMake projects, an option appears in the command-line arguments drop-down list to **Edit in `launch.vs.json`**:

:::image type="content" source="./media/vs-2026/command-line-arguments-dropdown-cmake.png" border="false" alt-text="Screenshot of the command-line argument drop-down list for CMake projects. It shows Edit in launch.vs.json as an option.":::

Select **Edit in `launch.vs.json`**, to open the `launch.vs.json` file and set command-line arguments to pass when debugging your application in the `"args"` element:

:::image type="content" source="./media/vs-2026/command-line-launch-vs-json.png" border="false" alt-text="Screenshot of the launch.vs.json file with the args element highlighted":::

Changes to the file are reflected in the command-line arguments drop-down list for future debugging sessions.

### Unreal Engine project type (`.uproject`)

For Unreal Engine projects, an option appears in the command-line arguments drop-down list to **Edit in `UETargetProperties.json`**:

:::image type="content" source="./media/vs-2026/command-line-arguments-dropdown-unreal-engine.png" border="false" alt-text="Screenshot of the command-line argument drop-down list for Unreal Engine projects. It shows Edit in UETargetProperties.json as an option.":::

Select **Edit in `UETargetProperties.json`**, to open the `UETargetProperties.json` file where you set command-line arguments to pass when debugging your application in the "args" element:

:::image type="content" source="./media/vs-2026/command-line-unreal-engine-json.png" border="false" alt-text="Screenshot of the UETargetProperties.json file with the args element highlighted":::

Changes to the file are reflected in the command-line arguments drop-down list for future debugging sessions.

::: moniker-end

## Related content

- [First look at the Visual Studio debugger](./debugger-feature-tour.md)
- [Navigate through code by using the Visual Studio debugger](./navigating-through-code-with-the-debugger.md)
- [Use the right type of breakpoint (.NET, .NET Framework, C++, All languages)](./using-breakpoints.md)
