---
title: Debug ASP.NET Core in the Visual Studio Debugger
description: Debug your code for ASP.NET Core apps by using the Visual Studio debugger, create a project, set breakpoints, inspect variables, and edit code while debugging.
ms.date: 05/28/2026
ms.topic: quickstart
helpviewer_keywords:
  - "debugger"
author: mikejo5000
ms.author: mikejo

ms.subservice: debug-diagnostics
# customer intent: As a developer, I want to debug my ASP.NET Core apps in the Visual Studio debugger, so I can work with features that help me debug my code.
---

# Quickstart: Debug ASP.NET Core with the Visual Studio debugger

In this Quickstart, you explore how to use the Visual Studio debugger to you debug your ASP.NET Core application code. This article provides a quick way to learn some of the basic features for working in the debugger.

If you don't have Visual Studio, you can install the [free trial version](https://visualstudio.microsoft.com/downloads/) from the Visual Studio Downloads page.

## Create a new project

Start by creating a new project, so you have some code to check in the debugger.

1. Open Visual Studio and create a new project.

   - If the **Start Window** isn't open, select **File** > **Start Window**.
   
   - In the Start Window, select **Create a new project**.

1. In the **Create a new project** window, set the filters and search for a project template.

   <a name="select-web-app-template"></a>

   - In the **Search for templates** box, enter **web app**.

   - Expand the **Language** dropdown and select **C#**.

1. In the list of results, select the **ASP.NET Core Web App (Razor Pages)** template for C#, and then select **Next**.

   If you don't see the **ASP.NET Core Web App (Razor Pages)** template for C#, select the **Continue without code** option.
   
   1. Select **Tools** > **Get Tools and Features...**, which opens the Visual Studio Installer.
   
   1. In the Installer window, select the checkbox for the **ASP.NET and web development** workload, and then select **Modify**.

       Your Visual Studio installation updates to include the selected ASP.NET workload.
   
   1. After the update completes, select **File** > **Start Window**, and follow [the previous instructions](#select-web-app-template) to select the required template.

1. Configure the new project:

   1. Enter a **Project name** and **Solution name**, or use the default values.

   1. Use the default **Location** or select browse (**...**) to create the project in a different folder.

   1. Select **Next**.

   1. Use the recommended target **Framework** (the default is **.NET 10.0 Long Term Support**).

   1. For the other settings, use the default values.

   1. Select **Create**.

   Visual Studio creates your new project and adds the project files in the specified folder.

### Update the project code

Update some of the code supplied by the project template so you have more statements to test in the debugger.

1. In the **Solution Explorer** pane, expand the *\<project-name>\Pages* node, and select the *Privacy.cshtml* item.

   The *Privacy.cshtml* file opens in the code editor.

1. Locate the following section of code in the file and replace it with the provided snippet:

   ```html
   @{
    ViewData["Title"] = "Privacy Policy";
   }
   ```

   Replacement snippet:

   ```html
   @{
    ViewData["Title"] = "Privacy Policy";
    <label>@PrivacyModel.PrivacyMessage</label>
   }
   ```

1. In **Solution Explorer**, expand the *\<project-name>\Pages\Privacy.cshtml* node, and select the *Privacy.cshtml.cs* item.

   The *Privacy.cshtml.cs* file opens in the code editor.

1. Locate the following section of code in the file and replace it with the provided snippet:

   ```csharp
   public void OnGet()
   {
   }
   ```

   Replacement snippet:

   ```csharp

   public static string? PrivacyMessage { get; set; }

   public void OnGet() {
      LinkedList<int> result = DoWork();

      PrivacyMessage = "Result of work: " + result.First.Value + ", " + result.First.Value;
   }

   private static LinkedList<int> DoWork() {
      LinkedList<int> c1 = new();

      c1.AddLast(10);
      c1.AddLast(20);

      LinkedList<int> c2 = new(c1);
      return c2;
   }
   ```

## Set a breakpoint

A *breakpoint* is a marker that indicates where Visual Studio should suspend your running code. When a breakpoint is set, you can take a look at the current values of variables, examine the behavior of memory, and check if a specific branch of code is running. Breakpoints are the most basic feature in debugging.

1. To set a breakpoint, locate the call to the `DoWork` function in the code, and then select in the left gutter on the same line.

   When the breakpoint is set, a red dot displays in the left gutter on the corresponding line in the code.

   ::: moniker range="visualstudio"

   :::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-set-breakpoint-aspnet.png" border="false" alt-text="Screenshot that shows how to set a breakpoint in the Visual Studio debugger.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../debugger/media/debug-quickstart-set-breakpoint-aspnet.png" border="false" alt-text="Screenshot that shows how to set a breakpoint in the Visual Studio 2022 debugger.":::

   ::: moniker-end

1. Start debugging by using the **F5** keyboard shortcut (or select **Debug** > **Start Debugging**).

1. When the web page opens in the browser window, select the **Privacy** link at the top of the page.

   Code execution pauses immediately before the call to the `DoWork` function.
   
   The debugger pauses where you set the breakpoint. A yellow arrow identifies the statement where the debugger pauses app execution.

   ::: moniker range="visualstudio"

   :::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-hit-breakpoint-aspnet.png" border="false" alt-text="Screenshot that shows the debugger paused on a set breakpoint in Visual Studio.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../debugger/media/debug-quickstart-hit-breakpoint-aspnet.png" border="false" alt-text="Screenshot that shows the debugger paused on a set breakpoint in Visual Studio 2022.":::

   ::: moniker-end

### Set conditional breakpoints

If you set a breakpoint in a loop or recursion, or if you have many breakpoints that you frequently step through, use a [conditional breakpoint](../debugger/using-breakpoints.md#BKMK_Specify_a_breakpoint_condition_using_a_code_expression).

This approach helps ensure your code is suspended **only** when specific conditions are met. A conditional breakpoint can save time and also make it easier to debug issues that are hard to reproduce.

## Walk through your code

Visual Studio provides several different ways for instructing the debugger to continue with app execution. The following example shows a useful command for walking through your code.

While the code is paused at the breakpoint, hover over the statement `return c2;` until you see the green **Run to click** (_Run execution to here_) :::image type="icon" source="../debugger/media/visualstudio/debugger-run-to-click.png"::: icon. Select the icon.

::: moniker range="visualstudio"

:::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-run-to-click-aspnet.png" border="false" alt-text="Screenshot that shows how to work with the Run to click action in the Visual Studio debugger.":::

::: moniker-end
::: moniker range="<=vs-2022"

:::image type="content" source="../debugger/media/debug-quickstart-run-to-click-aspnet.png" border="false" alt-text="Screenshot that shows how to work with the Run to click action in the Visual Studio 2022 debugger.":::

::: moniker-end

The app continues execution, and pauses on the line of code where you clicked the button.

Common keyboard commands used to step through code include **F10** and **F11**. For more in-depth instructions, see [First look at the debugger](../debugger/debugger-feature-tour.md).

## Inspect variables in a data tip

You can inspect the state of your variables by using the **data tip** feature.

1. In the current line of code (marked by the yellow execution pointer), hover over the `c2` object to see the data tip.

   ::: moniker range="visualstudio"

   :::image type="content" source="../debugger/media/visualstudio/debugger-quickstart-data-tip-aspnet.png" border="false" alt-text="Screenshot that shows how to view data tips for code variables in the Visual Studio debugger.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="../debugger/media/debug-quickstart-data-tip-aspnet.png" border="false" alt-text="Screenshot that shows how to view data tips for code variables in the Visual Studio 2022 debugger.":::

   ::: moniker-end

   The data tip shows you the current value of the `c2` variable and allows you to inspect its properties.
   
   When you're debugging, if you see an unexpected value for a variable, you probably have a bug. The bug could be in the code that makes the call to the variable or in the previous line.

1. Expand the data tip to look at the current property values of the `c2` object.

1. To continue checking the value of `c2` as the code executes, select the **pin** :::image type="icon" source="../debugger/media/debugger-pin-data-tip.png"::: icon on the data tip.

   The **pin** action keeps the data tip open. As the code executes, the value in the pinned tip changes to show the current state of the watched object.

   You can move the pinned tip to any location in the IDE, so it doesn't prevent you watching other items while debugging.

## Next step

> [!div class="nextstepaction"]
> [Overview of the Visual Studio debugger](../debugger/debugger-feature-tour.md)
