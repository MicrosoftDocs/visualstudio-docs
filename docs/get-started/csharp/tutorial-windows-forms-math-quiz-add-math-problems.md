---
title: "Tutorial: Add math problems to Windows Forms app"
description: Add an event handler and random math problems to a math quiz Windows Forms application in the Visual Studio integrated development environment (IDE).
ms.custom: vs-acquisition
dev_langs:
  - "CSharp"
  - "VB"
ms.date: 10/18/2024
ms.topic: tutorial
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Tutorial: Add math problems to a math quiz WinForms app

In this series of four tutorials, you'll build a math quiz. The quiz contains four random math problems that a quiz taker tries to answer within a specified time.

Controls use C# or Visual Basic code. In this second tutorial, you make the quiz challenging by adding code for math problems that are based on random numbers. You also create a method that's named `StartTheQuiz()` to fill in the problems.

In this second tutorial, you learn how to:

> [!div class="checklist"]
> - Write code to create Random objects to use in math problems.
> - Add an event handler for the start button.
> - Write code to start the quiz.

## Prerequisites

This tutorial builds on a previous tutorial, [Create a math quiz WinForms app](tutorial-windows-forms-math-quiz-create-project-add-controls.md). If you haven't completed that tutorial, go through it first.

## Create a random addition problem

1. In your Visual Studio project, select **Windows Forms Designer**.

1. Select the form, **Form1**.

1. On the menu bar, select **View** > **Code**. *Form1.cs* or *Form1.vb* appears, depending on the programming language that you're using, so that you can view the code behind the form.

1. Create a <xref:System.Random> object by adding a `new` statement near the top of the code in *Form1.cs* or *Form1.vb*.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step2/cs/form1.cs" id="Snippet1":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step2/vb/form1.vb" id="Snippet1":::
   ---

   You can use `new` statements like this one to create buttons, labels, panels, OpenFileDialogs, ColorDialogs, SoundPlayers, Randoms, and even forms. These items are called *objects*.

   When you run your program, the form is started. The code behind it creates a Random object and names it **randomizer**.

   Your quiz needs variables to store the random numbers that it creates for each problem. Before using variables, you declare them, which means listing their names and data types.

1. Add two integer variables to the form, and name them **addend1** and **addend2** in *Form1.cs* or *Form1.vb*.

   > [!NOTE]
   > An integer variable is known as an *int* in C# or an *Integer* in Visual Basic. This kind of variable stores a positive or negative number from -2147483648 through 2147483647 and can store only whole numbers, not decimals.

   You use similar syntax to add an integer variable as you did to add the Random object, as the following code shows.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step2/cs/form1.cs" id="Snippet2":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step2/vb/form1.vb" id="Snippet2":::
   ---

1. Add a method that's named `StartTheQuiz()` *Form1.cs* or *Form1.vb*. This method uses the Random object's <xref:System.Random.Next> method to generate random numbers for the labels. `StartTheQuiz()` will eventually fill in all the problems and then start the timer, so add this information to the summary comment. The function should look like the following code.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step2/cs/form1.cs" id="Snippet3":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step2/vb/form1.vb" id="Snippet3":::
   ---

   When you use the `Next()` method with a Random object, such as when you call `randomizer.Next(51)`, you get a random number that's less than 51, or between 0 and 50. This code calls `randomizer.Next(51)` so that the two random numbers add up to an answer that's between 0 and 100.

   Take a closer look at these statements.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step2/cs/form1.cs" id="Snippet18":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step2/vb/form1.vb" id="Snippet18":::
   ---

   These statements set the **Text** properties of **plusLeftLabel** and **plusRightLabel** so that they display the two random numbers. Label controls display values in text format, and in programming, strings hold text. Each integer's `ToString()` method converts the integer into text that a label can display.

## Create random subtraction, multiplication, and division problems

The next step is to declare variables and provide random values for the other math problems.

1. Add integer variables for the remaining math problems to your form, after the addition problem variables. The code in *Form1.cs* or *Form1.vb* should look like the following sample.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs" range="14-38":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb" range="2-27":::
   ---

1. Modify the `StartTheQuiz()` method in *Form1.cs* or *Form1.vb* by adding the following code, starting with the "Fill in the subtraction problem" comment.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs" range="51-94":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb" range="35-79":::
   ---

   This code uses the <xref:System.Random.Next> method of the <xref:System.Random> class a little differently from how the addition problem does. When you give the `Next()` method two values, it picks a random number that's greater than or equal to the first value and less than the second one.

   By using the `Next()` method with two arguments, you can ensure the subtraction problem has a positive answer, the multiplication answer is at most 100, and the division answer isn't a fraction.

## Add an event handler to the start button

In this section, you add code to start the quiz when the start button is selected. Code that runs in reaction to an event like a button selection is called an event handler.

1. In **Windows Forms Designer**, either double-click the **Start the quiz** button, or select it and then select **Enter**. The form's code appears, and a new method is visible.

   These actions add a [*Click*](/dotnet/api/system.windows.forms.control.click) event handler to the start button. When a quiz taker selects this button, the app runs the code that you'll add to this new method.

1. Add the following two statements so that the event handler starts the quiz.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step2/cs/form1.cs" id="Snippet4":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step2/vb/form1.vb" id="Snippet4":::
   ---

   The first statement calls the new `StartTheQuiz()` method. The second statement sets the **Enabled** property of the **startButton** control to `false` so that the quiz taker can't select the button during a quiz.

## Run your app

1. Save your code.

1. Run your app, and then select **Start the quiz**. Random math problems appear, as the following screenshot shows.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/random-math-problems.png" alt-text="Screenshot that shows random values in all four math problems. The Start the quiz button appears dimmed.":::

## Next steps

Advance to the next tutorial to add a timer to your math quiz and check user answers.
> [!div class="nextstepaction"]
> [Tutorial part 3: Add a timer control to a math quiz WinForms app](tutorial-windows-forms-math-quiz-add-timer.md)