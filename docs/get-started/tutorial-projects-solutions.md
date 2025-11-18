---
title: Introduction to projects and solutions
description: Explore the difference between projects and solutions that contain and organize projects, and how to work with these items in Visual Studio.
ms.date: 12/06/2024
ms.subservice: general-ide
ms.custom: vs-acquisition
ms.topic: tutorial
f1_keywords:
- project.addnewitem
author: anandmeg
ms.author: meghaanand
manager: mijacobs
#customer intent: As a developer new to Visual Studio, I want to understand the concepts of solution and project in order to plan and implement my development projects.
---
# Introduction to projects and solutions

In this tutorial, you explore what it means to create a *solution* and a *project* in Visual Studio. A solution is a container to organize one or more related code projects, like a class library project and a corresponding test project. You create a reference from one project to another in a solution. This tutorial also describes the properties of a project and some of the files that it can contain.

As an exercise to understand the concept of a project, you create a solution and project from scratch. Ordinarily, you'd use Visual Studio project *templates* to create new projects. 

In this tutorial, you learn how to:

> [!div class="checklist"]
> - Add an item to the project
> - Add a second project
> - Add a project reference
> - Add test code
> - View Project properties

## Prerequisites

::: moniker range="vs-2019"

- If you don't have Visual Studio 2019, go to [Visual Studio downloads](https://aka.ms/vs/download/?cid=learn-onpage-download-cta) to install it for free.

::: moniker-end

::: moniker range=">=vs-2022"

- If you don't have Visual Studio, go to [Visual Studio downloads](https://aka.ms/vs/download/?cid=learn-onpage-download-cta) to install it for free.

::: moniker-end

## Solutions and projects

In Visual Studio, a solution isn't an *answer*. A solution is simply a container that Visual Studio uses to organize one or more related projects. When you open a solution, Visual Studio automatically loads all the projects that the solution contains.

> [!NOTE]
> Developing apps in Visual Studio doesn't require solutions and projects. You can just open a folder that contains code and start coding, building, and debugging. For example, a cloned [GitHub](https://github.com/) repo might not contain Visual Studio projects and solutions. For more information, see [Develop code in Visual Studio without projects or solutions](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md).

### Create a solution

Start your exploration by creating an empty solution. After you get to know Visual Studio, you probably won't create empty solutions often. When you create a new project, Visual Studio automatically creates a solution for the project unless a solution is already open.

::: moniker range="vs-2019"

1. Open Visual Studio.

1. On the start window, select **Create a new project**.

1. On the **Create a new project** page, enter *blank solution* into the search box, select the **Blank Solution** template, and then select **Next**.

   :::image type="content" source="media/vs-2019/tutorial-projects-blank-solution-template.png" alt-text="Screenshot that shows a Blank Solution template selected in Visual Studio 2019.":::

   > [!TIP]
   > If you have several workloads installed, the **Blank Solution** template might not appear at the top of your list of search results. Try scrolling to the **Other results based on your search** section of the list. It should appear there.

1. Name the solution *QuickSolution*, and then select **Create**.

   A solution appears in **Solution Explorer** on the right-hand side of the Visual Studio window. You'll probably use **Solution Explorer** often, to browse the contents of your projects.

::: moniker-end

::: moniker range=">=vs-2022"

1. Open Visual Studio, and on the start window, select **Create a new project**.

1. On the **Create a new project** page, type *blank solution* into the search box, select the **Blank Solution** template, and then select **Next**.

   :::image type="content" source="media/vs-2022/tutorial-projects-blank-solution-template.png" alt-text="Screenshot that shows a Blank Solution template selected in Visual Studio." lightbox="media/vs-2022/tutorial-projects-blank-solution-template.png" border="false":::

   > [!TIP]
   > If you have several workloads installed, the **Blank Solution** template might not appear at the top of your list of search results. Try scrolling through **Other results based on your search** to find the template.

1. On the **Configure your new project** page, name the solution *QuickSolution*, and then select **Create**.

   The **QuickSolution** solution appears in **Solution Explorer** on the right side of the Visual Studio window. You'll use **Solution Explorer** often to browse the contents of your projects.

::: moniker-end

### Add a project

Now add your first project to the solution. Start with an empty project, and add the items you need.

::: moniker range="vs-2019"

1. In **Solution Explorer**, right-click **Solution 'QuickSolution'**. In the context menu, select **Add** > **New Project**.

   A dialog box opens that says **Add a new project**.

1. Enter the text *empty* into the search box at the top, and then select **C#** under **Language**.

1. Select the **Empty Project (.NET Framework)** template, and then select **Next**.

1. Name the project *QuickDate*, then select **Create**.

   A project named QuickDate appears beneath the solution in **Solution Explorer**. Currently it contains a single file called *App.config*.

   > [!NOTE]
   > If you don't see the **Empty Project (.NET Framework)** template, you must install the **.NET desktop development** Visual Studio workload. Visual Studio uses workload-based installation to install only the components you need for the type of development you do.
   >
   >An easy way to install a new workload when you're creating a new project is to select the **Install more tools and features** link under the text that says **Not finding what you're looking for?**. After Visual Studio Installer launches, select the **.NET desktop development** workload and then the **Modify** button.
   >
   > ![Screenshot that shows the Open Visual Studio Installer link.](media/vs-2019/tutorial-projects-open-installer.png "The Open Visual Studio Installer link in the Create a New Project dialog in Visual Studio.")

::: moniker-end

::: moniker range=">=vs-2022"

1. In **Solution Explorer**, right-click **Solution 'QuickSolution'**. In the context menu, select **Add** > **New Project**.

1. On the **Add a new project** page, type *empty* into the search box at the top, and select **C#** under **All languages**.

1. Select the C# **Empty Project (.NET Framework)** template, and then select **Next**.

   > [!NOTE]
   > Visual Studio uses workload-based installation to install only the components you need for the type of development you do. If you don't see the **Empty Project (.NET Framework)** template, install the **.NET desktop development** Visual Studio workload.
   >
   > An easy way to install a new workload when you create a new project is to select the **Install more tools and features** link under the text that says **Not finding what you're looking for?**. In the Visual Studio Installer, select the **.NET desktop development** workload, and then select **Modify**.
   >
   > :::image type="content" source="media/vs-2022/tutorial-projects-open-installer.png" alt-text="Screenshot that shows the Open Visual Studio Installer link." border="false":::

1. On the **Configure your new project** page, name the project *QuickDate*, and then select **Create**.

   The **QuickDate** project appears under the solution in **Solution Explorer**. The project contains a **References** node and a single file named **App.config**.

::: moniker-end

## Add an item to the project

Add a code file to your empty project.

1. In **Solution Explorer**, right-click the **QuickDate** project. From the context menu, select **Add** > **New Item**.

   The **Add New Item** dialog box opens. Select **Show All Templates** if dialog opens in compact view.

1. Expand **Visual C# Items**, and then select **Code**. In the middle pane, select the **Class** item template. Under **Name**, type *Calendar*, and then select **Add**.

   Visual Studio adds a file named *Calendar.cs* to the project. The `.cs` on the end is the file extension for C# code files. The *Calendar.cs* file appears in the **Solution Explorer** visual project hierarchy, and the file opens in the editor.

1. Replace the contents of the *Calendar.cs* file with the following code:

   ```csharp
   using System;

   namespace QuickDate
   {
       internal class Calendar
       {
           static void Main(string[] args)
           {
               DateTime now = GetCurrentDate();
               Console.WriteLine($"Today's date is {now}");
               Console.ReadLine();
           }

           internal static DateTime GetCurrentDate()
           {
               return DateTime.Now.Date;
           }
       }
   }
   ```

   You don't need to understand everything the code is doing yet. Run the app by pressing **Ctrl**+**F5**. The app prints today's date to the *console*, or standard output, window. Then, close the console window.

## Add a second project

Solutions commonly contain more than one project, and these projects often reference each other. Some projects in a solution might be class libraries, some might be executable applications, and some might be unit test projects or websites.

To add a unit test project to your solution, start from a project template so you don't have to add another code file to the project.

::: moniker range="vs-2019"

1. In **Solution Explorer**, right-click **Solution 'QuickSolution'**. From the context menu, select **Add** > **New Project**.

1. In the **Add a new project** dialog box, enter the text *unit test* into the search box at the top, and then select **C#** under **Language**.

1. Select the **Unit Test Project** project template for .NET Core, and then select **Next**.

   > [!NOTE]
   > Starting in Visual Studio 2019 version 16.9, the MSTest project template name changed from **MSTest Unit Test Project (.NET Core)** to **Unit Test Project**. Several steps in the project creation changed in this update.

1. Name the project **QuickTest**, and then select **Next**.

1. Choose either the recommended target framework (.NET Core 3.1) or .NET 5, and then choose **Create**.

   A second project is added to **Solution Explorer**, and a file named *UnitTest1.cs* opens in the editor.

   :::image type="content" source="media/vs-2019/tutorial-projects-solution-explorer.png" alt-text="Screenshot that shows Solution Explorer with two projects.":::

::: moniker-end

::: moniker range=">=vs-2022"

1. In **Solution Explorer**, right-click **Solution 'QuickSolution'**. From the context menu, select **Add** > **New Project**.

1. In the **Add a new project** dialog box, type *unit test* into the search box at the top, and then select **C#** under **All languages**.

1. Select the C# **Unit Test Project (.NET Framework)** project template, and then select **Next**.

1. On the **Configure your new project** page, name the project *QuickTest*, and then select **Create**.

   Visual Studio adds the **QuickTest** project to **Solution Explorer**, and the **UnitTest1.cs** file opens in the editor.

   :::image type="content" source="media/vs-2022/tutorial-projects-solutions/tutorial-projects-solution-explorer.png" alt-text="Screenshot that shows Solution Explorer with two projects." border="false":::

::: moniker-end

## Add a project reference

To use the new unit test project to test your method in the **QuickDate** project, you need to add a reference to **QuickDate** to the **QuickTest** project. Adding the reference creates a *build dependency* between the two projects. When you build the solution, **QuickDate** builds before **QuickTest**.

::: moniker range="vs-2019"

1. Right-click the **Dependencies** node in the **QuickTest** project. From the context menu, select **Add Project Reference**.

   The **Reference Manager** dialog box opens.

1. In the left pane, expand **Projects**, and then select **Solution**. In the middle pane, select the checkbox next to **QuickDate**, and then select **OK**.

   A reference to the **QuickDate** project is added.

   :::image type="content" source="media/vs-2019/tutorial-projects-solution-explorer-reference.png" alt-text="Screenshot of Solution Explorer showing a project reference in Visual Studio 2019.":::

::: moniker-end

::: moniker range=">=vs-2022"

1. In **Solution Explorer**, right-click the **References** node of the **QuickTest** project. From the context menu, select **Add Reference**.

1. In the **Reference Manager** dialog box, select **Projects**. In the middle pane, select the checkbox next to **QuickDate**, and then select **OK**.

   A reference to the **QuickDate** project appears under the **QuickTest** project in **Solution Explorer**.

   :::image type="content" source="media/vs-2022/tutorial-projects-solutions/tutorial-projects-solution-explorer-reference.png" alt-text="Screenshot of Solution Explorer showing a project reference." border="false":::

::: moniker-end

## Add test code

1. Now add test code to the C# test code file. Replace the contents of *UnitTest1.cs* with the following code:

   ```csharp
   using System;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   namespace QuickTest
   {
       [TestClass]
       public class UnitTest1
       {
           [TestMethod]
           public void TestGetCurrentDate()
           {
               Assert.AreEqual(DateTime.Now.Date, QuickDate.Calendar.GetCurrentDate());
           }
       }
   }
   ```

   A red squiggle appears under some of the code. You can fix this error by making the test project a [friend assembly](/dotnet/standard/assembly/friend-assemblies) to the **QuickDate** project.

1. In the *Calendar.cs* file, add the following [using statement](/dotnet/csharp/language-reference/keywords/using-statement) and <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute> attribute to the top of the file to resolve the error in the test project.

   ```csharp
   using System.Runtime.CompilerServices;

   [assembly: InternalsVisibleTo("QuickTest")]
   ```

   The *Calendar.cs* code should look like this screenshot:

   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/tutorial-projects-cs-code.png" alt-text="Screenshot that shows C Sharp code.":::

   ::: moniker-end

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/tutorial-projects-cs-code.png" alt-text="Screenshot that shows C Sharp code." border="false":::

   ::: moniker-end

### Run the unit test

To check that your unit test is working, from the menu bar, choose **Test** > **Run All Tests**. The **Test Explorer** window opens, and you should see that the **TestGetCurrentDate** test passes.

::: moniker range="<=vs-2019"

:::image type="content" source="media/tutorial-projects-test-explorer.png" alt-text="Screenshot that shows Test Explorer with a passed test.":::

::: moniker-end

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/tutorial-projects-test-explorer.png" alt-text="Screenshot that shows Test Explorer with a passed test." border="false":::

::: moniker-end

> [!TIP]
> You can also open **Test Explorer** by choosing **Test** > **Test Explorer** from the menu bar.

## Project properties

The line in the *Calendar.cs* file that contains the <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute> attribute references the assembly name or file name of the **QuickTest** project. The assembly name might not always be the same as the project name. To find the assembly name of a project, use the project properties. The property pages contain various settings for the project.

1. In **Solution Explorer**, right-click the **QuickTest** project and select **Properties**, or select the project and press **Alt**+**Enter**.

   The *property pages* for the project open to the **Application** tab. The **Assembly name** of the QuickTest project is indeed **QuickTest**.

   If you want, you can change the name here. When you build the test project, the name of the resulting binary file then changes from *QuickTest.dll* to *\<NewName>.dll*.

    ::: moniker range="<=vs-2019"

    :::image type="content" source="media/tutorial-projects-netcore-properties.png" alt-text="Screenshot that shows project properties.":::

    ::: moniker-end

    ::: moniker range=">=vs-2022"

    :::image type="content" source="media/vs-2022/tutorial-project-properties.png" alt-text="Screenshot that shows project properties." lightbox="media/vs-2022/tutorial-project-properties.png":::

    ::: moniker-end

1. Explore some of the other tabs of the project's property pages, such as **Build** and **Debug**. These tabs are different for different types of projects.

## Related content

- [Create, work with, and delete Visual Studio projects and solutions](../ide/creating-solutions-and-projects.md)
- [Develop code in Visual Studio without projects or solutions](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md)
- [Manage project and solution properties](../ide/managing-project-and-solution-properties.md)
- [Manage references in a project](../ide/managing-references-in-a-project.md)
