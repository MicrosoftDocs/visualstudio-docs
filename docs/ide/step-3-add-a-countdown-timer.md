---
title: 'Step 3: Add a countdown timer'
description: Learn how to add a countdown timer to track the number of seconds that remain for the quiz taker to finish.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: tutorial
dev_langs:
- CSharp
- VB
ms.assetid: 62670a2b-efdc-45c6-9646-9b17eeb33dcb
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Step 3: Add a countdown timer

In the third part of this tutorial, you'll add a countdown timer to track the number of seconds that remain for the quiz taker to finish.

> [!NOTE]
> This topic is part of a tutorial series about basic coding concepts. For an overview of the tutorial, see [Tutorial 2: Create a timed math quiz](../ide/tutorial-2-create-a-timed-math-quiz.md).

## To add a countdown timer

1. Add an integer variable that's named **timeLeft**, just like you did in the previous procedure. Your code should look like the following.

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step3/vb/form1.vb" id="Snippet5":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step3/cs/form1.cs" id="Snippet5":::

     [!INCLUDE [devlang-control-csharp-vb](./includes/devlang-control-csharp-vb.md)]

     Now you need a method that actually counts the seconds, such as a timer, which raises an event after the amount of time that you specify.

2. In the design window, move a <xref:System.Windows.Forms.Timer> control from the **Components** category of the **Toolbox** to your form.

     The control appears in the gray area at the bottom of the design window.

3. On the form, choose the **timer1** icon that you just added, and set its **Interval** property to **1000**.

     Because the interval value is milliseconds, a value of 1000 causes the <xref:System.Windows.Forms.Timer.Tick> event to fire every second.

4. On the form, double-click the **Timer** control, or choose it and then choose the **Enter** key.

     The code editor appears and displays the method for the Tick event handler that you just added.

5. Add the following statements to the new event handler method.

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step3/vb/form1.vb" id="Snippet6":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step3/cs/form1.cs" id="Snippet6":::

     Based on what you added, the timer checks each second whether time has run out by determining whether the **timeLeft** integer variable is greater than 0. If it is, time still remains. The timer first subtracts 1 from timeLeft and then updates the **Text** property of the **timeLabel** control to show the quiz taker how many seconds remain.

     If no time remains, the timer stops and changes the text of the **timeLabel** control so that it shows **Time's up!** A message box announces that the quiz is over, and the answer is revealed—in this case, by adding addend1 and addend2. The **Enabled** property of the **startButton** control is set to **true** so that the quiz taker can start another quiz.

     You just added an `if else` statement, which is how you tell programs to make decisions. An `if else` statement looks like the following.

    > [!NOTE]
    > The following example is for demonstration only--don't add it to your project.

    ```vb
    If (something that your program will check) Then
        ' One or more statements that will run
        ' if what the program checked is true.
    Else
        ' One or more statements that will run
        ' if what the program checked is false.
    End If
    ```

    ```csharp
    if (something that your program will check)
    {
        // One or more statements that will run
        // if what the program checked is true.
    }
    else
    {
        // One or more statements that will run
        // if what the program checked is false.
    }
    ```

     Look closely at the statement that you added in the `else` block to show the answer to the addition problem.

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step3/vb/form1.vb" id="Snippet24":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step3/cs/form1.cs" id="Snippet24":::

     The statement `addend1 + addend2` adds the values in the two variables together. The first part (`sum.Value`) uses the **Value** property of the sum NumericUpDown control to display the correct answer. You use the same property later to check the answers for the quiz.

     Quiz takers can enter numbers more easily by using a <xref:System.Windows.Forms.NumericUpDown> control, which is why you use one for the answers to the math problems. All of the potential answers are whole numbers from 0 through 100. By leaving the default values of the **Minimum**, **Maximum**, and **DecimalPlaces** properties, you ensure that quiz takers can't enter decimals, negative numbers, or numbers that are too high. (If you wanted to allow quiz takers to enter 3.141 but not 3.1415, you could set the **DecimalPlaces** property to 3.)

6. Add three lines to the end of the `StartTheQuiz()` method, so the code looks like the following.

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step3/vb/form1.vb" id="Snippet7":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step3/cs/form1.cs" id="Snippet7":::

     Now, when your quiz starts, the **timeLeft** variable is set to 30 and the **Text** property of the **timeLabel** control is set to 30 seconds. Then the <xref:System.Windows.Forms.Timer.Start> method of the Timer control starts the countdown. (The quiz doesn't check the answer yet—that comes next.)

7. Save your program, run it, and then choose the **Start** button on the form.

     The timer starts to count down. When time runs out, the quiz ends, and the answer appears. The following illustration shows the quiz in progress.

     ![Math quiz in progress](../ide/media/express_addcountdown.png)<br/>
*Math quiz in progress*

## To continue or review

- To go to the next tutorial step, see **[Step 4: Add the CheckTheAnswer() method](../ide/step-4-add-the-checktheanswer-parens-method.md)**.

- To return to the previous tutorial step, see [Step 2: Create a random addition problem](../ide/step-2-create-a-random-addition-problem.md).
