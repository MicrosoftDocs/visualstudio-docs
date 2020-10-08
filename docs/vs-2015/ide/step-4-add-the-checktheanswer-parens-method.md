---
title: "Step 4: Add the CheckTheAnswer() Method | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: c66f3831-b4a0-40bc-a109-8f46f4db35ed
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Step 4: Add the CheckTheAnswer() Method
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In the fourth part of this tutorial, you'll write a method, `CheckTheAnswer()`, that determines whether the answers to the math problems are correct. This topic is part of a tutorial series about basic coding concepts. For an overview of the tutorial, see [Tutorial 2: Create a Timed Math Quiz](../ide/tutorial-2-create-a-timed-math-quiz.md).

> [!NOTE]
> If you're following along in Visual Basic, you'll use the `Function` keyword instead of the usual `Sub` keyword because this method returns a value. It's really that simple: a sub doesn't return a value, but a function does.

### To verify whether the answers are correct

1. Add the `CheckTheAnswer()` method.

     When this method is called, it adds the values of addend1 and addend2 and compares the result to the value in the sum `NumericUpDown` control. If the values are equal, the method returns a value of `true`. Otherwise, the method returns a value of `false`. Your code should look like the following.

     [!code-csharp[VbExpressTutorial3Step4#8](../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step4/cs/form1.cs#8)]
     [!code-vb[VbExpressTutorial3Step4#8](../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step4/vb/form1.vb#8)]

     Next, you'll check the answer by updating the code in the method for the timer's Tick event handler to call the new `CheckTheAnswer()` method.

2. Add the following code to the `if else` statement.

     [!code-csharp[VbExpressTutorial3Step4#10](../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step4/cs/form1.cs#10)]
     [!code-vb[VbExpressTutorial3Step4#10](../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step4/vb/form1.vb#10)]

     If the answer is correct, `CheckTheAnswer()` returns `true`. The event handler stops the timer, shows a congratulatory message, and then makes the **Start** button available again. Otherwise, the quiz continues.

3. Save your program, run it, start a quiz, and provide a correct answer to the addition problem.

    > [!NOTE]
    > When you enter your answer, you must either select the default value before you start to enter your answer, or you must delete the zero manually. You'll correct this behavior later in this tutorial.

     When you provide a correct answer, a message box opens, the **Start** button becomes available, and the timer stops.

### To continue or review

- To go to the next tutorial step, see [Step 5: Add Enter Event Handlers for the NumericUpDown Controls](../ide/step-5-add-enter-event-handlers-for-the-numericupdown-controls.md).

- To return to the previous tutorial step, see [Step 3: Add a Countdown Timer](../ide/step-3-add-a-countdown-timer.md).
