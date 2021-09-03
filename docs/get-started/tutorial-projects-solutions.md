---
title: Introduction to projects and solutions
description: Learn about the difference between projects and solutions and how to use them in Visual Studio.
ms.date: 11/17/2020
ms.technology: vs-ide-general
ms.custom: [vs-acquisition,  get-started, SEO-VS-2020]
ms.topic: tutorial
f1_keywords:
- project.addnewitem
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.workload:
- multiple
---
# Introduction to projects and solutions

In this introductory article, we'll explore what it means to create a *solution* and a *project* in Visual Studio. A solution is a container that's used to organize one or more related code projects, for example a class library project and a corresponding test project. We'll look at the properties of a project and some of the files it can contain. We'll also create a reference from one project to another.

::: moniker range="vs-2017"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.

::: moniker-end

::: moniker range="vs-2019"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free.

::: moniker-end

::: moniker range="vs-2022"

If you haven't already installed Visual Studio 2022 Preview, go to the [Visual Studio 2022 Preview downloads](https://visualstudio.microsoft.com/vs/preview/vs2022) page to install it for free.

::: moniker-end

We'll construct a solution and project from scratch as an educational exercise to understand the concept of a project. In your general use of Visual Studio, you'll likely use some of the various project *templates* that Visual Studio offers when you create a new project.

> [!NOTE]
> Solutions and projects aren't required to develop apps in Visual Studio. You can also just open a folder that contains code and start coding, building, and debugging. For example, if you clone a [GitHub](https://github.com/) repo, it might not contain Visual Studio projects and solutions. For more information, see [Develop code in Visual Studio without projects or solutions](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md).

## Solutions and projects

Despite its name, a solution is not an "answer". A solution is simply a container used by Visual Studio to organize one or more related projects. When you open a solution in Visual Studio, it automatically loads all the projects that the solution contains.

### Create a solution

We'll start our exploration by creating an empty solution. After you get to know Visual Studio, you probably won't find yourself creating empty solutions very often. When you create a new project, Visual Studio automatically creates a solution to house the project if there's not a solution already open.

::: moniker range="vs-2017"

1. Open Visual Studio.

1. On the top menu bar, select **File** > **New** > **Project**.

   The **New Project** dialog box opens.

1. In the left pane, expand **Other Project Types**, then select **Visual Studio Solutions**. In the center pane, select the **Blank Solution** template. Name your solution **QuickSolution**, then select the **OK** button.

   ![Blank Solution template in Visual Studio 2017](media/tutorial-projects-new-solution.png "The Blank Solution template in Visual Studio 2017.")

   The **Start Page** closes, and a solution appears in **Solution Explorer** on the right-hand side of the Visual Studio window. You'll probably use **Solution Explorer** often, to browse the contents of your projects.

::: moniker-end

::: moniker range=">=vs-2019"

1. Open Visual Studio.

2. On the start window, select **Create a new project**.

3. On the **Create a new project** page, enter **blank solution** into the search box, select the **Blank Solution** template, and then select **Next**.

   ![Blank Solution template in Visual Studio 2019](media/vs-2019/tutorial-projects-blank-solution-template.png "The Blank Solution template in Visual Studio 2019.")

    > [!TIP]
    > If you have several workloads installed, the **Blank Solution** template might not appear at the top of your list of search results. Try scrolling to the **Other results based on your search** section of the list. It should appear there.

4. Name the solution **QuickSolution**, and then select **Create**.

   A solution appears in **Solution Explorer** on the right-hand side of the Visual Studio window. You'll probably use **Solution Explorer** often, to browse the contents of your projects.

::: moniker-end

### Add a project

Now let's add our first project to the solution. We'll start with an empty project and add the items we need to the project.

::: moniker range="vs-2017"

1. From the right-click or context menu of **Solution 'QuickSolution'** in **Solution Explorer**, select **Add** > **New Project**.

   The **Add New Project** dialog box opens.

1. In the left pane, expand **Visual C#** and select **Windows Desktop**. Then, in the middle pane, select the **Empty Project (.NET Framework)** template. Name the project **QuickDate**, then select **OK**.

   A project named QuickDate appears beneath the solution in **Solution Explorer**. Currently it contains a single file called *App.config*.

   > [!NOTE]
   > If you don't see **Visual C#** in the left pane of the dialog box, you must install the **.NET desktop development** Visual Studio workload. Visual Studio uses workload-based installation to install only the components you need for the type of development you do. An easy way to install a new workload is to select the **Open Visual Studio Installer** link in the bottom left corner of the **Add New Project** dialog box. After Visual Studio Installer launches, select the **.NET desktop development** workload and then the **Modify** button.
   >
   > ![Open Visual Studio Installer link](media/tutorial-projects-open-installer.png "The Open Visual Studio Installer link in the Add New Project dialog in Visual Studio 2017.")

::: moniker-end

::: moniker range=">=vs-2019"

1. From the right-click or context menu of **Solution 'QuickSolution'** in **Solution Explorer**, select **Add** > **New Project**.

   A dialog box opens that says **Add a new project**.

1. Enter the text **empty** into the search box at the top, and then select **C#** under **Language**.

1. Select the **Empty Project (.NET Framework)** template, and then select **Next**.

1. Name the project **QuickDate**, then select **Create**.

   A project named QuickDate appears beneath the solution in **Solution Explorer**. Currently it contains a single file called *App.config*.

   > [!NOTE]
   > If you don't see the **Empty Project (.NET Framework)** template, you must install the **.NET desktop development** Visual Studio workload. Visual Studio uses workload-based installation to install only the components you need for the type of development you do.
   >
   >An easy way to install a new workload when you're creating a new project is to select the **Install more tools and features** link under the text that says **Not finding what you're looking for?**. After Visual Studio Installer launches, select the **.NET desktop development** workload and then the **Modify** button.
   >
   > ![Open Visual Studio Installer link](media/vs-2019/tutorial-projects-open-installer.png "The Open Visual Studio Installer link in the Create a New Project dialog in Visual Studio.")

::: moniker-end

## Add an item to the project

We have an empty project. Let's add a code file.

1. From the right-click or context menu of the **QuickDate** project in **Solution Explorer**, select **Add** > **New Item**.

   The **Add New Item** dialog box opens.

1. Expand **Visual C# Items**, then select **Code**. In the middle pane, select the **Class** item template. Name the class **Calendar**, and then select the **Add** button.

   A file named *Calendar.cs* is added to the project. The *.cs* on the end is the file extension that is given to C# code files. The file appears in the visual project hierarchy in **Solution Explorer**, and its contents are opened in the editor.

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

   You don't need to understand what the code does, but if you want, you can run the program by pressing **Ctrl**+**F5** and see that it prints today's date to the console (or standard output) window.

## Add a second project

It is common for solutions to contain more than one project, and often these projects reference each other. Some projects in a solution might be class libraries, some executable applications, and some might be unit test projects or websites.

Let's add a unit test project to our solution. This time we'll start from a project template so we don't have to add an additional code file to the project.

1. From the right-click or context menu of **Solution 'QuickSolution'** in **Solution Explorer**, select **Add** > **New Project**.

::: moniker range="vs-2017"

2. In the left pane, expand **Visual C#** and select the **Test** category. In the middle pane, select the **MSTest Test Project (.NET Core)** project template. Name the project **QuickTest**, and then select **OK**.

   A second project is added to **Solution Explorer**, and a file named *UnitTest1.cs* opens in the editor.

   ![Visual Studio Solution Explorer with two projects](media/tutorial-projects-solution-explorer.png "Solution Explorer with two projects in Visual Studio 2017.")

::: moniker-end

::: moniker range=">=vs-2019"

2. In the **Add a new project** dialog box, enter the text **unit test** into the search box at the top, and then select **C#** under **Language**.

3. Select the **Unit Test Project** project template for .NET Core, and then select **Next**.

   > [!NOTE]
   > Starting in Visual Studio 2019 version 16.9, the MSTest project template name changed from **MSTest Unit Test Project (.NET Core)** to **Unit Test Project**. Several steps in the project creation changed in this update.

4. Name the project **QuickTest**, and then select **Next**.

5. Choose either the recommended target framework (.NET Core 3.1) or .NET 5, and then choose **Create**.

   A second project is added to **Solution Explorer**, and a file named *UnitTest1.cs* opens in the editor.

   ![Visual Studio Solution Explorer with two projects](media/vs-2019/tutorial-projects-solution-explorer.png "Solution Explorer with two projects in Visual Studio.")

::: moniker-end

## Add a project reference

We're going to use the new unit test project to test our method in the **QuickDate** project, so we need to add a reference to that project. This creates a *build dependency* between the two projects, meaning that when you build the solution, **QuickDate** is built before **QuickTest**.

::: moniker range="vs-2017"

1. Select the **Dependencies** node in the **QuickTest** project, and from the right-click or context menu, select **Add Reference**.

   The **Reference Manager** dialog box opens.

1. In the left pane, expand **Projects** and select **Solution**. In the middle pane, select the checkbox next to **QuickDate**, and then select **OK**.

   A reference to the **QuickDate** project is added.

   ![A screenshot of Solution Explorer showing project reference in Visual Studio](media/vs-2019/tutorial-projects-solution-explorer-reference.png "A screenshot of Solution Explorer showing a project reference in Visual Studio.")

::: moniker-end

::: moniker range=">=vs-2019"

1. Select the **Dependencies** node in the **QuickTest** project, and from the right-click or context menu, select **Add Project Reference...**.

   The **Reference Manager** dialog box opens.

1. In the left pane, expand **Projects**, and then select **Solution**. In the middle pane, select the checkbox next to **QuickDate**, and then select **OK**.

   A reference to the **QuickDate** project is added.

   ![A screenshot of Solution Explorer showing a project reference in Visual Studio 2019](media/vs-2019/tutorial-projects-solution-explorer-reference.png)

::: moniker-end

## Add test code

1. Now we'll add test code to the C# test code file. Replace the contents of *UnitTest1.cs* with the following code:

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

   You'll see a red squiggle under some of the code. We'll fix this error by making the test project a [friend assembly](/dotnet/standard/assembly/friend-assemblies) to the **QuickDate** project.

1. Back in the **QuickDate** project, open the *Calendar.cs* file if it's not already open. Add the following [using statement](/dotnet/csharp/language-reference/keywords/using-statement) and <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute> attribute to the top of the file to resolve the error in the test project.

   ```csharp
   using System.Runtime.CompilerServices;

   [assembly: InternalsVisibleTo("QuickTest")]
   ```

   The code file should look like this:

   ![CSharp code](media/tutorial-projects-cs-code.png "The code snippet from the Add Test Code section in this article.")

## Project properties

The line in the *Calendar.cs* file that contains the <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute> attribute references the assembly name (file name) of the **QuickTest** project. The assembly name might not always be the same as the project name. To find the assembly name of a project, open the project properties.

1. In **Solution Explorer**, select the **QuickTest** project. From the right-click or context menu, select **Properties**, or just press **Alt**+**Enter**.

   The *property pages* for the project open on the **Application** tab. The property pages contain various settings for the project. Notice that the assembly name of the **QuickTest** project is indeed "QuickTest". If you wanted to change it, this is where you'd do that. Then, when you build the test project, the name of the resulting binary file would change from *QuickTest.dll* to whatever you chose.

   ![Project properties](media/tutorial-projects-netcore-properties.png "Project Properties dialog in Visual Studio.")

1. Explore some of the other tabs of the project's property pages, such as **Build** and **Debug**. These tabs are different for different types of projects.

## Next steps

::: moniker range="vs-2017"

If you want to check that your unit test is working, choose **Test** > **Run** > **All Tests** from the menu bar. A window called **Test Explorer** opens, and you should see that the **TestGetCurrentDate** test passes.

::: moniker-end

::: moniker range=">=vs-2019"

If you want to check that your unit test is working, choose **Test** > **Run All Tests** from the menu bar. A window called **Test Explorer** opens, and you should see that the **TestGetCurrentDate** test passes.

::: moniker-end

![Test Explorer in Visual Studio showing passed test](media/tutorial-projects-test-explorer.png "Test Explorer in Visual Studio showing a passed test.")

::: moniker range="vs-2017"

> [!TIP]
> If **Test Explorer** doesn't open automatically, open it by choosing **Test** > **Windows** > **Test Explorer** from the menu bar.

::: moniker-end

::: moniker range=">=vs-2019"

> [!TIP]
> If **Test Explorer** doesn't open automatically, open it by choosing **Test** > **Test Explorer** from the menu bar.

::: moniker-end

## See also

- [Work with projects and solutions](../ide/creating-solutions-and-projects.md)
- [Manage project and solution properties](../ide/managing-project-and-solution-properties.md)
- [Manage references in a project](../ide/managing-references-in-a-project.md)
- [Develop code in Visual Studio without projects or solutions](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md)
- [Visual Studio IDE overview](../get-started/visual-studio-ide.md)
