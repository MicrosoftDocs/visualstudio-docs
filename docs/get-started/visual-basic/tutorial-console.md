---
title: "Tutorial: Get started with Visual Basic"
description: "Learn how to create Visual Basic console apps in Visual Studio, step-by-step."
ms.custom: "seodec18, get-started"
ms.date: 09/11/2019
ms.technology: vs-ide-general
ms.prod: visual-studio-windows
ms.topic: tutorial
ms.devlang: vb
author: TerryGLee
ms.author: tglee
manager: jillfra
dev_langs:
  - vb
ms.workload:
  - "multiple"
---
# Tutorial: Get started with Visual Basic in Visual Studio

In this tutorial for Visual Basic (VB), you'll use Visual Studio to create and run a few different console apps and explore some features of the [Visual Studio integrated development environment (IDE)](visual-studio-ide.md) while you do so.

::: moniker range="vs-2017"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.

::: moniker-end

::: moniker range="vs-2019"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free.

::: moniker-end

## Create a project

First, we'll create a Visual Basic application project. The project type comes with all the template files you'll need, before you've even added anything!

::: moniker range="vs-2017"

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project**.

3. In the **New Project** dialog box in the left pane, expand **Visual Basic**, and then choose **.NET Core**. In the middle pane, choose **Console App (.NET Core)**. Then name the project *WhatIsYourName*.

   ![Console App (.NET Core) project template in the New Project dialog box in the Visual Studio IDE](media/new-project-vb-dotnetcore-whatisyourname-console-app.png)

### Add a workload (optional)

If you don't see the **Console App (.NET Core)** project template, you can get it by adding the **.NET Core cross-platform development** workload. You can add this workload in one of the two following ways, depending on which Visual Studio 2017 updates are installed on your machine.

#### Option 1: Use the New Project dialog box

1. Click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box.

   ![Click the Open Visual Studio Installer link from the New Project dialog box](../media/vs-open-visual-studio-installer-generic.png)

1. The Visual Studio Installer launches. Choose the **.NET Core cross-platform development** workload, and then choose **Modify**.

   ![.NET Core cross-platform development workload in the Visual Studio Installer](../media/tutorial-aspnet-workload.png)

#### Option 2: Use the Tools menu bar

1. Cancel out of the **New Project** dialog box and from the top menu bar, choose **Tools** > **Get Tools and Features**.

1. The Visual Studio Installer launches. Choose the **.NET Core cross-platform development** workload, and then choose **Modify**.

::: moniker-end

::: moniker range="vs-2019"

> [!NOTE]
> Some of the screenshots in this tutorial use the dark theme. If you aren't using the dark theme but would like to, see the [Personalize the Visual Studio IDE and Editor](../../ide/quickstart-personalize-the-ide.md) page to learn how.

1. Open Visual Studio 2019.

1. On the start window, choose **Create a new project**.

   ![View the 'Create a new project' window](../../get-started/media/vs-2019/create-new-project-dark-theme.png)

1. On the **Create a new project** window, enter or type *console* in the search box. Next, choose **Visual Basic** from the Language list, and then choose **Windows** from the Platform list. 

   After you apply the language and platform filters, choose the **Console App (.NET Core)** template, and then choose **Next**.

   ![Choose the Visual Basic template for the Console App (.NET Framework)](./media/vs-2019/vb-create-new-project-search-console-net-core-filtered.png)

   > [!NOTE]
   > If you do not see the **Console App (.NET Core)** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, choose the **Install more tools and features** link.
   >
   > ![The 'Install more tools and features' link from the 'Not finding what you're looking for' message in the 'Create new project' window](../../get-started/media/vs-2019/not-finding-what-looking-for.png) 
   > 
   > Then, in the Visual Studio Installer, choose the **.NET Core cross-platform development** workload.
   >
   > ![.NET Core cross-platform development workload in the Visual Studio Installer](../../get-started/media/dot-net-core-xplat-dev-workload.png)
   >
   > After that, choose the **Modify** button in the Visual Studio Installer. You might be prompted to save your work; if so, do so. Next, choose **Continue** to install the workload. Then, return to step 2 in this "[Create a project](#create-a-project)" procedure.

1. In the **Configure your new project** window, type or enter *WhatIsYourName* in the **Project name** box. Then, choose **Create**.

   ![in the 'Configure your new project' window, name your project 'WhatIsYourName'](./media/vs-2019/vb-name-your-project-whatname.png)

   Visual Studio opens your new project.

::: moniker-end

## Create a "What Is Your Name" application

Let's create an app that prompts you for your name and then displays it along with the date and time. Here's how:

 ::: moniker range="vs-2017"

1. If it is not already open, then open your *WhatIsYourName* project.

1. Enter the following Visual Basic code immediately after the opening bracket that follows the `Sub Main(args As String())` line and before the `End Sub` line:

     ```vb
     Console.WriteLine(vbCrLf + "What is your name? ")
     Dim name = Console.ReadLine()
     Dim currentDate = DateTime.Now
     Console.WriteLine($"{vbCrLf}Hello, {name}, on {currentDate:d} at {currentDate:t}")
     Console.Write(vbCrLf + "Press any key to exit... ")
     Console.ReadKey(True)
    ```

    This code replaces the existing <xref:System.Console.WriteLine%2A>, <xref:System.Console.Write%2A>, and <xref:System.Console.ReadKey%2A> statements.

   ![Code window showing the What Is Your Name code](./media/vs-2019/vb-codewindow-what-name-dark.png)

1. Use the green **Start** button, or press **F5** to build and run your first app.

1. When the console window opens, enter your name. Your console window should look similar to the following screenshot:

   ![Console window showing What Is Your Name, the time and date, and Press any key to continue message](media/vb-console-what-name.png)

1. Press any key to close the console window.

::: moniker-end

::: moniker range="vs-2019"

1. In the *WhatIsYourName* project, enter the following Visual Basic code immediately after the opening bracket that follows the `Sub Main(args As String())` line and before the `End Sub` line:

     ```vb
     Console.WriteLine(vbCrLf + "What is your name? ")
     Dim name = Console.ReadLine()
     Dim currentDate = DateTime.Now
     Console.WriteLine($"{vbCrLf}Hello, {name}, on {currentDate:d} at {currentDate:t}!")
     Console.Write(vbCrLf + "Press any key to exit... ")
     Console.ReadKey(True)
    ```

    This code replaces the existing <xref:System.Console.WriteLine%2A>, <xref:System.Console.Write%2A>, and <xref:System.Console.ReadKey%2A> statements.

   ![Code window showing the What Is Your Name code](./media/vs-2019/vb-codewindow-what-name-dark.png)

1. Use the green **Start** button, or press **F5** to build and run your first app.

1. When the console window opens, enter your name. Your console window should look similar to the following screenshot:

   ![Console window showing What Is Your Name, the time and date, and Press any key to continue message](media/vb-console-what-name.png)

1. Press any key to close the console window.

 ::: moniker-end

## Create a "Calculate This" application

::: moniker range="vs-2017"

1. Open Visual Studio 2017, and then from the top menu bar, choose **File** > **New** > **Project**.

1. In the **New Project** dialog box in the left pane, expand **Visual Basic**, and then choose **.NET Core**. In the middle pane, choose **Console App (.NET Core)**. Then name the file *CalculateThis*.

1. Enter the following code between the `Module Program` line and `End Module` line:

   ```vb
   Public num1 As Integer
   Public num2 As Integer
   Public answer As Integer
   Sub Main()
       Console.WriteLine("Type a number and press Enter")
       num1 = Console.ReadLine()
       Console.WriteLine("Type another number to add to it and press Enter")
       num2 = Console.ReadLine()
       answer = num1 + num2
       Console.WriteLine("The answer is " & answer)
       Console.ReadLine()
   End Sub
   ```

   Your code window should look like the following screenshot:

   ![Code window showing the CalculateThis code](media/vb-codewindow-calculate-this.png)

1. Click **CalculateThis** to run your program. Your console window should look similar to the following screenshot:

    ![Console window showing the CalculateThis app, which includes prompts on which actions to take.](media/vb-console-calculate-this.png)

::: moniker-end 

::: moniker range="vs-2019"

1. On the start window, choose **Create a new project**. 

1. On the **Create a new project** window, enter or type *console* in the search box. Next, choose **Visual Basic** from the Language list, and then choose **Windows** from the Platform list. 

1. After you apply the language and platform filters, choose the **Console App (.NET Core)** template, and then choose **Next**.

   Then, in the **Configure your new project** window, type or enter *CalculateThis* in the **Project name** box. Next, choose **Create**.

1. Enter the following code between the `Module Program` line and `End Module` line:

   ```vb
   Public num1 As Integer
   Public num2 As Integer
   Public answer As Integer
   Sub Main()
       Console.WriteLine("Type a number and press Enter")
       num1 = Console.ReadLine()
       Console.WriteLine("Type another number to add to it and press Enter")
       num2 = Console.ReadLine()
       answer = num1 + num2
       Console.WriteLine("The answer is " & answer)
       Console.ReadLine()
   End Sub
   ```

   Your code window should look like the following screenshot:

   ![Code window showing the CalculateThis code](media/vb-codewindow-calculate-this.png)

1. Click **CalculateThis** to run your program. Your console window should look similar to the following screenshot:

    ![Console window showing the CalculateThis app, which includes prompts on which actions to take.](media/vb-console-calculate-this.png)

::: moniker-end

## Quick answers FAQ

Here's a quick FAQ to highlight some key concepts.

### What is Visual Basic?

Visual Basic is a type-safe programming language that's designed to be easy to learn. It is derived from BASIC, which means "Beginner's All-purpose Symbolic Instruction Code".

### What is Visual Studio?

Visual Studio is an integrated development suite of productivity tools for developers. Think of it as a program you can use to create programs and applications.

### What is a console app?

A console app takes input and displays output in a command-line window, a.k.a. a console.

### What is .NET Core?

.NET Core is the evolutionary next step of the .NET Framework. Where the .NET Framework allowed you to share code across programming languages, .NET Core adds the ability to share code across platforms. Even better, it's open source. (Both the .NET Framework and .NET Core include libraries of prebuilt functionality as well as a common language runtime (CLR), which acts as a virtual machine in which to run your code.)

## Next steps

Congratulations on completing this tutorial! To learn even more, see the following tutorial.

> [!div class="nextstepaction"]
> [Build a library with Visual Basic and the .NET Core SDK in Visual Studio](/dotnet/core/tutorials/vb-library-with-visual-studio)

## See also

* [Visual Basic language walkthroughs](/dotnet/visual-basic/walkthroughs)
* [Visual Basic language reference](/dotnet/visual-basic/language-reference/index)
* [IntelliSense for Visual Basic code files](../../ide/visual-basic-specific-intellisense.md)
