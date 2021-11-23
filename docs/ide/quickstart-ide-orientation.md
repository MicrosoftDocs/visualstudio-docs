---
title: "Quickstart: Tour of the Visual Studio IDE"
description: Learn about some of the windows, menus, and other UI features of the Visual Studio integrated development environment (IDE).
ms.custom: vs-acquisition
titleSuffix: ''
ms.date: 09/14/2021
ms.topic: quickstart
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Quickstart: First look at the Visual Studio IDE

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), we'll take a tour of some of the windows, menus, and other UI features.

::: moniker range="vs-2017"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.

::: moniker-end

::: moniker range=">=vs-2019"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free.

::: moniker-end

::: moniker range="vs-2017"

## Start Page

The first thing you'll see after you open Visual Studio is most likely the **Start Page**. The **Start Page** is designed as a "hub" to help you find the commands and project files you need faster. The **Recent** section displays projects and folders you've worked on recently. Under **New project**, you can click a link to bring up the **New Project** dialog box, or under **Open**, you can open an existing code project or folder. On the right is a feed of the latest developer news.

![Screenshot of the Start Page in Visual Studio 2017.](media/start-page.png)

If you close the **Start Page** and want to see it again, you can reopen it from the **File** menu.

![Screenshot of the File menu in Visual Studio 2017.](media/quickstart-IDE-file-menu-large.png)

::: moniker-end

::: moniker range="vs-2019"

## Start window

The first thing you'll see after you open Visual Studio is the start window. The start window is designed to help you "get to code" faster. It has options to clone or check out code, open an existing project or solution, create a new project, or simply open a folder that contains some code files.

[![Screenshot of the Start window in Visual Studio 2019.](media/vs-2019/start-window-labeled.png)](media/vs-2019/start-window-labeled.png#lightbox)

If this is the first time you're using Visual Studio, your recent projects list will be empty.

If you work with non-MSBuild based codebases, you'll use the **Open a local folder** option to open your code in Visual Studio. For more information, see [Develop code in Visual Studio without projects or solutions](develop-code-in-visual-studio-without-projects-or-solutions.md). Otherwise, you can create a new project or clone a project from a source provider such as GitHub or Azure DevOps.

The **Continue without code** option simply opens the Visual Studio development environment without any specific project or code loaded. You might choose this option to join a [Live Share](/visualstudio/liveshare/) session or attach to a process for debugging. You can also press **Esc** to close the start window and open the IDE.

::: moniker-end

::: moniker range=">=vs-2022"

## Start window

The first thing you'll see after you open Visual Studio is the start window. The start window is designed to help you "get to code" faster. It has options to clone or check out code, open an existing project or solution, create a new project, or simply open a folder that has some code files.

:::image type="content" source="media/vs-2022/quickstart-start-window-labeled.png" border="true" alt-text="An annotated screenshot that shows the start window in Visual Studio 2022." lightbox="media/vs-2022/quickstart-start-window-labeled.png":::

If this is the first time you're using Visual Studio, your recent projects list will be empty.

If you work with codebases that don't use MSBuild, you'll use the **Open a local folder** option to open your code in Visual Studio. For more information, see [Develop code in Visual Studio without projects or solutions](develop-code-in-visual-studio-without-projects-or-solutions.md). Otherwise, you can create a new project or clone a project from a source provider such as GitHub or Azure DevOps.

The **Continue without code** option opens the Visual Studio development environment without any specific project or code loaded. You might choose this option to join a [Live Share](/visualstudio/liveshare/) session or attach to a process for debugging. You can also press **Esc** to close the start window and open the IDE.

::: moniker-end

## Create a project

To continue exploring Visual Studio's features, let's create a new project.

::: moniker range="vs-2017"

1. On the **Start Page**, in the search box under **New project**, type in **console** to filter the list of project types to those that contain "console" in their name.

   ![Screenshot showing a list of project templates on the Start Page in Visual Studio 2017.](media/start-page-search-templates.png)

   Visual Studio provides various kinds of project templates that help you get started coding quickly. Choose a C# **Console App (.NET Core)** project template. (Alternatively, if you're a Visual Basic, C++, JavaScript, or other language developer, feel free to create a project in one of those languages. The UI we'll be looking at is similar for all programming languages.)

1. In the **New Project** dialog box that appears, accept the default project name and choose **OK**.

The project is created and a file named *Program.cs* opens in the **Editor** window. The **Editor** shows the contents of files and is where you'll do most of your coding work in Visual Studio.

![Screenshot showing the Editor in Visual Studio 2017.](media/editor.png)

::: moniker-end

::: moniker range="vs-2019"

1. On the start window, choose **Create a new project**.

    :::image type="content" source="../get-started/media/vs-2019/start-window-create-new-project.png" alt-text="Screenshot of the 'Create a new project' window in Visual Studio 2019.":::

   The **Create a new project** window opens and shows several project *templates*. A template contains the basic files and settings required for a given project type.

   Here, you can search, filter, and pick a project template. It also shows a list of your recently used project templates.

1. In the search box at the top, type in **console** to filter the list of project types to those that contain "console" in their name. Further refine the search results by picking **C#** (or another language of your choice) from the **All language** drop-down list.

    :::image type="content" source="media/vs-2019/create-new-project.png" alt-text="Screenshot of the 'Create a new project' window in Visual Studio 2019, where you select the template that you want.":::

1. If you selected C#, Visual Basic, or F# as your language, select the **Console Application** template, and then choose **Next**. (If you selected a different language, just pick any template. The UI we'll be looking at is similar for all programming languages.)

1. On the **Configure your new project** window, accept the default project name and location, and then choose **Next**.

    :::image type="content" source="media/vs-2019/configure-new-project-console.png" alt-text="Screenshot of the 'Configure a new project' window in Visual Studio 2019, where you enter the name of the project.":::

1. In the **Additional information** window, verify that **.NET Core 3.1** appears in the **Target Framework** drop-down menu, and then click **Create**.

    :::image type="content" source="../get-started/media/vs-2019/create-project-additional-info.png" alt-text="Screenshot of the 'Additional information' window in Visual Studio 2019, where you select the version of the .NET Core Framework that you want.":::

The project is created and a file named *Program.cs* opens in the **Editor** window. The **Editor** shows the contents of files and is where you'll do most of your coding work in Visual Studio.

![Screenshot showing the Editor window in Visual Studio 2019.](media/editor.png)

::: moniker-end

::: moniker range=">=vs-2022"

1. On the start window, choose **Create a new project**.

    :::image type="content" source="media/vs-2022/start-window-create-new-project.png" alt-text="Screenshot of the 'Create a new project' window in Visual Studio 2022.":::

   The **Create a new project** window opens and shows several project *templates*. A template contains the basic files and settings required for a given project type.

   Here, you can search, filter, and pick a project template. The **Create a new project** window also shows a list of your recently used project templates.

1. In the search box at the top, type in *console* to filter the list of project types to those that contain "console" in their name. Further refine the search results by picking **C#** (or another language of your choice) from the **All language** dropdown list.

    :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Screenshot of the 'Create a new project' window in Visual Studio 2022, where you select the template that you want.":::

1. If you selected C#, Visual Basic, or F# as your language, select the **Console Application** template, and then choose **Next**. If you selected a different language, just pick any template.

1. On the **Configure your new project** window, accept the default project name and location, and then choose **Next**.

    :::image type="content" source="media/vs-2022/quickstart-configure-new-project-console.png" alt-text="Screenshot of the 'Configure a new project' window in Visual Studio 2022, where you enter the name of the project.":::

1. In the **Additional information** window, ensure that **.NET 6.0** appears in the **Framework** dropdown menu, and then choose **Create**.

    :::image type="content" source="media/vs-2022/create-project-additional-info.png" alt-text="Screenshot of the 'Additional information' window in Visual Studio 2022, where you select the version of the .NET that you want.":::

1. The project is created. Select the code file *Program.cs* in the **Solution Explorer** window, which is typically on the right-hand side of Visual Studio.

    :::image type="content" source="media/vs-2022/quickstart-opened-new-project.png" alt-text="Screenshot of the new C# console project in Visual Studio 2022.":::

The file *Program.cs* opens in the **Editor** window. The **Editor** shows the contents of files and is where you'll do most of your coding work in Visual Studio.

:::image type="content" source="media/vs-2022/editor.png" alt-text="Screenshot of the Editor in Visual Studio 2022.":::

::: moniker-end

## Solution Explorer

::: moniker range="<=vs-2019"

**Solution Explorer**, which is typically on the right-hand side of Visual Studio, shows you a graphical representation of the hierarchy of files and folders in your project, solution, or code folder. You can browse the hierarchy and navigate to a file in **Solution Explorer**.

![Screenshot showing the Solution Explorer in Visual Studio.](media/quickstart-IDE-solution-explorer.png)

::: moniker-end

::: moniker range=">=vs-2022"

**Solution Explorer** shows you a graphical representation of the hierarchy of files and folders in your project, solution, or code folder. You can browse the hierarchy and select a file to open it in the **Editor**.

:::image type="content" source="media/vs-2022/quickstart-ide-solution-explorer.png" alt-text="Screenshot of Solution Explorer in Visual Studio 2022.":::

::: moniker-end

## Menus

The menu bar along the top of Visual Studio groups commands into categories. For example, the **Project** menu contains commands related to the project you're working in. On the **Tools** menu, you can customize how Visual Studio behaves by selecting **Options**, or add features to your installation by selecting **Get Tools and Features**.

::: moniker range="vs-2017"

![Screenshot showing the Menu bar in Visual Studio 2017.](media/quickstart-IDE-menu-bar.png)

::: moniker-end

::: moniker range="vs-2019"

![Screenshot showing the Menu bar in Visual Studio 2019.](media/vs-2019/menu-bar.png)

::: moniker-end

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/menu-bar.png" alt-text="Screenshot of the Menu bar in Visual Studio 2022.":::

::: moniker-end

## Error List

The **Error List** shows you errors, warning, and messages about the current state of your code. If there are errors (like a missing brace or semicolon) in your file or anywhere in your project, they're listed here.

To open the **Error List** window, choose the **View** menu, and then select **Error List**.

::: moniker range="<=vs-2019"

:::image type="content" source="media/quickstart-IDE-error-list.png" alt-text="Screenshot of the Error List in Visual Studio 2019.":::

::: moniker-end

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/quickstart-ide-error-list.png" alt-text="Screenshot of the Error List in Visual Studio 2022.":::

::: moniker-end

## Output window

The **Output** window shows you output messages from building your project and from your source control provider.

Let's build the project to see some build output. From the **Build** menu, choose **Build Solution**. The **Output** window automatically obtains focus and shows a successful build message.

::: moniker range="<=vs-2019"

![Screenshot of the Output window in Visual Studio.](media/build-output-minimal.png)

::: moniker-end

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/quickstart-build-output-minimal.png" alt-text="Screenshot of the Output window in Visual Studio 2022.":::

::: moniker-end

## Search box

The search box is a quick and easy way to find just about anything in Visual Studio. You can enter some text related to what you want to do, and it will show you a list of options that are relevant to the text. For example, imagine you want to increase the verbosity of the build output to display more details about what the build is doing. Here's how you might do that:

::: moniker range="vs-2017"

1. Locate the **Quick Launch** search box in the upper right of the IDE. (Alternatively, press **Ctrl**+**Q** to access it.)

1. Type **verbosity** into the search box. From the displayed results, choose **Projects and Solutions --> Build and Run** under the **Options** category.

   ![Screenshot of the Quick launch search box in Visual Studio 2017.](media/quickstart-IDE-quick-launch.png)

   The **Options** dialog box opens to the **Build and Run** options page.

1. Under **MSBuild project build output verbosity**, choose **Normal**, and then click **OK**.

1. Build the project again by right-clicking on the **ConsoleApp1** project in **Solution Explorer** and choosing **Rebuild** from the context menu.

   This time the **Output** window shows more verbose logging from the build process, including which files were copied where.

   ![Screenshot of a more detailed build log within the Output window in Visual Studio 2017.](media/build-output-verbose.png)

::: moniker-end

::: moniker range="vs-2019"

1. Press **Ctrl**+**Q** to activate the search box in the upper part of the IDE.

1. Type **verbosity** into the search box. From the displayed results, choose **Change MSBuild verbosity**.

   ![Screenshot of the Search box in Visual Studio 2019.](media/vs-2019/quick-launch-verbosity.png)

   The **Options** dialog box opens to the **Build and Run** options page.

1. Under **MSBuild project build output verbosity**, choose **Normal**, and then click **OK**.

1. Build the project again by right-clicking on the **ConsoleApp1** project in **Solution Explorer** and choosing **Rebuild** from the context menu.

   This time the **Output** window shows more verbose logging from the build process, including which files were copied where.

   ![Screenshot of a more detailed build log within the Output window in Visual Studio 2019.](media/build-output-verbose.png)

::: moniker-end

::: moniker range=">=vs-2022"

1. Press **Ctrl**+**Q** to activate the search box in the upper part of the IDE.

1. Type *verbosity* into the search box. From the displayed results, choose **Change MSBuild verbosity**.

   :::image type="content" source="media/vs-2022/quickstart-search-verbosity.png" alt-text="Screenshot of the Search box in Visual Studio 2022.":::

   The **Options** dialog box opens to the **Build and Run** options page.

1. Under **MSBuild project build output verbosity**, choose **Normal**, and then choose **OK**.

1. Build the project again by right-clicking on the **ConsoleApp1** project in **Solution Explorer** and choosing **Rebuild** from the context menu.

   This time the **Output** window shows more verbose logging from the build process, including which files were copied where.

   :::image type="content" source="media/vs-2022/quickstart-build-output-verbose.png" alt-text="Screenshot of a more detailed build log within the Output window in Visual Studio 2022.":::

::: moniker-end

## Send Feedback menu

::: moniker range="vs-2017"

Should you encounter any problems while you're using Visual Studio, or if you have suggestions for how to improve the product, you can use the **Send Feedback** menu near the top of the Visual Studio window.

![Screenshot of the Send Feedback menu in Visual Studio 2017.](media/quickstart-IDE-send-feedback.png)

::: moniker-end

::: moniker range="vs-2019"

Should you encounter any problems while you're using Visual Studio, or if you have suggestions for how to improve the product, you can use the **Send Feedback** menu near the top of the Visual Studio window.

![Screenshot of the Send Feedback menu in Visual Studio 2019.](media/vs-2019/send-feedback-menu.png)

::: moniker-end

::: moniker range=">=vs-2022"

Should you run into any problems while you're using Visual Studio, or if you have suggestions for how to improve the product, you can let us know. To do so, choose the **Send Feedback** button near the upper-right corner of the IDE and use one of the feedback options in the **Send Feedback** menu.

:::image type="content" source="media/vs-2022/quickstart-ide-send-feedback.png" alt-text="Screenshot of the Send Feedback button and menu in Visual Studio 2022.":::

::: moniker-end

## Next steps

We've looked at just a few of the features of Visual Studio to get acquainted with the user interface. To explore further:

> [!div class="nextstepaction"]
> [Learn about the code editor](../get-started/tutorial-editor.md)

> [!div class="nextstepaction"]
> [Learn about projects and solutions](../get-started/tutorial-projects-solutions.md)

## See also

- [Overview of the Visual Studio IDE](../get-started/visual-studio-ide.md)
- [More features of Visual Studio](../ide/advanced-feature-overview.md)
- [Change theme and font colors](../ide/quickstart-personalize-the-ide.md)
