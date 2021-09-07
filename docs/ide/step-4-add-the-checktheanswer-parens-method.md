---
title: 'Step 4: Add the CheckTheAnswer() method'
description: Learn how to write a CheckTheAnswer()method to determine whether the answers to the math problems are correct.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: tutorial
dev_langs:
- CSharp
- VB
ms.assetid: c66f3831-b4a0-40bc-a109-8f46f4db35ed
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Step 4: Add the CheckTheAnswer() method

In the fourth part of this tutorial, you'll write a method, `CheckTheAnswer()`, that determines whether the answers to the math problems are correct. This topic is part of a tutorial series about basic coding concepts. For an overview of the tutorial, see [Tutorial 2: Create a timed math quiz](../ide/tutorial-2-create-a-timed-math-quiz.md).

> [!NOTE]
> This topic is part of a tutorial series about basic coding concepts. For an overview of the tutorial, see [Tutorial 2: Create a timed math quiz](../ide/tutorial-2-create-a-timed-math-quiz.md).

## To verify whether the answers are correct

> [!NOTE]
> If you're following along in Visual Basic, you'll use the `Function` keyword instead of the usual `Sub` keyword because this method returns a value. It's really that simple: a sub doesn't return a value, but a function does.

1. Add the `CheckTheAnswer()` method. This method should be in line with the other methods you made, such as `StartTheQuiz()`.

     When this method is called, it adds the values of addend1 and addend2 and compares the result to the value in the sum <xref:System.Windows.Forms.NumericUpDown> control. If the values are equal, the method returns a value of `true`. Otherwise, the method returns a value of `false`. Your code should look like the following.

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step4/vb/form1.vb" id="Snippet8":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step4/cs/form1.cs" id="Snippet8":::

     [!INCLUDE [devlang-control-csharp-vb](./includes/devlang-control-csharp-vb.md)]

     Next, you'll check the answer by updating the code in the method for the timer's <xref:System.Windows.Forms.Timer.Tick> event handler to call the new `CheckTheAnswer()` method.

2. Add the following code to the `if else` statement in the `Timer1_Tick()` method, so that the timer stops when the user gets the answer right.

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step4/vb/form1.vb" id="Snippet10":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step4/cs/form1.cs" id="Snippet10":::

     If the answer is correct, `CheckTheAnswer()` returns `true`. The event handler stops the timer, shows a congratulatory message, and then makes the **Start** button available again. Otherwise, the quiz continues.

3. Save your program, run it, start a quiz, and provide a correct answer to the addition problem.

    > [!NOTE]
    > When you enter your answer, you must either select the default value before you start to enter your answer, or you must delete the zero manually. You'll correct this behavior later in this tutorial.

     When you provide a correct answer, a message box opens, the **Start** button becomes available, and the timer stops.

## To continue or review

- To go to the next tutorial step, see **[Step 5: Add Enter event handlers for the NumericUpDown controls](../ide/step-5-add-enter-event-handlers-for-the-numericupdown-controls.md)**.

- To return to the previous tutorial step, see [Step 3: Add a countdown timer](../ide/step-3-add-a-countdown-timer.md).
