---
title: "Tutorial: Add a timer to a Windows Forms app"
description: Add a Timer control and event handler to a math quiz Windows Forms application in the Visual Studio integrated development environment (IDE).
ms.custom: vs-acquisition
dev_langs:
  - "CSharp"
  - "VB"
ms.date: 02/13/2025
ms.topic: tutorial
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Tutorial: Add a timer to a math quiz WinForms app

In this series of four tutorials, you'll build a math quiz. The quiz contains four random math problems that a quiz taker tries to answer within a specified time.

The quiz uses a Timer control. The code behind this control tracks the elapsed time and checks the quiz taker's answers.

In this third tutorial, you learn how to:

> [!div class="checklist"]
> - Add a Timer control to your Windows Forms app.
> - Add an event handler for the Timer.
> - Write code to check the user's answers, display messages, and fill in the correct answers.

## Prerequisites

This tutorial builds on previous tutorials, starting with [Create a math quiz WinForms app](tutorial-windows-forms-math-quiz-create-project-add-controls.md). If you haven't completed those tutorials, go through them first.

## Add a countdown timer

To keep track of time during the quiz, you use a Timer component. You also need a variable to store the amount of time that's left.

1. Add an integer variable that's named **timeLeft** in the same way that you declared variables in previous tutorials. Put the **timeLeft** declaration right after the other declarations. Your code should look like the following sample.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs" id="Snippet15":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb" id="Snippet15":::
   ---

2. In **Windows Forms Designer**, move a <xref:System.Windows.Forms.Timer> control from the **Components** category of the **Toolbox** to your form. The control appears in the gray area at the bottom of the design window.

3. On the form, select the Timer icon that you just added, and set its **Interval** property to *1000*. Because this interval is in milliseconds, a value of 1000 causes the timer to raise a <xref:System.Windows.Forms.Timer.Tick> event every second.

## Check the answers

Because the timer raises a Tick event every second, it makes sense to check the elapsed time in a Tick event handler. It's also practical to check the answers in that event handler. If time has run out, or if the answers are correct, the quiz should end.

Before you write that event handler, add a method called `CheckTheAnswer()` to determine whether the answers to the math problems are correct. This method should be in line with the other methods, such as `StartTheQuiz()`. Your code should look like the following sample.

### [C#](#tab/csharp)
:::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs" id="Snippet17":::

### [VB](#tab/vb)
:::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb" id="Snippet17":::
---

This method determines the answers to the math problems and compares the results to the values in the <xref:System.Windows.Forms.NumericUpDown> controls. In this code:

- The Visual Basic version uses the `Function` keyword instead of the usual `Sub` keyword because this method returns a value.

- You can't easily enter the multiplication sign (×) or the division sign (÷) by using the keyboard, so C# and Visual Basic accept an asterisk (`*`) for multiplication and a slash mark (`/`) for division.

- In C#, `&&` is the `logical and` operator. In Visual Basic, the equivalent operator is `AndAlso`. You use the `logical and` operator to check whether more than one condition is true. In this case, if the values are all correct, the method returns a value of `true`. Otherwise, the method returns a value of `false`.

- The `if` statement uses the **Value** property of a NumericUpDown control to access the control's current value. In the next section, you use the same property to display the correct answer in each control.

## Add an event handler to the timer

Now that you have a way to check the answers, you can write the code for the Tick event handler. This code runs every second, after the timer raises a Tick event. This event handler checks the quiz taker's answers by calling `CheckTheAnswer()`. It also checks how much time has elapsed in the quiz.

1. On the form, double-click the **Timer** control, or select it and then select **Enter**. These actions add a Tick event handler. The code editor appears and displays the Tick handler's method.

   For C#, it adds a line of code in the *Form1.Designer.cs* code file that hooks up the event handler:

   ```csharp
   timer1.Tick += new EventHandler(timer1_Tick);
   ```

   For Visual Basic, there's no need for that line, but the event handler contains a `handles Timer1.Tick` which does the same thing.

1. Add the following statements to the new event handler method.

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step3/cs/form1.cs" id="Snippet6":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step3/vb/form1.vb" id="Snippet6":::
   ---

   Each second of the quiz, this method runs. The code first checks the value that `CheckTheAnswer()` returns.

   - If all answers are correct, that value is `true`, and the quiz ends:

     - The timer stops.
     - A congratulatory message appears.
     - The **Enabled** property of the **startButton** control is set to `true` so that the quiz taker can start another quiz.

   - If `CheckTheAnswer()` returns `false`, the code checks the value of **timeLeft**:

     - If this variable is greater than 0, the timer subtracts 1 from **timeLeft**. It also updates the **Text** property of the **timeLabel** control to show the quiz taker how many seconds remain.
     - If no time remains, the timer stops and changes the **timeLabel** text to **Time's up!** A message box announces that the quiz is over, and the answers are revealed. The start button becomes available again.

## Start the timer

To start the timer when the quiz starts, add three lines to the end of the `StartTheQuiz()` method, as the following sample shows.

### [C#](#tab/csharp)
:::code language="csharp" source="../../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step3/cs/form1.cs" id="Snippet7":::

### [VB](#tab/vb)
:::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step3/vb/form1.vb" id="Snippet7":::
---

When your quiz starts, this code sets the **timeLeft** variable to 30 and the **Text** property of the **timeLabel** control to 30 seconds. Then the <xref:System.Windows.Forms.Timer.Start> method of the Timer control starts the countdown.

## Run your app

1. Save your program and run it.

1. Select **Start the quiz**. The timer starts to count down. When time runs out, the quiz ends, and the answers appear. 

1. Start another quiz, and provide correct answers to the math problems. When you answer correctly within the time limit, a message box opens, the start button becomes available, and the timer stops.

   :::image type="content" source="../media/tutorial-windows-forms-timed-math-quiz/quiz-end.png" alt-text="Screenshot that shows a completed quiz with 19 seconds remaining. The Start the quiz button is available.":::

## Next step

Advance to the next tutorial to learn how to customize your math quiz.
> [!div class="nextstepaction"]
> [Tutorial part 4: Customize a math quiz WinForms app](tutorial-windows-forms-math-quiz-customize-ui.md)