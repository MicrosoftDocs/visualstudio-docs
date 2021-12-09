---
title: "Create your first console app with Visual Basic"
description: "Learn how to create a simple Hello World console app in Visual Studio with Visual Basic, step by step."
ms.custom: "vs-acquisition"
ms.date: 09/14/2021
ms.topic: quickstart
ms.devlang: vb
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
dev_langs:
  - vb
ms.workload:
  - "multiple"
---
# Quickstart: Create your first console app in Visual Studio with Visual Basic

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you'll create a simple Visual Basic application that runs on the console.

::: moniker range="vs-2017"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.

::: moniker-end

::: moniker range=">=vs-2019"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free.

::: moniker-end

## Create a project

First, you'll create a Visual Basic application project. The project type comes with all the template files you'll need, before you've even added anything!

::: moniker range="vs-2017"

1. Open Visual Studio 2017.

1. From the top menu bar, choose **File** > **New** > **Project**.

1. In the **New Project** dialog box in the left pane, expand **Visual Basic**, and then choose **.NET Core**. In the middle pane, choose **Console App (.NET Core)**. Then name the project *HelloWorld*.

   ![Console App (.NET Core) project template in the New Project dialog box in the Visual Studio IDE](../ide/media/new-project-vb-dotnetcore-helloworld-console-app.png)

   If you don't see the **Console App (.NET Core)** project template, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box.

   ![Click the Open Visual Studio Installer link from the New Project dialog box](../ide/media/vb-open-visual-studio-installer-hello-world.png)

   The Visual Studio Installer launches. Choose the **.NET Core cross-platform development** workload, and then choose **Modify**.

   ![.NET Core cross-platform development workload in the Visual Studio Installer](../ide/media/dot-net-core-xplat-dev-workload.png)

::: moniker-end

::: moniker range="vs-2019"

> [!NOTE]
> Some of the screenshots in this Quickstart use the dark theme. If you aren't using the dark theme but would like to, see the [Personalize the Visual Studio IDE and Editor](quickstart-personalize-the-ide.md) page to learn how.

1. Open Visual Studio.

1. On the start window, choose **Create a new project**.

   ![Screenshot showing the start window in Visual Studio with the 'Create a new project' option highlighted.](../get-started/media/vs-2019/create-new-project-dark-theme.png)

1. In the **Create a new project** window, choose **Visual Basic** from the Language list. Next, choose **Windows** from the Platform list and **Console** from the project types list.

   After you apply the language, platform, and project type filters, choose the **Console Application** template, and then choose **Next**.

   :::image type="content" source="../get-started/visual-basic/media/vs-2019/vb-create-new-project-console-net-core.png" alt-text="Screenshot showing the 'Create a new project' window with 'Visual Basic', 'Windows', and 'Console' selected in the language, platform, and project type filters. The 'Console Application' project template is highlighted.":::

   > [!NOTE]
   > If you do not see the **Console Application** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, choose the **Install more tools and features** link.
   >
   > ![Screenshot showing the 'Install more tools and features' link highlighted in the 'Not finding what you're looking for' message.](../get-started/media/vs-2019/not-finding-what-looking-for.png) 
   > 
   > Then, in the Visual Studio Installer, choose the **.NET Core cross-platform development** workload.
   >
   > ![Screenshot showing the '.NET Core cross-platform development' workload in the Visual Studio Installer.](../get-started/media/dot-net-core-xplat-dev-workload.png)
   >
   > After that, choose the **Modify** button in the Visual Studio Installer. You might be prompted to save your work; if so, do so. Next, choose **Continue** to install the workload. Then, return to step 2 in this "[Create a project](#create-a-project)" procedure.

1. In the **Configure your new project** window, type or enter *HelloWorld* in the **Project name** box. Then, choose **Next**.

   :::image type="content" source="../get-started/visual-basic/media/vs-2019/vb-name-your-console-project-hello-world.png" alt-text="in the 'Screenshot showing the 'Configure your new project' window with 'HelloWorld' entered in the Project name field.":::

1. In the **Additional information** window, **.NET Core 3.1** should already be selected for your target framework. If not, select **.NET Core 3.1**. Then, choose **Create**.

   :::image type="content" source="../get-started/visual-basic/media/vs-2019/vb-target-framework.png" alt-text="Screenshot showing the Additional information window with '.NET Core 3.1' selected in the Framework field.":::

   Visual Studio opens your new project.

::: moniker-end

::: moniker range=">=vs-2022"

1. Open Visual Studio.

1. On the start window, choose **Create a new project**.

   :::image type="content" source="media/vs-2022/create-new-project-dark-theme.png" alt-text="Screenshot showing the start window in Visual Studio with the 'Create a new project' option highlighted.":::

1. In the **Create a new project** window, choose **Visual Basic** from the Language list. Next, choose **Windows** from the Platform list and **Console** from the project types list.

   After you apply the language, platform, and project type filters, choose the **Console Application** template, and then choose **Next**.

   :::image type="content" source="media/vs-2022/vb-create-new-project-console-net-core.png" alt-text="Screenshot showing the 'Create a new project' window with 'Visual Basic', 'Windows', and 'Console' selected in the language, platform, and project type filters. The 'Console Application' project template is highlighted.":::

   > [!NOTE]
   > If you do not see the **Console Application** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, choose the **Install more tools and features** link.
   >
   > :::image type="content" source="media/vs-2022/not-finding-what-looking-for.png" alt-text="Screenshot showing the 'Install more tools and features' link highlighted in the 'Not finding what you're looking for' message.":::
   > 
   > Then, in the Visual Studio Installer, choose the **.NET desktop development** workload.
   >
   > :::image type="content" source="media/vs-2022/dot-net-core-xplat-dev-workload.png" alt-text="Screenshot showing the '.NET desktop development' workload in the Visual Studio Installer.":::
   >
   > After that, choose the **Modify** button in the Visual Studio Installer. You might be prompted to save your work; if so, do so. Next, choose **Continue** to install the workload. Then, return to step 2 in this "[Create a project](#create-a-project)" procedure.

1. In the **Configure your new project** window, type or enter *HelloWorld* in the **Project name** box. Then, choose **Next**.

   :::image type="content" source="media/vs-2022/vb-name-your-project-hello-world.png" alt-text="Screenshot showing the 'Configure your new project' window with 'HelloWorld' entered in the Project name field.":::

1. In the **Additional information** window, **.NET 6.0** should already be selected for your target framework. If not, select **.NET 6.0** in the **Framework** drop-down list. Then, choose **Create**.

   :::image type="content" source="media/vs-2022/vb-target-framework.png" alt-text="Screenshot showing the Additional information window with '.NET 6.0' selected in the Framework field.":::

   Visual Studio opens your new project.

::: moniker-end

## Create the application

::: moniker range="vs-2019"

After you select your Visual Basic project template and name your project, Visual Studio creates a simple "Hello World" application for you. It calls the <xref:System.Console.WriteLine%2A> method to display the literal string "Hello World!" in the console window.

![Screenshot showing the default 'Hello World' code in the Visual Basic project template.](../ide/media/vb-console-helloworld-template.png)

If you select the **HelloWorld** button in the IDE, you can run the program in Debug mode.

![Screenshot showing the 'Hello World' button highlighted in the Visual Studio toolbar.](../ide/media/vb-console-hello-world-button.png)

When the application runs in the Microsoft Visual Studio Debug Console, the console window remains open until you press a key. 

However, if you navigate to *HelloWorld.exe* in File Explorer and run it, the `Main` procedure terminates after its single statement executes and the console window closes quickly.

### Add some code

Let's add some code to pause the application and then ask for user input.

1. Add the following code immediately after the call to the <xref:System.Console.WriteLine%2A> method:

   ```vb
   Console.Write("Press any key to continue...")
   Console.ReadKey(true)
   ```

   This pauses the program until you press a key.

1. On the menu bar, select **Build** > **Build Solution**.

   This compiles your program into an intermediate language (IL) that's converted into binary code by a just-in-time (JIT) compiler.

## Run the application

1. In **Solution Explorer**, right-click on **HelloWorld** to open the context menu for your project. Then, select **Open Folder in File Explorer**.

1. Navigate to the *HelloWorld.exe* file in the **bin > Debug > net6.0** folder, and run it.

Now your application runs in the console and remains open until you press any key to close the console window.

   ![Screenshot showing the running Hello World console application. The app displays the messages 'Hello World!' and 'Press any key to continue'.](../ide/media/vb-console-hello-world-press-any-key.png)

::: moniker-end

::: moniker range=">=vs-2022"

After you select your Visual Basic project template and name your project, Visual Studio creates a simple "Hello World!" application for you. The **Program.vb** file contains default code that calls the <xref:System.Console.WriteLine%2A> method to display the literal string "Hello World!" in the console window.

:::image type="content" source="media/vs-2022/vb-console-hello-world-template.png" alt-text="Screenshot showing the default 'Hello World' code in the Program.vb file.":::

Select the **HelloWorld** button or press **Ctrl**+**F5** to run the default "HelloWorld" code in Debug mode.

:::image type="content" source="media/vs-2022/vb-console-hello-world-button.png" alt-text="Screenshot showing the 'HelloWorld' button highlighted in the Visual Studio toolbar.":::

When the application runs in the Microsoft Visual Studio Debug Console, the console window remains open until you press a key. 

However, if you navigate to *HelloWorld.exe* in File Explorer and run it, the `Main` procedure terminates after its single statement executes and the console window closes quickly.

### Add some code

Let's add some code to pause the application and then ask for user input.

1. Add the following code immediately after the call to the <xref:System.Console.WriteLine%2A> method:

   ```vb
   Console.Write("Press any key to continue...")
   Console.ReadKey(true)
   ```

   This code pauses the program until you press a key.

1. On the menu bar, select **Build** > **Build Solution**.

   Building the solution, compiles your program into an intermediate language (IL) that's converted into binary code by a just-in-time (JIT) compiler.

## Run the application

1. In **Solution Explorer**, right-click on **HelloWorld** to open the context menu for your project. Then, select **Open Folder in File Explorer**.

1. Navigate to the *HelloWorld.exe* file in the **bin > Debug > net6.0** folder, and run it.

Now your application runs in the console and remains open until you press any key to close the console window.

   :::image type="content" source="media/vs-2022/vb-console-hello-world-press-any-key.png" alt-text="Screenshot showing the running HelloWorld console application. The app displays the messages 'Hello World!' and 'Press any key to continue'.":::

::: moniker-end

## Next steps

Congratulations on completing this Quickstart! We hope you learned something about Visual Basic and the Visual Studio IDE. To learn more, continue with the following tutorial.

> [!div class="nextstepaction"]
> [Get started with Visual Basic in Visual Studio](../get-started/visual-basic/tutorial-console.md)
