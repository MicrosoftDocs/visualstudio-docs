---
title: "Step 7: Add multiplication and division problems"
ms.date: 11/04/2016
ms.topic: tutorial
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
dev_langs:
  - "CSharp"
  - "VB"
ms.assetid: e638959e-f6a4-4eb4-b2e9-f63b7855cf8f
author: TerryGLee
ms.author: "tglee"
manager: jillfra
ms.workload:
  - "multiple"
---
# Step 7: Add multiplication and division problems

In the seventh part of this tutorial, you'll add multiplication and division problems, but first think about how to make that change. Consider the initial step, which involves storing values.

> [!NOTE]
> This topic is part of a tutorial series about basic coding concepts.
> - For an overview of the tutorial, see [Tutorial 2: Create a timed math quiz](../ide/tutorial-2-create-a-timed-math-quiz.md).
> - To download a completed version of the code, see [Complete math quiz tutorial sample](https://code.msdn.microsoft.com/Complete-Math-Quiz-8581813c).

## To add multiplication and division problems

1. Add four more integer variables to the form.

     [!code-vb[VbExpressTutorial3Step7#15](../ide/codesnippet/VisualBasic/step-7-add-multiplication-and-division-problems_1.vb)]
     [!code-csharp[VbExpressTutorial3Step7#15](../ide/codesnippet/CSharp/step-7-add-multiplication-and-division-problems_1.cs)]

     [!INCLUDE [devlang-control-csharp-vb](./includes/devlang-control-csharp-vb.md)]

2. As you did before, modify the `StartTheQuiz()` method to fill in random numbers for the multiplication and division problems.

     [!code-vb[VbExpressTutorial3Step7#16](../ide/codesnippet/VisualBasic/step-7-add-multiplication-and-division-problems_2.vb)]
     [!code-csharp[VbExpressTutorial3Step7#16](../ide/codesnippet/CSharp/step-7-add-multiplication-and-division-problems_2.cs)]

3. Modify the `CheckTheAnswer()` method so that it also checks the multiplication and division problems.

     [!code-vb[VbExpressTutorial3Step7#17](../ide/codesnippet/VisualBasic/step-7-add-multiplication-and-division-problems_3.vb)]
     [!code-csharp[VbExpressTutorial3Step7#17](../ide/codesnippet/CSharp/step-7-add-multiplication-and-division-problems_3.cs)]

     You can't easily enter the multiplication sign (×) and the division sign (÷) using the keyboard, so C# and Visual Basic accept an asterisk (*) for multiplication and a slash mark (/) for division.

4. Change the last part of the timer's <xref:System.Windows.Forms.Timer.Tick> event handler so that it fills in the correct answer when time runs out.

     [!code-vb[VbExpressTutorial3Step7#23](../ide/codesnippet/VisualBasic/step-7-add-multiplication-and-division-problems_4.vb)]
     [!code-csharp[VbExpressTutorial3Step7#23](../ide/codesnippet/CSharp/step-7-add-multiplication-and-division-problems_4.cs)]

5. Save and run your program.

     Quiz takers must answer four problems to complete the quiz, as the following illustration shows.

     ![Math quiz with four problems](../ide/media/express_finishedquiz.png)<br/>
***Math quiz*** *with four problems*

## To continue or review

- To go to the next tutorial step, see **[Step 8: Customize the quiz](../ide/step-8-customize-the-quiz.md)**.

- To return to the previous tutorial step, see [Step 6: Add a subtraction problem](../ide/step-6-add-a-subtraction-problem.md).
