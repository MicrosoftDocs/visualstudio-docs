---
title: "Step 7: Add Multiplication and Division Problems"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e638959e-f6a4-4eb4-b2e9-f63b7855cf8f
caps.latest.revision: 17
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Step 7: Add Multiplication and Division Problems
In the seventh part of this tutorial, you'll add multiplication and division problems, but first think about how to make that change. Consider the initial step, which involves storing values.  
  
### To add multiplication and division problems  
  
1.  Add four more integer variables to the form.  
  
     [!CODE [VbExpressTutorial3Step7#15](../CodeSnippet/VS_Snippets_VBCSharp/vbexpresstutorial3step7#15)]  
  
2.  As you did before, modify the `StartTheQuiz()` method to fill in random numbers for the multiplication and division problems.  
  
     [!CODE [VbExpressTutorial3Step7#16](../CodeSnippet/VS_Snippets_VBCSharp/vbexpresstutorial3step7#16)]  
  
3.  Modify the `CheckTheAnswer()` method so that it also checks the multiplication and division problems.  
  
     [!CODE [VbExpressTutorial3Step7#17](../CodeSnippet/VS_Snippets_VBCSharp/vbexpresstutorial3step7#17)]  
  
     You can't easily enter the multiplication sign (×) and the division sign (÷) using the keyboard, so Visual C# and Visual Basic accept an asterisk (*) for multiplication and a slash mark (/) for division.  
  
4.  Change the last part of the timer's Tick event handler so that it fills in the correct answer when time runs out.  
  
     [!CODE [VbExpressTutorial3Step7#23](../CodeSnippet/VS_Snippets_VBCSharp/vbexpresstutorial3step7#23)]  
  
5.  Save and run your program.  
  
     Quiz takers must answer four problems to complete the quiz, as the following illustration shows.  
  
     ![Math quiz with four problems](../VS_IDE/media/Express_FinishedQuiz.png "Express_FinishedQuiz")  
Math quiz with four problems  
  
### To continue or review  
  
-   To go to the next tutorial step, see [Step 8: Customize the Quiz](../VS_IDE/Step-8--Customize-the-Quiz.md).  
  
-   To return to the previous tutorial step, see [Step 6: Add a Subtraction Problem](../VS_IDE/Step-6--Add-a-Subtraction-Problem.md).