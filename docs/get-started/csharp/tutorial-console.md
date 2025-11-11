---
title: "Tutorial: Create a simple C# console app"
description: Create a C# console application in Visual Studio and explore some features of the Visual Studio integrated development environment (IDE).
ms.custom: vs-acquisition
ms.date: 01/24/2025
ms.subservice: general-ide
ms.topic: tutorial
ms.devlang: csharp
author: anandmeg
ms.author: meghaanand
manager: mijacobs
dev_langs:
  - CSharp
---
# Tutorial: Create a simple C# console app in Visual Studio (part 1 of 2)

In this tutorial, you use Visual Studio to create and run a C# console app, and explore some features of the Visual Studio integrated development environment (IDE). This tutorial is part 1 of a two-part tutorial series.

In this tutorial, you complete the following tasks:

> [!div class="checklist"]
> * Create a Visual Studio project.
> * Create a C# console app.
> * Debug your app.
> * Close your app.
> * Inspect your complete code.

In [part 2 of this tutorial](tutorial-console-part-2.md), you extend this app to add more projects, learn debugging tricks, and reference non-Microsoft packages.

## Prerequisites

You must have Visual Studio installed.

If you don't have Visual Studio, go to [Visual Studio downloads](https://aka.ms/vs/download/?cid=learn-onpage-download-tutorial-create-simple-csharp-console-app-page-cta) to install it for free.

## Create a project

To start, create a C# application project. The project type comes with all the template files you need.

::: moniker range="vs-2019"

1. Open Visual Studio, and select **Create a new project** in the start window.

   :::image type="content" source="../../get-started/media/vs-2019/create-new-project-dark-theme.png" alt-text="Screenshot showing the Create a new project window.":::

1. In the **Create a new project** window, select **C#** from the language dropdown list. Choose **Windows** from the platform list and **Console** from the project types list.

   After you apply the language, platform, and project type filters, choose the **Console Application** template, and then select **Next**.

   > [!NOTE]
   > If you don't see the **Console Application** template, select **Install more tools and features**.
   >
   > :::image type="content" source="../../get-started/media/vs-2019/not-finding-what-looking-for.png" alt-text="Screenshot that shows the Install more tools and features link.":::
   >
   > In the Visual Studio Installer, select the **.NET Core cross-platform development** workload.
   >
   > :::image type="content" source="media/dot-net-core-xplat-dev-workload.png" alt-text="Screenshot showing the .NET Core cross-platform development workload in the Visual Studio Installer.":::
   >
   > Select **Modify** in the Visual Studio Installer. You might be prompted to save your work. Select **Continue** to install the workload.
   >
   > Return to step 2 in the [Create a project](#create-a-project) procedure.

1. In the **Configure your new project** window, type or enter *Calculator* in the **Project name** box. Then, select **Next**.

   :::image type="content" source="./media/vs-2019/csharp-name-your-calculator-project.png" alt-text="Screenshot showing how to name your project 'Calculator' in the 'Configure your new project' window in Visual Studio." lightbox="./media/vs-2019/csharp-name-your-calculator-project.png":::

1. In the **Additional information** window, verify that **.NET Core 3.1** appears in the **Target Framework** field. Then, select **Create**.

   :::image type="content" source="./media/vs-2019/csharp-target-framework.png" alt-text="Screenshot of the Additional information window in Visual Studio showing .NET Core 3.1 as the target framework for the new project." lightbox="./media/vs-2019/csharp-target-framework.png":::

Visual Studio opens your new project, which includes default *Hello World* code. To view it in the editor, select the code file *Program.cs* in the Solution Explorer window, which is typically on the right-hand side of Visual Studio.

The default *Hello World* code calls the <xref:System.Console.WriteLine%2A> method to display the literal string **Hello, World!** in the console window. If you press F5, you can run the default program in Debug mode. After the application runs in the debugger, the console window stays open. Press any key to close the console window.

::: moniker-end
::: moniker range=">=vs-2022"

1. Open Visual Studio, and select **Create a new project** in the start window.

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Screenshot that shows the Create a new project window.":::

1. In the **Create a new project** window, select **C#** from the language dropdown list. Choose **Windows** from the platform list and **Console** from the project types list.

   After you apply the language, platform, and project type filters, choose the **Console App** template, and then select **Next**.

   > [!NOTE]
   > If you don't see the **Console App** template, select **Install more tools and features**.
   > 
   > :::image type="content" source="media/vs-2022/not-finding-what-looking-for.png" alt-text="Screenshot that shows the Install more tools and features link.":::
   >
   > In the Visual Studio Installer, select the **.NET desktop development** workload.
   >
   > :::image type="content" source="media/vs-2022/dot-net-development-workload.png" alt-text="Screenshot that shows the .NET desktop development workload in the Visual Studio Installer.":::
   >
   > Select **Modify** in the Visual Studio Installer. You might be prompted to save your work. Select **Continue** to install the workload.
   >
   > Return to step 2 in this [Create a project](#create-a-project) procedure.

1. In the **Configure your new project** window, type or enter *Calculator* in the **Project name** box, and then select **Next**.

   :::image type="content" source="./media/vs-2022/csharp-name-your-calculator-project.png" alt-text="Screenshot that shows how to name your project 'Calculator' in the 'Configure your new project' window in Visual Studio." lightbox="./media/vs-2022/csharp-name-your-calculator-project.png":::

1. In the **Additional information** window, select **.NET 8.0** for the **Target Framework** field. Then, select **Create**.

   :::image type="content" source="./media/vs-2022/csharp-target-framework.png" alt-text="Screenshot of the Additional information window in Visual Studio that shows .NET 8.0 selected as the target framework for the new project." lightbox="./media/vs-2022/csharp-target-framework.png":::

Visual Studio opens your new project, which includes default *Hello World* code. To view it in the editor, select the code file *Program.cs* in the Solution Explorer window, which is typically on the right-hand side of Visual Studio.

The single code statement calls the <xref:System.Console.WriteLine%2A> method to display the literal string *Hello, World!* in the console window. If you press F5, you can run the default program in Debug mode. After the application runs in the debugger, the console window stays open. Press any key to close the console window.

> [!NOTE]
> Starting with .NET 6, new projects using the console template generate different code than previous versions. To learn more, see [New C# templates generate top-level statements](/dotnet/core/tutorials/top-level-templates).

::: moniker-end

## Create the app

In this section, you complete the following tasks:

- Explore some basic integer math in C#.
- Add code to create a basic calculator app.
- Debug the app to find and fix errors.
- Refine the code to make it more efficient.

### Explore integer math

Start with some basic integer math in C#.

::: moniker range="<=vs-2019"
1. In the right pane, select *Program.cs* to display the file in the code editor.

1. In the code editor, delete the default *Hello World* code.

   :::image type="content" source="media/csharp-console-calculator-deletehelloworld.png" alt-text="Screenshot showing the default Hello World code to delete from your new calculator app.":::

   Specifically, delete the line that says, `Console.WriteLine("Hello World!");`.

1. In its place, enter the following code:

   ```csharp
       int a = 42;
       int b = 119;
       int c = a + b;
       Console.WriteLine(c);
       Console.ReadKey();
   ```

   Notice that when you enter the code, the IntelliSense feature in Visual Studio offers you the option to autocomplete the entry.

   :::image type="content" source="media/integer-math-intellisense.gif" alt-text="Animation of integer math code showing the IntelliSense autocomplete feature in the Visual Studio IDE.":::

1. Select the green **Start** button next to **Calculator** to build and run your program, or press **F5**.

   :::image type="content" source="media/csharp-console-calculator-button.png" alt-text="Screenshot showing the Calculator button to run the app from the toolbar.":::

   A console window opens that reveals the sum of 42 + 119, which is **161**.

   :::image type="content" source="media/csharp-console-integer-math.png" alt-text="Screenshot showing a console window with the results of integer math.":::

1. **(Optional)** You can change the operator to change the result. For example, you can change the `+` operator in the `int c = a + b;` line of code to `-` for subtraction, `*` for multiplication, or `/` for division. Then, when you run the program, the result changes, too.

1. Close the console window.
::: moniker-end

::: moniker range=">=vs-2022"
1. In **Solution Explorer**, in the right pane, select *Program.cs* to display the file in the code editor.

1. In the code editor, replace the default *Hello World* code that says `Console.WriteLine("Hello World!");`.

   :::image type="content" source="media/vs-2022/csharp-console-calculator-delete-hello-world.png" alt-text="Screenshot that shows the line to replace in the program file.":::

   Replace the line with the following code:

   ```csharp
       int a = 42;
       int b = 119;
       int c = a + b;
       Console.WriteLine(c);
       Console.ReadKey();
   ```

    If you enter the code, the Visual Studio IntelliSense feature offers you the option to autocomplete the entry.

   :::image type="content" source="media/vs-2022/integer-math-intellisense.gif" alt-text="Animation of integer math code that shows the IntelliSense autocomplete feature in the Visual Studio IDE.":::

1. To build and run your app, press **F5**, or select the green arrow next to the name **Calculator** in the top toolbar.

   :::image type="content" source="media/vs-2022/csharp-console-calculator-button.png" alt-text="Screenshot that shows selecting the Calculator button to run the app from the Debug toolbar.":::

   A console window opens that shows the sum of 42 + 119, which is **161**.

   :::image type="content" source="media/vs-2022/csharp-console-integer-math.png" alt-text="Screenshot of a Console window showing the results of integer math.":::

1. Close the console window.

1. **(Optional)** You can change the operator to change the result. For example, you can change the `+` operator in the `int c = a + b;` line of code to `-` for subtraction, `*` for multiplication, or `/` for division. When you run the app, the result changes accordingly.

::: moniker-end

### Add code to create a calculator

Continue by adding a more complex set of calculator code to your project.

::: moniker range="<=vs-2019"

1. In the code editor, replace all the code in *Program.cs* with the following new code:

    ```csharp
        using System;

        namespace Calculator
        {
            class Program
            {
                static void Main(string[] args)
                {
                    // Declare variables and then initialize to zero.
                    int num1 = 0; int num2 = 0;
    
                    // Display title as the C# console calculator app.
                    Console.WriteLine("Console Calculator in C#\r");
                    Console.WriteLine("------------------------\n");
    
                    // Ask the user to type the first number.
                    Console.WriteLine("Type a number, and then press Enter");
                    num1 = Convert.ToInt32(Console.ReadLine());
    
                    // Ask the user to type the second number.
                    Console.WriteLine("Type another number, and then press Enter");
                    num2 = Convert.ToInt32(Console.ReadLine());
    
                    // Ask the user to choose an option.
                    Console.WriteLine("Choose an option from the following list:");
                    Console.WriteLine("\ta - Add");
                    Console.WriteLine("\ts - Subtract");
                    Console.WriteLine("\tm - Multiply");
                    Console.WriteLine("\td - Divide");
                    Console.Write("Your option? ");
    
                    // Use a switch statement to do the math.
                    switch (Console.ReadLine())
                    {
                        case "a":
                            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                            break;
                        case "s":
                            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                            break;
                        case "m":
                            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                            break;
                        case "d":
                            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                            break;
                    }
                    // Wait for the user to respond before closing.
                    Console.Write("Press any key to close the Calculator console app...");
                    Console.ReadKey();
                }
            }
        }
    ```

1. Select the **Calculator** button or press **F5** to run your app.

   A console window opens.

1. In the console window, follow the prompts to add the numbers **42** and **119** together.

   Your app should look similar to the following screenshot:

   :::image type="content" source="media/csharp-console-calculator.png" alt-text="Screenshot of a Console window showing the Calculator app with prompts.":::

::: moniker-end

::: moniker range=">=vs-2022"

1. In the code editor, replace all the code in *Program.cs* with the following new code:

    ```csharp
        // Declare variables and then initialize to zero.
        int num1 = 0; int num2 = 0;
    
        // Display title as the C# console calculator app.
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");
    
        // Ask the user to type the first number.
        Console.WriteLine("Type a number, and then press Enter");
        num1 = Convert.ToInt32(Console.ReadLine());
    
        // Ask the user to type the second number.
        Console.WriteLine("Type another number, and then press Enter");
        num2 = Convert.ToInt32(Console.ReadLine());
    
        // Ask the user to choose an option.
        Console.WriteLine("Choose an option from the following list:");
        Console.WriteLine("\ta - Add");
        Console.WriteLine("\ts - Subtract");
        Console.WriteLine("\tm - Multiply");
        Console.WriteLine("\td - Divide");
        Console.Write("Your option? ");
    
        // Use a switch statement to do the math.
        switch (Console.ReadLine())
        {
            case "a":
                Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                break;
            case "s":
                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                break;
            case "m":
                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                break;
            case "d":
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                break;
        }
        // Wait for the user to respond before closing.
        Console.Write("Press any key to close the Calculator console app...");
        Console.ReadKey();
    ```

1. Select the **Calculator** button or press **F5** to run your app.

   A console window opens.

1. In the console window, follow the prompts to add the numbers **42** and **119** together.

   Your app should look similar to the following screenshot:

   :::image type="content" source="media/csharp-console-calculator.png" alt-text="Screenshot that shows a Console window with the Calculator app with prompts.":::

::: moniker-end

### Add decimal functionality

Now, tweak the code to add more functionality.

The current calculator app only accepts and returns whole numbers. For example, if you run the app and divide the number 42 by the number 119, your result is zero, which isn't exact.

:::image type="content" source="media/csharp-console-calculator-nodecimal.png" alt-text="Screenshot of a Console window that shows the Calculator app returning an inexact whole number as a result.":::

To fix the code to improve precision by handling decimals:

1. From *Program.cs* in the Visual Studio editor, press **Ctrl**+**H** to open the **Find and Replace** control.

1. Type *int* in the control, and type *float* in the **Replace** field.

1. Select the icons for **Match case** and **Match whole word** in the control, or press **Alt**+**C** and **Alt**+**W**.

1. Select the **Replace all** icon or press **Alt**+**A** to run the search and replace.

   :::image type="content" source="media/find-replace-control-animation.gif" alt-text="Animation of the Find and Replace control showing how to change the int variable to float.":::

1. Run your calculator app again, and divide the number **42** by the number **119**.

   The app now returns a decimal number instead of zero.

   :::image type="content" source="media/csharp-console-calculator-decimal.png" alt-text="Screenshot of a Console window showing the Calculator app that now returns a decimal numeral as a result.":::

   Now the app can produce decimal results. Make a few more tweaks to the code so the app can calculate decimals too.

1. Use the **Find and Replace** control to change each instance of the `float` variable to `double`, and to change each instance of the `Convert.ToInt32` method to `Convert.ToDouble`.

1. Run your calculator app, and divide the number **42.5** by the number **119.75**.

   The app now accepts decimal values, and returns a longer decimal numeral as its result.

   :::image type="content" source="media/csharp-console-calculator-usedecimals.png" alt-text="Screenshot of a Console window showing the Calculator app that now accepts decimal numbers and returns a longer decimal result.":::

   In the [Revise the code](#revise-the-code) section, you reduce the number of decimal places in the results.

## Debug the app

You improved your basic calculator app, but your app doesn't yet handle exceptions, such as user input errors. For example, if users try to divide by zero, or enter an unexpected character, the app might stop working, return an error, or return an unexpected non-numeric result.

Let's walk through a few common user input errors, locate them in the debugger if they appear there, and fix them in the code.

> [!TIP]
> For more information about the debugger and how it works, see [First look at the Visual Studio debugger](../../debugger/debugger-feature-tour.md).

### Fix the *divide by zero* error

If you try to divide a number by zero, the console app might freeze, and then shows you what's wrong in the code editor.

:::image type="content" source="media/csharp-console-calculator-dividebyzero-error.png" alt-text="Screenshot of the Visual Studio code editor showing a line highlighted in yellow and an Exception Unhandled error for 'Attempted to divide by zero'.":::

> [!NOTE]
> Sometimes the app doesn't freeze, and the debugger doesn't show a divide-by-zero error. Instead, the app might return an unexpected non-numeric result, such as an infinity symbol. The following code fix still applies.

Let's change the code to handle this error. In *Program.cs*, replace the code for `case "d":` with the following code:

```csharp
            // Ask the user to enter a non-zero divisor until they do so.
                while (num2 == 0)
                {
                    Console.WriteLine("Enter a non-zero divisor: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                break;
```

After you replace the code, the section with the `switch` statement should look similar to the following screenshot:

:::image type="content" source="media/csharp-console-calculator-switch-code.png" alt-text="Screenshot showing the revised switch section in the Visual Studio code editor.":::

Now, when you divide any number by zero, the app asks for another number, and keeps asking until you provide a nonzero number.

:::image type="content" source="media/csharp-console-calculator-dividebyzero.png" alt-text="Screenshot of a Console window with a repeated prompt to provide a nonzero number.":::

### Fix the *format* error

If you enter an alphabetic character when the app expects a numeric character, the app freezes. Visual Studio shows you what's wrong in the code editor.

::: moniker range="<=vs-2019"

:::image type="content" source="media/csharp-console-calculator-format-error.png" alt-text="Screenshot showing an unhandled format error in the Visual Studio code editor.":::

::: moniker-end

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/csharp-console-calculator-format-error.png" alt-text="Screenshot that shows an unhandled format error in the Visual Studio code editor.":::

::: moniker-end

To prevent this exception, you can refactor the code you previously entered.

:::moniker range="<=vs-2019"
#### Revise the code

Rather than rely on the `program` class to handle all the code, you can divide your app into two classes: `Calculator` and `Program`.

The `Calculator` class handles the bulk of the calculation work, and the `Program` class handles the user interface and error-handling work.

Let's get started.

1. In *Program.cs*, delete everything and add the following new `Calculator` class:

    ```csharp
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }

    ```

1. Also add a new  `Program` class, as follows:

    ```csharp
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter a numeric value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter a numeric value: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
    ```

1. Select the **Calculator** button or press **F5** to run your app.

1. Follow the prompts and divide the number **42** by the number **119**. Your results should look similar to the following screenshot:

   :::image type="content" source="media/csharp-console-calculator-refactored.png" alt-text="Screenshot showing a Console window with the refactored Calculator app.":::

   You can now run more calculations until you choose to close the console app. There are also fewer decimal places in the results. And if you enter an incorrect character, you get an appropriate error response.

:::moniker-end

:::moniker range=">=vs-2022"
#### Revise the code

Rather than rely on the `program` class to handle all the code, you can divide your app into two classes: `Calculator` and `Program`.

The `Calculator` class handles the bulk of the calculation work, and the `Program` class handles the user interface and error-handling work.

Let's get started.

1. In *Program.cs*, delete everything and add the following new `Calculator` class:

    ```csharp
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }

    ```

1. Also add a new  `Program` class, as follows:

    ```csharp
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty.
                // Use Nullable types (with ?) to match type of System.Console.ReadLine
                string? numInput1 = "";
                string? numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter a numeric value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter a numeric value: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string? op = Console.ReadLine();

                // Validate input is not null, and matches the pattern
                if (op == null || ! Regex.IsMatch(op, "[a|s|m|d]"))
                {
                   Console.WriteLine("Error: Unrecognized input.");
                }
                else
                { 
                   try
                   {
                      result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                      if (double.IsNaN(result))
                      {
                         Console.WriteLine("This operation will result in a mathematical error.\n");
                      }
                      else Console.WriteLine("Your result: {0:0.##}\n", result);
                    }
                    catch (Exception e)
                    {
                       Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                    }
                }
                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
    ```

    > [!NOTE]
    > It's best to use nullable types (with the `?` symbol) for the input strings, since `System.Console.ReadLine` returns a [nullable reference type](/dotnet/csharp/language-reference/builtin-types/nullable-reference-types).

1. Select the **Calculator** button or press **F5** to run your app.

1. Follow the prompts and divide the number **42** by the number **119**. Your results should look similar to the following screenshot:

   :::image type="content" source="media/vs-2022/csharp-console-calculator-refactored.png" alt-text="Screenshot showing a Console window with the refactored Calculator app.":::

   You can now run more calculations until you choose to close the console app. There are also fewer decimal places in the results. And if you enter an incorrect character, you get an appropriate error response.

:::moniker-end

## Close the app

1. If you haven't already done so, close the Calculator app.

1. Close the **Output** pane in Visual Studio.

   :::image type="content" source="media/csharp-calculator-close-output-pane.png" alt-text="Screenshot that shows closing the Output pane in Visual Studio.":::

1. In Visual Studio, press **Ctrl**+**S** to save your app.

[!INCLUDE[../includes/git-source-control.md](../includes/git-source-control.md)]

## Review: Code complete

In this tutorial, you made many changes to the Calculator app. The app now handles computing resources more efficiently, and handles most user input errors.

Here's the complete code, all in one place:

:::moniker range="<=vs-2019"

```csharp

class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

        // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        // Display title as the C# console calculator app.
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            // Declare variables and set to empty.
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            // Ask the user to type the first number.
            Console.Write("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                numInput1 = Console.ReadLine();
            }

            // Ask the user to type the second number.
            Console.Write("Type another number, and then press Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                numInput2 = Console.ReadLine();
            }

            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error.\n");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

            // Wait for the user to respond before closing.
            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); // Friendly linespacing.
        }
        return;
    }
}

```

:::moniker-end
:::moniker range=">=vs-2022"

```csharp

class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

        // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        // Display title as the C# console calculator app.
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            // Declare variables and set to empty.
            // Use Nullable types (with ?) to match type of System.Console.ReadLine
            string? numInput1 = "";
            string? numInput2 = "";
            double result = 0;

            // Ask the user to type the first number.
            Console.Write("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                numInput1 = Console.ReadLine();
            }

            // Ask the user to type the second number.
            Console.Write("Type another number, and then press Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                numInput2 = Console.ReadLine();
            }

            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            string? op = Console.ReadLine();

            // Validate input is not null, and matches the pattern
            if (op == null || ! Regex.IsMatch(op, "[a|s|m|d]"))
            {
                Console.WriteLine("Error: Unrecognized input.");
            }
            else
            { 
                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
            }
            Console.WriteLine("------------------------\n");

            // Wait for the user to respond before closing.
            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); // Friendly linespacing.
        }
        return;
    }
}
```
:::moniker-end

## Next step

Continue with the second part of this tutorial:

> [!div class="nextstepaction"]
> [Part 2: Extend and debug your C# console app](tutorial-console-part-2.md)
