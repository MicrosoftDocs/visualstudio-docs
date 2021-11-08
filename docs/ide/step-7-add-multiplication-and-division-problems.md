---
title: "Step 7: Add multiplication and division problems"
description: Learn how to add multiplication and division problems.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: tutorial
dev_langs:
  - "CSharp"
  - "VB"
ms.assetid: e638959e-f6a4-4eb4-b2e9-f63b7855cf8f
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
  - "multiple"
---
# Step 7: Add multiplication and division problems

In the seventh part of this tutorial, you'll add multiplication and division problems, but first think about how to make that change. Consider the initial step, which involves storing values.

> [!NOTE]
> This topic is part of a tutorial series about basic coding concepts. For an overview of the tutorial, see [Tutorial 2: Create a timed math quiz](../ide/tutorial-2-create-a-timed-math-quiz.md).

## To add multiplication and division problems

1. Add four more integer variables to the form.

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb" id="Snippet15":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs" id="Snippet15":::

     [!INCLUDE [devlang-control-csharp-vb](./includes/devlang-control-csharp-vb.md)]

2. As you did before, modify the `StartTheQuiz()` method to fill in random numbers for the multiplication and division problems.

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb" id="Snippet16":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs" id="Snippet16":::

3. Modify the `CheckTheAnswer()` method so that it also checks the multiplication and division problems.

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb" id="Snippet17":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs" id="Snippet17":::

     You can't easily enter the multiplication sign (×) and the division sign (÷) using the keyboard, so C# and Visual Basic accept an asterisk (*) for multiplication and a slash mark (/) for division.

4. Change the last part of the timer's <xref:System.Windows.Forms.Timer.Tick> event handler so that it fills in the correct answer when time runs out.

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/vbexpresstutorial3step7/vb/form1.vb" id="Snippet23":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/vbexpresstutorial3step7/cs/form1.cs" id="Snippet23":::

5. Save and run your program.

     Quiz takers must answer four problems to complete the quiz, as the following illustration shows.

     ![Math quiz with four problems](../ide/media/express_finishedquiz.png)<br/>
***Math quiz*** *with four problems*

## To continue or review

- To go to the next tutorial step, see **[Step 8: Customize the quiz](../ide/step-8-customize-the-quiz.md)**.

- To return to the previous tutorial step, see [Step 6: Add a subtraction problem](../ide/step-6-add-a-subtraction-problem.md).
