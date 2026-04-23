---
title: Learn about projects and solutions using Visual Basic
description: Create a new project and a solution to organize and contain your code projects in Visual Studio as a Visual Basic developer.
ms.date: 02/20/2026
ms.subservice: general-ide
ms.custom: vs-acquisition
ms.topic: how-to
author: MikeJo5000
ms.author: mikejo
manager: mijacobs
dev_langs:
- VB

#customer intent: As a developer new to using Visual Basic in Visual Studio, I want to understand how to create and use a solution and create a test project.
---
# Learn about projects and solutions using Visual Basic

In this introductory article, you explore what it means to create a *solution* and a *project* in Visual Studio. A solution is a container that's used to organize one or more related code projects, for example a class library project and a corresponding test project. This article looks at the properties of a project and some of the files it can contain. You also create a reference from one project to another.

In this article, you construct a solution and project from scratch to understand the concept of a project. In your general use of Visual Studio, you'll likely use some of the various project *templates* that Visual Studio offers when you create a new project.

> [!NOTE]
> Solutions and projects aren't required to develop apps in Visual Studio. You can also just open a folder that contains code and start coding, building, and debugging.
>
> For example, if you clone a [GitHub](https://github.com/) repo, it might not contain Visual Studio projects and solutions. For more information, see [Develop code in Visual Studio without projects or solutions](../../ide/develop-code-in-visual-studio-without-projects-or-solutions.md).

## Prerequisites

- You need Visual Studio to follow along with this article. To install it for free, see [Visual Studio downloads](https://aka.ms/vs/download/?cid=learn-onpage-download-cta).

## Solutions and projects

Despite its name, a solution isn't an *answer*. A solution is a container used by Visual Studio to organize one or more related projects. When you open a solution in Visual Studio, it automatically loads all the projects that the solution contains.

### Create a solution

To start your exploration, create an empty solution. After you get to know Visual Studio, you probably won't find yourself creating empty solutions often. When you create a new project, Visual Studio automatically creates a solution to house the project if there's not a solution already open.

1. Open Visual Studio.

1. On the start window, choose **Create a new project**.

1. On the **Create a new project** window, enter *blank solution* into the search box. Select the **Blank Solution** template. Then choose **Next**.

   ::: moniker range=">=visualstudio"
   :::image type="content" source="media/visualstudio/tutorial-projects-blank-solution-template.png" alt-text="Screenshot showing the Create a new project window with 'blank solution' in the search box and the Blank Solution project template selected.":::
   ::: moniker-end

   ::: moniker range="vs-2022"
   :::image type="content" source="media/vs-2022/tutorial-projects-blank-solution-template.png" alt-text="Screenshot showing the Create a new project window in Visual Studio 2022 with 'blank solution' in the search box and the Blank Solution project template selected.":::
   ::: moniker-end

1. Name the solution **QuickSolution**, and then choose **Create**.

   A solution appears in **Solution Explorer** on the right-hand side of the Visual Studio window. You'll probably use **Solution Explorer** often, to browse the contents of your projects.

### Add a project

Now add your first project to the solution. Add an empty project and add the items you need to the project.

1. From the right-click or context menu of **Solution 'QuickSolution'** in **Solution Explorer**, choose **Add** > **New Project**.

   A dialog opens that says **Add a new project**.

1. Enter the text **empty** into the search box at the top, and then select **Visual Basic** in the **All languages** dropdown list.

1. Select the **Empty Project (.NET Framework)** template, and then choose **Next**.

1. Name the project *QuickDate*, then choose **Create**.

   A project named **QuickDate** appears beneath the solution in **Solution Explorer**. Currently it contains a single file called *App.config*.

   ::: moniker range=">=visualstudio"
   > [!NOTE]
   > If you don't see the **Empty Project (.NET Framework)** template, you need to install the **.NET desktop development** Visual Studio *workload*. Visual Studio uses workload-based installation to install the components you need for the type of development you do.
   >
   > An easy way to install a new workload is to choose the **Install more tools and features** link under the text that says **Not finding what you're looking for?**. After Visual Studio Installer launches, choose the **.NET desktop development** workload and then the **Modify** button.
   >
   > :::image type="content" source="media/visualstudio/tutorial-projects-open-installer.png" alt-text="Screenshot showing the Create a new project window with the 'Install more tools and features' link highlighted.":::
   ::: moniker-end

   ::: moniker range="vs-2022"
   > [!NOTE]
   > If you don't see the **Empty Project (.NET Framework)** template, you need to install the **.NET desktop development** Visual Studio *workload*. Visual Studio uses workload-based installation to install the components you need for the type of development you do.
   >
   > An easy way to install a new workload is to choose the **Install more tools and features** link under the text that says **Not finding what you're looking for?**. After Visual Studio Installer launches, choose the **.NET desktop development** workload and then the **Modify** button.
   >
   > :::image type="content" source="media/vs-2022/tutorial-projects-open-installer.png" alt-text="Screenshot showing the Create a new project window in Visual Studio 2022 with the 'Install more tools and features' link highlighted.":::
   ::: moniker-end

## Add an item to the project

You have an empty project. Now add a code file.

1. From the right-click or context menu of the **QuickDate** project in **Solution Explorer**, choose **Add** > **New Item**. The **Add New Item** dialog opens.

   When you add an item for the first time, Visual Studio opens a compact view of this dialog. To see the whole dialog, select **Show All Templates**.

1. Expand **Common Items**, then choose **Code**. In the middle pane, choose the **Class** item template. Name the class **Calendar**. Then choose **Add**.

   A file named *Calendar.vb* is added to the project. The *.vb* on the end is the file extension for Visual Basic code files. The file appears in the visual project hierarchy in **Solution Explorer**. Its contents open in the editor.

1. Replace the contents of the *Calendar.vb* file with the following code:

   ```vb
   Class Calendar
       Public Shared Function GetCurrentDate() As Date
           Return DateTime.Now.Date
       End Function
   End Class
   ```

   The `Calendar` class contains a single function, `GetCurrentDate`, that returns the current date.

1. Open the project properties by double-clicking **My Project** in **Solution Explorer**. On the **Application** tab, change **Application type** to **Class Library**. This step is necessary to build the project successfully.

1. Build the project by right-clicking on **QuickDate** in **Solution Explorer** and choosing **Build**. You should see a successful build message in the **Output** window.

   :::image type="content" source="media/vs-2022/output-window.png" alt-text="Screenshot of the Output window in Visual Studio.":::

## Add a second project

It's common for solutions to contain more than one project. Often these projects reference each other. Some projects in a solution might be class libraries, some executable applications, and some might be unit test projects or websites.

Add a unit test project to your solution. Start from a project template so you don't have to add another code file to the project.

1. From the right-click or context menu of **Solution 'QuickSolution'** in **Solution Explorer**, choose **Add** > **New Project**.

1. In the **Add a new project** window, enter the text **unit test** into the search box at the top. Then select **Visual Basic** in the **All languages** list.

1. Choose the **Unit Test Project (.NET Framework)** project template, and then choose **Next**.

1. Name the project **QuickTest**, and then choose **Create**.

   A second project is added to **Solution Explorer**. A file named *UnitTest1.vb* opens in the editor.

## Add a project reference

Use the new unit test project to test your method in the **QuickDate** project, so you need to add a reference to that project. The reference creates a *build dependency* between the two projects, meaning that when you build the solution, **QuickDate** is built before **QuickTest**.

1. Choose the **References** node in the **QuickTest** project, and from the right-click or context menu, choose **Add Reference**.

   :::image type="content" source="media/vs-2022/tutorial-projects-add-reference-vb.png" alt-text="Screenshot showing the context menu for the References node in the QuickTest project, with the 'Add Reference' option selected.":::

   The **Reference Manager** opens.

1. In the left pane, expand **Projects** and choose **Solution**. In the middle pane, choose the checkbox next to **QuickDate**, and then select **OK**.

   A reference to the **QuickDate** project is added.

## Add test code

1. Now add test code to the Visual Basic code file. Replace the contents of *UnitTest1.vb* with the following code.

   ```vb
   <TestClass()> Public Class UnitTest1

       <TestMethod()> Public Sub TestGetCurrentDate()
           Assert.AreEqual(Date.Now.Date, QuickDate.Calendar.GetCurrentDate())
       End Sub

   End Class
   ```

   You see a red squiggle under some of the code. Fix this error by making the test project a [friend assembly](/dotnet/visual-basic/programming-guide/concepts/assemblies-gac/friend-assemblies) to the **QuickDate** project.

1. Back in the **QuickDate** project, open the *Calendar.vb* file if it's not already open. To resolve the error in the test project, add the following [Imports statement](/dotnet/visual-basic/language-reference/statements/imports-statement-net-namespace-and-type) and <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute> attribute.

   ```vb
   Imports System.Runtime.CompilerServices

   <Assembly: InternalsVisibleTo("QuickTest")>
   ```

   The code file should look like this:

   :::image type="content" source="media/vs-2022/tutorial-projects-code-vb.png" alt-text="Screenshot showing the code for Calendar.vb in the Visual Basic code editor window after you added the Imports statement and Assembly attribute lines.":::

## Project properties

The line in the *Calendar.vb* file that contains the <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute> attribute references the assembly name (file name) of the **QuickTest** project. The assembly name might not always be the same as the project name. To find the assembly name of a project, open the project properties.

1. In **Solution Explorer**, select the **QuickTest** project. From the right-click or context menu, select **Properties**, or just press **Alt**+**Enter**. You can also double-click **My Project** in **Solution Explorer**.

   The *property pages* for the project open on the **Application** tab. The property pages contain various settings for the project. The assembly name of the **QuickTest** project is indeed "QuickTest". If you want to change the assembly name, this page is where you'd do that. Then, when you build the test project, the name of the resulting binary file would change from *QuickTest.dll* to whatever you chose.

   :::image type="content" source="media/vs-2022/tutorial-projects-properties.png" alt-text="Screenshot showing the Application tab of the property pages for the QuickTest project with the Assembly name field highlighted and the value is QuickTest.":::

1. Explore some of the other tabs of the project's property pages, such as **Compile** and **Settings**. These tabs are different for different types of projects.

## (Optional) Run the test

If you want to check that your unit test is working, choose **Test** > **Run All Tests** from the menu bar. A window called **Test Explorer** opens. You should see that the **TestGetCurrentDate** test passes.

:::image type="content" source="media/vs-2022/tutorial-projects-test-explorer.png" alt-text="Screenshot of the Test Explorer in Visual Studio showing that the TestGetCurrentDate test passed.":::

> [!TIP]
> If **Test Explorer** doesn't open automatically, from the menu, select **Test** > **Test Explorer**.

## Related content

If you want to further explore Visual Studio, consider creating an app by following one of the [Visual Basic tutorials](index.yml).

The following resources might also be useful:

- [Create projects and solutions](../../ide/creating-solutions-and-projects.md)
- [Manage project and solution properties](../../ide/managing-project-and-solution-properties.md)
- [Manage references in a project](../../ide/managing-references-in-a-project.md)
- [Develop code in Visual Studio without projects or solutions](../../ide/develop-code-in-visual-studio-without-projects-or-solutions.md)
- [Visual Studio IDE overview](../../get-started/visual-studio-ide.md)
