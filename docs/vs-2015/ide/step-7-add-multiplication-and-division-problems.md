---
title: "Step 7: Add Multiplication and Division Problems | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: e638959e-f6a4-4eb4-b2e9-f63b7855cf8f
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# Step 7: Add Multiplication and Division Problems
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In the seventh part of this tutorial, you'll add multiplication and division problems, but first think about how to make that change. Consider the initial step, which involves storing values.

### To add multiplication and division problems

1. Add four more integer variables to the form.

     [!code-csharp[VbExpressTutorial3Step7#15](../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs#15)]
     [!code-vb[VbExpressTutorial3Step7#15](../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb#15)]

2. As you did before, modify the `StartTheQuiz()` method to fill in random numbers for the multiplication and division problems.

     [!code-csharp[VbExpressTutorial3Step7#16](../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs#16)]
     [!code-vb[VbExpressTutorial3Step7#16](../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb#16)]

3. Modify the `CheckTheAnswer()` method so that it also checks the multiplication and division problems.

     [!code-csharp[VbExpressTutorial3Step7#17](../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs#17)]
     [!code-vb[VbExpressTutorial3Step7#17](../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb#17)]

     You can't easily enter the multiplication sign (×) and the division sign (÷) using the keyboard, so Visual C# and Visual Basic accept an asterisk (*) for multiplication and a slash mark (/) for division.

4. Change the last part of the timer's Tick event handler so that it fills in the correct answer when time runs out.

     [!code-csharp[VbExpressTutorial3Step7#23](../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs#23)]
     [!code-vb[VbExpressTutorial3Step7#23](../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb#23)]

5. Save and run your program.

     Quiz takers must answer four problems to complete the quiz, as the following illustration shows.

     ![Math quiz with four problems](../ide/media/express-finishedquiz.png "Express_FinishedQuiz")
Math quiz with four problems

### To continue or review

- To go to the next tutorial step, see [Step 8: Customize the Quiz](../ide/step-8-customize-the-quiz.md).

- To return to the previous tutorial step, see [Step 6: Add a Subtraction Problem](../ide/step-6-add-a-subtraction-problem.md).
